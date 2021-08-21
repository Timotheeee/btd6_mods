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

namespace btd6ai
{
    public class Main : BloonsTD6Mod
    {

        public static System.Random random = new System.Random();
        static List<string> allowedTowers = new List<string>()
        {
            TowerType.NinjaMonkey + "-302",
            TowerType.BoomerangMonkey + "-024",
            TowerType.NinjaMonkey + "-402",
            TowerType.Alchemist + "-300",
            TowerType.BoomerangMonkey + "-402",
            TowerType.BombShooter + "-203",
            TowerType.BombShooter + "-204",
            TowerType.BombShooter + "-031",
            TowerType.GlueGunner + "-013",
            TowerType.WizardMonkey + "-032",
            TowerType.WizardMonkey + "-024",
            TowerType.TackShooter + "-205",
            TowerType.HeliPilot + "-230",
            TowerType.SuperMonkey + "-203",
            TowerType.SniperMonkey + "-200",
            TowerType.SniperMonkey + "-025",
            TowerType.SniperMonkey + "-420",
            TowerType.DartMonkey,
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

            foreach (var t in allowedTowers)
            {
                towersPlaced.Add(t, 0);
            }
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
            if(towerPlaced == true)
            {
                towersPlaced[id]++;
            }

            towerPlaced = false;
        }



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


            bool shouldPlaceTower = output[0] > 0f;
            Console.WriteLine("shouldPlaceTower: " + shouldPlaceTower + " (" + output[0] + ")");

            float x = output[1] * 100;
            float y = output[2] * 100;
            Console.WriteLine("x,y: " + x + ", " + y);

            string towerToPlace = ""; // allowedTowers[Mathf.RoundToInt(output[1] * (allowedTowers.Count - 1))];
            float max = -10;
            for (int i = 0; i < allowedTowers.Count; i++)
            {
                int index = i + 3;
                if (output[index] > max)
                {
                    max = output[index];
                    towerToPlace = allowedTowers[i];
                }
            }
            Console.WriteLine("towerToPlace: " + towerToPlace);


            if (shouldPlaceTower)
            {
                spawnTower(x, y, towerToPlace);
            }
        }






        //static List<TowerModel> allowedTowers_ = new List<TowerModel>();


        //[HarmonyPatch(typeof(TitleScreen), "Start")]
        //public class Awake_Patch
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix()
        //    {
        //        //allowedTowers.Add(Game.instance.model.GetTowerFromId("NinjaMonkey"));
        //        //allowedTowers.Add(Game.instance.model.GetTowerFromId("BombShooter"));
        //        allowedTowers.Add("NinjaMonkey");
        //        allowedTowers.Add("BombShooter");


        //var pos = InGame.instance.InputManager.cursorPositionWorld;
        //spawnTower(pos.x, pos.y, allowedTowers[0]);

        //    }
        //}




    }

}