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


//using Il2CppSystem.Collections;


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
using Il2CppAssets.Main.Scenes;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Models.Store;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Map;
using UnityEngine;
using System.IO;
using UnhollowerRuntimeLib;
using Il2CppAssets.Scripts.Models.Map.Spawners;

namespace custommaps.Maps
{
    class Checkers
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-148.1482f, -20.23141f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-132.5926f, -21.2962f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-133.3333f, -56.43521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100.7408f, -57.07408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-98.8889f, -22.36099f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-66.48149f, -21.50929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-67.03705f, -56.86113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.81482f, -55.79634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-33.14816f, -20.01845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(0.9259344f, -20.01845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9259255f, -57.5f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(32.5926f, -56.43521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(32.96296f, -21.50929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(67.22223f, -20.65746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(66.66667f, -57.5f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(98.70371f, -56.86113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(100.7408f, -21.2962f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(130.5556f, -20.87042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(132.4074f, 16.82422f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(99.44445f, 15.97225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(100.5556f, 52.81479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(67.77779f, 52.81479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(66.85187f, 16.82422f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(33.14816f, 16.61113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(32.96296f, 51.53704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.3703684f, 52.81479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(0f, 15.33338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-30.74075f, 16.18521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32.77778f, 52.60197f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-66.11112f, 53.02774f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-67.22223f, 17.03704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100f, 16.82422f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100.3704f, 52.81479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-132.2222f, 53.4538f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-133.7037f, 16.82422f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-148.1482f, 16.18521f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }



        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)0));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.963f, -97.53704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.5926f, -95.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.037f, 93.4907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, 94.55563f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 10, (AreaType)2));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, -114.787f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, -97.75f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.4074f, -96.25916f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.2222f, -114.787f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 10, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, 94.55563f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, 115f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.037f, 115f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.7778f, 95.40746f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 10, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-154.6297f, -25.34254f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.4815f, -26.19437f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-135.7408f, -62.82408f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.22224f, -61.97225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-96.11112f, -26.19437f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.37038f, -26.19437f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.81483f, -60.90746f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.92593f, -59.41662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30f, -25.55549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.148145f, -24.06479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.851851f, -60.6945f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.2963f, -58.56479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.03704f, -25.55549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.85185f, -25.34254f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.40741f, -63.03704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.9259f, -60.90746f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.963f, -27.25929f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.7037f, -24.06479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(138.1481f, 17.67591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.2222f, 18.95366f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.5926f, 54.73155f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.7037f, 55.58338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.07408f, 21.08338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.48148f, 20.23155f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.03704f, 55.79634f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.148145f, 56.64817f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.407408f, 20.87042f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.25926f, 19.37958f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.85185f, 57.07408f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.62963f, 57.71296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.44446f, 21.50929f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.14816f, 22.14817f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.03705f, 57.92591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-135.9259f, 59.41662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-135.5556f, 24.06479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-154.6297f, 21.72225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-154.6297f, 8.092535f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-129.4445f, 10.86113f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-128.3333f, 47.27774f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-103.1482f, 45.78704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105f, 10.22225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.5926f, 9.796338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.77779f, 47.27774f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 46.85183f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.22223f, 7.66662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.999996f, 9.370422f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.703702f, 44.93521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.7037f, 46.63887f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.77778f, 8.731549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.00002f, 10.64817f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.62963f, 45.14817f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.48148f, 46.42591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.48148f, 8.944507f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(127.963f, 10.64817f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(126.8519f, -12.77775f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.11112f, -14.05549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(95.92594f, -49.62042f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.85186f, -50.47225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.2963f, -14.48141f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.25926f, -15.12028f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.44445f, -51.75f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.92593f, -50.68521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.814816f, -16.61113f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.22223f, -15.12028f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.40741f, -53.2407f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-61.29631f, -52.81479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.14816f, -16.82408f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-103.7037f, -14.90746f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.6296f, -51.32409f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-126.2963f, -51.32409f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-127.2222f, -16.18507f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-154.6297f, -15.12028f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 10, (AreaType)0));

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