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
            TowerType.NinjaMonkey + "-302",
            TowerType.Druid + "-220",
            TowerType.BoomerangMonkey + "-024",
            TowerType.BoomerangMonkey + "-052",
            TowerType.NinjaMonkey + "-402",
            TowerType.NinjaMonkey + "-204",
            TowerType.NinjaMonkey + "-040",
            TowerType.Alchemist + "-300",
            TowerType.BoomerangMonkey + "-402",
            TowerType.BoomerangMonkey + "-302",
            TowerType.BoomerangMonkey + "-502",
            TowerType.BombShooter + "-203",
            TowerType.BombShooter + "-204",
            TowerType.BombShooter + "-031",
            TowerType.GlueGunner + "-210",
            TowerType.WizardMonkey + "-032",
            TowerType.WizardMonkey + "-022",
            TowerType.WizardMonkey + "-024",
            TowerType.WizardMonkey + "-025",
            TowerType.WizardMonkey + "-003",
            TowerType.IceMonkey + "-024",
            TowerType.IceMonkey + "-205",
            TowerType.TackShooter + "-205",
            TowerType.TackShooter + "-204",
            //TowerType.HeliPilot + "-230",
            TowerType.SuperMonkey + "-203",
            TowerType.SuperMonkey + "-201",
            TowerType.SniperMonkey + "-110",
            //TowerType.SniperMonkey + "-025",
            //TowerType.SniperMonkey + "-420",
            TowerType.SpikeFactory + "-320",
            TowerType.SpikeFactory + "-205",
            TowerType.SpikeFactory + "-240",
            TowerType.MonkeyVillage + "-210",
            TowerType.MonkeyAce + "-520",
            TowerType.SniperMonkey,
            TowerType.DartMonkey,
            //TowerType.BombShooter,
            TowerType.Alchemist,
            TowerType.NinjaMonkey,
            TowerType.Sauda,
            TowerType.IceMonkey,
            TowerType.TackShooter,
            TowerType.EngineerMonkey,
            TowerType.SpikeFactory,
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
        static int generation = 1;
        static int selectedNet = 0;
        static List<NeuralNetwork> networks = new List<NeuralNetwork>();
        static int initialOutputSize = 14;
        static int[] networkSize = new int[] { 11, 30, 50, initialOutputSize };//gets increased below
        static int networkCount = 15;
        //static float mapXsize = 290;
        //static float mapYsize = 230;
        static float tileXsize = 60;
        static float tileYsize = 45;
        static (string, float, float) nextAction = ("", 0, 0);

        static float MutationChance = 0.01f;

        static float MutationStrength = 0.5f;

        static string savePath = "Mods/btd6AI/";

        static float getCash()
        {
            return (float)InGame.instance.bridge.simulation.cashManagers.entries[0].value.cash.Value;
        }

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
            //networkSize[0] += allowedTowers.Count;
            networkSize[3] += allowedTowers.Count;

            for (int i = 0; i < networkCount; i++)
            {
                //init the networks randomly
                networks.Add(new NeuralNetwork(networkSize));
            }
            resetTowerCount();

        }
        static void useAllAbilities()
        {
            foreach (var ab in InGame.instance.bridge.GetAllAbilities(false))
            {
                try
                {
                    ab.Activate();
                }
                catch { }
            }
        }

        //WARNING: always uses medium mode prices and ignores MK
        static void spawnTower(float x, float y, string id)
        {
            TowerModel t = Game.instance.model.GetTowerFromId(id);
            if (t.cost > getCash()) return;


            int attempts = 0;
            while (!towerPlaced && attempts < 300)
            {

                try
                {

                    if (attempts > 2)
                    {
                        float expensiveMultiplier = t.cost > 10000 && attempts > 150 ? 2 : 1;
                        var x2 = x + ((float)random.NextDouble() - 0.5f) * 2 * tileXsize * expensiveMultiplier;
                        var y2 = y + ((float)random.NextDouble() - 0.5f) * 2 * tileYsize * expensiveMultiplier;
                        InGame.instance.bridge.CreateTowerAt(new UnityEngine.Vector2(x2, y2), t, -1, 0, false, action2);
                        //Console.WriteLine("nudged");
                    }
                    else
                    {
                        InGame.instance.bridge.CreateTowerAt(new UnityEngine.Vector2(x, y), t, -1, 0, false, action2);

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
        static float abilityTimer = 0;
        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (AIactive)
                {
                    abilityTimer += UnityEngine.Time.deltaTime;
                    if (abilityTimer > 10)
                    {
                        abilityTimer = 0;
                        useAllAbilities();
                    }
                    if (nextAction.Item1 != "")
                    {
                        float cost = Game.instance.model.GetTowerWithName(nextAction.Item1).cost;
                        //Console.WriteLine("saving up to buy " + nextAction.Item1 + " (costs " + cost + ")");
                        if (cost <= getCash())
                        {
                            spawnTower(nextAction.Item2, nextAction.Item3, nextAction.Item1);
                            nextAction.Item1 = "";
                        }
                    }
                    if (nextAction.Item1 == "")
                    {
                        Step();
                    }

                }

                if (restart)
                {
                    InGame.instance.bridge.Restart();
                    startNextRound = 0;
                    restart = false;
                    gameEnded = false;
                    nextAction.Item1 = "";
                }
                startNextRound++;
                if (startNextRound == 200)
                {
                    InGame.instance.bridge.StartRound();
                }
                if (startNextRound == 220)
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
                        networks[i].Load(savePath + "Save" + i + ".txt");
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
                //if (Input.GetKeyDown(KeyCode.F4))
                //{
                //    selectedNet++;
                //    Console.WriteLine(selectedNet);

                //}

                //if (Input.GetKeyDown(KeyCode.F5))
                //{
                //    Console.WriteLine("restarting");
                //    InGame.instance.bridge.Restart();

                //}

                if (Input.GetKeyDown(KeyCode.F6))
                {
                    Console.WriteLine("calling abilities");
                    useAllAbilities();

                }

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
            //********** collect inputs and give them to the AI **************
            int round = InGame.instance.bridge.GetCurrentRound();
            int roundcategory = Mathf.RoundToInt(round * 0.1f);
            //float cash = getCash();

            float[] input = new float[networkSize[0]];
            for (int i = 0; i <= 10; i++)
            {
                input[i] = roundcategory == i ? 1 : -1;
            }
            //input[11] = Convert(cash / 20000f);
            //input[11] = (float)(random.NextDouble() - 0.5f) * 2;


            //int inpIndex = 13;
            //foreach (var pair in towersPlaced)
            //{
            //    input[inpIndex] = Convert(pair.Value / 5f);
            //    inpIndex++;
            //}

            Console.WriteLine(string.Join(", ", input));


            /*
             *  collect the Ai's output and process them 
             *  
             */

            float[] output = networks[selectedNet].FeedForward(input);


            //the map is 210x210 and is divided into 9 tiles, we take the Ai's favorite one
            float max = -10;
            int selectedTile = -1;
            for (int i = 0; i < 9; i++)
            {
                if (output[i] > max)
                {
                    max = output[i];
                    selectedTile = i;
                }
            }

            float x = ((selectedTile % 3) - 1) * tileXsize;
            float y = (Mathf.FloorToInt(selectedTile / 3f) - 1) * tileYsize;
            //Console.WriteLine("selected tile: " + selectedTile + ", " + "x & y: " + x + ", " + y);

            //the range's id, and the value the ai gave it
            List<(int, float)> ranges = new List<(int, float)>();
            //Console.WriteLine("init ranges");
            //max = -10;

            for (int i = 9; i < initialOutputSize; i++)
            {
                ranges.Add((i - 9, output[i]));
                //if (output[i] > max)
                //{
                //    max = output[i];
                //    selectedPriceRange = i - 9;
                //}
            }
            ranges.Sort(delegate ((int, float) a, (int, float) b)
            {
                return a.Item2 < b.Item2 ? 1 : -1;
            });
            //Console.WriteLine("ordered");
            for (int i = 0; i < ranges.Count; i++)
            {
                Console.WriteLine(ranges[i].Item1 + ": " + ranges[i].Item2);
            }

            //select the tower
            string towerToPlace = "";
            for (int rangeIndex = 0; rangeIndex < 3; rangeIndex++)
            {
                int selectedPriceRange = ranges[rangeIndex].Item1;
                max = -10;
                for (int i = 0; i < allowedTowers.Count; i++)
                {
                    int index = i + initialOutputSize;
                    //check the price range
                    bool correctPriceRange = false;
                    var cost = Game.instance.model.GetTowerWithName(allowedTowers[i]).cost;
                    if (selectedPriceRange == 0) { correctPriceRange = cost < 650; }
                    if (selectedPriceRange == 1) { correctPriceRange = cost > 650 && cost < 5000; }
                    if (selectedPriceRange == 2) { correctPriceRange = cost > 5000 && cost < 10000; }
                    if (selectedPriceRange == 3) { correctPriceRange = cost > 10000 && cost < 20000; }
                    if (selectedPriceRange == 4) { correctPriceRange = cost > 20000; }

                    //queue the tower the AI wants to place the most, within the price range, with a limit of 4 per tower
                    if (correctPriceRange && output[index] > max && towersPlaced[allowedTowers[i]] <= 3 && output[index] > 0.5 && !((allowedTowers[i].Contains("5") || allowedTowers[i] == TowerType.Sauda) && towersPlaced[allowedTowers[i]] == 1))
                    {
                        max = output[index];
                        towerToPlace = allowedTowers[i];
                    }
                }
                if (towerToPlace != "") break;
            }

            nextAction = (towerToPlace, x, y);
            Console.WriteLine("network " + selectedNet + " (gen " + generation + ") towerToPlace: " + towerToPlace);


        }


        static void NextRound(bool victory)
        {
            if (gameEnded == true) return;
            gameEnded = true;

            resetTowerCount();

            if (victory)
            {
                networks[selectedNet].fitness = 1000 + getCash();
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
                generation++;
            }

            //this took ages to figure out, the game crashes if you restart too quickly and also crashes if you restart from another thread
            Il2CppSystem.Action action = (Il2CppSystem.Action)delegate ()
            {
                //Console.WriteLine("restarting soon");
                Thread.Sleep(1000);
                Main.restart = true;

            };

            Task.Run(action);



        }




        static void SortNetworks()
        {

            //index 0 means the worst
            networks.Sort();


            Console.WriteLine("networks finished one gen, scores:");
            for (int i = 0; i < networks.Count; i++)
            {
                Console.WriteLine(i + ": " + networks[i].fitness);
            }

            List<NeuralNetwork> networkstemp = new List<NeuralNetwork>();

            for (int i = 0; i < 3; i++)
                networkstemp.Add(networks[networkCount - 1].copy(new NeuralNetwork(networkSize)));

            for (int i = 0; i < 2; i++)
                networkstemp.Add(networks[networkCount - 2].copy(new NeuralNetwork(networkSize)));

            //for (int i = 0; i < 1; i++)
            //    networkstemp.Add(networks[networkCount - 3].copy(new NeuralNetwork(networkSize)));

            //for (int i = 0; i < 1; i++)
            //    networkstemp.Add(networks[networkCount - 4].copy(new NeuralNetwork(networkSize)));

            for (int i = 3; i < 13; i++)
                networkstemp.Add(networks[networkCount - i].copy(new NeuralNetwork(networkSize)));

            Console.WriteLine("created next gen with " + networkstemp.Count + " networks");

            networks = networkstemp;


            //mutate all except best
            for (int i = 0; i < networkCount - 1; i++)
            {
                //networks[i] = networks[i].copy(new NeuralNetwork(layers));
                networks[i].Mutate((int)(1 / MutationChance), MutationStrength);
            }

            for (int i = 0; i < networkCount; i++)
            {
                networks[i].Save(savePath + "Save" + i + ".txt");//save best
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