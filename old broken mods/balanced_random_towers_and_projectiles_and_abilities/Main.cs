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
//
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Main.Scenes;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper;
using System.Text.RegularExpressions;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.Stats;

[assembly: MelonInfo(typeof(balanced_random_towers_and_projectiles_and_abilities.Main), balanced_random_towers_and_projectiles_and_abilities.ModHelperData.Name, balanced_random_towers_and_projectiles_and_abilities.ModHelperData.Version, balanced_random_towers_and_projectiles_and_abilities.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace balanced_random_towers_and_projectiles_and_abilities
{
    public class Main : BloonsTD6Mod
    {

        //static TextMeshProUGUI infoDisplay;
        static GameObject upgradeTreeButton;
        static TowerToSimulation lastSelected;
        static System.Collections.Generic.List<TowerModel> allTowers = new System.Collections.Generic.List<TowerModel>();
        static string toWrite = "Info";


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("balanced_random_towers_and_projectiles_and_abilities loaded.");
        }

        //[HarmonyPatch(typeof(RoundDisplay), "OnUpdate")]
        //public class RoundDisplayModification
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix(RoundDisplay __instance)
        //    {
        //        Console.WriteLine("OnUpdate");
        //        if ((UnityEngine.Object)(object)infoDisplay == null)
        //        {
        //            Console.WriteLine("a");
        //            infoDisplay = UnityEngine.Object.Instantiate<TextMeshProUGUI>(__instance.text, new Transform());
        //            ((UnityEngine.Object)(object)infoDisplay).name = "InfoDisplay";
        //            ((TMP_Text)infoDisplay).text = toWrite;
        //            ((TMP_Text)infoDisplay).transform.position.Set(-200f, -19f, 0f);
        //        }
        //        ((TMP_Text)infoDisplay).text = toWrite;
        //    }
        //}

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
                    //upgradeTreeButton.GetComponentInChildren<TextMeshProUGUI>().text = t.Substring(t.Length - 3) + "-" + t.Substring(0,t.Length - 3);
                } else
                {
                    //upgradeTreeButton.GetComponentInChildren<TextMeshProUGUI>().text = t;
                }
                
                //upgradeTreeButton.GetComponentInChildren<NK_TextMeshProUGUI>().text = t;
            }

        }
        static bool wasLoaded = false;
        static float timer = 0;
        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;

            if (inAGame)
            {
                timer += UnityEngine.Time.deltaTime;
            }
            else
            {
                timer = 0;
            }

            if (!wasLoaded && inAGame)
            {
                InGameLoaded(InGame.instance);
            }
            wasLoaded = inAGame;

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
                        if(!a.ToLower().Contains("projectilemodel"))
                            Write(a);
                    }
                    catch(Exception e)
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
                if(item.cost > (price * (1-margin)) && item.cost < (price * (1 + margin)) && item.name != orig && !blacklist.Any(item.name.Contains) && !Regex.IsMatch(item.name, "DartlingGunner-4..") && !Regex.IsMatch(item.name, "DartlingGunner-5.."))                                      
                {
                    Console.WriteLine("new value: " + item.cost);
                    return item;
                }
            }
            //Console.WriteLine("failed");
            return randomTower(price,margin*2,orig);
        }

        static AbilityModel randomAbility(float price, float margin, string orig)
        {
            //Console.WriteLine("called randomTower with " + price + " " + margin);
            if (price == 0) return null;
            allTowers.Shuffle();
            foreach (var item in allTowers)
            {
                if (item.cost > (price * (1 - margin)) && item.cost < (price * (1 + margin+0.05f)) && item.name != orig && !blacklist.Any(item.name.Contains) && !Regex.IsMatch(item.name, "DartlingGunner-4..") && !Regex.IsMatch(item.name, "DartlingGunner-5..") && !Regex.IsMatch(item.name, "HeliPilot-.4.") && !Regex.IsMatch(item.name, "HeliPilot-.5.") && item.GetAbilities().Count > 0)
                {
                    
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
                if (timer < 1)
                {
                    return true;
                }
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
                    temp = randomTower(modelToUse.Cast<TowerModel>().cost, 0.2f, modelToUse.Cast<TowerModel>().name);
                    var newproj = temp.Cast<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile;
                    if (temp != null)
                        foreach(var attackmodel in modelToUse.Cast<TowerModel>().GetBehaviors<AttackModel>())
                        {
                            foreach(var weapon in attackmodel.weapons)
                            {
                                weapon.projectile = newproj.Duplicate();
                                weapon.projectile.name = temp.Cast<TowerModel>().name;
                            }
                        }

                    //random ability
                    if (modelToUse.Cast<TowerModel>().GetAbilities().Count > 0)
                    {
                        var randomAbility = Main.randomAbility(modelToUse.Cast<TowerModel>().cost, 0.2f, modelToUse.Cast<TowerModel>().name).Duplicate();
                        if (randomAbility != null)
                        {
                            modelToUse.Cast<TowerModel>().RemoveBehavior<AbilityModel>();
                            modelToUse.Cast<TowerModel>().AddBehavior(randomAbility);
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




        public override void OnTowerUpgraded(Tower tower, string upgradeName, TowerModel newBaseTowerModel)
        {
            if (timer < 1)
            {
                return;
            }
            if (Regex.IsMatch(tower.model.name, "DartlingGunner-4..") || Regex.IsMatch(tower.model.name, "DartlingGunner-5.."))
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
                            weapon.projectile.name = random.Cast<TowerModel>().name;
                        }
                    }

                //random ability
                if (modelToUse.Cast<TowerModel>().GetAbilities().Count > 0)
                {
                    var randomAbility = Main.randomAbility(modelToUse.Cast<TowerModel>().cost, 0.2f, modelToUse.Cast<TowerModel>().name).Duplicate();
                    if (randomAbility != null)
                    {
                        modelToUse.Cast<TowerModel>().RemoveBehavior<AbilityModel>();
                        modelToUse.Cast<TowerModel>().AddBehavior(randomAbility);
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