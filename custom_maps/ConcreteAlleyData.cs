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


//using Il2CppSystem.Collections;


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
using Assets.Scripts.Models.Map.Spawners;

namespace custom_maps
{
    class ConcreteAlleyData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.8889f, 115f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.8889f, 71.98154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-55.00001f, 71.76859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-55.18519f, 0.6388733f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-102.7778f, 0.6388733f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.5185f, -60.90746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-2.222219f, -61.75929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-2.592597f, 21.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(51.11113f, 21.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.92593f, 102.6482f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(110.1852f, 104.3518f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(110.9259f, -32.15746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(52.03704f, -34.49986f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(52.40742f, -93.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(148.3333f, -92f) });
            return list.ToArray();
        }







        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.1852f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.8889f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.5185f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.037f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.2222f, 57.07408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.81482f, 56.64817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.81482f, 9.370422f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.6667f, 8.731549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.6667f, -76.02775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.222224f, -76.2407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.962961f, 6.601831f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.1852f, 7.66662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.1852f, 88.80549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.1852f, 89.01845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.81483f, -24.06479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.96297f, -25.12958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.03705f, -107.9723f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.5926f, -108.3982f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.5185f, -107.1204f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.8889f, -85.18521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, -85.18521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.59259f, -84.75929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.59259f, -47.91662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.4445f, -46.85183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.3704f, 112.6575f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.11111f, 112.0186f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.37038f, 30.87972f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.22222f, 30.02789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.40741f, -53.2407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.22223f, -53.02774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.5926f, -13.41662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.18518f, -13.20366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.18518f, 79.00929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.77779f, 79.64817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.40742f, 115f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.037f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.963f, -114.5741f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.4445f, -114.787f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.6297f, 115f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.3704f, 115f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.9259f, -30.66662f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(131.1111f, -30.87958f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(131.1111f, -83.05549f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.7037f, -82.84254f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.7037f, 115f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.2963f, 115f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.74075f, 84.75929f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.25928f, 80.71296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(67.22223f, 72.62042f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.62964f, 61.54634f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.96297f, 44.29634f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.25926f, 6.814789f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.29631f, -4.685211f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.14816f, -12.13887f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.18519f, -14.48141f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.66667f, -15.7593f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.66667f, -12.9907f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.14816f, -8.305493f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.03704f, -0.851831f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.51853f, 14.26859f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.77779f, 33.22225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(95.92594f, 45.36113f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.33335f, 58.56479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.40742f, 71.55549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.33334f, 83.26859f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.07408f, 86.88887f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.55556f, 83.90746f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.14816f, 76.24084f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.44446f, 59.62971f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)1));

            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                    }), new SplitterModel("", new string[]
                    {
                        "Path1",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path1", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}