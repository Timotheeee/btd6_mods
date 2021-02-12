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
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.TowerFilters;
using Assets.Scripts.Unity.UI_New.Main.MonkeySelect;

namespace handkanonier
{

    class Main : MelonMod
    {
        //https://github.com/gurrenm3/BloonsTD6-Mod-Helper/releases
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();

            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine(customTowerDisplayName + " mod loaded");
            //if (!File.Exists("Mods/BloonsTD6.Mod.Helper.dll"))
            //{
            //    using (WebClient client = new WebClient())
            //    {
            //        client.DownloadFile("https://github.com/gurrenm3/BloonsTD6-Mod-Helper/releases/download/0.0.2/BloonsTD6.Mod.Helper.dll", "Mods/BloonsTD6.Mod.Helper.dll");
            //        File.Delete("Mods/BloonsTD6_Mod_Helper.dll");
            //    }
            //    Console.WriteLine("Downloaded BloonsTD6.Mod.Helper.dll");
            //    Console.WriteLine("Restart required");
            //    Application.Quit(0);

            //}
        }


        static string customTowerImageID;
        static string customTowerName = "handkanonier";//don't use any spaces in here
        static string customTowerDisplayName = "Handkanonier";
        static string customTowerDisplay = "06bf915dea753ad43b772045caf1d906";

        static string customTowerUpgrade1Top = "Enlarged Shots";
        static string customTowerUpgrade2Top = "'Nade Optimizer";
        static string customTowerUpgrade3Top = "Heavy Blasts";
        static string customTowerUpgrade4Top = "T-101 Feldhaubitz";
        static string customTowerUpgrade5Top = "The Big Bang";
        static string customTowerDescription1Top = "Bullets deliver larger and better popping blasts.";
        static string customTowerDescription2Top = "Explosions affect even more bloons and deal extra damage.";
        static string customTowerDescription3Top = "Heavier impact bullets deliver thrice as much pain.";
        static string customTowerDescription4Top = "Upgrade the sidearm to a heavy duty bullet launcher; damage and blast radius are greatly increased.";
        static string customTowerDescription5Top = "These explosions can be seen from miles away!";

        static string customTowerUpgrade1Mid = "Quickdraw Sight";
        static string customTowerUpgrade2Mid = "Tenacious";
        static string customTowerUpgrade3Mid = "Adaptive";
        static string customTowerUpgrade4Mid = "Bouncy Shots";
        static string customTowerUpgrade5Mid = "Explosives Specialist";
        static string customTowerDescription1Mid = "Visual training allows Handkanonier to target Camo Bloons.";
        static string customTowerDescription2Mid = "The explosive aftershow pops even more bloons over time.";
        static string customTowerDescription3Mid = "Shots now pop Thermal Bloons and deal bonus damage to Armored Bloons.";
        static string customTowerDescription4Mid = "Shots bounce twice to other bloons upon detonation.";
        static string customTowerDescription5Mid = "Shots deal increased bonus damage to Armored Bloons. Explosives Specialist ability: Mortars and bombs nearby attack twice as fast for 15 seconds.";

        static string customTowerUpgrade1Bottom = "Nimble Hands";
        static string customTowerUpgrade2Bottom = "Tactical Lobber";
        static string customTowerUpgrade3Bottom = "EMB";
        static string customTowerUpgrade4Bottom = "T-102 Jagdfaust";
        static string customTowerUpgrade5Bottom = "Zerfallen";
        static string customTowerDescription1Bottom = "New clip holder allows for faster reloading.";
        static string customTowerDescription2Bottom = "Handkanonier shoots behind cover when the Bloons least expect it.";
        static string customTowerDescription3Bottom = "Electro-magnetic Bombs generate a powerful energy pulse in contact with Bloons.";
        static string customTowerDescription4Bottom = "Converts to a powerful energy blaster; explosions pierce with each hit.";
        static string customTowerDescription5Bottom = "Generates massive piercing energy balls that 'decay' every bloon from their path. Watch out for the end result!";

        static string customTowerImages = @"Mods/" + customTowerName + "/";
        static string customTowerImageLocation = customTowerImages + "mainImage.png";
        static string customTowerTowerSet = "Military";
        static int customTowerTowerIndex = 6;

        static ShopTowerDetailsModel stdm = new ShopTowerDetailsModel(customTowerName, customTowerTowerIndex, 5, 5, 5, -1, 0, null);




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
                if (!Directory.Exists("Mods/" + customTowerName + "/ "))
                {
                    File.WriteAllBytes("Mods/" + customTowerName + ".zip", Resource1.images);
                    System.IO.Compression.ZipFile.ExtractToDirectory("Mods/" + customTowerName + ".zip", "Mods/");
                    File.Delete("Mods/" + customTowerName + ".zip");
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

                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "300portrait.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "500portrait.PNG", default);
                Game.instance.GetSpriteRegister().RegisterSpriteFromImage(customTowerImages + "040portrait.PNG", default);
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
                list.Add(new UpgradeModel(customTowerUpgrade1Top, 500, 0, new SpriteReference(customTowerImages + "100.PNG"), 0, 1, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade2Top, 900, 0, new SpriteReference(customTowerImages + "200.PNG"), 0, 2, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade3Top, 2000, 0, new SpriteReference(customTowerImages + "300.PNG"), 0, 3, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade4Top, 9000, 0, new SpriteReference(customTowerImages + "400.PNG"), 0, 4, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade5Top, 30000, 0, new SpriteReference(customTowerImages + "500.PNG"), 0, 5, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade1Mid, 450, 0, new SpriteReference(customTowerImages + "010.PNG"), 1, 1, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade2Mid, 900, 0, new SpriteReference(customTowerImages + "020.PNG"), 1, 2, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade3Mid, 900, 0, new SpriteReference(customTowerImages + "030.PNG"), 1, 3, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade4Mid, 2750, 0, new SpriteReference(customTowerImages + "040.PNG"), 1, 4, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade5Mid, 22500, 0, new SpriteReference(customTowerImages + "050.PNG"), 1, 5, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade1Bottom, 400, 0, new SpriteReference(customTowerImages + "001.PNG"), 2, 1, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade2Bottom, 650, 0, new SpriteReference(customTowerImages + "002.PNG"), 2, 2, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade3Bottom, 1500, 0, new SpriteReference(customTowerImages + "003.PNG"), 2, 3, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade4Bottom, 6000, 0, new SpriteReference(customTowerImages + "004.PNG"), 2, 4, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade5Bottom, 200000, 0, new SpriteReference(customTowerImages + "005.PNG"), 2, 5, 0, "", ""));

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
                
                Game.instance.model.towerSet = Game.instance.model.towerSet.Add(stdm);
                Console.WriteLine("Game.instance.model.towerset size is " + Game.instance.model.towerSet.Count);

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
            TowerModel towerModel = gameModel.GetTowerFromId("BombShooter").Duplicate<TowerModel>();
            towerModel.name = customTowerName;
            towerModel.baseId = customTowerName;
            towerModel.portrait = new SpriteReference(customTowerImageID);
            towerModel.display = customTowerDisplay;
            towerModel.GetBehavior<DisplayModel>().display = customTowerDisplay;
            towerModel.towerSet = customTowerTowerSet;
            towerModel.dontDisplayUpgrades = false;
            towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[]
            {
                        new UpgradePathModel(customTowerUpgrade1Top, customTowerName + "-100", 1, 1),
                        new UpgradePathModel(customTowerUpgrade1Mid, customTowerName + "-010", 1, 1),
                        new UpgradePathModel(customTowerUpgrade1Bottom, customTowerName + "-001", 1, 1),
            });
            towerModel.tiers = new int[] { 0, 0, 0 };


            //balance stuff
            towerModel.cost = 900;
            //towerModel.mods = new Il2CppReferenceArray<Assets.Scripts.Models.Towers.Mods.ApplyModModel>(0);
            //var bombProj = gameModel.GetTowerFromId("BombShooter").GetBehavior<AttackModel>().weapons[0].projectile.Duplicate<ProjectileModel>();
            //towerModel.GetBehavior<AttackModel>().weapons[0].projectile = bombProj;

            var attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().CapDamage(9999);
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().maxDamage = 9999;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.maxPierce = 99999;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.CapPierce(99999);
            attackModel.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan = 99;
            attackModel.weapons[0].projectile.display = "62e990209b10d374d89f70c6f578def0";

            //change damage type
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damageTypes[0] = "Explosion";
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().ignoreImmunityForBloonTypes = new Il2CppStringArray(0);

            //pierce and damage
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce = 25;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage = 2;

            //change radius to 75% of 100 mortar
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 28 * 0.75f;



            //how many seconds until it shoots
            attackModel.weapons[0].Rate = 2.5f;






            //make it deal 50 extra damage against fortifieds
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Fortified", 1, 0, false, false) { tags = new string[] { "Fortified" }, collisionPass = 0 });
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ceramic", 1, 0, false, false) { tags = new string[] { "Ceramic" }, collisionPass = 0 });
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Moab", 1, 0, false, false) { tags = new string[] { "Moab" }, collisionPass = 0 });
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bfb", 1, 0, false, false) { tags = new string[] { "Bfb" }, collisionPass = 0 });
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Zomg", 1, 0, false, false) { tags = new string[] { "Zomg" }, collisionPass = 0 });
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ddt", 1, 0, false, false) { tags = new string[] { "Ddt" }, collisionPass = 0 });
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bad", 1, 0, false, false) { tags = new string[] { "Bad" }, collisionPass = 0 });



            return towerModel;

        }




        public static TowerModel getT1Top(GameModel gameModel)
        {
            TowerModel towerModel = getT0(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 1, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce = 35;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 28 * 1.1f;

            return towerModel;
        }


        public static TowerModel getT2Top(GameModel gameModel)
        {
            TowerModel towerModel = getT1Top(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 2, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce = 50;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage = 4;
            return towerModel;
        }


        public static TowerModel getT3Top(GameModel gameModel)
        {
            TowerModel towerModel = getT2Top(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 3, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImages + "300portrait.PNG");


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage = 12;


            return towerModel;
        }


        public static TowerModel getT4Top(GameModel gameModel)
        {
            TowerModel towerModel = getT3Top(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 4, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage = 45;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce = 100;
            attackModel.weapons[0].Rate = 1.75f;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 28 * 1.65f;


            return towerModel;
        }


        public static TowerModel getT5Top(GameModel gameModel)
        {
            TowerModel towerModel = getT4Top(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 5, 0, 0);
            towerModel.portrait = new SpriteReference(customTowerImages + "500portrait.PNG");


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.radius = 80 * 1.35f;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage = 130;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce = 150;
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damageTypes[0] = "Normal";


            return towerModel;
        }


        public static TowerModel getT1Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT0(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 1, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            towerModel.AddBehavior(new OverrideCamoDetectionModel("OverrideCamoDetectionModel_", true));

            return towerModel;
        }


        public static TowerModel getT2Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT1Mid(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 2, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            var fire = gameModel.GetTowerFromId("MortarMonkey-002").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<CreateProjectileOnExhaustFractionModel>().projectile.GetBehavior<AddBehaviorToBloonModel>();
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(fire);
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.collisionPasses = new int[] { 0, -1 };

            return towerModel;
        }


        public static TowerModel getT3Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT2Mid(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 3, 0);
            towerModel.portrait = new SpriteReference(customTowerImageID);


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();


            var normal = gameModel.GetTowerFromId("BombShooter-050").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>();
            normal.setDamage(3);
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.RemoveBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(normal);


            //var mib = gameModel.GetTowerFromId("MonkeyVillage-030").Duplicate<TowerModel>().GetBehavior<DamageTypeSupportModel>();
            //var mib2 = gameModel.GetTowerFromId("MonkeyVillage-030").Duplicate<TowerModel>().GetBehavior<SupportRemoveFilterOutTagModel>();
            //mib.appliesToOwningTower = true;
            //mib.customRadius = 0.1f;
            //mib.isCustomRadius = true;
            //mib2.customRadius = 0.1f;
            //mib2.isCustomRadius = true;
            //mib2.appliesToOwningTower = true;
            //towerModel.AddBehavior(mib);
            //towerModel.AddBehavior(mib2);


            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().name = "fuck";
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>()._name = "fuck2";
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damageTypes[0] = "Normal";
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().ignoreImmunityForBloonTypes = new Il2CppStringArray(0);




            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damageTypes[0] = "Normal";
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Fortified", 1, 10, false, false) { tags = new string[] { "Fortified" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ceramic", 1, 10, false, false) { tags = new string[] { "Ceramic" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Moab", 1, 10, false, false) { tags = new string[] { "Moab" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bfb", 1, 10, false, false) { tags = new string[] { "Bfb" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Zomg", 1, 10, false, false) { tags = new string[] { "Zomg" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ddt", 1, 10, false, false) { tags = new string[] { "Ddt" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bad", 1, 10, false, false) { tags = new string[] { "Bad" }, collisionPass = 0 });

            return towerModel;
        }


        public static TowerModel getT4Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT3Mid(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 4, 0);
            towerModel.portrait = new SpriteReference(customTowerImages + "040portrait.PNG");


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.setPierce(3, false);
            var bouncy = gameModel.GetTowerFromId("SniperMonkey-030").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<RetargetOnContactModel>();
            bouncy.distance = 100;
            attackModel.weapons[0].projectile.AddBehavior(bouncy);

            return towerModel;
        }


        public static TowerModel getT5Mid(GameModel gameModel)
        {
            TowerModel towerModel = getT4Mid(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 5, 0);
            towerModel.portrait = new SpriteReference(customTowerImages + "050portrait.PNG");


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Fortified", 1, 30, false, false) { tags = new string[] { "Fortified" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ceramic", 1, 30, false, false) { tags = new string[] { "Ceramic" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Moab", 1, 30, false, false) { tags = new string[] { "Moab" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bfb", 1, 30, false, false) { tags = new string[] { "Bfb" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Zomg", 1, 30, false, false) { tags = new string[] { "Zomg" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Ddt", 1, 30, false, false) { tags = new string[] { "Ddt" }, collisionPass = 0 });
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(new DamageModifierForTagModel("aaa", "Bad", 1, 30, false, false) { tags = new string[] { "Bad" }, collisionPass = 0 });

            var ability = gameModel.GetTowerFromId("AdmiralBrickell 3").Duplicate<TowerModel>().GetBehavior<AbilityModel>();
            ability.icon = new SpriteReference(customTowerImageID);
            ability.GetBehavior<ActivateRateSupportZoneModel>().filters[0] = new FilterInBaseTowerIdModel("lol", new string[] { "BombShooter", "MortarMonkey" });
            //ability.GetBehavior<ActivateRateSupportZoneModel>().useTowerRange = false;
            //ability.GetBehavior<ActivateRateSupportZoneModel>().lifespan = 15;
            towerModel.AddBehavior(ability);


            return towerModel;
        }



        public static TowerModel getT1Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT0(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 1);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].Rate *= 0.8f;

            return towerModel;
        }


        public static TowerModel getT2Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT1Bottom(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 2);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            towerModel.ignoreBlockers = true;
            attackModel.weapons[0].projectile.ignoreBlockers = true;
            attackModel.weapons[0].projectile.canCollisionBeBlockedByMapLos = false;
            attackModel.attackThroughWalls = true;

            return towerModel;
        }


        public static TowerModel getT3Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT2Bottom(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 3);
            towerModel.portrait = new SpriteReference(customTowerImageID);

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damageTypes[0] = "Energy";
            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().ignoreImmunityForBloonTypes = new Il2CppStringArray(0);
            var lasershock = gameModel.GetTowerFromId("DartlingGunner-200").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<AddBehaviorToBloonModel>();
            lasershock.lifespan = 4;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.AddBehavior(lasershock);
            attackModel.weapons[0].projectile.AddBehavior(lasershock);
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.collisionPasses = new int[] { 0, 1 };
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage=5;

            FileIOUtil.SaveObject("handlaser.json", towerModel);

            return towerModel;
        }


        public static TowerModel getT4Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT3Bottom(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 4);
            towerModel.portrait = new SpriteReference(customTowerImageID);


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.setPierce(4, false);
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage = 7;
            attackModel.weapons[0].Rate *= 0.8f;

            return towerModel;
        }


        public static TowerModel getT5Bottom(GameModel gameModel)
        {
            TowerModel towerModel = getT4Bottom(gameModel).Duplicate<TowerModel>();
            SetTiersAndUpgrades(ref towerModel, 0, 0, 5);
            towerModel.portrait = new SpriteReference(customTowerImages + "005portrait.PNG");


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();

            //attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damageTypes[0] = "Normal";

            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.pierce = 100;
            attackModel.weapons[0].projectile.GetBehavior<CreateProjectileOnContactModel>().projectile.GetBehavior<DamageModel>().damage = 600;




            var genericDamage = gameModel.GetTowerFromId("DartlingGunner").Duplicate<TowerModel>().GetBehavior<AttackModel>().weapons[0].projectile.GetBehavior<DamageModel>();
            attackModel.weapons[0].projectile.AddBehavior(genericDamage);
            //attackModel.weapons[0].projectile.GetBehavior<DamageModel>().damageTypes[0] = "Normal";
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().setDamage(500);
            attackModel.weapons[0].projectile.setPierce(50);

            attackModel.weapons[0].projectile.display = "88399aeca4ae48a44aee5b08eb16cc61";

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


        static string lastTower;

        [HarmonyPatch(typeof(UpgradeScreen), "UpdateUi")]
        private class UpgradeScreen3
        {

            [HarmonyPrefix]
            internal static bool UpdateUi(ref UpgradeScreen __instance, ref string towerId, string upgradeID)
            {
                lastTower = towerId;
                if (towerId == customTowerName)
                {
                    //if (__instance == null) return false;

                    towerId = "DartMonkey";

                    //Console.WriteLine("UpdateUi called");
                    //Console.WriteLine(towerId);
                    //Console.WriteLine(upgradeID);
                    //Console.WriteLine("populating paths");
                    //if (__instance != null)
                    //    __instance.PopulatePaths(getT0(Game.instance.model), "", true);
                    //return false;
                }
                return true;
            }


            [HarmonyPostfix]
            internal static void UpdateUi2(ref UpgradeScreen __instance, ref string towerId, string upgradeID)
            {
                if (lastTower == customTowerName)
                {
                    //Console.WriteLine("postfix sword");
                    __instance.towerTitle.text = "Handkanonier";
                    __instance.path1Upgrades[0].upgradeName.text = customTowerDescription1Top;
                    __instance.path1Upgrades[1].upgradeName.text = customTowerDescription2Top;
                    __instance.path1Upgrades[2].upgradeName.text = customTowerDescription3Top;
                    __instance.path1Upgrades[3].upgradeName.text = customTowerDescription4Top;
                    __instance.path1Upgrades[4].upgradeName.text = customTowerDescription5Top;
                    __instance.path2Upgrades[0].upgradeName.text = customTowerDescription1Mid;
                    __instance.path2Upgrades[1].upgradeName.text = customTowerDescription2Mid;
                    __instance.path2Upgrades[2].upgradeName.text = customTowerDescription3Mid;
                    __instance.path2Upgrades[3].upgradeName.text = customTowerDescription4Mid;
                    __instance.path2Upgrades[4].upgradeName.text = customTowerDescription5Mid;
                    __instance.path3Upgrades[0].upgradeName.text = customTowerDescription1Bottom;
                    __instance.path3Upgrades[1].upgradeName.text = customTowerDescription2Bottom;
                    __instance.path3Upgrades[2].upgradeName.text = customTowerDescription3Bottom;
                    __instance.path3Upgrades[3].upgradeName.text = customTowerDescription4Bottom;
                    __instance.path3Upgrades[4].upgradeName.text = customTowerDescription5Bottom;
                    //__instance.path1Upgrades[0].upgradeCost.text = Game.instance.model.upgradesByName[customTowerUpgrade1Top].name;



                }
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





        [HarmonyPatch(typeof(InGame), "Update")]
        public class Update_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                if (!(InGame.instance != null && InGame.instance.bridge != null)) return;
                foreach (var tts in InGame.Bridge.GetAllTowers())
                {

                    if (!tts.namedMonkeyKey.ToLower().Contains("handkanonier")) continue;
                    if (tts?.tower?.Node?.graphic?.transform != null)
                    {
                        tts.tower.Node.graphic.transform.localScale = new UnityEngine.Vector3(1.3f, 1.3f, 1.3f);

                    }

                }

            }
        }


    }
}
