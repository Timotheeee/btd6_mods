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
    class TheRink
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(27.03704f, 112.4445f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25f, -74.96296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(33.33334f, -93.4907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(46.29631f, -101.7963f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(60.55556f, -103.0741f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(77.03704f, -100.7314f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(89.07408f, -92.85183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(94.25927f, -76.87958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(91.66669f, -59.84253f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(81.85185f, -42.59253f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(68.8889f, -34.28704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.92593f, -33.86113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-91.11113f, -36.84253f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-107.037f, -47.06479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-112.2222f, -62.61113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-107.4074f, -84.54633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-93.51852f, -100.5184f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-64.62964f, -100.5184f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-48.70371f, -88.37958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-47.77778f, -81.56479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-45.18518f, 72.62042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-52.77779f, 86.03704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-66.2963f, 97.53704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-82.77779f, 97.53704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-97.77779f, 96.25929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-108.7037f, 94.55563f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-113.8889f, 85.18521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-116.4815f, 69.42591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-112.4074f, 53.66676f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-96.2963f, 35.56479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-76.48149f, 30.87972f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(146.2963f, 30.2407f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }





        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.963f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.4074f, -114.5741f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6667f, 114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, 114.3611f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(19.62962f, 113.5093f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.59259f, -44.29634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.22222f, -61.12042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(18.51853f, -73.04633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.11111f, -82.41662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.96296f, -99.2407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.22223f, -107.5462f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.37038f, -108.8241f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.92594f, -107.5462f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(95.74075f, -96.47225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.5556f, -76.02775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.88889f, -57.28704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.40742f, -43.01845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.14816f, -30.87958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.70371f, -27.25929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80f, -26.62028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.77779f, -30.45366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115.1852f, -45.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120f, -60.90746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.4074f, -79.86098f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.1482f, -95.19437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-95.55556f, -104.1389f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-73.88889f, -107.1204f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.74075f, -101.3703f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.33334f, -90.72225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.51852f, -74.96296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.77778f, 67.50929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.40741f, 86.25f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-56.11112f, 100.0925f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-84.07408f, 104.3518f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.6296f, 101.7963f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-114.0741f, 87.31479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120.9259f, 68.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.7037f, 41.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.44445f, 29.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.74075f, 24.7038f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(145.5556f, 24.91676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.8519f, 36.41662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.62964f, 38.7593f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-78.33334f, 37.48155f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.9259f, 42.16676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-107.2222f, 53.02774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.6667f, 73.89817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.4074f, 86.46296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.25927f, 91.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-72.5926f, 91.36112f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-56.66667f, 80.92591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.74075f, 65.80563f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.18519f, -26.62028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.11111f, -44.93507f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.48148f, -62.39803f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.40741f, -76.66662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-57.59259f, -89.01845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.40742f, -95.19437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-87.40742f, -96.89817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.44446f, -87.10183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.5556f, -71.34254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-103.3333f, -54.94437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-89.25927f, -43.87028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.48148f, -43.87028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.33333f, -43.87028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.03704f, -44.93507f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.8889f, -41.31479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.40741f, -48.98141f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.1852f, -69.42591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.40741f, -87.7407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.85187f, -94.12958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.62963f, -93.91662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.18518f, -78.15746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.03704f, -65.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.22222f, -46.63887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.85186f, -20.44437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.37037f, 112.4445f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.8889f, -58.77774f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.07408f, -73.47225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(51.66666f, -87.10183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.00002f, -85.82408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.00002f, -81.56479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.11111f, -74.96296f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.1852f, -60.05563f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.7037f, -49.83338f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(58.33333f, -53.87958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.14816f, -53.02774f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.25926f, -56.22211f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 10, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.81483f, 112.6575f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.11112f, 110.3148f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.1852f, 106.2684f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.37038f, 100.9445f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.7037f, 101.1575f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.59261f, 99.2407f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.1852f, 93.7038f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.25927f, 92.42591f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.2963f, 88.59267f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.1852f, 84.97225f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.92594f, 82.41676f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.77779f, 82.2038f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.07408f, 77.9445f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.55556f, 73.25929f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.00002f, 71.12971f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.88889f, 68.57408f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(100f, 65.80563f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.9259f, 67.72225f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.7037f, 69.21296f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.5185f, 72.40746f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(115.7407f, 74.11112f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.963f, 76.66662f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.7037f, 80.07408f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.0741f, 84.33338f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.8148f, 87.95366f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.3704f, 92.21296f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.3704f, 94.55563f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.5926f, 99.66676f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(115.7407f, 102.6482f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.7037f, 105.4166f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.7778f, 108.3982f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.8889f, 111.5925f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.81483f, 112.4445f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.40742f, 110.5277f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.77778f, 107.9723f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.66667f, 103.5f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.00002f, 101.5834f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.77779f, 99.02775f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.48149f, 96.47225f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.3704f, 69.85183f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.7778f, 68.78704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.3333f, 65.59254f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.2963f, 63.46296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.8889f, 61.54634f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.4074f, 54.73155f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.7037f, 50.2593f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(110f, 46.85183f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.7778f, 42.80549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.1111f, 40.67591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.5185f, 39.61113f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.6667f, 39.18521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(127.7778f, 40.67591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(131.6667f, 43.44451f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.3333f, 45.78704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.7037f, 48.76845f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(134.2593f, 55.37042f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(134.4445f, 58.77789f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(132.963f, 61.75929f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(130f, 64.7407f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(126.8519f, 66.65746f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.2593f, 68.36112f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.1111f, 69.63887f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.4815f, 68.14817f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.3333f, 66.65746f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.1111f, 63.25f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.4445f, 60.26845f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.1482f, 56.43521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.1482f, 55.58338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.5926f, 51.32409f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.8148f, 48.12958f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.3333f, 20.44451f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(145.7408f, 23.42591f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(142.037f, 23.21296f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(134.4445f, 21.93521f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.3704f, 18.95366f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(127.4074f, 16.61113f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.8889f, 11.28704f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.7408f, 6.814789f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.3704f, 4.472253f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.2593f, 4.259295f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.9259f, 2.342676f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.8519f, 0.4259155f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.1111f, -1.91662f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.6296f, -4.685211f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(122.7778f, -5.537042f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.0741f, -8.731549f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(125f, -13.20366f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(126.6667f, -15.54634f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.7408f, -16.39817f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(132.4074f, -18.31479f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(136.8519f, -20.01845f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(139.8148f, -21.08338f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(143.3333f, -20.44437f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.2963f, -19.37958f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.3333f, -17.46296f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, 19.80563f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, -69.85183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.6667f, -69.63887f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-144.4445f, -72.1945f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-142.5926f, -73.25929f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140.1852f, -74.32408f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.2222f, -76.66662f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.1111f, -78.7962f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.1111f, -80.92591f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-135f, -83.26845f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-134.8148f, -84.97211f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.4815f, -86.46296f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.8519f, -88.80563f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.2963f, -91.36112f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-135.5556f, -93.91662f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.2963f, -95.19437f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.2963f, -98.38887f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.963f, -101.1575f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-141.6667f, -103.0741f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.2963f, -105.4166f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.963f, -106.9075f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, -70.4907f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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