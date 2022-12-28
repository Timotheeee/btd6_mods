using MelonLoader;
using Harmony;

using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Il2CppAssets.Main.Scenes;
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
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles;
using Il2CppAssets.Scripts.Simulation.Towers;

[assembly: MelonInfo(typeof(damage_numbers.Main), damage_numbers.ModHelperData.Name, damage_numbers.ModHelperData.Version, damage_numbers.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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
            public static void Prefix(Bloon __instance, float amount, Projectile projectile, bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, Tower tower, bool blockSpawnChildren)
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