using MelonLoader;
using Harmony;
using NKHook6.Api;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using NKHook6;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
using Assets.Scripts.Unity.UI_New.Main;
using NKHook6.Api.Events;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using static NKHook6.Api.Events._Towers.TowerEvents;
using Assets.Scripts.Simulation.Towers;

using static NKHook6.Api.Events._Weapons.WeaponEvents;
using Assets.Scripts.Utils;

using static NKHook6.Api.Events._TimeManager.TimeManagerEvents;
//using Il2CppSystem.Collections;
using NKHook6.Api.Events._Bloons;
using NKHook6.Api.Events._Weapons;
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

namespace custom_maps
{
    class TrueTrueExpertData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> ouch1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(53.37871f, 1.38219f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(53.37871f, 115.2764f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> ouch2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(96.65875f, 0.8293701f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(97.13965f, 115.2764f) });
            return list.ToArray();


        }

        public static Il2CppReferenceArray<PointInfo> ouch3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(0f, 39.53125f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(148.1139f, 39.53125f) });
            return list.ToArray();


        }

        public static Il2CppReferenceArray<PointInfo> ouch4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(0f, 80.44469f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.633f, 79.33905f) });
            return list.ToArray();



        }

        public static Il2CppReferenceArray<PointInfo> infernalTop()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.633f, -113.0648f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-126.4739f, -75.46875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-89.9263f, -58.32923f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-97.13964f, -95.37251f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.01873f, -110.3005f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-55.30227f, -94.26687f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-51.93605f, -87.07923f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-61.55384f, -61.09375f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.48713f, -75.46875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-1.442664f, -114.1706f) });
            return list.ToArray();


        }

        public static Il2CppReferenceArray<PointInfo> infernalBottom()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.1521f, 0.8293701f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-125.0312f, -37.87251f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-99.54408f, -51.14187f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-86.07919f, -50.58891f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-96.17786f, -32.89657f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-91.84986f, -20.73313f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-85.11741f, -6.91095f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-73.57607f, -5.25235f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-60.59206f, -14.09859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-53.37871f, -28.47359f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-53.37871f, -40.63703f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-63.47739f, -51.69469f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-43.76093f, -46.16593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-29.81514f, -37.31969f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-17.31201f, -27.36781f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-9.136896f, -11.88703f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-1.442664f, -0.8292297f) });
            return list.ToArray();

        }


        public static Il2CppReferenceArray<PointInfo> quadLeft()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.633f, 62.75249f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-123.1077f, 55.01203f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100.5059f, 40.63703f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-77.42317f, 14.65141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-76.94229f, 6.35813f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.98051f, 14.09859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-59.63028f, 31.79093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-46.16537f, 43.40141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.14314f, 53.35343f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-4.328001f, 62.75249f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> quadTop()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-76.4614f, 1.93515f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.01873f, 11.88703f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-57.70672f, 32.89671f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-40.3947f, 49.48313f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-10.57957f, 62.75249f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-29.81514f, 72.15141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-43.76093f, 79.89187f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-59.14938f, 94.26687f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.49962f, 109.7477f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> quadRight()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-11.54135f, 62.19953f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-38.47114f, 76.02171f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-52.89782f, 88.73797f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-74.53785f, 110.8534f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-94.7352f, 92.05531f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-108.2001f, 80.99765f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-138.0152f, 62.75249f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> quadBottom()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.49962f, 109.7477f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-96.17786f, 89.29079f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-115.4134f, 76.57453f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-135.1299f, 64.41109f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-121.665f, 55.01203f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-107.2383f, 45.61311f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-94.7352f, 35.66109f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-84.15562f, 22.94469f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-75.98051f, 4.69953f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> bloodles1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(16.35023f, -114.1706f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(15.38846f, -99.24281f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(23.56357f, -81.55047f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(29.81514f, -67.17547f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(13.46491f, -45.61297f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(13.46491f, -35.10813f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25.48713f, -19.62735f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(24.52536f, 1.38219f) });
            return list.ToArray();



        }
        public static Il2CppReferenceArray<PointInfo> bloodles2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(39.43293f, -114.7236f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.47114f, -100.3486f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(41.83736f, -89.84375f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.97426f, -77.68031f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(52.89782f, -65.51687f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.47114f, -46.71875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(36.54758f, -36.21391f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(40.87559f, -26.81485f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(49.05072f, -20.18031f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.01249f, -9.675469f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(44.72271f, 0.8293701f) });
            return list.ToArray();


        }

        public static Il2CppReferenceArray<PointInfo> bloodles3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(68.76717f, -113.6178f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(67.80539f, -100.3486f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(71.6525f, -89.29079f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(78.86584f, -78.78595f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(81.27029f, -66.06969f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(75.01872f, -55.01203f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(66.84361f, -46.16593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(65.40096f, -37.87251f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(71.6525f, -26.81485f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(78.38496f, -21.28595f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(79.34673f, -8.01687f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(75.49962f, 0.2764099f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> bloodles3R()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(75.49962f, 0.2764099f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(79.34673f, -15.20423f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(75.49962f, -22.39187f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(66.36272f, -34.00235f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(64.43916f, -43.95423f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(69.24807f, -51.14187f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(76.4614f, -55.56485f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(81.75118f, -66.06969f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(81.75118f, -76.57453f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(76.94228f, -82.65625f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(70.20984f, -90.39657f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(67.80539f, -96.47829f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(67.80539f, -105.8773f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(69.24807f, -114.1706f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> bloodles4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(103.3912f, 0.8293701f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(106.7574f, -9.12251f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(107.2383f, -19.07453f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(101.9485f, -25.15625f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(96.65875f, -31.23797f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(93.29253f, -38.42547f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(92.33074f, -45.61297f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(95.21609f, -48.93031f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(102.4294f, -56.11781f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(107.2383f, -60.54093f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(110.6045f, -69.93985f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(107.7192f, -78.23313f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(100.5059f, -85.97359f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(96.65875f, -96.47829f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(95.21609f, -103.113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(98.10142f, -114.1706f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> bloodles5()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(129.3592f, 0.2764099f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(133.2063f, -8.01687f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(132.7254f, -19.07453f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(127.4357f, -26.26203f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(121.665f, -32.89657f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(119.2606f, -41.74281f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(119.2606f, -47.82453f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(125.5121f, -54.45907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(132.2446f, -58.32923f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(135.6108f, -64.41095f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(136.5726f, -73.25719f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(133.6872f, -80.99751f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(126.4739f, -85.97359f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(123.1077f, -93.71391f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(121.1841f, -99.79563f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(125.0312f, -114.1706f) });
            return list.ToArray();



        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var areaa0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            areaa0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.1904f, -113.3414f));
            areaa0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.1904f, -113.3414f));
            areaa0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.1521f, 112.7886f));
            areaa0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.1904f, 113.3414f));
            areaa0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, -113.8942f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(areaa0), 0, (AreaType)2));

            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.2404469f, 0f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-0.2404469f, -114.447f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.3926f, -115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.8735f, 1.10578f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 0, (AreaType)0));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.8735f, -35.38468f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-139.6983f, -40.36062f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.2939f, -49.20672f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.813f, -56.94704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-139.2175f, -62.47594f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.8735f, -68.55766f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 0, (AreaType)2));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-74.77828f, -21.00968f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.56495f, -24.32688f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.12228f, -30.96142f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.4885f, -37.04328f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.25917f, -39.2547f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.02985f, -35.38468f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.4343f, -29.30282f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.10629f, -23.77406f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 0, (AreaType)2));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.25917f, -71.875f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.00761f, -74.08642f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.08406f, -79.0625f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.04583f, -85.69704f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-72.85473f, -87.35578f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.58718f, -85.69704f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.51073f, -81.27406f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.02985f, -76.29812f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-78.6254f, -73.5336f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 0, (AreaType)2));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.202226f, -35.38468f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.858228f, -40.91344f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.26268f, -50.86532f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.26268f, -56.39408f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.858228f, -61.37016f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-4.087563f, -66.3461f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-0.2404469f, -68.0047f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 0, (AreaType)2));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.15426f, -100.072f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.38359f, -96.7547f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.94091f, -90.12016f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.19248f, -84.5914f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.44404f, -89.01438f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.3676f, -94.54328f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.11604f, -98.9664f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5), 0, (AreaType)1));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.4023f, -29.30282f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-103.6316f, -27.0914f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.7463f, -20.45672f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.1125f, -15.48078f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.8832f, -13.82204f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115.173f, -17.69234f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-114.2112f, -24.32688f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.8832f, -28.19704f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6), 0, (AreaType)1));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.59692f, -29.30282f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.34537f, -28.19704f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.46003f, -21.5625f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.46003f, -16.0336f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.74981f, -12.16344f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.0396f, -12.16344f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.40582f, -17.69234f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.92493f, -22.66828f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.48226f, -26.53844f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.0396f, -28.75f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7), 0, (AreaType)2));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.4023f, -98.9664f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.5934f, -97.86062f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.2272f, -92.33172f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.7463f, -87.9086f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-104.1125f, -82.93266f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.4405f, -82.3797f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.2494f, -84.5914f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115.6539f, -86.80296f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115.6539f, -92.88468f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-115.6539f, -96.20188f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.7303f, -98.9664f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-110.3641f, -100.072f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8), 0, (AreaType)2));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.2404469f, 35.66109f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.77204f, 35.66109f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.77204f, 0.2764099f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(58.42804f, 1.38219f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.94717f, 35.66109f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.01385f, 36.21405f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.53296f, 0.8293701f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.189f, 1.38219f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.7081f, 35.66109f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.9117f, 35.66109f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.3926f, 43.95437f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.189f, 44.50719f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.6699f, 74.36297f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.9117f, 75.46875f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.8735f, 83.20921f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.6699f, 83.76203f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.6699f, 114.1708f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.53296f, 115.2764f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.53296f, 84.86781f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(58.42804f, 83.20921f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.94717f, 114.1708f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(50.25293f, 115.2764f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.77204f, 83.20921f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.7213408f, 83.76203f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.7213408f, 75.46875f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.81027f, 76.02171f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.29115f, 44.50719f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.2404469f, 43.95437f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9), 0, (AreaType)0));
            var area10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.46627f, 42.84859f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.01385f, 42.84859f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.01385f, 75.46875f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.94717f, 76.02171f));
            newareas.Add(new AreaModel("lol10", new Assets.Scripts.Simulation.SMath.Polygon(area10), 0, (AreaType)1));
            var area11 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.8735f, 40.08407f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.0806f, 45.61311f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-124.3099f, 52.80047f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-88.24318f, 21.83905f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.38009f, 1.38219f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.6956f, 0.8293701f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.58094f, 12.99281f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.27517f, 22.39187f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.20847f, 51.14187f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.55246f, 36.76687f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-0.2404469f, 40.08407f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.2404469f, 85.42077f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.36135f, 82.10343f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.24669f, 76.02171f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.8325f, 102.5602f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-56.50449f, 114.7236f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-96.4183f, 116.3822f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.05209f, 100.9014f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-125.7526f, 75.46875f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-133.4468f, 84.86781f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.3926f, 85.42077f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.3926f, 39.53125f));
            newareas.Add(new AreaModel("lol11", new Assets.Scripts.Simulation.SMath.Polygon(area11), 0, (AreaType)0));
            var area12 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.5774f, 67.72843f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.0965f, 58.32937f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.51073f, 29.02641f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.52673f, 29.57937f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.42181f, 58.32937f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.94091f, 67.72843f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.08406f, 95.92547f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.4343f, 95.37265f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-119.501f, 67.17547f));
            newareas.Add(new AreaModel("lol12", new Assets.Scripts.Simulation.SMath.Polygon(area12), 0, (AreaType)2));
            var area13 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-72.37384f, 45.06015f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-56.0236f, 63.30531f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.00761f, 79.33905f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-91.12852f, 69.38703f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-89.68585f, 53.90625f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.25917f, 45.06015f));
            newareas.Add(new AreaModel("lol13", new Assets.Scripts.Simulation.SMath.Polygon(area13), 0, (AreaType)1));
            var area14 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.202217f, -27.92063f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-0.2404469f, 0.2764099f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.65113f, 0.2764099f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.05559f, -15.75719f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.65113f, -26.81485f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(18.51424f, -33.44953f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.59068f, -43.40141f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.61292f, -56.11781f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.97914f, -63.30531f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.46002f, -74.36297f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.53648f, -80.99751f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.32312f, -90.39657f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.88046f, -114.1706f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.10979f, -114.1706f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.26267f, -100.3486f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.66712f, -90.39657f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.39957f, -79.89187f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.72758f, -73.81015f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.72758f, -66.62251f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.84225f, -60.54093f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.55247f, -55.56485f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.70535f, -51.14187f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.33911f, -47.82453f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.858236f, -40.08407f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.33911f, -35.10813f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.18623f, -30.13219f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.07158f, -25.15625f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.36135f, -19.07453f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.28491f, -15.20423f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.74356f, -16.86297f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.7213408f, -27.92063f));
            newareas.Add(new AreaModel("lol14", new Assets.Scripts.Simulation.SMath.Polygon(area14), 0, (AreaType)0));
            var area15 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.59694f, -0.2764099f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.40582f, -16.86297f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.00137f, -22.94469f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.71159f, -25.70907f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.9027f, -31.23797f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.46002f, -36.21391f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.46002f, -42.29563f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.9027f, -46.71875f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.26892f, -51.69469f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.63515f, -56.67063f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.96315f, -60.54093f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.40582f, -61.64657f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.29115f, -68.28125f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.77204f, -74.91579f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.88671f, -79.33891f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.0396f, -83.76203f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.19248f, -88.18515f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.82626f, -93.71391f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.34537f, -100.3486f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.34537f, -106.4303f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.78803f, -113.6178f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.92493f, -114.1706f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.0396f, -106.4303f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.5587f, -102.0072f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.0396f, -98.13703f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.44403f, -94.26687f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.32938f, -89.29079f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(50.73383f, -85.42063f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.61916f, -79.33891f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.06182f, -74.91579f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.54272f, -67.72829f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.10005f, -60.54093f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(51.6956f, -55.56485f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.84848f, -51.14187f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.48226f, -46.71875f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.59694f, -44.50719f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.63515f, -40.63703f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.07781f, -36.76687f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.40582f, -32.34375f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.81027f, -28.47359f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(51.6956f, -22.94469f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.61916f, -15.20423f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.61916f, -8.01687f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(51.21471f, -2.48797f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(50.25293f, 0.2764099f));
            newareas.Add(new AreaModel("lol15", new Assets.Scripts.Simulation.SMath.Polygon(area15), 0, (AreaType)0));
            var area16 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.45029f, -0.2764099f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.25917f, -12.43985f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.25917f, -17.41593f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(72.37384f, -20.73313f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(67.56496f, -24.60329f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.71784f, -32.89657f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.31339f, -41.18985f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.27516f, -50.03595f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.12228f, -53.35329f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.58094f, -61.64657f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.06182f, -78.78595f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.81651f, -79.89187f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.67961f, -93.71391f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.23695f, -101.4542f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.23695f, -110.3005f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.67961f, -114.1706f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(72.85474f, -114.7236f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.93118f, -104.2188f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.89295f, -97.58421f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.25917f, -93.16095f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.54895f, -84.86781f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.9534f, -78.23313f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.87696f, -71.59859f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.9534f, -61.64657f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.58718f, -53.90625f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.35786f, -53.90625f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.34187f, -33.44953f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.54895f, -25.15625f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.4343f, -14.65141f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.54895f, -0.2764099f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.89295f, -0.2764099f));
            newareas.Add(new AreaModel("lol16", new Assets.Scripts.Simulation.SMath.Polygon(area16), 0, (AreaType)0));
            var area17 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.2654f, 0.2764099f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.0743f, -12.99281f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.34187f, -22.39187f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.01385f, -27.92063f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.64764f, -35.10813f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.16674f, -42.84859f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.12852f, -50.58891f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.49475f, -55.01203f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.2654f, -59.98797f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(104.5934f, -64.41095f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.517f, -72.15141f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.0743f, -77.12735f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.7463f, -81.55047f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.86097f, -84.86781f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.49475f, -90.94953f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.05209f, -97.58421f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.0903f, -105.8773f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.57119f, -112.512f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.30363f, -114.1706f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.34187f, -106.4303f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.34187f, -99.24281f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.6699f, -93.16095f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.0361f, -89.84375f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.4023f, -85.42063f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.3259f, -77.12735f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8068f, -68.83407f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.8832f, -60.54093f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.9979f, -52.80047f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.189f, -47.27157f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.34187f, -44.50719f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.8992f, -40.08407f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.86097f, -35.10813f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.7081f, -30.13219f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.9597f, -25.70907f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.4405f, -15.75719f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(108.4405f, -7.46391f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.9597f, -3.59375f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.4788f, -0.8292297f));
            newareas.Add(new AreaModel("lol17", new Assets.Scripts.Simulation.SMath.Polygon(area17), 0, (AreaType)0));
            var area18 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.4628f, -114.1706f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.9819f, -109.7475f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.5392f, -104.7716f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.5392f, -95.92547f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.9819f, -90.39657f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.829f, -84.86781f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(128.157f, -80.44469f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(131.5232f, -74.91579f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(132.0041f, -67.72829f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.0806f, -61.64657f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.7908f, -57.77641f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.0201f, -51.69469f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.6157f, -46.16593f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.6157f, -39.53125f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.0583f, -31.79093f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.4245f, -25.15625f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(127.1952f, -18.52157f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.0806f, -12.43985f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.0806f, -8.01687f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(126.2334f, -0.2764099f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.3703f, 0.8293701f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(136.813f, -8.01687f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(137.7748f, -15.20423f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.8512f, -22.94469f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(132.485f, -26.81485f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(128.157f, -31.23797f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.7908f, -36.21391f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.3481f, -41.18985f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.3481f, -44.50719f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(126.7143f, -47.27157f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(131.5232f, -52.80047f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(134.4086f, -57.77641f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(137.2939f, -62.19953f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(138.2557f, -71.59859f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(138.7366f, -75.46875f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(136.3321f, -82.65625f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.4468f, -87.63219f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.5614f, -92.60813f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(126.7143f, -98.13703f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(125.7526f, -102.0072f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(125.7526f, -109.7475f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(127.1952f, -114.1706f));
            newareas.Add(new AreaModel("lol18", new Assets.Scripts.Simulation.SMath.Polygon(area18), 0, (AreaType)0));
            var area19 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.14802f, -80.44469f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.80402f, -75.46875f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.68936f, -67.72829f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.80402f, -62.19953f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.4378f, -57.22359f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.66712f, -55.01203f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.453785f, -56.67063f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.049333f, -63.30531f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.644899f, -68.28125f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.530227f, -74.91579f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.33911f, -79.33891f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.66712f, -80.99751f));
            newareas.Add(new AreaModel("lol19", new Assets.Scripts.Simulation.SMath.Polygon(area19), 0, (AreaType)1));
            var area20 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.65739f, -56.67063f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.27516f, -48.37735f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.31339f, -40.08407f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.87072f, -34.55531f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(51.21471f, -29.02641f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.96315f, -30.13219f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.15425f, -37.87251f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.15425f, -44.50719f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.48226f, -48.93031f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.13826f, -55.56485f));
            newareas.Add(new AreaModel("lol20", new Assets.Scripts.Simulation.SMath.Polygon(area20), 0, (AreaType)1));
            var area21 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.05209f, -24.60329f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.30363f, -22.39187f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.1507f, -17.96875f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.1507f, -11.33407f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.2654f, -6.91095f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.86097f, -3.59375f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.0903f, -0.2764099f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.76231f, -0.2764099f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.4343f, -6.35813f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.99163f, -15.20423f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.35786f, -22.94469f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.16674f, -24.60329f));
            newareas.Add(new AreaModel("lol21", new Assets.Scripts.Simulation.SMath.Polygon(area21), 0, (AreaType)1));











            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            AlternateRoundMultiPathSplitterModel arm = new AlternateRoundMultiPathSplitterModel("", new string[]
                    {
                        "infernalTop",
                        "bloodles1",
                        "bloodles5",
                        "ouch1",
                        "ouch2",
                        "ouch3",
                        "ouch4",
                        "quadLeft",
                        "quadTop",
                        "quadRight",
                        "quadBottom",
                        "infernalBottom",
                        "bloodles2",
                        "bloodles4",
                        "ouch1",
                        "ouch2",
                        "ouch3",
                        "ouch4",
                        "quadLeft",
                        "quadTop",
                        "quadRight",
                        "quadBottom",
                        "infernalTop",
                        "bloodles3",
                        "bloodles3R",
                        "ouch1",
                        "ouch2",
                        "ouch3",
                        "ouch4",
                        "quadLeft",
                        "quadTop",
                        "quadRight",
                        "quadBottom",
                        "infernalBottom",
                        "bloodles2",
                        "bloodles4",
                        "ouch1",
                        "ouch2",
                        "ouch3",
                        "ouch4",
                        "quadLeft",
                        "quadTop",
                        "quadRight",
                        "quadBottom",
                    }, new int[]
                    {
                        11,11,11,11
                    });


            return new PathSpawnerModel("", arm, arm);
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("infernalTop", infernalTop(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("infernalBottom", infernalBottom(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("bloodles1", bloodles1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("bloodles2", bloodles2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("bloodles3", bloodles3(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("bloodles3R", bloodles3R(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("bloodles4", bloodles4(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("bloodles5", bloodles5(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("ouch1", ouch1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("ouch2", ouch2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("ouch3", ouch3(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("ouch4", ouch4(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("quadLeft", quadLeft(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("quadTop", quadTop(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("quadRight", quadRight(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("quadBottom", quadBottom(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),


                    };
        }


    }
}
