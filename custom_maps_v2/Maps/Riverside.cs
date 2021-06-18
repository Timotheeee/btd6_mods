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
    class Riverside
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100.5556f, 115f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100.5556f, 33.0093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-89.25927f, 16.39817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(86.66667f, 16.39817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(102.7778f, -3.83324f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(102.7778f, -75.38887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(87.03705f, -88.59254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-85.37038f, -88.59254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-99.44446f, -69f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-99.44446f, -2.129578f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-84.81482f, 14.90746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(89.44446f, 14.90746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(103.1482f, 34.28704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(103.1482f, 115f) });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.3704f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.8148f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.8148f, 114.5741f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2)); var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-91.48148f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-90.55557f, 37.90746f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.33334f, 25.76859f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.33334f, 25.12958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.33334f, 35.35183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.37038f, 34.71296f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.1852f, 24.91676f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.37038f, 24.91676f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.14816f, 31.30549f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.62963f, 34.28704f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.4815f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.0741f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8519f, 27.47225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.7778f, 12.56493f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.33334f, -0.4259155f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.03705f, 1.277887f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.85185f, -9.370422f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.70371f, -8.731549f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.33334f, 1.277887f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-82.5926f, 0.2129578f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.2593f, 18.31479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.3333f, 26.83338f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.5185f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-90.74075f, 114.787f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.8889f, 12.77775f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-107.7778f, -1.703662f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.3333f, -75.81479f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.81483f, -90.2962f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.8889f, -100.5184f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.44445f, -100.9445f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.81482f, -112.0184f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.66668f, -111.8055f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.66668f, -100.9445f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.40742f, -96.89817f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.7037f, -83.05549f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.0741f, -69.85183f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.2222f, -5.111126f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.1482f, 11.71296f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.40742f, 0.2129578f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.62963f, -10.86113f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.88889f, -70.06479f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.85185f, -79.22225f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.74074f, -78.7962f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.11112f, -67.08338f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.51853f, -67.50916f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.44445f, -78.15746f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-82.40741f, -78.58338f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-89.62964f, -70.06479f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-89.62964f, -8.944366f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-82.22223f, 0.2129578f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.81483f, 12.56493f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 110f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var areaA = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40f, 33.86113f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.48149f, 44.5093f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.07408f, 54.30549f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.7037f, 62.18521f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 77.09267f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.62964f, 86.88887f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 96.04633f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.44445f, 106.4815f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.11111f, 115f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.18518f, 115f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.96297f, 107.5463f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.18518f, 101.5834f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.40741f, 95.62042f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.44444f, 77.9445f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.81482f, 69.63887f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.74074f, 63.25f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.8889f, 58.35183f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.37038f, 53.02774f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.37038f, 43.01859f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.77779f, 38.97225f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.2963f, 34.5f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40f, 34.07409f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.40741f, 38.97225f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(areaA), 10, (AreaType)1));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.88889f, -8.092535f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.88889f, -21.2962f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, -25.76845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.14816f, -31.30563f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.51852f, -40.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, -45.78704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.81482f, -53.02774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.92593f, -59.41662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.70371f, -65.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.07408f, -68.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.22223f, -67.50916f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.14815f, -61.5462f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.88889f, -54.09253f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.88889f, -49.19437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.66667f, -42.37958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.51853f, -37.69437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.22223f, -32.15746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.40741f, -25.55549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.37038f, -19.80549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.59259f, -15.33324f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.85186f, -12.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.48148f, -10.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.44445f, -8.305493f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 10, (AreaType)1));
            var areaB = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 115f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.44445f, 107.5463f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 97.32408f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.74074f, 91.36112f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.74074f, 85.61112f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.11111f, 81.13887f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.77778f, 77.51845f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 73.68521f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.81482f, 69.21296f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.25926f, 62.18521f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.11111f, 57.71296f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.51852f, 55.79634f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.44444f, 53.02774f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.40741f, 48.98155f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.40741f, 44.08338f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.70371f, 39.61113f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.81482f, 34.71296f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40f, 34.92591f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.18518f, 34.5f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.92593f, 115f));
            newareas.Add(new AreaModel("lolB", new Assets.Scripts.Simulation.SMath.Polygon(areaB), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var areaC = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.25927f, 115f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.07409f, 108.1852f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.44444f, 101.7963f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.96297f, 97.53704f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.33333f, 91.78704f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.25927f, 87.10183f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.18518f, 82.41676f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.74074f, 76.02775f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.92594f, 70.06493f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.85185f, 65.59254f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.96297f, 61.97225f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.44444f, 59.41662f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.59259f, 55.79634f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.55556f, 50.89817f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.74074f, 45.78704f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.22223f, 40.88887f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.33334f, 38.7593f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.2963f, 34.07409f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.33334f, 35.13901f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.44445f, 115f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.92594f, 115f));
            newareas.Add(new AreaModel("lolC", new Assets.Scripts.Simulation.SMath.Polygon(areaC), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.25926f, -8.731549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.88889f, -13.84254f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.44445f, -20.44437f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, -25.34254f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.18518f, -29.81479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.51852f, -32.58324f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.88889f, -37.90732f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.81482f, -43.23141f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.85186f, -46f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.55556f, -50.68521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.55556f, -55.15732f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.48149f, -60.90746f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.70371f, -63.67591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.62963f, -67.50916f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.62964f, -67.72225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.18518f, -10.00916f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.44445f, -10.00916f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.96296f, -9.796338f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.59259f, -9.58338f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.22223f, -12.13887f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.77777f, -15.54634f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(40f, -17.46296f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.66667f, -20.01845f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.18518f, -21.93521f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.25927f, -24.91662f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.77777f, -28.53704f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.88889f, -34.07409f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.44444f, -37.48155f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.48149f, -40.03704f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.03705f, -41.7407f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.74074f, -44.29634f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.44444f, -48.98141f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.74074f, -56.43521f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.22223f, -60.48141f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.62964f, -63.25f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.40741f, -67.93521f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.14816f, -67.72225f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.14816f, -9.370422f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.59259f, -9.370422f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
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