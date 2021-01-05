using MelonLoader;
using Harmony;
using NKHook6.Api;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using NKHook6;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
using Assets.Scripts.Unity.UI_New.Main;
using NKHook6.Api.Events;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using static NKHook6.Api.Events._Towers.TowerEvents;
using Assets.Scripts.Simulation.Towers;

using static NKHook6.Api.Events._Weapons.WeaponEvents;
using Assets.Scripts.Utils;

using static NKHook6.Api.Events._TimeManager.TimeManagerEvents;
using Il2CppSystem.Collections;
using NKHook6.Api.Events._Bloons;
using NKHook6.Api.Events._Weapons;
using Assets.Scripts.Unity.UI_New.Popups;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using TMPro;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Assets.Scripts.Simulation.Towers.Behaviors;

namespace depositmod
{
    public class Main : MelonMod
    {
        static float timer = -99999999f;


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            Logger.Log("depositmod loaded");
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
                            InGame.instance.addCash(-4750);
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
            }
        }



        //[EventAttribute("KeyPressEvent")]
        //public static void onEvent(KeyEvent e)
        //{

        //    string key = e.key + "";

        //    if (key == "F4")
        //    {

        //    }




        //}




    }

}