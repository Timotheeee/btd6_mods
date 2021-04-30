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


        static void makeSeeking(UnhollowerBaseLib.Il2CppReferenceArray<AttackModel> attacks,string name)
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