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
    class WaterHazard
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.963f, 103.5f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-141.8519f, 100.0925f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-136.2963f, 94.98154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-131.1111f, 86.88887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-127.963f, 74.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-126.8519f, 60.6945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-126.1111f, 53.4538f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-123.8889f, 43.44451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-122.4074f, 32.79634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-123.7037f, 19.37958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-124.4445f, 8.944507f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-123.1482f, 2.981549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-119.2593f, -1.064789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-117.5926f, -11.5f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-117.4074f, -27.25929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-115.9259f, -31.94451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-120.1852f, -47.70366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-121.1111f, -59.84253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-118.8889f, -72.1945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-112.5926f, -83.48154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-104.8148f, -90.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-96.2963f, -95.40733f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-89.07408f, -95.62042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-81.2963f, -92.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-74.81482f, -84.75929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-69.81483f, -73.47225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-64.44445f, -58.35183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-59.44445f, -50.68521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-55.92593f, -35.9907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-56.2963f, -24.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-58.51853f, -14.05549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-64.62964f, -1.490704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-67.40742f, 2.981549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-68.33334f, 13.62972f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-69.81483f, 25.98155f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-72.03704f, 35.77774f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-72.77779f, 44.93521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-69.81483f, 59.62971f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-66.66667f, 75.81479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-57.03704f, 85.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-47.59259f, 91.36112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-36.66667f, 91.36112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-29.25926f, 89.4445f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-19.44444f, 87.95366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.222224f, 88.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.222224f, 19.59268f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-14.62963f, 12.56493f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-20.92593f, -1.064789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-20.74075f, -7.66662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-15.18518f, -12.35183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.592592f, -17.03704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.592592f, -72.83324f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-23.51852f, -80.28704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-30.74075f, -88.37958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-36.85186f, -99.2407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-39.81482f, -102.6482f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-45.00001f, -109.8889f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-55.37038f, -114.787f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.963f, 102.2223f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(136.1111f, 96.25929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(130.5556f, 90.50929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(126.1111f, 84.75929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(123.8889f, 78.37042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(124.4445f, 69.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(125.7408f, 62.61113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(125f, 52.81479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(122.2222f, 38.97225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(118.7037f, 28.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(116.6667f, 18.74084f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(117.963f, 7.240704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(117.2222f, -3.620422f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(115.3704f, -12.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(113.8889f, -21.50929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(114.6296f, -31.09254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(118.7037f, -43.01845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(121.1111f, -54.30549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(121.6667f, -66.23154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(116.2963f, -77.94437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(108.7037f, -84.75929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(100.5556f, -88.59254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(93.33334f, -89.87042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(84.25926f, -88.80563f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(70.55557f, -83.90733f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(61.66668f, -73.68507f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(58.33333f, -65.16662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(56.48148f, -56.86113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(56.2963f, -44.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(57.22224f, -34.92591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(56.2963f, -24.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(55.55556f, -13.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(56.85186f, -3.407465f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(64.81482f, 17.67591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(69.62963f, 32.37042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(70.37037f, 41.52774f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(68.51852f, 51.11113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(64.07408f, 62.82408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(58.88889f, 69.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.00001f, 74.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(36.85186f, 79.43521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25.92593f, 83.48154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(12.77778f, 87.31479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(8.148141f, 87.52789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(8.148141f, 18.74084f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(13.14815f, 16.61113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(17.59259f, 13.41676f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.25926f, 6.175915f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(20.18518f, -0.6388733f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(17.03703f, -9.58338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(14.25927f, -13.20366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(7.962961f, -16.39817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(7.962961f, -71.98141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(16.2963f, -74.11112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.14816f, -77.51845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(37.22223f, -84.33338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(46.66667f, -93.06479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(53.51852f, -100.7314f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(63.8889f, -106.2684f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(71.48148f, -109.8889f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(74.81483f, -114.787f) });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.8148f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.2593f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1852f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.1852f, -114.787f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.962961f, 8.518591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.592592f, 98.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.000005f, 99.66676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.111114f, 98.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.037031f, 97.75f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.370373f, 99.87971f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.592601f, 99.87971f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.962961f, 13.41676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.74075f, 12.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.77778f, 10.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.5926f, 8.305634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.444452f, 5.75f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.518517f, 5.75f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.851847f, 7.027746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.999996f, 8.092535f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.703702f, 8.944507f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-0.1851887f, 9.796338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.370373f, 7.240704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.592592f, 6.814789f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.592592f, -8.944366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.592592f, -85.82408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.92593f, -86.67591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.222219f, -85.18521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.407408f, -85.39817f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.185194f, -86.88887f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.148141f, -86.67591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.962961f, -9.157324f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.296289f, -7.66662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.814816f, -7.453662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.148145f, -9.796338f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.3703773f, -10.00916f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.962965f, -7.66662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-6.851856f, -7.66662f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.44446f, 115f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.48149f, 111.1668f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.81482f, 109.6759f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.92593f, 108.3982f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.81482f, 106.9075f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.66667f, 106.0556f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.11111f, 104.5648f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.70372f, 104.9908f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.48149f, 100.3055f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.44446f, 101.5834f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.25928f, 99.02775f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.48148f, 100.7315f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.2963f, 97.75f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.14816f, 99.45366f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.62963f, 97.11112f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.03704f, 94.34254f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.44445f, 94.34254f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.9259f, 93.4907f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.963f, 92.85183f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.8889f, 94.12958f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.1111f, 96.47225f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.4074f, 97.96296f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.5185f, 98.38887f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.1852f, 99.02775f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.1482f, 98.60183f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.6296f, 99.2407f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.2222f, 100.5186f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.8148f, 103.0741f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.2963f, 106.2684f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.1111f, 109.25f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.6667f, 114.1482f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.44446f, 115f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, 102.6482f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-133.5185f, 90.29633f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.7408f, 84.54633f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-126.8519f, 71.12971f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-126.8519f, 57.28704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-123.7037f, 44.08338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-122.5926f, 24.7038f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-124.2593f, 8.518591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-122.4074f, 2.129718f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.2222f, -11.28704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.7778f, -25.12958f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-116.2963f, -32.15746f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.5185f, -43.87028f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-121.2963f, -52.81479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120f, -70.06479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115f, -81.56479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.7408f, -90.08324f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.40742f, -95.19437f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-90.1852f, -95.19437f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.81483f, -92.21296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-73.33334f, -81.35183f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.11112f, -63.25f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.03704f, -54.30549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.70371f, -48.55549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-55.92593f, -37.90732f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-56.85186f, -26.62028f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-57.96297f, -14.48141f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.33334f, -4.685211f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.96297f, 7.240704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.8889f, 16.39817f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70f, 25.12958f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.85186f, 35.9907f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-72.03704f, 51.53704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.44446f, 61.54634f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.66667f, 74.11112f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.44445f, 82.2038f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.22223f, 88.80549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.44445f, 90.93521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.92593f, 92.63902f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.00001f, 90.93521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.03704f, 88.80549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.07408f, 88.37971f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.148149f, 88.59267f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10f, 18.74084f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.77778f, 15.33338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.33334f, 8.518591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.55556f, -0.851831f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.81482f, -9.157324f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.37037f, -11.71296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.259264f, -16.18507f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.407404f, -16.82408f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.777781f, -73.25929f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15f, -75.38887f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.7037f, -80.07408f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.85185f, -89.4445f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, -101.5832f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.92593f, -106.9075f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.03704f, -112.4444f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.55556f, -114.787f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, -114.787f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.963f, 102.6482f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)1));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.2222f, 102.0093f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(137.5926f, 97.32408f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.1852f, 89.87042f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(125f, 83.48154f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.1482f, 74.96296f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.4445f, 66.01859f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(125.9259f, 57.92591f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(122.7778f, 42.37972f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.8889f, 31.73155f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.8519f, 19.37958f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.0371f, 8.731549f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.963f, -0.6388733f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.4445f, -12.35183f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.3333f, -19.59254f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(115f, -32.15746f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.5185f, -43.65746f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(122.4074f, -59.20366f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.8148f, -70.27775f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.3704f, -84.75929f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.25928f, -90.50929f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(80f, -87.31479f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.70372f, -82.20366f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.2963f, -71.34254f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.40741f, -59.84253f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.2963f, -46f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.22224f, -31.30563f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.62963f, -17.88887f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.03704f, -2.768451f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.77779f, 15.54634f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(67.96297f, 28.11113f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.00002f, 42.37972f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.85187f, 58.13887f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.22224f, 70.70366f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.14815f, 77.73154f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.00001f, 81.77775f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.37038f, 84.97225f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.222224f, 87.7407f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.333338f, 19.37958f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.96296f, 16.61113f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.85186f, 14.05549f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(19.81482f, 2.342676f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(18.33333f, -6.601831f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.62963f, -13.20366f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.333338f, -16.39817f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.518517f, -71.12958f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.18518f, -73.89817f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.14815f, -76.02775f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.25927f, -81.56479f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.85185f, -88.16662f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.81481f, -97.32408f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.07409f, -102.4351f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.66667f, -107.7593f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.11113f, -114.787f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, -114.787f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, 102.2223f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5), 10, (AreaType)1));

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