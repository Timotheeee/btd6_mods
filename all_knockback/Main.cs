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
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

[assembly: MelonInfo(typeof(all_knockback.Main), all_knockback.ModHelperData.Name, all_knockback.ModHelperData.Version, all_knockback.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace all_knockback
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("all_knockback loaded");
        }

        static KnockbackModel seeking;
        static string[] doesNotTargetBloons = new string[] { "TargetTrack", "TargetFriendly", "BrewTargetting", "RandomPosition", };


        static void makeSeeking(Il2CppReferenceArray<AttackModel> attacks, string name)
        {
            foreach (var attack in attacks)
            {
                if (!doesNotTargetBloons.Any(attack.name.Contains))
                {
                    foreach (var proj in attack.GetAllProjectiles())
                    {
                        if (proj.HasBehavior<KnockbackModel>()) continue;

                        //if (name.ToLower().Contains("boomerang"))
                        //{
                        //    //proj.RemoveBehavior<TrackTargetWithinTimeModel>();
                        //    proj.RemoveBehavior<FollowPathModel>();
                        //    proj.AddBehavior(new TravelStraitModel("lol", 175, 2));
                        //}
                        if (proj.HasBehavior<TravelStraitModel>())
                        {
                            proj.AddBehavior(seeking);

                            //Il2CppArrays are aids
                            Il2CppStructArray<int> a = new Il2CppStructArray<int>(proj.collisionPasses.Count+1);

                            for (int i = 0; i < proj.collisionPasses.Count; i++)
                            {
                                a[i + 1] = proj.collisionPasses[i];
                            }
                            a[0] = -1;

                            //List<int> list = new List<int>();
                            //list.Add(0);
                            //foreach (int item in proj.collisionPasses)
                            //{
                            //    list.Add(item);
                            //}

                            //UnhollowerBaseLib.Il2CppStructArray<int> a = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<int>(proj.collisionPasses.Count);

                            //if (!proj.collisionPasses.Contains(-1))
                            //    proj.collisionPasses = (UnhollowerBaseLib.Il2CppStructArray<int>)proj.collisionPasses.Add(-1);

                            //Console.WriteLine(proj.name + " collision passes: " + String.Join(",", proj.collisionPasses));

                            //proj.collisionPasses = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray<int>(2) { 0, 0 };
                            //proj.collisionPasses[0] = -1;

                            proj.collisionPasses=a;
                            //var k = new KnockbackModel("KnockbackModel_", 0.5f, 1.0f, 1.0f, 0.1f, "Knockback");
                            //Console.WriteLine(name);
                            //Console.WriteLine(k.collisionPass);
                            //k.collisionPass = 0;

                            //proj.AddBehavior(k);
                        }

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
                //seeking = Game.instance.model.GetTowerFromId("NinjaMonkey-001").GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<TrackTargetWithinTimeModel>().Duplicate();
                seeking = Game.instance.model.GetTowerFromId("SuperMonkey-001").GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<KnockbackModel>().Duplicate();


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
                //FileIOUtil.SaveObject("s.json", Game.instance.model.GetTowerFromId("SuperMonkey"));

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