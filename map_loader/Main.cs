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
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Data;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Unity.Map;
using Il2CppAssets.Scripts.Unity.Bridge;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Net;
using Il2CppSystem.Collections.Generic;
using Il2CppAssets.Scripts.Utils;
using BTD_Mod_Helper.Api.ModOptions;
using Il2CppSystem.Reflection;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using Il2CppAssets.Scripts.Unity.Player;
using Il2CppNinjaKiwi.Common;
//using Harmony;




[assembly: MelonInfo(typeof(map_loader.Main), map_loader.ModHelperData.Name, map_loader.ModHelperData.Version, map_loader.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace map_loader
{
    public class Main : BloonsMod
    {
        //public override string MelonInfoCsURL => "https://raw.githubusercontent.com/Timotheeee/btd6_mods/master/custom_maps_v2/Main.cs";  
        //public override string LatestURL => "https://github.com/Timotheeee/btd6_mods/blob/master/custom_maps_v2/custommaps.dll?raw=true";
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
                //return;
                System.Collections.Generic.List<MapData> maplist2 = new System.Collections.Generic.List<MapData>();

                foreach (string map in Directory.GetDirectories("Mods/map_editor/"))
                {
                    //System.Console.WriteLine(map);
                }

                foreach (string map in Directory.GetDirectories("Mods/map_editor/"))
                {
                    string name = new DirectoryInfo(map).Name;
                    System.Console.WriteLine("loading custom map from the map editor mod: " + name);
                    string[] info = File.ReadAllLines(map + "/info.txt");
                    //System.Console.WriteLine("info len: " + info.Length);
                    //System.Console.WriteLine("info : " + (info.Length == 3 ? info[1] : info[0]));
                    MapDifficulty dif = (MapDifficulty)int.Parse(info.Length == 3 ? info[1] : info[0]);
                    string music = info.Length == 3 ? info[2] : info[1];
                    string guid = map + "/image.png";
                    Game.instance.CreateSpriteReference(guid);
                    //Game.instance.GetSpriteRegister().RegisterSpriteFromImage(map + "/image.png", default, out string guid);


                    //System.Console.WriteLine("0");
                    //paths
                    PathModel[] paths = DefaultMap.pathmodel();
                    //System.Console.WriteLine("1");
                    PathSpawnerModel spawner = DefaultMap.spawner();
                    //System.Console.WriteLine("2");
                    string[] pathsData = null;
                    //System.Console.WriteLine("3");
                    try { pathsData = File.ReadAllLines(map + "/paths.txt"); } catch { }
                    //System.Console.WriteLine("4");


                    //if the paths file exists, process it
                    if (pathsData != null)
                    {
                        System.Console.WriteLine("processing paths");
                        //remove empty paths
                        pathsData = string.Join(":", pathsData).Replace("next:next", "next").Split(':');

                        int numOfPaths = string.Join("", pathsData).Split('n').Count() - 1;
                        //System.Console.WriteLine("numOfPaths: " + numOfPaths);

                        List<string> a = new List<string>();
                        List<PathModel> p = new List<PathModel>();
                        for (int i = 0; i < numOfPaths; i++)
                        {
                            a.Add("track" + i);
                            p.Add(new PathModel("track" + i, null, true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null));
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
                            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(float.Parse(coords[0]), float.Parse(coords[1])), bloonSpeedMultiplier = 1 });
                            //list.Add(new PointInfo() { point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(float.Parse(coords[0]), float.Parse(coords[1])), bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0,bloonSpeedMultiplier=1 });
                        }
                        //paths[0].points = (Il2CppReferenceArray<PointInfo>)list.ToArray();


                        spawner = new PathSpawnerModel("", sm, sm);
                    }
                    //System.Console.WriteLine("5");
                    //MelonLogger.Msg("setting up areas");
                    //areas
                    Il2CppReferenceArray<AreaModel> areas = DefaultMap.areas();
                    //System.Console.WriteLine("6");
                    string[] areasData = null;
                    try { areasData = File.ReadAllLines(map + "/areas.txt"); } catch { }
                    //System.Console.WriteLine("7");
                    if (areasData != null)
                    {
                        System.Console.WriteLine("processing areas");
                        List<AreaModel> newareas = new List<AreaModel>();

                        int lineIndex = 0;
                        foreach (var line in areasData)
                        {
                            if (line == "") continue;
                            //MelonLogger.Msg("line: " + line);

                            if (!line.Contains(","))
                            {
                                //if the line contains a comma that means it's a new area, but we only add it if it isn't empty and if it isn't at the end of the file.
                                //System.Console.WriteLine("areasData[lineIndex] " + areasData[lineIndex]);
                                //System.Console.WriteLine("areasData[lineIndex + 1] " + areasData[lineIndex + 1]);
                                if (lineIndex != areasData.Length - 1 && areasData[lineIndex + 1].Contains(","))
                                {
                                    AreaType type = (AreaType)int.Parse(line.Split(' ')[0]);
                                    bool blocker = line.Split(' ')[1] == "True";
                                    int height = blocker ? 100 : 0;
                                    newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>()), Empty(), height, type) { isBlocker = blocker });
                                }

                            }
                            else
                            {
                                //add the coords
                                var coords = line.Split(',');
                                var stuffToAdd = new Il2CppAssets.Scripts.Simulation.SMath.Vector2(float.Parse(coords[0]), float.Parse(coords[1]));

                                var oldpoints = newareas.Last().polygon.points;
                                Il2CppStructArray<Il2CppAssets.Scripts.Simulation.SMath.Vector2> newpoints = new Il2CppStructArray<Il2CppAssets.Scripts.Simulation.SMath.Vector2>(oldpoints.Count + 1);

                                for (int i = 0; i < oldpoints.Count; i++)
                                {
                                    newpoints[i] = oldpoints[i];
                                }
                                newpoints[oldpoints.Count] = stuffToAdd;

                                newareas.Last().polygon.points = newpoints;

                                //newareas.Last().polygon.points.Add();
                                //newareas.Last().polygon.points.
                                //System.Console.WriteLine("newareas size: " + newareas.Last().polygon.points.Count);
                            }
                            lineIndex++;
                        }


                        areas = (Il2CppReferenceArray<AreaModel>)newareas.ToArray();
                    }
                    //System.Console.WriteLine("8");

                    //new System.String(name.Where(System.Char.IsLetter).ToArray())
                    maplist2.Add(new MapData(name, dif, paths, spawner, areas, music, name, guid));
                    //System.Console.WriteLine("9");

                }
                //System.Console.WriteLine("10");
                mapList = maplist2.ToArray();
                //System.Console.WriteLine("11");

                //MelonLogger.Msg("setting up map difficulty");
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
                        mapSprite = new SpriteReference() { guidRef = mapdata.guid },//ModContent.GetSpriteReference<Main>(mapdata.name),//fix this
                        coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                    }).ToArray();

                    if (!LocalizationManager.Instance.textTable.ContainsKey(mapdata.name))
                    {
                        LocalizationManager.Instance.textTable.Add(mapdata.name, mapdata.mapDisplayName);
                    }
                }
            }
        }


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

        public static Il2CppReferenceArray<Il2CppAssets.Scripts.Simulation.SMath.Polygon> Empty()
        {
            //var ar = new Il2CppAssets.Scripts.Simulation.SMath.Polygon(new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>());
            return new Il2CppReferenceArray<Il2CppAssets.Scripts.Simulation.SMath.Polygon>(0);
        }


        [HarmonyPatch(typeof(MapLoader), nameof(MapLoader.LoadScene))]
        public class LoadMap
        {
            [HarmonyPrefix]
            internal static bool Fix(ref MapLoader __instance)
            {
                //lastmap = __instance.currentMapName;
                //if (isCustom(lastmap))
                //{
                //    __instance.currentMapName = "MuddyPuddles";
                //}
                //System.Console.WriteLine("map loader prefix");
                return true;
            }
            [HarmonyPostfix]
            internal static void Fix2(ref MapLoader __instance)
            {
                lastmap = __instance.currentMapName;
                if (isCustom(lastmap))
                {
                    __instance.currentMapName = "MuddyPuddles";
                }
                //__instance.currentMapName = lastmap;
                //System.Console.WriteLine("map loader postfix");
            }
        }



        [HarmonyPatch(typeof(UnityToSimulation), nameof(UnityToSimulation.InitMap))]
        internal class InitMap_Patch
        {
            [HarmonyPrefix]
            internal static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {
                System.Console.WriteLine("clearing old map visuals");

                try
                {
                    GameObject.Destroy(GameObject.Find("mapcube"));
                }
                catch
                {
                    System.Console.WriteLine("no old visuals found");
                }

                if (!isCustom(lastmap)) return true;
                MapData mapdata = mapList.Where(x => x.name == lastmap).First();
                var ob2 = GameObject.Find("MuddyPuddlesTerrain");
                foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (ob.name.Contains("Festive") || ob.name.Contains("Rocket") || ob.name.Contains("Firework") || ob.name.Contains("Box") || ob.name.Contains("Candy") || ob.name.Contains("Gift") || ob.name.Contains("Snow") || ob.name.Contains("Ripples") || ob.name.Contains("Grass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower") || ob.name.Contains("Tree") || ob.name.Contains("Rock") || ob.name.Contains("Shadow") || ob.name.Contains("WaterSplashes"))
                    {
                        if (ob.transform.position.x == 1000 && ob.transform.position.y == 1000 && ob.transform.position.z == 1000)
                        {
                            //MelonLogger.Msg("already processed");
                            return true;
                        }
                    }
                }


                Texture2D tex = new Texture2D(2, 2);
                string filePath = "Mods/map_editor/" + lastmap + "/image.png";
                byte[] filedata = File.ReadAllBytes(filePath);
                ImageConversion.LoadImage(tex, filedata);

                var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.name = "mapcube";
                cube.transform.position = new Vector3(0, -0.4901f, 0);
                cube.transform.localScale = new Vector3(-300, 1f, -235);
                cube.GetComponent<Renderer>().material = ob2.GetComponent<Renderer>().material;
                cube.GetComponent<Renderer>().material.mainTexture = tex;
                //filedata = Resize(filedata, 1652, 1064);
                //float divx = 2;
                //float divy = 1.21f;
                //int marginx = 450;
                //int marginy = 890;
                //Bitmap old = new Bitmap(System.Drawing.Image.FromStream(new MemoryStream(filedata)));//new Bitmap(filePath);
                //Bitmap newImage = new Bitmap(old.Width + marginx, old.Height + marginy);
                //using (var graphics = System.Drawing.Graphics.FromImage(newImage))
                //{
                //    //graphics.Clear(paddingColor);
                //    int x = (int)((newImage.Width - old.Width) / divx);
                //    int y = (int)((newImage.Height - old.Height) / divy);
                //    graphics.DrawImage(old, x, y);
                //    using (MemoryStream ms = new MemoryStream())
                //    {
                //        newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                //        filedata = ms.ToArray();
                //    }
                //}
                //Texture2D tex2 = new Texture2D(tex.width, tex.height);
                //ImageConversion.LoadImage(tex2, filedata);
                //ob2.GetComponent<Renderer>().material.mainTexture = tex2;


                foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (ob.name.Contains("Festive") || ob.name.Contains("Rocket") || ob.name.Contains("Firework") || ob.name.Contains("Box") || ob.name.Contains("Candy") || ob.name.Contains("Gift") || ob.name.Contains("Snow") || ob.name.Contains("Ripples") || ob.name.Contains("Grass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower") || ob.name.Contains("Tree") || ob.name.Contains("Rock") || ob.name.Contains("Shadow") || ob.name.Contains("WaterSplashes"))// || ob.name.Contains("Body")   || ob.name.Contains("Ouch") || ob.name.Contains("Statue")|| ob.name.Contains("Chute")  || ob.name.Contains("Jump") || ob.name.Contains("Timer") || ob.name.Contains("Wheel") || ob.name.Contains("Body") || ob.name.Contains("Axle") || ob.name.Contains("Leg") || ob.name.Contains("Clock") ||
                        if (ob.name != "MuddyPuddlesTerrain")
                            ob.transform.position = new Vector3(1000, 1000, 1000);
                }

                map.areas = mapdata.areas;
                map.spawner = mapdata.spawner;
                map.paths = mapdata.paths;
                //map.paths[0] = mapdata.paths[0];

                if (GameObject.Find("Rain"))
                    GameObject.Find("Rain").active = false;
                map.name = mapdata.name;
                map.mapName = mapdata.name;
                //System.Console.WriteLine("InitMap_Patch, map.paths[0].points[0].point.x: " + map.paths[0].points[0].point.x);
                //System.Console.WriteLine("InitMap_Patch, map.paths[0].points[1].point.x: " + map.paths[0].points[1].point.x);
                //System.Console.WriteLine("InitMap_Patch, map.paths[0].points[1].bloonSpeedMultiplier: " + map.paths[0].points[1].bloonSpeedMultiplier);
                //System.Console.WriteLine("InitMap_Patch, mapdata.spawner.name: " + mapdata.spawner.name);
                //System.Console.WriteLine("InitMap_Patch, mapdata.spawner.forwardSplitter.paths[0]: " + mapdata.spawner.forwardSplitter.paths[0]);
                //System.Console.WriteLine("InitMap_Patch, mapdata.paths[0].name: " + mapdata.paths[0].name);
                return true;
            }

        }
        //public static byte[] Resize(byte[] data, int width, int height)
        //{
        //    using (var stream = new MemoryStream(data))
        //    {
        //        var image = System.Drawing.Image.FromStream(stream);

        //        //var height = (width * image.Height) / image.Width;
        //        //var thumbnail = image.GetThumbnailImage(width, height, null, IntPtr.Zero);
        //        Bitmap b = ResizeImage(image, width, height);//new Bitmap(image, 1652, 1064);
        //        //b.Save("test.png", ImageFormat.Png);

        //        using (var thumbnailStream = new MemoryStream())
        //        {
        //            b.Save(thumbnailStream, ImageFormat.Png);
        //            return thumbnailStream.ToArray();
        //        }
        //    }
        //}
        //public static Bitmap ResizeImage(System.Drawing.Image image, int width, int height)
        //{
        //    var destRect = new Rectangle(0, 0, width, height);
        //    var destImage = new Bitmap(width, height);

        //    destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        //    using (var graphics = System.Drawing.Graphics.FromImage(destImage))
        //    {
        //        graphics.CompositingMode = CompositingMode.SourceCopy;
        //        graphics.CompositingQuality = CompositingQuality.HighQuality;
        //        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        graphics.SmoothingMode = SmoothingMode.HighQuality;
        //        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        //        using (var wrapMode = new ImageAttributes())
        //        {
        //            wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
        //            graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
        //        }
        //    }

        //    return destImage;
        //}




    }

}