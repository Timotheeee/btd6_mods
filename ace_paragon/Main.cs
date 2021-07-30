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
using Assets.Scripts.Models.Towers.Weapons.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.Towers.Weapons;

namespace ace_paragon
{
    public class Main : BloonsTD6Mod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("ace_paragon loaded");
        }



        public class AceParagon : ModTower
        {
            //public override string BaseTower => "DartMonkey-003";
            public override string BaseTower => "MonkeyAce-204";
            public override string Name => "AceParagon";
            public override int Cost => 500000;
            public override string TowerSet => "Military";
            public override int TopPathUpgrades => 0;
            public override int MiddlePathUpgrades => 0;
            public override int BottomPathUpgrades => 0;
            public override string DisplayName => "Ace Paragon";
            public override string Description => "pog";


            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                var em = Game.instance.model.GetTowerFromId("MonkeyAce-500").GetBehaviors<AttackAirUnitModel>()[0].weapons[0].emission;
                var seeking = Game.instance.model.GetTowerFromId("NinjaMonkey-001").GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<TrackTargetWithinTimeModel>().Duplicate();
                var tsar = Game.instance.model.GetTowerFromId("MonkeyAce-050").GetBehavior<AbilityModel>().Duplicate();
                tsar.Cooldown = 8;
                tsar.GetBehavior<ActivateAttackModel>().attacks[0].weapons[0].projectile.GetBehavior<SlowModel>().Lifespan = 0.2f;
                towerModel.AddBehavior(tsar);
                towerModel.AddBehavior(new OverrideCamoDetectionModel("a",true));


                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].emission = em.Duplicate();
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].projectile.RemoveBehavior<TrackTargetModel>();
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].projectile.AddBehavior(seeking);
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].projectile.GetBehavior<DamageModel>().immuneBloonProperties = BloonProperties.None;
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().emissionModel = em.Duplicate();
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().projectile.AddBehavior(seeking);
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().projectile.GetBehavior< CreateProjectileOnContactModel >().projectile.GetBehavior<DamageModel>().immuneBloonProperties = BloonProperties.None;
                //towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().projectile.display = "6f4aa8eecdb528144b69efee775c64f2";
                //towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().projectile.scale = 0.1f;

                towerModel.GetBehaviors<AttackAirUnitModel>()[1].RemoveBehavior<TargetFirstAirUnitModel>();
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].targetProvider = null;
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].fireWithoutTarget = true;



                var b = Game.instance.model.GetTowerFromId("MonkeyAce-005");
                towerModel.icon = new SpriteReference(b.portrait.guidRef);
                towerModel.instaIcon = new SpriteReference(b.portrait.guidRef);
                towerModel.portrait = new SpriteReference(b.portrait.guidRef);
                towerModel.display = b.display;

            }



        }




    }


}