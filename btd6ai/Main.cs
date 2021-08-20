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

namespace btd6ai
{
    public class Main : MelonMod
    {

        public static System.Random random = new System.Random();
        static List<string> allowedTowers = new List<string>()
        {
            "NinjaMonkey",
            "BombShooter",
        };

        static bool towerPlaced = false;
        static Il2CppSystem.Action<bool> action2 = (Il2CppSystem.Action<bool>)delegate (bool s)
        {
            //Console.WriteLine(s);
            towerPlaced = s;
        };
        static bool AIactive = false;
        static float timer = 0;

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("btd6ai loaded");
        }



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
                    //var x2 = x;// + ((float)random.NextDouble() - 0.5f) * 200;
                    //var x2 = (float)random.NextDouble() * 200;
                    //var y = ((float)random.NextDouble() - 0.5f) * 200f;
                    //System.Console.WriteLine(x + " " + y);
                    //break;
                }
                catch// (System.Exception e2)
                {
                    //System.Console.WriteLine(e2 + "");

                }
                attempts++;
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
                    if(timer > 20)
                    {
                        timer = 0;
                        Step();
                    }
                    Console.WriteLine("Next decision in " + timer);
                }

                if (Input.GetKeyDown(KeyCode.F2))
                {
                    
                    AIactive = !AIactive;

                }

                if (Input.GetKeyDown(KeyCode.F3))
                {
                    Step();

                }
            }
        }

        //runs the AI one time
        static void Step()
        {
            //collect inputs and give them to the AI
            int round = InGame.instance.bridge.GetCurrentRound();
            int roundcategory = Mathf.RoundToInt(round * 0.1f);
            float cash = (float)InGame.instance.bridge.simulation.cashManagers.entries[0].value.cash.Value;

            float[] input = new float[6];
            input[0] = roundcategory == 0 ? 1 : 0;
            input[1] = roundcategory == 1 ? 1 : 0;
            input[2] = roundcategory == 2 ? 1 : 0;
            input[3] = roundcategory == 3 ? 1 : 0;
            input[4] = roundcategory == 4 ? 1 : 0;
            input[5] = Mathf.Clamp(cash / 700, 0, 1);
            //Console.WriteLine(string.Join(", ", input));

            //collect the Ai's output and process them
            float[] output = AI.getOutputTest(input);
            bool shouldPlaceTower = output[0] > 0.5f;
            string towerToPlace = allowedTowers[Mathf.RoundToInt(output[1])];
            float x = (output[2] - 0.5f) * 200;
            float y = (output[3] - 0.5f) * 200;

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