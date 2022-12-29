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
using Il2CppInterop.Runtime.InteropTypes.Arrays;

[assembly: MelonInfo(typeof(all_seeking.Main), all_seeking.ModHelperData.Name, all_seeking.ModHelperData.Version, all_seeking.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace all_seeking
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("all_seeking loaded");
        }

        static TrackTargetWithinTimeModel seeking;
        static string[] doesNotTargetBloons = new string[] { "TargetTrack", "TargetFriendly", "BrewTargetting", "RandomPosition", };


        static void makeSeeking(Il2CppReferenceArray<AttackModel> attacks,string name)
        {
            foreach (var attack in attacks)
            {
                if (!doesNotTargetBloons.Any(attack.name.Contains))
                {
                    foreach (var proj in attack.GetAllProjectiles())
                    {
                        if (proj.HasBehavior<ArriveAtTargetModel>()) continue;

                        if (name.ToLower().Contains("boomerang"))
                        {
                            //proj.RemoveBehavior<TrackTargetWithinTimeModel>();
                            proj.RemoveBehavior<FollowPathModel>();
                            proj.AddBehavior(new TravelStraitModel("lol", 175, 2));
                        }
                        if (proj.HasBehavior<TravelStraitModel>())
                            proj.AddBehavior(seeking);
                    }

                }

            }
        }



        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                var models = Game.instance.model.towers;
                seeking = Game.instance.model.GetTowerFromId("NinjaMonkey-001").GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<TrackTargetWithinTimeModel>().Duplicate();
                

                for (int i = 0; i < models.Count; i++)
                {
                    var tower = models[i];
                    if (tower.name.ToLower().Contains("icemonkey")) continue;
                    if (tower.name.ToLower().Contains("sniper")) continue;
                    if (tower.name.ToLower().Contains("mortar")) continue;
                    if (tower.name.ToLower().Contains("spike")) continue;


                    //Console.WriteLine(tower.name);
                    try
                    {
                        makeSeeking(tower.GetBehaviors<AttackModel>().ToIl2CppReferenceArray(), tower.name);
                        
                        foreach (var abilities in tower.GetBehaviors<AbilityModel>())
                        {
                            foreach (var att1 in abilities.GetBehaviors<ActivateAttackModel>())
                            {
                                makeSeeking(att1.attacks, tower.name);
                            }
                        }
                    }
                    catch { }

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