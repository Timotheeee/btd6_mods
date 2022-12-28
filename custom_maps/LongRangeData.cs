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

namespace custom_maps
{
    class LongRangeData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.5926f, -58.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-137.037f, -28.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-127.963f, -4.685211f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-117.5926f, 16.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-109.2593f, 31.30549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-97.77779f, 43.44451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-84.25926f, 51.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-65.55556f, 56.22225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-46.11111f, 49.19451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-33.88889f, 35.13901f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-22.96297f, 20.65746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-9.814812f, -1.703662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.5555571f, -19.16662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(7.407404f, -33.43521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(20.37038f, -48.76845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(39.07409f, -54.09253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(59.25927f, -51.75f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(77.5926f, -43.23141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(93.14816f, -28.75f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(103.3333f, -12.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(117.2222f, 10.86113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(127.5926f, 28.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(135.7408f, 46.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(142.2222f, 63.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.2222f, 73.47225f) });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, -114.5741f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, -114.5741f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.2222f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.963f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.2222f, 27.89817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-141.8519f, 44.08338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-134.4445f, 67.50929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-125.7408f, 77.9445f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.7037f, 84.12042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110f, 93.7038f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.7037f, 114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.07408f, 114.5741f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.96297f, 101.5834f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-16.66667f, 87.31479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.518517f, 71.98154f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.3703773f, 62.39817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.81481f, 47.91662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.07408f, 36.84253f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.85186f, 20.44451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.2963f, 2.342676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.40741f, -4.259295f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(58.51853f, -0.2129578f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.70372f, 10.64817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.00001f, 25.98155f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.48149f, 46f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.92593f, 64.9538f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.70372f, 82.84254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.40742f, 97.11112f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.96297f, 110.7407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.62965f, 114.3611f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.7778f, 114.3611f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.7778f, 17.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(142.5926f, 12.35183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(139.0741f, -23.21296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.3704f, -37.05549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.4445f, -53.02774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.1852f, -71.34254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.81483f, -88.59254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.22224f, -93.4907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.25927f, -103.9259f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(95.37038f, -114.3611f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.18518f, -114.5741f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.777781f, -109.6759f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.518517f, -96.25916f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.77778f, -84.12028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.18518f, -74.75f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.81482f, -58.77774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.55556f, -43.87028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.96297f, -25.34254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.03704f, -8.092535f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.14816f, 2.768451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-77.96297f, 2.342676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-88.14816f, -14.26845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.77779f, -44.93507f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.4815f, -78.7962f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-114.4445f, -100.5184f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.7037f, -114.1482f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.037f, -114.3611f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
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