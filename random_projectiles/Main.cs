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
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using System.Linq;
using Assets.Main.Scenes;

namespace random_projectiles
{
    public class Main : MelonMod
    {

        static Random randomizer = new Random();

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            Logger.Log("random_projectiles loaded");
        }

        static HashSet<string> proj = new HashSet<string>();

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            // Token: 0x060004FA RID: 1274 RVA: 0x0001940C File Offset: 0x0001760C
            [HarmonyPostfix]
            public static void Postfix()
            {
                foreach (var tower in Game.instance.getAllTowerModels())
                {
                    foreach (var bev in tower.behaviors)
                    {
                        try
                        {
                            var at = bev.Cast<AttackModel>();
                            if (at.weapons != null)
                            {
                                foreach (var w in at.weapons)
                                {
                                    if (w.projectile != null && w.projectile.display.Trim() != "")
                                        proj.Add(w.projectile.display);
                                }
                            }

                        }
                        catch
                        {

                        }
                    }


                }
                foreach (var p in proj)
                {
                    //Console.WriteLine(p);
                }


            }
        }


        [HarmonyPatch(typeof(TravelStrait), "Initialise")]
        internal class TravelStrait_Patch
        {

            [HarmonyPostfix]
            internal static void Postfix(ref TravelStrait __instance)
            {
                
                string[] asArray = proj.ToArray();
                string randomLine = asArray[randomizer.Next(asArray.Length)];

                //Console.WriteLine(__instance.projectile.projectileModel.display);
                __instance.projectile.projectileModel.display = randomLine;
                //Console.WriteLine(__instance.projectile.projectileModel.display);

                //if (__instance.projectile.projectileModel.display == "3c27c2e53b36c6346a6dd2766052c9e5")
                //{

                //}

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