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
    class BattleParkData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-148.3333f, -86.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-119.2593f, -84.54633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-117.963f, 88.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-117.4074f, 88.59267f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-64.81482f, 88.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-63.70371f, -86.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(6.481487f, -86.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(17.03703f, -66.44437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(21.11111f, -53.02774f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(20.74074f, 61.54634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(9.074075f, 83.48154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-13.14815f, 94.34254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-31.48148f, 83.6945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-44.07408f, 63.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-44.07408f, -56.64817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-23.33333f, -86.67591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(39.25927f, -85.61112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(41.11111f, 87.95366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(94.81483f, 87.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(94.81483f, -86.03704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.963f, -85.82408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(186.2963f, 27.89817f) });
            return list.ToArray();
        }







        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1482f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.037f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 114.787f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.5185f, -93.91662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.9259f, -92f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.3333f, 79.86112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.22223f, 79.00929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-70.55556f, -95.19437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.70372f, -93.70366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.8889f, 79.00929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.77779f, 77.9445f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.14816f, -93.4907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, -94.12958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.3333f, -76.87958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.0741f, -76.02775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.8519f, 96.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.14816f, 96.25929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.22222f, -75.38887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.11112f, -75.60183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.22223f, 97.75f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.0741f, 99.2407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.7037f, 81.56479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.7408f, 79.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.6667f, -76.2407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -75.81479f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.51852f, -76.2407f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.88889f, -76.45366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(23.88888f, -69.85183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.85185f, -60.48141f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.44445f, -37.05549f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.44445f, 64.7407f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(27.5926f, 73.47225f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20f, 86.03704f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.92593f, 93.27775f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.111114f, 97.96296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.11111f, 102.2223f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.14815f, 97.32408f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.74074f, 92.42591f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-44.07408f, 83.26859f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.51852f, 72.83338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-53.14816f, 58.56479f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-51.11111f, -63.25f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.14816f, -74.96296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-38.14815f, -76.02775f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-29.25926f, -75.60183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-31.2963f, -64.95366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.66667f, -54.94437f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.03704f, -35.77774f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.22223f, -21.93521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.85186f, -3.620422f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.66667f, 12.56493f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.40741f, 27.68521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.96297f, 47.70366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.00001f, 62.61113f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.22223f, 75.38887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-14.07408f, 82.2038f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.111114f, 78.58338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.444452f, 67.50929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.88889f, 52.38887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(14.44445f, -51.96296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.481487f, -66.44437f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.444448f, -74.32408f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-20.37037f, -72.62028f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-29.25926f, -66.87042f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.48148f, -54.30549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.62963f, -46.42591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.51852f, -35.35183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.48149f, -27.89817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.22223f, -18.95366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.37037f, -13.20366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.48149f, -6.388873f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.48149f, 3.407465f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.22223f, 13.84254f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.40741f, 22.14817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.74074f, 25.98155f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.11111f, 35.9907f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.62963f, 50.47225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.03704f, 57.07408f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.37037f, 62.82408f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.703707f, 64.31479f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.03704f, 60.05549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.592588f, 50.47225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.555553f, 47.27774f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(4.259259f, 31.51845f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.370373f, 12.35183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.703702f, 2.981549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.555553f, -18.52775f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.407408f, -25.76845f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(4.259259f, -41.31479f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.5555571f, -46.42591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.296294f, -52.38887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-9.259264f, -56.86113f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.14815f, -54.51845f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.55556f, -45.78704f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1482f, -19.59254f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-140.9259f, -23.21296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-133.8889f, -32.15746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.7408f, -42.80549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.1852f, -55.37028f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-134.4445f, -65.16662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-138.5185f, -73.25929f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.8889f, -78.15746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1482f, -20.44437f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.33334f, 115f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.07408f, 108.8241f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(91.11113f, 110.102f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.44445f, 105.4166f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.2222f, 102.6482f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(110.9259f, 106.0556f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.7778f, 107.3334f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.4074f, 111.1668f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.3333f, 115f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.14816f, 115f));
            newareas.Add(new AreaModel("lol5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(129.4445f, 106.4815f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.1852f, 100.0925f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.4445f, 93.27775f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115f, 85.18521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(113.7037f, 78.15746f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.9259f, 65.16662f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(124.0741f, 56.86113f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(131.8519f, 54.30549f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(142.5926f, 55.15746f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, 59.20366f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, 96.25929f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(141.1111f, 99.45366f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(135.7408f, 101.5834f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.8889f, 106.2684f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.5556f, 98.60183f));
            newareas.Add(new AreaModel("lol6", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.5926f, 104.7777f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(140.9259f, 104.5648f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(137.4074f, 113.0834f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, 114.5741f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.037f, 105.8427f));
            newareas.Add(new AreaModel("lol7", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area7), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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