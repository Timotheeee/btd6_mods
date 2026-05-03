using MelonLoader;
using Harmony;

using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Il2CppAssets.Scripts.Unity.Scenes;
using UnityEngine;
using System.Linq;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Track;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers;

[assembly: MelonInfo(typeof(doorgunner_everything.Main), doorgunner_everything.ModHelperData.Name, doorgunner_everything.ModHelperData.Version, doorgunner_everything.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace doorgunner_everything
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            
            Console.WriteLine("doorgunner_everything mod loaded");
        }



        [HarmonyLib.HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyLib.HarmonyPostfix]
            public static void Postfix()
            {



            }
        }

        static DoorGunnerInput dgi;
        static Deploy deploy;
        static Redeploy redeploy;
        static List<int> valid;

        [HarmonyLib.HarmonyPatch(typeof(DoorGunnerInput), "Init")]
        public class aaaa
        {
            [HarmonyLib.HarmonyPostfix]
            public static void Postfix(ref DoorGunnerInput __instance)
            {
                dgi = __instance;


            }
        }

        [HarmonyLib.HarmonyPatch(typeof(Deploy), "Initialise")]
        public class aaaasdfasda
        {
            [HarmonyLib.HarmonyPostfix]
            public static void Postfix(ref Deploy __instance)
            {
                deploy = __instance;


            }
        }

        [HarmonyLib.HarmonyPatch(typeof(Redeploy), "Initialise")]
        public class aaaasdfasdasaa
        {
            [HarmonyLib.HarmonyPostfix]
            public static void Postfix(ref Redeploy __instance)
            {
                redeploy = __instance;


            }
        }

        [HarmonyLib.HarmonyPatch(typeof(DoorGunner), "IsBanned")]
        public class aaaaa
        {
            [HarmonyLib.HarmonyPrefix]
            public static bool a(ref bool __result)
            {
                Console.WriteLine("IsBanned called");
                __result = false;
                return false;

            }
        }


        [HarmonyLib.HarmonyPatch(typeof(DoorGunner), "CanUseAbility")]
        public class CanUseAbilitya
        {
            [HarmonyLib.HarmonyPrefix]
            public static bool a(ref bool __result)
            {
                Console.WriteLine("CanUseAbility called");
                __result = true;
                return false;

            }
        }


        [HarmonyLib.HarmonyPatch(typeof(Deploy), "CanUseAbility")]
        public class CanUseAbilityd
        {
            [HarmonyLib.HarmonyPrefix]
            public static bool a(ref bool __result)
            {
                Console.WriteLine("CanUseAbility2 called");
                __result = true;
                return false;

            }
        }

        [HarmonyLib.HarmonyPatch(typeof(Redeploy), "CanUseAbility")]
        public class CanUseAbilityda
        {
            [HarmonyLib.HarmonyPrefix]
            public static bool a(ref bool __result)
            {
                Console.WriteLine("CanUseAbility3 called");
                __result = true;
                return false;

            }
        }

        static DoorGunner dg;
        Tower selected;

        [HarmonyLib.HarmonyPatch(typeof(DoorGunner), "Initialise")]
        public class aaaaaa
        {
            [HarmonyLib.HarmonyPostfix]
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



                Redeploy.towerBanList = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStringArray(0);
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