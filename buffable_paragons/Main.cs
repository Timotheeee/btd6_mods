using MelonLoader;
using Harmony;

using Assets.Scripts.Unity.UI_New.InGame;

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
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Simulation.Track;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper;

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
            //public override string BaseTower => "DartMonkey-003";
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
                //towerModel.showPowerTowerBuffs = true;
                towerModel.RemoveBehavior<ParagonTowerModel>();

                var b = Game.instance.model.GetTowerFromId("DartMonkey-Paragon");
                towerModel.icon = new SpriteReference(b.portrait.guidRef);
                towerModel.instaIcon = new SpriteReference(b.portrait.guidRef);
                towerModel.portrait = new SpriteReference(b.portrait.guidRef);

            }
        }




    }

    public class Main2 : BloonsTD6Mod
    {
        public class BoomerParagon : ModTower
        {
            //public override string BaseTower => "DartMonkey-003";
            public override string BaseTower => "BoomerangMonkey-Paragon";
            public override string Name => "BoomerangMonkey-Paragon-Buffable";
            public override int Cost => 540000;
            public override string TowerSet => "Primary";
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "BoomerangMonkey Paragon Buffable";
            public override string Description => "Buffable";

            //public override string Icon => "MonkeyIcons[DartMonkeyIcon]";


            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                towerModel.isParagon = false;
                towerModel.isBakable = true;
                //towerModel.showPowerTowerBuffs = true;
                towerModel.RemoveBehavior<ParagonTowerModel>();

                var b = Game.instance.model.GetTowerFromId("BoomerangMonkey-Paragon");
                towerModel.icon = new SpriteReference(b.portrait.guidRef);
                towerModel.instaIcon = new SpriteReference(b.portrait.guidRef);
                towerModel.portrait = new SpriteReference(b.portrait.guidRef);
            }
        }
    }

}