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
    class SprintTrackData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.4074f, 68.14817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-52.77779f, 64.31479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-76.66668f, 47.49084f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-87.96297f, 24.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-88.51852f, -8.518451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-81.48149f, -29.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-63.70371f, -49.62042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.25926f, -56.64817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.1851887f, -57.07408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(23.7037f, -56.86113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(49.81481f, -54.94437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(74.81483f, -45.78704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(93.70371f, -25.98155f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(100.3704f, -1.277747f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(102.2222f, 24.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(93.70371f, 46.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(69.44446f, 71.76859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(34.07407f, 82.84254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(0.7407368f, 83.05549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-41.2963f, 81.13887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-71.48148f, 72.1945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-87.96297f, 55.15746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-98.51853f, 33.0093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.5185f, -2.342535f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-98.51853f, -24.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-90.74075f, -40.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-79.81483f, -55.15732f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-67.40742f, -64.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-48.14815f, -71.34254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-21.2963f, -72.62028f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-1.666671f, -72.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(26.85185f, -72.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(52.77778f, -71.34254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(72.77778f, -61.33324f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(89.81481f, -41.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(99.44445f, -10.64817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(103.3333f, 15.33338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(100.7408f, 36.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(89.25928f, 64.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(58.14815f, 96.25929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(24.62964f, 99.66676f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-4.814816f, 98.60183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-35.92593f, 97.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-58.70371f, 92.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-77.5926f, 81.77775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-97.77779f, 65.37958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-108.5185f, 46.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-116.8519f, 23.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-118.8889f, 5.537042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-116.6667f, -13.20366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-111.8519f, -28.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-104.8148f, -43.23141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-91.66667f, -63.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-68.8889f, -81.35183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-42.77778f, -90.08324f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.14815f, -91.36112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.7037f, -92.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(61.48149f, -91.14803f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.2222f, -92.42591f) });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.8148f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6667f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.85185f, -40.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.81482f, -43.65746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.51852f, -41.10183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-61.85186f, -32.15746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.8889f, -18.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.92593f, 0f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.25927f, 16.61113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.88889f, 27.04634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-55.55556f, 37.48155f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.74074f, 42.59253f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.88889f, 42.59253f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.85186f, 35.9907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.77778f, 21.50929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.2963f, 6.814789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30f, -5.749859f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.25926f, -25.12958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.40741f, -41.10183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.66667f, -43.23141f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 10, (AreaType)1));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.2222f, 56.00929f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.6667f, 54.51859f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.1111f, 33.22225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.8889f, 20.01845f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.9259f, -0.851831f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.0371f, -27.89817f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.6667f, -54.09253f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.037f, -54.30549f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.4074f, -99.66662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.8519f, -98.60183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.1852f, -100.0925f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.44445f, -100.7314f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.48148f, -99.45366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-61.85186f, -95.19437f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.2963f, -85.82408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.33334f, -70.70366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.1482f, -46.42591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120.3704f, -24.91662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-122.963f, -3.620422f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120.1852f, 28.53704f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.4815f, 58.77789f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-87.77779f, 81.13887f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.14816f, 99.66676f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.9259344f, 101.1575f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.55556f, 100.5186f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6667f, 100.0925f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.5926f, 56.86113f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.48149f, 54.73155f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.62964f, 54.30549f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.33334f, 39.61113f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80f, 16.82422f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-82.40741f, 0.4259155f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-78.51853f, -21.08338f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.00001f, -41.31479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.25926f, -53.45366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.25926f, -53.66662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.18518f, -53.87958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.66667f, -53.45366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.92594f, -45.36113f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.40742f, -20.01845f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.92594f, -0.851831f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.03704f, 23.85197f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(67.77779f, 38.7593f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.5926f, 52.17591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.5926f, 54.94451f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.11111f, 55.15746f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)0));
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
