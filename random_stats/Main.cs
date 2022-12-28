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
using TMPro;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using UnityEngine;
using BloonsTD6_Mod_Helper.Extensions;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Main.Scenes;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;

[assembly: MelonInfo(typeof(random_stats.Main), random_stats.ModHelperData.Name, random_stats.ModHelperData.Version, random_stats.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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