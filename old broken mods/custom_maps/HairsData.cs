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
    class HairsData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-123.7037f, -84.33338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-129.4445f, -74.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-135.3704f, -66.44437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-135.7408f, -63.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-134.8148f, -58.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-132.2222f, -52.81479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-128.8889f, -46.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-127.037f, -42.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-126.2963f, -35.13887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-127.5926f, -30.45366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-129.2593f, -25.12958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-132.2222f, -18.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-132.963f, -12.77775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-130.3704f, -7.66662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-128.1482f, -5.111126f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-125.7408f, -2.981409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-125f, 4.685211f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-125.7408f, 8.092535f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-127.7778f, 11.5f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-129.4445f, 16.61113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-129.0741f, 20.01845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-126.6667f, 25.76859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-123.8889f, 27.25929f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-87.96297f, -85.61112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-88.51852f, -84.33338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-91.11113f, -81.13887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-93.51852f, -77.09254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-95.92593f, -71.34254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-96.48149f, -63.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-92.5926f, -53.87958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-88.51852f, -50.0462f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-86.48149f, -45.78704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.92593f, -40.88887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-87.77779f, -35.13887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-91.2963f, -29.60183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-94.25927f, -24.91662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-96.2963f, -19.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-97.77779f, -8.092535f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-95.74075f, -2.768451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-93.33334f, 2.129718f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-90.74075f, 7.240704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-88.51852f, 11.5f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-87.77779f, 14.48155f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-89.07408f, 17.03704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-91.85186f, 21.50929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-93.33334f, 25.34254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-93.14816f, 31.51845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-92.03704f, 34.92591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-89.44446f, 41.7407f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-38.51852f, -84.54633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.92593f, -82.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-43.14816f, -77.09254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.92593f, -70.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-32.5926f, -58.77774f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-27.40741f, -51.32409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-29.07408f, -42.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-35.18518f, -34.71296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.18519f, -25.12958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.74075f, -15.54634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-36.66667f, -5.111126f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-32.96297f, 0.851831f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-31.85185f, 7.453802f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-35.37037f, 15.12042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-39.25927f, 21.29634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.37037f, 29.60183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.55556f, 37.05563f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(12.40742f, -84.54633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(9.074075f, -82.41662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(5.370373f, -78.37042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(2.962965f, -74.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(0.5555571f, -67.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(1.111114f, -59.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(3.703702f, -53.2407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(8.148141f, -43.23141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(7.962961f, -36.20366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(4.999996f, -28.11113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(0.7407368f, -21.2962f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-1.481483f, -14.69451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-1.851851f, -8.518451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(1.111114f, -2.342535f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(4.074079f, 2.555493f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(4.999996f, 8.305634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(3.888882f, 15.54634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(1.666671f, 22.78704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(1.296294f, 31.51845f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track5()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(62.22223f, -85.61112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(60.1852f, -81.77775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(57.22224f, -77.94437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(55.92592f, -70.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(59.25927f, -61.97225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(63.33334f, -53.87958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(61.11112f, -43.01845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(57.22224f, -33.0093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(53.14816f, -25.12958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(52.22222f, -19.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(53.88889f, -12.9907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(54.62963f, -8.944366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(54.81483f, -2.129578f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(52.5926f, 8.731549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(50.00001f, 16.82422f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(49.81481f, 25.55549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(54.81483f, 35.13901f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(56.11112f, 36.84253f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track6()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(127.4074f, -86.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(125.5556f, -83.05549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(122.963f, -78.37042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(124.0741f, -67.93521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(126.2963f, -59.20366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(132.5926f, -46.85183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(135.3704f, -38.12042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(133.1482f, -28.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(127.4074f, -21.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(123.5185f, -15.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(123.3334f, -7.66662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(125.9259f, -0.851831f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(129.8148f, 6.389014f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(131.1111f, 11.71296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(129.2593f, 21.93521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(122.7778f, 31.51845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(122.963f, 35.9907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(124.0741f, 39.39817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(125.3704f, 43.01859f) });
            return list.ToArray();
        }




        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-154.6297f, -96.89817f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.8148f, -93.70366f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.6296f, 85.39817f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-154.6297f, 85.39817f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-154.6297f, 76.24084f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.6296f, 76.24084f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.2593f, 114.5741f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-154.6297f, 115f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), 10, (AreaType)0));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-154.6297f, -86.67591f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-154.6297f, -114.787f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150f, -114.787f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.6296f, -85.82408f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)0));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, -85.18521f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.3704f, -85.18521f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-118.3333f, -60.90746f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-103.8889f, 27.89817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-100.5556f, 77.30563f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 76.87958f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -85.18521f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.7408f, -84.97211f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)0));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.40742f, -85.82408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80f, -82.62958f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.70371f, -77.30563f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.11111f, -71.98141f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.74075f, -66.23154f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-82.40741f, -60.48141f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80f, -53.2407f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-78.33334f, -49.40746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.77779f, -42.80549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.25927f, -37.05549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-81.2963f, -32.58324f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.55556f, -27.25929f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.59261f, -24.06479f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.92593f, -18.10183f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.03704f, -15.12028f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.77779f, -7.879578f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.66667f, -2.555493f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.00002f, -0.6388733f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.22223f, 3.407465f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.29631f, 11.5f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.48149f, 17.25f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.07408f, 22.78704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.11113f, 24.06479f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.2963f, 24.7038f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.2963f, 26.62042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.2963f, 31.09267f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.81483f, 36.41662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.96297f, 39.82409f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-88.33334f, 41.95366f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.22223f, 42.16676f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.37038f, 38.12042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.77779f, 31.73155f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.22224f, 25.98155f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.81483f, 20.65746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.22223f, 15.7593f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.66667f, 10.43521f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-93.70371f, 3.83338f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.5926f, 0.2129578f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-102.2222f, -3.83324f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-103.1482f, -11.5f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.8519f, -14.48141f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-100.9259f, -16.39817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-99.44446f, -22.57408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-96.66668f, -31.51845f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.74075f, -36.62958f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.22224f, -43.65746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-100.7408f, -52.17591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-104.6296f, -57.07408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.8519f, -65.59254f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.6667f, -71.98141f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-103.8889f, -80.92591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-100.7408f, -84.97211f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-100f, -85.82408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-78.14816f, -86.03704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-81.66667f, -81.13887f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.8889f, -78.15746f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)0));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.92593f, -85.39817f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-29.25926f, -81.77775f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-31.85185f, -77.94437f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.5926f, -74.11112f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.03704f, -68.36112f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.96296f, -63.67591f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.25926f, -58.35183f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.22222f, -53.02774f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.5926f, -45.36113f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.11111f, -41.52774f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.18519f, -33.86113f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.51852f, -27.47211f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.85186f, -18.7407f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.7037f, -7.879578f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.92593f, -4.046197f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-29.07408f, -1.277747f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.96296f, 6.389014f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.18519f, 13.20366f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.96297f, 15.7593f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.22223f, 22.36113f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.44444f, 26.83338f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.44444f, 31.73155f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.81482f, 35.9907f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-41.66667f, 36.84253f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.14816f, 33.64817f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.33334f, 26.62042f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.77778f, 20.44451f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-40.18519f, 16.18521f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.03704f, 9.157464f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.92593f, 3.407465f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.85186f, -1.064789f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-41.11111f, -5.537042f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-44.25926f, -10.00916f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.48149f, -12.35183f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.25927f, -15.7593f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.62963f, -20.65746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.59259f, -26.62028f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.5926f, -35.13887f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.96297f, -45.57409f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.59259f, -50.68521f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-41.2963f, -54.51845f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.74074f, -57.5f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.44445f, -61.12042f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-53.70371f, -72.1945f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.22223f, -82.84254f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.81482f, -85.82408f));
            newareas.Add(new AreaModel("lol5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5), 10, (AreaType)0));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.962965f, 33.64817f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.666671f, 31.09267f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.148145f, 23.63887f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.518517f, 15.12042f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.37037f, 9.58338f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.444452f, 2.342676f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.481487f, -3.194507f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.592588f, -7.453662f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.9259344f, -12.13887f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.592588f, -17.03704f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.518517f, -24.06479f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.11111f, -28.75f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.51851f, -32.58324f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(14.44445f, -34.49986f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.37036f, -40.88887f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.18518f, -46.85183f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.85186f, -54.30549f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.703697f, -58.9907f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.037045f, -62.82408f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.851847f, -71.76845f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.40742f, -77.73141f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.11111f, -85.18521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.48149f, -86.03704f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.48148f, -87.95366f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.148145f, -86.46296f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.592597f, -85.82408f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.259259f, -83.90733f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.037035f, -80.07408f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.777781f, -73.25929f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.592592f, -65.37958f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.259259f, -55.37028f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0f, -45.36113f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.9259344f, -39.18521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.222219f, -28.11113f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.666667f, -21.72225f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.888886f, -11.07408f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.703702f, -1.277747f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.7407368f, 1.064789f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.851851f, 6.175915f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.777785f, 18.74084f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.3703684f, 23.42591f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0f, 27.25929f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.5555571f, 32.15746f));
            newareas.Add(new AreaModel("lol6", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6), 10, (AreaType)0));
            var area7 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.66668f, 37.69451f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.18519f, 32.58338f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.07407f, 27.47225f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.96297f, 19.37958f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.88889f, 4.898169f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(58.70371f, -0.6388733f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.25927f, -7.027746f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(57.40741f, -13.84254f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.74074f, -21.08338f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.81482f, -31.73141f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.29631f, -38.54634f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.18519f, -43.87028f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.51853f, -53.45366f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.37037f, -62.39803f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.40741f, -68.14817f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.22223f, -78.37042f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.22222f, -84.75929f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.5926f, -85.61112f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.03704f, -85.82408f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.96297f, -85.39817f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.66666f, -84.97211f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.70372f, -84.75929f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.14816f, -84.75929f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.92593f, -82.20366f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(44.44444f, -78.7962f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.33334f, -71.34254f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.37038f, -63.88887f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.07408f, -57.07408f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.03704f, -49.83338f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.40742f, -43.65746f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.44445f, -34.28704f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(44.44444f, -26.19437f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.33334f, -21.93521f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(44.44444f, -16.39817f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.33334f, -9.157324f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.62963f, -1.91662f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.40741f, 7.453802f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(44.62964f, 16.18521f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45f, 28.53704f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.44445f, 32.79634f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.44445f, 37.69451f));
            newareas.Add(new AreaModel("lol7", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area7), 10, (AreaType)0));
            var area8 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(139.0741f, -85.61112f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(137.2222f, -84.33338f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(134.6297f, -79.64817f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(132.5926f, -75.17591f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(130.7408f, -66.65733f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(133.8889f, -60.48141f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(138.5185f, -49.62042f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(143.3333f, -40.25f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(141.6667f, -32.7962f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(137.5926f, -24.27775f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(129.4445f, -12.56479f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.3333f, -8.305493f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(133.7037f, 4.685211f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(134.4445f, 10.0093f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(134.0741f, 15.54634f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(129.0741f, 20.87042f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.9259f, 28.53704f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(124.0741f, 39.82409f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.7408f, 43.01859f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(124.2593f, 44.93521f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.0371f, 40.67591f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(118.5185f, 34.28704f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.0741f, 23.63887f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.963f, 13.20366f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(124.0741f, 3.620422f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.8148f, -3.194507f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.4445f, -10.00916f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(113.1482f, -18.7407f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(116.4815f, -24.06479f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.7408f, -31.09254f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(124.6296f, -41.10183f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.4074f, -47.06479f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.5926f, -54.09253f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(112.4074f, -64.7407f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(111.1111f, -73.68507f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.0741f, -84.12028f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.4445f, -86.03704f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.2593f, -85.39817f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(111.4815f, -78.58338f));
            newareas.Add(new AreaModel("lol8", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area8), 10, (AreaType)0));
            var area9 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45f, -1.064789f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.81481f, -0.6388733f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.85185f, 10.43521f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.92592f, 4.685211f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.1852f, -0.851831f));
            newareas.Add(new AreaModel("lol9", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area9), 10, (AreaType)1));
            var area10 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.81482f, 0f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.2593f, -0.851831f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.7778f, 5.324084f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(110.5556f, 12.35183f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.5926f, 13.62972f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.9259f, 15.54634f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.25927f, 16.39817f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.55556f, 17.46296f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.74075f, 17.46296f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.25928f, 17.25f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60.37038f, 14.90746f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.00001f, 13.62972f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.51852f, 13.20366f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.70371f, 12.13887f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.18519f, 9.157464f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(57.40741f, 6.814789f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.25927f, 4.046338f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.81482f, 0.851831f));
            newareas.Add(new AreaModel("lol10", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area10), 10, (AreaType)1));
            var area11 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-38.33334f, 3.620422f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.07408f, 2.129718f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.66667f, 1.703662f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.92593f, 2.129718f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.22223f, 2.555493f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.03704f, 2.555493f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.07409f, 2.555493f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.55556f, 1.490704f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-88.33334f, 1.064789f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-88.14816f, 1.064789f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.37038f, 6.175915f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.1852f, 9.58338f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.00001f, 12.77775f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-81.85185f, 13.84254f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.03704f, 15.7593f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.5926f, 16.82422f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-69.62963f, 17.25f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.74075f, 17.88887f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.40741f, 16.61113f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.48149f, 15.7593f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.77779f, 14.90746f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.37038f, 12.56493f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.03704f, 11.28704f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.25927f, 10.22225f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.40741f, 9.58338f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.55556f, 8.305634f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.55556f, 5.537042f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.2963f, 3.83338f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-38.33334f, 2.342676f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.77778f, 1.490704f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.77778f, 0.851831f));
            newareas.Add(new AreaModel("lol11", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area11), 10, (AreaType)1));
            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new AlternateRoundSplitterModel("", new string[]
                    {
                        "Path",
                        "Path (1)",
                        "Path (2)",
                        "Path (3)",
                        "Path (4)",
                        "Path (5)",
                    }), new AlternateRoundSplitterModel("", new string[]
                    {
                        "Path",
                        "Path (1)",
                        "Path (2)",
                        "Path (3)",
                        "Path (4)",
                        "Path (5)",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (1)", track2(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (2)", track3(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (3)", track4(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (4)", track5(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (5)", track6(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}
