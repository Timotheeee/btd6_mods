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

using Il2CppAssets.Scripts.Models.Map.Spawners;

namespace custom_maps
{
    class TheRinkData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(27.03704f, 112.4445f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25f, -74.96296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(33.33334f, -93.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(46.29631f, -101.7963f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(60.55556f, -103.0741f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(77.03704f, -100.7314f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(89.07408f, -92.85183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(94.25927f, -76.87958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(91.66669f, -59.84253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(81.85185f, -42.59253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(68.8889f, -34.28704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(50.92593f, -33.86113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-91.11113f, -36.84253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-107.037f, -47.06479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-112.2222f, -62.61113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-107.4074f, -84.54633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-93.51852f, -100.5184f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-64.62964f, -100.5184f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-48.70371f, -88.37958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-47.77778f, -81.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.18518f, 72.62042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-52.77779f, 86.03704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-66.2963f, 97.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-82.77779f, 97.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-97.77779f, 96.25929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-108.7037f, 94.55563f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-113.8889f, 85.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-116.4815f, 69.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-112.4074f, 53.66676f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-96.2963f, 35.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-76.48149f, 30.87972f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(146.2963f, 30.2407f) });
            return list.ToArray();
        }





        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.4074f, -114.5741f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6667f, 114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.4074f, 114.3611f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.62962f, 113.5093f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.59259f, -44.29634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.22222f, -61.12042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.51853f, -73.04633f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.11111f, -82.41662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.96296f, -99.2407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.22223f, -107.5462f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(65.37038f, -108.8241f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.92594f, -107.5462f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(95.74075f, -96.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.5556f, -76.02775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.88889f, -57.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.40742f, -43.01845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.14816f, -30.87958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(38.70371f, -27.25929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80f, -26.62028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.77779f, -30.45366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.1852f, -45.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120f, -60.90746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.4074f, -79.86098f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.1482f, -95.19437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.55556f, -104.1389f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-73.88889f, -107.1204f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50.74075f, -101.3703f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.33334f, -90.72225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-38.51852f, -74.96296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.77778f, 67.50929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.40741f, 86.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.11112f, 100.0925f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-84.07408f, 104.3518f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-104.6296f, 101.7963f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-114.0741f, 87.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120.9259f, 68.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.7037f, 41.95366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.44445f, 29.17591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.74075f, 24.7038f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(145.5556f, 24.91676f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.8519f, 36.41662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-54.62964f, 38.7593f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-78.33334f, 37.48155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-100.9259f, 42.16676f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-107.2222f, 53.02774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.6667f, 73.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-102.4074f, 86.46296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.25927f, 91.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.5926f, 91.36112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.66667f, 80.92591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50.74075f, 65.80563f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50.18519f, -26.62028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-51.11111f, -44.93507f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-51.48148f, -62.39803f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.40741f, -76.66662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.59259f, -89.01845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.40742f, -95.19437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.40742f, -96.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-99.44446f, -87.10183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.5556f, -71.34254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-103.3333f, -54.94437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.25927f, -43.87028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-71.48148f, -43.87028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(38.33333f, -43.87028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(57.03704f, -44.93507f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.8889f, -41.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.40741f, -48.98141f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.1852f, -69.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.40741f, -87.7407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.85187f, -94.12958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.62963f, -93.91662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.18518f, -78.15746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.03704f, -65.16662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.22222f, -46.63887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.85186f, -20.44437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.37037f, 112.4445f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.8889f, -58.77774f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(44.07408f, -73.47225f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(51.66666f, -87.10183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.00002f, -85.82408f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.00002f, -81.56479f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(81.11111f, -74.96296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.1852f, -60.05563f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.7037f, -49.83338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(58.33333f, -53.87958f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.14816f, -53.02774f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(44.25926f, -56.22211f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)1));

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
                        new PathModel("Path1", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}