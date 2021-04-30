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
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Simulation.Bloons;
using UnhollowerBaseLib;
using Assets.Scripts.Simulation.Towers.Projectiles;
using Assets.Scripts.Simulation.Towers;

namespace damage_numbers
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("damage_numbers loaded");
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
                    //if (tower.name.ToLower().Contains("helipilot")) continue;
                    //if (tower.name.ToLower().Contains("monkeyace")) continue;
                    //Console.WriteLine(tower.name);


                    try
                    {
                        foreach (var proj in tower.GetBehavior<AttackModel>().GetAllProjectiles())
                        {
                            if (proj.HasBehavior<ShowTextOnHitModel>())
                            {
                                proj.GetBehavior<ShowTextOnHitModel>().text = "";
                            }
                            else
                            {
                                proj.AddBehavior(new ShowTextOnHitModel("", "3dcdbc19136c60846ab944ada06695c0", 3f, false, ""));
                            }

                        }
                    }
                    catch
                    {
                        //Console.WriteLine(tower.name + " failed");
                    }





                }

            }
        }



        [HarmonyPatch(typeof(Bloon), "RecieveDamage")]
        public class lol
        {
            [HarmonyPrefix]
            public static void Prefix(Bloon __instance, float amount, Il2CppStringArray types, Projectile projectile, bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, Tower tower, bool blockSpawnChildren)
            {

                if (projectile != null)
                {
                    var proj = projectile.projectileModel;
                    if (proj.HasBehavior<ShowTextOnHitModel>() && proj.HasBehavior<DamageModel>())
                    {
                        proj.GetBehavior<ShowTextOnHitModel>().text = amount+"";
                    }
                    else
                    {
                        proj.AddBehavior(new ShowTextOnHitModel("", "3dcdbc19136c60846ab944ada06695c0", 3f, false, amount + ""));
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

            }
        }








    }

}