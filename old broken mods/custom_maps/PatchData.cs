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

namespace custom_maps
{
    class PatchData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.5926f, -70.06479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-110.9259f, -71.98141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-124.2593f, -67.29633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-130.1852f, -51.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-125.1852f, -33.22225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-111.1111f, -24.91662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(21.2963f, -23f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(50.92593f, -23f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(69.44446f, -21.08338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(87.96297f, -17.67591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(106.6667f, -14.69451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(116.4815f, -3.620422f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(116.8519f, 13.41676f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(110.7408f, 30.02789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(103.5185f, 36.84253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(92.03704f, 39.61113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(75.92594f, 41.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-84.62964f, 41.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-97.22224f, 41.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-106.4815f, 41.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-117.5926f, 45.57409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-122.5926f, 57.71296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-121.4815f, 77.09267f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-111.1111f, 86.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-93.14816f, 86.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-75.92593f, 88.16662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-60.37038f, 86.88887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40f, 84.12042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-23.51852f, 85.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-1.851851f, 84.33338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(14.62963f, 82.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(31.11111f, 83.05549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(55.92592f, 84.54633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(82.03705f, 86.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(106.2963f, 86.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(133.7037f, 86.03704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.963f, 86.46296f) });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6667f, -81.9907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.9259f, -81.56479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.963f, -75.81479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-136.1111f, -67.50916f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-138.5185f, -56.00929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-132.963f, -37.69437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.9259f, -23.85183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120f, -18.52775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.5926f, -18.52775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.03704f, -19.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.14815f, -16.39817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.55555f, -15.12028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100f, -9.58338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(108.1482f, -1.490704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(108.8889f, 8.944507f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105.3704f, 25.55549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(91.66669f, 28.11113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.22223f, 27.04634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.40742f, 28.32408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-104.2593f, 29.60183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-114.2593f, 31.09267f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.8519f, 38.33338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-134.2593f, 46.85183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-135f, 63.88901f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-132.2222f, 79.86112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.7037f, 89.4445f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-112.963f, 95.40746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.77779f, 94.76859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-31.2963f, 90.93521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.18518f, 89.87042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.51852f, 91.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(103.7037f, 96.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.2222f, 96.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, 77.09267f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(44.25926f, 69.63887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(27.77778f, 67.72225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.5555571f, 72.40746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.48149f, 70.06493f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.96297f, 76.45366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.6667f, 76.87958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-112.4074f, 74.53704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-114.2593f, 60.90746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.8889f, 50.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.2963f, 46.21296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.6296f, 47.91662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.4445f, 48.12958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.2963f, 35.77774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.963f, 25.34254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.5926f, 10.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(126.8519f, -7.453662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.3704f, -21.08338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.2593f, -21.2962f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(106.6667f, -30.02775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.22223f, -32.58324f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.22223f, -34.92591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-107.037f, -35.77774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-114.2593f, -40.46296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-118.8889f, -51.75f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.8519f, -63.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.14816f, -68.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.2222f, -60.90746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.2222f, -82.84254f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.5555571f, -17.03704f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.333338f, -15.33324f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.37037f, -7.66662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.40741f, -0.851831f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.74074f, 10.64817f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.703707f, 18.10183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.111114f, 21.29634f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.18519f, 17.88887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.11112f, 11.92592f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.62962f, 0.851831f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(14.44445f, -10.22225f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.407404f, -15.97225f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-14.07408f, 14.69451f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.666667f, 20.65746f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.296294f, 21.72225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.48148f, 18.10183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.96297f, 8.944507f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.81482f, -1.277747f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.96297f, -10.22225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.40742f, -17.46296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.333342f, -21.50929f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.592592f, -19.59254f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.92593f, -13.20366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.33334f, -2.555493f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.74074f, -5.962958f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10.74075f, -12.9907f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-5.740741f, -16.39817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.666671f, -17.67591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.74075f, -14.69451f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.66668f, -8.731549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.25926f, 0.2129578f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.96297f, 13.84254f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.18518f, 18.52775f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.444452f, 23.63887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.703702f, 25.55549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10.55556f, 25.12958f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.22223f, 18.74084f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-20.18519f, 9.157464f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-20.37037f, 1.703662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-19.62963f, -0.6388733f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));

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