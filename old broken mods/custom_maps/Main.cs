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


using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using System.Reflection;
using Il2CppAssets.Scripts.Models;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using System;
using System.Linq;
using Il2CppAssets.Scripts.Models.ServerEvents;
using Il2CppAssets.Scripts.Data.Cosmetics.Pets;
using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Models.Store;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Map;
using UnityEngine;
using System.IO;

using Il2CppAssets.Scripts.Unity.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Unity.UI_New;
using Il2CppAssets.Scripts.Data.MapSets;
using Il2CppAssets.Scripts.Unity.Player;
using Il2CppAssets.Scripts.Unity.UI_New.Main.ModeSelect;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using Il2CppAssets.Scripts.Data;


[assembly: MelonInfo(typeof(custom_maps.Main), custom_maps.ModHelperData.Name, custom_maps.ModHelperData.Version, custom_maps.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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
            new MapData("oceanroad","https://i.imgur.com/W6Wrm9c.png",MapDifficulty.Beginner,OceanRoadData.pathmodel(),OceanRoadData.spawner(),OceanRoadData.areas()),
            new MapData("3 times around","https://i.imgur.com/uAayFC2.png",MapDifficulty.Beginner,ThreeTimesAround.pathmodel(),ThreeTimesAround.spawner(),ThreeTimesAround.areas()),
            new MapData("offside","https://i.imgur.com/4UI6hqo.png",MapDifficulty.Intermediate,OffsideData.pathmodel(),OffsideData.spawner(),OffsideData.areas()),
            new MapData("brick wall","https://i.imgur.com/dW6jlkn.png",MapDifficulty.Beginner,BrickWallData.pathmodel(),BrickWallData.spawner(),BrickWallData.areas()),
            new MapData("skull peak","https://i.imgur.com/2QCfyAq.png",MapDifficulty.Beginner,SkullPeakData.pathmodel(),SkullPeakData.spawner(),SkullPeakData.areas()),
            new MapData("the rink","https://i.imgur.com/1GvhDwo.png",MapDifficulty.Beginner,TheRinkData.pathmodel(),TheRinkData.spawner(),TheRinkData.areas()),
            new MapData("express shipping","https://i.imgur.com/sdtQ7v5.png",MapDifficulty.Beginner,ExpressShippingData.pathmodel(),ExpressShippingData.spawner(),ExpressShippingData.areas()),
            new MapData("long range","https://i.imgur.com/w3gq0CJ.png",MapDifficulty.Expert,LongRangeData.pathmodel(),LongRangeData.spawner(),LongRangeData.areas()),
            new MapData("milk and cookies","https://i.imgur.com/vKYxrBn.png",MapDifficulty.Beginner,MilkAndCookiesData.pathmodel(),MilkAndCookiesData.spawner(),MilkAndCookiesData.areas()),
            new MapData("snow monkey","https://i.imgur.com/hxCYxww.png",MapDifficulty.Beginner,SnowMonkeyData.pathmodel(),SnowMonkeyData.spawner(),SnowMonkeyData.areas()),
            new MapData("rink revenge","https://i.imgur.com/KDubNoU.png",MapDifficulty.Advanced,RinksRevengeData.pathmodel(),RinksRevengeData.spawner(),RinksRevengeData.areas()),
            new MapData("monkey lane","https://i.imgur.com/SCXivmK.png",MapDifficulty.Beginner,MonkeyLaneData.pathmodel(),MonkeyLaneData.spawner(),MonkeyLaneData.areas()),
            new MapData("minecraft desert","https://i.imgur.com/HASBIct.png",MapDifficulty.Intermediate,MinecraftDesertData.pathmodel(),MinecraftDesertData.spawner(),MinecraftDesertData.areas()),
            new MapData("battle park","https://i.imgur.com/wXvRXAq.png",MapDifficulty.Beginner,BattleParkData.pathmodel(),BattleParkData.spawner(),BattleParkData.areas()),
            new MapData("indoor pools","https://i.imgur.com/hpkUX28.png",MapDifficulty.Advanced,IndoorPoolsData.pathmodel(),IndoorPoolsData.spawner(),IndoorPoolsData.areas()),
            new MapData("maze","https://i.imgur.com/3xHlgRO.png",MapDifficulty.Beginner,MazeData.pathmodel(),MazeData.spawner(),MazeData.areas()),
            new MapData("pool table","https://i.imgur.com/2MuOnXW.png",MapDifficulty.Intermediate,PoolTableData.pathmodel(),PoolTableData.spawner(),PoolTableData.areas()),
            new MapData("patch","https://i.imgur.com/lj0etvX.png",MapDifficulty.Beginner,PatchData.pathmodel(),PatchData.spawner(),PatchData.areas()),
            new MapData("mondrian","https://i.imgur.com/kXa1ZNd.png",MapDifficulty.Intermediate,MondrianData.pathmodel(),MondrianData.spawner(),MondrianData.areas()),
            new MapData("battle sands","https://i.imgur.com/5egIufc.png",MapDifficulty.Intermediate,BattleSandsData.pathmodel(),BattleSandsData.spawner(),BattleSandsData.areas()),
            new MapData("bloon circles","https://i.imgur.com/V67KVM1.png",MapDifficulty.Beginner,BloonCirclesData.pathmodel(),BloonCirclesData.spawner(),BloonCirclesData.areas()),
            new MapData("Lightning Scar","https://i.imgur.com/JMYEfSN.png",MapDifficulty.Advanced,LightningScarData.pathmodel(),LightningScarData.spawner(),LightningScarData.areas()),
            new MapData("Concrete Alley","https://i.imgur.com/39irjLS.png",MapDifficulty.Beginner,ConcreteAlleyData.pathmodel(),ConcreteAlleyData.spawner(),ConcreteAlleyData.areas()),
            new MapData("PvZ Roof","https://i.imgur.com/KTJD05O.png",MapDifficulty.Intermediate,PvZRoofData.pathmodel(),PvZRoofData.spawner(),PvZRoofData.areas()),
            new MapData("amogus","https://i.imgur.com/HYgUwno.png",MapDifficulty.Expert,AmogusData.pathmodel(),AmogusData.spawner(),AmogusData.areas()),
        };
        class UnlockMaps
        {
            internal static readonly string[] mapnamesfinal = { "tar pits", "bloontoniumcore", "toxic waste", "slons", "btd6irl", "truetrueexpert", "epiloge", "brickout", "grid", "lyne", "heartgate", "sprinttrack", "checkers", "castle", "BTD1", "crossover", "cannal", "hairs", "flooded bazaar", "blooncano", "flower", "oceanroad", "3 times around", "offside", "brick wall", "skull peak", "the rink", "express shipping", "long range", "milk and cookies", "snow monkey", "rink revenge", "monkey lane", "minecraft desert", "battle park", "indoor pools", "maze", "pool table", "patch", "mondrian", "battle sands", "bloon circles", "Lightning Scar", "Concrete Alley", "PvZ Roof", "amogus" };
        }



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
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("custom_maps loaded");

        }


        /*[HarmonyPatch(typeof(Game), "Awake")]
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
                    Game.instance.mapSet.Maps.items = Game.instance.mapSet.Maps.items.Add(new MapDetails
                    {
                        id = item.name,
                        isDebug = false,
                        difficulty = item.difficulty,
                        coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                        unlockDifficulty = MapDifficulty.Beginner,
                        mapMusic = "MusicDarkA",
                        mapSprite = new SpriteReference(guid)
                    }).ToArray<MapDetails>();

                
                    


                    
                }





            }
        }*/


        

        [HarmonyPatch(typeof(Game), "Awake")]
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
            GameData._instance.mapSet.Maps.items = GameData._instance.mapSet.Maps.items.Add(new MapDetails
                    {
                id = item.name,
                isDebug = false,
                difficulty = item.difficulty,
                coopMapDivisionType = CoopDivision.FREE_FOR_ALL,
                unlockDifficulty = MapDifficulty.Beginner,
                mapMusic = "MusicDarkA",
                mapSprite = new SpriteReference(guid)
            }).ToArray<MapDetails>();








                }





    }
}


        [HarmonyPatch(typeof(Btd6Player), "IsMapUnlocked")]
        public class ShowMedal_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(ref bool __result)
            {
                __result = true;
                return false;
            }
        }

        [HarmonyPatch(typeof(Btd6Player), "IsModeUnlocked")]
        public class aaaa
        {
            [HarmonyPrefix]
            public static bool Prefix(ref bool __result)
            {
                __result = true;
                return false;
            }
        }





        [HarmonyPatch(typeof(MapButton), "ShowMedal")]
        public class ShowMedal_Patch2
        {
            [HarmonyPrefix]
            public static bool Prefix(MapButton __instance, Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode)
            {
                //player.debugUnlockAllModes = true;
                //player.IsModeUnlocked

   
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.UnlockMap(mapnamesfinal);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Easy", "Standard", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Easy", "PrimaryOnly", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Easy", "Deflation", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Easy", "Reverse", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Medium", "Standard", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Medium", "MilitaryOnly", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Medium", "Apopalypse", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Medium", "Reverse", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Hard", "Standard", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Hard", "MagicOnly", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Hard", "DoubleMoabHealth", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Hard", "HalfCash", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Hard", "AlternateBloonsRounds", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Hard", "Impoppable", false, false);
                foreach (string mapnamesfinal in UnlockMaps.mapnamesfinal) player.CompleteMode(mapnamesfinal, "Hard", "Clicks", false, false);


                return true;


                //foreach (var item in Game.instance.mapSet.Maps.items)
                //{
                //    player.MarkSeenMapUnlock(item.id);
                //    player.IsMapUnlocked
                //}


                //player.kno
                //Console.WriteLine(mapId);
                //Console.WriteLine(difficulty);
                //Console.WriteLine(mode);
                //player.CompleteMap("lyne");
                //player.CompleteMap("heartgate");
                //player.MarkSeenMapUnlock("lyne");
                //player.MarkSeenMapUnlock("lyne");
                //player.MarkSeenMapUnlock("heartgate");
                //Console.WriteLine("ShowMedal");
                //Console.WriteLine(player == null);
                //Console.WriteLine(player.debugUnlockAllModes = true);
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



        //[HarmonyPatch(typeof(Tower), "Initialise")]
        //public class TowerInitialise_Patch
        //{

        //    [HarmonyPrefix]
        //    public static bool Prefix(Tower __instance, ref Model modelToUse)
        //    {
        //        if (lastMap != "epiloge") return true;
        //        var wep = modelToUse.Cast<TowerModel>();
        //        var builder = new TowerBuilder(wep);
        //        builder.SetFootprint(new FootprintModel("", true, true, true));
        //        modelToUse = builder.build();
        //        return true;
        //    }
        //}

        //[HarmonyPatch(typeof(Tower), "UpdatedModel")]
        //public class UpdatedModel_Patch
        //{

        //    [HarmonyPrefix]
        //    public static bool Prefix(Tower __instance, ref Model modelToUse)
        //    {
        //        if (lastMap != "epiloge") return true;
        //        var wep = modelToUse.Cast<TowerModel>();
        //        var builder = new TowerBuilder(wep);
        //        builder.SetFootprint(new FootprintModel("", true, true, true));
        //        modelToUse = builder.build();
        //        return true;
        //    }
        //}




        //public static List<AreaModel> getTrackAreas(List<PointInfo> pointsList,float margin)
        //{
        //    List<AreaModel> newareas = new List<AreaModel>();

        //    var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
        //    area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, -115.2764f));
        //    area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.1904f, -114.1706f));
        //    area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6712f, 114.1708f));
        //    area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, 114.7236f));
        //    newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 0, (AreaType)2));

        //    var points = pointsList.ToArray();
        //    for (var j = 0; j < points.Length - 1; j++)
        //    {
        //        var point1 = pointsList[j];
        //        var point2 = pointsList[j + 1];
        //        var area = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
        //        area.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(point1.point.x + margin, point1.point.y));
        //        area.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(point1.point.x - margin, point1.point.y));
        //        area.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(point2.point.x + margin, point2.point.y));
        //        area.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(point2.point.x - margin, point2.point.y));
        //        newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area), 0, (AreaType)2));


        //    }
        //    return newareas;
        //}




    }
}