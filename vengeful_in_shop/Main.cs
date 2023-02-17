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
//using Newtonsoft.Json;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Models.Profile;

[assembly: MelonInfo(typeof(vengeful_in_shop.Main), vengeful_in_shop.ModHelperData.Name, vengeful_in_shop.ModHelperData.Version, vengeful_in_shop.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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
                        temp.icon.guidRef = b.portrait.guidRef;
                        temp.instaIcon.guidRef = b.portrait.guidRef;
                        temp.portrait.guidRef = b.portrait.guidRef;
                        vengeful = temp.Duplicate();

                        Console.WriteLine("saved " + tm.name);
                        
                        Game.instance.model.AddTowerToGame(vengeful, new ShopTowerDetailsModel(vengeful.name, 10, 0, 0, 0, -1, 0));
                        //Game.instance.GetPlayerProfile().unlockedTowers.Add(vengeful.name);
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