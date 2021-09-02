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


        static TowerModel vengeful;
        static ProfileModel profile;

        public override void OnUpdate()
        {
            base.OnUpdate();


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

                }
            }

        }

        

        [HarmonyPatch(typeof(ProfileModel), "Validate")]
        public class ProfileModel_Patch
        {

            [HarmonyPostfix]
            public static void Postfix(ref ProfileModel __instance)
            {
                profile = __instance;

            }
        }


    }


}