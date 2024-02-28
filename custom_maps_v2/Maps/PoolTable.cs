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

namespace custommaps.Maps
{
    class PoolTable
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-110.9259f, -87.95366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.92593f, -90.72225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-64.07408f, -91.36112f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-44.25926f, -92.21296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-25.00001f, -83.48154f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-12.22222f, -66.23154f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-3.703702f, -47.4907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-7.037035f, -23.21296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-14.25926f, -10.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-30.74075f, 0.4259155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-49.81482f, 4.472253f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-62.22223f, 7.240704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-78.8889f, 13.62972f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-94.62964f, 32.58338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-98.14816f, 52.81479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-93.70371f, 79.00929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-80.92594f, 96.89817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-59.62963f, 106.2684f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-34.44445f, 105.2037f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-14.07408f, 86.67591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-3.703702f, 63.46296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(5.740733f, 32.58338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(18.70371f, 10.43521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(54.44445f, 5.75f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(80f, 18.74084f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(92.96297f, 48.76845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(88.8889f, 74.53704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(73.88889f, 98.38887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(56.85186f, 107.9723f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(38.88889f, 106.9075f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(15.18518f, 96.25929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(4.999996f, 77.30563f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-1.296294f, 52.60197f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(5.370373f, 26.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(21.11111f, 11.92592f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(43.51852f, 7.027746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(63.8889f, 1.490704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(79.62965f, -11.28704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(89.44446f, -30.45366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(91.85186f, -60.26845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(85.92593f, -76.45366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(95.18519f, -87.7407f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(95.55556f, -88.59254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(84.44446f, -73.68507f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(92.77778f, -44.08324f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(85.37038f, -18.95366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(58.33333f, 9.58338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(45.92593f, 5.111126f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(22.96297f, 10.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(7.777781f, 23.42591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.7407368f, 47.70366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-2.592597f, 68.36112f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(7.222224f, 86.46296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.18519f, 102.0093f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(50.55557f, 107.7593f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(72.5926f, 96.68521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(91.11113f, 74.11112f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(90.92593f, 35.56479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(72.5926f, 11.5f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(47.96296f, 5.962958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(22.22223f, 12.13887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(3.518522f, 32.58338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-3.333333f, 56.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-9.074075f, 83.90746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-35.55556f, 103.5f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-63.70371f, 103.5f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-84.25926f, 89.65746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-98.70371f, 64.9538f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-98.51853f, 37.90746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.55556f, 18.10183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-62.77779f, 10.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.92593f, 6.814789f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-25.92593f, -1.490704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-6.11111f, -20.23141f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-4.814816f, -50.0462f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-13.14815f, -76.2407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-30.74075f, -88.80563f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-52.03704f, -93.70366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-76.2963f, -91.36112f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-110.9259f, -88.37958f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(120.1852f, 79.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(81.66667f, 87.52789f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(63.7037f, 102.0093f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(40.18518f, 106.0556f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(19.44444f, 96.68521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(1.666671f, 78.79633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-4.259259f, 49.62042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(7.777781f, 22.78704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(29.25926f, 9.370422f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(52.40742f, 3.620422f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(70.37037f, -2.342535f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(87.59261f, -26.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(93.88889f, -51.53704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(85.37038f, -75.38887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(69.62963f, -88.59254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(51.11113f, -93.06479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(29.25926f, -90.2962f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(7.777781f, -74.96296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-2.592597f, -50.0462f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-8.148149f, -22.14817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-22.77778f, -5.749859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.55556f, 2.129718f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-72.40741f, 0.851831f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-90.74075f, -15.97225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-99.81483f, -40.46296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-97.40742f, -69f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-84.25926f, -88.59254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-61.85186f, -94.34254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-37.22223f, -90.72225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-18.51852f, -77.94437f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-5.555553f, -52.60183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-7.592592f, -24.91662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-18.14815f, -9.58338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-44.07408f, 3.194507f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-65.37038f, 9.58338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.37038f, 22.36113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-100.1852f, 43.65746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-123.1482f, 80.71296f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1482f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.0741f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1482f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area9 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.5185f, -76.66662f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-112.2222f, -97.11112f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-40.55556f, -101.1575f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.51852f, -92.21296f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.148145f, -78.58338f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(4.444438f, -61.12042f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.037045f, -49.83338f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.370373f, -30.2407f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.1851887f, -10.86113f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.33333f, 1.064789f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.18519f, 9.58338f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-40.37037f, 15.54634f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.59259f, 17.67591f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-66.48149f, 13.20366f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-84.62964f, 7.027746f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.07408f, -4.685211f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.3704f, -23.63887f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-107.7778f, -41.52774f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.3704f, -61.5462f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.4815f, -77.51845f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.1482f, -76.66662f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-76.11112f, -74.11112f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.55556f, -81.9907f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.96297f, -83.69437f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.37037f, -80.28704f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.33333f, -71.12958f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.85186f, -56.64817f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.33333f, -39.18521f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.96296f, -21.93521f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.55556f, -9.370422f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.77778f, -4.472253f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-61.29631f, -5.962958f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-74.81482f, -13.20366f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-84.62964f, -25.76845f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.00002f, -42.37958f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.40742f, -59.20366f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-78.51853f, -72.40746f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-64.07408f, -82.20366f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area9),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.481483f, -78.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.77778f, -63.88887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.70371f, -73.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.44445f, -80.71296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.22223f, -83.69437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.2963f, -81.13887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.48148f, -74.32408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80f, -59.84253f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(83.8889f, -42.80549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.81483f, -24.91662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.25928f, -11.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.25927f, 6.814789f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.25926f, -0.2129578f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.96297f, -10.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.07409f, -22.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(103.1482f, -35.77774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(103.5185f, -52.38887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(97.5926f, -66.87042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(106.4815f, -83.26845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(91.48148f, -92.85183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.92593f, -88.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.37038f, -94.76845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.40741f, -100.3055f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.18519f, -103.287f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(27.5926f, -100.3055f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.814812f, -93.27775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.407408f, -80.5f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.444452f, -60.48141f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-84.44445f, 6.389014f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.59261f, 20.01845f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.77779f, 29.17591f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.74075f, 41.52774f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.96297f, 53.02774f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.74075f, 70.06493f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-75.18519f, 87.10183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-61.11112f, 94.12958f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.33334f, 95.19437f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.33333f, 87.31479f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.5926f, 72.40746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.481483f, 90.93521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-9.444444f, 99.02775f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.59259f, 105.8427f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.40741f, 114.1482f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.8889f, 115f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-63.51852f, 115f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-73.70371f, 111.8055f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.14816f, 105.2037f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.2963f, 97.75f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.1111f, 84.75929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.9259f, 77.09267f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115f, 88.37971f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.1111f, 92.21296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.0741f, 85.18521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.4815f, 76.45366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.00002f, 15.33338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.8889f, 5.75f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-70.92593f, 21.08338f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.5556f, 68.78704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.8148f, 76.66662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(126.6667f, 88.80549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.37038f, 98.81493f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.07409f, 104.5648f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.25928f, 111.8055f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.81483f, 115f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.2963f, 115f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.74075f, 113.0834f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.96296f, 105.6296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(4.444438f, 96.89817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.777776f, 90.50929f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10.55556f, 74.96296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.48148f, 60.05549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.703707f, 36.41662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.962965f, 22.78704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.851847f, 12.35183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.92592f, 3.194507f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.77778f, -4.685211f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.48149f, -5.537042f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.81482f, -2.768451f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.00001f, 5.537042f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.59261f, 9.157464f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(93.51853f, 21.50929f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.3704f, 35.77774f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(103.7037f, 55.58338f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.8519f, 72.83338f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(118.8889f, 70.91676f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(78.70371f, 76.45366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(83.14815f, 64.7407f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(83.51852f, 46f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.18519f, 29.60183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.25926f, 19.59268f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(40.18518f, 13.84254f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.11111f, 21.50929f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.88889f, 32.58338f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.888895f, 48.98155f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.00001f, 68.78704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(23.14815f, 87.95366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.7037f, 96.25929f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.59259f, 92f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.96297f, 78.79633f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.5185f, 61.12042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-140.5556f, 60.48155f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-142.7778f, 76.66662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-132.037f, 75.38887f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120.5556f, 81.77775f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.6667f, 90.50929f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-118.1482f, 103.5f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.5926f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, 61.33338f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, -46.21296f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.7778f, -51.11098f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.1111f, -68.14817f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.8889f, -66.44437f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.2963f, -72.62028f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.1111f, -83.05549f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.8889f, -100.0925f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.1111f, -107.5462f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.7408f, -108.1852f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.1111f, -114.787f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -113.9352f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -47.4907f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, 29.38887f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(124.8148f, 40.46296f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(136.2963f, 56.43521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(130.9259f, 56.64817f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.037f, 60.90746f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.963f, 63.46296f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.5556f, 69f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.0741f, 76.24084f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.0371f, 86.46296f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.1482f, 90.93521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(140.3704f, 95.62042f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(134.6297f, 109.463f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.7037f, 111.1668f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.5926f, 31.30549f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.7037f, -76.02775f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.2222f, -90.50929f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.4445f, -87.10183f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.4445f, -85.39817f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.88889f, -86.25f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(91.85186f, -93.91662f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.77779f, -103.9259f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.33334f, -113.7221f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.00001f, -114.787f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, -114.787f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.2593f, -93.06479f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(129.8148f, -76.02775f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.3333f, -74.75f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));

            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                    }, ""), new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                    }, ""));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path1", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path2", track2(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path3", track3(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}