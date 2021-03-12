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
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.GenericBehaviors;

namespace all_spike_factory
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("all_spike_factory loaded");
        }

        static TowerModel baseSpac;





        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                var models = Game.instance.model.towers;
                baseSpac = Game.instance.model.GetTowerFromId("SpikeFactory");


                for (int i = 0; i < models.Count; i++)
                {
                    var tower = models[i];
                    if (tower.name.ToLower().Contains("helipilot")) continue;
                    if (tower.name.ToLower().Contains("monkeyace")) continue;
                    //Console.WriteLine(tower.name);


                    try
                    {
                        if (tower.HasBehavior<AttackModel>())// && tower.GetBehavior<AttackModel>().weapons[0].projectile.HasBehavior<TravelStraitModel>()
                        {
                            var baseSpacAttackClone = baseSpac.GetBehavior<AttackModel>().Duplicate();
                            //baseSpacAttackClone.weapons[0].projectile.RemoveBehavior<DamageModel>();
                            bool hasProjectiles = false;

                            foreach (var proj in tower.GetBehavior<AttackModel>().GetAllProjectiles())
                            {
                                if (proj.HasBehavior<TravelStraitModel>() || tower.name.ToLower().Contains("boomer"))
                                {
                                    hasProjectiles = true;

                                }
                            }
                            if (hasProjectiles)
                            {
                                var oldAttack = tower.GetBehavior<AttackModel>().Duplicate();
                                baseSpacAttackClone.range = oldAttack.range;

                                foreach (var proj in tower.GetBehavior<AttackModel>().GetAllProjectiles())
                                {
                                    if (proj.HasBehavior<TravelStraitModel>() || tower.name.ToLower().Contains("boomer"))
                                    {
                                        //baseSpacAttackClone.weapons[0].projectile.AddBehavior(proj.GetBehavior<DamageModel>());
                                        baseSpacAttackClone.weapons[0].Rate = oldAttack.weapons[0].Rate;
                                        //baseSpacAttackClone.weapons[0].projectile.GetBehavior<SetSpriteFromPierceModel>().sprites = new UnhollowerBaseLib.Il2CppStringArray(8) { proj.GetBehavior<DisplayModel>().display, proj.GetBehavior<DisplayModel>().display, proj.GetBehavior<DisplayModel>().display, proj.GetBehavior<DisplayModel>().display, proj.GetBehavior<DisplayModel>().display, proj.GetBehavior<DisplayModel>().display, proj.GetBehavior<DisplayModel>().display, proj.GetBehavior<DisplayModel>().display };
                                        //baseSpacAttackClone.weapons[0].projectile.RemoveBehavior<SetSpriteFromPierceModel>();
                                        //baseSpacAttackClone.weapons[0].projectile.GetBehavior<DisplayModel>().display = proj.GetBehavior<DisplayModel>().display;
                                        if (proj.HasBehavior<DamageModel>())
                                        {
                                            baseSpacAttackClone.weapons[0].projectile.GetBehavior<DamageModel>().damage = proj.GetBehavior<DamageModel>().damage;
                                            baseSpacAttackClone.weapons[0].projectile.GetBehavior<DamageModel>().damageTypes = proj.GetBehavior<DamageModel>().damageTypes;
                                        } 
                                        //else if (proj.HasBehavior<CreateProjectileOnContactModel>())
                                        //{
                                        //    baseSpacAttackClone.weapons[0].projectile.RemoveBehavior<DamageModel>();

                                        //}

                                        
                                        baseSpacAttackClone.weapons[0].projectile.pierce = proj.pierce;
                                        baseSpacAttackClone.weapons[0].projectile.maxPierce = proj.maxPierce;
                                        break;
                                    }
                                }
                                tower.RemoveBehavior<AttackModel>();
                                tower.AddBehavior(baseSpacAttackClone);
                                tower.TargetTypes = baseSpac.TargetTypes.Duplicate();
                            }




                        }
                    }
                    catch
                    {
                        Console.WriteLine(tower.name + " failed");
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