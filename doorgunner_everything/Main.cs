using MelonLoader;
using Harmony;

using Assets.Scripts.Unity.UI_New.InGame;

using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity;
using Assets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Assets.Main.Scenes;
using UnityEngine;
using System.Linq;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Simulation.Track;
using Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Simulation.Towers;

namespace doorgunner_everything
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("doorgunner_everything mod loaded");
        }



        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {



            }
        }

        static DoorGunnerInput dgi;
        static Deploy deploy;
        static Redeploy redeploy;
        static List<int> valid;

        [HarmonyPatch(typeof(DoorGunnerInput), "Init")]
        public class aaaa
        {
            [HarmonyPostfix]
            public static void Postfix(ref DoorGunnerInput __instance)
            {
                dgi = __instance;


            }
        }

        [HarmonyPatch(typeof(Deploy), "Initialise")]
        public class aaaasdfasda
        {
            [HarmonyPostfix]
            public static void Postfix(ref Deploy __instance)
            {
                deploy = __instance;


            }
        }

        [HarmonyPatch(typeof(Redeploy), "Initialise")]
        public class aaaasdfasdasaa
        {
            [HarmonyPostfix]
            public static void Postfix(ref Redeploy __instance)
            {
                redeploy = __instance;


            }
        }

        [HarmonyPatch(typeof(DoorGunner), "IsBanned")]
        public class aaaaa
        {
            [HarmonyPrefix]
            public static bool a(ref bool __result)
            {
                Console.WriteLine("IsBanned called");
                __result = false;
                return false;

            }
        }


        [HarmonyPatch(typeof(DoorGunner), "CanUseAbility")]
        public class CanUseAbilitya
        {
            [HarmonyPrefix]
            public static bool a(ref bool __result)
            {
                Console.WriteLine("CanUseAbility called");
                __result = true;
                return false;

            }
        }


        [HarmonyPatch(typeof(Deploy), "CanUseAbility")]
        public class CanUseAbilityd
        {
            [HarmonyPrefix]
            public static bool a(ref bool __result)
            {
                Console.WriteLine("CanUseAbility2 called");
                __result = true;
                return false;

            }
        }

        [HarmonyPatch(typeof(Redeploy), "CanUseAbility")]
        public class CanUseAbilityda
        {
            [HarmonyPrefix]
            public static bool a(ref bool __result)
            {
                Console.WriteLine("CanUseAbility3 called");
                __result = true;
                return false;

            }
        }

        static DoorGunner dg;
        Tower selected;

        [HarmonyPatch(typeof(DoorGunner), "Initialise")]
        public class aaaaaa
        {
            [HarmonyPostfix]
            public static void Postfix(ref DoorGunner __instance)
            {
                dg = __instance;


            }
        }


        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {


                Il2CppSystem.Collections.Generic.List<int> alltowersIDs = new Il2CppSystem.Collections.Generic.List<int>();
                foreach (var t in InGame.instance.GetTowers())
                {
                    alltowersIDs.Add(t.Id);
                }
                if (dgi?.data?.validTowerIds != null)
                    dgi.data.validTowerIds = alltowersIDs;

                if (Input.GetKeyDown(KeyCode.F6))
                {
                    selected = InGame.instance.inputManager.SelectedTower.tower;
                    Console.WriteLine("selected tower " + selected.Id + " as target");
                }
                if (dg != null)
                {
                    if (dg.targetTower != null)
                    {
                        dg.targetTower = selected;
                        //Console.WriteLine("changed targetTower to " + selected.Id);
                    }
                    if (dg.rData != null)
                    {
                        dg.rData.towerId = selected.Id;
                        //Console.WriteLine("changed rData.towerId to " + selected.Id);
                    }
                }
                if (deploy != null)
                {
                    if (deploy.rData != null)
                    {
                        deploy.rData.towerId = selected.Id;
                        //Console.WriteLine("changed deploy.rData.towerId to " + selected.Id);
                    }
                }



                Redeploy.towerBanList = new UnhollowerBaseLib.Il2CppStringArray(0);
                Redeploy.upgradeBanList = new Il2CppSystem.Collections.Generic.Dictionary<string, UnhollowerBaseLib.Il2CppStructArray<int>>();


                //if (Input.GetKeyDown(KeyCode.F7))
                //{
                //    Console.WriteLine(dgi == null);
                //    Console.WriteLine(dgi.data == null);
                //    Console.WriteLine(dgi.data.validTowerIds == null);
                //    var towers = dgi.data.validTowerIds;
                //    foreach (var t in towers)
                //    {
                //        Console.WriteLine(t);
                //    }

                //}
                //if (Input.GetKeyDown(KeyCode.F6))
                //{
                //    Console.WriteLine(dgi == null);
                //    Console.WriteLine(dgi.data == null);
                //    Console.WriteLine(dgi.data.validTowerIds == null);
                //    var towers = dgi.data.validTowerIds;
                //    foreach (var t in InGame.instance.GetTowers())
                //    {
                //        Console.WriteLine(t.Id);
                //    }
                //    foreach (var t in InGame.instance.GetAllTowerToSim())
                //    {
                //        Console.WriteLine(t.Id);
                //    }

                //}
            }
        }








    }

}