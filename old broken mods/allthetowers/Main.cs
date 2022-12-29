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
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppSystem.Collections.Generic;
using Il2CppAssets.Main.Scenes;
using Il2CppAssets.Scripts.Models.Profile;
using Il2CppAssets.Scripts.Models.Powers;
using Il2CppAssets.Scripts.Simulation.Input;
using System.Linq;

[assembly: MelonInfo(typeof(allthetowers.Main), allthetowers.ModHelperData.Name, allthetowers.ModHelperData.Version, allthetowers.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace allthetowers
{
    public class Main : MelonMod
    {

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("allthetowers loaded");
        }
        internal static class Constants
        {
            internal static readonly string[] powers = { "BananaFarmer", "CaveMonkey", "EnergisingTotem", "Pontoon", "PortableLake", "TechBot" };
            internal static readonly int[] powerCosts = { 2500, 215, 1000, 1250, 1250, 2000 };
            internal static readonly string[] otherTowers = { "Marine", "Sentry", "SentryBoom", "SentryCold", "SentryCrushing", "SentryEnergy", "SentryParagon",
        "SunAvatarMini", "TransformedBaseMonkey" };
            internal static readonly int[] towerCosts = { 2270, 95, 470, 470, 470, 470, 800, 8000, 5500 };
            internal static readonly string[] otherTowerTowersets = { "Military", "Support", "Support", "Support", "Support", "Support", "Support", "Magic", "Magic" };
        }

        public class Utils
        {
            public static void RegisterTowerInInventory(ShopTowerDetailsModel details, string insertBefore, List<TowerDetailsModel> allTowersInTheGame)
            {
                // get the tower details for the tower insertBefore and insert the new tower into the index towerBefore is at, shifting everything after it by 1
                TowerDetailsModel towerAfter = allTowersInTheGame.ToArray().FirstOrDefault(tower => tower.towerId == insertBefore);
                allTowersInTheGame.Insert(allTowersInTheGame.IndexOf(towerAfter), details);
            }
        }

        public class Mod : MelonMod { }

        [HarmonyPatch(typeof(ProfileModel), "Validate")] // this method is called after the profile data is parsed, hence why it's used to modify said profile data
        public class ProfileModel_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(ProfileModel __instance)
            {
                var unlockedTowers = __instance.unlockedTowers;
                if (unlockedTowers.Contains("TransformedBaseMonkey")) return;

                foreach (string power in Constants.powers) unlockedTowers.Add(power);
                foreach (string otherTower in Constants.otherTowers) unlockedTowers.Add(otherTower);

                Console.WriteLine("Added needed towers to the list of unlocked towers");
            }
        }

        [HarmonyPatch(typeof(TitleScreen), "UpdateVersion")] // this method is called soon after the game is done initializing the models, hence why it's used to modify said models
        public class GameModel_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                for (int i = 0; i < Constants.powers.Length; i++)
                {
                    PowerModel powerModel = Game.instance.model.GetPowerWithName(Constants.powers[i]);

                    if (powerModel.tower.icon == null) powerModel.tower.icon = powerModel.icon;

                    powerModel.tower.cost = Constants.powerCosts[i];
                    powerModel.tower.towerSet = "Support";
                }

                for (int i = 0; i < Constants.otherTowers.Length; i++)
                {
                    TowerModel otherTowerModel = Game.instance.model.GetTowerWithName(Constants.otherTowers[i]);

                    if (otherTowerModel.icon == null) otherTowerModel.icon = otherTowerModel.portrait;
                    if (Constants.otherTowers[i] == "SunAvatarMini") otherTowerModel.icon = Game.instance.model.GetTowerWithName("SuperMonkey-300").portrait;
                    if (Constants.otherTowers[i] == "TransformedBaseMonkey") otherTowerModel.icon = Game.instance.model.GetTowerWithName("Alchemist-050").portrait;

                    otherTowerModel.cost = Constants.towerCosts[i];
                    otherTowerModel.towerSet = Constants.otherTowerTowersets[i];
                }

                Console.WriteLine("Configured tower models");
            }
        }

        [HarmonyPatch(typeof(TowerInventory), "Init")] // this method tells the game to create buttons for a given list of towers, allTowersInTheGame, which we modify here
        public class TowerInit_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(ref List<TowerDetailsModel> allTowersInTheGame)
            {
                for (int i = 0; i < Constants.powers.Length; i++)
                {
                    ShopTowerDetailsModel powerDetails = new ShopTowerDetailsModel(Constants.powers[i],
                        allTowersInTheGame.ToArray().FirstOrDefault(tower => tower.name.Contains("EngineerMonkey")).towerIndex, 0, 0, 0, -1, -1, null);
                    Utils.RegisterTowerInInventory(powerDetails, "EngineerMonkey", allTowersInTheGame);
                }

                for (int i = 0; i < Constants.otherTowers.Length; i++)
                {
                    ShopTowerDetailsModel otherTowerDetails = new ShopTowerDetailsModel(Constants.otherTowers[i], -1, 0, 0, 0, -1, -1, null);

                    string insertBefore = "EngineerMonkey"; // support had the most occurrences, so have it default to mortar to eliminate the conditional for military

                    if (Constants.otherTowerTowersets[i] == "Military") insertBefore = "MortarMonkey"; // military towers
                    if (Constants.otherTowerTowersets[i] == "Magic") insertBefore = "Druid"; // magic towers

                    otherTowerDetails.towerIndex = allTowersInTheGame.ToArray().FirstOrDefault(tower => tower.name.Contains(insertBefore)).towerIndex;
                    Utils.RegisterTowerInInventory(otherTowerDetails, insertBefore, allTowersInTheGame);
                }

                Console.WriteLine("Registered tower models in tower inventory");
                return true;
            }
        }







    }

}