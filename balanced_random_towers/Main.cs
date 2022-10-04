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
using BTD_Mod_Helper.Api.ModOptions;
using System.Text.RegularExpressions;

namespace balanced_random_towers
{
    public class Main : BloonsTD6Mod
    {

        static ModSettingDouble defaultmargin = new ModSettingDouble(1.2f)
        {
            displayName = "margin",
            isSlider = false
        };

            

        //static bool loaded = false;
        //public override void OnInGameLoaded(InGame inGame)
        public void InGameLoaded(InGame inGame)
        {
            //if (loaded) return;
            //loaded = true;
            Console.WriteLine("fixing costs");
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
                    Console.WriteLine(tower.name + " " + tower.cost);
                }
            }
            Console.WriteLine("building tower list");
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

        //public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        //{
        //    Console.WriteLine("OnSceneWasInitialized");
        //}

        //public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        //{
        //    Console.WriteLine("OnSceneWasLoaded");
        //}

        //public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        //{
        //    Console.WriteLine("OnSceneWasUnloaded");
        //}

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("balanced_random_towers loaded.");
        }

        static System.Collections.Generic.List<TowerModel> allTowers = new System.Collections.Generic.List<TowerModel>();

        //static Model temp;
        static Model randomTower(float price, float margin, string orig)
        {
            Console.WriteLine("called randomTower with " + price + " " + margin);
            //Console.WriteLine("allTowers count: " + allTowers.Count);
            if (price == 0) return null;
            allTowers.Shuffle();
            foreach (var item in allTowers)
            {
                if(item.cost > (price / margin) && item.cost < (price * margin) && item.name != orig && !Regex.IsMatch(item.name, "DartlingGunner-4..") && !Regex.IsMatch(item.name, "DartlingGunner-5.."))
                {
                    Console.WriteLine("new value: " + item.cost);
                    return item;
                }
            }
            Console.WriteLine("failed");
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
                    //Console.WriteLine("name: " + modelToUse.Cast<TowerModel>().name + " cost: " + modelToUse.Cast<TowerModel>().cost);
                    var temp = randomTower(modelToUse.Cast<TowerModel>().cost, (float)defaultmargin, modelToUse.Cast<TowerModel>().name);
                    if (temp != null)
                        modelToUse = temp;

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
                //foreach (var tower in Game.instance.model.towers)
                //{
                //    if (tower.name.Contains("-"))
                //    {
                //        float cost = tower.cost;
                //        foreach (var up in tower.appliedUpgrades)
                //        {
                //            cost += Game.instance.model.upgradesByName[up].cost;
                //        }
                //        tower.cost = cost;
                //    }
                //    tower.cost *= 1.08f;//hard mode

                //}

                //Console.WriteLine("setting up list");
                //foreach (var item in Game.instance.model.towers)
                //{
                //    if(!item.IsHero())
                //        allTowers.Add(item);
                //}


            }

        }


        static bool wasLoaded = false;
        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if(!wasLoaded && inAGame)
            {
                InGameLoaded(InGame.instance);
            }
            wasLoaded = inAGame;

        }

        public override void OnTowerUpgraded(Tower tower, string upgradeName, TowerModel newBaseTowerModel)
        {
            if (Regex.IsMatch(tower.model.name, "DartlingGunner-4..") || Regex.IsMatch(tower.model.name, "DartlingGunner-5.."))
            {
                return;
            }
            try
            {
                //Console.WriteLine("name: " + newBaseTowerModel.name + " cost: " + newBaseTowerModel.cost);
                var temp = randomTower(newBaseTowerModel.cost, (float)defaultmargin, newBaseTowerModel.name).Cast<TowerModel>();
                if (temp != null)
                    tower.SetTowerModel(temp);
                tower.SetNextTargetType();

            }
            catch (Exception e)
            {
                Console.WriteLine("OnTowerUpgraded failed: " + e.Message);
            }
        }





    }

}