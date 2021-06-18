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
using UnityEngine;

namespace depositmod
{
    public class Main : MelonMod
    {
        static float timer = -99999999f;


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("depositmod loaded");
        }

        [HarmonyPatch(typeof(Simulation), "OnRoundEnd")]
        class RoundEndHook
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                timer = 0;
            }
        }
        [HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        public class InitMap_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                timer = 0;
            }
        }

        void Deposit()
        {
            foreach (TowerToSimulation towerToSimulation in InGame.instance.bridge.GetAllTowers())
            {
                for (int i = 0; i < towerToSimulation.tower.towerBehaviors.Count; i++)
                {
                    var bev = towerToSimulation.tower.towerBehaviors[i];
                    try
                    {
                        Bank b = bev.Cast<Bank>();
                        if (b.Cash > 9000)
                        {
                            b.Collect();
                            b.DepositCash(4750);
                            InGame.instance.bridge.simulation.cashManagers.entries[0].value.cash.Value -= 4750;
                            InGame.instance.bridge.OnCashChangedSim();
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }


        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                timer += UnityEngine.Time.deltaTime;

                if (timer > 0.5f)
                {
                    Deposit();
                    timer = -99999999f;
                }
                //if (Input.GetKeyDown(KeyCode.F3))
                //{
                //    InGame.instance.bridge.simulation.cashManagers.entries[0].value.cash.Value-=100;
                //    InGame.instance.bridge.OnCashChangedSim();
                //}
                //if (Input.GetKeyDown(KeyCode.F4))
                //{
                //    InGame.Bridge.GameSimulation.SetCash(3, 0);
                //}
            }
        }







    }

}