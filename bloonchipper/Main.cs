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
using NKHook6.Api.Events;
using UnhollowerBaseLib;
using UnityEngine;
using BloonsTD6_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Weapons.Behaviors;
using Assets.Scripts.Models.Towers.Weapons;
using System.Net;
using Assets.Scripts.Unity.UI_New.Popups;
using TMPro;

namespace bloonchipper
{

    class Bloon_Chipper : MelonMod
    {
        //https://github.com/gurrenm3/BloonsTD6-Mod-Helper/releases
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();

            EventRegistry.instance.listen(typeof(Bloon_Chipper));
            Console.WriteLine("bloonchipper mod loaded");
        }


        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {

            [HarmonyPostfix]
            public static void Postfix()
            {

                if (!File.Exists("Mods/NKHook6.dll"))
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile("https://github.com/TDToolbox/NKHook6/releases/download/41/NKHook6.dll", "Mods/NKHook6.dll");
                    }
                    Console.WriteLine("downloaded NKHook6.dll");
                }
                if (!File.Exists("Mods/BloonsTD6.Mod.Helper.dll"))
                {
                    Il2CppSystem.Action<int> mod = (Il2CppSystem.Action<int>)delegate (int s)
                    {
                        if (s == 1) {
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile("https://github.com/gurrenm3/BloonsTD6-Mod-Helper/releases/download/0.0.2/BloonsTD6.Mod.Helper.dll", "Mods/BloonsTD6.Mod.Helper.dll");
                                File.Delete("Mods/BloonsTD6_Mod_Helper.dll");
                            }
                            Console.WriteLine("downloaded BloonsTD6.Mod.Helper.dll");
                            Application.Quit(0);
                        }


                    };

                    PopupScreen.instance.ShowSetValuePopup("your btd6 mod helper seems to be outdated", "type 1 to update it", mod, 1);

                    PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;

                }




                Console.WriteLine("initializing bloonchipper");

                if (!LocalizationManager.instance.textTable.ContainsKey(customTowerName))
                {
                    LocalizationManager.instance.textTable.Add(customTowerName, "Bloon Chipper");
                }
                string[] array = new string[]
                {
                customTowerUpgrade1,
                customTowerUpgrade2,
                customTowerUpgrade3,
                customTowerUpgrade4,
                customTowerUpgrade5
                };
                string[] array2 = new string[]
                {
                "Increased range and pierce",
                "Attacks twice as fast",
                "Can now destroy moabs. Ability doubles attack speed",
                "Can now destroy ZOMGs and instakill bloons",
                "Can now destroy 4 blimps at once, and attacks bloons much faster"
                };

                for (int i = 0; i < array.Length; i++)
                {
                    if (!LocalizationManager.instance.textTable.ContainsKey(array[i] + " Description"))
                    {
                        LocalizationManager.instance.textTable.Add(array[i] + " Description", array2[i]);
                    }
                }
                Game.instance.GetSpriteRegister().RegisterSpriteFromURL(@"Mods\bloonchipper\bloonchipper.png", "https://static.wikia.nocookie.net/b__/images/3/3b/BMC_Bloon_Chipper_Fix.png/revision/latest?cb=20151222214314&path-prefix=bloons", default, out customTowerImageID);


                Il2CppSystem.Collections.Generic.List<UpgradeModel> list = new Il2CppSystem.Collections.Generic.List<UpgradeModel>();
                list.Add(new UpgradeModel(customTowerUpgrade1, 750, 0, new SpriteReference(customTowerImageID), 1, 1, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade2, 1300, 0, new SpriteReference(customTowerImageID), 1, 2, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade3, 2500, 0, new SpriteReference(customTowerImageID), 1, 3, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade4, 16000, 0, new SpriteReference(customTowerImageID), 1, 4, 0, "", ""));
                list.Add(new UpgradeModel(customTowerUpgrade5, 32000, 0, new SpriteReference(customTowerImageID), 1, 5, 0, "", ""));
                Game.instance.model.upgrades = Game.instance.model.upgrades.Add(list);
                Il2CppSystem.Collections.Generic.List<TowerModel> list2 = new Il2CppSystem.Collections.Generic.List<TowerModel>();
                list2.Add(getT0(Game.instance.model));
                list2.Add(getT1(Game.instance.model));
                list2.Add(getT2(Game.instance.model));
                list2.Add(getT3(Game.instance.model));
                list2.Add(getT4(Game.instance.model));
                list2.Add(getT5(Game.instance.model));
                Game.instance.model.towers = Game.instance.model.towers.Add(list2);
                Il2CppSystem.Collections.Generic.List<TowerDetailsModel> list3 = new Il2CppSystem.Collections.Generic.List<TowerDetailsModel>();
                foreach (TowerDetailsModel item in Game.instance.model.towerSet)
                {
                    list3.Add(item);
                }
                ShopTowerDetailsModel newPart = new ShopTowerDetailsModel(customTowerName, 10, 0, 5, 0, -1, 0, null);
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
                Console.WriteLine("bloonchipper initialized");

            }
        }

        static string customTowerImageID;
        static string customTowerName = "BloonChipper";
        static string customTowerDisplay = "60ec4c22a4deef445b076b538de9c2e4";
        static string customTowerUpgrade1 = "longer succ";
        static string customTowerUpgrade2 = "faster succ";
        static string customTowerUpgrade3 = "moab succ";
        static string customTowerUpgrade4 = "zomg succ";
        static string customTowerUpgrade5 = "quad succ";



        public static TowerModel getT0(GameModel gameModel)
        {
            TowerModel towerModel = gameModel.GetTowerFromId("PatFusty 20").Duplicate<TowerModel>();
            towerModel.name = customTowerName;
            towerModel.baseId = customTowerName;
            towerModel.portrait = new SpriteReference(customTowerImageID);
            towerModel.display = customTowerDisplay;
            towerModel.GetBehavior<DisplayModel>().display = customTowerDisplay;
            towerModel.towerSet = "Military";
            towerModel.dontDisplayUpgrades = false;
            towerModel.cost = 200;
            towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[]
            {
                        new UpgradePathModel(customTowerUpgrade1, customTowerName + "-010", 1, 1)
            });
            towerModel.tiers = new int[] { 0, 0, 0 };


            //balance stuff
            towerModel.mods = new Il2CppReferenceArray<Assets.Scripts.Models.Towers.Mods.ApplyModModel>(0);
            towerModel.RemoveBehavior<HeroModel>();
            towerModel.RemoveBehavior<CreateSoundOnBloonEnterTrackModel>();
            towerModel.RemoveBehavior<CreateSoundOnBloonLeakModel>();
            towerModel.RemoveBehavior<CreateSoundOnSelectedModel>();
            var squeeze = towerModel.behaviors.FirstOrDefault((Model disp) => disp.name.Contains("AbilityModel_AbilityBigSqueeze")).Cast<AbilityModel>().behaviors[0].Cast<ActivateAttackModel>().attacks[0].Duplicate<AttackModel>();
            squeeze.weapons[0].Rate = 5;
            squeeze.weapons[0].GetBehavior<SwitchAnimStateForBloonTypeModel>().nonMoabsAnimId = 4;
            squeeze.weapons[0].GetBehavior<SwitchAnimStateForBloonTypeModel>().moabAnimId = 4;
            squeeze.weapons[0].GetBehavior<SwitchAnimStateForBloonTypeModel>().bfbAnimId = 4;
            squeeze.weapons[0].GetBehavior<SwitchAnimStateForBloonTypeModel>().zomgAnimId = 4;
            squeeze.weapons[0].GetBehavior<SwitchAnimStateForBloonTypeModel>().ddtAnimId = 4;
            squeeze.weapons[0].projectile.filters = new Il2CppReferenceArray<FilterModel>(new FilterModel[] {
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze","Moabs",new Il2CppStringArray(0)),
                    new FilterInvisibleModel("FilterInvisibleModel_",true,false)
                });
            squeeze.weapons[0].projectile.GetBehavior<ProjectileFilterModel>().filters = new Il2CppReferenceArray<FilterModel>(new FilterModel[] {
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze","Moabs",new Il2CppStringArray(0)),
                    new FilterInvisibleModel("FilterInvisibleModel_",true,false)
                });
            squeeze.GetBehavior<AttackFilterModel>().filters = new Il2CppReferenceArray<FilterModel>(new FilterModel[] {
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze","Moabs",new Il2CppStringArray(0)),
                    new FilterInvisibleModel("FilterInvisibleModel_",true,false),
                });
            squeeze.GetBehavior<TargetStrongModel>().isSelectable = true;
            squeeze.AddBehavior<TargetFirstModel>(new TargetFirstModel("TargetFirstModel_", true, false));
            squeeze.weapons[0].projectile.pierce = 6f;
            squeeze.weapons[0].projectile.maxPierce = 999999;
            squeeze.weapons[0].projectile.CapPierce(999999);
            towerModel.RemoveBehavior<AttackModel>();
            towerModel.AddBehavior<AttackModel>(squeeze);
            towerModel.RemoveBehavior<AbilityModel>();
            towerModel.RemoveBehavior<AbilityModel>();
            return towerModel;

        }


        public static TowerModel getT1(GameModel gameModel)
        {
            TowerModel towerModel = getT0(gameModel).Duplicate<TowerModel>();
            towerModel.name = customTowerName + "-010";
            towerModel.tier = 1;
            towerModel.tiers = new int[] { 0, 1, 0 };
            towerModel.portrait = new SpriteReference(customTowerImageID);
            towerModel.appliedUpgrades = new Il2CppStringArray(new string[]
            {
                    customTowerUpgrade1
            });
            towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[]
            {
                    new UpgradePathModel(customTowerUpgrade2, customTowerName + "-020", 1, 2)
            });

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.pierce = 10f;
            attackModel.range += 10;
            towerModel.range += 10;
            attackModel.weapons[0].projectile.radius += 10;

            return towerModel;
        }


        public static TowerModel getT2(GameModel gameModel)
        {
            TowerModel towerModel = getT1(gameModel).Duplicate<TowerModel>();
            towerModel.name = customTowerName + "-020";
            towerModel.tier = 2;
            towerModel.tiers = new int[] { 0, 2, 0 };
            towerModel.portrait = new SpriteReference(customTowerImageID);
            towerModel.appliedUpgrades = new Il2CppStringArray(new string[]
            {
                    customTowerUpgrade1,
                    customTowerUpgrade2
            });
            towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[]
            {
                    new UpgradePathModel(customTowerUpgrade3, customTowerName + "-030", 1, 3)
            });

            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.pierce = 15f;
            attackModel.weapons[0].Rate *= 0.5f;
            attackModel.weapons[0].projectile.GetBehavior<DelayBloonChildrenSpawningModel>().Lifespan *= 0.45f;
            attackModel.weapons[0].projectile.GetBehavior<CreateSoundOnDelayedCollisionModel>().delay *= 0.3f;
            return towerModel;
        }


        public static TowerModel getT3(GameModel gameModel)
        {
            TowerModel towerModel = getT2(gameModel).Duplicate<TowerModel>();
            towerModel.name = customTowerName + "-030";
            towerModel.tier = 3;
            towerModel.tiers = new int[] { 0, 3, 0 };
            towerModel.portrait = new SpriteReference(customTowerImageID);
            towerModel.appliedUpgrades = new Il2CppStringArray(new string[]
            {
                    customTowerUpgrade1,
                    customTowerUpgrade2,
                    customTowerUpgrade3
            });
            towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[]
            {
                    new UpgradePathModel(customTowerUpgrade4, customTowerName + "-040", 1, 4)
            });


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[0].projectile.GetBehavior<DelayBloonChildrenSpawningModel>().Lifespan *= 0.5f;
            attackModel.weapons[0].projectile.GetBehavior<CreateSoundOnDelayedCollisionModel>().delay *= 0.5f;
            attackModel.AddWeapon(attackModel.weapons[0].Duplicate<WeaponModel>());
            attackModel.weapons[1].projectile.pierce = 1;
            attackModel.weapons[1].projectile.maxPierce = 1;
            attackModel.weapons[1].projectile.CapPierce(1);
            attackModel.weapons[1].projectile.filters = new Il2CppReferenceArray<FilterModel>(new FilterModel[] {
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze","Bad",new Il2CppStringArray(0)),
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze2","Zomg",new Il2CppStringArray(0)),
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze3","Bfb",new Il2CppStringArray(0)),
                    new FilterInvisibleModel("FilterInvisibleModel_",true,false),
                    new FilterWithTagModel("FilterWithTagModel_","Moabs",false){ growTag=false,camoTag=false,moabTag=true,fortifiedTag=false},
                });
            attackModel.weapons[1].projectile.GetBehavior<ProjectileFilterModel>().filters = new Il2CppReferenceArray<FilterModel>(new FilterModel[] {
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze","Bad",new Il2CppStringArray(0)),
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze2","Zomg",new Il2CppStringArray(0)),
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze3","Bfb",new Il2CppStringArray(0)),
                    new FilterInvisibleModel("FilterInvisibleModel_",true,false),
                    new FilterWithTagModel("FilterWithTagModel_","Moabs",false){ growTag=false,camoTag=false,moabTag=true,fortifiedTag=false},
                });
            attackModel.behaviors[1].Cast<AttackFilterModel>().filters = new Il2CppReferenceArray<FilterModel>(new FilterModel[] {
                    //new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze","Moabs",new Il2CppStringArray(0)),
                    new FilterInvisibleModel("FilterInvisibleModel_",true,false),
                });
            AbilityModel abilityModel = gameModel.towers.FirstOrDefault((TowerModel pat) => pat.name.Contains("Pat") && pat.tier == 20).behaviors.FirstOrDefault((Model ab) => ab.name.Contains("Rally")).Clone().Cast<AbilityModel>();
            abilityModel.icon = new SpriteReference(customTowerImageID);
            ActivateTowerDamageSupportZoneModel a = abilityModel.behaviors.FirstOrDefault((Model AA) => AA.name.Contains("ActivateTowerDamageSupportZoneModel")).Clone().Cast<ActivateTowerDamageSupportZoneModel>();
            ActivateRateSupportZoneModel arszm = new ActivateRateSupportZoneModel(a.name, a.mutatorId, a.isUnique, 0.5f, 0.1f, 1, a.canEffectThisTower, a.lifespan, null, a.buffLocsName, a.buffIconName, a.filters, false);
            abilityModel.AddBehavior<ActivateRateSupportZoneModel>(arszm);
            abilityModel.RemoveBehavior<ActivateTowerDamageSupportZoneModel>();
            towerModel.behaviors = towerModel.behaviors.Add(abilityModel);
            towerModel.behaviors = towerModel.behaviors.Add(new OverrideCamoDetectionModel("OverrideCamoDetectionModel_", true));
            attackModel.weapons[0].Rate *= 0.8f;
            attackModel.weapons[0].projectile.GetBehavior<DelayBloonChildrenSpawningModel>().Lifespan *= 0.8f;
            attackModel.weapons[0].projectile.GetBehavior<CreateSoundOnDelayedCollisionModel>().delay *= 0.8f;
            return towerModel;
        }


        public static TowerModel getT4(GameModel gameModel)
        {
            TowerModel towerModel = getT3(gameModel).Duplicate<TowerModel>();
            towerModel.name = customTowerName + "-040";
            towerModel.tier = 4;
            towerModel.tiers = new int[] { 0, 4, 0 };
            towerModel.portrait = new SpriteReference(customTowerImageID);
            towerModel.appliedUpgrades = new Il2CppStringArray(new string[]
            {
                    customTowerUpgrade1,
                    customTowerUpgrade2,
                    customTowerUpgrade3,
                    customTowerUpgrade4
            });
            towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[]
            {
                    new UpgradePathModel(customTowerUpgrade5, customTowerName + "-050", 1, 5)
            });


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[1].projectile.filters = new Il2CppReferenceArray<FilterModel>(new FilterModel[] {
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze","Bad",new Il2CppStringArray(0)),
                    new FilterInvisibleModel("FilterInvisibleModel_",true,false),
                    new FilterWithTagModel("FilterWithTagModel_","Moabs",false){ growTag=false,camoTag=false,moabTag=true,fortifiedTag=false},
                });
            attackModel.weapons[1].projectile.GetBehavior<ProjectileFilterModel>().filters = new Il2CppReferenceArray<FilterModel>(new FilterModel[] {
                    new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze","Bad",new Il2CppStringArray(0)),
                    new FilterInvisibleModel("FilterInvisibleModel_",true,false),
                    new FilterWithTagModel("FilterWithTagModel_","Moabs",false){ growTag=false,camoTag=false,moabTag=true,fortifiedTag=false},
                });
            attackModel.behaviors[1].Cast<AttackFilterModel>().filters = new Il2CppReferenceArray<FilterModel>(new FilterModel[] {
                    //new FilterOutTagModel("FilterOutTagModel_ProjectileSqueeze","Moabs",new Il2CppStringArray(0)),
                    new FilterInvisibleModel("FilterInvisibleModel_",true,false),
                });

            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().distributeToChildren = true;
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().maxDamage = 999999;
            attackModel.weapons[0].projectile.GetBehavior<DamageModel>().overrideDistributeBlocker = true;
            return towerModel;
        }


        public static TowerModel getT5(GameModel gameModel)
        {
            TowerModel towerModel = getT4(gameModel).Duplicate<TowerModel>();
            towerModel.name = customTowerName + "-050";
            towerModel.tier = 5;
            towerModel.tiers = new int[] { 0, 5, 0 };
            towerModel.portrait = new SpriteReference(customTowerImageID);
            towerModel.appliedUpgrades = new Il2CppStringArray(new string[]
            {
                    customTowerUpgrade1,
                    customTowerUpgrade2,
                    customTowerUpgrade3,
                    customTowerUpgrade4,
                    customTowerUpgrade5
            });
            towerModel.upgrades = new Il2CppReferenceArray<UpgradePathModel>(new UpgradePathModel[0]);


            //balance stuff
            AttackModel attackModel = towerModel.GetBehavior<AttackModel>();
            attackModel.weapons[1].projectile.pierce += 3f;
            attackModel.range += 10;
            towerModel.range += 10;
            attackModel.weapons[1].Rate *= 0.3f;
            attackModel.weapons[1].projectile.GetBehavior<DelayBloonChildrenSpawningModel>().Lifespan *= 0.27f;
            attackModel.weapons[1].projectile.GetBehavior<CreateSoundOnDelayedCollisionModel>().delay *= 0.25f;
            attackModel.weapons[0].Rate *= 0.8f;
            attackModel.weapons[0].projectile.GetBehavior<DelayBloonChildrenSpawningModel>().Lifespan *= 0.8f;
            attackModel.weapons[0].projectile.GetBehavior<CreateSoundOnDelayedCollisionModel>().delay *= 0.8f;
            attackModel.weapons[0].projectile.pierce = 40f;
            attackModel.weapons[0].projectile.radius += 10;
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
                string[] array = new string[]
                {
                    customTowerUpgrade1,
                    customTowerUpgrade2,
                    customTowerUpgrade3,
                    customTowerUpgrade4,
                    customTowerUpgrade5
                };
                checked
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (!acquiredUpgrades.Contains(array[i]))
                        {
                            acquiredUpgrades.Add(array[i]);
                        }
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
                    Texture2D pngTexture = TextureFromPNG(@"Mods\bloonchipper\bloonchipper.png");
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

        public static Texture2D TextureFromPNG(string path)
        {
            Texture2D text = new Texture2D(2, 2);

            if (!ImageConversion.LoadImage(text, File.ReadAllBytes(path)))
            {
                throw new Exception("Could not acquire texture from file " + Path.GetFileName(path) + ".");
            }

            return text;
        }


    }
}
