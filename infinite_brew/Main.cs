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
using BloonsTD6_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Simulation.Track;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Simulation.Towers;
using UnhollowerBaseLib;

namespace infinite_brew
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("infinite_brew loaded");
        }



        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                var models = Game.instance.model.towers;


                for (int i = 0; i < models.Count; i++)
                {
                    var tower = models[i];



                    if (Regex.IsMatch(tower.name, "Alchemist-3..") || Regex.IsMatch(tower.name, "Alchemist-4.."))
                    {
                        foreach (var at in tower.GetBehaviors<AttackModel>())
                        {
                            try
                            {
                                at.weapons[0].projectile.GetBehavior<AddBerserkerBrewToProjectileModel>().cap = 999999;
                                at.weapons[0].projectile.GetBehavior<AddBerserkerBrewToProjectileModel>().towerBehaviors[0].Cast<BerserkerBrewCheckModel>().maxCount = 999999;
                            } catch
                            {

                            }
                        }


                    }


                }

            }
        }

        //[HarmonyPatch(typeof(Spawner), "OnRoundEndProjectiles")]
        //public class OnRoundEndProjectiles_Patch
        //{

        //    [HarmonyPrefix]
        //    public static bool Prefix()
        //    {

        //        return false;
        //    }
        //}

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