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

using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using System.Linq;
using Il2CppAssets.Main.Scenes;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles;

[assembly: MelonInfo(typeof(inf_lifespan.Main), inf_lifespan.ModHelperData.Name, inf_lifespan.ModHelperData.Version, inf_lifespan.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace inf_lifespan
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("inf_lifespan loaded");
        }


        //[HarmonyPatch(typeof(TitleScreen), "Start")]
        //public class Awake_Patch
        //{
        //    // Token: 0x060004FA RID: 1274 RVA: 0x0001940C File Offset: 0x0001760C
        //    [HarmonyPostfix]
        //    public static void Postfix()
        //    {
        //        foreach (var tower in Game.instance.getAllTowerModels())
        //        {
        //            foreach (var bev in tower.behaviors)
        //            {
        //                try
        //                {
        //                    var at = bev.Cast<AttackModel>();
        //                    if (at.weapons != null)
        //                    {
        //                        foreach (var w in at.weapons)
        //                        {
        //                            if (w.projectile != null && w.projectile.display.Trim() != "")
        //                                projectiles.Add(w.projectile.display);
        //                        }
        //                    }

        //                }
        //                catch
        //                {

        //                }
        //                try
        //                {
        //                    var dm = bev.Cast<DisplayModel>();
        //                    //Console.WriteLine(dm.display);
        //                    if (dm.display.Trim() != "")
        //                        towers.Add(dm.display);
        //                }
        //                catch
        //                {

        //                }
        //            }


        //        }
        //        foreach (var p in projectiles)
        //        {
        //            //Console.WriteLine(p);
        //        }


        //    }
        //}

        //[HarmonyPatch(typeof(Projectile), "Expire")]
        //internal class Expire_Patch
        //{
        //    [HarmonyPrefix]
        //    public static bool Prefix()
        //    {
        //        return false;
        //    }
        //}

        //[HarmonyPatch(typeof(Projectile), "Expired")]
        //internal class Expired_Patch
        //{
        //    [HarmonyPrefix]
        //    public static bool Prefix()
        //    {
        //        return false;
        //    }
        //}

        [HarmonyPatch(typeof(TravelStrait), "Initialise")]
        internal class TravelStrait_Patch
        {

            [HarmonyPostfix]
            internal static void Postfix(ref TravelStrait __instance)
            {
                __instance.travelStraitModel.lifespan = 300;
                __instance.travelStraitModel.Lifespan = 300;
                __instance.travelStraitModel.lifespanFrames = 300;


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








    }

}