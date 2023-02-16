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

using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using UnityEngine;

using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper;
using System.Text.RegularExpressions;
using BTD_Mod_Helper.Api.ModOptions;

[assembly: MelonInfo(typeof(balanced_random_projectiles.Main), balanced_random_projectiles.ModHelperData.Name, balanced_random_projectiles.ModHelperData.Version, balanced_random_projectiles.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace balanced_random_projectiles
{
    public class Main : BloonsTD6Mod
    {

        static ModSettingDouble defaultmargin = new ModSettingDouble(1.2f)
        {
            displayName = "margin",
            isSlider = false
        };

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("balanced_random_projectiles loaded.");
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
                if(item.cost > (price / margin) && item.cost < (price * margin) && item.name != orig && !blacklist.Any(item.name.Contains) && !Regex.IsMatch(item.name, "DartlingGunner-4..") && !Regex.IsMatch(item.name, "DartlingGunner-5.."))                                      
                {
                    //Console.WriteLine("returning " + item.name);
                    try
                    {
                        var newproj = item.Cast<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile;
                    }
                    catch
                    {
                        Console.WriteLine(item.name + " was not a valid choice, trying again");
                        return randomTower(price, margin, orig);
                    }
                    Console.WriteLine("new projectile: " + item.name + " new value: " + item.cost);
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
                    modelToUse = modelToUse.Duplicate();
                    var temp = randomTower(modelToUse.Cast<TowerModel>().cost, (float)defaultmargin, modelToUse.Cast<TowerModel>().name);
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



        public void InGameLoaded(InGame inGame)
        {
            foreach (var tower in inGame.GetGameModel().towers)
            {
                if (tower.name.Contains("-"))
                {
                    float cost = tower.cost;
                    foreach (var up in tower.appliedUpgrades)
                    {
                        cost += inGame.GetGameModel().upgradesByName[up].cost;
                    }
                    tower.cost = cost;
                    //Console.WriteLine(tower.name + " " + tower.cost);
                }
            }

            allTowers = new System.Collections.Generic.List<TowerModel>();
            foreach (var item in inGame.GetGameModel().towers)
            {
                if (!item.IsHero())
                {
                    //Console.WriteLine("added " + item.name + " " + item.cost);
                    allTowers.Add(item);
                }

            }
        }


        static bool wasLoaded = false;
        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (!wasLoaded && inAGame)
            {
                InGameLoaded(InGame.instance);
            }
            wasLoaded = inAGame;

        }

        public override void OnTowerUpgraded(Tower tower, string upgradeName, TowerModel newBaseTowerModel)
        {
            if(Regex.IsMatch(tower.model.name, "DartlingGunner-4..") || Regex.IsMatch(tower.model.name, "DartlingGunner-5.."))
            {
                return;
            }
            try
            {
                var modelToUse = newBaseTowerModel.Duplicate();
                var random = randomTower(newBaseTowerModel.cost, (float)defaultmargin, newBaseTowerModel.name).Cast<TowerModel>().Duplicate();

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
                //tower.SetNextTargetType();

            }
            catch (Exception e)
            {
                Console.WriteLine("OnTowerUpgraded failed: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }





    }

}