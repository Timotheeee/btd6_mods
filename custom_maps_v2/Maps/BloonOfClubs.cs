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
    class BloonOfClubs
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32.03704f, 115f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-22.96297f, 103.5f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-17.59259f, 93.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-14.25926f, 84.33338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.14815f, 70.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-19.07408f, 76.66662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-27.96296f, 82.41676f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-37.96297f, 85.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-52.22223f, 86.67591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-61.66668f, 84.54633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-70.74075f, 80.92591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-77.77779f, 74.96296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-84.25926f, 66.4445f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-88.33334f, 58.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-90.74075f, 50.68521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-92.03704f, 41.52774f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-92.03704f, 32.58338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-89.81483f, 18.95366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-85.00001f, 6.601831f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-79.25927f, -1.490704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-73.14816f, -6.814789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-66.66667f, -11.07408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-58.51853f, -14.48141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-51.11111f, -15.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-41.66667f, -16.18507f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-45.37038f, -28.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-46.66667f, -39.61113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-45.92593f, -47.91662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-43.51852f, -57.07408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-38.70371f, -68.36112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.25926f, -74.75f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-28.70371f, -81.13887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-20.18519f, -87.52775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-10.55556f, -90.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.1851887f, -91.36112f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(12.40742f, -88.37958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(20.37038f, -83.48154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(29.44445f, -73.47225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(36.2963f, -63.67591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(40.37038f, -48.76845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(39.62964f, -29.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(36.66668f, -15.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(45.92593f, -15.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(58.14815f, -12.77775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(67.03705f, -7.027746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(75.18519f, 1.064789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(83.14815f, 15.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(86.48149f, 32.37042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(85.1852f, 48.76845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(81.11111f, 61.75929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(72.77778f, 73.89817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(60.92594f, 83.26859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(51.11113f, 86.67591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(39.62964f, 87.31479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25f, 84.97225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(12.5926f, 75.60183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(7.037045f, 69.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(9.814812f, 87.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(21.11111f, 108.1852f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.14816f, 115f) });
            return list.ToArray();
        }

    






    public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.4445f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.8148f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.6297f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.81482f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.55556f, 109.6759f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.44445f, 102.6482f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.70371f, 90.72225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.37037f, 81.77775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.25926f, 74.11112f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.44445f, 83.05549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.48149f, 87.7407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.18519f, 89.87042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.07408f, 85.82408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.00001f, 80.28704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.51852f, 69.85183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-88.70372f, 60.26845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.51852f, 43.65746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.70371f, 30.02789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-91.66667f, 16.39817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-85.37038f, 4.685211f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-78.33334f, -6.814789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.62963f, -11.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.81482f, -16.61113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.62964f, -18.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.77778f, -34.28704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.40741f, -48.76845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.51852f, -64.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.81482f, -79.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.00001f, -88.59254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.22222f, -93.4907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(0f, -94.55549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.14815f, -91.78704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.11111f, -82.84254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.48148f, -68.36112f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.18518f, -55.58338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.77779f, -37.69437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.88889f, -18.10183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.96296f, -17.03704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.81482f, -12.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(76.66668f, 0f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.14815f, 10.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.77779f, 24.7038f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.77779f, 41.52774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.8889f, 60.6945f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.2963f, 77.51845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.03705f, 83.90746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.7037f, 90.29633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.48149f, 88.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.259254f, 74.53704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.40741f, 98.81493f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.37037f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.07408f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.370373f, 67.29633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.851847f, 65.59254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.74074f, 76.24084f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.33334f, 82.41676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.74074f, 86.03704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.66668f, 82.41676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.85186f, 71.76859f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(80f, 58.35183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.62964f, 38.54634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.14815f, 18.10183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.44445f, 2.342676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.44446f, -6.814789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.96296f, -14.05549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.62963f, -15.7593f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.44444f, -42.59253f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.11112f, -61.75929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.03703f, -80.07408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.18519f, -88.37958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.29629f, -88.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.88889f, -81.56479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.62964f, -70.70366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.96297f, -53.2407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.07408f, -31.09254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.8889f, -13.20366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.40741f, -12.77775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.5926f, -11.71296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.74075f, -0.4259155f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-86.66667f, 16.82422f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-90.00002f, 33.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-87.59261f, 52.38887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.81483f, 68.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.92593f, 77.73154f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.14815f, 83.6945f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.77778f, 85.39817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.07408f, 80.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.03703f, 70.27775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.66667f, 65.80563f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10.74075f, 71.98154f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.5926f, 86.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.25926f, 109.037f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30f, 115f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));

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