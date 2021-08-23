using MelonLoader;
using Harmony;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Scripts.Unity.UI_New.Main;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using Assets.Scripts.Simulation.Towers;

using Assets.Scripts.Utils;

using Il2CppSystem.Collections;
using Assets.Scripts.Unity.UI_New.Popups;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using TMPro;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Assets.Scripts.Simulation.Towers.Behaviors;
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using System.Linq;
using Assets.Main.Scenes;
using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Simulation.Towers.Pets;
using UnityEngine;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Bloons.Behaviors;
using BTD_Mod_Helper;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace btd6ai
{
    public class Main : BloonsTD6Mod
    {

        public static System.Random random = new System.Random();
        static List<string> allowedTowers = new List<string>()
        {
            //TowerType.NinjaMonkey + "-302",
            TowerType.BoomerangMonkey + "-024",
            TowerType.NinjaMonkey + "-402",
            TowerType.Alchemist + "-300",
            TowerType.BoomerangMonkey + "-402",
            TowerType.BombShooter + "-203",
            TowerType.BombShooter + "-204",
            TowerType.BombShooter + "-031",
            TowerType.GlueGunner + "-013",
            TowerType.WizardMonkey + "-032",
            TowerType.WizardMonkey + "-022",
            TowerType.WizardMonkey + "-024",
            TowerType.TackShooter + "-205",
            TowerType.HeliPilot + "-230",
            TowerType.SuperMonkey + "-203",
            TowerType.SniperMonkey + "-110",
            TowerType.SniperMonkey + "-025",
            TowerType.SniperMonkey + "-420",
            TowerType.SniperMonkey,
            TowerType.DartMonkey,
            TowerType.BombShooter,
            TowerType.Alchemist,
            TowerType.NinjaMonkey,
            //TowerType.MonkeySub + "-203",
        };

        static Dictionary<string, int> towersPlaced = new Dictionary<string, int>();
        static bool towerPlaced = false;
        static Il2CppSystem.Action<bool> action2 = (Il2CppSystem.Action<bool>)delegate (bool s)
        {
            //Console.WriteLine(s);
            towerPlaced = s;
        };
        static bool AIactive = false;
        static float timer = 0;
        static int selectedNet = 0;
        static List<NeuralNetwork> networks = new List<NeuralNetwork>();
        static int[] networkSize = new int[] { 13, 30, 30, 3 };
        static int networkCount = 20;

        static float MutationChance = 0.01f;

        static float MutationStrength = 0.5f;

        static string savePath = "Mods/Save.txt";

        public override void OnTitleScreen()
        {
            base.OnTitleScreen();
            Console.WriteLine("fixing costs");
            foreach (var tower in Game.instance.model.towers)
            {
                if (!tower.name.Contains("-")) continue;

                float cost = tower.cost;
                foreach (var up in tower.appliedUpgrades)
                {
                    cost += Game.instance.model.upgradesByName[up].cost;
                }
                tower.cost = cost;
                //Console.WriteLine(tower.name + " " + cost);
            }
        }

        static void resetTowerCount()
        {
            towersPlaced = new Dictionary<string, int>();
            foreach (var t in allowedTowers)
            {
                towersPlaced.Add(t, 0);
            }
        }

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("btd6ai loaded");

            //each tower gets its own output neuron, and an input to keep track of how many times it's been placed
            networkSize[0] += allowedTowers.Count;
            networkSize[3] += allowedTowers.Count;

            for (int i = 0; i < networkCount; i++)
            {
                //init the networks randomly
                networks.Add(new NeuralNetwork(networkSize));
            }
            resetTowerCount();

        }


        //WARNING: always uses medium mode prices and ignores MK
        static void spawnTower(float x, float y, string id)
        {

            int attempts = 0;
            while (!towerPlaced && attempts < 300)
            {

                try
                {

                    if (attempts > 2)
                    {
                        var x2 = x + ((float)random.NextDouble() - 0.5f) * 70f;
                        var y2 = y + ((float)random.NextDouble() - 0.5f) * 70f;
                        InGame.instance.bridge.CreateTowerAt(new UnityEngine.Vector2(x2, y2), Game.instance.model.GetTowerFromId(id), -1, 0, false, action2);
                        //Console.WriteLine("nudged");
                    }
                    else
                    {
                        InGame.instance.bridge.CreateTowerAt(new UnityEngine.Vector2(x, y), Game.instance.model.GetTowerFromId(id), -1, 0, false, action2);

                    }
                }
                catch// (System.Exception e2)
                {
                    //System.Console.WriteLine(e2 + "");

                }
                attempts++;
            }
            if (towerPlaced == true)
            {
                towersPlaced[id]++;
            }

            towerPlaced = false;
        }

        static bool restart = false;
        static int startNextRound = 99;
        static bool gameEnded = false;
        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (AIactive)
                {
                    timer += UnityEngine.Time.deltaTime;
                    if (timer > 20)
                    {
                        timer = 0;
                        Step();
                    }
                    //Console.WriteLine("Next decision in " + timer);
                }

                if (restart)
                {
                    InGame.instance.bridge.Restart();
                    startNextRound = 0;
                    timer = 5;
                    restart = false;
                    gameEnded = false;
                }
                startNextRound++;
                if (startNextRound == 100)
                {
                    InGame.instance.bridge.StartRound();
                }
                if (startNextRound == 120)
                {
                    InGame.instance.bridge.SetFastForward(true);
                }

                //Console.WriteLine(InGame.instance.bridge.GetCurrentRound() + ", " + (InGame.instance.bridge.GetEndRound() - 1));

                //victory
                if (InGame.instance.bridge.GetCurrentRound() == InGame.instance.bridge.GetEndRound() - 1)
                {
                    NextRound(true);
                }

                if (Input.GetKeyDown(KeyCode.F1))
                {

                    for (int i = 0; i < networkCount; i++)
                    {
                        networks[i].Load(savePath);
                    }
                    SortNetworks();
                    Console.WriteLine("loaded from file");
                }

                if (Input.GetKeyDown(KeyCode.F2))
                {

                    AIactive = !AIactive;
                    Console.WriteLine("active: " + AIactive);
                }

                if (Input.GetKeyDown(KeyCode.F3))
                {
                    Step();

                }
                if (Input.GetKeyDown(KeyCode.F4))
                {
                    selectedNet++;
                    Console.WriteLine(selectedNet);

                }

                //if (Input.GetKeyDown(KeyCode.F5))
                //{
                //    Console.WriteLine("restarting");
                //    InGame.instance.bridge.Restart();

                //}

                //if (Input.GetKeyDown(KeyCode.F6))
                //{
                //    Console.WriteLine("starting round");
                //    InGame.instance.bridge.StartRound();

                //}

            }
        }

        //take a number and convert it so it goes from -1 to 1 
        static float Convert(float v)
        {
            return (Mathf.Clamp(v, 0f, 1f) - 0.5f) * 2;
        }

        //runs the AI one time
        static void Step()
        {
            //collect inputs and give them to the AI
            int round = InGame.instance.bridge.GetCurrentRound();
            int roundcategory = Mathf.RoundToInt(round * 0.1f);
            float cash = (float)InGame.instance.bridge.simulation.cashManagers.entries[0].value.cash.Value;

            float[] input = new float[networkSize[0]];
            for (int i = 0; i <= 10; i++)
            {
                input[i] = roundcategory == i ? 1 : -1;
            }
            input[11] = Convert(cash / 20000f);
            input[12] = (float)(random.NextDouble() - 0.5f) * 2;
            int inpIndex = 13;
            foreach (var pair in towersPlaced)
            {
                //Console.WriteLine(pair.Value + ", " + Convert(pair.Value / 5f));
                input[inpIndex] = Convert(pair.Value / 5f);
                inpIndex++;
            }

            //Console.WriteLine(string.Join(", ", input));


            //collect the Ai's output and process them
            Console.WriteLine("getting output from network number " + selectedNet);
            float[] output = networks[selectedNet].FeedForward(input);


            bool shouldPlaceTower = output[0] > 0;
            Console.WriteLine("shouldPlaceTower: " + shouldPlaceTower + " (" + output[0] + ")");

            float x = output[1] * 70;
            float y = output[2] * 70;
            Console.WriteLine("x,y: " + x + ", " + y);

            string towerToPlace = ""; // allowedTowers[Mathf.RoundToInt(output[1] * (allowedTowers.Count - 1))];
            float max = -10;
            for (int i = 0; i < allowedTowers.Count; i++)
            {
                int index = i + 3;
                //place the tower the AI wants to place the most, but only if it has enough money, and if the tower has been placed less than 6 times, and if it actually really wants to place it
                if (output[index] > max && Game.instance.model.GetTowerWithName(allowedTowers[i]).cost <= cash && towersPlaced[allowedTowers[i]]<=5 && output[index] > 0.5)
                {
                    max = output[index];
                    towerToPlace = allowedTowers[i];
                }
            }
            Console.WriteLine("towerToPlace: " + towerToPlace);


            if (shouldPlaceTower && towerToPlace != "")
            {
                spawnTower(x, y, towerToPlace);
            }
        }


        static void NextRound(bool victory)
        {
            if (gameEnded == true) return;
            gameEnded = true;

            resetTowerCount();
            timer = 0;

            if (victory)
            {
                networks[selectedNet].fitness = 1000 + (float)InGame.instance.bridge.simulation.cashManagers.entries[0].value.cash.Value;
                Console.WriteLine("this network won, fitness is:" + networks[selectedNet].fitness);
            }
            else
            {
                networks[selectedNet].fitness = InGame.instance.bridge.GetCurrentRound();
                Console.WriteLine("this network lost, fitness is:" + networks[selectedNet].fitness);
            }
            selectedNet++;
            if (selectedNet >= networkCount)
            {
                SortNetworks();//create the next generation
                selectedNet = 0;
            }

            //this took ages to figure out, the game crashes if you restart too quickly and also crashes if you restart from another thread
            Il2CppSystem.Action action = (Il2CppSystem.Action)delegate ()
            {
                //Console.WriteLine("restarting soon");
                Thread.Sleep(200);
                Main.restart = true;

            };

            Task.Run(action);



        }




        static void SortNetworks()
        {

            //index 0 means the worst
            networks.Sort();
            networks[networkCount - 1].Save(savePath);//save best

            Console.WriteLine("networks finished one gen, scores:");
            for (int i = 0; i < networks.Count; i++)
            {
                Console.WriteLine(i + ": " + networks[i].fitness);
            }

            List<NeuralNetwork> networkstemp = new List<NeuralNetwork>();

            for (int i = 0; i < 4; i++)
                networkstemp.Add(networks[networkCount - 1].copy(new NeuralNetwork(networkSize)));

            for (int i = 0; i < 2; i++)
                networkstemp.Add(networks[networkCount - 2].copy(new NeuralNetwork(networkSize)));

            for (int i = 0; i < 2; i++)
                networkstemp.Add(networks[networkCount - 3].copy(new NeuralNetwork(networkSize)));

            for (int i = 0; i < 2; i++)
                networkstemp.Add(networks[networkCount - 4].copy(new NeuralNetwork(networkSize)));

            for (int i = 5; i < 15; i++)
                networkstemp.Add(networks[networkCount - i].copy(new NeuralNetwork(networkSize)));

            Console.WriteLine("created next gen with " + networkstemp.Count + " networks");

            networks = networkstemp;


            //mutate all except best
            for (int i = 0; i < networkCount - 1; i++)
            {
                //networks[i] = networks[i].copy(new NeuralNetwork(layers));
                networks[i].Mutate((int)(1 / MutationChance), MutationStrength);
            }

        }



        //doesn't work in challenge editor
        //public override void OnVictory()
        //{
        //    NextRound(true);
        //    base.OnVictory();
        //}

        public override void OnDefeat()
        {
            NextRound(false);
            base.OnDefeat();
        }

    }

}