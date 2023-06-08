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
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper;
using static Il2CppAssets.Scripts.Models.Towers.Behaviors.ParagonTowerModel;

[assembly: MelonInfo(typeof(buffable_paragons.Main0), buffable_paragons.ModHelperData.Name, buffable_paragons.ModHelperData.Version, buffable_paragons.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace buffable_paragons
{
    public class Main0 : BloonsTD6Mod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("buffable_paragons loaded");
        }

        public static void Process(TowerModel towerModel, string name)
        {
            towerModel.isParagon = false;
            towerModel.isBakable = true;
            towerModel.RemoveBehavior<ParagonTowerModel>();

            var b = Game.instance.model.GetTowerFromId(name);
            towerModel.icon = new SpriteReference() { guidRef = b.portrait.guidRef };
            towerModel.instaIcon = new SpriteReference() { guidRef = b.portrait.guidRef };
            towerModel.portrait = new SpriteReference() { guidRef = b.portrait.guidRef };
        }

        //public override void OnUpdate()
        //{
        //    base.OnUpdate();

        //    bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
        //    if (inAGame)
        //    {
        //        //var buffmodel = InGame.instance.GetGameModel().paragonDegreeDataModel;
        //        //buffmodel.
        //        foreach (var tower in InGame.instance.bridge.GetAllTowers())
        //        {
        //            if (tower.tower.model.name.Contains("Paragon"))
        //            {
        //                Console.WriteLine(tower.tower.model.name);
        //                //tower.tower.AddParagonMutator(new PowerDegreeMutator(100,0.5f))
        //                foreach(var mut in tower.tower.mutators)
        //                {
        //                    Console.WriteLine(mut.ToString());
        //                }
        //            }
        //        }

        //    }

        //}

    }

    public class Main1 : BloonsTD6Mod
    {
        public class DartParagon : ModTower
        {
            public override string BaseTower => "DartMonkey-Paragon";
            public override string Name => "DartMonkey-Paragon-Buffable";
            public override int Cost => 450000;
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Primary;
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "DartMonkey Paragon Buffable";
            public override string Description => "Buffable";
            public override string Icon => "3906afef12a8fab4db780428c3b8a50b";
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                Main0.Process(towerModel, "DartMonkey-Paragon");
            }
        }
    }

    public class Main2 : BloonsTD6Mod
    {
        public class MonkeyBuccaneer : ModTower
        {
            public override string BaseTower => "MonkeyBuccaneer-Paragon";
            public override string Name => "MonkeyBuccaneer-Paragon-Buffable";
            public override int Cost => 540000;
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Primary;
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "MonkeyBuccaneer Paragon Buffable";
            public override string Description => "Buffable";
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                Main0.Process(towerModel, "MonkeyBuccaneer-Paragon");
            }
        }
    }

    public class Main3 : BloonsTD6Mod
    {
        public class BoomerangMonkey : ModTower
        {
            public override string BaseTower => "BoomerangMonkey-Paragon";
            public override string Name => "BoomerangMonkey-Paragon-Buffable";
            public override int Cost => 540000;
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Primary;
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "BoomerangMonkey Paragon Buffable";
            public override string Description => "Buffable";
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                Main0.Process(towerModel, "BoomerangMonkey-Paragon");
            }
        }
    }

    public class Main4 : BloonsTD6Mod
    {
        public class MonkeyBuccaneer : ModTower
        {
            public override string BaseTower => "NinjaMonkey-Paragon";
            public override string Name => "NinjaMonkey-Paragon-Buffable";
            public override int Cost => 540000;
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Primary;
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "NinjaMonkey Paragon Buffable";
            public override string Description => "Buffable";
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                Main0.Process(towerModel, "NinjaMonkey-Paragon");
            }
        }
    }

    public class Main5 : BloonsTD6Mod
    {
        public class MonkeyBuccaneer : ModTower
        {
            public override string BaseTower => "EngineerMonkey-Paragon";
            public override string Name => "EngineerMonkey-Paragon-Buffable";
            public override int Cost => 540000;
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Primary;
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "EngineerMonkey Paragon Buffable";
            public override string Description => "Buffable";
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                Main0.Process(towerModel, "EngineerMonkey-Paragon");
            }
        }
    }

    public class Main6 : BloonsTD6Mod
    {
        public class MonkeyBuccaneer : ModTower
        {
            public override string BaseTower => "WizardMonkey-Paragon";
            public override string Name => "WizardMonkey-Paragon-Buffable";
            public override int Cost => 540000;
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Primary;
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "WizardMonkey Paragon Buffable";
            public override string Description => "Buffable";
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                Main0.Process(towerModel, "WizardMonkey-Paragon");
            }
        }
    } 

}