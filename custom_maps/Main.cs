using MelonLoader;
using Harmony;
using NKHook6.Api;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using NKHook6;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
using Assets.Scripts.Unity.UI_New.Main;
using NKHook6.Api.Events;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using static NKHook6.Api.Events._Towers.TowerEvents;
using Assets.Scripts.Simulation.Towers;

using static NKHook6.Api.Events._Weapons.WeaponEvents;
using Assets.Scripts.Utils;

using static NKHook6.Api.Events._TimeManager.TimeManagerEvents;
//using Il2CppSystem.Collections;
using NKHook6.Api.Events._Bloons;
using NKHook6.Api.Events._Weapons;
using Assets.Scripts.Unity.UI_New.Popups;
using System.Reflection;
using Assets.Scripts.Models;
using System.Collections.Generic;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.GenericBehaviors;
using System;
using System.Linq;
using Assets.Scripts.Models.ServerEvents;
using Assets.Scripts.Data.Cosmetics.Pets;
using Assets.Main.Scenes;
using UnhollowerBaseLib;

using Assets.Scripts.Models.Rounds;
using Assets.Scripts.Models.Store;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Map;
using UnityEngine;
using System.IO;
using UnhollowerRuntimeLib;
using Assets.Scripts.Unity.Map;
using Assets.Scripts.Models.Map.Spawners;
using Assets.Scripts.Unity.UI_New;
using Assets.Scripts.Data.MapSets;
using Assets.Scripts.Unity.Player;
using Assets.Scripts.Unity.UI_New.Main.ModeSelect;
using Assets.Scripts.Unity.UI_New.Main.MapSelect;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using NKHook6.Api.Towers;

namespace custom_maps
{
    public class Main : MelonMod
    {


        public static System.Random r = new System.Random();
        public static bool writingPoint = false;
        public static bool writingArea = false;
        public static int index = 0;
        public static int type = 0;
        public static bool mapeditor = false;
        //public static GameObject cube;
        public static string lastMap = "";
        //        public static string[] listOfMaps = new string[]
        //{
        //                    "tar pits",
        //                    "bloontoniumcore",
        //                    "toxic waste",
        //                    "slons",
        //                    "btd6irl",
        //                    "truetrueexpert",
        //                    "epiloge",
        //                    "brickout",
        //                    "grid",
        //                    "lyne",
        //                    "heartgate",
        //};

        static MapData[] listOfMaps = new MapData[]
        {
            new MapData("tar pits","https://i.imgur.com/gMjFiHW.png",MapDifficulty.Expert,TarPitsData.pathmodel(),TarPitsData.spawner(),TarPitsData.areas()),
            new MapData("bloontoniumcore","https://i.imgur.com/kOUp2zx.png",MapDifficulty.Expert,BloontoniumcoreData.pathmodel(),BloontoniumcoreData.spawner(),BloontoniumcoreData.areas()),
            new MapData("toxic waste","https://i.imgur.com/bCe6jMr.png",MapDifficulty.Expert,ToxicWasteData.pathmodel(),ToxicWasteData.spawner(),ToxicWasteData.areas()),
            new MapData("slons","https://i.imgur.com/RKiVthA.png",MapDifficulty.Expert,SlonsData.pathmodel(),SlonsData.spawner(),SlonsData.areas()),
            new MapData("btd6irl","https://i.imgur.com/dBHHhpK.png",MapDifficulty.Expert,btd6irlData.pathmodel(),btd6irlData.spawner(),btd6irlData.areas()),
            new MapData("truetrueexpert","https://i.imgur.com/e3qETCm.png",MapDifficulty.Expert,TrueTrueExpertData.pathmodel(),TrueTrueExpertData.spawner(),TrueTrueExpertData.areas()),
            new MapData("epiloge","https://i.imgur.com/atZk4U9.png",MapDifficulty.Expert,EpilogeData.pathmodel(),EpilogeData.spawner(),EpilogeData.areas()),
            new MapData("brickout","https://i.imgur.com/9Rp7eee.png",MapDifficulty.Intermediate,BrickoutData.pathmodel(),BrickoutData.spawner(),BrickoutData.areas()),
            new MapData("grid","https://i.imgur.com/EHrWM6u.png",MapDifficulty.Expert,GridData.pathmodel(),GridData.spawner(),GridData.areas()),
            new MapData("lyne","https://i.imgur.com/ZlL3DqE.png",MapDifficulty.Advanced,LyneData.pathmodel(),LyneData.spawner(),LyneData.areas()),
            new MapData("heartgate","https://i.imgur.com/94ZDQzd.png",MapDifficulty.Expert,HeartGateData.pathmodel(),HeartGateData.spawner(),HeartGateData.areas()),
            new MapData("sprinttrack","https://imgur.com/Wq4LqUV.png",MapDifficulty.Beginner,SprintTrackData.pathmodel(),SprintTrackData.spawner(),SprintTrackData.areas()),
            new MapData("checkers","https://imgur.com/PM6Fgv5.png",MapDifficulty.Beginner,CheckersData.pathmodel(),CheckersData.spawner(),CheckersData.areas()),
            new MapData("castle","https://i.imgur.com/cFhLGNa.png",MapDifficulty.Intermediate,CastleData.pathmodel(),CastleData.spawner(),CastleData.areas()),
            new MapData("BTD1","https://i.imgur.com/uqbcEV5.png",MapDifficulty.Beginner,BTD1Data.pathmodel(),BTD1Data.spawner(),BTD1Data.areas()),
            new MapData("crossover","https://i.imgur.com/03yafTA.png",MapDifficulty.Expert,CrossoverData.pathmodel(),CrossoverData.spawner(),CrossoverData.areas()),
            new MapData("cannal","https://i.imgur.com/j43e73Q.png",MapDifficulty.Expert,CannalData.pathmodel(),CannalData.spawner(),CannalData.areas()),
            new MapData("hairs","https://i.imgur.com/Mro0GIR.png",MapDifficulty.Expert,HairsData.pathmodel(),HairsData.spawner(),HairsData.areas()),
            new MapData("flooded bazaar","https://i.imgur.com/Wq0IWwk.jpg",MapDifficulty.Expert,FloodedBazaarData.pathmodel(),FloodedBazaarData.spawner(),FloodedBazaarData.areas()),
            new MapData("blooncano","https://i.imgur.com/sYCisVt.png",MapDifficulty.Expert,BlooncanoData.pathmodel(),BlooncanoData.spawner(),BlooncanoData.areas()),
            new MapData("flower","https://i.imgur.com/Hc1ApO1.png",MapDifficulty.Expert,FlowerData.pathmodel(),FlowerData.spawner(),FlowerData.areas()),
        }; 

        class MapData
        {
            public string name;
            public string url;
            public MapDifficulty difficulty;
            public PathModel[] paths;
            public PathSpawnerModel spawner;
            public Il2CppReferenceArray<AreaModel> areas;

            public MapData(string name, string url, MapDifficulty difficulty, PathModel[] paths, PathSpawnerModel spawner, Il2CppReferenceArray<AreaModel> areas)
            {
                this.name = name;
                this.url = url;
                this.difficulty = difficulty;
                this.paths = paths;
                this.spawner = spawner;
                this.areas = areas;
            }
        }



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            NKHook6.Logger.Log("custom_maps loaded");

        }


        [HarmonyPatch(typeof(UI), "Awake")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                Console.WriteLine("loading custom maps... this will take a while if it's the first time you use the mod");
                string guid;
                foreach (var item in listOfMaps)
                {
                    SpriteRegister.RegisterSpriteFromURL(@"Mods\Maps\" + item.name + ".png", item.url, default, out guid);
                    UI.instance.mapSet.Maps.items = UI.instance.mapSet.Maps.items.Add(new MapDetails
                    {
                        id = item.name,
                        isAvailable = true,
                        difficulty = item.difficulty,
                        coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        unlockDifficulty = MapDifficulty.Beginner,
                        mapMusic = "MusicDarkA",
                        mapSprite = new SpriteReference
                        {
                            guidRef = guid
                        }
                    }).ToArray<MapDetails>();
                }





            }
        }


        [HarmonyPatch(typeof(MapButton), "ShowMedal")]
        public class ShowMedal_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(MapButton __instance, Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode)
            {
                //Console.WriteLine("ShowMedal");
                //Console.WriteLine(player == null);
                //Console.WriteLine(player.debugUnlockAllModes = true);
                player.debugUnlockAllModes = true;
                //player.CompleteMap("lyne");
                //player.CompleteMap("heartgate");
                //player.MarkSeenMapUnlock("lyne");
                //player.MarkSeenMapUnlock("lyne");
                //player.MarkSeenMapUnlock("heartgate");
                foreach (var item in UI.instance.mapSet.Maps.items)
                {
                    player.MarkSeenMapUnlock(item.id);
                }
                //player.kno
                //Console.WriteLine(mapId);
                //Console.WriteLine(difficulty);
                //Console.WriteLine(mode);
                return true;
            }
        }

        static bool isCustom(string map)
        {
            return listOfMaps.Where(x => x.name == map).Count() > 0;
        }

        [HarmonyPatch(typeof(MapLoader), "Load")]
        public class MapLoad_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(MapLoader __instance, ref string map, Il2CppSystem.Action<MapModel> loadedCallback)
            {
                lastMap = map;
                //Console.WriteLine(lastMap);
                //Console.WriteLine(listOfMaps.Where(x => x.name == lastMap).Count());
                if (isCustom(lastMap))
                {
                    map = "MuddyPuddles";
                }


                return true;
            }
        }


        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {

                }


            }
        }



        [HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        public class InitMap_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {


                if (!isCustom(lastMap)) return true;


                Texture2D tex = null;
                string filePath = @"Mods\Maps\" + lastMap + ".png";
                byte[] fileData = File.ReadAllBytes(filePath);
                fileData = Resize(fileData, 1652, 1064);

                if (File.Exists(filePath))
                {
                    //fileData = File.ReadAllBytes(filePath);
                    //float divx = 2;
                    //float divy = 1.21f;
                    //int marginx = 190;
                    //int marginy = 430;
                    float divx = 2;
                    float divy = 1.21f;
                    int marginx = 450;
                    int marginy = 890;

                    Bitmap old = new Bitmap(Image.FromStream(new MemoryStream(fileData)));//new Bitmap(filePath);
                    Bitmap newImage = new Bitmap(old.Width + marginx, old.Height + marginy);
                    //var paddingColor = new System.Drawing.Color(255, 255, 255);
                    using (var graphics = System.Drawing.Graphics.FromImage(newImage))
                    {
                        //graphics.Clear(paddingColor);
                        int x = (int)((newImage.Width - old.Width) / divx);
                        int y = (int)((newImage.Height - old.Height) / divy);
                        graphics.DrawImage(old, x, y);
                        using (MemoryStream ms = new MemoryStream())
                        {
                            newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            fileData = ms.ToArray();
                        }
                    }


                    tex = new Texture2D(2, 2);
                    ImageConversion.LoadImage(tex, fileData);
                }
                var ob2 = GameObject.Find("MuddyPuddlesTerrain");
                ob2.GetComponent<Renderer>().material.mainTexture = tex;
                //ob2.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, 0);
                //ob2.GetComponent<Renderer>().material.mainTextureScale = new Vector2(1, 1);
                foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (ob.name.Contains("Candy") || ob.name.Contains("Gift") || ob.name.Contains("Snow") || ob.name.Contains("Ripples") || ob.name.Contains("Grass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower") || ob.name.Contains("Tree") || ob.name.Contains("Rock") || ob.name.Contains("Shadow") || ob.name.Contains("WaterSplashes"))// || ob.name.Contains("Body")   || ob.name.Contains("Ouch") || ob.name.Contains("Statue")|| ob.name.Contains("Chute")  || ob.name.Contains("Jump") || ob.name.Contains("Timer") || ob.name.Contains("Wheel") || ob.name.Contains("Body") || ob.name.Contains("Axle") || ob.name.Contains("Leg") || ob.name.Contains("Clock") ||
                        if (ob.name != "MuddyPuddlesTerrain")
                            ob.transform.position = new Vector3(1000, 1000, 1000);
                    //if (ob.name.Contains("Tree"))
                    //    GameObject.Destroy(ob);
                }


                //foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                //{
                //    if (ob.GetComponent<Renderer>())
                //    {
                //        if (ob.name.Contains("Candy") || ob.name.Contains("Statue") || ob.name.Contains("Body") || ob.name.Contains("Chute") || ob.name.Contains("Gift") || ob.name.Contains("Snow") || ob.name.Contains("Jump") || ob.name.Contains("Timer") || ob.name.Contains("Ripples") || ob.name.Contains("Clock") || ob.name.Contains("Grass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower") || ob.name.Contains("Tree") || ob.name.Contains("Rock") || ob.name.Contains("Wheel") || ob.name.Contains("Body") || ob.name.Contains("Axle") || ob.name.Contains("Shadow") || ob.name.Contains("Leg") || ob.name.Contains("WaterSplashes") || ob.name.Contains("Ouch"))
                //            ob.transform.position = new Vector3(1000, 1000, 1000);
                //        if (ob.name.Contains("Statue"))
                //            GameObject.Destroy(ob);
                //    }
                //}
                //cube.GetComponent<Renderer>().material = GameObject.Find("OuchTerrainGrateless").GetComponent<Renderer>().material;
                //cube.GetComponent<Renderer>().material.mainTexture = tex;
                MapData mapdata = listOfMaps.Where(x => x.name == lastMap).First();
                map.areas = mapdata.areas;
                map.spawner = mapdata.spawner;
                map.paths = mapdata.paths;

                if (GameObject.Find("Rain"))
                    GameObject.Find("Rain").active = false;
                return true;
            }

        }



        public static byte[] Resize(byte[] data, int width, int height)
        {
            using (var stream = new MemoryStream(data))
            {
                var image = Image.FromStream(stream);

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

        public static Bitmap ResizeImage(Image image, int width, int height)
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


















        //used only for epiloge
        [HarmonyPatch(typeof(TowerModel), "IsTowerPlaceableInAreaType")]
        public class IsTowerPlaceableInAreaType_Patch
        {

            [HarmonyPrefix]
            static bool Prefix(ref bool __result, AreaType areaType)
            {
                if (lastMap != "epiloge" && lastMap != "crossover") return true;
                __result = true;
                return false;
            }
        }



        [HarmonyPatch(typeof(Tower), "Initialise")]
        public class TowerInitialise_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix(Tower __instance, ref Model modelToUse)
            {
                if (lastMap != "epiloge") return true;
                var wep = modelToUse.Cast<TowerModel>();
                var builder = new TowerBuilder(wep);
                builder.SetFootprint(new FootprintModel("", true, true, true));
                modelToUse = builder.build();
                return true;
            }
        }

        [HarmonyPatch(typeof(Tower), "UpdatedModel")]
        public class UpdatedModel_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix(Tower __instance, ref Model modelToUse)
            {
                if (lastMap != "epiloge") return true;
                var wep = modelToUse.Cast<TowerModel>();
                var builder = new TowerBuilder(wep);
                builder.SetFootprint(new FootprintModel("", true, true, true));
                modelToUse = builder.build();
                return true;
            }
        }




        //public static List<AreaModel> getTrackAreas(List<PointInfo> pointsList,float margin)
        //{
        //    List<AreaModel> newareas = new List<AreaModel>();

        //    var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
        //    area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, -115.2764f));
        //    area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.1904f, -114.1706f));
        //    area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6712f, 114.1708f));
        //    area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, 114.7236f));
        //    newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 0, (AreaType)2));

        //    var points = pointsList.ToArray();
        //    for (var j = 0; j < points.Length - 1; j++)
        //    {
        //        var point1 = pointsList[j];
        //        var point2 = pointsList[j + 1];
        //        var area = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
        //        area.Add(new Assets.Scripts.Simulation.SMath.Vector2(point1.point.x + margin, point1.point.y));
        //        area.Add(new Assets.Scripts.Simulation.SMath.Vector2(point1.point.x - margin, point1.point.y));
        //        area.Add(new Assets.Scripts.Simulation.SMath.Vector2(point2.point.x + margin, point2.point.y));
        //        area.Add(new Assets.Scripts.Simulation.SMath.Vector2(point2.point.x - margin, point2.point.y));
        //        newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area), 0, (AreaType)2));


        //    }
        //    return newareas;
        //}




    }
}