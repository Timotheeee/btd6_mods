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
    class MonkeysInSpace
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.963f, -18.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-112.2222f, -34.07409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-105.7408f, -41.31479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100.5556f, -50.68521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-98.14816f, -64.31479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-98.70371f, -72.83324f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-101.8519f, -74.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-105.1852f, -72.83324f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-111.6667f, -66.23154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-114.8148f, -55.79634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-114.0741f, -41.95366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.7037f, -30.2407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-95.18519f, -24.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-84.25926f, -19.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.37038f, -18.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-61.66668f, -21.2962f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-51.85185f, -25.98155f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-42.22223f, -32.15746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32.22223f, -38.97225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-26.2963f, -48.12958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-23.51852f, -57.92591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-23.33333f, -67.08338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.55556f, -72.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-29.07408f, -73.68507f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-33.33334f, -73.25929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-37.22223f, -69.85183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-40.55556f, -59.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-42.03704f, -49.19437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.81482f, -33.64803f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-23.51852f, -23.63887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-12.5926f, -20.65746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-2.592597f, -20.44437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(10.92593f, -24.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(22.77779f, -30.45366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(33.51851f, -37.26845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.88889f, -46.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.88889f, -47.4907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(41.48149f, -55.58338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(42.03705f, -63.88887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(40.74074f, -68.36112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(39.25927f, -74.96296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(35.55556f, -74.96296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(31.2963f, -72.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25f, -62.61113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(24.44444f, -51.32409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(27.96296f, -39.82409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(35.74074f, -31.09254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(43.14815f, -25.76845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(53.70371f, -21.93521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(65.92593f, -19.80549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(77.77779f, -22.57408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(88.70372f, -28.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(95.37038f, -33.22225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(102.4074f, -38.12042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(107.7778f, -41.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(112.963f, -51.96296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(114.6296f, -60.6945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(114.2593f, -68.78704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(112.4074f, -74.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(108.1482f, -75.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(101.8519f, -69.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(98.51853f, -56.43521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(98.14816f, -44.5093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(106.1111f, -36.20366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(110.7408f, -29.38887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(119.0741f, -23f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(126.4815f, -20.65746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(137.5926f, -18.95366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.963f, -20.65746f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.7778f, 23.63887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-121.2963f, 31.51845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-113.5185f, 37.05563f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-105.5556f, 45.36113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100.3704f, 56.64817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-97.96297f, 66.65746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-98.8889f, 77.51845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-102.963f, 78.79633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-109.6296f, 74.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-113.3333f, 64.52775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-113.8889f, 54.94451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-111.4815f, 44.29634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-105f, 36.84253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-94.62964f, 30.45366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-83.70371f, 26.83338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-71.48148f, 28.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-55.74074f, 30.87972f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-43.70371f, 37.48155f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-37.96297f, 41.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-31.48148f, 46.85183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.74074f, 54.94451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.62963f, 62.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.00001f, 70.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.55556f, 77.51845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-30f, 78.58338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.81482f, 75.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-39.25927f, 67.08338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-40.92593f, 53.4538f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-36.48149f, 41.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-28.14815f, 33.0093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-18.14815f, 28.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.037035f, 28.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(5.370373f, 29.38887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(18.70371f, 34.71296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.7037f, 40.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(37.59259f, 49.19451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(40.55556f, 60.48155f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(40.74074f, 71.76859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(37.77777f, 78.15746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(33.33334f, 77.73154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(27.96296f, 70.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(24.62964f, 52.38887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.14816f, 41.52774f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(37.96297f, 33.0093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(45.55555f, 30.02789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(57.40741f, 25.34254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(63.14815f, 23.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(73.14816f, 24.06479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(80.92594f, 28.11113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(90.74075f, 33.0093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(98.88889f, 38.12042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(106.6667f, 43.44451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(112.037f, 51.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(114.8148f, 65.59254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(113.5185f, 73.25929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(111.2963f, 76.66662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(106.2963f, 77.9445f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(99.07409f, 67.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(98.51853f, 51.11113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(101.6667f, 40.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(108.5185f, 33.22225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(122.4074f, 26.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(137.5926f, 24.06479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.5926f, 25.55549f) });
            return list.ToArray();
        }







        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.8148f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.6296f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1852f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.6297f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, 18.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-122.7778f, 24.91676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.6296f, 34.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.1111f, 23.85197f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-87.59261f, 19.59268f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.1852f, 19.37958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.70371f, 26.62042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.8889f, 33.0093f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.40741f, 34.07409f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.48148f, 27.04634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.44444f, 22.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.074075f, 20.01845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.11111f, 20.87042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.03703f, 26.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.8889f, 33.86113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.40741f, 28.53704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.44445f, 20.87042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.7037f, 17.46296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.40742f, 18.74084f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.74075f, 23.63887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.1111f, 31.94451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.0741f, 25.76859f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(128.5185f, 19.80563f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(143.7037f, 18.31479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.5185f, 18.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.0741f, 31.94451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.8519f, 31.30549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.1852f, 39.61113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.4815f, 55.37042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.4445f, 67.08338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.4074f, 80.71296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.4074f, 84.75929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.6667f, 80.28704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.11112f, 71.98154f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.51853f, 47.91662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.62963f, 40.25f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.81483f, 31.09267f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.62963f, 31.09267f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.40741f, 39.61113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.74074f, 47.49084f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.14815f, 53.87958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.37038f, 63.88901f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.51852f, 79.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.51853f, 84.75929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.96296f, 84.12042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.29629f, 77.09267f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.92594f, 65.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.55556f, 52.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.2963f, 42.16676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.55556f, 38.7593f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.111114f, 33.0093f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.07408f, 33.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.81482f, 35.35183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.55556f, 40.88887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.07408f, 40.46296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-21.48148f, 59.62971f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.18519f, 68.36112f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.77778f, 79.86112f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.22223f, 84.54633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 81.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.51852f, 70.06493f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.18518f, 52.81479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.07408f, 43.01859f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.70371f, 41.52774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.85185f, 38.33338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.74075f, 33.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-77.96297f, 30.02789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-91.2963f, 33.64817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.5926f, 40.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.8889f, 48.12958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-95.37038f, 58.77789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.62964f, 77.09267f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.2963f, 84.33338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.2963f, 79.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-116.6667f, 65.37958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.963f, 48.12958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115.5556f, 41.31493f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-123.1482f, 34.92591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-135.7408f, 30.02789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, 27.68521f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.4445f, 48.12958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.2963f, 53.2407f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.7408f, 60.90746f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.5185f, 68.14817f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.3704f, 73.47225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.4074f, 74.96296f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.1111f, 69.85183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.4815f, 63.46296f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-103.5185f, 54.94451f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-107.7778f, 48.12958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110f, 49.19451f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 150, (AreaType)2));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.81482f, 47.49084f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 49.83338f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, 57.07408f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, 64.7407f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.77778f, 71.98154f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.81482f, 75.17591f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.51852f, 73.68521f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.40741f, 69.21296f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.59259f, 63.25f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.25926f, 56.86113f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.85185f, 49.83338f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.81482f, 47.70366f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.22223f, 50.04634f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.77778f, 57.92591f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 150, (AreaType)2));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.07408f, 48.98155f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.22223f, 56.43521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.25926f, 63.67591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.11111f, 69.85183f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.44445f, 74.96296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.2963f, 75.81479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.77777f, 72.40746f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.88889f, 66.23154f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.66668f, 55.58338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.51851f, 49.62042f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.74075f, 48.12958f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.5926f, 53.02774f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 150, (AreaType)2));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.7778f, 47.91662f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.5556f, 53.66676f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.4074f, 63.67591f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(105f, 71.55549f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.3333f, 74.53704f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.2963f, 75.17591f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.037f, 65.37958f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.2963f, 57.28704f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.4815f, 48.12958f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.3333f, 47.06479f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.0371f, 48.76845f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5), 150, (AreaType)2));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, -14.05549f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-131.4815f, -17.03704f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.8148f, -29.38887f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-96.85186f, -19.59254f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-74.62964f, -15.54634f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.74075f, -17.67591f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.88889f, -21.72225f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.40741f, -30.45366f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.18519f, -22.14817f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.22223f, -18.31479f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-4.07407f, -15.54634f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.37037f, -19.16662f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.55555f, -27.47211f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.25926f, -30.2407f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.14815f, -23.42591f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.07408f, -17.46296f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.1852f, -13.84254f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.07409f, -16.39817f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.77778f, -22.36099f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.8519f, -28.75f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.037f, -23.21296f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.7037f, -18.10183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(134.8148f, -15.97225f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.3333f, -15.54634f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.7037f, -26.62028f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(125.3704f, -28.53704f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.5185f, -29.60183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.8148f, -36.41662f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.8889f, -43.01845f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.5185f, -52.60183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.4445f, -64.7407f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.2963f, -75.81479f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8519f, -79.86098f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(104.2593f, -78.15746f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.22224f, -71.76845f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.81483f, -61.97225f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.70371f, -47.06479f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.81483f, -37.05549f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.88889f, -26.40732f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.1852f, -25.34254f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.33334f, -26.40732f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.77779f, -31.73141f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.66668f, -35.77774f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.66668f, -35.77774f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(40f, -41.7407f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.8889f, -49.40746f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.1852f, -58.9907f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(45f, -67.50916f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.85185f, -76.66662f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.14815f, -79.64817f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.51851f, -79.22225f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.18519f, -72.83324f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.66667f, -64.52775f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.92594f, -54.51845f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.03703f, -38.97225f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.185194f, -29.38887f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.407404f, -27.47211f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.22223f, -30.66662f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.37037f, -35.9907f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.70371f, -37.69437f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.96297f, -49.19437f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.55556f, -57.28704f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.81482f, -67.29633f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.22222f, -77.09254f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.03704f, -80.71296f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.7037f, -78.7962f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.14816f, -69.85183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.74074f, -57.28704f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.88889f, -37.90732f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.85185f, -32.58324f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.07408f, -28.75f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-78.51853f, -25.55549f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.40742f, -29.81479f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.7408f, -35.9907f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-95.55556f, -55.37028f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.33334f, -68.78704f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-95.92593f, -77.30563f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.6667f, -80.71296f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.3333f, -76.45366f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115.1852f, -68.78704f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.5185f, -57.28704f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115.7408f, -36.62958f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-127.4074f, -29.17591f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-144.6296f, -26.83338f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, -24.27775f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-141.8519f, -24.4907f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.4074f, -25.98155f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, -23.85183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, -15.54634f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.6296f, -42.37958f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.4815f, -48.34253f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.7408f, -60.6945f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-107.037f, -66.65733f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-103.5185f, -70.4907f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.1111f, -69.85183f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.3704f, -63.03704f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.4074f, -53.66662f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.0741f, -46.85183f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.3333f, -41.95366f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7), 150, (AreaType)2));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.18518f, -42.16662f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.85186f, -44.72225f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.77778f, -48.98141f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.22223f, -56.86113f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.11111f, -63.46296f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.44445f, -67.50916f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30f, -70.91662f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.14815f, -70.70366f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.22223f, -64.52775f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.8889f, -56.64817f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.48148f, -48.55549f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.00001f, -43.01845f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8), 150, (AreaType)2));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.18519f, -43.65746f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.14816f, -47.27774f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.33334f, -54.09253f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.62963f, -61.75929f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.5926f, -67.72225f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.66668f, -72.1945f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.70371f, -67.93521f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.40741f, -58.56479f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.81483f, -47.91662f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.92593f, -43.44451f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9), 150, (AreaType)2));
            var areaA = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.5185f, -43.23141f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.9259f, -47.70366f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.8519f, -56.64817f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.7778f, -64.7407f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.1111f, -70.91662f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.5556f, -70.70366f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.2222f, -66.01845f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.6667f, -57.5f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.7037f, -51.32409f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.2963f, -44.93507f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.963f, -41.10183f));
            newareas.Add(new AreaModel("lolA", new Assets.Scripts.Simulation.SMath.Polygon(areaA), 150, (AreaType)2));
            var areaB = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-141.8519f, 67.93521f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-124.6296f, 82.62958f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-128.8889f, 87.95366f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-122.4074f, 96.47225f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-131.8519f, 105.6296f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.2222f, 99.87971f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-132.7778f, 92.42591f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, 78.15746f));
            areaB.Add(new Assets.Scripts.Simulation.SMath.Vector2(-141.1111f, 67.72225f));
            newareas.Add(new AreaModel("lolB", new Assets.Scripts.Simulation.SMath.Polygon(areaB), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var areaC = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.18519f, 25.55549f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.22223f, 24.27775f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.2963f, 16.39817f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.77779f, 16.18521f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.88889f, 1.064789f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.74075f, 4.046338f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.03705f, -11.71296f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40f, -25.55549f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.11111f, -11.92592f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.96297f, -15.54634f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.85186f, -17.46296f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.074075f, 10.64817f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.33334f, 18.95366f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-21.2963f, 14.90746f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.03704f, 20.44451f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.74074f, 13.62972f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.51852f, 14.26859f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.81482f, 24.7038f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.96297f, 23.21296f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.22223f, 15.7593f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.96297f, 14.90746f));
            areaC.Add(new Assets.Scripts.Simulation.SMath.Vector2(-55.00001f, 1.490704f));
            newareas.Add(new AreaModel("lolC", new Assets.Scripts.Simulation.SMath.Polygon(areaC), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var areaD = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.7778f, -95.62042f));
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.5556f, -98.38887f));
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-114.0741f, -110.3148f));
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.7037f, -114.787f));
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.1852f, -114.787f));
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140.3704f, -108.1852f));
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-134.0741f, -98.38887f));
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-121.8519f, -106.0556f));
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.7778f, -96.89817f));
            areaD.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.037f, -98.38887f));
            newareas.Add(new AreaModel("lolD", new Assets.Scripts.Simulation.SMath.Polygon(areaD), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var areaE = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaE.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.7408f, 115f));
            areaE.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.70371f, 108.6111f));
            areaE.Add(new Assets.Scripts.Simulation.SMath.Vector2(104.4445f, 98.60183f));
            areaE.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.4815f, 113.9352f));
            areaE.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.3704f, 115f));
            areaE.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.9259f, 115f));
            newareas.Add(new AreaModel("lolE", new Assets.Scripts.Simulation.SMath.Polygon(areaE), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var areaF = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaF.Add(new Assets.Scripts.Simulation.SMath.Vector2(125.1852f, -92.42591f));
            areaF.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.3334f, -103.0741f));
            areaF.Add(new Assets.Scripts.Simulation.SMath.Vector2(131.1111f, -114.1482f));
            areaF.Add(new Assets.Scripts.Simulation.SMath.Vector2(144.6296f, -114.787f));
            areaF.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.8889f, -107.9723f));
            areaF.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.1111f, -98.38887f));
            areaF.Add(new Assets.Scripts.Simulation.SMath.Vector2(139.8148f, -104.3518f));
            areaF.Add(new Assets.Scripts.Simulation.SMath.Vector2(126.1111f, -92.42591f));
            areaF.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.7037f, -101.3703f));
            newareas.Add(new AreaModel("lolF", new Assets.Scripts.Simulation.SMath.Polygon(areaF), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var areaG = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaG.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.81481f, 13.41676f));
            areaG.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.18518f, -4.259295f));
            areaG.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.22222f, -13.84254f));
            areaG.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.96296f, -5.324084f));
            areaG.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.70372f, 11.71296f));
            areaG.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.03704f, 19.59268f));
            areaG.Add(new Assets.Scripts.Simulation.SMath.Vector2(15f, 13.41676f));
            newareas.Add(new AreaModel("lolG", new Assets.Scripts.Simulation.SMath.Polygon(areaG), 10, (AreaType)1));

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