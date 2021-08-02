using MelonLoader;
using HarmonyLib;

using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Scripts.Unity;
using System.IO;
using Assets.Main.Scenes;
using UnityEngine;
using System.Linq;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Data.MapSets;
using Assets.Scripts.Models.Map.Spawners;
using Assets.Scripts.Models.Map;
using UnhollowerBaseLib;
using Assets.Scripts.Data;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper;
using Assets.Scripts.Unity.Map;
using Assets.Scripts.Unity.Bridge;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Net;
using Il2CppSystem.Collections.Generic;
using Assets.Scripts.Utils;
using BTD_Mod_Helper.Api.ModOptions;
using Il2CppSystem.Reflection;
using Assets.Scripts.Unity.UI_New.Main.MapSelect;
using Assets.Scripts.Unity.Player;
using NinjaKiwi.Common;
//using Harmony;

[assembly: MelonInfo(typeof(map_loader.Main), "map_loader", "1.0.0", "Timotheeee1")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace map_loader
{
    public class Main : BloonsMod
    {
        public override string MelonInfoCsURL => "https://raw.githubusercontent.com/Timotheeee/btd6_mods/master/custom_maps_v2/Main.cs";
        public override string LatestURL => "https://github.com/Timotheeee/btd6_mods/blob/master/custom_maps_v2/custommaps.dll?raw=true";
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            MelonLogger.Msg("map_loader loaded");
        }
        static string lastmap = null;
        public static System.Random r = new System.Random();
        static bool isCustom(string map)
        {
            return mapList.Where(x => x.name == map).Count() > 0;
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
            public string guid;


            public MapData(string name, MapDifficulty difficulty, PathModel[] paths, PathSpawnerModel spawner, Il2CppReferenceArray<AreaModel> areas, string mapMusic, string mapDisplayName, string guid)
            {
                this.name = name;
                this.difficulty = difficulty;
                this.paths = paths;
                this.spawner = spawner;
                this.areas = areas;
                this.mapMusic = mapMusic;
                this.mapDisplayName = mapDisplayName;
                this.guid = guid;

            }
        }
        static MapData[] mapList = new MapData[]
        {
            //new MapData("3TimesAround", MapDifficulty.Beginner, Maps._3TimesAround.pathmodel(), Maps._3TimesAround.spawner(), Maps._3TimesAround.areas(), "MusicBTD5JazzA", "3 Times Around", "BTD 5"),
        };

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                System.Collections.Generic.List<MapData> maplist2 = new System.Collections.Generic.List<MapData>();
                foreach (string map in Directory.GetDirectories("Mods/map_editor/"))
                {
                    string[] info = File.ReadAllLines(map + "/info.txt");
                    string name = info[0];
                    MapDifficulty dif = (MapDifficulty)int.Parse(info[1]);
                    string music = info[2];
                    Game.instance.GetSpriteRegister().RegisterSpriteFromImage(map + "/image.png", default, out string guid);

                    System.Console.WriteLine("loading custom map from the map editor mod: " + name);

                    //paths
                    PathModel[] paths = DefaultMap.pathmodel();
                    PathSpawnerModel spawner = DefaultMap.spawner();
                    string[] pathsData = null;
                    try { pathsData = File.ReadAllLines(map + "/paths.txt"); } catch { }
                    //if the paths file exists, process it
                    if (pathsData != null)
                    {
                        int numOfPaths = string.Join("", pathsData).Split('n').Count()-1;
                        //System.Console.WriteLine("numOfPaths: " + numOfPaths);

                        List<string> a = new List<string>();
                        List<PathModel> p = new List<PathModel>();
                        for (int i = 0; i < numOfPaths; i++)
                        {
                            a.Add("track" + i);
                            p.Add(new PathModel("track" + i, null, true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null));
                        }
                        SplitterModel sm = new SplitterModel("", (Il2CppStringArray)a.ToArray());
                        paths = p.ToArray();
                        //System.Console.WriteLine("set up models");

                        List<PointInfo> list = new List<PointInfo>();
                        int pathindex = 0;
                        foreach (var line in pathsData)
                        {
                            if (line == "") break;
                            if (line == "next")
                            {
                                paths[pathindex].points = (Il2CppReferenceArray<PointInfo>)list.ToArray();
                                pathindex++;
                                list = new List<PointInfo>();
                                continue;
                            }
                            var coords = line.Split(',');
                            list.Add(new PointInfo() { point = new Assets.Scripts.Simulation.SMath.Vector3(float.Parse(coords[0]), float.Parse(coords[1])), bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0 });
                        }
                        //paths[0].points = (Il2CppReferenceArray<PointInfo>)list.ToArray();


                        spawner = new PathSpawnerModel("", sm, sm);
                    }

                    //areas
                    Il2CppReferenceArray<AreaModel> areas = DefaultMap.areas();
                    string[] areasData = null;
                    try { areasData = File.ReadAllLines(map + "/areas.txt"); } catch { }
                    if (areasData != null)
                    {
                        List<AreaModel> newareas = new List<AreaModel>();

                        foreach (var line in areasData)
                        {
                            if (line == "") continue;

                            //if the line is just a number, that means it's the area type
                            if (!line.Contains(","))
                            {
                                newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>()), 0, (AreaType)int.Parse(line)));

                            }
                            else
                            {
                                //add the coords
                                var coords = line.Split(',');
                                newareas.Last().polygon.points.Add(new Assets.Scripts.Simulation.SMath.Vector2(float.Parse(coords[0]), float.Parse(coords[1])));

                            }

                        }


                        areas = (Il2CppReferenceArray<AreaModel>)newareas.ToArray();
                    }



                    maplist2.Add(new MapData(new System.String(name.Where(System.Char.IsLetter).ToArray()), dif, paths, spawner, areas, music, name, guid));

                }
                mapList = maplist2.ToArray();

                foreach (var mapdata in mapList)
                {

                    GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.AddTo(new MapDetails
                    {
                        id = mapdata.name,
                        isBrowserOnly = false,
                        isDebug = false,
                        difficulty = mapdata.difficulty,
                        unlockDifficulty = MapDifficulty.Beginner,
                        mapMusic = mapdata.mapMusic,
                        mapSprite = new SpriteReference(mapdata.guid),//ModContent.GetSpriteReference<Main>(mapdata.name),//fix this
                        coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                    }).ToArray();

                    if (!LocalizationManager.Instance.textTable.ContainsKey(mapdata.name))
                    {
                        LocalizationManager.Instance.textTable.Add(mapdata.name, mapdata.mapDisplayName);
                    }
                }
            }
        }


        //[HarmonyPatch(typeof(MapButton), "ShowMedal")]
        //public class ShowMedal_Patch2
        //{
        //    [HarmonyPrefix]
        //    public static bool Prefix(MapButton __instance, Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode)
        //    {


        //        foreach (var mapData in mapList)
        //        {
        //            player.UnlockMap(mapData.name);

        //        }

        //        return true;
        //    }
        //}

        //public override void OnUpdate()
        //{
        //    base.OnUpdate();

        //    bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
        //    if (inAGame)
        //    {
        //        if (Input.GetKeyDown(KeyCode.F9))
        //        {
        //            foreach (var mapData in mapList)
        //            {
        //                Game.instance.GetBtd6Player().UnlockMap(mapData.name);
        //                InGame.instance.Player.UnlockMap(mapData.name);
        //            }
        //        }
        //    }
        //}


        [HarmonyPatch(typeof(MapLoader), nameof(MapLoader.Load))]
        public class LoadMap
        {
            [HarmonyPrefix]
            internal static bool Fix(ref MapLoader __instance, ref string map, ref CoopDivision coopDivisionType, ref Il2CppSystem.Action<MapModel> loadedCallback)
            {
                lastmap = map;
                if (isCustom(lastmap))
                {
                    map = "MuddyPuddles";

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

                if (!isCustom(lastmap)) return true;
                MapData mapdata = mapList.Where(x => x.name == lastmap).First();


                //Texture2D tex = ModContent.GetTexture<Main>(mapdata.name);
                //byte[] filedata = null;
                //filedata = Resize(ImageConversion.EncodeToPNG(tex), 1652, 1064);
                Texture2D tex = new Texture2D(2, 2); ;
                string filePath = "Mods/map_editor/" + lastmap + "/image.png";
                byte[] filedata = File.ReadAllBytes(filePath);
                filedata = Resize(filedata, 1652, 1064);


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
                    if (ob.name.Contains("Festive") || ob.name.Contains("Rocket") || ob.name.Contains("Firework") || ob.name.Contains("Box") || ob.name.Contains("Candy") || ob.name.Contains("Gift") || ob.name.Contains("Snow") || ob.name.Contains("Ripples") || ob.name.Contains("Grass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower") || ob.name.Contains("Tree") || ob.name.Contains("Rock") || ob.name.Contains("Shadow") || ob.name.Contains("WaterSplashes"))// || ob.name.Contains("Body")   || ob.name.Contains("Ouch") || ob.name.Contains("Statue")|| ob.name.Contains("Chute")  || ob.name.Contains("Jump") || ob.name.Contains("Timer") || ob.name.Contains("Wheel") || ob.name.Contains("Body") || ob.name.Contains("Axle") || ob.name.Contains("Leg") || ob.name.Contains("Clock") ||
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