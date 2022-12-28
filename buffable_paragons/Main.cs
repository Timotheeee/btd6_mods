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
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper;

[assembly: MelonInfo(typeof(buffable_paragons.Main), buffable_paragons.ModHelperData.Name, buffable_paragons.ModHelperData.Version, buffable_paragons.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace buffable_paragons
{
    public class Main : BloonsTD6Mod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("buffable_paragons loaded");
        }



        public class DartParagon : ModTower
        {
            public override string BaseTower => "DartMonkey-Paragon";
            public override string Name => "DartMonkey-Paragon-Buffable";
            public override int Cost => 450000;
            public override string TowerSet => "Primary";
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "DartMonkey Paragon Buffable";
            public override string Description => "Buffable";

            public override string Icon => "3906afef12a8fab4db780428c3b8a50b";

            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.isParagon = false;
                towerModel.isBakable = true;
                towerModel.RemoveBehavior<ParagonTowerModel>();

                var b = Game.instance.model.GetTowerFromId("DartMonkey-Paragon");
                towerModel.icon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.instaIcon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.portrait = new SpriteReference() { guidRef = b.portrait.guidRef };

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
            public override string TowerSet => "Primary";
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "MonkeyBuccaneer Paragon Buffable";
            public override string Description => "Buffable";



            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.isParagon = false;
                towerModel.isBakable = true;
                towerModel.RemoveBehavior<ParagonTowerModel>();

                var b = Game.instance.model.GetTowerFromId("MonkeyBuccaneer-Paragon");
                towerModel.icon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.instaIcon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.portrait = new SpriteReference() { guidRef = b.portrait.guidRef };
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
            public override string TowerSet => "Primary";
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "BoomerangMonkey Paragon Buffable";
            public override string Description => "Buffable";


            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.isParagon = false;
                towerModel.isBakable = true;
                towerModel.RemoveBehavior<ParagonTowerModel>();

                var b = Game.instance.model.GetTowerFromId("BoomerangMonkey-Paragon");
                towerModel.icon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.instaIcon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.portrait = new SpriteReference() { guidRef = b.portrait.guidRef };
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
            public override string TowerSet => "Primary";
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "NinjaMonkey Paragon Buffable";
            public override string Description => "Buffable";



            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.isParagon = false;
                towerModel.isBakable = true;
                towerModel.RemoveBehavior<ParagonTowerModel>();

                var b = Game.instance.model.GetTowerFromId("NinjaMonkey-Paragon");
                towerModel.icon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.instaIcon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.portrait = new SpriteReference() { guidRef = b.portrait.guidRef };
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
            public override string TowerSet => "Primary";
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "EngineerMonkey Paragon Buffable";
            public override string Description => "Buffable";



            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.isParagon = false;
                towerModel.isBakable = true;
                towerModel.RemoveBehavior<ParagonTowerModel>();

                var b = Game.instance.model.GetTowerFromId("EngineerMonkey-Paragon");
                towerModel.icon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.instaIcon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.portrait = new SpriteReference() { guidRef = b.portrait.guidRef };
            }
        }
    }

}