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

[assembly: MelonInfo(typeof(paragon_helper.Main), paragon_helper.ModHelperData.Name, paragon_helper.ModHelperData.Version, paragon_helper.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace paragon_helper
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("paragon_helper mod loaded");
        }



        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {



            }
        }

        class TowerInfo
        {
            public long pops;
            public float value;
            public float upgrades;
            public float tier5;
        }


        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (Input.GetKeyDown(KeyCode.F7))
                {
                    Dictionary<string, TowerInfo> types = new Dictionary<string, TowerInfo>();

                    foreach (var tower in InGame.instance.GetAllTowerToSim())
                    {
                        string baseName = tower.Def.baseId;
                        string name = tower.Def.name;

                        int upgrades = 0;
                        if (name.Contains("0"))
                        {
                            upgrades = name.Substring(name.Length - 3).Sum(c => c - '0');
                        }


                        if (!types.ContainsKey(baseName))
                        {
                            types.Add(baseName, new TowerInfo());
                        }

                        types[baseName].pops += tower.damageDealt;
                        types[baseName].value += tower.worth;
                        types[baseName].upgrades += upgrades;
                        types[baseName].tier5 += name.Contains("5") ? 1 : 0;

                    }

                    foreach (var type in types)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Info for tower type " + type.Key + ":");
                        Console.WriteLine("Total combined pops: " + type.Value.pops + " (max is 16.2 million for up to 90000 power)");
                        Console.WriteLine("Total combined money spent: " + type.Value.value + " (max is $250K for up to 10000 power)");
                        Console.WriteLine("Total combined upgrades: " + type.Value.upgrades + " (max is 100 upgrades for up to 10000 power)");
                        Console.WriteLine("Total combined tier 5 towers: " + type.Value.tier5 + " (max is 12 tier 5s for up to 90000 power)");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                }
            }
        }








    }

}