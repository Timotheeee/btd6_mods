using MelonLoader;
using Harmony;

using Il2CppAssets.Scripts.Unity.UI_New.InGame.Races;
using Il2CppAssets.Scripts.Simulation.Towers.Weapons;

using Il2CppAssets.Scripts.Simulation;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using Il2CppAssets.Scripts.Unity.UI_New.Main;

using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppAssets.Scripts.Models.Towers;

using Il2CppAssets.Scripts.Unity;



using Il2CppAssets.Scripts.Simulation.Towers;


using Il2CppAssets.Scripts.Utils;


using Il2CppSystem.Collections;

using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Simulation.Objects;
using Il2CppAssets.Scripts.Models;

using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using UnityEngine;
using Il2CppAssets.Scripts.Unity.Display;
using System.Linq;
using System.IO;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity.Player;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using Il2CppAssets.Scripts.Data.MapSets;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Data;

[assembly: MelonInfo(typeof(coop_fix.Main), coop_fix.ModHelperData.Name, coop_fix.ModHelperData.Version, coop_fix.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace coop_fix
{
    public class Main : MelonMod
    {

        List<string> customMaps = new List<string>()
        {
            "3TimesAround",
            "SpaceTruckin",
            "BloonOfClubs",
            "BattleSands",
            "LightningScar",
            "MonkeysInSpace",
            "BloontoniumLab",
            "MainStreet",
            "TarPits",
            "BloonsTD1",
            "OceanRoad",
            "HighTech",
            "BloonDunes",
            "Brickout",
            "PoolTable",
            "ConcreteAlley",
            "Riverside",
            "Maze",
            "Patch",
            "SnakeRiver",
            "AGame",
            "IndoorPools",
            "TreasureTrove",
            "Amogus",
            "BattlePark",
            "BloonCircles",
            "Blooncano",
            "BloontoniumCore",
            "BrickWall",
            "Cannal",
            "Castle",
            "Checkers",
            "Crossover",
            "Epilogue",
            "ExpressShipping",
            "FloodedBazaar",
            "Flower",
            "Grid",
            "Hairs",
            "Heartgate",
            "LongRange",
            "Lyne",
            "MilkAndCookies",
            "MinecraftDesert",
            "Mondrian",
            "MonkeyLane",
            "Offside",
            "PvZRoof",
            "RinksRevenge",
            "SkullPeak",
            "Slons",
            "SnowMonkey",
            "SprintTrack",
            "TheRink",
            "ToxicWaste",
            "TrueTrueExpert",
            "BTD6IRL",
            "TheSkeld",
            "WaterHazard",

        };


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("coop_fix loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();




            if (Input.GetKeyDown(KeyCode.F1))
            {
                


                var fixedmaps = new Il2CppSystem.Collections.Generic.Dictionary<string, Assets.Scripts.Models.Profile.MapInfo>();
                var normalMaps = new List<string>();

                Console.WriteLine("setting up list of normal maps");
                foreach (var map in GameData._instance.mapSet.Maps.items)
                {
                    normalMaps.Add(map.id);
                    Console.WriteLine("added " + map.id);
                }
                Console.WriteLine("done");

                Console.WriteLine("deleting all maps");
                foreach (var map in player2.Data.mapInfo.maps)
                {
                    if (normalMaps.Contains(map.key))
                    {
                        fixedmaps.Add(map.key, map.value);
                        Console.WriteLine("added " + map.key);
                    }
                }

                player2.Data.mapInfo.maps = fixedmaps;
                Console.WriteLine("updated profile");

            }


        }


        static Btd6Player player2;


        [HarmonyPatch(typeof(MapButton), "ShowMedal")]
        public class ShowMedal_Patch2
        {
            [HarmonyPrefix]
            public static bool Prefix(MapButton __instance, Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode)
            {
                player2 = player;


                return true;
            }
        }

    }

}