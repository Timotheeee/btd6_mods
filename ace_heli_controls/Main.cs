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
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

[assembly: MelonInfo(typeof(ace_heli_controls.Main), ace_heli_controls.ModHelperData.Name, ace_heli_controls.ModHelperData.Version, ace_heli_controls.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace ace_heli_controls
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("ace_heli_controls loaded");
        }

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + " /Ninja Kiwi/BloonsTD6/";
        static TargetType[] targets;

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                var models = Game.instance.model.towers;
                var HeliPilot210 = Game.instance.model.GetTowerFromId("HeliPilot-210").Duplicate();
                targets = HeliPilot210.Duplicate().targetTypes;


                for (int i = 0; i < models.Count; i++)
                {
                    var tower = models[i];



                    if (tower.name.Contains("MonkeyAce"))
                    {
                        tower.TargetTypes = HeliPilot210.TargetTypes;
                        var disp = tower.GetBehavior<AirUnitModel>().Duplicate().display;
                        tower.RemoveBehavior<AirUnitModel>(); tower.AddBehavior(HeliPilot210.GetBehavior<AirUnitModel>().Duplicate());
                        tower.GetBehavior<AirUnitModel>().display = disp;
                        tower.GetBehavior<AttackAirUnitModel>().RemoveBehavior<CirclePatternModel>();
                        tower.GetBehavior<AttackAirUnitModel>().RemoveBehavior<FigureEightPatternModel>();
                        tower.GetBehavior<AttackAirUnitModel>().RemoveBehavior<FigureEightPatternModel>();
                        tower.GetBehavior<AttackAirUnitModel>().RemoveBehavior<CenterElipsePatternModel>();
                        tower.GetBehavior<AttackAirUnitModel>().RemoveBehavior<WingmonkeyPatternModel>();
                        tower.GetBehavior<AttackAirUnitModel>().AddBehavior(HeliPilot210.GetBehavior<AttackModel>().GetBehavior<FollowTouchSettingModel>());
                        tower.GetBehavior<AttackAirUnitModel>().AddBehavior(HeliPilot210.GetBehavior<AttackModel>().GetBehavior<LockInPlaceSettingModel>());
                        tower.GetBehavior<AttackAirUnitModel>().AddBehavior(HeliPilot210.GetBehavior<AttackModel>().GetBehavior<PatrolPointsSettingModel>());
                        tower.GetBehavior<AttackAirUnitModel>().AddBehavior(HeliPilot210.GetBehavior<AttackModel>().GetBehavior<RotateToTargetAirUnitModel>());
                        tower.GetBehavior<AttackAirUnitModel>().AddBehavior(HeliPilot210.GetBehavior<AttackModel>().GetBehavior<PursuitSettingModel>());
                        tower.towerSelectionMenuThemeId = HeliPilot210.towerSelectionMenuThemeId;

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
                var towers = InGame.instance.bridge.GetAllTowers();
                
                foreach (TowerToSimulation towerToSimulation in towers.ToList())
                {
                    Tower tower = towerToSimulation.tower;
                    TowerModel towerModel = tower.towerModel;
                    if (towerModel.name.Contains("MonkeyAce"))
                    {
                        towerModel.targetTypes = targets;
                    }
                }
            }
        }








    }

}