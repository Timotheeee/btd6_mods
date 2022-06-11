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
using Assets.Scripts.Unity.UI_New.InGame.Stats;
using System.Linq;
using System.Collections.Generic;

namespace balanced_random_abilities
{
    public class Main : BloonsTD6Mod
    {

        static TextMeshProUGUI infoDisplay;
        static GameObject upgradeTreeButton;
        static TowerToSimulation lastSelected;
        static System.Collections.Generic.List<TowerModel> allTowers = new System.Collections.Generic.List<TowerModel>();
        static string toWrite = "Info";


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("balanced_random_abilities loaded.");
        }


        static void Write(string t)
        {
            //toWrite = t;
            if (upgradeTreeButton == null)
            {
                //upgradeTreeButton = GameObject.Find("UpgradeTreeButton");
                upgradeTreeButton = GameObject.Find("RoundPanel");
                //upgradeTreeButton = GameObject.Find("TowerSelected");

            }
            //Console.WriteLine("upgradeTreeButton: " + (upgradeTreeButton==null));
            if (upgradeTreeButton != null)
            {
                //var pos = upgradeTreeButton.transform.position;
                //upgradeTreeButton.transform.position = new Vector3(1000f, pos.y, pos.z);
                if (t.Contains("-"))
                {
                    upgradeTreeButton.GetComponentInChildren<TextMeshProUGUI>().text = t.Substring(t.Length - 3) + "-" + t.Substring(0, t.Length - 3);
                }
                else
                {
                    upgradeTreeButton.GetComponentInChildren<TextMeshProUGUI>().text = t;
                }

                //upgradeTreeButton.GetComponentInChildren<NK_TextMeshProUGUI>().text = t;
            }

        }

        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {

                if (InGame.instance.inputManager.SelectedTower != null)
                {
                    //Console.WriteLine("writing:");
                    try
                    {
                        lastSelected = InGame.instance.inputManager.SelectedTower;
                        var a = lastSelected.tower.model.Cast<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.name;
                        //Console.WriteLine(a);
                        if (!a.ToLower().Contains("projectilemodel"))
                            Write(a);
                    }
                    catch (Exception e)
                    {
                        //Write(e.Message);
                        Write("Round");
                    }
                }
                else
                {
                    Write("Round");
                }



            }
        }


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
                if (item.cost > (price * (1 - margin)) && item.cost < (price * (1 + margin)) && item.name != orig && !blacklist.Any(item.name.Contains) && !Regex.IsMatch(item.name, "DartlingGunner-4..") && !Regex.IsMatch(item.name, "DartlingGunner-5.."))
                {
                    //Console.WriteLine("returning " + item.name);
                    return item;
                }
            }
            //Console.WriteLine("failed");
            return randomTower(price, margin * 2, orig);
        }

        static AbilityModel randomAbility(float price, float margin, string orig)
        {
            //Console.WriteLine("called randomTower with " + price + " " + margin);
            if (price == 0) return null;
            allTowers.Shuffle();
            foreach (var item in allTowers)
            {
                if (item.cost > (price * (1 - margin)) && item.cost < (price * (1 + margin)) && item.name != orig && !blacklist.Any(item.name.Contains) && !Regex.IsMatch(item.name, "DartlingGunner-4..") && !Regex.IsMatch(item.name, "DartlingGunner-5..") && !Regex.IsMatch(item.name, "HeliPilot-.4.") && !Regex.IsMatch(item.name, "HeliPilot-.5.") && item.GetAbilites().Count > 0)
                {
                    //Console.WriteLine("returning " + item.name);
                    return item.GetAbility();
                }
            }
            //Console.WriteLine("failed");
            return randomAbility(price, margin * 2, orig);
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
                if (modelToUse.Cast<TowerModel>().GetAbilites().Count == 0)
                {
                    return true;
                }

                try
                {

                    var randomAbility = Main.randomAbility(modelToUse.Cast<TowerModel>().cost, 0.2f, modelToUse.Cast<TowerModel>().name).Duplicate();
                    if (randomAbility != null)
                    {
                        modelToUse.Cast<TowerModel>().RemoveBehavior<AbilityModel>();
                        modelToUse.Cast<TowerModel>().AddBehavior(randomAbility);
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
                    if (!item.IsHero())
                        allTowers.Add(item);
                }

                List<TowerModel> SortedList = allTowers.OrderBy(o => o.cost).ToList();
                foreach (var item in SortedList)
                {
                    //Console.WriteLine(item.cost + " " + item.name);
                }

            }

        }




        public override void OnTowerUpgraded(Tower tower, string upgradeName, TowerModel newBaseTowerModel)
        {
            if (Regex.IsMatch(tower.model.name, "DartlingGunner-4..") || Regex.IsMatch(tower.model.name, "DartlingGunner-5.."))
            {
                return;
            }
            if (newBaseTowerModel.GetAbilites().Count == 0)
            {
                return;
            }
            try
            {

                var modelToUse = newBaseTowerModel.Duplicate();

                var randomAbility = Main.randomAbility(newBaseTowerModel.cost, 0.2f, newBaseTowerModel.name).Duplicate();
                if (randomAbility != null)
                {
                    modelToUse.Cast<TowerModel>().RemoveBehavior<AbilityModel>();
                    modelToUse.Cast<TowerModel>().AddBehavior(randomAbility);
                }

                tower.SetTowerModel(modelToUse);

            }
            catch (Exception e)
            {
                Console.WriteLine("OnTowerUpgraded failed: " + e.Message);
            }
        }





    }

}