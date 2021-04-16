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

namespace random_projectiles
{
    public class Main : MelonMod
    {

        static Random randomizer = new Random();

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("random_projectiles loaded");
        }

        static HashSet<string> projectiles = new HashSet<string>();
        static HashSet<string> towers = new HashSet<string>();

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            // Token: 0x060004FA RID: 1274 RVA: 0x0001940C File Offset: 0x0001760C
            [HarmonyPostfix]
            public static void Postfix()
            {
                foreach (var tower in Game.instance.model.towers)
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
                                        projectiles.Add(w.projectile.display);
                                }
                            }

                        }
                        catch
                        {

                        }
                        try
                        {
                            var dm = bev.Cast<DisplayModel>();
                            //Console.WriteLine(dm.display);
                            if (dm.display.Trim() != "")
                                towers.Add(dm.display);
                        }
                        catch
                        {

                        }
                    }


                }
                foreach (var p in projectiles)
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

                string[] asArray = randomizer.NextDouble() > 0.2 ? projectiles.ToArray() : towers.ToArray();
                __instance.projectile.projectileModel.display = asArray[randomizer.Next(asArray.Length)];


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