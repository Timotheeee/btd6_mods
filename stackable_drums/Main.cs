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
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[assembly: MelonInfo(typeof(stackable_drums.Main), stackable_drums.ModHelperData.Name, stackable_drums.ModHelperData.Version, stackable_drums.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace stackable_drums
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("stackable_drums loaded");
        }

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + " /Ninja Kiwi/BloonsTD6/";

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                var models = Game.instance.model.towers;

                for (int i = 0; i < models.Count; i++)
                {
                    var tower = models[i];

                    if (Regex.IsMatch(tower.name, "MonkeyVillage-2..") || Regex.IsMatch(tower.name, "MonkeyVillage-3..") || Regex.IsMatch(tower.name, "MonkeyVillage-4..") || Regex.IsMatch(tower.name, "MonkeyVillage-5.."))
                    {
                        tower.GetBehavior<RateSupportModel>().isUnique = false;
                        tower.GetBehavior<RateSupportModel>().maxStackSize = 255;
                        tower.GetBehavior<RateSupportModel>().showBuffIcon = true;
                    }


                    //if (Regex.IsMatch(tower.name, "EngineerMonkey-.5.") || Regex.IsMatch(tower.name, "EngineerMonkey-.4."))
                    //{
                    //    tower.GetBehavior<AbilityModel>().GetBehavior<OverclockModel>().maxStacks = 9999;
                    //    tower.GetBehavior<AbilityModel>().GetBehavior<OverclockModel>().Mutator.buffIndicator.maxStackSize = 9999;
                    //    tower.GetBehavior<AbilityModel>().GetBehavior<OverclockModel>().Mutator.buffIndicator.stackable = true;
                    //    tower.GetBehavior<CanBuffIndicatorModel>().maxStackSize = 9999;
                    //}

                }
                Game.instance.model.upgradesByName["Jungle Drums"].cost = 4000;
                //Game.instance.model.upgradesByName["Overclock"].cost = 18000;

            }
        }










    }

}