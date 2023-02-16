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

using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Track;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Simulation.Input;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Models.Powers;
using Il2CppAssets.Scripts.Models.Profile;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using BTD_Mod_Helper.Extensions;

[assembly: MelonInfo(typeof(farmer_and_tech_bot_in_shop.Main), farmer_and_tech_bot_in_shop.ModHelperData.Name, farmer_and_tech_bot_in_shop.ModHelperData.Version, farmer_and_tech_bot_in_shop.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace farmer_and_tech_bot_in_shop
{
    public class Main : BloonsTD6Mod
    {


        public class BananaFarmer : ModTower
        {
            //public override string BaseTower => "DartMonkey-003";
            public override string BaseTower => "BananaFarmer";
            public override string Name => "BananaFarmer";
            public override int Cost => 0;
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Support;
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "BananaFarmer";
            public override string Description => "BananaFarmer";

            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                //display = new PrefabReference() { guidRef = "PowerIcons[BananaFarmerIcon]" };
                towerModel.icon = new SpriteReference() { guidRef = "PowerIcons[BananaFarmerIcon]" };
                towerModel.instaIcon = new SpriteReference() { guidRef = "PowerIcons[BananaFarmerIcon]" };
                towerModel.portrait = new SpriteReference() { guidRef = "PowerIcons[BananaFarmerIcon]" };
            }
        }

        public class TechBot : ModTower
        {
            //public override string BaseTower => "DartMonkey-003";
            public override string BaseTower => "TechBot";
            public override string Name => "TechBot";
            public override int Cost => 0;
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Support;
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "TechBot";
            public override string Description => "TechBot";

            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.icon = new SpriteReference() { guidRef = "PowerIcons[TechbotIcon]" };
                towerModel.instaIcon = new SpriteReference() { guidRef = "PowerIcons[TechbotIcon]" };
                towerModel.portrait = new SpriteReference() { guidRef = "PowerIcons[TechbotIcon]" };
            }
        }


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("farmer_and_tech_bot_in_shop loaded");
        }




        //internal static class Constants
        //{
        //    internal static readonly string[] powers = { "BananaFarmer", "TechBot", };// "CaveMonkey", "EnergisingTotem", "Pontoon", "PortableLake", "TechBot" };
        //    internal static readonly int[] powerCosts = { 0, 0 };//, 1000, 1250, 1250, 2000 };
        //    internal static readonly string[] otherTowers = { };// "Marine", "Sentry", "SentryBoom", "SentryCold", "SentryCrushing", "SentryEnergy", "SentryParagon",
        //                                                        //"SunAvatarMini", "TransformedBaseMonkey" };
        //    internal static readonly int[] towerCosts = { };// 2270, 95, 470, 470, 470, 470, 800, 8000, 5500 };
        //    internal static readonly string[] otherTowerTowersets = { };//{ "Military", "Support", "Support", "Support", "Support", "Support", "Support", "Magic", "Magic" };
        //}
        ////internal static class Constants
        ////{
        ////    internal static readonly string[] powers = { "BananaFarmer", "CaveMonkey", "EnergisingTotem", "Pontoon", "PortableLake", "TechBot" };
        ////    internal static readonly int[] powerCosts = { 25, 215, 1000, 1250, 1250, 25 };
        ////    internal static readonly string[] otherTowers = { "Marine", "Sentry", "SentryBoom", "SentryCold", "SentryCrushing", "SentryEnergy", "SentryParagon",
        ////"SunAvatarMini", "TransformedBaseMonkey" };
        ////    internal static readonly int[] towerCosts = { 2270, 95, 470, 470, 470, 470, 800, 8000, 5500 };
        ////    internal static readonly string[] otherTowerTowersets = { "Military", "Support", "Support", "Support", "Support", "Support", "Support", "Magic", "Magic" };
        ////}

        //public class Utils
        //{
        //    public static void RegisterTowerInInventory(ShopTowerDetailsModel details, string insertBefore, Il2CppSystem.Collections.Generic.List<TowerDetailsModel> allTowersInTheGame)
        //    {
        //        // get the tower details for the tower insertBefore and insert the new tower into the index towerBefore is at, shifting everything after it by 1
        //        TowerDetailsModel towerAfter = allTowersInTheGame.ToArray().FirstOrDefault(tower => tower.towerId == insertBefore);
        //        allTowersInTheGame.Insert(allTowersInTheGame.IndexOf(towerAfter), details);
        //    }
        //}

        //[HarmonyPatch(typeof(ProfileModel), "Validate")] // this method is called after the profile data is parsed, hence why it's used to modify said profile data
        //public class ProfileModel_Patch
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix(ProfileModel __instance)
        //    {
        //        var unlockedTowers = __instance.unlockedTowers;
        //        if (unlockedTowers.Contains("BananaFarmer")) return;

        //        foreach (string power in Constants.powers) unlockedTowers.Add(power);
        //        foreach (string otherTower in Constants.otherTowers) unlockedTowers.Add(otherTower);


        //    }
        //}

        //[HarmonyPatch(typeof(TitleScreen), "UpdateVersion")] // this method is called soon after the game is done initializing the models, hence why it's used to modify said models
        //public class GameModel_Patch
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix()
        //    {
        //        for (int i = 0; i < Constants.powers.Length; i++)
        //        {
        //            PowerModel powerModel = Game.instance.model.GetPowerWithName(Constants.powers[i]);

        //            if (powerModel.tower.icon == null) powerModel.tower.icon = powerModel.icon;

        //            powerModel.tower.cost = Constants.powerCosts[i];
        //            powerModel.tower.towerSet = "Support";
        //        }

        //        for (int i = 0; i < Constants.otherTowers.Length; i++)
        //        {
        //            TowerModel otherTowerModel = Game.instance.model.GetTowerWithName(Constants.otherTowers[i]);

        //            if (otherTowerModel.icon == null) otherTowerModel.icon = otherTowerModel.portrait;
        //            if (Constants.otherTowers[i] == "SunAvatarMini") otherTowerModel.icon = Game.instance.model.GetTowerWithName("SuperMonkey-300").portrait;
        //            if (Constants.otherTowers[i] == "TransformedBaseMonkey") otherTowerModel.icon = Game.instance.model.GetTowerWithName("Alchemist-050").portrait;

        //            otherTowerModel.cost = Constants.towerCosts[i];
        //            otherTowerModel.towerSet = Constants.otherTowerTowersets[i];
        //        }


        //    }
        //}

        //[HarmonyPatch(typeof(TowerInventory), "Init")] // this method tells the game to create buttons for a given list of towers, allTowersInTheGame, which we modify here
        //public class TowerInit_Patch
        //{
        //    [HarmonyPrefix]
        //    public static bool Prefix(ref Il2CppSystem.Collections.Generic.List<TowerDetailsModel> allTowersInTheGame)
        //    {
        //        for (int i = 0; i < Constants.powers.Length; i++)
        //        {
        //            ShopTowerDetailsModel powerDetails = new ShopTowerDetailsModel(Constants.powers[i],
        //                allTowersInTheGame.ToArray().FirstOrDefault(tower => tower.name.Contains("EngineerMonkey")).towerIndex, 0, 0, 0, -1, -1, null);
        //            Utils.RegisterTowerInInventory(powerDetails, "EngineerMonkey", allTowersInTheGame);
        //        }

        //        for (int i = 0; i < Constants.otherTowers.Length; i++)
        //        {
        //            ShopTowerDetailsModel otherTowerDetails = new ShopTowerDetailsModel(Constants.otherTowers[i], -1, 0, 0, 0, -1, -1, null);

        //            string insertBefore = "EngineerMonkey"; // support had the most occurrences, so have it default to mortar to eliminate the conditional for military

        //            if (Constants.otherTowerTowersets[i] == "Military") insertBefore = "MortarMonkey"; // military towers
        //            if (Constants.otherTowerTowersets[i] == "Magic") insertBefore = "Druid"; // magic towers

        //            otherTowerDetails.towerIndex = allTowersInTheGame.ToArray().FirstOrDefault(tower => tower.name.Contains(insertBefore)).towerIndex;
        //            Utils.RegisterTowerInInventory(otherTowerDetails, insertBefore, allTowersInTheGame);
        //        }


        //        return true;
        //    }
        //}





    }

}