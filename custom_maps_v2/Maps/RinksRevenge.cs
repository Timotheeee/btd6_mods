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
    class RinksRevenge
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.5926f, -33.64803f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(92.22222f, -34.28704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(104.2593f, -19.37958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(109.0741f, -0.851831f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(107.7778f, 18.95366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(99.25927f, 36.62958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(78.14816f, 42.59253f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(55.74074f, 46.21296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(39.07409f, 44.72225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.2222f, 45.36113f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.51853f, -113.9352f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.70371f, 81.9907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(31.11111f, 95.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(21.66667f, 102.6482f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.3703684f, 106.2684f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-16.48148f, 106.4815f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-30.92593f, 102.4352f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-40f, 90.50929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-46.48149f, 79.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-45.18518f, 64.7407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-44.25926f, -113.5093f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }







        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.037f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, 114.787f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.8889f, -114.1482f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.1852f, 85.61112f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.48148f, 100.9445f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.88888f, 107.7593f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.11111f, 112.8704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.333338f, 111.3796f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-6.296299f, 111.1668f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.25926f, 110.7407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.81482f, 108.6111f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.00001f, 96.47225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-49.81482f, 87.7407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-49.62963f, -114.5741f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.03704f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, 85.61112f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.37037f, 87.31479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.11111f, 95.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10f, 98.81493f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.48148f, 99.66676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.59259f, 98.60183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.03704f, 86.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.40742f, -114.3611f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, -41.31479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.07409f, -39.18521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8519f, -22.57408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.6296f, -5.749859f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(115.1852f, 7.240704f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.4815f, 26.62042f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.3704f, 41.31493f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.33334f, 45.57409f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.70372f, 47.49084f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.1111f, 51.75f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, 39.18521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.1852f, 34.5f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.1111f, 26.83338f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(104.8148f, 12.56493f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.1852f, 1.277887f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.1852f, -13.41662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.70371f, -24.06479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.5926f, -27.47211f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, -27.68521f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.2963f, 66.01859f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.07408f, 63.03704f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-91.85186f, 63.67591f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-86.48149f, 58.56479f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.92593f, 66.01859f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.25927f, 84.12042f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80.74075f, 90.50929f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80.37038f, 96.47225f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.96297f, 96.89817f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.5556f, 84.12042f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.9259f, 66.4445f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 10, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.62963f, -61.5462f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.37038f, -77.73141f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.51852f, -89.87042f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.25927f, -89.87042f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.74074f, -84.75929f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.66669f, -79.86098f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.37037f, -62.18521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.81483f, -53.66662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.8889f, -58.13887f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.48149f, -55.79634f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.62963f, -61.33324f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.11112f, -77.30563f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 10, (AreaType)1));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.5185f, 80.5f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-145.3704f, 81.77775f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-143.1482f, 81.77775f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140.7408f, 84.54633f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-138.3333f, 87.31479f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.963f, 91.57408f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.6667f, 96.47225f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.6667f, 99.66676f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.963f, 102.0093f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-139.8148f, 104.1389f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-142.037f, 107.1204f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-144.8148f, 109.037f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-145.3704f, 109.8889f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.4815f, 110.102f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, 110.5277f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, 81.35197f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.5926f, 115f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.22224f, 112.8704f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.92594f, 109.8889f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.07407f, 106.6945f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(72.5926f, 104.5648f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.44445f, 102.2223f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.92594f, 101.3704f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.62963f, 98.17591f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.55556f, 96.47225f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.5926f, 94.98154f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.22224f, 92.63902f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.14816f, 91.14817f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.70371f, 89.65746f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.14816f, 87.52789f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.40741f, 84.97225f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.25926f, 85.39817f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.1852f, 83.05549f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.96297f, 81.56479f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.25928f, 81.13887f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.48148f, 82.41676f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.14816f, 80.71296f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.81483f, 78.79633f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(95.92594f, 80.71296f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.40742f, 81.9907f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.88889f, 81.56479f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.1111f, 82.2038f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.5185f, 83.48154f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.1111f, 84.54633f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.1482f, 85.82408f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.6296f, 87.10183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8519f, 88.80549f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.5926f, 90.08338f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.5926f, 92f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.5926f, 92.85183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.5926f, 94.34254f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8519f, 95.83338f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.6667f, 97.75f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.8889f, 102.6482f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.0741f, 104.5648f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.0741f, 105.2037f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.8889f, 106.4815f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.5185f, 108.8241f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.5926f, 110.7407f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.4074f, 110.9538f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.5556f, 115f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.4074f, 115f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.40742f, 115f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.4445f, 97.11112f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.7778f, 93.27775f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.1111f, 92.63902f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.2963f, 88.37971f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.4815f, 84.33338f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.7778f, 80.92591f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(120f, 77.30563f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.5185f, 74.53704f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(127.2222f, 72.40746f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(128.3333f, 72.1945f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(132.037f, 73.04633f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(136.8519f, 74.75f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(139.4445f, 77.30563f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(142.037f, 80.5f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(142.037f, 84.33338f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(142.5926f, 89.23154f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(142.5926f, 92.85183f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(141.2963f, 95.83338f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(138.7037f, 97.75f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.7408f, 100.0925f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.5556f, 102.6482f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(127.4074f, 103.0741f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.4445f, 101.7963f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(122.4074f, 99.2407f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.6296f, 97.53704f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.5926f, 93.7038f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.2963f, 91.36112f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.1111f, 88.16662f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, -64.52775f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-145.7408f, -64.95366f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-143.1482f, -67.08338f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-139.6297f, -70.27775f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-135.5556f, -72.62028f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-132.037f, -75.60183f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-131.6667f, -78.58338f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.1852f, -83.69437f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.5556f, -87.7407f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-131.6667f, -93.27775f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-131.6667f, -96.47225f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-131.8519f, -99.87958f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-134.2593f, -99.45366f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.8519f, -99.2407f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140.1852f, -100.7314f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-144.0741f, -102.2223f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-145.9259f, -104.9907f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.963f, -108.611f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.963f, -64.7407f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120f, -90.72225f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.2222f, -90.72225f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115.1852f, -90.2962f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.037f, -91.36112f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.5185f, -92.85183f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.7408f, -95.40733f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.963f, -97.96296f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.6667f, -100.9445f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.1111f, -106.0556f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.2963f, -111.1666f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.7778f, -114.787f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.963f, -114.787f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-125.7408f, -114.787f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-127.4074f, -111.5925f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-128.5185f, -108.1852f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-129.0741f, -102.6482f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-127.963f, -98.17591f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-125.5556f, -96.25916f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-122.7778f, -92.85183f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120.7408f, -91.78704f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.4074f, -89.87042f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-114.8148f, -89.87042f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.6667f, -89.87042f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));

            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                    }), new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path1", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path2", track2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }
    }
}