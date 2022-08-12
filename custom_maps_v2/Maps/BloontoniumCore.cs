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
    class BloontoniumCore
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-118.7797f, -15.75719f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-51.45515f, -15.20423f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-42.79915f, -11.88703f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-28.37247f, -12.99281f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-15.38845f, -8.01687f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.4808851f, 1.38219f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(11.06045f, 9.12265f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(21.64001f, 14.09859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(39.43293f, 14.09859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(51.93605f, 17.96875f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(116.8561f, 17.96875f), bloonSpeedMultiplier = 1 });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {

            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(115.4134f, -17.41593f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(49.53159f, -17.41593f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(41.35649f, -27.92063f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25.00624f, -8.56969f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(6.732444f, -2.48797f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9617789f, 1.38219f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.4649f, 5.80531f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.00624f, 9.675469f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-37.50936f, 25.70907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-41.83737f, 30.13219f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-46.64627f, 22.94469f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-117.8179f, 25.15625f), bloonSpeedMultiplier = 1 });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-12.98401f, 114.7236f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-12.50312f, 56.67077f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.4649f, 24.05047f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9617789f, 3.04093f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.847116f, -10.22829f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(9.136896f, -17.96875f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(10.57956f, -34.00235f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(5.770674f, -69.38703f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(7.694232f, -114.1706f), bloonSpeedMultiplier = 1 });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-23.08269f, -114.1706f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-21.64002f, -52.24751f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.96802f, -47.82453f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-16.83113f, -37.87251f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-8.175117f, -26.26203f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-4.328001f, -12.43985f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9617789f, 0.8293701f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.847116f, 14.09859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(5.28978f, 26.81485f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(12.02224f, 37.31969f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(23.0827f, 48.37749f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(17.31202f, 55.56485f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.71646f, 114.7236f), bloonSpeedMultiplier = 1 });
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
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.56982f, -113.6178f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.97427f, -46.71875f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, -45.61297f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, -114.1706f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 0, (AreaType)0));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.53159f, -113.6178f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.08893f, -46.16593f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6712f, -46.16593f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.1521f, -113.0648f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 0, (AreaType)0));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.71295f, 114.7236f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.27029f, 101.4544f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.92629f, 93.71405f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.44542f, 74.36297f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.81164f, 66.62265f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.9708f, 56.11781f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(128.8783f, 35.10813f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.1904f, 32.89671f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.1521f, 114.1708f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 0, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.6712f, 48.93031f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-125.993f, 47.82453f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.9103f, 62.75249f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.2543f, 72.70437f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.19385f, 83.20921f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.17162f, 89.29079f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.47739f, 99.24281f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.03472f, 114.1708f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, 114.1708f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 0, (AreaType)1));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.8179f, 36.76687f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.2988f, 14.09859f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.11116f, 11.33407f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.59206f, -4.69953f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.2988f, -4.14657f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.337f, -26.81485f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-56.74494f, -26.26203f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.08893f, -44.50719f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.54759f, -55.56485f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.29602f, -61.09375f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.81514f, -113.6178f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.42668f, -113.6178f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.94579f, -69.38703f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.885337f, -72.15141f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.923558f, -114.1706f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.86934f, -114.1706f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.35023f, -68.83407f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.37247f, -62.75235f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.54758f, -56.11781f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.24181f, -47.82453f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(50.49338f, -37.87251f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.3405f, -29.57923f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(115.4134f, -25.70907f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.8561f, -6.91095f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.55384f, -6.91095f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.55384f, 5.80531f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.8179f, 8.01687f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.2606f, 26.81485f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.30227f, 30.68515f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.08893f, 43.40141f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.87559f, 53.35343f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.00624f, 63.85813f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.33425f, 114.1708f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.06045f, 115.2764f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.617789f, 68.83407f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.847116f, 70.49281f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.847116f, 114.1708f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.6018f, 114.7236f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.19735f, 66.06969f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.18136f, 59.43515f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.83737f, 50.58905f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.45515f, 37.31969f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-116.8561f, 38.97843f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 0, (AreaType)0));











            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                        "Path4",
                    }), new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                        "Path4",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path1", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path2", track2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path3", track3(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path4", track4(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }

    }
}