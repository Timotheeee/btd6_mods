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

namespace custommaps.Maps
{
    class AGame
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(1.481474f, -114.3611f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(1.666671f, -106.6944f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(11.2963f, -104.9907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25f, -101.7963f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.70371f, -96.89817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(52.40742f, -89.87042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(63.8889f, -80.71296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(71.11113f, -72.40746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(81.48149f, -58.35183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(88.33334f, -44.93507f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(93.51853f, -27.47211f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(96.4815f, -10.00916f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(96.85186f, 5.75f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(92.22222f, 25.34254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(84.81482f, 43.44451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(74.25927f, 59.84267f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(64.81482f, 71.12971f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.18519f, 83.05549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(29.62963f, 92.21296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(15.18518f, 96.47225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(1.666671f, 97.96296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-10.74075f, 97.11112f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-33.51852f, 93.7038f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-47.40741f, 86.03704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-60.55556f, 76.66662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-77.40742f, 60.26845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-87.59261f, 44.29634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-94.81483f, 24.91676f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-97.77779f, 9.796338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-98.33334f, -16.39817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-94.25927f, -36.84253f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-87.77779f, -51.96296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.00001f, -69.63887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-66.11112f, -79.86098f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-54.25926f, -89.23141f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.44445f, -100.3055f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.88889f, -105.6296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.037035f, -106.2684f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.407404f, -114.787f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-127.7778f, -114.787f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(96.66668f, -4.685211f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-2.222219f, 44.5093f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-3.518522f, -54.94437f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(96.11112f, -5.537042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-140.7408f, 113.5093f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.4445f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.2593f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.7037f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.1852f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.444438f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.444438f, -107.5462f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.77779f, -97.75f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(60f, -86.25f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.51853f, -72.83324f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.44446f, -58.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.70371f, -39.61113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.96297f, -17.88887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.51853f, 6.814789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.51853f, 31.30549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.55556f, 56.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.81482f, 74.75f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.74075f, 88.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.55555f, 97.11112f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.3703773f, 101.1575f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.55556f, 97.32408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.14815f, 88.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.77779f, 74.32408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-87.03705f, 50.04634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.70371f, 22.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.4815f, 0.6388733f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.14816f, -29.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-87.77779f, -54.94437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.66667f, -78.15746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.81482f, -88.37958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.48149f, -100.7314f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.44445f, -106.6944f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.629632f, -106.6944f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.444444f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-4.259259f, -114.3611f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-6.296299f, -103.713f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.51852f, -90.50929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.25927f, -75.60183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-87.59261f, -45.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.81483f, -25.34254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.03705f, -6.175915f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.96297f, 23f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-84.44445f, 42.80549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.8889f, 65.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.55556f, 80.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.44444f, 90.29633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.888882f, 94.98154f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.07408f, 83.48154f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.74075f, 62.61113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.03705f, 34.71296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.14816f, 7.027746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.03704f, -24.70366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.00001f, -64.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(58.14815f, -81.56479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.07408f, -99.45366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.1851797f, -103.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-0.7407368f, -113.9352f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-122.4074f, -114.787f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.44445f, -6.388873f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.25927f, -2.129578f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.037f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-142.2222f, 112.0186f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-4.444448f, 43.65746f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.000005f, -52.60183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.2963f, -4.472253f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(0f, 39.82409f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(0f, -49.62042f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-132.4074f, -114.3611f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));

            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            var moab = new MoabOnlySplitterModel("", new string[]
                    {
                        "Path",
                        "Path (1)",
                    }, new bool[] {
                        false,
                        true
                    });


            return new PathSpawnerModel("", moab, moab);
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (1)", track2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }
    }
}