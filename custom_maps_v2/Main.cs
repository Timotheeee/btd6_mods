using MelonLoader;
using HarmonyLib;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppAssets.Scripts.Unity;
using System.IO;
using Il2CppAssets.Main.Scenes;
using UnityEngine;
using System.Linq;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data.MapSets;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Models.Map;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Data;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Unity.Map;
using Il2CppAssets.Scripts.Unity.Bridge;
using System.Drawing;
//using System.Drawing.common;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Net;
using Il2CppSystem.Collections.Generic;
using Il2CppAssets.Scripts.Utils;
using BTD_Mod_Helper.Api.ModOptions;
using Il2CppSystem.Reflection;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using Il2CppAssets.Scripts.Unity.Player;
//using Il2CppNinjaKiwi.Common;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Profile;
using Il2CppNinjaKiwi.Common;

[assembly: MelonInfo(typeof(custommaps.Main), custommaps.ModHelperData.Name, custommaps.ModHelperData.Version, custommaps.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace custommaps
{
    public class Main : BloonsMod
    {
        public override string MelonInfoCsURL => "https://raw.githubusercontent.com/Timotheeee/btd6_mods/master/custom_maps_v2/Main.cs";
        public override string LatestURL => "https://github.com/Timotheeee/btd6_mods/blob/master/custom_maps_v2/custommaps.dll?raw=true";
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            MelonLogger.Msg("custom maps loaded");
        }
        static string lastMap = null;
        static bool isCustom(string map)
        {
            return mapList.Where(x => x.name == map).Count() > 0;
        }
        private readonly static ModSettingString Info = new ModSettingString("Restart your game to apply changes!")
        {
            displayName = "Restart your game to apply changes!",
        };
        private readonly static ModSettingBool MemeMaps = new ModSettingBool(true)
        {
            IsButton = false,
            displayName = "Meme Maps",
        };
        private readonly static ModSettingBool OldMaps = new ModSettingBool(true)
        {
            IsButton = false,
            displayName = "Old (BTD 1-3) Maps",
        };
        private readonly static ModSettingBool BTD4Maps = new ModSettingBool(true)
        {
            IsButton = false,
            displayName = "BTD 4 Maps",
        };
        private readonly static ModSettingBool BTD5Maps = new ModSettingBool(true)
        {
            IsButton = false,
            displayName = "BTD 5 Maps",
        };
        private readonly static ModSettingBool BTDBMaps = new ModSettingBool(true)
        {
            IsButton = false,
            displayName = "BTD Battles Maps",
        };
        private readonly static ModSettingBool BTDB2Maps = new ModSettingBool(true)
        {
            IsButton = false,
            displayName = "BTD Battles 2 Maps",
        };
        private readonly static ModSettingBool BMCMaps = new ModSettingBool(true)
        {
            IsButton = false,
            displayName = "BMC Maps",
        };
        private readonly static ModSettingBool NewMaps = new ModSettingBool(true)
        {
            IsButton = false,
            displayName = "New (Completely custom) Maps",
        };

        public static Il2CppReferenceArray<Il2CppAssets.Scripts.Simulation.SMath.Polygon> Empty()
        {
            //var ar = new Il2CppAssets.Scripts.Simulation.SMath.Polygon(new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>());
            return new Il2CppReferenceArray<Il2CppAssets.Scripts.Simulation.SMath.Polygon>(0);
        }

        class MapData
        {
            public string name; //Map name without spaces or any special characters
            public MapDifficulty difficulty; //Map difficulty
            public PathModel[] paths; //Map paths, do MapClassName.pathmodel
            public PathSpawnerModel spawner; //Map paths, do MapClassName.spawner
            public Il2CppReferenceArray<AreaModel> areas; //Map paths, do MapClassName.areas
            public string mapMusic; //Map music, there are examples in mapList
            public string mapDisplayName; //Map name with spaces
            public string mapType; //Types: "Meme", "Old" "BTD 4", "BTD 5", "BTD B", "BMC" "New"

            public MapData(string name, MapDifficulty difficulty, PathModel[] paths, PathSpawnerModel spawner, Il2CppReferenceArray<AreaModel> areas, string mapMusic, string mapDisplayName, string mapType)
            {
                this.name = name;
                this.difficulty = difficulty;
                this.paths = paths;
                this.spawner = spawner;
                this.areas = areas;
                this.mapMusic = mapMusic;
                this.mapDisplayName = mapDisplayName;
                this.mapType = mapType;

            }
        }
        static MapData[] mapList = new MapData[]
        {
            new MapData("3TimesAround", MapDifficulty.Beginner, Maps._3TimesAround.pathmodel(), Maps._3TimesAround.spawner(), Maps._3TimesAround.areas(), "MusicBTD5JazzA", "3 Times Around", "BTD 5"),
            new MapData("SpaceTruckin", MapDifficulty.Beginner, Maps.SpaceTruckin.pathmodel(), Maps.SpaceTruckin.spawner(), Maps.SpaceTruckin.areas(), "MusicBTD5JazzA", "Space Truckin'", "BTD 5"),
            new MapData("BloonOfClubs", MapDifficulty.Intermediate, Maps.BloonOfClubs.pathmodel(), Maps.BloonOfClubs.spawner(), Maps.BloonOfClubs.areas(), "MusicBTD5JazzA", "Bloon Of Clubs", "BTD 5"),
            new MapData("BattleSands", MapDifficulty.Intermediate, Maps.BattleSands.pathmodel(), Maps.BattleSands.spawner(), Maps.BattleSands.areas(), "MusicDarkA", "Battle Sands", "BTD B"),
            new MapData("LightningScar", MapDifficulty.Advanced, Maps.LightningScar.pathmodel(), Maps.LightningScar.spawner(), Maps.LightningScar.areas(), "MusicBTD5JazzA", "Lightning Scar", "BTD 5"),
            new MapData("MonkeysInSpace", MapDifficulty.Advanced, Maps.MonkeysInSpace.pathmodel(), Maps.MonkeysInSpace.spawner(), Maps.MonkeysInSpace.areas(), "MusicDarkA", "Monkeys In Space", "New"),
            new MapData("BloontoniumLab", MapDifficulty.Expert, Maps.BloontoniumLab.pathmodel(), Maps.BloontoniumLab.spawner(), Maps.BloontoniumLab.areas(), "MusicBTD5JazzA", "Bloontonium Lab", "BTD 5"),
            new MapData("MainStreet", MapDifficulty.Expert, Maps.MainStreet.pathmodel(), Maps.MainStreet.spawner(), Maps.MainStreet.areas(), "MusicBTD5JazzA", "Main Street", "BTD 5"),
            new MapData("TarPits", MapDifficulty.Expert, Maps.TarPits.pathmodel(), Maps.TarPits.spawner(), Maps.TarPits.areas(), "MusicBTD5JazzA", "Tar Pits", "BTD 5"),
            new MapData("BloonsTD1", MapDifficulty.Beginner, Maps.BTD1.pathmodel(), Maps.BTD1.spawner(), Maps.BTD1.areas(), "MusicDarkA", "Bloons TD 1", "Old"), //Credits to K1d_5h31d0n for this map texture
            new MapData("OceanRoad", MapDifficulty.Beginner, Maps.OceanRoad.pathmodel(), Maps.OceanRoad.spawner(), Maps.OceanRoad.areas(), "MusicDarkA", "Ocean Road", "BTD 4"),
            new MapData("HighTech", MapDifficulty.Expert, Maps.HighTech.pathmodel(), Maps.HighTech.spawner(), Maps.HighTech.areas(), "MusicDarkA", "High Tech", "BTD 4"), //Credits to K1d_5h31d0n for this map texture
            new MapData("BloonDunes", MapDifficulty.Advanced, Maps.BloonDunes.pathmodel(), Maps.BloonDunes.spawner(), Maps.BloonDunes.areas(), "MusicDarkA", "Bloon Dunes", "Old"), //Credits to K1d_5h31d0n for this map texture
            new MapData("Brickout", MapDifficulty.Advanced, Maps.BrickoutData.pathmodel(), Maps.BrickoutData.spawner(), Maps.BrickoutData.areas(), "MusicDarkA", "Brickout", "New"),
            new MapData("PoolTable", MapDifficulty.Intermediate, Maps.PoolTable.pathmodel(), Maps.PoolTable.spawner(), Maps.PoolTable.areas(), "MusicDarkA", "Pool Table", "BTD 4"),
            new MapData("ConcreteAlley", MapDifficulty.Intermediate, Maps.ConcreteAlley.pathmodel(), Maps.ConcreteAlley.spawner(), Maps.ConcreteAlley.areas(), "MusicDarkA", "Concrete Alley", "BTD B"),
            new MapData("Riverside", MapDifficulty.Intermediate, Maps.Riverside.pathmodel(), Maps.Riverside.spawner(), Maps.Riverside.areas(), "MusicDarkA", "Riverside", "BTD B"),
            new MapData("Maze", MapDifficulty.Beginner, Maps.Maze.pathmodel(), Maps.Maze.spawner(), Maps.Maze.areas(), "MusicBTD5JazzA", "Maze", "BTD 5"),
            new MapData("Patch", MapDifficulty.Beginner, Maps.Patch.pathmodel(), Maps.Patch.spawner(), Maps.Patch.areas(), "MusicBTD5JazzA", "Patch", "BTD 5"),
            new MapData("SnakeRiver", MapDifficulty.Intermediate, Maps.SnakeRiver.pathmodel(), Maps.SnakeRiver.spawner(), Maps.SnakeRiver.areas(), "MusicBTD5JazzA", "Snake River", "BTD 5"),
            new MapData("AGame", MapDifficulty.Advanced, Maps.AGame.pathmodel(), Maps.AGame.spawner(), Maps.AGame.areas(), "MusicDarkA", "A-Game", "BTD B"),
            new MapData("IndoorPools", MapDifficulty.Advanced, Maps.IndoorPools.pathmodel(), Maps.IndoorPools.spawner(), Maps.IndoorPools.areas(), "MusicDarkA", "Indoor Pools", "BTD B"),
            new MapData("TreasureTrove", MapDifficulty.Expert, Maps.TreasureTrove.pathmodel(), Maps.TreasureTrove.spawner(), Maps.TreasureTrove.areas(), "MusicDarkA", "Treasure Trove", "BMC"),
            new MapData("Amogus", MapDifficulty.Expert, Maps.Amogus.pathmodel(), Maps.Amogus.spawner(), Maps.Amogus.areas(), "MusicDarkA", "Amogus", "Meme"),
            new MapData("BattlePark", MapDifficulty.Intermediate, Maps.BattlePark.pathmodel(), Maps.BattlePark.spawner(), Maps.BattlePark.areas(), "MusicDarkA", "Battle Park", "BTD B"),
            new MapData("BloonCircles", MapDifficulty.Intermediate, Maps.BloonCircles.pathmodel(), Maps.BloonCircles.spawner(), Maps.BloonCircles.areas(), "MusicDarkA", "Bloon Circles", "BTD B"),
            new MapData("Blooncano", MapDifficulty.Expert, Maps.Blooncano.pathmodel(), Maps.Blooncano.spawner(), Maps.Blooncano.areas(), "MusicDarkA", "Blooncano", "New"),
            new MapData("BloontoniumCore", MapDifficulty.Expert, Maps.BloontoniumCore.pathmodel(), Maps.BloontoniumCore.spawner(), Maps.BloontoniumCore.areas(), "MusicDarkA", "Bloontonium Core", "New"),
            new MapData("BrickWall", MapDifficulty.Beginner, Maps.BrickWall.pathmodel(), Maps.BrickWall.spawner(), Maps.BrickWall.areas(), "MusicBTD5JazzA", "Brick Wall", "BTD 5"),
            new MapData("Cannal", MapDifficulty.Expert, Maps.Cannal.pathmodel(), Maps.Cannal.spawner(), Maps.Cannal.areas(), "MusicDarkA", "Cannal", "New"),
            new MapData("Castle", MapDifficulty.Advanced, Maps.Castle.pathmodel(), Maps.Castle.spawner(), Maps.Castle.areas(), "MusicBTD5JazzA", "Castle", "BTD 5"),
            new MapData("Checkers", MapDifficulty.Beginner, Maps.Checkers.pathmodel(), Maps.Checkers.spawner(), Maps.Checkers.areas(), "MusicBTD5JazzA", "Checkers", "BTD 5"),
            new MapData("Crossover", MapDifficulty.Expert, Maps.Crossover.pathmodel(), Maps.Crossover.spawner(), Maps.Crossover.areas(), "MusicDarkA", "Crossover", "New"),
            new MapData("Epilogue", MapDifficulty.Expert, Maps.Epilogue.pathmodel(), Maps.Epilogue.spawner(), Maps.Epilogue.areas(), "MusicDarkA", "Epilogue", "New"),
            new MapData("ExpressShipping", MapDifficulty.Beginner, Maps.ExpressShipping.pathmodel(), Maps.ExpressShipping.spawner(), Maps.ExpressShipping.areas(), "MusicBTD5JazzA", "Express Shipping", "BTD 5"),
            new MapData("FloodedBazaar", MapDifficulty.Expert, Maps.FloodedBazaar.pathmodel(), Maps.FloodedBazaar.spawner(), Maps.FloodedBazaar.areas(), "MusicDarkA", "Flooded Bazaar", "New"),
            new MapData("Flower", MapDifficulty.Expert, Maps.Flower.pathmodel(), Maps.Flower.spawner(), Maps.Flower.areas(), "MusicDarkA", "Flower", "New"),
            new MapData("Grid", MapDifficulty.Expert, Maps.Grid.pathmodel(), Maps.Grid.spawner(), Maps.Grid.areas(), "MusicDarkA", "Grid", "Meme"),
            new MapData("Hairs", MapDifficulty.Expert, Maps.Hairs.pathmodel(), Maps.Hairs.spawner(), Maps.Hairs.areas(), "MusicDarkA", "Hairs", "Meme"),
            new MapData("Heartgate", MapDifficulty.Expert, Maps.Heartgate.pathmodel(), Maps.Heartgate.spawner(), Maps.Heartgate.areas(), "MusicDarkA", "Heartgate", "New"),
            new MapData("LongRange", MapDifficulty.Expert, Maps.LongRange.pathmodel(), Maps.LongRange.spawner(), Maps.LongRange.areas(), "MusicBTD5JazzA", "Long Range", "BTD 5"),
            new MapData("Lyne", MapDifficulty.Advanced, Maps.Lyne.pathmodel(), Maps.Lyne.spawner(), Maps.Lyne.areas(), "MusicDarkA", "Lyne", "New"),
            new MapData("MilkAndCookies", MapDifficulty.Beginner, Maps.MilkAndCookies.pathmodel(), Maps.MilkAndCookies.spawner(), Maps.MilkAndCookies.areas(), "MusicDarkA", "Milk And Cookies", "BTD 4"),
            new MapData("MinecraftDesert", MapDifficulty.Intermediate, Maps.MinecraftDesert.pathmodel(), Maps.MinecraftDesert.spawner(), Maps.MinecraftDesert.areas(), "MusicDarkA", "Minecraft Desert", "New"),
            new MapData("Mondrian", MapDifficulty.Intermediate, Maps.Mondrian.pathmodel(), Maps.Mondrian.spawner(), Maps.Mondrian.areas(), "MusicDarkA", "Mondrian", "BTD B"),
            new MapData("MonkeyLane", MapDifficulty.Beginner, Maps.MonkeyLane.pathmodel(), Maps.MonkeyLane.spawner(), Maps.MonkeyLane.areas(), "MusicBTD5JazzA", "Monkey Lane", "BTD 5"),
            new MapData("Offside", MapDifficulty.Intermediate, Maps.Offside.pathmodel(), Maps.Offside.spawner(), Maps.Offside.areas(), "MusicDarkA", "Offside", "BTD B"),
            new MapData("PvZRoof", MapDifficulty.Intermediate, Maps.PvZRoof.pathmodel(), Maps.PvZRoof.spawner(), Maps.PvZRoof.areas(), "MusicDarkA", "PvZ Roof", "New"),
            new MapData("RinksRevenge", MapDifficulty.Advanced, Maps.RinksRevenge.pathmodel(), Maps.RinksRevenge.spawner(), Maps.RinksRevenge.areas(), "MusicBTD5JazzA", "Rinks Revenge", "BTD 5"),
            new MapData("SkullPeak", MapDifficulty.Beginner, Maps.SkullPeak.pathmodel(), Maps.SkullPeak.spawner(), Maps.SkullPeak.areas(), "MusicBTD5JazzA", "Skull Peak", "BTD 5"),
            new MapData("Slons", MapDifficulty.Expert, Maps.Slons.pathmodel(), Maps.Slons.spawner(), Maps.Slons.areas(), "MusicDarkA", "Slons", "Meme"),
            new MapData("SnowMonkey", MapDifficulty.Beginner, Maps.SnowMonkey.pathmodel(), Maps.SnowMonkey.spawner(), Maps.SnowMonkey.areas(), "MusicDarkA", "Snow Monkey", "BTD 4"),
            new MapData("SprintTrack", MapDifficulty.Beginner, Maps.SprintTrack.pathmodel(), Maps.SprintTrack.spawner(), Maps.SprintTrack.areas(), "MusicBTD5JazzA", "Sprint Track", "BTD 5"),
            new MapData("TheRink", MapDifficulty.Beginner, Maps.TheRink.pathmodel(), Maps.TheRink.spawner(), Maps.TheRink.areas(), "MusicBTD5JazzA", "The Rink", "BTD 5"),
            new MapData("ToxicWaste", MapDifficulty.Expert, Maps.ToxicWaste.pathmodel(), Maps.ToxicWaste.spawner(), Maps.ToxicWaste.areas(), "MusicBTD5JazzA", "Toxic Waste", "BTD 5"),
            new MapData("TrueTrueExpert", MapDifficulty.Expert, Maps.TrueTrueExpert.pathmodel(), Maps.TrueTrueExpert.spawner(), Maps.TrueTrueExpert.areas(), "MusicDarkA", "True True Expert", "Meme"),
            new MapData("BTD6IRL", MapDifficulty.Expert, Maps.BTD6IRL.pathmodel(), Maps.BTD6IRL.spawner(), Maps.BTD6IRL.areas(), "MusicDarkA", "BTD 6 IRL", "Meme"),
            new MapData("TheSkeld", MapDifficulty.Expert, Maps.TheSkeld.pathmodel(), Maps.TheSkeld.spawner(), Maps.TheSkeld.areas(), "MusicDarkA", "The Skeld", "New"),
            new MapData("WaterHazard", MapDifficulty.Intermediate, Maps.WaterHazard.pathmodel(), Maps.WaterHazard.spawner(), Maps.WaterHazard.areas(), "MusicDarkA", "Water Hazard", "BTD 5"),
            //new MapData("Docks", MapDifficulty.Beginner, Maps.BTDBattles2.Docks.pathmodel(), Maps.BTDBattles2.Docks.spawner(), Maps.BTDBattles2.Docks.areas(), "MusicDarkA", "Docks", "BTD B2"),
            //new MapData("BasaltColumns", MapDifficulty.Beginner, Maps.BTDBattles2.BasaltColumns.pathmodel(), Maps.BTDBattles2.BasaltColumns.spawner(), Maps.BTDBattles2.BasaltColumns.areas(), "MusicDarkA", "Basalt Columns", "BTD B2"),
            //new MapData("Garden", MapDifficulty.Beginner, Maps.BTDBattles2.Garden.pathmodel(), Maps.BTDBattles2.Garden.spawner(), Maps.BTDBattles2.Garden.areas(), "MusicDarkA", "Garden", "BTD B2"),
            //new MapData("Koru", MapDifficulty.Beginner, Maps.BTDBattles2.Koru.pathmodel(), Maps.BTDBattles2.Koru.spawner(), Maps.BTDBattles2.Koru.areas(), "MusicDarkA", "Koru", "BTD B2"),
            //new MapData("Mayan", MapDifficulty.Beginner, Maps.BTDBattles2.Mayan.pathmodel(), Maps.BTDBattles2.Mayan.spawner(), Maps.BTDBattles2.Mayan.areas(), "MusicDarkA", "Mayan", "BTD B2"),
            //new MapData("SandsOfTime", MapDifficulty.Beginner, Maps.BTDBattles2.SandsOfTime.pathmodel(), Maps.BTDBattles2.SandsOfTime.spawner(), Maps.BTDBattles2.SandsOfTime.areas(), "MusicDarkA", "Sands Of Time", "BTD B2"),
            //new MapData("InTheWall", MapDifficulty.Beginner, Maps.BTDBattles2.InTheWall.pathmodel(), Maps.BTDBattles2.InTheWall.spawner(), Maps.BTDBattles2.InTheWall.areas(), "MusicDarkA", "In The Wall", "BTD B2"),
            //new MapData("BloontoniumMines", MapDifficulty.Beginner, Maps.BTDBattles2.BloontoniumMines.pathmodel(), Maps.BTDBattles2.BloontoniumMines.spawner(), Maps.BTDBattles2.BloontoniumMines.areas(), "MusicDarkA", "Bloontonium Mines", "BTD B2"),
            //new MapData("CastleRuins", MapDifficulty.Beginner, Maps.BTDBattles2.CastleRuins.pathmodel(), Maps.BTDBattles2.CastleRuins.spawner(), Maps.BTDBattles2.CastleRuins.areas(), "MusicDarkA", "Castle Ruins", "BTD B2"),
            //new MapData("Glade", MapDifficulty.Beginner, Maps.BTDBattles2.Glade.pathmodel(), Maps.BTDBattles2.Glade.spawner(), Maps.BTDBattles2.Glade.areas(), "MusicDarkA", "Glade", "BTD B2"),
            //new MapData("DinoGraveyard", MapDifficulty.Beginner, Maps.BTDBattles2.DinoGraveyard.pathmodel(), Maps.BTDBattles2.DinoGraveyard.spawner(), Maps.BTDBattles2.DinoGraveyard.areas(), "MusicDarkA", "Dino Graveyard", "BTD B2"),
            //new MapData("Inflection", MapDifficulty.Beginner, Maps.BTDBattles2.Inflection.pathmodel(), Maps.BTDBattles2.Inflection.spawner(), Maps.BTDBattles2.Inflection.areas(), "MusicDarkA", "Inflection", "BTD B2"),
            //new MapData("Ports", MapDifficulty.Beginner, Maps.BTDBattles2.Ports.pathmodel(), Maps.BTDBattles2.Ports.spawner(), Maps.BTDBattles2.Ports.areas(), "MusicDarkA", "Ports", "BTD B2"),
            //new MapData("InTheWallDouble", MapDifficulty.Intermediate, Maps.BTDBattles2.InTheWallDouble.pathmodel(), Maps.BTDBattles2.InTheWallDouble.spawner(), Maps.BTDBattles2.InTheWallDouble.areas(), "MusicDarkA", "In The Wall Double", "BTD B2"),
            //new MapData("BloontoniumMinesDouble", MapDifficulty.Intermediate, Maps.BTDBattles2.BloontoniumMinesDouble.pathmodel(), Maps.BTDBattles2.BloontoniumMinesDouble.spawner(), Maps.BTDBattles2.BloontoniumMinesDouble.areas(), "MusicDarkA", "Bloontonium Mines Double", "BTD B2"),
            //new MapData("CastleRuinsDouble", MapDifficulty.Intermediate, Maps.BTDBattles2.CastleRuinsDouble.pathmodel(), Maps.BTDBattles2.CastleRuinsDouble.spawner(), Maps.BTDBattles2.CastleRuinsDouble.areas(), "MusicDarkA", "Castle Ruins Double", "BTD B2"),
        };

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                foreach (var item in GameData._instance.mapSet.Maps.items)
                {
                    //System.Console.WriteLine(item.mapMusic);
                }
                foreach (var mapdata in mapList)
                {
                    //Yes, there are more cleaner and easier ways, but each way I tried would somehow break the game
                    if (MemeMaps && mapdata.mapType == "Meme")
                    {
                        GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.AddTo(new MapDetails
                        {
                            id = mapdata.name,
                            isBrowserOnly = false,
                            isDebug = false,
                            difficulty = mapdata.difficulty,
                            unlockDifficulty = MapDifficulty.Beginner,
                            mapMusic = mapdata.mapMusic,
                            mapSprite = ModContent.GetSpriteReference<Main>(mapdata.name),
                            coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        }).ToArray();
                    }
                    if (OldMaps && mapdata.mapType == "Old")
                    {
                        GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.AddTo(new MapDetails
                        {
                            id = mapdata.name,
                            isBrowserOnly = false,
                            isDebug = false,
                            difficulty = mapdata.difficulty,
                            unlockDifficulty = MapDifficulty.Beginner,
                            mapMusic = mapdata.mapMusic,
                            mapSprite = ModContent.GetSpriteReference<Main>(mapdata.name),
                            coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        }).ToArray();
                    }
                    if (BTD4Maps && mapdata.mapType == "BTD 4")
                    {
                        GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.AddTo(new MapDetails
                        {
                            id = mapdata.name,
                            isBrowserOnly = false,
                            isDebug = false,
                            difficulty = mapdata.difficulty,
                            unlockDifficulty = MapDifficulty.Beginner,
                            mapMusic = mapdata.mapMusic,
                            mapSprite = ModContent.GetSpriteReference<Main>(mapdata.name),
                            coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        }).ToArray();
                    }
                    if (BTD5Maps && mapdata.mapType == "BTD 5")
                    {
                        GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.AddTo(new MapDetails
                        {
                            id = mapdata.name,
                            isBrowserOnly = false,
                            isDebug = false,
                            difficulty = mapdata.difficulty,
                            unlockDifficulty = MapDifficulty.Beginner,
                            mapMusic = mapdata.mapMusic,
                            mapSprite = ModContent.GetSpriteReference<Main>(mapdata.name),
                            coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        }).ToArray();
                    }
                    if (BTDBMaps && mapdata.mapType == "BTD B")
                    {
                        GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.AddTo(new MapDetails
                        {
                            id = mapdata.name,
                            isBrowserOnly = false,
                            isDebug = false,
                            difficulty = mapdata.difficulty,
                            unlockDifficulty = MapDifficulty.Beginner,
                            mapMusic = mapdata.mapMusic,
                            mapSprite = ModContent.GetSpriteReference<Main>(mapdata.name),
                            coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        }).ToArray();
                    }
                    if (BMCMaps && mapdata.mapType == "BMC")
                    {
                        GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.AddTo(new MapDetails
                        {
                            id = mapdata.name,
                            isBrowserOnly = false,
                            isDebug = false,
                            difficulty = mapdata.difficulty,
                            unlockDifficulty = MapDifficulty.Beginner,
                            mapMusic = mapdata.mapMusic,
                            mapSprite = ModContent.GetSpriteReference<Main>(mapdata.name),
                            coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        }).ToArray();
                    }
                    if (BTDB2Maps && mapdata.mapType == "BTD B2")
                    {
                        GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.AddTo(new MapDetails
                        {
                            id = mapdata.name,
                            isBrowserOnly = false,
                            isDebug = false,
                            difficulty = mapdata.difficulty,
                            unlockDifficulty = MapDifficulty.Beginner,
                            mapMusic = mapdata.mapMusic,
                            mapSprite = ModContent.GetSpriteReference<Main>(mapdata.name),
                            coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        }).ToArray();
                    }
                    if (NewMaps && mapdata.mapType == "New")
                    {
                        GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.AddTo(new MapDetails
                        {
                            id = mapdata.name,
                            isBrowserOnly = false,
                            isDebug = false,
                            difficulty = mapdata.difficulty,
                            unlockDifficulty = MapDifficulty.Beginner,
                            mapMusic = mapdata.mapMusic,
                            mapSprite = ModContent.GetSpriteReference<Main>(mapdata.name),
                            coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        }).ToArray();
                    }
                    if (!LocalizationManager.Instance.textTable.ContainsKey(mapdata.name))
                    {
                        LocalizationManager.Instance.textTable.Add(mapdata.name, mapdata.mapDisplayName);
                    }
                }
            }
        }


        /*[HarmonyPatch(typeof(MapButton), "ShowMedal")]
        public class ShowMedal_Patch2
        {
            [HarmonyPrefix]
            public static bool Prefix(MapButton __instance, Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode)
            {


                foreach (var mapData in mapList)
                {
                    player.UnlockMap(mapData.name);

                }

                return true;
            }
        }*/

        [HarmonyPatch(typeof(MapButton), "ShowMedal")]
        public class ShowMedal_Patch2
        {
            [HarmonyPrefix]
            public static bool Prefix(MapButton __instance, Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode)
            {
                foreach (var mapData in mapList)
                {
                    Game.instance.GetBtd6Player().UnlockMap(mapData.name);
                    //InGame.instance.Player.UnlockMap(mapData.name);
                }
                return true;

            }
        }

        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;

            if (Input.GetKeyDown(KeyCode.F9))
            {
                foreach (var mapData in mapList)
                {
                    Game.instance.GetBtd6Player().UnlockMap(mapData.name);
                    //InGame.instance.Player.UnlockMap(mapData.name);
                }
            }
        
        }


        [HarmonyPatch(typeof(MapLoader), nameof(MapLoader.LoadScene))]
        public class LoadMap
        {
            [HarmonyPrefix]
            internal static bool Fix(ref MapLoader __instance)
            {
                //MelonLogger.Msg(__instance.currentMapName);
                //__instance.currentMapName
                lastMap = __instance.currentMapName;
                if (isCustom(lastMap))
                {
                    __instance.currentMapName = "MuddyPuddles";

                }

                return true;
            }
        }
        static bool shouldRun = true;


        [HarmonyPatch(typeof(UnityToSimulation), nameof(UnityToSimulation.InitMap))]
        internal class InitMap_Patch
        {
            [HarmonyPrefix]
            internal static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {

                //MelonLogger.Msg("processing part 1");
                //MelonLogger.Msg(LastMap);
                if (!isCustom(lastMap)) return true;
                var ob2 = GameObject.Find("MuddyPuddlesTerrain");


                foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (ob.name.Contains("Festive") || ob.name.Contains("Rocket") || ob.name.Contains("Firework") || ob.name.Contains("Box") || ob.name.Contains("Candy") || ob.name.Contains("Gift") || ob.name.Contains("Snow") || ob.name.Contains("Ripples") || ob.name.Contains("Grass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower") || ob.name.Contains("Tree") || ob.name.Contains("Rock") || ob.name.Contains("Shadow") || ob.name.Contains("WaterSplashes"))
                    {
                        if(ob.transform.position.x == 1000 && ob.transform.position.y == 1000 && ob.transform.position.z == 1000)
                        {
                            //MelonLogger.Msg("already processed");
                            return true;
                        }
                    }
                }

                //if (ob2.GetComponent<Renderer>().material.mainTexture.width != 2048)
                //{
                //    MelonLogger.Msg("already processed");
                //    return true;
                //}


                //MelonLogger.Msg("processing part 2");
                MapData mapdata = mapList.Where(x => x.name == lastMap).First();
                Texture2D tex = ModContent.GetTexture<Main>(mapdata.name);
                //MelonLogger.Msg("size: " + tex.width + " " + tex.height);
                byte[] filedata = null;
                filedata = Resize(ImageConversion.EncodeToPNG(tex), 1652, 1064);
                float divx = 2;
                float divy = 1.21f;
                int marginx = 450;
                int marginy = 890;
                Bitmap old = new Bitmap(System.Drawing.Image.FromStream(new MemoryStream(filedata)));//new Bitmap(filePath);
                Bitmap newImage = new Bitmap(old.Width + marginx, old.Height + marginy);
                using (var graphics = System.Drawing.Graphics.FromImage(newImage))
                {
                    //graphics.Clear(paddingColor);
                    int x = (int)((newImage.Width - old.Width) / divx);
                    int y = (int)((newImage.Height - old.Height) / divy);
                    graphics.DrawImage(old, x, y);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        filedata = ms.ToArray();
                    }
                }
                Texture2D tex2 = new Texture2D(tex.width,tex.height);
                ImageConversion.LoadImage(tex2, filedata);
                ob2.GetComponent<Renderer>().material.mainTexture = tex2;

                foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (ob.name.Contains("Festive") || ob.name.Contains("Rocket") || ob.name.Contains("Firework") || ob.name.Contains("Box") || ob.name.Contains("Candy") || ob.name.Contains("Gift") || ob.name.Contains("Snow") || ob.name.Contains("Ripples") || ob.name.Contains("Grass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower") || ob.name.Contains("Tree") || ob.name.Contains("Rock") || ob.name.Contains("Shadow") || ob.name.Contains("WaterSplashes"))// || ob.name.Contains("Body")   || ob.name.Contains("Ouch") || ob.name.Contains("Statue")|| ob.name.Contains("Chute")  || ob.name.Contains("Jump") || ob.name.Contains("Timer") || ob.name.Contains("Wheel") || ob.name.Contains("Body") || ob.name.Contains("Axle") || ob.name.Contains("Leg") || ob.name.Contains("Clock") ||
                        if (ob.name != "MuddyPuddlesTerrain")
                            ob.transform.position = new Vector3(1000, 1000, 1000);
                }

                map.areas = mapdata.areas;
                map.spawner = mapdata.spawner;
                //map.paths[0].points = Maps.BTD1.track1();
                map.paths = mapdata.paths;
                //map.paths = new PathModel[]
                //    {
                //        mapdata.paths[0],
                //        mapdata.paths[0],
                //        mapdata.paths[0],
                //        mapdata.paths[0],
                //    };
                map.name = mapdata.name;
                map.mapName = mapdata.name;

                //map.mapWideBloonSpeed = 1;
                //map.mapDifficulty = 1;
                //map.blockers = new Il2CppReferenceArray<BlockerModel>(0);
                //map.gizmos = new Il2CppReferenceArray<Il2CppAssets.Scripts.Models.Map.Gizmos.MapGizmoModel>(0);

                //System.Console.WriteLine("InitMap_Patch, map.paths[0].points[0].point.x: " + map.paths[0].points[0].point.x);
                //System.Console.WriteLine("InitMap_Patch, map.paths[0].points[1].point.x: " + map.paths[0].points[1].point.x);
                //System.Console.WriteLine("InitMap_Patch, mapdata.spawner.name: " + mapdata.spawner.name);
                //System.Console.WriteLine("InitMap_Patch, mapdata.spawner.forwardSplitter.paths[0]: " + mapdata.spawner.forwardSplitter.paths[0]);
                //System.Console.WriteLine("InitMap_Patch, mapdata.paths[0].name: " + mapdata.paths[0].name);


                if (GameObject.Find("Rain"))
                    GameObject.Find("Rain").active = false;

                //MelonLogger.Msg("processing part 3");
                return true;
            }

        }
        public static byte[] Resize(byte[] data, int width, int height)
        {
            using (var stream = new MemoryStream(data))
            {
                var image = System.Drawing.Image.FromStream(stream);

                //var height = (width * image.Height) / image.Width;
                //var thumbnail = image.GetThumbnailImage(width, height, null, IntPtr.Zero);
                Bitmap b = ResizeImage(image, width, height);//new Bitmap(image, 1652, 1064);
                //b.Save("test.png", ImageFormat.Png);

                using (var thumbnailStream = new MemoryStream())
                {
                    b.Save(thumbnailStream, ImageFormat.Png);
                    return thumbnailStream.ToArray();
                }
            }
        }
        public static Bitmap ResizeImage(System.Drawing.Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = System.Drawing.Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        [HarmonyPatch(typeof(TowerModel), "IsTowerPlaceableInAreaType")]
        public class IsTowerPlaceableInAreaType_Patch
        {

            [HarmonyPrefix]
            static bool Prefix(ref bool __result, AreaType areaType)
            {
                //MelonLogger.Msg(lastMap);
                if (lastMap != "Epilogue" && lastMap != "Crossover") return true;
                __result = true;
                return false;
            }
        }


    }

}