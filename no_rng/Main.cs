using MelonLoader;
using Harmony;

using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Il2CppAssets.Main.Scenes;
using UnityEngine;
using System.Linq;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Track;

[assembly: MelonInfo(typeof(no_rng.Main), no_rng.ModHelperData.Name, no_rng.ModHelperData.Version, no_rng.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace no_rng
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("no rng mod loaded");
        }

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + " /Ninja Kiwi/BloonsTD6/";

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                var models = Game.instance.model.towers;
                var mortar = Game.instance.model.GetTowerFromId("MortarMonkey").Duplicate();
                var mortarAttack = Game.instance.model.GetTowerFromId("MortarMonkey").GetBehavior<AttackModel>().Duplicate();

                for (int i = 0; i < models.Count; i++)
                {
                    var tower = models[i];



                    if (Regex.IsMatch(tower.name, "WizardMonkey-02.") || Regex.IsMatch(tower.name, "WizardMonkey-03.") || Regex.IsMatch(tower.name, "WizardMonkey-04.") || Regex.IsMatch(tower.name, "WizardMonkey-05."))
                    {

                        tower.towerSelectionMenuThemeId = "ActionButton";


                        tower.TargetTypes = mortar.TargetTypes;
                        tower.targetTypes = mortar.targetTypes;


                        var wof = tower.behaviors.FirstOrDefault((Model ab) => ab.name.Contains("AttackModel_Attack Wall of Fire_")).Cast<AttackModel>();
                        wof.targetProvider = mortarAttack.targetProvider;
                        wof.RemoveBehavior<TargetTrackOrDefaultModel>();
                        wof.AddBehavior(mortarAttack.GetBehavior<TargetSelectedPointModel>().Duplicate());
                        wof.weapons[0].startInCooldown = false;


                    }
                    if (tower.name.Contains("MortarMonkey"))
                    {
                        tower.GetBehavior<AttackModel>().weapons[0].emission.Cast<RandomTargetSpreadModel>().spread = 0;
                    }

                    if (Regex.IsMatch(tower.name, "SpikeFactory-..2") || Regex.IsMatch(tower.name, "SpikeFactory-..3") || Regex.IsMatch(tower.name, "SpikeFactory-..4") || Regex.IsMatch(tower.name, "SpikeFactory-..5"))
                    {

                        tower.towerSelectionMenuThemeId = "ActionButton";


                        tower.TargetTypes = mortar.TargetTypes;
                        tower.targetTypes = mortar.targetTypes;


                        var spike = tower.GetBehavior<AttackModel>();
                        spike.targetProvider = mortarAttack.targetProvider;
                        //spike.RemoveBehavior<TargetTrackOrDefaultModel>();
                        spike.AddBehavior(mortarAttack.GetBehavior<TargetSelectedPointModel>().Duplicate());
                        //spike.weapons[0].startInCooldown = false;


                    }

                }

            }
        }

        //[HarmonyPatch(typeof(Spawner), "OnRoundEndProjectiles")]
        //public class OnRoundEndProjectiles_Patch
        //{

        //    [HarmonyPrefix]
        //    public static bool Prefix()
        //    {

        //        return false;
        //    }
        //}

        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {

            }
        }








    }

}