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

namespace custommaps.Maps
{
    class SpaceTruckin
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-100.5556f, -114.787f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-86.48149f, -94.98154f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-63.14816f, -41.95366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-57.59259f, -34.71296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-44.81482f, -30.2407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-32.96297f, -16.39817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-29.07408f, -3.620422f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-34.44445f, 14.69451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-46.85186f, 27.25929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-59.81482f, 31.51845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-71.48148f, 27.25929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-81.2963f, 18.31479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-87.40742f, 4.898169f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-87.40742f, -5.962958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-83.8889f, -20.23141f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-74.44445f, -29.38887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-62.77779f, -32.7962f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.74074f, -46.42591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-29.25926f, -54.51845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-6.666667f, -51.75f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(15f, -35.35183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.18519f, -10.00916f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.37037f, 10.86113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(16.66668f, 32.58338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.1851887f, 47.06479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-21.48148f, 53.87958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-41.85185f, 49.62042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-61.85186f, 31.51845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-77.5926f, 22.36113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.74075f, 6.601831f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.1852f, -10.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-79.62965f, -25.76845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-67.96297f, -31.73141f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-59.07408f, -33.86113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-43.14816f, -48.12958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-29.25926f, -53.2407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-10.92593f, -53.45366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-4.444448f, -50.2593f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(22.77779f, -67.93521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(40.92594f, -69.63887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(59.81482f, -64.95366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(73.33334f, -57.28704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(85.92593f, -47.06479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(93.51853f, -33.43521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(101.1111f, -12.77775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(97.5926f, 10.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(91.48148f, 33.22225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(80.1852f, 51.32409f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(67.22223f, 62.61113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(50.00001f, 69f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(34.25927f, 70.70366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(12.77778f, 65.37958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-4.07407f, 52.60197f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-21.85185f, 54.73155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-37.03704f, 50.04634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-54.62964f, 40.25f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-61.29631f, 31.73155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-77.22224f, 23.85197f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.55556f, 9.796338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-87.03705f, -4.898028f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-83.51852f, -20.65746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-70.55556f, -30.87958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-60.37038f, -33.64803f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.92593f, -47.06479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-31.66667f, -52.81479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-15.55555f, -54.09253f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-6.851856f, -51.11098f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(20.37038f, -66.65733f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(41.2963f, -69f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(52.40742f, -77.73141f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(98.14816f, -58.13887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(120f, -30.2407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(124.8148f, 6.601831f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(111.2963f, 45.14817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(86.66667f, 66.23154f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(55.92592f, 74.96296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(13.70371f, 72.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-11.29629f, 67.08338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-25.92593f, 69.63887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-42.77778f, 65.16662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-63.33334f, 78.15746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-74.44445f, 94.34254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-82.22223f, 115f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.8148f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.4445f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.4445f, 114.5741f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 20, (AreaType)2));
            //var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.96297f, 28.75f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-68.70371f, 25.55549f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-75.18519f, 21.29634f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.07409f, 15.7593f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-81.48149f, 7.66662f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.14816f, -1.277747f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.92594f, -11.07408f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.07409f, -17.67591f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.03704f, -25.98155f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-60.37038f, -31.09254f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.48149f, -31.09254f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-51.48148f, -35.9907f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.22223f, -44.93507f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.40741f, -48.55549f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.85186f, -49.19437f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-9.259264f, -47.91662f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.703702f, -45.36113f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.666667f, -54.94437f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.51851f, -59.41662f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(24.62964f, -63.88887f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(39.07409f, -65.59254f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.33334f, -64.10183f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(58.70371f, -61.12042f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.81482f, -58.13887f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.85186f, -52.38887f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80f, -43.87028f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.48149f, -33.43521f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.77778f, -35.35183f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.0741f, -33.64803f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(110.5556f, -28.75f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(116.6667f, -23.63887f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.2222f, -10.86113f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.963f, 2.981549f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(118.3334f, 18.31479f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(111.8519f, 26.40746f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.81483f, 31.73155f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.14816f, 30.66662f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.62964f, 36.41662f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.37038f, 43.87042f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.96297f, 56.22225f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60f, 61.97225f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.96296f, 64.52775f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(34.07407f, 67.29633f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.88889f, 64.10183f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.74075f, 59.20366f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.3703773f, 52.60197f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.259259f, 46.42591f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-14.25926f, 48.98155f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.25926f, 50.04634f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.22223f, 46f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.33334f, 39.61113f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.37038f, 32.15746f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.96297f, 28.75f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-68.8889f, 25.55549f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-76.48149f, 19.80563f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-82.03705f, 8.944507f));
            ////area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.70371f, -1.064789f));
            ////area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.33334f, -7.240704f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150f, -5.537042f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150f, -5.537042f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150f, -114.787f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1852f, -114.787f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150f, 114.787f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150f, 115f));
            //area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.6297f, -114.787f));
            //newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            //var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.8148f, -114.787f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.96297f, -114.787f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.55556f, -30.45366f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.22223f, -29.38887f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-75.18519f, -24.91662f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-82.03705f, -14.05549f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.70371f, -6.175915f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-82.96297f, 4.046338f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.44444f, 13.41676f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-74.44445f, 21.29634f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.77779f, 25.98155f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.48149f, 28.11113f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.11112f, 115f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            //area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.6297f, -114.787f));
            //newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            //var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.92592f, 62.18521f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.333333f, 45.57409f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.77778f, 30.66662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.18518f, 13.84254f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.55556f, -9.796338f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.2963f, -23f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.703697f, -35.13887f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.9259344f, -43.65746f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.592597f, -46f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.037045f, -55.79634f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.814812f, -51.96296f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.96296f, -53.02774f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(14.07407f, -47.06479f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(14.07407f, -42.16662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.37036f, -36.20366f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.77777f, -28.96296f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.66667f, -22.36099f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.37037f, -19.59254f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.11111f, -14.90746f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(27.77778f, -11.28704f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.44445f, -11.07408f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.81481f, -16.61113f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.40742f, -12.35183f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(34.62963f, -6.601831f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.66668f, -3.83324f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(38.88889f, -3.194507f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(40.37038f, 0.851831f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.14815f, 1.91662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.55555f, 3.407465f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45f, 6.814789f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.37038f, 13.20366f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.51852f, 18.52775f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.40742f, 18.95366f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.00001f, 20.44451f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.37038f, 24.7038f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.62963f, 29.17591f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.37038f, 30.66662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.81483f, 35.13901f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.07407f, 38.12042f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.88889f, 44.29634f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.66668f, 49.62042f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.07409f, 51.11113f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60.74074f, 52.60197f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.59259f, 52.81479f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.7037f, 51.32409f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.59259f, 47.70366f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.22223f, 45.57409f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.7037f, 43.87042f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(65f, 41.31493f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(65.92593f, 36.41662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.8889f, 34.28704f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.55557f, 30.87972f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.51853f, 29.60183f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.55556f, 25.34254f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.92594f, 21.72225f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.5926f, 19.16662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(78.14816f, 15.54634f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.70371f, 13.62972f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.74075f, 8.731549f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.14816f, 7.66662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.66667f, 4.685211f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.33334f, 3.620422f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.62964f, 1.277887f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.37038f, 0.4259155f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.74075f, -0.6388733f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.96296f, -1.703662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(44.62964f, -0.6388733f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.55555f, -2.555493f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.55555f, -4.685211f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.7037f, -6.388873f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.7037f, -9.58338f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.2963f, -10.64817f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(40.37038f, -14.26845f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.48149f, -16.39817f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.8889f, -16.61113f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.48149f, -13.62958f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.81481f, -12.56479f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.18519f, -15.33324f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.96296f, -18.95366f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.29631f, -20.87042f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.66667f, -23.21296f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.77778f, -24.27775f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.77778f, -30.2407f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.62963f, -32.58324f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(51.11113f, -31.09254f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.96297f, -32.15746f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.77778f, -36.62958f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.55557f, -39.18521f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.55557f, -40.03704f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.18519f, -40.46296f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.48148f, -37.90732f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(57.96297f, -42.37958f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.85186f, -45.14817f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.2963f, -44.93507f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.25926f, -55.79634f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.29631f, -56.00929f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.29631f, -53.02774f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.40741f, -51.96296f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.59259f, -48.98141f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(39.25927f, -56.22211f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.33334f, -56.00929f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.11111f, -59.41662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.00001f, -58.77774f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.25927f, -54.73155f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.25927f, -54.73155f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(58.51853f, -52.60183f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60.74074f, -53.66662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.44445f, -56.43521f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.62964f, -58.35183f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.14815f, -58.9907f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.88889f, -48.76845f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.74075f, -48.34253f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.77779f, -46.85183f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.62963f, -41.7407f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.48149f, -41.31479f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.8889f, -40.03704f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.77779f, -36.41662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.81482f, -30.66662f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.59261f, -31.51845f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.62963f, -35.13887f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.62963f, -39.61113f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.74075f, -40.03704f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.51853f, -36.20366f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.2963f, -33.22225f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.77778f, -31.94451f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.00002f, -26.83338f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.48148f, -25.98155f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.70371f, -28.96296f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(78.14816f, -30.45366f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(81.2963f, -32.37042f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.1852f, -35.77774f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.40741f, -31.73141f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.74074f, -27.47211f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.5926f, -25.12958f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.5926f, -22.36099f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(74.44445f, -19.37958f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.14816f, -18.52775f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(74.07407f, -14.69451f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.03704f, -10.43521f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.25927f, -10.43521f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.74074f, -11.07408f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.92594f, -15.97225f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.25926f, -17.03704f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.85187f, -20.01845f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.37037f, -22.78704f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.40742f, -15.33324f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.14816f, -15.54634f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.55556f, -14.69451f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.22223f, -11.07408f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.1852f, -10.22225f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80f, -4.472253f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.77779f, 0.2129578f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.11111f, 5.324084f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.37037f, 6.814789f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.96297f, 8.305634f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.40742f, 14.69451f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.92593f, 35.35183f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.00001f, 51.11113f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.59259f, 60.48155f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60.37038f, 61.33338f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.07409f, 59.84267f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.48149f, 56.00929f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60.55556f, 52.38887f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.55556f, 55.15746f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(51.48148f, 57.71296f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.7037f, 60.05549f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.14816f, 58.35183f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.14816f, 61.12042f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.96297f, 58.56479f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.07409f, 58.9907f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.74074f, 62.39817f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.85186f, 62.18521f));
            //area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.962965f, 46.42591f));
            //newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 50, (AreaType)1));

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