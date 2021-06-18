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
using static Assets.Scripts.Models.Towers.TargetType;
using Assets.Scripts.Simulation;
using Assets.Scripts.Data.MapSets;
using Assets.Scripts.Models.Map.Spawners;
using Assets.Scripts.Models.Map;
using UnhollowerBaseLib;
using Assets.Scripts.Data;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper;
using Assets.Scripts.Unity.Map;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Unity.Localization;
using UnityEngine.UI;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace custommaps
{
    public class Main : BloonsMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            MelonLogger.Msg("custom maps loaded");
        }
        static string LastMap = null;
        static bool isCustom(string map)
        {
            return mapList.Where(x => x.name == map).Count() > 0;
        }
        class MapData
        {
            public string name;
            public MapDifficulty difficulty;
            public PathModel[] paths;
            public PathSpawnerModel spawner;
            public Il2CppReferenceArray<AreaModel> areas;
            public string mapMusic;
            public string mapDisplayName;

            public MapData(string name, MapDifficulty difficulty, PathModel[] paths, PathSpawnerModel spawner, Il2CppReferenceArray<AreaModel> areas, string mapMusic, string mapDisplayName)
            {
                this.name = name;
                this.difficulty = difficulty;
                this.paths = paths;
                this.spawner = spawner;
                this.areas = areas;
                this.mapMusic = mapMusic;
                this.mapDisplayName = mapDisplayName;
            }
        }
        static MapData[] mapList = new MapData[]
        {
            new MapData("3TimesAround", MapDifficulty.Beginner, Maps._3TimesAround.pathmodel(), Maps._3TimesAround.spawner(), Maps._3TimesAround.areas(), "MusicBTD5JazzA", "3 Times Around"),
            new MapData("SpaceTruckin", MapDifficulty.Beginner, Maps.SpaceTruckin.pathmodel(), Maps.SpaceTruckin.spawner(), Maps.SpaceTruckin.areas(), "MusicBTD5JazzA", "Space Truckin'"),
            new MapData("BloonOfClubs", MapDifficulty.Intermediate, Maps.BloonOfClubs.pathmodel(), Maps.BloonOfClubs.spawner(), Maps.BloonOfClubs.areas(), "MusicBTD5JazzA", "Bloon Of Clubs"),
            new MapData("BattleSands", MapDifficulty.Intermediate, Maps.BattleSands.pathmodel(), Maps.BattleSands.spawner(), Maps.BattleSands.areas(), "MusicDarkA", "Battle Sands"),
            new MapData("LightningScar", MapDifficulty.Advanced, Maps.LightningScar.pathmodel(), Maps.LightningScar.spawner(), Maps.LightningScar.areas(), "MusicBTD5JazzA", "Lightning Scar"),
            new MapData("MonkeysInSpace", MapDifficulty.Advanced, Maps.MonkeysInSpace.pathmodel(), Maps.MonkeysInSpace.spawner(), Maps.MonkeysInSpace.areas(), "MusicDarkA", "Monkeys In Space"),
            new MapData("BloontoniumLab", MapDifficulty.Expert, Maps.BloontoniumLab.pathmodel(), Maps.BloontoniumLab.spawner(), Maps.BloontoniumLab.areas(), "MusicBTD5JazzA", "Bloontonium Lab"),
            new MapData("MainStreet", MapDifficulty.Expert, Maps.MainStreet.pathmodel(), Maps.MainStreet.spawner(), Maps.MainStreet.areas(), "MusicBTD5JazzA", "Main Street"),
            new MapData("TarPits", MapDifficulty.Expert, Maps.TarPits.pathmodel(), Maps.TarPits.spawner(), Maps.TarPits.areas(), "MusicBTD5JazzA", "Tar Pits"),
            new MapData("BloonsTD1", MapDifficulty.Beginner, Maps.BTD1.pathmodel(), Maps.BTD1.spawner(), Maps.BTD1.areas(), "MusicDarkA", "Bloons TD 1"), //Credits to K1d_5h31d0n for this map texture
            new MapData("OceanRoad", MapDifficulty.Beginner, Maps.OceanRoad.pathmodel(), Maps.OceanRoad.spawner(), Maps.OceanRoad.areas(), "MusicDarkA", "Ocean Road"),
            new MapData("HighTech", MapDifficulty.Expert, Maps.HighTech.pathmodel(), Maps.HighTech.spawner(), Maps.HighTech.areas(), "MusicDarkA", "High Tech"), //Credits to K1d_5h31d0n for this map texture
            new MapData("BloonDunes", MapDifficulty.Advanced, Maps.BloonDunes.pathmodel(), Maps.BloonDunes.spawner(), Maps.BloonDunes.areas(), "MusicDarkA", "Bloon Dunes"), //Credits to K1d_5h31d0n for this map texture
            new MapData("Brickout", MapDifficulty.Advanced, Maps.BrickoutData.pathmodel(), Maps.BrickoutData.spawner(), Maps.BrickoutData.areas(), "MusicDarkA", "Brickout"),
            new MapData("PoolTable", MapDifficulty.Intermediate, Maps.PoolTable.pathmodel(), Maps.PoolTable.spawner(), Maps.PoolTable.areas(), "MusicDarkA", "Pool Table"),
            new MapData("ConcreteAlley", MapDifficulty.Intermediate, Maps.ConcreteAlley.pathmodel(), Maps.ConcreteAlley.spawner(), Maps.ConcreteAlley.areas(), "MusicDarkA", "Concrete Alley"),
            new MapData("Riverside", MapDifficulty.Intermediate, Maps.Riverside.pathmodel(), Maps.Riverside.spawner(), Maps.Riverside.areas(), "MusicDarkA", "Riverside"),
            new MapData("Maze", MapDifficulty.Beginner, Maps.Maze.pathmodel(), Maps.Maze.spawner(), Maps.Maze.areas(), "MusicBTD5JazzA", "Maze"),
        };
        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                foreach(var mapdata in mapList)
                {
                    GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.Add(new MapDetails
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
                    if(!LocalizationManager.instance.textTable.ContainsKey(mapdata.name))
                    {
                        LocalizationManager.instance.textTable.Add(mapdata.name, mapdata.mapDisplayName);
                    }
                }
            }
        }



        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if(Input.GetKeyDown(KeyCode.F9))
                {
                    foreach(var mapData in mapList)
                    {
                        Game.instance.GetBtd6Player().UnlockMap(mapData.name);
                    }
                }
            }
        }


        [HarmonyPatch(typeof(MapLoader), nameof(MapLoader.Load))]
        public class LoadMap
        {
            [HarmonyPrefix]
            internal static bool Fix(ref MapLoader __instance, ref string map, ref CoopDivision coopDivisionType, ref Il2CppSystem.Action<MapModel> loadedCallback)
            {
                LastMap = map;
                if(isCustom(LastMap))
                {
                    map = "MuddyPuddles";
                }
                return true;
            }
        }
        [HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        public class InitMap_Patch
        {

            [HarmonyPrefix]
            internal static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {


                if (!isCustom(LastMap)) return true;
                //To make custom maps make sure the map is 1652x1064
                MapData mapdata = mapList.Where(x => x.name == LastMap).First();
                Texture2D tex = ModContent.GetTexture<Main>(mapdata.name);
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
                ImageConversion.LoadImage(tex, filedata);
                var ob2 = GameObject.Find("MuddyPuddlesTerrain");
                ob2.GetComponent<Renderer>().material.mainTexture = tex;
                foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (ob.name.Contains("Candy") || ob.name.Contains("Gift") || ob.name.Contains("Snow") || ob.name.Contains("Ripples") || ob.name.Contains("Grass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower") || ob.name.Contains("Tree") || ob.name.Contains("Rock") || ob.name.Contains("Shadow") || ob.name.Contains("WaterSplashes"))// || ob.name.Contains("Body")   || ob.name.Contains("Ouch") || ob.name.Contains("Statue")|| ob.name.Contains("Chute")  || ob.name.Contains("Jump") || ob.name.Contains("Timer") || ob.name.Contains("Wheel") || ob.name.Contains("Body") || ob.name.Contains("Axle") || ob.name.Contains("Leg") || ob.name.Contains("Clock") ||
                        if (ob.name != "MuddyPuddlesTerrain")
                            ob.transform.position = new Vector3(1000, 1000, 1000);
                }

                map.areas = mapdata.areas;
                map.spawner = mapdata.spawner;
                map.paths = mapdata.paths;

                if (GameObject.Find("Rain"))
                    GameObject.Find("Rain").active = false;
                map.name = mapdata.name;
                map.mapName = mapdata.name;
                
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




    }

}