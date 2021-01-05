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



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            Logger.Log("depositmod loaded");
        }

        [HarmonyPatch(typeof(Simulation), "OnRoundEnd")]
        class RoundEndHook
        {
            [HarmonyPrefix]
            static bool Prefix()
            {
                foreach (TowerToSimulation towerToSimulation in InGame.instance.bridge.GetAllTowers())
                {
                    //if (towerToSimulation.GetBankAmount() > 0)
                    //{

                    //}
                    for (int i = 0; i < towerToSimulation.tower.towerBehaviors.Count; i++)
                    {
                        var bev = towerToSimulation.tower.towerBehaviors[i];
                        try
                        {
                            Bank b = bev.Cast<Bank>();
                            if (b.Cash > 9000)
                            {
                                b.Collect();
                                if(InGame.instance.getCash() > 4750)
                                {
                                    b.DepositCash(4750);
                                    InGame.instance.addCash(-4750);
                                }
                            }
                            //if (b.Cash < 500 && InGame.instance.bridge.GetCash()>4750)
                            //{
                            //    b.DepositCash(4750);
                            //    InGame.instance.bridge.AddCash(-4750, Simulation.CashSource.BankDeposit);
                            //}


                        }
                        catch
                        {

                        }
                    }
                }
                return true;
            }
        }


        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            { 
                
            }
        }



        [EventAttribute("KeyPressEvent")]
        public static void onEvent(KeyEvent e)
        {

            string key = e.key + "";

            if (key == "F4")
            {
                
            }




        }




    }

}