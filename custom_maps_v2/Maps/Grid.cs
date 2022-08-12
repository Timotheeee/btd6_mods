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
    class Grid
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-129.8401f, -115f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-129.8401f, 116.1058f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100.9868f, -115f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-101.4676f, 116.1058f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-71.65251f, -114.447f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-71.17162f, 115.553f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-41.83737f, -115f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-42.31826f, 116.1058f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track5()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-12.02223f, -115f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-11.06045f, 116.6586f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track6()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(15.38846f, -114.447f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(16.35023f, 116.1058f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track7()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(44.72271f, -114.447f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(44.72271f, 115f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track8()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(75.01872f, -115f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(74.53785f, 115.553f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track9()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(104.353f, -115.553f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(105.3148f, 116.6586f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track10()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(130.321f, -113.8942f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(130.321f, 116.1058f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track11()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.633f, -80.16828f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.1521f, -79.0625f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track12()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.633f, -37.5961f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(148.1139f, -37.04328f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track13()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.633f, 2.21156f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.1521f, 2.21156f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track14()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.633f, 42.57218f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.633f, 42.01922f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track15()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.633f, 81.27406f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.1521f, 81.82688f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }




        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, -115.2764f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.1904f, -114.1706f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6712f, 114.1708f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, 114.7236f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 0, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.0917f, -114.447f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.0535f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-121.665f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-121.665f, -113.3414f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 10, (AreaType)0));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.1619f, -113.6178f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.1619f, 115.2764f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.2543f, 114.7236f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.2543f, -113.6178f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 10, (AreaType)0));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.34673f, -114.7236f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-78.86584f, 115.8294f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.95828f, 115.2764f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.95828f, -114.1706f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 10, (AreaType)0));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-49.53159f, -113.6178f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.01249f, 114.1708f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.62403f, 114.1708f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.62403f, -114.1706f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 10, (AreaType)0));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.75468f, -114.7236f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.27379f, 115.8294f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.366222f, 115.8294f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.366222f, -114.1706f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 10, (AreaType)0));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.656002f, -114.1706f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.694232f, 115.2764f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.56357f, 115.2764f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.04447f, -114.7236f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 10, (AreaType)0));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.54758f, -114.7236f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.54758f, 113.6178f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(51.45515f, 115.2764f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.41694f, -114.7236f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 10, (AreaType)0));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.36272f, -114.7236f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.36272f, 114.7236f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.27029f, 115.2764f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.27029f, -114.7236f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8),Main.Empty(), 10, (AreaType)0));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.62052f, -114.1706f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.13965f, 114.7236f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.0472f, 115.2764f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.0472f, -114.1706f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9),Main.Empty(), 10, (AreaType)0));
            var area10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.1077f, -114.7236f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.1077f, 114.1708f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(138.0152f, 115.2764f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(138.0152f, -115.8292f));
            newareas.Add(new AreaModel("lol10", new Assets.Scripts.Simulation.SMath.Polygon(area10),Main.Empty(), 10, (AreaType)0));
            var area11 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, -85.97359f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.1521f, -86.52641f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.633f, -72.70423f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, -71.59859f));
            newareas.Add(new AreaModel("lol11", new Assets.Scripts.Simulation.SMath.Polygon(area11),Main.Empty(), 10, (AreaType)0));
            var area12 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, -45.61297f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.633f, -45.06015f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.1521f, -30.68515f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, -30.13219f));
            newareas.Add(new AreaModel("lol12", new Assets.Scripts.Simulation.SMath.Polygon(area12),Main.Empty(), 10, (AreaType)0));
            var area13 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, -6.35813f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.1904f, -5.80531f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.633f, 8.56969f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, 8.56969f));
            newareas.Add(new AreaModel("lol13", new Assets.Scripts.Simulation.SMath.Polygon(area13),Main.Empty(), 10, (AreaType)0));
            var area14 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, 34.00249f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6712f, 34.00249f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6712f, 50.58905f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, 48.93031f));
            newareas.Add(new AreaModel("lol14", new Assets.Scripts.Simulation.SMath.Polygon(area14),Main.Empty(), 10, (AreaType)0));
            var area15 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, 72.70437f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6712f, 73.81015f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.1521f, 88.73797f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, 88.18515f));
            newareas.Add(new AreaModel("lol15", new Assets.Scripts.Simulation.SMath.Polygon(area15),Main.Empty(), 10, (AreaType)0));
            var area16 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.33425f, -21.83891f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.23557f, -22.94469f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.23557f, -6.91095f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.85336f, -6.91095f));
            newareas.Add(new AreaModel("lol16", new Assets.Scripts.Simulation.SMath.Polygon(area16),Main.Empty(), 10, (AreaType)1));
            var area17 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.847116f, -23.49751f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.694232f, -24.60329f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.175125f, -6.91095f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.366222f, -6.91095f));
            newareas.Add(new AreaModel("lol17", new Assets.Scripts.Simulation.SMath.Polygon(area17),Main.Empty(), 10, (AreaType)1));
            var area18 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.0827f, -19.07453f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.7387f, -19.62735f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.21959f, -6.91095f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.04447f, -6.91095f));
            newareas.Add(new AreaModel("lol18", new Assets.Scripts.Simulation.SMath.Polygon(area18),Main.Empty(), 10, (AreaType)1));
            var area19 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.56357f, 8.01687f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.14315f, 9.12265f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.14315f, 25.70907f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.56357f, 26.26203f));
            newareas.Add(new AreaModel("lol19", new Assets.Scripts.Simulation.SMath.Polygon(area19),Main.Empty(), 10, (AreaType)1));
            var area20 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.366222f, 8.56969f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.175125f, 9.12265f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.175125f, 28.47359f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.366222f, 28.47359f));
            newareas.Add(new AreaModel("lol20", new Assets.Scripts.Simulation.SMath.Polygon(area20),Main.Empty(), 10, (AreaType)1));
            var area21 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.29602f, 9.12265f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.75468f, 9.12265f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.75468f, 25.70907f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.81514f, 24.05047f));
            newareas.Add(new AreaModel("lol21", new Assets.Scripts.Simulation.SMath.Polygon(area21),Main.Empty(), 10, (AreaType)1));
            var area22 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.0827f, 8.01687f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.06671f, 8.01687f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.54758f, 31.23811f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.0827f, 30.68515f));
            newareas.Add(new AreaModel("lol22", new Assets.Scripts.Simulation.SMath.Polygon(area22),Main.Empty(), 10, (AreaType)1));










            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            SplitterModel sm = new SplitterModel("", new string[]
            {
                            "track1",
                            "track2",
                            "track3",
                            "track4",
                            "track5",
                            "track6",
                            "track7",
                            "track8",
                            "track9",
                            "track10",
                            "track11",
                            "track12",
                            "track13",
                            "track14",
                            "track15",
            });


            return new PathSpawnerModel("", sm, sm);

            //return new PathSpawnerModel("", new SplitterModel("", new string[]
            //        {
            //            "Path1",
            //        }), new SplitterModel("", new string[]
            //        {
            //            "Path1",
            //        }));
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
                        new PathModel("track6", track6(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track7", track7(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track8", track8(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track9", track9(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track10", track10(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track11", track11(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track12", track12(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track13", track13(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track14", track14(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track15", track15(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }
    }
}