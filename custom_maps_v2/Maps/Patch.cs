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

namespace custommaps.Maps
{
    class Patch
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.963f, -70.91662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-122.2222f, -70.91662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-137.037f, -62.39803f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-136.4815f, -41.31479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-117.2222f, -27.47211f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(77.77779f, -22.14817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(123.1482f, -12.9907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(127.5926f, -9.157324f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(127.7778f, 21.50929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(109.0741f, 39.61113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-116.8519f, 39.61113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-134.2593f, 54.73155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-134.8148f, 72.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-122.0371f, 87.31479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.55555f, 79.22225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.4074f, 89.87042f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150.1852f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, -63.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-104.2593f, -69f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.7037f, -66.65733f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.963f, -64.10183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.7778f, -62.82408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.2222f, -59.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.3333f, -53.66662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.1482f, -47.27774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.5556f, -40.88887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.5926f, -37.26845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.9259f, -35.77774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-99.07409f, -36.41662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.51852f, -35.77774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.92593f, -30.66662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120f, -25.34254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(131.8519f, -18.10183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(136.1111f, -13.41662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(138.1481f, -7.240704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(137.7778f, 16.61113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(131.6667f, 34.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.2222f, 44.29634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(93.14816f, 46f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.00001f, 46.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.8519f, 47.91662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120f, 49.83338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.5926f, 52.17591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125f, 59.62971f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.5185f, 69.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.0741f, 74.32408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.3333f, 77.51845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-54.81482f, 70.70366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.81482f, 69.21296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.592597f, 73.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.2963f, 67.72225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(76.11112f, 75.17591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.4074f, 73.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(133.1482f, 72.1945f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, 73.04633f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, 95.83338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(39.81482f, 87.95366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50f, 92.63902f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-103.3333f, 93.7038f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120.1852f, 92.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.2222f, 90.72225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.8519f, 84.75929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-135.1852f, 79.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-138.1482f, 70.91676f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-139.2593f, 59.20366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-137.4074f, 52.17591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-136.8519f, 46.21296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.1111f, 39.61113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.7037f, 33.64817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.0741f, 34.5f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.2963f, 31.09267f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.1111f, 28.75f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.81483f, 28.96296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.2593f, 28.96296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.0741f, 23.85197f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.963f, 18.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.9259f, 10.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.8148f, -1.703662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.4445f, -4.685211f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.03705f, -13.41662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.77777f, -15.33324f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.22223f, -19.80549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.5926f, -20.44437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.2963f, -23.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-139.0741f, -30.02775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-142.2222f, -38.75916f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-145.3704f, -53.87958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-143.5185f, -65.80549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-138.8889f, -73.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.963f, -81.35183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.03704f, -86.46296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.03705f, -85.82408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.5926f, -86.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.88889f, -87.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, -82.84254f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, 94.76859f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.66666f, 87.95366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.333333f, 89.65746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.48149f, 92.42591f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.51852f, 93.91662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.1111f, 93.4907f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.5556f, 92.42591f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.7408f, 89.65746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.7408f, 90.93521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.9259f, 94.12958f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-81.48149f, 97.11112f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-59.81482f, 93.27775f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.77778f, 91.57408f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.2963f, 90.72225f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.592597f, 89.65746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.33333f, 88.37971f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(37.22223f, 88.37971f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(57.40741f, 90.50929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(83.8889f, 93.91662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.8148f, 96.68521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(132.4074f, 98.38887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.8519f, 98.60183f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.5555571f, 21.50929f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.481487f, 21.08338f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.77778f, 17.03704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.92592f, 14.05549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.18518f, 8.305634f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.85185f, 2.342676f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20f, -5.324084f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.66668f, -9.796338f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.03704f, -14.05549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(4.259259f, -17.03704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.1851887f, -18.10183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-5.740741f, -17.67591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-9.074075f, -16.18507f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.88889f, -12.77775f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.66667f, -8.944366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-20.18519f, -2.768451f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-19.62963f, 1.703662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.59259f, 10.22225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.66667f, 16.18521f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.481478f, 18.95366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.481483f, 20.65746f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.666671f, 21.29634f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.851851f, 26.19451f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.03704f, 26.19451f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.11111f, 23.21296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.55555f, 20.23155f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-19.25926f, 15.7593f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-21.66667f, 10.43521f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.40741f, 2.768451f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-20.37037f, -5.324084f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.22223f, -13.41662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.03704f, -17.88887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.851856f, -20.87042f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.3703773f, -22.14817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.851847f, -20.65746f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.85186f, -18.52775f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.74074f, -16.39817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.81482f, -12.35183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.85185f, -5.111126f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.59259f, 0f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.85185f, 6.814789f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.62962f, 15.12042f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.74074f, 19.80563f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.18519f, 23.63887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.740733f, 24.91676f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.9259344f, 25.98155f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.259259f, 25.12958f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10f, 23.21296f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 110f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.9259255f, 20.23155f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.666667f, 19.16662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10.55556f, 17.03704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-14.07408f, 14.26859f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.48148f, 10.22225f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.88889f, 6.175915f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-19.07408f, 0.2129578f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.51852f, -4.472253f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.66667f, -8.518451f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-14.62963f, -11.07408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10.92593f, -14.26845f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.703707f, -16.18507f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0f, -18.10183f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.92593f, -16.82408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.48148f, -14.26845f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.55556f, -11.07408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.70371f, -6.388873f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.37038f, -3.194507f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.92594f, 0.2129578f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.44444f, 6.814789f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.14815f, 11.28704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.70371f, 14.90746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.074075f, 18.74084f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.703702f, 20.01845f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.3703773f, 20.65746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.888891f, 19.59268f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.777781f, 18.52775f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 10, (AreaType)1));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.8889f, -77.73141f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-144.6296f, -80.07408f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-141.8519f, -82.20366f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-138.3333f, -86.67591f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-137.037f, -86.67591f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-134.6296f, -89.65746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-133.3333f, -92.85183f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.6667f, -96.04633f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-135.9259f, -99.66662f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-137.2222f, -102.2223f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-140f, -109.037f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-141.1111f, -110.9537f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-144.2593f, -113.5093f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.2222f, -114.787f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1482f, -114.787f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, -81.13887f));
            newareas.Add(new AreaModel("lol5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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