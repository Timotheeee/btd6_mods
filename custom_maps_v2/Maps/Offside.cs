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

namespace custommaps.Maps
{
    class Offside
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.037f, 2.981549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-120.1852f, -3.194507f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-97.5926f, 75.38887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-74.62964f, 16.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-50.74075f, 69.85183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-30f, 25.34254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-60.74075f, -53.02774f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32.77778f, -67.08338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.7407368f, 0f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(30.00001f, -66.01845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(59.44445f, -55.15732f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(48.14816f, -22.57408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.14816f, 24.7038f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(48.51852f, 67.08338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(72.5926f, 18.74084f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(95.00001f, 73.89817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(118.5185f, -2.768451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(145.3704f, 1.91662f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(145.3704f, 2.981549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(119.2593f, -2.768451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(95.55556f, 73.68521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(73.14816f, 16.82422f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(48.14816f, 70.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(27.96296f, 25.55549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(59.44445f, -54.51845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(29.44445f, -67.29633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.7407368f, 0.2129578f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32.03704f, -67.50916f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-61.29631f, -54.94437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-30.37037f, 24.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-50.92593f, 67.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.55556f, 18.74084f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-97.5926f, 75.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-120.9259f, -1.490704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-146.6667f, 2.555493f) });
            return list.ToArray();
        }





        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.5926f, -114.3611f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, -114.1482f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.037f, 114.3611f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.5926f, 114.3611f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, 10.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-123.7037f, 4.685211f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.81483f, 84.54633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.88889f, 84.54633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-74.81482f, 32.79634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.5926f, 78.37042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.77778f, 77.9445f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.88889f, 27.68521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.62964f, -49.62042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.00001f, -57.28704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.777776f, 5.537042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.037031f, 5.324084f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.70371f, -57.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.33334f, -50.0462f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.03703f, 26.19451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.96296f, 79.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.88889f, 32.15746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.33334f, 83.26859f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.81483f, 83.26859f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.8519f, 4.898169f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.037f, 10.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.4074f, -3.83324f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(115.7407f, -10.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.22224f, 53.66676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.5926f, 8.731549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.25928f, 7.879578f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.96296f, 56.00929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.88889f, 24.7038f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.85187f, -56.86113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.25926f, -75.60183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.66667f, -74.32408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.51852f, -73.89817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.48149f, -72.83324f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.55555f, -69.21296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.33334f, -66.44437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.81482f, -70.91662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(0f, -16.61113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.70371f, -76.02775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.85186f, -56.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.25926f, 24.4907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.33334f, 56.64817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.11111f, 8.092535f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-77.77779f, 8.305634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-95.92593f, 53.02774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-116.6667f, -8.092535f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.5926f, -3.620422f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
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
                        new PathModel("Path", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (1)", track2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }
    }
}