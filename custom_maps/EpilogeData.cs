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
    class EpilogeData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> longTrack()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-129.8148f, 115f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-129.0741f, 92f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-114.4445f, 91.14817f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-114.0741f, 83.48154f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-125.7408f, 82.2038f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-125f, 74.96296f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-108.5185f, 75.17591f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-107.2222f, 102.2223f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-88.51852f, 103.0741f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-87.77779f, 95.62042f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-96.11112f, 94.76859f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-96.66668f, 84.75929f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-75.00001f, 83.48154f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-75.18519f, 75.38887f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-87.40742f, 75.38887f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-86.11111f, 90.08338f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-56.2963f, 90.29633f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-31.48148f, 90.29633f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-13.14815f, 90.72225f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-12.03704f, 99.02775f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-23.51852f, 99.02775f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-24.07408f, 75.60183f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-34.81482f, 75.81479f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-34.81482f, 83.26859f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-5.555553f, 84.33338f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-2.407408f, 92.42591f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(5.185194f, 93.27775f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(4.259259f, 79.22225f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-15.55555f, 77.09267f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-16.85186f, 60.6945f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-26.66667f, 49.62042f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-25.92593f, 32.79634f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-23.14816f, 22.57408f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-28.51852f, 17.03704f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-37.40741f, 18.31479f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-39.81482f, 23.85197f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-35.74074f, 31.09267f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-29.62963f, 32.58338f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-16.2963f, 34.07409f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-2.222219f, 39.39817f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(7.407404f, 43.01859f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(17.96297f, 46.42591f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(19.81482f, 53.4538f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(16.66668f, 58.13887f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(10.18519f, 59.84267f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(3.703702f, 56.64817f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(2.222228f, 51.32409f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(8.333338f, 37.90746f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(13.70371f, 33.0093f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(21.85185f, 31.09267f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(30.55557f, 28.32408f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(39.25927f, 23.63887f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(44.81482f, 18.95366f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(48.51852f, 9.796338f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(50.00001f, 3.620422f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(52.77778f, 0f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(56.85186f, -1.064789f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(62.22223f, 1.277887f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(67.03705f, 5.962958f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(72.77778f, 9.370422f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(84.25926f, 12.77775f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(93.88889f, 12.13887f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(102.7778f, 8.731549f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(109.8148f, 3.407465f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(113.3333f, -7.453662f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(111.4815f, -15.97225f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(104.2593f, -23.21296f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(96.11112f, -27.89817f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(85.1852f, -30.87958f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(76.48148f, -29.17591f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(69.07407f, -25.98155f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(71.66666f, -22.14817f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(76.11112f, -21.72225f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(82.77779f, -23.42591f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(90.55557f, -22.14817f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(97.5926f, -20.01845f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(102.963f, -14.48141f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(104.6296f, -6.175915f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(100.7408f, 1.064789f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(93.33334f, 5.962958f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(83.8889f, 6.389014f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(78.33335f, 3.194507f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(78.51853f, -0.4259155f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(83.33334f, -1.064789f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(89.62964f, -1.703662f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(93.88889f, -4.046197f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(95.37038f, -8.944366f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(93.51853f, -14.05549f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(87.40742f, -15.97225f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(80.74074f, -15.33324f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(75.55556f, -11.71296f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(59.07409f, -15.33324f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(41.66667f, -20.44437f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(22.03703f, -24.4907f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(12.96296f, -28.53704f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(9.074075f, -36.20366f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(6.481487f, -43.87028f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(1.111114f, -48.55549f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-7.777781f, -52.60183f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-21.48148f, -53.02774f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-31.48148f, -48.12958f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-36.2963f, -35.56479f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-32.96297f, -25.98155f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-26.48149f, -20.44437f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-16.2963f, -16.61113f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-4.629627f, -15.54634f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(6.296289f, -17.88887f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(12.22222f, -22.14817f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(10.00001f, -25.98155f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(4.999996f, -23.42591f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-2.592597f, -21.08338f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-13.33333f, -21.08338f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-22.22222f, -24.4907f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-28.33334f, -30.02775f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-28.33334f, -37.90732f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-20.74075f, -44.08324f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-13.33333f, -44.72225f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-4.814816f, -39.61113f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-5.555553f, -33.0093f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-11.66667f, -30.87958f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-16.85186f, -34.28704f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-18.70371f, -39.61113f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-16.66667f, -51.11098f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-15.92593f, -61.5462f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-15.92593f, -76.02775f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-16.11111f, -92f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-16.11111f, -96.25916f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-13.7037f, -104.9907f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-6.666667f, -106.4814f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-0.3703684f, -104.9907f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(1.666671f, -99.45366f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-2.222219f, -94.98154f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-5.92593f, -95.83338f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-10.37037f, -100.5184f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-11.85185f, -107.5462f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-9.444444f, -110.9537f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-3.148145f, -112.2315f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(6.296289f, -112.2315f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(12.77778f, -112.6575f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(21.2963f, -111.8055f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(27.96296f, -109.037f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(26.85185f, -101.7963f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(22.96297f, -95.40733f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(15.92592f, -95.19437f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(12.77778f, -99.87958f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(15.92592f, -105.4166f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(21.2963f, -106.0556f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(27.96296f, -103.5f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(31.48148f, -95.40733f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(30.55557f, -89.23141f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(30.18519f, -81.77775f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(25.37037f, -77.51845f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(17.59259f, -76.66662f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(13.14815f, -79.22225f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(12.03704f, -86.03704f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(15.55556f, -87.95366f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(21.48149f, -88.16662f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(26.48149f, -84.33338f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(27.96296f, -77.94437f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(23.88888f, -73.04633f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(11.66666f, -72.40746f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-8.703707f, -72.62028f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-31.48148f, -72.62028f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-45.92593f, -73.04633f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-49.81482f, -79.43521f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-60.55556f, -78.58338f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-72.03704f, -80.71296f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-74.62964f, -80.28704f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-71.85186f, -85.82408f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-68.33334f, -90.93521f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-74.44445f, -89.4445f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-79.44444f, -93.06479f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-78.51853f, -97.11112f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-80.55556f, -99.45366f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-78.70371f, -104.7777f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-87.03705f, -106.0556f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-91.66667f, -100.3055f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-84.25926f, -97.32408f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-87.96297f, -87.95366f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-97.5926f, -90.2962f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-102.4074f, -84.75929f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-111.2963f, -86.46296f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-102.7778f, -91.78704f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-107.5926f, -94.55549f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-117.4074f, -88.59254f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-127.963f, -89.23141f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-126.4815f, -94.76845f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-132.963f, -95.19437f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-132.7778f, -97.32408f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-113.8889f, -99.66662f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-112.7778f, -108.611f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-117.5926f, -111.1666f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-121.2963f, -107.7593f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-132.5926f, -108.611f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-126.4815f, -113.7221f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-131.1111f, -114.787f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-136.8519f, -111.5925f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-144.4445f, -112.8703f)
            });
            list.Add(new PointInfo()
            {
                bloonScale = 1,
                bloonsInvulnerable = false,
                distance = 1,
                id = r.NextDouble() + string.Empty,
                moabScale = 1,
                moabsInvulnerable = false,
                rotation = 0,
                point = new Assets.Scripts.Simulation.SMath.Vector3(-142.5926f, -114.787f)
            });
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
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 0, (AreaType)2));












            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "longTrack",
                    }), new SplitterModel("", new string[]
                    {
                        "longTrack",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("longTrack", longTrack(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}
