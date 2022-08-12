using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Assets.Main.Scenes;
using Assets.Scripts.Models;
using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Models.Powers;
using Assets.Scripts.Models.Profile;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using Assets.Scripts.Models.Towers.Filters;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Models.TowerSets;
using Assets.Scripts.Unity;
using Assets.Scripts.Unity.Display;
using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Scripts.Unity.UI_New.InGame.StoreMenu;
using Assets.Scripts.Unity.UI_New.Upgrade;
using Assets.Scripts.Utils;
using Harmony;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

using UnhollowerBaseLib;
using UnityEngine;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Weapons.Behaviors;
using Assets.Scripts.Models.Towers.Weapons;
using System.Net;
using Assets.Scripts.Unity.UI_New.Popups;
using TMPro;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.TowerFilters;
using Assets.Scripts.Unity.UI_New.Main.MonkeySelect;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;

namespace handkanonier
{

    class Main : BloonsMod
    {
        //https://github.com/gurrenm3/BloonsTD6-Mod-Helper/releases

        public class Handkanonier : ModTower
        {
            public override string Name => "Handkanonier";
            public override string DisplayName => "Handkanonier";
            public override string Description => "Explodes bloons with his small but deadly gun. -Thanks David_The Superior for ideas!";
            public override string BaseTower => "BombShooter";
            public override int Cost => 900;
            public override int TopPathUpgrades => 5;
            public override int MiddlePathUpgrades => 5;
            public override int BottomPathUpgrades => 5;
            public override string TowerSet => "Military";
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                //balance stuff
                //towerModel.display = "06bf915dea753ad43b772045caf1d906";
                towerModel.display = new PrefabReference() { guidRef = "06bf915dea753ad43b772045caf1d906" };
                //towerModel.GetBehavior<DisplayModel>().display = "06bf915dea753ad43b772045caf1d906";
                towerModel.GetBehavior<DisplayModel>().display = new PrefabReference() { guidRef = "06bf915dea753ad43b772045caf1d906" };
                var attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().CapDamage(9999);
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().maxDamage = 9999;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.maxPierce = 99999;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.CapPierce(99999);
                attackModel.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan = 99;
                //attackModel.weapons[0].projectile.display = "62e990209b10d374d89f70c6f578def0";
                attackModel.weapons[0].projectile.display = new PrefabReference() { guidRef = "62e990209b10d374d89f70c6f578def0" };

                //pierce and damage
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce = 25;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage = 2;

                //change radius to 75% of 100 mortar
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 28 * 0.75f;



                //how many seconds until it shoots
                attackModel.weapons[0].Rate = 2.5f;
            }
            public override string Icon => "Handkanonier_Icon";
            public override string Portrait => "Handkanonier_Portrait";
        }
        public class EnlargedShots : ModUpgrade<Handkanonier>
        {
            public override string Name => "EnlargedShots";
            public override string DisplayName => "Enlarged Shots";
            public override string Description => "Bullets deliver larger and better popping blasts.";
            public override int Cost => 500;
            public override int Path => TOP;
            public override int Tier => 1;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce += 10;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 28 * 1.1f;
            }
            public override string Icon => "EnlargedShots_Icon";
        }
        public class NadeOptimizer : ModUpgrade<Handkanonier>
        {
            public override string Name => "NadeOptimizer";
            public override string DisplayName => "'Nade Optimizer";
            public override string Description => "Explosions affect even more bloons and deal extra damage.";
            public override int Cost => 900;
            public override int Path => TOP;
            public override int Tier => 2;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce += 15;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage += 2;
            }
            public override string Icon => "NadeOptimizer_Icon";
        }
        public class HeavyBlasts : ModUpgrade<Handkanonier>
        {
            public override string Name => "HeavyBlasts";
            public override string DisplayName => "Heavy Blasts";
            public override string Description => "Heavier impact bullets deliver thrice as much pain.";
            public override int Cost => 2000;
            public override int Path => TOP;
            public override int Tier => 3;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage += 8;
            }
            public override string Icon => "HeavyBlasts_Icon";
            public override string Portrait => "HeavyBlasts_Portrait";
        }
        public class T101Feldhaubitz : ModUpgrade<Handkanonier>
        {
            public override string Name => "T101Feldhaubitz";
            public override string DisplayName => "T-101 Feldhaubitz";
            public override string Description => "Upgrade the sidearm to a heavy duty bullet launcher; damage and blast radius are greatly increased.";
            public override int Cost => 9000;
            public override int Path => TOP;
            public override int Tier => 4;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage += 33;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce += 50;
                attackModel.weapons[0].Rate = 1.75f;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 28 * 1.65f;
            }
            public override string Icon => "T101Feldhaubitz_Icon";
            public override string Portrait => "T101Feldhaubitz_Portrait";
        }
        public class TheBigBang : ModUpgrade<Handkanonier>
        {
            public override string Name => "TheBigBang";
            public override string DisplayName => "The Big Bang";
            public override string Description => "These explosions can be seen from miles away!";
            public override int Cost => 30000;
            public override int Path => TOP;
            public override int Tier => 5;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 80 * 1.35f;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage += 85;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce += 50;
            }
            public override string Icon => "TheBigBang_Icon";
            public override string Portrait => "TheBigBang_Portrait";
        }
        public class QuickdrawSight : ModUpgrade<Handkanonier>
        {
            public override string Name => "QuickdrawSight";
            public override string DisplayName => "Quickdraw Sight";
            public override string Description => "Visual training allows Handkanonier to target Camo Bloons.";
            public override int Cost => 450;
            public override int Path => MIDDLE;
            public override int Tier => 1;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.AddBehavior(new OverrideCamoDetectionModel("OverrideCamoDetectionModel_", true));
            }
            public override string Icon => "QuickdrawSight_Icon";
        }
        public class Tenacious : ModUpgrade<Handkanonier>
        {
            public override string Name => "Tenacious";
            public override string DisplayName => "Tenacious";
            public override string Description => "The explosive aftershow pops even more bloons over time.";
            public override int Cost => 900;
            public override int Path => MIDDLE;
            public override int Tier => 2;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                var fire = Game.instance.model.GetTowerFromId("MortarMonkey-002").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<CreateProjectileOnExhaustFractionModel>().projectile.GetBehavior<AddBehaviorToBloonModel>();
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(fire);
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.collisionPasses = new int[] { 0, -1 };
            }
            public override string Icon => "Tenacious_Icon";
        }
        public class Adaptive : ModUpgrade<Handkanonier>
        {
            public override string Name => "Adaptive";
            public override string DisplayName => "Adaptive";
            public override string Description => "Shots now pop Thermal Bloons and deal bonus damage to Armored Bloons.";
            public override int Cost => 900;
            public override int Path => MIDDLE;
            public override int Tier => 3;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();


                var normal = Game.instance.model.GetTowerFromId("BombShooter-050").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>();
                normal.setDamage(3);
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.RemoveBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(normal);
             
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Fortified", 1, 10, false, false) { tags = new string[] { "Fortified" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ceramic", 1, 10, false, false) { tags = new string[] { "Ceramic" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Moab", 1, 10, false, false) { tags = new string[] { "Moab" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bfb", 1, 10, false, false) { tags = new string[] { "Bfb" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Zomg", 1, 10, false, false) { tags = new string[] { "Zomg" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ddt", 1, 10, false, false) { tags = new string[] { "Ddt" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bad", 1, 10, false, false) { tags = new string[] { "Bad" }, collisionPass = 0 });
            }
            public override string Icon => "Adaptive_Icon";
        }
        public class BouncyShots : ModUpgrade<Handkanonier>
        {
            public override string Name => "BouncyShots";
            public override string DisplayName => "Bouncy Shots";
            public override string Description => "Shots bounce twice to other bloons upon detonation.";
            public override int Cost => 2700;
            public override int Path => MIDDLE;
            public override int Tier => 4;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.pierce += 3;
                var bouncy = Game.instance.model.GetTowerFromId("SniperMonkey-030").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<RetargetOnContactModel>();
                bouncy.distance = 100;
                attackModel.weapons[0].projectile.AddBehavior(bouncy);
            }
            public override string Icon => "BouncyShots_Icon";
            public override string Portrait => "BouncyShots_Portrait";
        }
        public class ExplosivesSpecialist : ModUpgrade<Handkanonier>
        {
            public override string Name => "ExplosivesSpecialist";
            public override string DisplayName => "Explosives Specialist";
            public override string Description => "Shots deal increased bonus damage to Armored Bloons. Explosives Specialist ability: Mortars and bombs nearby attack twice as fast for 15 seconds.";
            public override int Cost => 22500;
            public override int Path => MIDDLE;
            public override int Tier => 5;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                //balance stuff
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Fortified", 1, 30, false, false) { tags = new string[] { "Fortified" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ceramic", 1, 30, false, false) { tags = new string[] { "Ceramic" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Moab", 1, 30, false, false) { tags = new string[] { "Moab" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bfb", 1, 30, false, false) { tags = new string[] { "Bfb" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Zomg", 1, 30, false, false) { tags = new string[] { "Zomg" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ddt", 1, 30, false, false) { tags = new string[] { "Ddt" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bad", 1, 30, false, false) { tags = new string[] { "Bad" }, collisionPass = 0 });

                var ability = Game.instance.model.GetTowerFromId("AdmiralBrickell 3").Duplicate<TowerModel>().GetBehavior<AbilityModel>();
                ability.GetBehavior<ActivateRateSupportZoneModel>().filters[0] = new FilterInBaseTowerIdModel("lol", new string[] { "BombShooter", "MortarMonkey" });
                towerModel.AddBehavior(ability);
            }
            public override string Icon => "ExplosivesSpecialist_Icon";
            public override string Portrait => "ExplosivesSpecialist_Portrait";
        }
        public class NimbleHands : ModUpgrade<Handkanonier>
        {
            public override string Name => "NimbleHands";
            public override string DisplayName => "Nimble Hands";
            public override string Description => "New clip holder allows for faster reloading.";
            public override int Cost => 400;
            public override int Path => BOTTOM;
            public override int Tier => 1;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].Rate *= 0.8f;
            }
            public override string Icon => "NimbleHands_Icon";
        }
        public class TacticalLobber : ModUpgrade<Handkanonier>
        {
            public override string Name => "TacticalLobber";
            public override string DisplayName => "Tactical Lobber";
            public override string Description => "Handkanonier shoots behind cover when the Bloons least expect it.";
            public override int Cost => 650;
            public override int Path => BOTTOM;
            public override int Tier => 2;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                towerModel.ignoreBlockers = true;
                attackModel.weapons[0].projectile.ignoreBlockers = true;
                attackModel.weapons[0].projectile.canCollisionBeBlockedByMapLos = false;
                attackModel.attackThroughWalls = true;
            }
            public override string Icon => "TacticalLobber_Icon";
        }
        public class EMB : ModUpgrade<Handkanonier>
        {
            public override string Name => "EMB";
            public override string DisplayName => "EMB";
            public override string Description => "Electro-magnetic Bombs generate a powerful energy pulse in contact with Bloons.";
            public override int Cost => 1500;
            public override int Path => BOTTOM;
            public override int Tier => 3;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                var lasershock = Game.instance.model.GetTowerFromId("DartlingGunner-200").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<AddBehaviorToBloonModel>();
                lasershock.lifespan = 4;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(lasershock);
                attackModel.weapons[0].projectile.AddBehavior(lasershock);
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.collisionPasses = new int[] { 0, 1 };
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage += 3;
            }
            public override string Icon => "EMB_Icon";
        }
        public class T102Jagdfaust : ModUpgrade<Handkanonier>
        {
            public override string Name => "T102Jagdfaust";
            public override string DisplayName => "T-102 Jagdfaust";
            public override string Description => "Converts to a powerful energy blaster; explosions pierce with each hit.";
            public override int Cost => 6000;
            public override int Path => BOTTOM;
            public override int Tier => 4;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.pierce += 4f;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage += 2;
                attackModel.weapons[0].Rate *= 0.8f;
            }
            public override string Icon => "T102Jagdfaust_Icon";
            public override string Portrait => "T102Jagdfaust_Portrait";
        }
        public class Zerfallen : ModUpgrade<Handkanonier>
        {
            public override string Name => "Zerfallen";
            public override string DisplayName => "Zerfallen";
            public override string Description => "Generates massive piercing energy balls that 'decay' every bloon from their path. Watch out for the end result!";
            public override int Cost => 200000;
            public override int Path => BOTTOM;
            public override int Tier => 5;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce += 100;
                attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage += 600;
                var genericDamage = Game.instance.model.GetTowerFromId("DartlingGunner").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<DamageModel>();
                attackModel.weapons[0].projectile.AddBehavior(genericDamage);
                attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage += 500;
                attackModel.weapons[0].projectile.pierce += 50;
                attackModel.weapons[0].projectile.display = new PrefabReference() { guidRef = "88399aeca4ae48a44aee5b08eb16cc61" };

            }
            public override string Icon => "Zerfallen_Icon";
            public override string Portrait => "Zerfallen_Portrait";
        }



        [HarmonyPatch(typeof(InGame), "Update")]
        public class Update_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                if (!(InGame.instance != null && InGame.instance.bridge != null)) return;
                try
                {
                    foreach (var tts in InGame.Bridge.GetAllTowers())
                    {

                        if (!tts.namedMonkeyKey.ToLower().Contains("handkanonier")) continue;
                        if (tts?.tower?.Node?.graphic?.transform != null)
                        {
                            tts.tower.Node.graphic.transform.localScale = new UnityEngine.Vector3(1.3f, 1.3f, 1.3f);

                        }

                    }
                }
                catch
                {

                }


            }
        }


    }
}
