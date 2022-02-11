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
using UnityEngine;
using BloonsTD6_Mod_Helper.Extensions;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Main.Scenes;
using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;

namespace random_stats
{
    public class Main : MelonMod
    {

        static System.Random r = new System.Random();

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("random_stats loaded.");
        }

        static float damageMult;
        static float rangeMult;
        //static float priceMult;
        static float abilityMult;
        static float rateMult;

        static double Randomize()
        {

            double temp = r.NextDouble() > 0.5f ? (r.NextDouble() + 1) : (1 - (r.NextDouble() * 0.5d));
            return temp*temp;
        }

        static void RandomizeAll()
        {
            damageMult = (float)Randomize();
            rangeMult = (float)Randomize();
            //priceMult = (float)Randomize();
            abilityMult = (float)Randomize();
            rateMult = (float)Randomize();
        }


        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                double productSum = 0;
                while(productSum<0.7f || productSum > 0.9f)
                {
                    RandomizeAll();
                    //productSum = damageMult * rangeMult * priceMult * abilityMult * rateMult;
                    productSum = damageMult * rangeMult * abilityMult * rateMult;
                }
                Console.WriteLine("randomizing damage with multiplier " + damageMult);

                Console.WriteLine("randomizing range with multiplier " + rangeMult);
                foreach (var tower in Game.instance.model.towers)
                {
                    tower.range *= rangeMult;
                    foreach (var bev in tower.behaviors)
                    {
                        try
                        {
                            bev.Cast<AttackModel>().range *= rangeMult;
                        }
                        catch
                        {

                        }
                    }

                }
                //Console.WriteLine("randomizing price with multiplier " + priceMult);
                //foreach (var tower in Game.instance.model.towers)
                //{
                //    foreach (TowerModel towerModel in Game.instance.model.towers)
                //    {
                //        towerModel.cost *= priceMult;
                //    }
                //    foreach (UpgradeModel upgradeModel in Game.instance.model.upgrades)
                //    {
                //        upgradeModel.cost = (int)(upgradeModel.cost * priceMult);
                //    }

                //}

                Console.WriteLine("randomizing ability cooldowns (" + abilityMult + " times faster)");
                foreach (var tower in Game.instance.model.towers)
                {
                    try
                    {
                        foreach (var bev in tower.behaviors.GetItemsOfType<Model, AbilityModel>())
                        {
                            bev.Cooldown /= abilityMult;
                        }
                    }
                    catch
                    {

                    }
                }

                Console.WriteLine("randomizing fire rate with multiplier " + rateMult);
                foreach (var tower in Game.instance.model.towers)
                {
                    foreach (var attack in tower.GetAttackModels())
                    {
                        foreach (var wep in attack.weapons)
                        {
                            wep.Rate /= rateMult;
                        }
                    }
                    foreach (var ability in tower.GetAbilites())
                    {
                        foreach (var activateAttackModel in ability.GetBehaviors<ActivateAttackModel>())
                        {
                            foreach (var attack in activateAttackModel.attacks)
                            {
                                foreach (var wep in attack.weapons)
                                {
                                    wep.Rate /= rateMult;
                                }
                            }
                        }
                    }
                }

            }

        }

        [HarmonyPatch(typeof(Damage), "Initialise")]
        public class WeakenPatch
        {
            [HarmonyPrefix]
            public static bool Prefix(Damage __instance, ref Model modelToUse)
            {
                if (!modelToUse.name.Contains("modified"))
                {
                    modelToUse.name += "modified";

                    DamageModel damageModel = modelToUse.Cast<DamageModel>();
                    damageModel.damage *= damageMult;
                    damageModel.maxDamage *= damageMult;

                }
                return true;
            }
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;


        }







    }

}