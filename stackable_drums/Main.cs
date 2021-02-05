using MelonLoader;
using Harmony;
using NKHook6;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
using NKHook6.Api.Events;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity;
using Assets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Assets.Main.Scenes;
using UnityEngine;
using System.Linq;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using BloonsTD6_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

namespace stackable_drums
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
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