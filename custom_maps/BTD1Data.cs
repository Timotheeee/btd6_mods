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
    class BTD1Data
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-146.4815f, 10.22225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-58.8889f, 10.22225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-59.44445f, -53.2407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(1.666671f, -53.45366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(1.111114f, 63.88901f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-67.40742f, 64.10183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-68.14816f, 101.5834f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(91.2963f, 101.1575f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(90.74075f, 32.15746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(33.33334f, 31.73155f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(32.96296f, -16.82408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(97.96297f, -16.39817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(97.5926f, -100.7314f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(31.11111f, -102.2223f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(29.62963f, -114.787f) });
            return list.ToArray();
        }
        




        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-154.6297f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.2593f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.8148f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-154.6297f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.6667f, 13.62972f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.70371f, 11.92592f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.92593f, -50.47225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.592592f, -50.0462f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.962961f, 47.27774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-74.44445f, 49.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-74.25927f, 104.9908f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.62965f, 103.287f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.77779f, 19.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.03705f, 16.82422f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.11111f, -11.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.6667f, -14.26845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.8519f, -112.6575f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.03703f, -114.5741f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.22223f, -98.38887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.22223f, -95.62042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(89.07408f, -31.51845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.88888f, -29.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.96297f, 34.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.74074f, 35.56479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.2963f, 85.18521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.51853f, 87.10183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-57.77778f, 68.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.888895f, 66.23154f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.888895f, -69.21296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.77779f, -69.85183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.51853f, -6.175915f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.037f, -6.814789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, 12.77775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.66667f, 13.41676f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 10, (AreaType)0));


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
