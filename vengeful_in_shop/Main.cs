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
using Newtonsoft.Json;
using Assets.Scripts.Models.TowerSets;
using Assets.Scripts.Models.Profile;

namespace vengeful_in_shop
{
    public class Main : BloonsTD6Mod
    {

        

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("vengeful_in_shop loaded");
        }



        //public class DartParagon : ModTower
        //{
        //    //public override string BaseTower => "DartMonkey-003";
        //    public override string BaseTower => "DartMonkey-Paragon";
        //    public override string Name => "DartMonkey-Paragon-Buffable";
        //    public override int Cost => 450000;
        //    public override string TowerSet => "Primary";
        //    public override int TopPathUpgrades => 0;
        //    public override int MiddlePathUpgrades => 0;
        //    public override int BottomPathUpgrades => 0;
        //    public override string DisplayName => "DartMonkey Paragon Buffable";
        //    public override string Description => "Buffable";

        //    public override string Icon => "3906afef12a8fab4db780428c3b8a50b";



        //    public override void ModifyBaseTowerModel(TowerModel towerModel)
        //    {
        //        //return;
        //        //var temple = FileIOUtil.LoadObject<TowerModel>("SuperMonkey-400.json");


        //        //var temple = FileIOUtil.LoadObject<TowerModel>("DartMonkey.json");
        //        //List<Model> bevs = new List<Model>();

        //        //Console.WriteLine(FileIOUtil.LoadObject<Assets.Scripts.Simulation.Behaviors.DisplayBehavior>(@"C:\Users\Timothe\AppData\LocalLow\Ninja Kiwi\BloonsTD6\behaviors\DartMonkey\AttackModel_Attack_.json").na);
        //        //foreach (string file in Directory.EnumerateFiles(@"C:\Users\Timothe\AppData\LocalLow\Ninja Kiwi\BloonsTD6\behaviors\DartMonkey\"))
        //        //{
        //        //    try
        //        //    {
        //        //        Console.WriteLine(FileIOUtil.LoadObject<Model>(file).name);
        //        //        bevs.Add(FileIOUtil.LoadObject<Model>(file));
        //        //        Console.WriteLine("loaded " + file);
        //        //    }
        //        //    catch
        //        //    {
        //        //        Console.WriteLine("failed " + file);
        //        //    }
        //        //}
        //        //towerModel.behaviors = bevs.ToArray();
        //        //Console.WriteLine(towerModel.behaviors.Count);
        //        //var temple = FileIOUtil.LoadObject<TowerModel>("DartMonkey.json");

        //        var settings = new JsonSerializerSettings { Error = (se, ev) => { ev.ErrorContext.Handled = true; } };
        //        Console.WriteLine("loading");
        //        var temple = JsonConvert.DeserializeObject<TowerModel>(File.ReadAllText(@"C:\Users\Timothe\AppData\LocalLow\Ninja Kiwi\BloonsTD6\SuperMonkey-400.json"), settings);
        //        Console.WriteLine("loaded");

        //        FileIOUtil.SaveObject("crashes.json", temple);

        //        try { towerModel.behaviors = temple.behaviors; } catch { Console.WriteLine("behaviors"); }
        //        try { towerModel.cachedThrowMarkerHeight = temple.cachedThrowMarkerHeight; } catch { Console.WriteLine("cachedThrowMarkerHeight"); }
        //        try { towerModel.ignoreTowerForSelection = temple.ignoreTowerForSelection; } catch { Console.WriteLine("ignoreTowerForSelection"); }
        //        try { towerModel.footprint = temple.footprint; } catch { Console.WriteLine("footprint"); }
        //        try { towerModel.dontDisplayUpgrades = temple.dontDisplayUpgrades; } catch { Console.WriteLine("dontDisplayUpgrades"); }
        //        try { towerModel.emoteSpriteSmall = temple.emoteSpriteSmall; } catch { Console.WriteLine("emoteSpriteSmall"); }
        //        try { towerModel.emoteSpriteLarge = temple.emoteSpriteLarge; } catch { Console.WriteLine("emoteSpriteLarge"); }
        //        try { towerModel.doesntRotate = temple.doesntRotate; } catch { Console.WriteLine("doesntRotate"); }
        //        try { towerModel.upgrades = temple.upgrades; } catch { Console.WriteLine("upgrades"); }
        //        try { towerModel.appliedUpgrades = temple.appliedUpgrades; } catch { Console.WriteLine("appliedUpgrades"); }
        //        try { towerModel.targetTypes = temple.targetTypes; } catch { Console.WriteLine("targetTypes"); }
        //        try { towerModel.paragonUpgrade = temple.paragonUpgrade; } catch { Console.WriteLine("paragonUpgrade"); }
        //        try { towerModel.isSubTower = temple.isSubTower; } catch { Console.WriteLine("isSubTower"); }
        //        try { towerModel.mods = temple.mods; } catch { Console.WriteLine("mods"); }
        //        try { towerModel.isBakable = temple.isBakable; } catch { Console.WriteLine("isBakable"); }
        //        try { towerModel.powerName = temple.powerName; } catch { Console.WriteLine("powerName"); }
        //        try { towerModel.showPowerTowerBuffs = temple.showPowerTowerBuffs; } catch { Console.WriteLine("showPowerTowerBuffs"); }
        //        try { towerModel.animationSpeed = temple.animationSpeed; } catch { Console.WriteLine("animationSpeed"); }
        //        try { towerModel.towerSelectionMenuThemeId = temple.towerSelectionMenuThemeId; } catch { Console.WriteLine("towerSelectionMenuThemeId"); }
        //        try { towerModel.ignoreCoopAreas = temple.ignoreCoopAreas; } catch { Console.WriteLine("ignoreCoopAreas"); }
        //        try { towerModel.canAlwaysBeSold = temple.canAlwaysBeSold; } catch { Console.WriteLine("canAlwaysBeSold"); }
        //        try { towerModel.isParagon = temple.isParagon; } catch { Console.WriteLine("isParagon"); }
        //        try { towerModel.towerSize = temple.towerSize; } catch { Console.WriteLine("towerSize"); }
        //        try { towerModel.instaIcon = temple.instaIcon; } catch { Console.WriteLine("instaIcon"); }
        //        try { towerModel.portrait = temple.portrait; } catch { Console.WriteLine("portrait"); }
        //        try { towerModel.icon = temple.icon; } catch { Console.WriteLine("icon"); }
        //        try { towerModel.areaTypes = temple.areaTypes; } catch { Console.WriteLine("areaTypes"); }
        //        try { towerModel.towerSet = temple.towerSet; } catch { Console.WriteLine("towerSet"); }
        //        try { towerModel.tiers = temple.tiers; } catch { Console.WriteLine("tiers"); }
        //        try { towerModel.tier = temple.tier; } catch { Console.WriteLine("tier"); }
        //        try { towerModel.isGlobalRange = temple.isGlobalRange; } catch { Console.WriteLine("isGlobalRange"); }
        //        try { towerModel.ignoreBlockers = temple.ignoreBlockers; } catch { Console.WriteLine("ignoreBlockers"); }
        //        try { towerModel.range = temple.range; } catch { Console.WriteLine("range"); }
        //        try { towerModel.radiusSquared = temple.radiusSquared; } catch { Console.WriteLine("radiusSquared"); }
        //        try { towerModel.radius = temple.radius; } catch { Console.WriteLine("radius"); }
        //        try { towerModel.cost = temple.cost; } catch { Console.WriteLine("cost"); }
        //        try { towerModel.baseId = temple.baseId; } catch { Console.WriteLine("baseId"); }
        //        try { towerModel.display = temple.display; } catch { Console.WriteLine("display"); }
        //        try { towerModel.TargetTypes = temple.TargetTypes; } catch { Console.WriteLine("TargetTypes"); }
        //        Console.WriteLine("done");
        //        //FileIOUtil.SaveObject("crashes.json", towerModel);
        //    }
        //}

        //static System.Random r = new System.Random();
        static TowerModel vengeful;
        static ProfileModel profile;

        public override void OnUpdate()
        {
            base.OnUpdate();

            //if (Input.GetKeyDown(KeyCode.F7))
            //{
            //    var t = Game.instance.model.GetTowerFromId(TowerType.DartMonkey).Duplicate();
            //    t.cost = 1333;
            //    t.name = "testtt";
            //    Game.instance.model.AddTowerToGame(t, new ShopTowerDetailsModel(t.name, 10, 5, 5, 5, -1, 0, null));
            //}


            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F1))
            {
                foreach (var t in InGame.instance.GetAllTowerToSim())
                {
                    var tm = t.tower.model.Cast<TowerModel>();
                    if (Regex.IsMatch(tm.name,"SuperMonkey-5.."))
                    {
                        var temp = tm.Duplicate();
                        temp.cost = 1200000;
                        temp.name = "Vengeful";
                        temp.tier = 0;
                        temp.tiers = new int[] { 0, 0, 0 };
                        temp.dontDisplayUpgrades = true;
                        var b = Game.instance.model.GetTowerFromId("SuperMonkey-500").Duplicate();
                        temp.icon = new SpriteReference(b.portrait.guidRef);
                        temp.instaIcon = new SpriteReference(b.portrait.guidRef);
                        temp.portrait = new SpriteReference(b.portrait.guidRef);
                        vengeful = temp.Duplicate();

                        Console.WriteLine("saved " + tm.name);

                        Game.instance.model.AddTowerToGame(vengeful, new ShopTowerDetailsModel(vengeful.name, 10, 0, 0, 0, -1, 0, null));
                        profile.unlockedTowers.Add(vengeful.name);
                        Console.WriteLine("added tower to shop");
                    }

                    


                    //foreach (var bev in tm.behaviors)
                    //{
                    //    FileIOUtil.SaveObject("behaviors/" + tm.name + "/" + bev.name + ".json", bev);
                    //}
                    //tm.behaviors = new UnhollowerBaseLib.Il2CppReferenceArray<Model>(0);


                    //FileIOUtil.SaveObject("" + tm.name + ".json", tm);

                    //FileIOUtil.SaveObject("temple.json", t.tower.model);
                }
            }
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F1))
            {

            }

        }

        

        [HarmonyPatch(typeof(ProfileModel), "Validate")]
        public class ProfileModel_Patch
        {

            [HarmonyPostfix]
            public static void Postfix(ref ProfileModel __instance)
            {
                profile = __instance;
                //Il2CppSystem.Collections.Generic.List<string> unlockedTowers = __instance.unlockedTowers;
                //Il2CppSystem.Collections.Generic.List<string> acquiredUpgrades = __instance.acquiredUpgrades;
                //if (!unlockedTowers.Contains(customTowerName))
                //{
                //    unlockedTowers.Add(customTowerName);
                //}
                //string[] array = new string[]
                //{
                //    customTowerUpgrade1,
                //    customTowerUpgrade2,
                //    customTowerUpgrade3,
                //    customTowerUpgrade4,
                //    customTowerUpgrade5
                //};
                //checked
                //{
                //    for (int i = 0; i < array.Length; i++)
                //    {
                //        if (!acquiredUpgrades.Contains(array[i]))
                //        {
                //            acquiredUpgrades.Add(array[i]);
                //        }
                //    }
                //}
            }
        }


    }


}