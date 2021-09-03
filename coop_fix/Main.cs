using MelonLoader;
using Harmony;

using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;

using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;

using Assets.Scripts.Unity.UI_New.Main;

using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using Assets.Scripts.Simulation.Towers;


using Assets.Scripts.Utils;


using Il2CppSystem.Collections;

using Assets.Scripts.Unity.UI_New.Popups;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using TMPro;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Assets.Scripts.Simulation.Towers.Behaviors;
using UnityEngine;
using Assets.Scripts.Unity.Display;
using System.Linq;
using System.IO;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Unity.Player;
using Assets.Scripts.Unity.UI_New.Main.MapSelect;
using Assets.Scripts.Data.MapSets;
using System.Collections.Generic;

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
                Console.WriteLine("deleting all maps");


                var fixedmaps = new Il2CppSystem.Collections.Generic.Dictionary<string, Assets.Scripts.Models.Profile.MapInfo>();

                foreach (var map in player2.Data.mapInfo.maps)
                {
                    if (!customMaps.Contains(map.key))
                    {
                        fixedmaps.Add(map.key,map.value);
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