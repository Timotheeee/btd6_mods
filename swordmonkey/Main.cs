using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Il2CppAssets.Main.Scenes;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Models.Powers;
using Il2CppAssets.Scripts.Models.Profile;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;

using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.StoreMenu;
using Il2CppAssets.Scripts.Unity.UI_New.Upgrade;
using Il2CppAssets.Scripts.Utils;
using Harmony;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using System.Net;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;

using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;

[assembly: MelonInfo(typeof(swordmonkey.Main), swordmonkey.ModHelperData.Name, swordmonkey.ModHelperData.Version, swordmonkey.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace swordmonkey
{

    class Main : BloonsMod
    {
        
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("swordmonkey mod loaded");

        }
        public class SwordMonkey : ModTower
        {
            public override string BaseTower => "PatFusty 20";
            public override int Cost => 500;
            public override string Description => "Hits bloons with his sword.";
            public override string DisplayName => "Sword Monkey";
            public override string Name => "SwordMonkey";
            public override int TopPathUpgrades => 5;
            public override int MiddlePathUpgrades => 5;
            public override int BottomPathUpgrades => 5;
            public override Il2CppAssets.Scripts.Models.TowerSets.TowerSet TowerSet => Il2CppAssets.Scripts.Models.TowerSets.TowerSet.Primary;
            public override void ModifyBaseTowerModel(TowerModel towerModel)
            {
                //balance stuff
                towerModel.mods = new Il2CppReferenceArray<Il2CppAssets.Scripts.Models.Towers.Mods.ApplyModModel>(0);
                towerModel.RemoveBehavior<HeroModel>();
                towerModel.RemoveBehavior<CreateSoundOnBloonEnterTrackModel>();
                towerModel.RemoveBehavior<CreateSoundOnBloonLeakModel>();
                towerModel.RemoveBehavior<CreateSoundOnSelectedModel>();
                towerModel.RemoveBehavior<AbilityModel>();
                towerModel.RemoveBehavior<AbilityModel>();
                var attack = Game.instance.model.GetTowerFromId("PatFusty").Duplicate<TowerModel>().GetBehavior<AttackModel>();//towerModel.GetBehavior<AttackModel>();
                attack.weapons[0].projectile.RemoveBehavior<CreateProjectileOnExhaustFractionModel>();
                //attack.weapons[0].GetBehavior<AlternateProjectileModel>().projectile.RemoveBehavior<BloonSlapModel>();

                //now doesnt pop leads - greenphx
                attack.weapons[0].projectile.GetBehavior<DamageModel>().immuneBloonProperties = Il2Cpp.BloonProperties.Lead;

                attack.weapons[0].projectile.RemoveBehavior<DamageModifierForTagModel>();
                attack.weapons[0].projectile.pierce = 5;
                attack.weapons[0].projectile.maxPierce = 99999;
                attack.weapons[0].projectile.CapPierce(99999);
                attack.weapons[0].projectile.scale *= 2;
                attack.weapons[0].projectile.radius *= 2;
                attack.weapons[0].projectile.GetBehavior<DamageModel>().damage = 3;
                attack.weapons[0].projectile.GetBehavior<DamageModel>().CapDamage(9999);
                attack.weapons[0].projectile.GetBehavior<DamageModel>().maxDamage = 9999;
                attack.range *= 1.3f;
                attack.weapons[0].projectile.GetBehavior<AgeModel>().Lifespan = 0.1f;
                attack.weapons[0].Rate = 1;
                towerModel.RemoveBehavior<AttackModel>();
                towerModel.AddBehavior(attack);
                towerModel.range *= 0.8f;
                towerModel.radius *= 0.8f;
                //makes sound on upgrade - greenphx
                towerModel.AddBehavior(Game.instance.model.GetTowerFromId("DartMonkey").GetBehavior<CreateSoundOnUpgradeModel>().Duplicate());
                //no longer says "max level" - greenphx
                towerModel.RemoveBehavior<CreateEffectOnUpgradeModel>();
                //creates effect when upgraded - greenphx
                towerModel.AddBehavior(Game.instance.model.GetTowerFromId("DartMonkey").GetBehavior<CreateEffectOnUpgradeModel>().Duplicate());
            }
            public override string Icon => "SwordMonkey_Icon";
            public override string Portrait => "SwordMonkey_Portrait";
        }
        public class FasterSwings : ModUpgrade<SwordMonkey>
        {
            public override string Name => "FasterSwings";
            public override string DisplayName => "Faster Swings";
            public override string Description => "Ups swinging speed";
            public override int Path => TOP;
            public override int Tier => 1;
            public override int Cost => 400;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].Rate *= 0.8f;
            }
            public override string Icon => "FasterSwings_Icon";
        }

        public class EvenFasterSwings : ModUpgrade<SwordMonkey>
        {
            public override string Name => "EvenFasterSwings";
            public override string DisplayName => "Even Faster Swings";
            public override string Description => "Ups swinging speed more";
            public override int Path => TOP;
            public override int Tier => 2;
            public override int Cost => 450;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].Rate *= 0.8f;
            }
            public override string Icon => "EvenFasterSwings_Icon";
        }

        public class DualWield : ModUpgrade<SwordMonkey>
        {
            public override string Name => "DualWield";
            public override string DisplayName => "Dual Wield";
            public override string Description => "Attacks twice as fast";
            public override int Path => TOP;
            public override int Tier => 3;
            public override int Cost => 1600;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].Rate *= 0.5f;
            }
            public override string Icon => "DualWield_Icon";
        }
        public class SynchronizedSwipes : ModUpgrade<SwordMonkey>
        {
            public override string Name => "SynchronizedSwipes";
            public override string DisplayName => "Synchronized Swipes";
            public override string Description => "Bloons near his target take 5 damage every swipe. Base attack now does 5 damage.";
            public override int Path => TOP;
            public override int Tier => 4;
            public override int Cost => 3500;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                var aoe = Game.instance.model.GetTowerFromId("PatFusty").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<CreateProjectileOnExhaustFractionModel>();
                aoe.projectile.radius = 40;
                aoe.projectile.pierce = 8;
                aoe.projectile.GetBehavior<DamageModel>().damage += 4;
                attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage += 4;
                attackModel.weapons[0].projectile.AddBehavior(aoe);
            }
            public override string Icon => "SynchronizedSwipes_Icon";
        }
        public class EliteSwordfender : ModUpgrade<SwordMonkey>
        {
            public override string Name => "EliteSwordfender";
            public override string DisplayName => "Elite Swordfender";
            public override string Description => "Swings his swords at speeds unknown to monkey kind!";
            public override int Path => TOP;
            public override int Tier => 5;
            public override int Cost => 32000;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].Rate *= 0.06f;
            }
            public override string Icon => "EliteSwordfender_Icon";
            public override string Portrait => "EliteSwordfender_Portrait";
        }

        public class Sharpen : ModUpgrade<SwordMonkey>
        {
            public override string Name => "Sharpen";
            public override string DisplayName => "Sharpen";
            public override string Description => "+2 Pierce";
            public override int Path => MIDDLE;
            public override int Tier => 1;
            public override int Cost => 750;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.pierce += 2;
            }
            public override string Icon => "Sharpen_Icon";
        }

        public class ThiccBlade : ModUpgrade<SwordMonkey>
        {
            public override string Name => "ThiccBlade";
            public override string DisplayName => "Thicc Blade";
            public override string Description => "+3 Pierce";
            public override int Path => MIDDLE;
            public override int Tier => 2;
            public override int Cost => 1300;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.pierce += 3;
            }
            public override string Icon => "ThiccBlade_Icon";
        }
        public class JavelinThrower : ModUpgrade<SwordMonkey>
        {
            public override string Name => "JavelinThrower";
            public override string DisplayName => "Javelin Thrower";
            public override string Description => "Throws javelines in a straight line (Javelins have 50 pierce, deal 6 damage)";
            public override int Path => MIDDLE;
            public override int Tier => 3;
            public override int Cost => 2000;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = Game.instance.model.GetTowerFromId("DartMonkey").GetBehavior<AttackModel>().Duplicate<AttackModel>();
                attackModel.weapons[0].projectile.pierce = 50;
                attackModel.weapons[0].projectile.maxPierce = 50;
                attackModel.weapons[0].projectile.CapPierce(50);
                attackModel.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan = 5;
                attackModel.weapons[0].projectile.GetDamageModel().damage = 6;
                attackModel.weapons[0].projectile.GetBehavior<DisplayModel>().display = new PrefabReference() { guidRef = "9717eb2059b0d6f4e9a5b500bd67a45e" }; 
                towerModel.RemoveBehavior<AttackModel>();
                towerModel.AddBehavior<AttackModel>(attackModel);
            }
            public override string Icon => "JavelinThrower_Icon";
        }
        public class HomingSpear : ModUpgrade<SwordMonkey>
        {
            public override string Name => "HomingSpear";
            public override string DisplayName => "Homing Spear";
            public override string Description => "Javelins now seek bloons and deal 10 damage";
            public override int Path => MIDDLE;
            public override int Tier => 4;
            public override int Cost => 10000;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage = 10;
                var seeking = Game.instance.model.GetTowerFromId("NinjaMonkey-001").GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<TrackTargetWithinTimeModel>().Duplicate<TrackTargetWithinTimeModel>();
                attackModel.weapons[0].projectile.AddBehavior<TrackTargetWithinTimeModel>(seeking);
            }
            public override string Icon => "HomingSpear_Icon";
        }
        public class Javalanche : ModUpgrade<SwordMonkey>
        {
            public override string Name => "Javalanche";
            public override string DisplayName => "Javalanche";
            public override string Description => "Now does a lot more damage. Ability Launches a storm of homing lances at the bloons (close range only)";
            public override int Path => MIDDLE;
            public override int Tier => 5;
            public override int Cost => 32000;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                AbilityModel abilityModel = Game.instance.model.towers.FirstOrDefault((TowerModel pat) => pat.name.Contains("Pat") && pat.tier == 20).behaviors.FirstOrDefault((Model ab) => ab.name.Contains("Rally")).Clone().Cast<AbilityModel>();
                ActivateTowerDamageSupportZoneModel a = abilityModel.behaviors.FirstOrDefault((Model AA) => AA.name.Contains("ActivateTowerDamageSupportZoneModel")).Clone().Cast<ActivateTowerDamageSupportZoneModel>();
                ActivateRateSupportZoneModel arszm = new ActivateRateSupportZoneModel(a.name, a.mutatorId, a.isUnique, 0.03f, 0.1f, 1, a.canEffectThisTower, 1, null, a.buffLocsName, a.buffIconName, a.filters, false);
                abilityModel.AddBehavior<ActivateRateSupportZoneModel>(arszm);
                abilityModel.RemoveBehavior<ActivateTowerDamageSupportZoneModel>();
                towerModel.behaviors = towerModel.behaviors.Add(abilityModel);
                attackModel.weapons[0].projectile.GetDamageModel().damage = 55;
            }
            public override string Icon => "Javalanche_Icon";
            public override string Portrait => "Javalanche_Portrait";
        }
        public class Polish : ModUpgrade<SwordMonkey>
        {
            public override string Name => "Polish";
            public override string DisplayName => "Polish";
            public override string Description => "+1 layer of damage";
            public override int Path => BOTTOM;
            public override int Tier => 1;
            public override int Cost => 350;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage += 1;
            }
            public override string Icon => "Polish_Icon";
        }
        public class HeatedBlade : ModUpgrade<SwordMonkey>
        {
            public override string Name => "HeatedBlade";
            public override string DisplayName => "Heated Blade";
            public override string Description => "+1 layer of damage";
            public override int Path => BOTTOM;
            public override int Tier => 2;
            public override int Cost => 700;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<DamageModel>().immuneBloonProperties = Il2Cpp.BloonProperties.None;
                attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage += 1;
            }
            public override string Icon => "HeatedBlade_Icon";
        }
        public class GlowBlade : ModUpgrade<SwordMonkey>
        {
            public override string Name => "GlowBlade";
            public override string DisplayName => "Glow Blade";
            public override string Description => "A heated blade that grants 7 layers of damage";
            public override int Path => BOTTOM;
            public override int Tier => 3;
            public override int Cost => 1900;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage += 2;
            }
            public override string Icon => "GlowBlade_Icon";
        }
        public class LightSaver : ModUpgrade<SwordMonkey>
        {
            public override string Name => "LightSaver";
            public override string DisplayName => "Light Saver";
            public override string Description => "Deals a lot more damage, and plus 50 to fortified bloons.";
            public override int Path => BOTTOM;
            public override int Tier => 4;
            public override int Cost => 8000;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage += 33;
                attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Fortified", 1, 50, false, false) { tags = new string[] { "Fortified" }, collisionPass = 0 });
            }
            public override string Icon => "LightSaver_Icon";
        }
        public class AntiBlimpSword : ModUpgrade<SwordMonkey>
        {
            public override string Name => "AntiBlimpSword";
            public override string DisplayName => "Anti-Blimp Sword";
            public override string Description => "Damage is massively increased depending on how big the target is. Also gains more range.";
            public override int Path => BOTTOM;
            public override int Tier => 5;
            public override int Cost => 32000;
            public override void ApplyUpgrade(TowerModel towerModel)
            {
                AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
                attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa1", "Moab", 1, 200, false, false) { tags = new string[] { "Moab" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa2", "Ddt", 1, 200, false, false) { tags = new string[] { "Ddt" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa3", "Bfb", 1, 400, false, false) { tags = new string[] { "Bfb" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa4", "Zomg", 1, 800, false, false) { tags = new string[] { "Zomg" }, collisionPass = 0 });
                attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa5", "Bad", 1, 1600, false, false) { tags = new string[] { "Bad" }, collisionPass = 0 });
                towerModel.range *= 1.5f;
                towerModel.radius *= 1.5f;
                attackModel.range *= 1.5f;
            }
            public override string Icon => "AntiBlimpSword_Icon";
            public override string Portrait => "AntiBlimpSword_Portrait";
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

                        if (!tts.namedMonkeyKey.ToLower().Contains("sword")) continue;
                        if (tts?.tower?.Node?.graphic?.transform != null)
                        {


                            var hand = tts.tower.Node.graphic.transform.FindChild("LOD_1").FindChild("MonkeyRIG").FindChild("NonkeyableGrp").FindChild("MonkeyJnt_Root").FindChild("MonkeyJnt_Spine01").FindChild("MonkeyJnt_Spine02").FindChild("MonkeyJnt_Shoulder_R").FindChild("MonkeyJnt_Arm_R").FindChild("MonkeyJnt_Hand_R");

                            if (hand != null && hand.FindChild("swordGO") == null)
                            {
                                var sword = GameObject.CreatePrimitive(PrimitiveType.Cube);
                                sword.name = "swordGO";
                                sword.transform.parent = hand;
                                sword.transform.localPosition = new Vector3(5.2f, -2, 6.889f);
                                //sword.transform.rotation = Quaternion.Euler(new Vector3(30, 344.954f, 2.140f));
                                sword.transform.localRotation = new Quaternion(-0.6f, -0.5f, 0.5f, -0.3f);
                                sword.transform.localScale = new Vector3(17.378f, 2.5f, 2.5f);
                            }

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
