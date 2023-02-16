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
using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Models.Store;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Map;
using UnityEngine;
using System.IO;

using Il2CppAssets.Scripts.Models.Map.Spawners;

namespace custommaps.Maps
{
    class Offside
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.037f, 2.981549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-120.1852f, -3.194507f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-97.5926f, 75.38887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-74.62964f, 16.18521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-50.74075f, 69.85183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-30f, 25.34254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-60.74075f, -53.02774f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-32.77778f, -67.08338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.7407368f, 0f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(30.00001f, -66.01845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(59.44445f, -55.15732f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(48.14816f, -22.57408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(28.14816f, 24.7038f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(48.51852f, 67.08338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(72.5926f, 18.74084f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(95.00001f, 73.89817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(118.5185f, -2.768451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(145.3704f, 1.91662f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(145.3704f, 2.981549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(119.2593f, -2.768451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(95.55556f, 73.68521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(73.14816f, 16.82422f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(48.14816f, 70.27775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(27.96296f, 25.55549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(59.44445f, -54.51845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(29.44445f, -67.29633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.7407368f, 0.2129578f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-32.03704f, -67.50916f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-61.29631f, -54.94437f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-30.37037f, 24.4907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-50.92593f, 67.72225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-75.55556f, 18.74084f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-97.5926f, 75.17591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-120.9259f, -1.490704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-146.6667f, 2.555493f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }





        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, -114.3611f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, -114.1482f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.037f, 114.3611f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, 114.3611f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 10.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.7037f, 4.685211f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-99.81483f, 84.54633f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-93.88889f, 84.54633f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-74.81482f, 32.79634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.5926f, 78.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.77778f, 77.9445f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.88889f, 27.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-54.62964f, -49.62042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.00001f, -57.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.777776f, 5.537042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.037031f, 5.324084f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.70371f, -57.5f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.33334f, -50.0462f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.03703f, 26.19451f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.96296f, 79.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.88889f, 32.15746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(93.33334f, 83.26859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.81483f, 83.26859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.8519f, 4.898169f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.037f, 10.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.4074f, -3.83324f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.7407f, -10.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(97.22224f, 53.66676f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.5926f, 8.731549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.25928f, 7.879578f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.96296f, 56.00929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.88889f, 24.7038f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.85187f, -56.86113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.25926f, -75.60183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.66667f, -74.32408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.51852f, -73.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.48149f, -72.83324f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.55555f, -69.21296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(23.33334f, -66.44437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(24.81482f, -70.91662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0f, -16.61113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.70371f, -76.02775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-66.85186f, -56.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.25926f, 24.4907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.33334f, 56.64817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-71.11111f, 8.092535f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.77779f, 8.305634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.92593f, 53.02774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.6667f, -8.092535f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, -3.620422f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new AlternateRoundSplitterModel("", new string[]
                    {
                        "Path",
                        "Path (1)",
                    }), new AlternateRoundSplitterModel("", new string[]
                    {
                        "Path",
                        "Path (1)",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (1)", track2(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }
    }
}