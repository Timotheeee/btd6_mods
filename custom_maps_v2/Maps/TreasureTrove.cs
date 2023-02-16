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
    class TreasureTrove
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-148.3333f, -92.21296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-121.8519f, -22.14817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-106.4815f, 4.898169f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-96.2963f, 15.54634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-83.14816f, 25.98155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-70.37038f, 31.94451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-53.70371f, 37.48155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-35.92593f, 38.33338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-17.03703f, 32.15746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.1851887f, 22.14817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(13.88889f, 6.601831f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(22.03703f, -11.71296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(23.33334f, -32.58324f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.55555f, -46.21296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(37.59259f, -53.2407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(53.14816f, -53.87958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(63.51852f, -53.45366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(85.55556f, -58.77774f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.7778f, -86.46296f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(3.148145f, 115f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(17.22222f, 59.41662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(21.11111f, 31.73155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(16.85186f, 5.962958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(10.92593f, -3.194507f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-7.777781f, -11.28704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-22.40741f, -13.84254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-38.51852f, -11.92592f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-49.07408f, -3.407465f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-57.22223f, 8.305634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-62.40741f, 31.94451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-52.22223f, 37.26859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-33.7037f, 37.26859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-10.18519f, 27.89817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(7.592601f, 16.61113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(17.59259f, 2.981549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(23.33334f, -15.33324f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(24.44444f, -36.62958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(27.96296f, -50.68521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(52.5926f, -54.51845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(63.8889f, -54.30549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(82.96297f, -59.41662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(85.55556f, -58.77774f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.7778f, -86.46296f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.7778f, 89.65746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(123.8889f, 81.9907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(102.4074f, 69.63887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(88.51852f, 59.62971f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(65.1852f, 41.7407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(51.85186f, 30.87972f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(33.70371f, 17.03704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(14.25927f, 1.703662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.5555571f, -8.944366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-12.22222f, -14.26845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-28.8889f, -15.33324f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.37038f, -8.092535f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-54.81482f, 4.898169f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-62.77779f, 31.73155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-57.22223f, 35.13901f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-44.81482f, 38.12042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-30f, 34.92591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-10.37037f, 27.04634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(0.9259344f, 18.52775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(16.48148f, 4.046338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(22.77779f, -16.39817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(24.25926f, -34.28704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.55555f, -42.80549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(33.70371f, -49.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(47.96296f, -53.2407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(69.25928f, -53.45366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(85.55556f, -58.77774f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.7778f, -86.46296f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150.1852f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.7408f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.6296f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-5.555553f, 115f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.222224f, 74.53704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.92593f, 57.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.33333f, 38.33338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.88889f, 28.32408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.40742f, 19.80563f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.703702f, 27.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.22222f, 36.2038f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.92593f, 41.7407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.11111f, 43.65746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-63.14816f, 40.88887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.25927f, 30.87972f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.8519f, 19.80563f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.5185f, 7.879578f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.3334f, -8.518451f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.2963f, -22.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.7037f, -72.83324f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.7037f, -114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-141.1111f, -114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-132.4074f, -79.64817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.1111f, -56.00929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-118.3333f, -38.97225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.5556f, -22.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-102.2222f, -5.962958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.40742f, 4.898169f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.33334f, 12.35183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-69.44446f, 19.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.55556f, 10.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-59.81482f, -4.472253f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-53.51852f, -13.84254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.96297f, -23.63887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.5926f, -27.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-9.444444f, -26.19437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.703702f, -20.23141f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.88889f, -13.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.37036f, -31.30563f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.77777f, -49.62042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.77779f, -54.51845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.33334f, -60.48141f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(37.96297f, -64.95366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.37038f, -66.01845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.48149f, -66.23154f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.25926f, -70.4907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.5185f, -101.1575f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.7037f, -79.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.7778f, -67.72225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.44445f, -54.94437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.77778f, -48.12958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(58.70371f, -46.63887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.1852f, -47.91662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.66668f, -45.78704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.88889f, -35.56479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.66666f, -20.23141f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.8889f, -2.342535f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.18519f, 14.26859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.14815f, 25.12958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.74075f, 35.56479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.48149f, 44.5093f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.7408f, 54.73155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.7407f, 63.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.037f, 69.63887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(139.4445f, 74.11112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, 75.38887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.5185f, 96.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(138.3334f, 93.27775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.1852f, 86.88887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.6296f, 78.15746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.96297f, 68.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(76.2963f, 60.05549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.22223f, 47.91662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.1852f, 32.79634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(30.37037f, 22.78704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.81481f, 38.33338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.14816f, 53.2407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(24.07408f, 70.4907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.37038f, 87.52789f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.11111f, 115f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 50f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.44445f, 26.40746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50.92593f, 19.59268f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.03704f, 11.71296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.00001f, 4.046338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.22223f, 0.6388733f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.62963f, 1.277887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-38.70371f, -3.407465f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.92593f, -7.879578f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.55555f, -7.66662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.666667f, -5.749859f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(4.074079f, 1.91662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.407408f, 9.796338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.48148f, 15.7593f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.7037f, 22.57408f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.00001f, 24.7038f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.40741f, 26.62042f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.8889f, 26.62042f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-51.29631f, 20.01845f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 60, (AreaType)2));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.92593f, 115f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(34.07407f, 99.66676f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(30.00001f, 94.98154f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.81481f, 89.65746f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(34.44445f, 87.10183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(38.88889f, 89.4445f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.14815f, 77.51845f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.66668f, 73.68521f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.62963f, 82.2038f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.11113f, 87.7407f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.55556f, 86.67591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.1852f, 89.4445f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.22222f, 94.12958f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.07409f, 89.4445f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(103.1482f, 91.57408f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.1111f, 98.60183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.4074f, 97.75f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.4445f, 102.4352f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(103.5185f, 107.1204f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105.9259f, 108.8241f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.4074f, 107.7593f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(112.5926f, 108.6111f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.5926f, 115f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.85185f, 114.1482f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.7408f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.2963f, 95.62042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.4815f, 89.23154f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120f, 89.23154f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.5926f, 81.35197f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.8148f, 79.00929f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.5556f, 80.71296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-112.963f, 80.71296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.5556f, 76.24084f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.5556f, 74.11112f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-104.0741f, 71.34254f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-104.4445f, 51.96296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.7037f, 49.62042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-112.7778f, 46.21296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.1111f, 43.01859f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-107.2222f, 42.59253f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105f, 40.03704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105f, 33.0093f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.8519f, 34.5f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.4815f, 34.71296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.4815f, 34.28704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.037f, 25.55549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.4815f, 18.74084f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120.5556f, 15.7593f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-124.8148f, 9.796338f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.2593f, 10.64817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.3333f, -3.407465f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-139.4445f, -9.58338f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-145.7408f, -8.731549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.6297f, -13.20366f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.5185f, 115f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.3333f, 29.17591f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(142.4074f, 26.83338f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(135.3704f, 31.94451f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.5926f, 28.75f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(126.2963f, 23f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(118.7037f, 20.23155f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.2593f, 10.86113f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(108.3333f, 12.56493f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.4445f, 11.5f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(106.6667f, 6.175915f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.3704f, 3.194507f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.3704f, -3.194507f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.96297f, -5.962958f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.40742f, -12.35183f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(97.22224f, -12.77775f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(96.85186f, -16.39817f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(93.88889f, -16.61113f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.77778f, -29.17591f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(96.66668f, -39.61113f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.7408f, -44.93507f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(106.2963f, -43.01845f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(113.7037f, -53.87958f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.7778f, -53.66662f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.0741f, -50.89817f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.1482f, -50.68521f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(135.1852f, -52.60183f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, -49.62042f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.5185f, 27.68521f));
            newareas.Add(new AreaModel("lol5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.48149f, -114.787f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-54.07408f, -107.5462f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.07408f, -107.5462f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.85186f, -103.713f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50.55556f, -99.02775f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.77778f, -91.57408f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.5926f, -87.10183f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-60.37038f, -89.23141f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-60.55556f, -90.08324f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-64.25926f, -87.52775f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-60.18519f, -79.43521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.40741f, -75.60183f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-68.14816f, -76.02775f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-71.2963f, -77.94437f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.40742f, -71.34254f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-84.44445f, -74.96296f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.74075f, -79.64817f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-88.51852f, -76.66662f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.03704f, -77.09254f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-93.33334f, -79.64817f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.07408f, -84.54633f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.11113f, -87.31479f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.77779f, -94.55549f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.18519f, -83.26845f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.1852f, -77.94437f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.6667f, -82.84254f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-118.5185f, -89.01845f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.8889f, -88.37958f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.6667f, -90.93521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.1852f, -94.34254f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-124.4445f, -96.89817f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.5926f, -96.89817f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.1111f, -97.11112f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.7778f, -94.12958f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-133.8889f, -91.78704f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-141.6667f, -114.787f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.66667f, -114.787f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.66667f, -113.7221f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.18519f, -106.2684f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.81482f, -107.7593f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.33334f, -104.7777f));
            newareas.Add(new AreaModel("lol6", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.81482f, -114.787f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(83.14815f, -112.0184f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.66667f, -97.32408f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(81.2963f, -91.78704f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(76.66668f, -93.70366f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.00001f, -88.80563f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.59261f, -86.88887f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.03705f, -79.86098f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.00001f, -77.73141f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.00002f, -86.25f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.96297f, -90.2962f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.2963f, -86.67591f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.5926f, -87.10183f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(51.66666f, -83.26845f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.66667f, -83.69437f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.2963f, -86.25f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.03705f, -90.50929f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(39.07409f, -89.23141f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.2963f, -92.21296f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.33334f, -95.62042f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.07408f, -101.5832f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(30.37037f, -109.463f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.77778f, -114.787f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.00002f, -114.787f));
            newareas.Add(new AreaModel("lol7", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));

            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                    }), new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                    }));
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