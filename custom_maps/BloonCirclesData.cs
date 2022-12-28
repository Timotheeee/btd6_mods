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
    class BloonCirclesData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(59.81482f, 114.787f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(57.96297f, 46.85183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(68.8889f, 42.59253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(82.77779f, 33.86113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(95.00001f, 21.08338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(103.5185f, 6.814789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(105.1852f, -14.26845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(100.9259f, -35.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(93.14816f, -52.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(81.85185f, -66.01845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(65.37038f, -72.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(48.70372f, -72.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.14816f, -66.01845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(15.74074f, -52.60183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(7.777781f, -37.05549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.333342f, -20.44437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(2.777785f, -2.555493f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(8.703697f, 13.62972f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(17.96297f, 32.15746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25.18519f, 24.7038f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(33.33334f, 11.28704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.51853f, -12.13887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(36.2963f, -33.86113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(29.44445f, -49.62042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(20.55556f, -61.12042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(8.518517f, -68.36112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-2.592597f, -71.76845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-23.88889f, -70.70366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-38.70371f, -63.88887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-49.62963f, -48.55549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-57.40741f, -28.96296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-60f, -8.518451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-54.81482f, 12.56493f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-51.29631f, 25.34254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-43.88889f, 35.13901f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-38.51852f, 35.35183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-27.59259f, 40.88887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.222224f, 44.93521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(10.00001f, 39.82409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(22.40741f, 27.68521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(31.85186f, 13.20366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(36.66668f, -4.046197f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.33333f, -26.19437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(29.81481f, -45.36113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(20.92594f, -60.48141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(8.888895f, -68.14817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-5.185184f, -74.11112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-22.40741f, -71.98141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-38.33334f, -66.23154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-49.62963f, -56.64817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-57.40741f, -42.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-60.74075f, -27.47211f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-62.22223f, -5.962958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-56.66667f, 11.28704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-57.59259f, 18.52775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-45.55556f, 33.64817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-35.55556f, 21.08338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-26.11111f, 4.472253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.44445f, -17.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-28.8889f, -39.61113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-37.77778f, -56.86113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-54.07408f, -70.06479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-73.33334f, -74.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-93.70371f, -70.91662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-104.2593f, -69.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-113.8889f, -58.9907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-121.2963f, -48.55549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-124.8148f, -30.2407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-127.037f, -12.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-122.2222f, 10.64817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-113.8889f, 24.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.7037f, 36.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-82.03705f, 45.78704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-67.77779f, 44.29634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-51.48148f, 39.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-39.44444f, 25.76859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-35.55556f, 17.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-26.2963f, 2.129718f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.81482f, -17.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-27.22223f, -34.07409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-35.37037f, -50.89817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-50.92593f, -64.31479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-66.11112f, -73.25929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-73.88889f, -73.25929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-72.96297f, -114.5741f) });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.5185f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.4074f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.07407f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.14816f, 54.51859f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.96297f, 52.60197f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.92593f, 48.12958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.18518f, 41.31493f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.2963f, 30.2407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.814816f, 17.46296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.407408f, -1.91662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.962965f, -15.97225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-0.1851887f, -32.7962f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.592588f, -40.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.407404f, -52.81479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.88889f, -62.82408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.96297f, -71.55549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.74074f, -76.02775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.59259f, -80.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.11112f, -82.41662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.48149f, -81.35183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.77779f, -75.38887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(95.92594f, -64.52775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.7408f, -53.45366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.6667f, -40.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.7778f, -26.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.7778f, -10.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.0741f, 6.175915f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(104.2593f, 24.91676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.44445f, 35.56479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.2963f, 46.21296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.55557f, 52.60197f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.74075f, 53.2407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.92593f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.74075f, 52.81479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.37038f, 38.12042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.33335f, 29.60183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.2963f, 17.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.70371f, 1.490704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.1111f, -15.33324f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.77779f, -36.20366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.74075f, -48.98141f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.77779f, -59.41662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.14816f, -66.23154f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.22222f, -67.08338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.59259f, -63.88887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.00001f, -56.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.96297f, -52.81479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.59259f, -43.87028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.2963f, -29.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.444452f, -15.12028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.00001f, 1.064789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.11112f, 16.61113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.18519f, 28.53704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.51852f, 38.33338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.81482f, 38.33338f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.407404f, 54.73155f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.370373f, 50.89817f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(19.44444f, 46.42591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.07407f, 31.51845f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.51852f, 15.33338f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.70372f, -8.305493f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(50.37037f, -23.63887f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.62964f, -43.65746f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.18518f, -59.84253f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.59259f, -70.06479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.18519f, -79.43521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.296294f, -81.56479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.14815f, -82.20366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.77778f, -79.43521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.77778f, -74.75f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.92593f, -77.94437f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.55556f, -71.76845f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.14815f, -63.25f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.25926f, -53.87958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-61.29631f, -43.65746f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.81482f, -30.87958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.55556f, -19.16662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.11112f, -3.194507f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60f, 14.69451f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50f, 30.87972f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40f, 41.31493f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.55556f, 50.68521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10.55556f, 53.87958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10.74075f, 38.7593f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.07408f, 35.9907f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.11111f, 25.98155f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.77778f, 24.06479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.25926f, 20.87042f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.22223f, 12.35183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.33334f, -3.407465f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.70371f, -25.12958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-49.62963f, -37.90732f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.66667f, -50.68521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.44444f, -62.39803f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.51852f, -65.59254f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.3703773f, -64.7407f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.51851f, -61.5462f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.37037f, -46.63887f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.77778f, -29.81479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.37037f, -13.20366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.33334f, 0.4259155f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.85185f, 15.54634f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.48148f, 28.11113f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.037045f, 34.5f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.96297f, 38.33338f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.48149f, -114.5741f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.96297f, -82.41662f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.44445f, -79.64817f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.18519f, -76.2407f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.70371f, -69.42591f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.59259f, -57.07408f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.07408f, -43.23141f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.81482f, -20.01845f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.18518f, -2.342535f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.51852f, 11.5f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.33333f, 22.57408f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.25926f, 31.09267f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.51852f, 39.61113f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.66667f, 45.36113f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-57.96297f, 51.53704f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.92593f, 52.17591f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-88.70372f, 51.75f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.6667f, 42.59253f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.9259f, 36.84253f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.3333f, 24.4907f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-125.3704f, 11.92592f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-129.4445f, -1.91662f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.5556f, -14.05549f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-128.7037f, -34.07409f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120.9259f, -50.89817f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.5556f, -65.16662f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.25927f, -74.75f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.81483f, -81.9907f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.25927f, -114.787f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80f, -65.37958f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-90.00002f, -60.90746f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.25927f, -57.28704f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.1111f, -43.23141f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.037f, -28.32408f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.963f, -11.92592f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-114.8148f, 4.472253f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.8519f, 21.50929f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-96.11112f, 31.73155f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.62965f, 38.54634f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.18519f, 37.05563f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.70371f, 24.4907f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.55556f, 13.84254f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.8889f, -2.342535f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.40741f, -20.65746f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.77778f, -37.69437f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.66667f, -52.38887f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.14815f, -64.7407f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.96297f, -67.50916f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-89.44446f, -63.25f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.18519f, -50.2593f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-49.44445f, -37.05549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.07408f, -21.72225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.62964f, -8.944366f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.11111f, 4.898169f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.96297f, 20.23155f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.5926f, 21.50929f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.96297f, 16.82422f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.88889f, 5.537042f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30f, -5.111126f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.62963f, -18.52775f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.40741f, -31.09254f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.40741f, -42.16662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.74075f, -49.40746f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)1));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.96297f, -50.47225f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(18.70371f, -44.5093f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.5926f, -35.77774f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.814812f, -25.12958f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.962961f, -14.26845f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.00001f, -1.064789f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.14815f, 9.58338f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.48149f, 22.14817f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.4074f, 11.92592f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.14816f, -0.4259155f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.77778f, -8.518451f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.33334f, -20.65746f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.18519f, -34.71296f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.66667f, -49.62042f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5), 10, (AreaType)1));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-77.77779f, -114.787f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-77.40742f, -81.77775f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-90.00002f, -79.64817f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.44446f, -75.17591f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.8519f, -69.42591f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.07409f, -57.92591f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-88.51852f, -64.10183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-72.96297f, -66.65733f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.40741f, -67.08338f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.77779f, -80.07408f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.33334f, -81.35183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.14816f, -114.787f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-77.5926f, -114.5741f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area6), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.44445f, 115f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.14816f, 54.09253f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(40f, 51.75f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.74074f, 36.41662f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.81483f, 38.12042f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.8889f, 35.77774f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.11113f, 50.68521f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.11111f, 51.53704f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.48149f, 115f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.18519f, 114.3611f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area7), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));

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