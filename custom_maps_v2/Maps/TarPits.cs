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
    class TarPits
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-112.5926f, -30.87958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-98.33334f, -29.38887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-97.77779f, -13.62958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-94.44445f, -1.064789f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-88.33334f, 7.453802f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-80.55556f, 11.92592f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-73.70371f, 14.05549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-64.81482f, 14.05549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-57.22223f, 11.07408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-48.8889f, 4.898169f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-44.25926f, -2.555493f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.55556f, -11.28704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.55556f, -22.57408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-43.51852f, -32.37042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-49.44445f, -42.16662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-53.51852f, -45.78704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-61.11112f, -51.53704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-69.25927f, -51.32409f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-77.5926f, -50.47225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-86.48149f, -44.5093f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-94.44445f, -33.86113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-96.48149f, -27.68521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-112.5926f, -28.75f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-29.44444f, -109.8889f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-19.44444f, -99.66662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-23.14816f, -94.76845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-27.59259f, -84.75929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-27.96296f, -75.81479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-27.77778f, -64.7407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-25.18518f, -55.15732f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-18.51852f, -45.36113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-10.37037f, -39.39817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-2.222219f, -36.41662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(5.92593f, -38.54634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(14.07407f, -40.88887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(21.48149f, -48.34253f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(26.11111f, -53.2407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(32.5926f, -72.62028f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(31.2963f, -80.71296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(29.62963f, -87.10183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(24.81482f, -97.11112f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(20f, -101.3703f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(10.74075f, -106.4814f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(0.5555571f, -108.8241f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-9.074075f, -103.0741f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-19.25926f, -100.9445f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-27.03704f, -110.7407f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(101.6667f, -53.66662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(90.74075f, -40.88887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(73.33334f, -48.55549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(61.48149f, -47.91662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(50.92593f, -42.37958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(45.74075f, -33.22225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(42.96297f, -22.57408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(45.1852f, -13.62958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(43.33334f, -10.00916f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(43.33334f, -1.91662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(49.25926f, 7.66662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(57.96297f, 14.26859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(66.85187f, 19.37958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(78.51853f, 19.16662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(89.62964f, 14.05549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(97.22224f, 2.129718f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(101.2963f, -6.175915f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(102.5926f, -20.01845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(100.1852f, -27.25929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(93.14816f, -36.62958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(90.37037f, -39.18521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(101.1111f, -53.45366f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(79.25927f, 90.08338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(69.25928f, 85.18521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(74.07407f, 73.04633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(72.22222f, 64.7407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(68.8889f, 56.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(65.1852f, 51.53704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(59.62964f, 46f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(55.00001f, 42.59253f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(44.44444f, 40.67591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(33.88889f, 43.01859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(26.29629f, 46f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(19.07409f, 53.02774f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(16.85186f, 61.75929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(15.74074f, 74.96296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(17.22222f, 82.84254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(19.07409f, 93.06479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(26.11111f, 100.7315f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(35.18518f, 105.4166f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(44.44444f, 106.9075f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(54.81483f, 104.9908f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(65f, 98.81493f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(69.07407f, 85.82408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(79.25927f, 89.65746f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track5()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-74.81482f, 108.3982f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-65.00001f, 99.87971f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-54.25926f, 105.2037f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-42.77778f, 105.8427f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-32.03704f, 102.4352f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-26.48149f, 94.12958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-21.2963f, 87.10183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-18.70371f, 76.24084f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-19.25926f, 63.88901f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-24.07408f, 57.5f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-29.07408f, 49.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-38.51852f, 43.44451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-52.96297f, 44.08338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-64.25926f, 45.78704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-72.03704f, 53.02774f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-76.11112f, 65.59254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-76.85186f, 75.60183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-71.66667f, 88.59267f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-66.48149f, 98.60183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-76.85186f, 108.1852f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150.1852f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.7408f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-68.33334f, 96.04633f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.40741f, 89.4445f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-76.48149f, 75.17591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-75.37038f, 65.80563f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-69.62963f, 53.2407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-64.81482f, 46.63887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-59.25927f, 43.65746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.51852f, 42.80549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.62964f, 45.78704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-29.07408f, 51.11113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.5926f, 60.48155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-19.62963f, 70.4907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.70371f, 78.58338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-21.48148f, 86.88887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.03704f, 96.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.59259f, 104.7777f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-53.33334f, 105.4166f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.03704f, 103.9259f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.96297f, 96.04633f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.5926f, -14.69451f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-96.85186f, -26.40732f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.62964f, -36.20366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.74075f, -41.7407f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-84.07408f, -46.63887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-74.44445f, -50.47225f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.40741f, -50.2593f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.00001f, -45.78704f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.25927f, -41.10183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.70371f, -31.94451f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-40.92593f, -23.21296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-40f, -15.33324f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.14816f, -7.027746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.70371f, 4.259295f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.2963f, 11.07408f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-69.62963f, 13.84254f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-81.2963f, 11.5f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.81483f, 5.111126f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.03705f, -7.027746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.51853f, -21.2962f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-96.48149f, -28.75f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-21.2963f, -93.27775f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.74074f, -98.17591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10.18519f, -102.6482f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.962965f, -104.9907f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.518517f, -104.7777f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20f, -96.89817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(27.77778f, -88.59254f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.25926f, -83.90733f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(30.55557f, -79.86098f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.2963f, -74.53704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.25926f, -67.72225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(27.96296f, -63.25f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.37037f, -57.07408f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.81482f, -49.62042f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.74074f, -46.21296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.259254f, -43.65746f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.3703773f, -42.16662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.03704f, -45.57409f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-19.25926f, -50.68521f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.07408f, -59.41662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.85186f, -67.93521f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.77778f, -77.94437f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.18518f, -86.46296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.22222f, -93.70366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.11111f, -98.17591f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.74074f, -39.82409f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.77779f, -44.29634f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.85186f, -46f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(81.2963f, -44.72225f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.8889f, -42.16662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.62963f, -34.92591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.81483f, -27.47211f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.8519f, -19.80549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.8519f, -11.92592f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.4815f, -5.111126f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(97.96297f, 3.407465f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.37037f, 10.0093f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.07408f, 15.54634f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.37038f, 18.52775f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.66668f, 15.12042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(51.29631f, 9.58338f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.70372f, 1.490704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.74075f, -7.240704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45f, -15.97225f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.85185f, -28.32408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.37037f, -34.28704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.66668f, -40.67591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.22223f, -44.93507f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.37037f, -46.42591f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.85185f, 47.91662f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(34.07407f, 43.01859f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.7037f, 41.31493f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.51852f, 40.46296f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.11112f, 42.80549f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.40741f, 49.40746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.77779f, 56.64817f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.48148f, 66.65746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.96297f, 77.09267f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.2963f, 84.54633f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.22223f, 93.4907f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60.37038f, 101.5834f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.55557f, 105.4166f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.22223f, 106.6945f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(34.25927f, 102.8611f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(27.5926f, 99.2407f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.11111f, 94.76859f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.59259f, 83.26859f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.88889f, 77.9445f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.55556f, 67.72225f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.07409f, 57.5f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.59259f, 55.58338f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.11111f, 50.89817f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.74075f, 47.27774f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.14816f, 43.87042f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.66667f, 42.37972f));
            newareas.Add(new AreaModel("lol5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.29631f, 109.25f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.85185f, 105.8427f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.25926f, 96.68521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(76.11112f, 73.25929f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.03704f, 69f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.62965f, 64.52775f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.44446f, 63.67591f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.77779f, 70.27775f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.44445f, 70.4907f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.07409f, 73.25929f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.4815f, 81.13887f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.1111f, 87.31479f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(103.1482f, 94.98154f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(103.1482f, 102.2223f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.14816f, 107.7593f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(93.51853f, 110.102f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.1852f, 108.6111f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(83.7037f, 106.0556f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.44444f, 106.9075f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.33334f, 110.7407f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.62964f, 109.6759f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.51852f, 103.713f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.62964f, 95.83338f));
            newareas.Add(new AreaModel("lol6", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-99.07409f, 115f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-99.44446f, 109.25f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-96.2963f, 102.6482f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-96.66668f, 99.45366f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.07408f, 92.85183f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.48148f, 88.59267f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.44446f, 84.75929f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.51852f, 86.25f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.92594f, 88.80549f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.40741f, 88.37971f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.70371f, 104.1389f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.40741f, 108.3982f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.48149f, 114.3611f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.85186f, 115f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.51853f, 115f));
            newareas.Add(new AreaModel("lol7", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area8 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-93.51852f, -0.6388733f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.96297f, -20.87042f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.18519f, -29.38887f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.96297f, -35.9907f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.00002f, -38.97225f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.7037f, -54.94437f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-114.6296f, -50.0462f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.1111f, -48.34253f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125f, -48.76845f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.7408f, -50.89817f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-140.3704f, -46.21296f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-140.9259f, -41.52774f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-137.4074f, -31.51845f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-133.7037f, -29.38887f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-136.8519f, -24.06479f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-137.037f, -18.52775f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.6667f, -12.13887f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-134.0741f, -6.175915f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.2963f, 1.064789f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.2963f, 5.962958f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.5926f, 8.731549f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.3704f, 5.111126f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.1852f, -1.277747f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-107.7778f, -8.092535f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-96.48149f, -9.370422f));
            newareas.Add(new AreaModel("lol8", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area8),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area9 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.11111f, -83.90733f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.92593f, -85.18521f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.14816f, -92.85183f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.96296f, -97.53704f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.03704f, -102.0093f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.037035f, -104.1389f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.962961f, -114.787f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.8889f, -114.787f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-54.44445f, -111.1666f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.44445f, -110.9537f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50.92593f, -107.9723f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.00001f, -106.4814f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.40741f, -102.0093f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.40741f, -96.68521f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.18518f, -94.34254f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.70371f, -89.87042f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.25927f, -84.75929f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.51852f, -85.39817f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-31.2963f, -90.72225f));
            newareas.Add(new AreaModel("lol9", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area9),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area10 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.74074f, -57.71296f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.22224f, -50.0462f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(89.07408f, -45.57409f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(91.66669f, -38.97225f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.14816f, -34.28704f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.4815f, -26.19437f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.3704f, -31.73141f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(116.8519f, -35.9907f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.1852f, -39.61113f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.3333f, -44.29634f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.9259f, -51.32409f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.7408f, -57.92591f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.9259f, -62.39803f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.0741f, -62.61113f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.4445f, -71.76845f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(116.6667f, -79.22225f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(112.5926f, -81.9907f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105f, -82.41662f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.9259f, -81.35183f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(97.96297f, -84.33338f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.07409f, -86.03704f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(91.2963f, -85.18521f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(91.48148f, -78.37042f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.66667f, -74.96296f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(83.7037f, -72.1945f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.29631f, -65.80549f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80f, -63.67591f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(78.51853f, -58.13887f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.25927f, -50.0462f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(78.33335f, -47.70366f));
            newareas.Add(new AreaModel("lol10", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area10),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area11 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.5556f, 52.60197f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.2222f, 50.89817f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115f, 48.76845f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(116.2963f, 43.65746f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.4074f, 41.95366f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.5556f, 46.85183f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(123.8889f, 51.53704f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.2963f, 53.02774f));
            newareas.Add(new AreaModel("lol11", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area11),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area12 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(141.4815f, 92.21296f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(137.963f, 90.93521f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(137.2222f, 86.25f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(136.1111f, 80.5f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(138.7037f, 76.02775f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(143.8889f, 73.68521f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.4815f, 75.17591f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.5185f, 77.51845f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, 91.78704f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(144.0741f, 92.21296f));
            area12.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(140f, 91.78704f));
            newareas.Add(new AreaModel("lol12", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area12),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area13 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area13.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.1852f, 115f));
            area13.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.9259f, 110.7407f));
            area13.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.2222f, 107.7593f));
            area13.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(132.2222f, 105.2037f));
            area13.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(138.1481f, 107.9723f));
            area13.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(137.4074f, 115f));
            area13.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(126.1111f, 115f));
            newareas.Add(new AreaModel("lol13", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area13),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area14 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area14.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.0741f, 115f));
            area14.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-118.7037f, 111.3796f));
            area14.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.4074f, 107.5463f));
            area14.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-112.4074f, 106.2684f));
            area14.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-109.8148f, 109.6759f));
            area14.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.7408f, 112.6575f));
            area14.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.9259f, 115f));
            newareas.Add(new AreaModel("lol14", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area14),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area15 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.1111f, 50.68521f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.1852f, 48.76845f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.5185f, 47.06479f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.7037f, 40.46296f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-124.8148f, 37.69451f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.1482f, 37.26859f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.4074f, 28.53704f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.2222f, 28.53704f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-114.2593f, 31.51845f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-114.8148f, 37.48155f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.6667f, 47.06479f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-118.5185f, 49.62042f));
            area15.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.3334f, 49.83338f));
            newareas.Add(new AreaModel("lol15", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area15),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area16 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area16.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -104.1389f));
            area16.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, -114.787f));
            area16.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-139.6297f, -114.787f));
            area16.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-139.2593f, -108.8241f));
            area16.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-142.963f, -105.6296f));
            area16.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-145.9259f, -104.1389f));
            area16.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.037f, -104.5648f));
            newareas.Add(new AreaModel("lol16", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area16),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area17 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.3333f, -100.7314f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.8148f, -103.5f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-132.037f, -109.6759f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.7408f, -113.7221f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.4815f, -114.787f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.7778f, -114.787f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.3704f, -108.1852f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-112.2222f, -108.1852f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.1482f, -104.7777f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.5556f, -103.287f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.5556f, -97.11112f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-107.037f, -93.06479f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-112.963f, -91.36112f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.4815f, -93.91662f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.8148f, -98.38887f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.2593f, -101.7963f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.8519f, -100.3055f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130f, -103.713f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.4815f, -111.3796f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.3704f, -113.7221f));
            area17.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-118.5185f, -114.787f));
            newareas.Add(new AreaModel("lol17", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area17),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area18 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.74075f, -106.0556f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.14816f, -98.60183f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(58.14815f, -96.04633f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.14815f, -98.60183f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.03705f, -101.3703f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.81481f, -104.9907f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(76.2963f, -106.4814f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.5926f, -114.787f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.22222f, -114.787f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.25927f, -110.9537f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(51.29631f, -108.8241f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.5926f, -99.45366f));
            area18.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.07407f, -98.17591f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area18),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area19 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.66667f, 4.472253f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.88889f, -3.620422f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.70371f, -10.86113f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.7037f, -17.88887f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.33334f, -22.14817f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.703707f, -27.89817f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.07407f, -31.09254f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.888895f, -29.81479f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.33333f, -25.76845f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(24.25926f, -19.59254f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.7037f, -10.86113f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.11111f, -3.620422f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.62963f, 4.685211f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.44445f, 11.92592f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.85185f, 20.23155f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.59259f, 29.81479f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.96297f, 37.26859f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.5926f, 40.88887f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.222224f, 43.87042f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.07407f, 44.29634f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.85185f, 41.52774f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.51852f, 37.69451f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.96296f, 32.79634f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.00001f, 25.34254f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.40741f, 17.03704f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.48149f, 3.194507f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.51852f, -4.472253f));
            area19.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-29.81482f, -10.00916f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area19),Main.Empty(), 10, (AreaType)1));

            return newareas.ToArray();
        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                        "Path4",
                        "Path5",
                    }, ""), new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                        "Path4",
                        "Path5",
                    }, ""));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path1", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path2", track2(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path3", track3(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path4", track4(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path5", track5(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}