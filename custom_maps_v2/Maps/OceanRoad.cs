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
    class OceanRoad
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(119.2593f, -114.787f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(119.2593f, -44.29634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(72.22222f, -44.29634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(72.22222f, -73.04633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-114.6296f, -73.04633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-114.6296f, 2.768451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.92593f, 2.768451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.92593f, -29.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-39.81482f, -29.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-39.81482f, 0.851831f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-3.148145f, 0.851831f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-3.148145f, -30.66662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(33.51851f, -30.66662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(33.51851f, 38.33338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(76.2963f, 38.33338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(76.2963f, -5.324084f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(120.5556f, -5.324084f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(120.5556f, 72.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-10.92593f, 72.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-10.92593f, 41.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.963f, 41.10183f) });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.1852f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.3704f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(150f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.1852f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.3704f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.6296f, -64.52775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.6667f, -59.84253f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.85187f, -58.77774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.22223f, -63.67591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.22223f, -79.64817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.74075f, -84.75929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.5926f, -84.54633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-124.0741f, -76.02775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-123.7037f, 0.851831f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.7778f, 9.796338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.11111f, 10.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.74075f, 2.768451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.55556f, -15.33324f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-61.11112f, -21.2962f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.77779f, -21.50929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.70371f, -15.12028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.96297f, 3.194507f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.48148f, 9.370422f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.407408f, 10.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.11111f, 2.342676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.407404f, -18.31479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.92593f, -21.93521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.40741f, -22.57408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.51852f, -18.31479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(25f, 40.46296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.37037f, 46.63887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.33335f, 46f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.00002f, 39.18521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.11111f, 9.796338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.00002f, 2.981549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.8519f, 2.768451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.2963f, 8.518591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.9259f, 53.02774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.7037f, 59.41662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.740733f, 59.84267f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-0.9259255f, 54.73155f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.666671f, 36.62958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.222224f, 29.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, 27.68521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.5185f, 47.27774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.59259f, 48.55563f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.92593f, 53.4538f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.81482f, 70.4907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.88889f, 78.37042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.88889f, 78.37042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.2593f, 78.37042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.5556f, 69.63887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.3704f, -9.370422f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.6296f, -16.39817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.14816f, -16.39817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.85187f, -10.86113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.85187f, 20.87042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.77779f, 27.47225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.22223f, 27.04634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.96297f, 21.50929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.22223f, -36.20366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.11112f, -42.80549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-4.259259f, -41.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.40741f, -35.9907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.14815f, -17.88887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.33334f, -11.07408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.77778f, -10.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.51852f, -14.05549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.44444f, -35.35183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.07408f, -40.88887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-77.77779f, -42.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-85.00001f, -34.71296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-84.44445f, -19.59254f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-88.8889f, -11.92592f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100f, -11.28704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105f, -15.33324f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.8148f, -60.48141f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.25927f, -65.37958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.59259f, -64.7407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.33334f, -58.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.33334f, -45.78704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.81481f, -38.75916f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.8148f, -38.54634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(128.7037f, -46.42591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(130f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.1852f, -114.787f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, 57.92591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140.5556f, 59.84267f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120f, 55.37042f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.9259f, 55.58338f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.25927f, 59.62971f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80.18519f, 58.77789f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.18519f, 56.86113f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.5926f, 56.43521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.62964f, 57.92591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.51852f, 59.62971f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.96297f, 61.75929f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.51852f, 65.59254f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, 68.36112f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.66667f, 72.62042f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, 76.24084f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.96297f, 81.9907f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.22223f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, 57.28704f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 10, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.59259f, -105.8425f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.03705f, -110.3148f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.48149f, -114.5741f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.88889f, -113.9352f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(76.11112f, -110.1018f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.14816f, -114.787f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.74075f, -114.3611f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.66669f, -106.2684f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.00002f, -105.2037f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.25928f, -101.1575f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.03705f, -96.25916f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.00001f, -99.87958f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.70371f, -103.713f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.03705f, -106.0556f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.48149f, -108.8241f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.66667f, -114.787f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.51852f, 115f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.96297f, 109.25f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.48149f, 105.2037f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.48149f, 102.0093f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.74075f, 98.81493f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.40742f, 105.8427f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.25928f, 110.5277f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.77779f, 115f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.70372f, 115f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.33334f, 108.8241f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.5926f, -81.56479f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-144.2593f, -81.77775f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-143.3333f, -83.69437f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140.5556f, -82.62958f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.1111f, -87.52775f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-135.3704f, -87.95366f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-135.1852f, -92.42591f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-141.1111f, -95.40733f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-145.5556f, -94.76845f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-144.8148f, -90.93521f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.5926f, -89.23141f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.963f, -84.33338f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.2963f, -81.56479f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-119.2593f, -96.47225f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.5185f, -98.38887f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.5185f, -102.2223f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-116.8519f, -104.5648f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-123.8889f, -103.287f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-129.2593f, -110.5277f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.7778f, -111.1666f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140f, -105.8425f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140.7408f, -100.7314f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.8519f, -97.96296f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-132.963f, -95.62042f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.3704f, -98.60183f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-124.2593f, -99.2407f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-119.0741f, -95.62042f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-116.4815f, -97.32408f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.77778f, 100.3055f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.5926f, 94.34254f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.55556f, 87.7407f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.40741f, 84.12042f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.81482f, 77.51845f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.96296f, 80.5f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10.92593f, 88.80549f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.55555f, 97.53704f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.55556f, 102.0093f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.14815f, 100.3055f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.22223f, 94.76859f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.18518f, 89.01845f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.22223f, 47.91662f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.37037f, 49.19451f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.85186f, 54.94451f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.44444f, 58.77789f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.37038f, 60.48155f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.37038f, 57.28704f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.88889f, 52.17591f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.5926f, 48.98155f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.7408f, 48.55563f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.40742f, 48.55563f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.5926f, 56.00929f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-96.66668f, 57.92591f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.4815f, 57.71296f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.3704f, 54.73155f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.7408f, 50.47225f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-138.1482f, 13.20366f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-134.2593f, 9.157464f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.1852f, 1.490704f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-134.4445f, -3.83324f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-142.037f, -6.814789f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, -1.91662f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.5185f, 2.981549f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.037f, 9.58338f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-141.8519f, 12.9907f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.8519f, 12.13887f));
            newareas.Add(new AreaModel("lol10", new Assets.Scripts.Simulation.SMath.Polygon(area10),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var areaA = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-57.59259f, 26.19451f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.92593f, 26.62042f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.62964f, 24.7038f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, 18.52775f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.62963f, 10.64817f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.66667f, 6.814789f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.81482f, 4.898169f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.22223f, 9.796338f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.18519f, 20.44451f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-57.96297f, 24.4907f));
            areaA.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.29631f, 26.19451f));
            newareas.Add(new AreaModel("lolA", new Assets.Scripts.Simulation.SMath.Polygon(areaA),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));

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