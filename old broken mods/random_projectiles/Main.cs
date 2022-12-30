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

[assembly: MelonInfo(typeof(random_projectiles.Main), random_projectiles.ModHelperData.Name, random_projectiles.ModHelperData.Version, random_projectiles.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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
                                    if (w.projectile != null && w.projectile.display.GUID.Trim() != "")
                                        projectiles.Add(w.projectile.display.GUID);
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
                            if (dm.display.GUID.Trim() != "")
                                towers.Add(dm.display.GUID);
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
                __instance.projectile.projectileModel.display = new PrefabReference(asArray[randomizer.Next(asArray.Length)]);


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