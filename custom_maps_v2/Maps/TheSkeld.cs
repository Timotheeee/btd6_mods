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
    class TheSkeld
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.55556f, -61.07774f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(83.55555f, -62.1f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(84.88889f, -23.25549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(98.66667f, -22.74437f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(98.66667f, 2.811127f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(83.99999f, 2.811127f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(83.99999f, 52.38887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(27.99999f, 52.9f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(27.99999f, 32.45563f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(20.88888f, 31.43338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.11111f, -62.61113f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.11111f, -62.1f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-71.11111f, -62.61113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-71.11111f, -45.23338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-80.44444f, -44.21112f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-81.33334f, 30.41113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-72f, 31.43338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-71.11111f, 48.3f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-51.55555f, 47.78887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-50.66667f, 71.3f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-2.66667f, 73.85549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-3.555554f, 43.7f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.55556f, 28.87775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.11111f, -62.61113f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(83.99999f, 70.27775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(82.66666f, 1.788873f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(97.33334f, 2.3f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(97.33334f, -12.52225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(124.8889f, -12.52225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(124.4445f, -25.3f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-41.33333f, -17.12225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32.88889f, -17.12225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32f, -61.58887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-70.22223f, -63.12211f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-70.22223f, -75.38887f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track5()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-70.22223f, 64.65549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-70.66666f, 48.81113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-51.55555f, 47.78887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-51.55555f, 72.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-36f, 71.81113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-35.55556f, 42.16676f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-19.55556f, 41.1445f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-18.22222f, 19.67775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-36.44444f, 16.61113f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }



        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var area_ = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, -115.2764f));
            area_.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.1904f, -114.1706f));
            area_.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6712f, 114.1708f));
            area_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, 114.7236f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area_),Main.Empty(), 0, (AreaType)2));
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.22222f, 66.7f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.55555f, 66.7f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.22222f, 53.92225f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.22222f, 54.94451f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.11111f, 45.23338f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.11111f, 27.34451f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.555559f, 17.63338f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.555559f, 5.877887f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40f, 4.855493f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40f, 60.05549f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)0));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.55556f, 67.72225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68f, 22.23338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.33334f, 21.21113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.77779f, 59.54451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-90.22221f, 67.21113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68f, 67.21113f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 10, (AreaType)0));
            var area2_ = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.4445f, 24.27775f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.4445f, 8.944507f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-96f, 9.966619f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.66667f, -30.41113f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.3333f, -30.41113f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.4445f, -46.25563f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.4444f, -46.25563f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-121.7778f, -36.03338f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-122.2222f, 14.05549f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.1111f, 24.27775f));
            area2_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104f, 24.78887f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2_),Main.Empty(), 10, (AreaType)0));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.22222f, 9.455493f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.22222f, 10.47775f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-49.77777f, -29.9f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.22222f, -37.56662f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.55555f, -37.05549f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.22222f, -29.38887f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.77778f, 8.43338f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 10, (AreaType)0));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.33334f, -40.63338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.44445f, -40.63338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.44445f, -85.1f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-89.77777f, -86.12225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.33334f, -78.45549f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 10, (AreaType)0));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.66666f, 97.36676f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.77778f, 18.14451f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.222228f, 17.12225f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.555559f, 29.38887f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.555559f, 79.47775f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.777782f, 98.9f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 10, (AreaType)0));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.33333f, 64.14451f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.22221f, 89.18887f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(40f, 97.36676f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.11111f, 98.38887f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.33334f, 89.7f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.44445f, 64.14451f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 10, (AreaType)0));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.1111f, 56.98887f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.66666f, 40.63338f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(67.11111f, 41.1445f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.22223f, 28.87775f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.88889f, 29.38887f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.88889f, 56.47789f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.55555f, 77.43338f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.44445f, 75.90014f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.44445f, 58.01112f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.66666f, 58.01112f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 10, (AreaType)0));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.33333f, -9.455493f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.33333f, -40.63338f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(58.66667f, -39.61113f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.55555f, -35.01113f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(50.22222f, -23.76662f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.77777f, -10.47775f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8),Main.Empty(), 10, (AreaType)0));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.5555f, -7.411127f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.8889f, -7.922253f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.3333f, 2.811127f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.7778f, 4.344367f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(142.2222f, -6.388873f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(143.5556f, -23.76662f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(134.6667f, -35.01113f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(122.2222f, -34.49986f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.3333f, -24.27775f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(104.4445f, -24.27775f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9),Main.Empty(), 10, (AreaType)0));
            var area10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.88889f, -46.76662f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.22223f, -46.76662f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.00001f, -56.98887f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.00001f, -92.25549f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.11111f, -92.25549f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.44444f, -73.34437f));
            newareas.Add(new AreaModel("lol10", new Assets.Scripts.Simulation.SMath.Polygon(area10),Main.Empty(), 10, (AreaType)0));
            var area11 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.8889f, -3.83324f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.00001f, -3.322113f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.44445f, 27.34451f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.99999f, 33.47775f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.44444f, 36.03338f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.88889f, 12.01113f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.77778f, 13.03338f));
            newareas.Add(new AreaModel("lol11", new Assets.Scripts.Simulation.SMath.Polygon(area11),Main.Empty(), 10, (AreaType)0));
            var area12 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.55556f, -15.07775f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(56f, -36.54451f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(56f, -86.12225f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.44444f, -110.6555f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.111112f, -113.2111f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.88889f, -97.87775f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.22223f, -36.54451f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(0f, -16.61113f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.55556f, -15.07775f));
            newareas.Add(new AreaModel("lol12", new Assets.Scripts.Simulation.SMath.Polygon(area12),Main.Empty(), 10, (AreaType)0));
            var area13 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.11111f, -56.98887f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.66667f, -74.87775f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.55556f, -74.87775f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.55556f, -57.5f));
            newareas.Add(new AreaModel("lol13", new Assets.Scripts.Simulation.SMath.Polygon(area13),Main.Empty(), 10, (AreaType)0));
            var area14 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-85.33334f, -39.61113f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-76.88889f, -39.61113f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-76.88889f, -13.03324f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68f, -10.47775f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.22222f, -2.3f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-76.44444f, -1.788873f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-76f, 21.21113f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-85.33334f, 20.70014f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-84.88889f, -2.811127f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.77778f, -1.788873f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.33333f, -12.01113f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-85.33334f, -12.01113f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-84.88889f, -39.61113f));
            newareas.Add(new AreaModel("lol14", new Assets.Scripts.Simulation.SMath.Polygon(area14),Main.Empty(), 10, (AreaType)0));
            var area15 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.888885f, 77.43338f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.444444f, 67.72225f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.66666f, 68.23338f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.77778f, 36.54451f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68f, 36.54451f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68f, 52.9f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-55.11111f, 52.9f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-55.55556f, 77.43338f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.000001f, 77.9445f));
            newareas.Add(new AreaModel("lol15", new Assets.Scripts.Simulation.SMath.Polygon(area15),Main.Empty(), 10, (AreaType)0));
            var area16 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.11112f, 23.25549f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.44444f, 23.25549f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.44444f, 12.52225f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.66668f, 12.01113f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(36f, -3.322113f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.44444f, -3.322113f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.33334f, -14.56662f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.11112f, -14.56662f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.55556f, 23.25549f));
            newareas.Add(new AreaModel("lol16", new Assets.Scripts.Simulation.SMath.Polygon(area16),Main.Empty(), 10, (AreaType)0));
            var area17 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.88889f, -58.26662f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.44444f, -57.24451f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.11111f, -51.62211f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.55556f, -51.62211f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.22222f, -30.15549f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.444444f, -16.35549f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.555559f, -3.06662f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.55556f, -3.577746f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.33334f, -12.26662f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.88889f, -51.11098f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.88889f, -51.11098f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.88889f, -56.73324f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area17),Main.Empty(), 10, (AreaType)0));
            var area18 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.44444f, -74.62225f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.00001f, -74.11112f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.00001f, -57.75549f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(56f, -57.24451f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.44444f, -74.62225f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area18),Main.Empty(), 10, (AreaType)0));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.11111f, -46.51099f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.66667f, -36.8f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(72.88889f, -36.28887f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(72f, -19.42225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.22223f, -18.91113f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.77777f, -9.711126f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.22223f, -8.688873f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.66667f, 29.64451f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.33333f, 29.13338f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.00001f, 7.155493f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(104f, 7.66662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.1111f, -6.13324f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.8889f, -6.644366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.4445f, -24.02225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.1111f, -23.51113f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(104f, -35.26662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.88889f, -34.75549f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.44445f, -46f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.11111f, -46f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 10, (AreaType)0));
            var area20 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.11111f, -113.7221f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.3333f, -113.7221f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.3333f, 112.7f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.11111f, 112.7f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.22223f, 88.16662f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.8889f, 41.65563f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.1111f, 31.43338f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-124.4445f, 22.23338f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-125.7778f, -38.58887f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.6667f, -57.5f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.6667f, -76.92225f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.99999f, -100.4334f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.11111f, -114.2334f));
            newareas.Add(new AreaModel("lol20", new Assets.Scripts.Simulation.SMath.Polygon(area20),Main.Empty(), 10, (AreaType)0));
            var area21 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.77778f, -113.7221f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.7778f, -113.7221f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.7778f, 111.6779f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.66666f, 111.6779f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.00001f, 92.76662f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.7778f, 73.85549f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.4444f, 28.87775f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(120f, 28.87775f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(142.6667f, 3.322253f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.4444f, -10.98887f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(144f, -23.25549f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(131.5556f, -37.56662f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.3333f, -41.65549f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.66667f, -73.34437f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.33334f, -97.87775f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.8889f, -113.7221f));
            newareas.Add(new AreaModel("lol21", new Assets.Scripts.Simulation.SMath.Polygon(area21),Main.Empty(), 10, (AreaType)0));











            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            SplitterModel sm = new SplitterModel("", new string[]
            {
                            "track1",
                            "track2",
                            "track1",
                            "track2",
                            "track1",
                            "track2",
                            "track1",
                            "track2",
                            "track3",
                                                        "track1",
                            "track2",
                            "track1",
                            "track2",
                            "track1",
                            "track2",
                            "track1",
                            "track2",
                            "track4",
                                                        "track1",
                            "track2",
                            "track1",
                            "track2",
                            "track1",
                            "track2",
                            "track1",
                            "track2",
                            "track5",
            });


            return new PathSpawnerModel("", sm, sm);

        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("track1", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track2", track2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track3", track3(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track4", track4(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track5", track5(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }
    }
}