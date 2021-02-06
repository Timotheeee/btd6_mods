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
using Assets.Scripts.Unity.Localization;
using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Scripts.Unity.UI_New.InGame.StoreMenu;
using Assets.Scripts.Unity.UI_New.Upgrade;
using Assets.Scripts.Utils;
using Harmony;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

using UnhollowerBaseLib;
using UnityEngine;
using BloonsTD6_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Weapons.Behaviors;
using Assets.Scripts.Models.Towers.Weapons;
using System.Net;
using Assets.Scripts.Unity.UI_New.Popups;
using TMPro;

namespace swordmonkey
{

    class Main : MelonMod
    {
        //https://github.com/gurrenm3/BloonsTD6-Mod-Helper/releases
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();

            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("swordmonkey mod loaded");
            if (!File.Exists("Mods/BloonsTD6.Mod.Helper.dll"))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://github.com/gurrenm3/BloonsTD6-Mod-Helper/releases/download/0.0.2/BloonsTD6.Mod.Helper.dll", "Mods/BloonsTD6.Mod.Helper.dll");
                    File.Delete("Mods/BloonsTD6_Mod_Helper.dll");
                }
                Console.WriteLine("Downloaded BloonsTD6.Mod.Helper.dll");
                Console.WriteLine("Restart required");
                Application.Quit(0);

            }
        }


        static string customTowerImageID;
        static string customTowerName = "swordmonkey";
        static string customTowerDisplayName = "Sword Monkey";
        static string customTowerDisplay = "60ec4c22a4deef445b076b538de9c2e4";

        static string customTowerUpgrade1Top = "Faster Swings";
        static string customTowerUpgrade2Top = "Even Faster Swings";
        static string customTowerUpgrade3Top = "Dual Wield";
        static string customTowerUpgrade4Top = "Synchronized Swipes";
        static string customTowerUpgrade5Top = "Elite Swordfender";
        static string customTowerDescription1Top = "Ups swinging speed";
        static string customTowerDescription2Top = "Ups swinging speed more";
        static string customTowerDescription3Top = "Attacks twice as fast.";
        static string customTowerDescription4Top = "Bloons near his target take 5 damage every swipe. Base attack now does 5 damage.";
        static string customTowerDescription5Top = "Swings his swords at speeds unknown to monkey kind!";

        static string customTowerUpgrade1Mid = "Sharpen";
        static string customTowerUpgrade2Mid = "Thicc Blade";
        static string customTowerUpgrade3Mid = "Javelin Thrower";
        static string customTowerUpgrade4Mid = "Homing Spear";
        static string customTowerUpgrade5Mid = "Javalanche";
        static string customTowerDescription1Mid = "+2 Pierce";
        static string customTowerDescription2Mid = "+3 Pierce";
        static string customTowerDescription3Mid = "Throws javelines in a straight line (Javelins have 50 pierce, deal 6 damage)";
        static string customTowerDescription4Mid = "Javelins now seek bloons and deal 10 damage";
        static string customTowerDescription5Mid = "Now does a lot more damage. Ability Launches a storm of homing lances at the bloons (close range only)";

        static string customTowerUpgrade1Bottom = "Polish";
        static string customTowerUpgrade2Bottom = "Heated Blade";
        static string customTowerUpgrade3Bottom = "Glow Blade";
        static string customTowerUpgrade4Bottom = "Light Saver";
        static string customTowerUpgrade5Bottom = "Anti-Blimp Sword";
        static string customTowerDescription1Bottom = "+1 layer of damage";
        static string customTowerDescription2Bottom = "+1 layer of damage";
        static string customTowerDescription3Bottom = "A heated blade that grants 7 layers of damage";
        static string customTowerDescription4Bottom = "Deals a lot more damage, and plus 50 to fortified bloons.";
        static string customTowerDescription5Bottom = "Damage is massively increased depending on how big the target is. Also gains more range.";

        static string customTowerImages = @"Mods/swordmonkey/";
        static string customTowerImageLocation = customTowerImages + "swordmonkey.png";
        static string customTowerTowerSet = "Primary";
        static int customTowerTowerIndex = 3;

 


        static string[] upgrades = new string[]
{
                customTowerUpgrade1Top,
                customTowerUpgrade2Top,
                customTowerUpgrade3Top,
                customTowerUpgrade4Top,
                customTowerUpgrade5Top,
                customTowerUpgrade1Mid,
                customTowerUpgrade2Mid,
                customTowerUpgrade3Mid,
                customTowerUpgrade4Mid,
                customTowerUpgrade5Mid,
                customTowerUpgrade1Bottom,
                customTowerUpgrade2Bottom,
                customTowerUpgrade3Bottom,
                customTowerUpgrade4Bottom,
                customTowerUpgrade5Bottom,
};
        static string[] upgradeDescriptions = new string[]
        {
                customTowerDescription1Top,
                customTowerDescription2Top,
                customTowerDescription3Top,
                customTowerDescription4Top,
                customTowerDescription5Top,
                customTowerDescription1Mid,
                customTowerDescription2Mid,
                customTowerDescription3Mid,
                customTowerDescription4Mid,
                customTowerDescription5Mid,
                customTowerDescription1Bottom,
                customTowerDescription2Bottom,
                customTowerDescription3Bottom,
                customTowerDescription4Bottom,
                customTowerDescription5Bottom,
        };



        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {

            [HarmonyPostfix]
            public static void Postfix()
            {
                if (!Directory.Exists("Mods/swordmonkey/"))
                {
                    File.WriteAllBytes("Mods/swordmonkey.zip", Resource1.swordmonkey);
                    System.IO.Compression.ZipFile.ExtractToDirectory("Mods/swordmonkey.zip", "Mods/");
                    File.Delete("Mods/swordmonkey.zip");
                }


                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImageLocation, default, out customTowerImageID);

                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "100.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "200.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "300.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "400.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "500.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "010.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "020.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "030.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "040.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "050.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "001.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "002.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "003.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "004.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "005.PNG", default);

                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "500portrait.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "050portrait.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "005portrait.PNG", default);







                Console.WriteLine("initializing " + customTowerName);

                if (!LocalizationManager.instance.textTable.ContainsKey(customTowerName))
                {
                    LocalizationManager.instance.textTable.Add(customTowerName, customTowerDisplayName);
                }


                for (int i = 0; i < upgrades.Length; i++)
                {
                    if (!LocalizationManager.instance.textTable.ContainsKey(upgrades[i] + " Description"))
                    {
                        LocalizationManager.instance.textTable.Add(upgrades[i] + " Description", upgradeDescriptions[i]);
                    }
                }


                Il2CppSystem.Collections.Generic.List<UpgradeModel> list = new Il2CppSystem.Collections.Generic.List<UpgradeModel>();
                list.Add(new UpgradeModel(customTowerUpgrade1Top, 400, 0, new SpriteReference(customTowerImages + "100.PNG"), 0, 1, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade2Top, 450, 0, new SpriteReference(customTowerImages + "200.PNG"), 0, 2, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade3Top, 1600, 0, new SpriteReference(customTowerImages + "300.PNG"), 0, 3, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade4Top, 3500, 0, new SpriteReference(customTowerImages + "400.PNG"), 0, 4, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade5Top, 32000, 0, new SpriteReference(customTowerImages + "500.PNG"), 0, 5, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade1Mid, 750, 0, new SpriteReference(customTowerImages + "010.PNG"), 1, 1, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade2Mid, 1300, 0, new SpriteReference(customTowerImages + "020.PNG"), 1, 2, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade3Mid, 2000, 0, new SpriteReference(customTowerImages + "030.PNG"), 1, 3, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade4Mid, 10000, 0, new SpriteReference(customTowerImages + "040.PNG"), 1, 4, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade5Mid, 32000, 0, new SpriteReference(customTowerImages + "050.PNG"), 1, 5, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade1Bottom, 350, 0, new SpriteReference(customTowerImages + "001.PNG"), 2, 1, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade2Bottom, 700, 0, new SpriteReference(customTowerImages + "002.PNG"), 2, 2, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade3Bottom, 1900, 0, new SpriteReference(customTowerImages + "003.PNG"), 2, 3, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade4Bottom, 8000, 0, new SpriteReference(customTowerImages + "004.PNG"), 2, 4, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade5Bottom, 32000, 0, new SpriteReference(customTowerImages + "005.PNG"), 2, 5, 0, "", ""));

                Game.instance.model.upgrades = Game.instance.model.upgrades.Add(list);
                Il2CppSystem.Collections.Generic.List<TowerModel> list2 = new Il2CppSystem.Collections.Generic.List<TowerModel>();
                list2.Add(getT0(Game.instance.model));
                list2.Add(getT1Top(Game.instance.model));
                list2.Add(getT2Top(Game.instance.model));
                list2.Add(getT3Top(Game.instance.model));
                list2.Add(getT4Top(Game.instance.model));
                list2.Add(getT5Top(Game.instance.model));
                list2.Add(getT1Mid(Game.instance.model));
                list2.Add(getT2Mid(Game.instance.model));
                list2.Add(getT3Mid(Game.instance.model));
                list2.Add(getT4Mid(Game.instance.model));
                list2.Add(getT5Mid(Game.instance.model));
                list2.Add(getT1Bottom(Game.instance.model));
                list2.Add(getT2Bottom(Game.instance.model));
                list2.Add(getT3Bottom(Game.instance.model));
                list2.Add(getT4Bottom(Game.instance.model));
                list2.Add(getT5Bottom(Game.instance.model));
                Game.instance.model.towers = Game.instance.model.towers.Add(list2);
                Il2CppSystem.Collections.Generic.List<TowerDetailsModel> list3 = new Il2CppSystem.Collections.Generic.List<TowerDetailsModel>();
                foreach (TowerDetailsModel item in Game.instance.model.towerSet)
                {
                    list3.Add(item);
                }
                ShopTowerDetailsModel newPart = new ShopTowerDetailsModel(customTowerName, customTowerTowerIndex, 5, 5, 5, -1, 0, null);
                Game.instance.model.towerSet = Game.instance.model.towerSet.Add(newPart);
                bool flag = false;
                foreach (TowerDetailsModel towerDetailsModel in Game.instance.model.towerSet)
                {
                    if (flag)
                    {
                        int towerIndex = towerDetailsModel.towerIndex;
                        towerDetailsModel.towerIndex = towerIndex + 1;
                    }
                    if (towerDetailsModel.towerId.Contains(customTowerName))
                    {
                        flag = true;
                    }
                }
                Console.WriteLine(customTowerName + " initialized");

            }
        }





        public static TowerModel getT0(GameModel gameModel)
        {
            TowerModel towerModel = gameModel.GetTowerFromId("PatFusty 20").Duplicate<TowerModel>();
            towerModel.name = customTowerName;
            towerModel.baseId = customTowerName;
            towerModel.portrait = new SpriteReference(customTowerImageID);
            towerModel.display = customTowerDisplay;
            towerModel.GetBehavior<DisplayModel>().display = customTowerDisplay;
            towerModel.towerSet = customTowerTowerSet;
            towerModel.dontDisplayUpgrades = false;
            towerModel.cost = 500;
            towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[]
            {
                        new UpgradePathModel(customTowerUpgrade1Top, customTowerName + "-100", 1, 1),
                        new UpgradePathModel(customTowerUpgrade1Mid, customTowerName + "-010", 1, 1),
                        new UpgradePathModel(customTowerUpgrade1Bottom, customTowerName + "-001", 1, 1),
            });
            towerModel.tiers = new int[] { 0, 0, 0 };


            //balance stuff
            towerModel.mods = new Il2CppReferenceArray<Assets.Scripts.Models.Towers.Mods.ApplyModModel>(0);
            towerModel.RemoveBehavior<HeroModel>();
            towerModel.RemoveBehavior<CreateSoundOnBloonEnterTrackModel>();
            towerModel.RemoveBehavior<CreateSoundOnBloonLeakModel>();
            towerModel.RemoveBehavior<CreateSoundOnSelectedModel>();
            towerModel.RemoveBehavior<AbilityModel>();
            towerModel.RemoveBehavior<AbilityModel>();
            var attack = gameModel.GetTowerFromId("PatFusty").Duplicate<TowerModel>().GetBehavior<AttackModel>();//towerModel.GetBehavior<AttackModel>();
            attack.weapons[0].projectile.RemoveBehavior<CreateProjectileOnExhaustFractionModel>();
            //attack.weapons[0].GetBehavior<AlternateProjectileModel>().projectile.RemoveBehavior<BloonSlapModel>();

            //wtf why does it still pop leads
            attack.weapons[0].projectile.GetBehavior<DamageModel>().damageTypes[0] = "Sharp";
            attack.weapons[0].projectile.GetBehavior<DamageModel>().ignoreImmunityForBloonTypes = new Il2CppStringArray(0);

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

            FileIOUtil.SaveObject("sword0.json", towerModel);

            return towerModel;

        }




        public static TowerModel getT1Top(GameModel gameModel)
        {
            TowerModel towerModel = getT0(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 1, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].Rate *= 0.8f;

            return towerModel;
        }


        public static TowerModel getT2Top(GameModel gameModel)
        {
            TowerModel towerModel = getT1Top(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 2, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].Rate *= 0.8f;
            return towerModel;
        }


        public static TowerModel getT3Top(GameModel gameModel)
        {
            TowerModel towerModel = getT2Top(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 3, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);
            //2 swords
            towerModel.display = customTowerDisplay;
            towerModel.GetBehavior<DisplayModel>().display = customTowerDisplay;

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].Rate *= 0.5f;


            return towerModel;
        }


        public static TowerModel getT4Top(GameModel gameModel)
        {
            TowerModel towerModel = getT3Top(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 4, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            var aoe = gameModel.GetTowerFromId("PatFusty").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<CreateProjectileOnExhaustFractionModel>();
            aoe.projectile.radius = 40;
            aoe.projectile.pierce = 8;
            aoe.projectile.GetBehavior<DamageModel>().damage = 5;
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage = 5;
            attackModel.weapons[0].projectile.AddBehavior(aoe);
            return towerModel;
        }


        public static TowerModel getT5Top(GameModel gameModel)
        {
            TowerModel towerModel = getT4Top(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 5, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImages + "500portrait.PNG");


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].Rate *= 0.06f;
            //attackModel.weapons[0].projectile.pierce = 8;
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnExhaustFractionModel>().projectile.pierce = 8; ;

            return towerModel;
        }


        public static TowerModel getT1Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT0(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 1, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.pierce = 7;

            return towerModel;
        }


        public static TowerModel getT2Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT1Mid(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 2, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.pierce = 10;
            return towerModel;
        }


        public static TowerModel getT3Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT2Mid(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 3, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);


            //balance stuff
            AttackModel attackModel = gameModel.GetTowerFromId("DartMonkey").GetBehavior<AttackModel>().Duplicate<AttackModel>();
            attackModel.weapons[0].projectile.pierce = 50;
            attackModel.weapons[0].projectile.maxPierce = 50;
            attackModel.weapons[0].projectile.CapPierce(50);
            attackModel.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan = 5;
            attackModel.weapons[0].projectile.GetDamageModel().damage = 6;
            attackModel.weapons[0].projectile.GetBehavior<DisplayModel>().display = "9717eb2059b0d6f4e9a5b500bd67a45e";
            attackModel.weapons[0].projectile.display = "9717eb2059b0d6f4e9a5b500bd67a45e";
            towerModel.RemoveBehavior<AttackModel>();
            towerModel.AddBehavior<AttackModel>(attackModel);


            return towerModel;
        }


        public static TowerModel getT4Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT3Mid(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 4, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage = 10;
            var seeking = gameModel.GetTowerFromId("NinjaMonkey-001").GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<TrackTargetWithinTimeModel>().Duplicate<TrackTargetWithinTimeModel>();
            attackModel.weapons[0].projectile.AddBehavior<TrackTargetWithinTimeModel>(seeking);
            return towerModel;
        }


        public static TowerModel getT5Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT4Mid(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 5, 0);
            towerModel.portrait = new SpriteReference(customTowerImages + "050portrait.PNG");


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            AbilityModel abilityModel = gameModel.towers.FirstOrDefault((TowerModel pat) => pat.name.Contains("Pat") && pat.tier == 20).behaviors.FirstOrDefault((Model ab) => ab.name.Contains("Rally")).Clone().Cast<AbilityModel>();
            abilityModel.icon = new SpriteReference(customTowerImageID);
            ActivateTowerDamageSupportZoneModel a = abilityModel.behaviors.FirstOrDefault((Model AA) => AA.name.Contains("ActivateTowerDamageSupportZoneModel")).Clone().Cast<ActivateTowerDamageSupportZoneModel>();
            ActivateRateSupportZoneModel arszm = new ActivateRateSupportZoneModel(a.name, a.mutatorId, a.isUnique, 0.03f, 0.1f, 1, a.canEffectThisTower, 1, null, a.buffLocsName, a.buffIconName, a.filters, false);
            abilityModel.AddBehavior<ActivateRateSupportZoneModel>(arszm);
            abilityModel.RemoveBehavior<ActivateTowerDamageSupportZoneModel>();
            towerModel.behaviors = towerModel.behaviors.Add(abilityModel);
            attackModel.weapons[0].projectile.GetDamageModel().damage = 55;

            return towerModel;
        }



        public static TowerModel getT1Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT0(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 1);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage = 4;

            return towerModel;
        }


        public static TowerModel getT2Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT1Bottom(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 2);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damageTypes[0] = "Normal";
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage = 5;
            //FileIOUtil.SaveObject("sword2.json", towerModel);
            return towerModel;
        }


        public static TowerModel getT3Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT2Bottom(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 3);
            towerModel.portrait = new SpriteReference(customTowerImageID);
            //2 swords
            towerModel.display = customTowerDisplay;
            towerModel.GetBehavior<DisplayModel>().display = customTowerDisplay;

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage = 7;


            return towerModel;
        }


        public static TowerModel getT4Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT3Bottom(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 4);
            towerModel.portrait = new SpriteReference(customTowerImageID);


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damage = 40;
            attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Fortified", 1, 50, false, false) { tags = new string[] { "Fortified" }, collisionPass = 0 });
            return towerModel;
        }


        public static TowerModel getT5Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT4Bottom(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 5);
            towerModel.portrait = new SpriteReference(customTowerImages + "005portrait.PNG");


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa1", "Moab", 1, 200, false, false) { tags = new string[] { "Moab" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa2", "Ddt", 1, 200, false, false) { tags = new string[] { "Ddt" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa3", "Bfb", 1, 400, false, false) { tags = new string[] { "Bfb" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa4", "Zomg", 1, 800, false, false) { tags = new string[] { "Zomg" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.AddBehavior(new DamageModifierForTagModel("aaa5", "Bad", 1, 1600, false, false) { tags = new string[] { "Bad" }, collisionPass = 0 });
            towerModel.range *= 1.5f;
            towerModel.radius *= 1.5f;
            attackModel.range *= 1.5f;


            return towerModel;
        }





        [HarmonyPatch(typeof(ProfileModel), "Validate")]
        public class ProfileModel_Patch
        {

            [HarmonyPostfix]
            public static void Postfix(ref ProfileModel __instance)
            {
                Il2CppSystem.Collections.Generic.List<string> unlockedTowers = __instance.unlockedTowers;
                Il2CppSystem.Collections.Generic.List<string> acquiredUpgrades = __instance.acquiredUpgrades;
                if (!unlockedTowers.Contains(customTowerName))
                {
                    unlockedTowers.Add(customTowerName);
                }
                //string[] array = new string[]
                //{
                //    customTowerUpgrade1Mid,
                //    customTowerUpgrade2Mid,
                //    customTowerUpgrade3Mid,
                //    customTowerUpgrade4Mid,
                //    customTowerUpgrade5Mid
                //};
                for (int i = 0; i < upgrades.Length; i++)
                {
                    if (!acquiredUpgrades.Contains(upgrades[i]))
                    {
                        acquiredUpgrades.Add(upgrades[i]);
                    }
                }
            }
        }


        [HarmonyPatch(typeof(StandardTowerPurchaseButton), "SetTower")]
        private class SetTower
        {

            [HarmonyPrefix]
            internal static bool Fix(ref StandardTowerPurchaseButton __instance, ref TowerModel towerModel, ref bool showTowerCount, ref bool hero, ref int buttonIndex)
            {
                if (towerModel.baseId.Contains(customTowerName))
                {
                    __instance.UpdateTowerDisplay();
                    Texture2D pngTexture = TextureFromPNG(customTowerImageLocation);
                    Sprite temp = Sprite.Create(pngTexture, new Rect(0.0f, 0.0f, pngTexture.width, pngTexture.height), default);
                    __instance.bg.sprite = temp;
                    __instance.icon.sprite = temp;
                    __instance.icon.overrideSprite = temp;
                    __instance.icon.material.mainTexture = temp.texture;
                    __instance.UpdateIcon();
                }
                return true;
            }
        }



        //Utility
        public static void SetTiersAndUpgrades(ref TowerModel towerModel, int top, int mid, int bottom)
        {
            towerModel.name = customTowerName + "-" + top + "" + mid + "" + bottom + "";
            towerModel.tiers = new int[] { top, mid, bottom };
            towerModel.tier = towerModel.tiers.Max();

            if (towerModel.tier != 5)
            {
                int pathUsed = towerModel.tiers.IndexOf(towerModel.tier);
                string nextUpgrade = upgrades[pathUsed * 5 + towerModel.tier];
                towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[]
                {
                    new UpgradePathModel(nextUpgrade, customTowerName + "-" + (pathUsed==0 ? top+1:top) + "" + (pathUsed==1 ? mid+1:mid) + "" + (pathUsed==2 ? bottom+1:bottom) + "", 1, towerModel.tier+1)
                });

            }
            else
            {
                towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[]
                {

                });
            }




        }


        //Utility
        public static Texture2D TextureFromPNG(string path)
        {
            Texture2D text = new Texture2D(2, 2);

            if (!ImageConversion.LoadImage(text, File.ReadAllBytes(path)))
            {
                throw new Exception("Could not acquire texture from file " + Path.GetFileName(path) + ".");
            }

            return text;
        }



        [HarmonyPatch(typeof(UpgradeScreen), "UpdateUi")]
        private class UpgradeScreen3
        {

            [HarmonyPrefix]
            internal static bool UpdateUi(ref UpgradeScreen __instance, string towerId, string upgradeID)
            {
                if (towerId.ToLower().Contains("sword"))
                {
                    if (__instance == null) return false;
                    __instance.towerTitle.text = "check the reddit post to see the upgrades";
                    //Console.WriteLine("UpdateUi called");
                    //Console.WriteLine(towerId);
                    //Console.WriteLine(upgradeID);
                    //Console.WriteLine("populating paths");
                    //if (__instance != null)
                    //    __instance.PopulatePaths(getT0(Game.instance.model), "", true);
                    return false;
                }
                return true;
            }
        }


        [HarmonyPatch(typeof(InGame), "Update")]
        public class Update_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                if (!(InGame.instance != null && InGame.instance.bridge != null)) return;
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
                            sword.transform.localPosition = new Vector3(5.2f,-2,6.889f);
                            //sword.transform.rotation = Quaternion.Euler(new Vector3(30, 344.954f, 2.140f));
                            sword.transform.localRotation = new Quaternion(-0.6f, -0.5f, 0.5f, -0.3f);
                            sword.transform.localScale = new Vector3(17.378f, 2.5f, 2.5f);
                        }

                    }

                }

            }
        }



    }
}
