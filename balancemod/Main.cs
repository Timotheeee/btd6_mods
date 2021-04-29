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
using BloonsTD6_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;

namespace balancemod
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("balancemod loaded");
        }

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + " /Ninja Kiwi/BloonsTD6/";

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                var models = Game.instance.model.towers;

                for (int i = 0; i < models.Count; i++)
                {
                    var tower = models[i];

                    if (Regex.IsMatch(tower.name, "MonkeyAce-402") || Regex.IsMatch(tower.name, "MonkeyAce-502"))
                    {
                        models[i].behaviors.First(b => b.name == "AttackAirUnitModel_Attack_").Cast<AttackAirUnitModel>().behaviors.First(b => b.name == "CirclePatternModel_").Cast<CirclePatternModel>().radius = 40;
                    }
                    if (Regex.IsMatch(tower.name, "IceMonkey-4.."))
                    {
                        foreach (var item in tower.GetBehaviors<LinkProjectileRadiusToTowerRangeModel>())
                        {
                            if (item.projectileModel.pierce == 40) item.projectileModel.pierce = 100;
                        }
                        foreach (var item in tower.GetWeapons())
                        {
                            item.Rate *= 0.8f;
                        }
                    }
                    if (Regex.IsMatch(tower.name, "NinjaMonkey-..5"))
                    {
                        foreach (var item in GetAllBehaviors<DamageOverTimeModel>(tower.GetAllProjectiles()))
                        {
                            item.damage = 2000;
                        }
                    }
                    if (Regex.IsMatch(tower.name, "NinjaMonkey-..4"))
                    {
                        foreach (var item in GetAllBehaviors<DamageOverTimeModel>(tower.GetAllProjectiles()))
                        {
                            item.damage = 700;
                        }
                    }
                    if (Regex.IsMatch(tower.name, "EngineerMonkey"))
                    {
                        tower.cost = 350;
                    }
                    //if (Regex.IsMatch(tower.name, "DartMonkey-4.."))
                    //{
                    //    foreach (var item in GetAllBehaviors<DamageModel>(tower.GetAllProjectiles()))
                    //    {
                    //        item.damage = 2;
                    //    }
                    //}
 
                    if (Regex.IsMatch(tower.name, "Druid-.5."))
                    {
                        tower.GetBehavior<SpiritOfTheForestModel>().damageOverTimeZoneModel.behaviorModel.damage = 3;
                    }
                    if (Regex.IsMatch(tower.name, "SentryParagon"))
                    {
                        foreach (var item in GetAllBehaviors<DamageModel>(tower.GetAllProjectiles()))
                        {
                            if (item.damage == 2)
                                item.damage = 3;
                        }
                    }
                    if (Regex.IsMatch(tower.name, "EngineerMonkey-5.."))
                    {
                        foreach (var item in GetAllBehaviors<CreateTowerModel>(tower.GetAllProjectiles()))
                        {
                            foreach (var item2 in GetAllBehaviors<DamageModel>(item.tower.GetAllProjectiles()))
                            {
                                if (item2.damage == 2)
                                    item2.damage = 3;
                            }

                        }
                    }
                    if (Regex.IsMatch(tower.name, "DartMonkey-.4.") || Regex.IsMatch(tower.name, "DartMonkey-.5."))
                    {
                        tower.GetBehavior<AbilityModel>().Cooldown = 35f;
                    }

                }
                Game.instance.model.upgradesByName["Inferno Ring"].cost = 45000;
                Game.instance.model.upgradesByName["Bloon Crush"].cost = 45000;
                Game.instance.model.upgradesByName["Absolute Zero"].cost = 22000;
                Game.instance.model.upgradesByName["Cripple MOAB"].cost = 30000;
                Game.instance.model.upgradesByName["Energizer"].cost = 25000;
                Game.instance.model.upgradesByName["Support Chinook"].cost = 11000;
                //Game.instance.model.upgradesByName["Special Poperations"].cost = 26000;
                Game.instance.model.upgradesByName["Blooncineration"].cost = 40000;
                //Game.instance.model.upgradesByName["Wizard Lord Phoenix"].cost = 50000;
                Game.instance.model.upgradesByName["Tech Terror"].cost = 18000;
                Game.instance.model.upgradesByName["Flash Bomb"].cost = 1500;
                Game.instance.model.upgradesByName["Ball Lightning"].cost = 4500;
                Game.instance.model.upgradesByName["Transforming Tonic"].cost = 3500;
                Game.instance.model.upgradesByName["Spiked Mines"].cost = 9000;
                Game.instance.model.upgradesByName["Monkey City"].cost = 1000;
                Game.instance.model.upgradesByName["Call to Arms"].cost = 15000;
                Game.instance.model.upgradesByName["Homeland Defense"].cost = 30000;
                Game.instance.model.upgradesByName["Sentry Expert"].cost = 2000;
                Game.instance.model.upgradesByName["XXXL Trap"].cost = 50000;
                Game.instance.model.upgradesByName["Relentless Glue"].cost = 2000;
                Game.instance.model.upgradesByName["Super Glue"].cost = 25000;
                Game.instance.model.upgradesByName["Laser Cannon"].cost = 3000;
                //Game.instance.model.upgradesByName["Plasma Accelerator"].cost = 9000;
                Game.instance.model.upgradesByName["Comanche Commander"].cost = 30000;

                //Game.instance.model.upgradesByName["Flying Fortress"].cost = 80000;
                //Game.instance.model.upgradesByName["The Anti-Bloon"].cost = 80000;
                //Game.instance.model.upgradesByName["Ray of Doom"].cost = 80000;
                Game.instance.model.upgradesByName["Sun Temple"].cost = 80000;
                Game.instance.model.upgradesByName["Superstorm"].cost = 80000;
                Game.instance.model.upgradesByName["Ultraboost"].cost = 80000;
            }
        }

        static List<T> GetAllBehaviors<T>(List<ProjectileModel> model) where T : Model
        {
            List<Model> bevs = new List<Model>();
            foreach (var proj in model)
            {
                bevs.AddRange(proj.behaviors);
            }
            for (int i = 0; i < bevs.Count; i++)
            {
                var item = bevs[i];
                if (item.GetIl2CppType().Name == "AddBehaviorToBloonModel")
                    bevs.AddRange(item.Cast<AddBehaviorToBloonModel>().behaviors);
            }

            return bevs.GetItemsOfType<Model, T>();
        }

        //Console.WriteLine(tower.name);
        //tower.behaviors[13].Cast<AttackModel>().weapons[0].projectile.behaviors[0].Cast<StripChildrenModel>()
        //tower.behaviors.First(b => b.name.Contains("AttackModel_Attack_")).Cast<AttackModel>().weapons[0].behaviors;

        //File.WriteAllText(tower.name + ".json", JsonUtility.ToJson(tower).Replace("1000", "2000"));
        //JsonUtility.FromJsonInternal(JsonUtility.ToJson(tower).Replace("1000", "2000"), Game.instance.model.towers[i], Game.instance.model.towers[i].GetIl2CppType());//.Replace("1000", "2000")
        //if (Regex.IsMatch(tower.name, "NinjaMonkey-..5"))
        //{
        //    FileIOUtil.SaveObject(tower.name + ".json", tower);
        //    string stuff = File.ReadAllText(path + tower.name + ".json");
        //    stuff = stuff.Replace("1000", "2000").Replace("filters\": []", "filters\": null");
        //    File.WriteAllText(path + tower.name + ".json", stuff);
        //    Game.instance.model.towers[i] = FileIOUtil.LoadObject<TowerModel>(tower.name + ".json");
        //}

        //if (Regex.IsMatch(tower.name, "GlueGunner-..5"))
        //{
        //    foreach (var item in GetAllBehaviors<DamageOverTimeModel>(tower.GetAllProjectiles()))
        //    {
        //        item.damage = 75;
        //    }
        //}
        //if (Regex.IsMatch(tower.name, "HeliPilot-..5"))
        //{
        //    foreach (var item in GetAllBehaviors<DamageModel>(tower.GetBehavior<ComancheDefenceModel>().towerModel.GetAllProjectiles()))
        //    {
        //        if (item.name == "DamageModel_Explosion_")
        //            item.damage = 5;
        //    }
        //}
                    //       if (Regex.IsMatch(tower.name, "DartlingGunner-4.."))
                    //{
                    //    tower.GetBehavior<AttackModel>().weapons[0].emission.Cast<LineProjectileEmissionModel>().projectileAtEndModel.GetBehavior<DamageModel>().damage = 3;
                    //}

    public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {

            }
        }








    }

}