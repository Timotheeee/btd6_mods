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
using BTD_Mod_Helper;
using System.Text.RegularExpressions;

namespace balanced_random_towers_and_projectiles
{
    public class Main : BloonsTD6Mod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("balanced_random_towers_and_projectiles loaded.");
        }

        static System.Collections.Generic.List<TowerModel> allTowers = new System.Collections.Generic.List<TowerModel>();

        static string[] blacklist =
        {
            "EngineerMonkey",
            "SniperMonkey",
            "BananaFarm",
        };

        //static Model temp;
        static Model randomTower(float price, float margin, string orig)
        {
            //Console.WriteLine("called randomTower with " + price + " " + margin);
            if (price == 0) return null;
            allTowers.Shuffle();
            foreach (var item in allTowers)
            {
                if(item.cost > (price * (1-margin)) && item.cost < (price * (1 + margin)) && item.name != orig && !blacklist.Any(item.name.Contains) && !Regex.IsMatch(item.name, "DartlingGunner-4..") && !Regex.IsMatch(item.name, "DartlingGunner-5.."))                                      
                {
                    //Console.WriteLine("returning " + item.name);
                    return item;
                }
            }
            //Console.WriteLine("failed");
            return randomTower(price,margin*2,orig);
        }


        [HarmonyPatch(typeof(Tower), nameof(Tower.Initialise))]
        internal class Tower_Initialise
        {

            [HarmonyPrefix]
            internal static bool Prefix(ref Tower __instance, ref Model modelToUse)
            {
                if (Regex.IsMatch(modelToUse.name, "DartlingGunner-4..") || Regex.IsMatch(modelToUse.name, "DartlingGunner-5.."))
                {
                    return true;
                }

                try
                {
                    //random tower
                    var temp = randomTower(modelToUse.Cast<TowerModel>().cost, 0.2f, modelToUse.Cast<TowerModel>().name).Duplicate();
                    if (temp != null)
                        modelToUse = temp;

                    //random projectile
                    //modelToUse = modelToUse.Duplicate();
                    temp = randomTower(modelToUse.Cast<TowerModel>().cost, 0.2f, modelToUse.Cast<TowerModel>().name);
                    //Console.WriteLine("name: " + modelToUse.Cast<TowerModel>().name + " new name: " + temp.Cast<TowerModel>().name);
                    var newproj = temp.Cast<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile;
                    if (temp != null)
                        foreach(var attackmodel in modelToUse.Cast<TowerModel>().GetBehaviors<AttackModel>())
                        {
                            foreach(var weapon in attackmodel.weapons)
                            {
                                weapon.projectile = newproj.Duplicate();
                            }
                        }

                }
                catch (Exception e)
                {
                    Console.WriteLine("failed: " + e.Message);
                }
                return true;
            }
        }



        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                //Console.WriteLine("fixing costs");
                //fix costs
                foreach (var tower in Game.instance.model.towers)
                {
                    if (tower.name.Contains("-"))
                    {
                        float cost = tower.cost;
                        foreach (var up in tower.appliedUpgrades)
                        {
                            cost += Game.instance.model.upgradesByName[up].cost;
                        }
                        tower.cost = cost;
                    }
                    tower.cost *= 1.08f;//hard mode

                }

                //Console.WriteLine("setting up list");
                foreach (var item in Game.instance.model.towers)
                {
                    if(!item.IsHero())
                        allTowers.Add(item);
                }


            }

        }


        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;


        }

        public override void OnTowerUpgraded(Tower tower, string upgradeName, TowerModel newBaseTowerModel)
        {
            if(Regex.IsMatch(tower.model.name, "DartlingGunner-4..") || Regex.IsMatch(tower.model.name, "DartlingGunner-5.."))
            {
                return;
            }
            try
            {
                //random tower
                var modelToUse = randomTower(newBaseTowerModel.cost, 0.2f, newBaseTowerModel.name).Cast<TowerModel>().Duplicate();


                //random projectile
                var random = randomTower(modelToUse.cost, 0.2f, modelToUse.name).Cast<TowerModel>().Duplicate();

                var newproj = random.Cast<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile;
                if (random != null)
                    foreach (var attackmodel in modelToUse.Cast<TowerModel>().GetBehaviors<AttackModel>())
                    {
                        foreach (var weapon in attackmodel.weapons)
                        {
                            weapon.projectile = newproj.Duplicate();
                        }
                    }



                if (random != null)
                    tower.SetTowerModel(modelToUse);
                tower.SetNextTargetType();

            }
            catch (Exception e)
            {
                Console.WriteLine("OnTowerUpgraded failed: " + e.Message);
            }
        }





    }

}