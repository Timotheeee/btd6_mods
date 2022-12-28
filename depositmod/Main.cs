using MelonLoader;
using Harmony;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.Races;
using Il2CppAssets.Scripts.Simulation.Towers.Weapons;
using Il2CppAssets.Scripts.Simulation;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppAssets.Scripts.Unity.UI_New.Main;
using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppAssets.Scripts.Models.Towers;

using Il2CppAssets.Scripts.Unity;



using Il2CppAssets.Scripts.Simulation.Towers;

using Il2CppAssets.Scripts.Utils;

using Il2CppSystem.Collections;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Simulation.Objects;
using Il2CppAssets.Scripts.Models;
using TMPro;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using UnityEngine;

[assembly: MelonInfo(typeof(depositmod.Main), depositmod.ModHelperData.Name, depositmod.ModHelperData.Version, depositmod.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace depositmod
{
    public class Main : MelonMod
    {
        static float timer = 0;


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("depositmod loaded");
        }

        //[HarmonyPatch(typeof(Simulation), "OnRoundEnd")]
        //class RoundEndHook
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix()
        //    {
        //        timer = 0;
        //    }
        //}
        //[HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        //public class InitMap_Patch
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix()
        //    {
        //        timer = 0;
        //    }
        //}

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
                            //b.DepositCash(4750);
                            //InGame.instance.bridge.simulation.cashManagers.entries[0].value.cash.Value -= 4750;
                            //InGame.instance.bridge.OnCashChangedSim();
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
                if (timer > 1)
                {
                    timer = 0;
                    Deposit();
                }

                //timer += UnityEngine.Time.deltaTime;

                //if (timer > 0.5f)
                //{
                //    Deposit();
                //    timer = -99999999f;
                //}



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