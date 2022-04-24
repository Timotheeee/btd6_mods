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
    class ToxicWaste
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-137.5343f, -66.62251f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-39.43292f, -64.41095f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-31.2578f, -83.20921f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-19.71646f, -92.60813f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-6.251559f, -95.92547f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(9.617789f, -94.81969f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(20.67824f, -88.73797f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25.00624f, -78.23313f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(24.52536f, -66.06969f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(22.12091f, -55.56485f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(14.42668f, -46.71875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.847116f, -45.61297f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.213338f, -47.27157f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-12.98401f, -55.56485f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-14.42668f, -66.06969f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.694232f, -71.59859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(0.9617701f, -73.25719f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(6.732444f, -67.72829f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(5.770674f, -62.75235f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(1.923558f, -62.19953f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(138.0152f, -64.41095f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.95203f, -63.85813f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(35.58581f, -52.24751f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(29.33425f, -42.29563f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(18.27379f, -35.10813f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(6.732444f, -31.79093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-2.404443f, -30.68515f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-8.656011f, -31.79093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.94579f, -36.76687f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-18.75468f, -40.08407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-21.15913f, -42.84859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-23.08269f, -50.03595f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.52536f, -57.77641f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.04447f, -64.96391f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-21.64002f, -71.59859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-17.79291f, -77.12735f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-14.90757f, -78.78595f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-11.06045f, -81.55047f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-6.251559f, -82.65625f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.366222f, -83.76203f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(7.213338f, -82.65625f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(12.02224f, -78.78595f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(14.90757f, -75.46875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(16.35023f, -71.59859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(16.83113f, -64.41095f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(13.46491f, -58.88219f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(10.57956f, -56.11781f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(4.32801f, -54.45907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9617789f, -56.11781f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-3.847116f, -59.98797f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-4.808895f, -63.30531f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9617789f, -65.51687f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-137.0535f, 61.64671f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-37.99026f, 64.41109f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.14314f, 72.15141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-29.33425f, 82.65625f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.00624f, 89.84375f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-19.71646f, 93.16109f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-10.57957f, 95.92547f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9617789f, 96.47843f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(9.136896f, 94.81969f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(16.83113f, 91.50249f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(22.6018f, 84.31485f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(24.52536f, 75.46875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(23.56357f, 61.64671f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(21.15914f, 53.90625f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(15.38846f, 48.93031f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(6.732444f, 44.50719f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-1.442664f, 44.50719f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-7.694232f, 47.27171f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-12.02223f, 51.69469f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.94579f, 56.67077f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.4649f, 63.30531f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-11.06045f, 69.38703f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-6.732453f, 72.70437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9617789f, 73.25719f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.847116f, 71.59859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(6.251568f, 68.28125f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(5.770674f, 63.30531f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(1.923558f, 63.85813f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(138.0152f, 64.41109f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(40.3947f, 64.41109f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(37.50937f, 55.01203f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(33.18136f, 46.71875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(26.44892f, 41.18985f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(18.27379f, 35.10813f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(9.136896f, 31.23811f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-3.366222f, 29.57937f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.4649f, 32.89671f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-18.75468f, 40.08407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-22.12091f, 46.71875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.52536f, 54.45907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.52536f, 61.09375f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-20.67824f, 69.38703f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-17.31201f, 75.46875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-12.98401f, 79.33905f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-5.28978f, 82.65625f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(2.404452f, 83.76203f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(9.617789f, 80.99765f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(13.94578f, 75.46875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(16.35023f, 68.28125f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(13.94578f, 60.54093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(9.136896f, 56.67077f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(4.808886f, 55.01203f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-1.923558f, 55.56485f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-4.808895f, 60.54093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(0f, 66.06969f) });
            return list.ToArray();


        }


        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var areaa = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaa.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.1904f, -113.3414f));
            areaa.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.1904f, -113.3414f));
            areaa.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.1521f, 112.7886f));
            areaa.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.1904f, 113.3414f));
            areaa.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, -113.8942f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(areaa),Main.Empty(), 0, (AreaType)2));
            var areab = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areab.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.89158f, -96.7547f));
            areab.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.04447f, -93.99032f));
            areab.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.92979f, -32.06734f));
            areab.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.23557f, -28.75f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(areab),Main.Empty(), 0, (AreaType)0));
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.96315f, -53.6297f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.53647f, -54.73562f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.57469f, 50.86532f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.96315f, 51.41828f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 0, (AreaType)1));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, -22.66828f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.96315f, -23.77406f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.92493f, 24.32688f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, 21.5625f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 0, (AreaType)1));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.28491f, -24.32688f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.48226f, -49.75968f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.92493f, -26.53844f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 0, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.92493f, 50.3125f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.40582f, 22.66828f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.07158f, 24.32688f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 0, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.4308f, -37.5961f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.7685f, -39.2547f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8068f, -89.01438f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(145.469f, -91.22594f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 0, (AreaType)0));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.4308f, -90.12016f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.3259f, -91.22594f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.845f, -37.5961f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.3926f, -37.04328f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 0, (AreaType)0));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.9117f, 36.49032f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.845f, 37.04328f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.845f, 89.56734f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-145.9499f, 90.67312f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 0, (AreaType)0));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8068f, 38.14906f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(145.9499f, 37.59624f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.9117f, 90.1203f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8068f, 89.56734f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 0, (AreaType)0));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.3641f, 75.19234f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.23069f, 72.98092f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.74982f, 53.62984f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.2876f, 55.8414f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8),Main.Empty(), 0, (AreaType)0));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.845f, -55.8414f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.46002f, -56.94704f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.46002f, -72.42782f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.3641f, -73.5336f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9),Main.Empty(), 0, (AreaType)0));
            var area10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.49825f, -55.8414f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.8832f, -54.18266f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.9214f, -73.5336f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.57469f, -72.98078f));
            newareas.Add(new AreaModel("lol10", new Assets.Scripts.Simulation.SMath.Polygon(area10),Main.Empty(), 0, (AreaType)0));
            var area11 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.4023f, 53.62984f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.97914f, 55.8414f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.01736f, 72.42796f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.9214f, 71.32218f));
            newareas.Add(new AreaModel("lol11", new Assets.Scripts.Simulation.SMath.Polygon(area11),Main.Empty(), 0, (AreaType)0));
            var area12 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.20847f, 26.53858f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.49825f, 92.88468f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.125784f, 106.1539f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.4378f, 98.41358f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.01736f, 79.61532f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.38358f, 72.98092f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.44403f, 72.42796f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.88671f, 53.62984f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.86447f, 34.2789f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.4378f, 27.64422f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.606669f, 22.66828f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.78179f, 24.87984f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.32313f, 32.06734f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.57469f, 48.6539f));
            newareas.Add(new AreaModel("lol12", new Assets.Scripts.Simulation.SMath.Polygon(area12),Main.Empty(), 0, (AreaType)0));
            var area13 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.96315f, -76.29812f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, -112.7884f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.92493f, -112.7884f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.92493f, -76.29812f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.42181f, -74.08642f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.20847f, -95.0961f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.18623f, -101.7308f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.2404469f, -104.4952f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.03335f, -101.7308f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.05559f, -94.54328f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.78803f, -87.35578f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.59692f, -74.08642f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.92493f, -75.74516f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area13),Main.Empty(), 0, (AreaType)1));
            var area14 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, 73.5336f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.92493f, 113.8942f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.92493f, 114.447f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.44403f, 74.08656f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.38358f, 72.98092f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.57469f, 84.03858f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.76581f, 94.54328f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.66712f, 101.178f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.453785f, 105.0481f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.64489f, 106.1539f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.18624f, 103.9423f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.80402f, 98.41358f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.42181f, 91.22594f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.19248f, 81.27406f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.07782f, 75.19234f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, 75.19234f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area14),Main.Empty(), 0, (AreaType)1));
            var area15 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, 54.45907f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.53647f, 56.67077f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.28491f, 34.00249f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.3009f, 24.60343f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.92493f, 22.39187f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.92493f, 52.80047f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area15),Main.Empty(), 0, (AreaType)1));
            var area16 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, 53.35343f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.8867f, -55.01203f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.97914f, -53.90625f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.7658f, -35.10813f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.377342f, -25.15625f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.202217f, -22.39187f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.70535f, -24.05047f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.20847f, -27.92063f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.82626f, -38.42547f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.0396f, -52.80047f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.92493f, -52.80047f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.36759f, 52.24765f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.52047f, 52.24765f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.9027f, 34.55531f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.36135f, 27.92077f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.10979f, 24.60343f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.087563f, 22.39187f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-4.568448f, 22.39187f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.70534f, 27.92077f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.32313f, 32.34375f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.61291f, 43.95437f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.09381f, 53.35343f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.53647f, 56.11781f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.63515f, 52.24765f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, 52.24765f));
            newareas.Add(new AreaModel("lol16", new Assets.Scripts.Simulation.SMath.Polygon(area16),Main.Empty(), 0, (AreaType)1));
            var area17 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.40582f, -53.35329f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.92493f, -72.15141f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.46002f, -71.59859f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.65113f, -89.84375f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.10979f, -99.79563f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.049333f, -103.113f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.3009f, -103.113f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.72758f, -97.03125f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.34537f, -87.07923f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.63515f, -75.46875f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.40582f, -73.81015f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.40582f, -53.90625f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.49825f, -56.11781f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.13203f, -42.29563f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-21.39958f, -33.44953f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.22446f, -27.92063f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.202226f, -22.39187f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.74356f, -24.05047f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.76581f, -29.02641f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.38358f, -35.10813f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.15425f, -45.06015f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.00137f, -53.35329f));
            newareas.Add(new AreaModel("lol17", new Assets.Scripts.Simulation.SMath.Polygon(area17),Main.Empty(), 0, (AreaType)0));
            var area18 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, 53.90625f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.53647f, 55.56485f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.24669f, 38.42547f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.14802f, 27.36781f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.683111f, 24.05047f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.78179f, 23.49765f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.68936f, 30.68515f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.9027f, 37.87265f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.59694f, 50.03609f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.40582f, 52.80047f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.88671f, 74.36297f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.94091f, 72.15141f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.57469f, 84.86781f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.28491f, 94.81969f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.14802f, 101.4544f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.087563f, 104.7717f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.415564f, 106.4303f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.07158f, 102.5602f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.13203f, 97.58421f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.94091f, 92.05531f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.26892f, 85.42077f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.07782f, 73.81015f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.92493f, 73.25719f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.92493f, 53.35343f));
            newareas.Add(new AreaModel("lol18", new Assets.Scripts.Simulation.SMath.Polygon(area18),Main.Empty(), 0, (AreaType)0));











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