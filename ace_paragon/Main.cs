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
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

[assembly: MelonInfo(typeof(ace_paragon.Main), ace_paragon.ModHelperData.Name, ace_paragon.ModHelperData.Version, ace_paragon.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Military;
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
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].projectile.GetBehavior<DamageModel>().immuneBloonProperties = Il2Cpp.BloonProperties.None;
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().emissionModel = em.Duplicate();
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().projectile.AddBehavior(seeking);
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().projectile.GetBehavior< CreateProjectileOnContactModel >().projectile.GetBehavior<DamageModel>().immuneBloonProperties = Il2Cpp.BloonProperties.None;
                //towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().projectile.display = "6f4aa8eecdb528144b69efee775c64f2";
                //towerModel.GetBehaviors<AttackAirUnitModel>()[1].weapons[0].GetBehavior<AlternateProjectileModel>().projectile.scale = 0.1f;

                towerModel.GetBehaviors<AttackAirUnitModel>()[1].RemoveBehavior<TargetFirstAirUnitModel>();
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].targetProvider = null;
                towerModel.GetBehaviors<AttackAirUnitModel>()[1].fireWithoutTarget = true;



                var b = Game.instance.model.GetTowerFromId("MonkeyAce-005");
                towerModel.icon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.instaIcon = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.portrait = new SpriteReference() { guidRef = b.portrait.guidRef };
                towerModel.display = b.display;

            }



        }




    }


}