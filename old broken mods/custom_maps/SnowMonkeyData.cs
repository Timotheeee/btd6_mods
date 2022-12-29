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
    class SnowMonkeyData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-148.3333f, 38.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-137.4074f, 45.36113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-129.0741f, 54.09253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-117.7778f, 62.82408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-103.7037f, 72.1945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.37038f, 82.41676f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-66.85186f, 90.29633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-47.40741f, 97.32408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-28.8889f, 104.5648f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-9.074075f, 110.5277f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(17.77777f, 107.1204f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(27.4074f, 97.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(35.55556f, 85.82408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(40.18518f, 65.59254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(38.33333f, 50.04634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(28.51852f, 31.30549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(20.18518f, 25.55549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(7.592601f, 32.37042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-6.666667f, 35.35183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-21.66667f, 28.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-27.96296f, 24.06479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-33.14816f, 11.07408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-36.2963f, -12.13887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-31.66667f, -24.70366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-20f, -38.54634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-16.11111f, -40.67591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(9.074075f, -40.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(18.33333f, -50.68521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.18519f, -67.93521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(23.7037f, -82.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(14.07407f, -94.12958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(7.222224f, -98.81479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(1.296294f, -99.66662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-10.92593f, -100.5184f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-20f, -96.68521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-25.55556f, -87.52775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-30.74075f, -73.04633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-29.81482f, -57.07408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-21.11111f, -42.16662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-9.444444f, -38.75916f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(5.92593f, -39.61113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(10.18519f, -40.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(19.62962f, -31.51845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(26.29629f, -19.59254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(30.18519f, 0.4259155f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.37037f, 16.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(14.25927f, 30.2407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-3.703702f, 34.07409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-17.40741f, 31.30549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-27.59259f, 24.7038f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.18519f, 38.54634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.92593f, 54.94451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-46.48149f, 77.9445f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.55556f, 93.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-29.62963f, 104.7777f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-10.92593f, 110.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(15.74074f, 108.6111f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(41.48149f, 108.6111f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(61.11112f, 104.9908f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(86.48149f, 99.2407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(103.1482f, 96.89817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(124.2593f, 83.6945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.2222f, 71.76859f) });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.4074f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 39.61113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-139.0741f, 45.36113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.8889f, 59.62971f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.6667f, 71.98154f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.1852f, 83.90746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-66.85186f, 90.29633f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.2963f, 96.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.77778f, 101.3704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-44.07408f, 88.59267f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.66667f, 71.55549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.92593f, 51.32409f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-41.11111f, 39.18521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.96297f, 29.17591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.59259f, 25.76859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.33334f, 14.05549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.11111f, 3.194507f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.2963f, -10.00916f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.5926f, -21.93521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.92593f, -33.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-14.81482f, -41.52774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.62963f, -50.2593f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30f, -60.6945f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.55556f, -78.7962f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.62963f, -91.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.37037f, -97.32408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.888882f, -102.2223f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.66666f, -100.3055f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.48149f, -86.46296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.11111f, -69f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.77779f, -58.13887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.51851f, -43.65746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.18519f, -40.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.03703f, -33.64803f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.55555f, -23.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.44445f, -11.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.11111f, -0.6388733f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.22223f, 21.08338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.55556f, 25.55549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.8889f, 33.86113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(38.70371f, 52.38887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.11111f, 63.88901f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(38.51853f, 78.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.66666f, 94.12958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(24.25926f, 101.5834f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.14815f, 107.5463f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.66668f, 111.8055f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.92592f, 109.037f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.11112f, 105.4166f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.62965f, 100.7315f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.2593f, 94.34254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.1852f, 82.41676f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(138.7037f, 76.24084f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, 71.76859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.4074f, 80.5f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(135.7408f, 87.95366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.8148f, 96.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.5556f, 102.6482f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.92593f, 109.8889f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.55555f, 113.5093f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.66667f, 114.1482f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.481474f, 114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.9259344f, 107.9723f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.74075f, 97.11112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.66667f, 80.5f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.33334f, 71.12971f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.00001f, 57.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.51852f, 44.29634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.59259f, 34.71296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.92592f, 28.53704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.888895f, 32.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.296294f, 34.5f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.66667f, 34.5f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.40741f, 31.73155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-29.44444f, 26.83338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.11111f, 22.36113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.51852f, 27.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10.18519f, 30.45366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.11111f, 30.02789f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.55555f, 27.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.40741f, 19.80563f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.85185f, 6.601831f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.37037f, -4.685211f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(24.07408f, -16.39817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.48148f, -26.19437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.74075f, -34.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.481487f, -39.61113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.481483f, -37.26845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.5926f, -38.54634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.33334f, -40.46296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.2963f, -46.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10f, -43.23141f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.222228f, -42.80549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.703697f, -46.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(14.62963f, -54.94437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.81482f, -66.87042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.40741f, -58.56479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.37038f, -72.62028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.48148f, -82.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.48148f, -82.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.96296f, -96.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.703697f, -97.53704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.259254f, -98.17591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.92593f, -99.2407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.407408f, -99.66662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.962961f, -99.02775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15f, -97.53704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-20.18519f, -89.87042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.51852f, -85.61112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.37037f, -75.60183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.2963f, -64.10183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.7037f, -55.79634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-18.88889f, -49.40746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.66667f, -42.80549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.40741f, -36.20366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.92593f, -26.83338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30f, -20.44437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-31.85185f, -14.48141f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.25926f, -2.768451f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-31.85185f, 9.157464f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.48149f, 18.10183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-21.48148f, 25.12958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.96296f, 31.09267f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.96297f, 40.03704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.25927f, 49.40746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-41.85185f, 64.52775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-41.48148f, 81.35197f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.92593f, 95.83338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.81482f, 103.0741f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-31.85185f, 108.8241f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.85186f, 104.1389f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.40741f, 100.0925f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.5926f, 94.76859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.74075f, 88.80549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.5926f, 84.33338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.1482f, 73.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-124.2593f, 67.72225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-133.7037f, 59.84267f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-143.5185f, 54.09253f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1482f, 49.83338f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10.92593f, 13.20366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-9.074075f, 10.86113f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.851856f, 7.027746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.518522f, 5.537042f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.666671f, 3.620422f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.555553f, 3.83338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.518517f, 4.898169f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.11111f, 8.518591f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.33333f, 12.77775f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.11112f, 13.20366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(13.51851f, 21.72225f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.074075f, 25.34254f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(4.074079f, 28.32408f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.962965f, 27.47225f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.777781f, 23f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.11111f, 18.31479f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.48148f, 10.0093f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.703707f, 51.96296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.814816f, 47.70366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.481474f, 45.57409f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.555553f, 47.27774f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(10.92593f, 48.34267f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.03704f, 54.09253f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(14.62963f, 59.62971f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.03704f, 65.59254f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.481487f, 70.06493f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.1851887f, 70.06493f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.962961f, 66.23154f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.85185f, 58.9907f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.85185f, 52.38887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.29629f, 51.32409f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.407404f, 51.96296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.629627f, 47.91662f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)1));
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