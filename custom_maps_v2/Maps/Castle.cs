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
    class Castle
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-6.296299f, -114.787f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(4.629636f, -70.27775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-77.03704f, -61.12042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-87.40742f, -68.14817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-95.55556f, -70.4907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-103.7037f, -67.93521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-109.8148f, -61.12042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-110.1852f, -38.54634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-105.1852f, -30.02775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-107.963f, 28.11113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-111.1111f, 35.9907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-117.7778f, 50.04634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-117.2222f, 64.10183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-113.5185f, 74.75f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-102.5926f, 79.43521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-90.55557f, 77.9445f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-77.5926f, 67.29633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-64.62964f, 67.29633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-36.11111f, 67.08338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-32.40741f, 73.04633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-24.07408f, 78.15746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-12.03704f, 77.9445f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-8.148149f, 77.9445f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-7.962961f, 115f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-6.481478f, -114.787f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(3.333342f, -70.27775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(15.74074f, -72.62028f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(18.51853f, -84.33338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(24.62964f, -93.27775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(33.88889f, -95.40733f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(43.51852f, -89.87042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(47.22223f, -76.02775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(50.92593f, -63.25f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(58.33333f, -56.22211f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(67.40741f, -47.70366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(76.66668f, -39.18521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(88.70372f, -38.75916f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(99.44445f, -33.0093f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(106.1111f, -24.70366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(107.2222f, -10.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(105.3704f, -0.4259155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(95.55556f, 6.175915f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(90.55557f, 6.814789f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(89.81481f, 20.44451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(89.44446f, 35.56479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(95.37038f, 46.85183f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(100f, 60.48155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(99.62965f, 67.93521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(89.81481f, 76.66662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(75.18519f, 76.66662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(65.74075f, 71.98154f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(60.74074f, 65.59254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(55.55556f, 65.59254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(48.8889f, 73.68521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(38.51853f, 78.79633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(30.18519f, 79.43521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(26.48149f, 78.79633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.37037f, 115f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }




        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-154.6297f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.2593f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(151.2963f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-154.6297f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.5926f, -105.4166f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.66667f, -102.2223f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-69.62963f, -106.6944f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-70.74075f, -99.45366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-76.85186f, -99.45366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-81.11111f, -102.4351f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-114.4445f, -96.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.4445f, -80.5f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.5185f, -3.194507f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.3333f, 20.23155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-141.4815f, 61.12042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.2593f, 101.7963f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.07408f, 115f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.14815f, 115f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.96297f, 87.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.37037f, 88.59267f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.59259f, 82.41676f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.81482f, 76.87958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-73.88889f, 75.81479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.44446f, 86.88887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-107.7778f, 87.95366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.4815f, 71.34254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.7408f, 58.9907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.7408f, 42.37972f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.5556f, 30.2407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120f, 19.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.037f, -21.93521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.3704f, -34.07409f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.963f, -45.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.7037f, -60.6945f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.963f, -74.75f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.7037f, -86.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.5556f, -90.72225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.03704f, -92.21296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.11111f, -90.50929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-74.62964f, -82.41662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.55556f, -84.97211f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.37037f, -87.52775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-9.444444f, -88.59254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.5926f, -104.5648f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.48149f, -102.4351f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-69.81483f, -106.4814f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 10, (AreaType)1));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.33334f, -109.463f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.74075f, -106.4814f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.5926f, -85.61112f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(124.2593f, -49.83338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.3333f, 15.7593f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120f, 66.65746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.6296f, 72.1945f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(112.7778f, 90.50929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(95.74075f, 115f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.03704f, 115f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(30.37037f, 86.03704f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(39.81482f, 88.16662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.22222f, 83.05549f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(58.70371f, 76.45366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.03704f, 84.12042f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.55557f, 85.18521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.88889f, 79.22225f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(108.3333f, 68.36112f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(112.7778f, 56.43521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(113.3333f, 41.52774f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(110.5556f, 29.38887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.0371f, 18.31479f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.5926f, 12.35183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(110f, 7.453802f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.4074f, -1.703662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.5926f, -16.61113f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.4815f, -29.60183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.9259f, -44.5093f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(110.3704f, -52.60183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.70371f, -58.56479f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.81482f, -60.26845f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(78.88889f, -63.88887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.51852f, -73.04633f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.07408f, -77.09254f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(65.55556f, -81.35183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.11112f, -95.40733f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.66668f, -102.4351f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.62963f, -109.037f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.03704f, -107.1204f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(103.1482f, -84.97211f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 10, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.3703684f, -114.787f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.333342f, -97.96296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.48148f, -111.8055f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.96297f, -114.787f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.2963f, -114.787f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(51.85186f, -111.8055f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.48148f, -106.2684f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.14815f, -95.40733f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.66667f, -80.71296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(65.37038f, -75.17591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.25927f, -64.7407f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.92594f, -62.82408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(93.33334f, -63.25f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(111.1111f, -53.45366f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(116.1111f, -45.14817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.0371f, -30.66662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.6667f, -15.7593f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.4074f, -2.768451f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.4445f, 6.814789f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.5926f, 13.41676f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.5926f, 16.61113f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(111.4815f, 28.32408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.0741f, 40.88887f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115f, 54.51859f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.4445f, 71.55549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.5556f, 81.9907f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.55557f, 87.10183f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.25927f, 87.7407f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.07407f, 85.39817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.25927f, 79.86112f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(58.14815f, 76.24084f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.22222f, 83.6945f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(40.74074f, 88.59267f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.11111f, 85.61112f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(30.74075f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.11111f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.55556f, 81.56479f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.66667f, 70.4907f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.2963f, 67.29633f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.33334f, 63.46296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.62963f, 55.37042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.48149f, 54.30549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.40741f, 54.51859f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.96297f, 60.6945f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.25927f, 63.46296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.1852f, 62.39817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.44445f, 56.86113f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(96.11112f, 47.49084f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.07409f, 38.7593f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.77779f, 33.64817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.37038f, 27.68521f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.00002f, 17.67591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.55556f, 5.324084f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.40742f, -2.981409f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.96297f, -8.092535f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.9259f, -14.90746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.8148f, -25.98155f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.2222f, -33.86113f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(96.11112f, -37.48155f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.03705f, -39.18521f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.40742f, -39.61113f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.92593f, -66.65733f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.92593f, -71.34254f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.29631f, -83.05549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.1852f, -87.31479f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.59259f, -89.87042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(39.81482f, -94.55549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.2963f, -97.32408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.40741f, -92.63887f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.88889f, -83.90733f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.55556f, -72.62028f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.07409f, -61.12042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.03705f, -68.78704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-93.33334f, -70.70366f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.4815f, -69f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-109.6296f, -63.25f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.1111f, -52.81479f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.7408f, -44.08324f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-102.0371f, -37.05549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-104.4445f, 30.66662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.2963f, 38.12042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-114.2593f, 47.06479f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.1482f, 59.62971f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.7037f, 63.67591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.2963f, 67.93521f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.37038f, 68.57408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-82.03705f, 63.03704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.18519f, 57.28704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.03704f, 56.22225f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.22223f, 63.03704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.07408f, 65.16662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.85186f, 67.29633f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.481478f, 68.36112f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.629627f, 69.42591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.703702f, 74.32408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.888891f, 85.39817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.962965f, 101.1575f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.592597f, 113.9352f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.222219f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.51852f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.14815f, 86.88887f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.00001f, 88.37971f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.55556f, 81.9907f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-40f, 76.45366f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.96297f, 76.66662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-73.33334f, 76.66662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.81483f, 83.90746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.92593f, 88.80549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.4815f, 89.4445f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.1111f, 88.59267f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.6667f, 85.39817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-124.0741f, 79.86112f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-132.4074f, 71.12971f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-134.6296f, 63.46296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-133.7037f, 57.07408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-132.2222f, 45.36113f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.2963f, 40.46296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.7037f, 30.66662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.3704f, 25.12958f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.8148f, 17.88887f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.2963f, -22.14817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.0741f, -23.85183f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.2222f, -26.40732f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125f, -33.64803f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.2222f, -40.25f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.8889f, -50.2593f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130f, -56.86113f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.7037f, -67.72225f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-124.0741f, -73.25929f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.7778f, -83.26845f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-109.8148f, -92f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.3704f, -91.78704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.5926f, -93.27775f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.11111f, -91.36112f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.25927f, -88.80563f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-74.62964f, -85.18521f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.59261f, -84.54633f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-51.85185f, -84.75929f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.59259f, -85.39817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-44.07408f, -86.46296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.55556f, -87.10183f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-21.66667f, -86.67591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10f, -87.95366f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-5.000005f, -89.01845f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.85185f, -114.787f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.296294f, -114.787f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.481487f, -83.69437f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 10, (AreaType)0));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.592597f, 81.9907f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.592588f, 77.73154f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.74074f, 76.87958f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.92594f, 81.9907f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.92594f, 72.40746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.33333f, 68.36112f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.037031f, 68.78704f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.407408f, 73.25929f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.03704f, 81.35197f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.592588f, 77.73154f));
            newareas.Add(new AreaModel("lol5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 10, (AreaType)0));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.00001f, -36.20366f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.74075f, -43.87028f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.81482f, -56.22211f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(34.07407f, -53.87958f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.40741f, -24.70366f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.40742f, -1.703662f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.96297f, 28.11113f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.51852f, 38.12042f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-81.2963f, 41.31493f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.62964f, 30.66662f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.92593f, -35.56479f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80f, -33.43521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.40742f, -37.69437f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.18518f, -50.0462f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(30.18519f, -48.34253f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.51852f, -19.59254f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.48149f, -11.28704f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(67.03705f, 26.19451f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.11112f, 31.30549f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-78.33334f, 34.92591f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.70371f, 27.68521f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80f, -32.58324f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.03704f, -37.69437f));
            newareas.Add(new AreaModel("lol6", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 10, (AreaType)0));


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
                        new PathModel("Path1", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path2", track2(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }
    }
}