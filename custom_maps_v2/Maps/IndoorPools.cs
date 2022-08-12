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
    class IndoorPools
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.7778f, 96.89817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.333342f, 96.89817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.333342f, -86.88887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(148.3333f, -86.88887f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.1852f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.6296f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.8148f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.5926f, 81.56479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.370373f, 81.35197f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.185184f, -102.0093f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.5185f, -102.4351f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.3333f, -81.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.03704f, -81.56479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.03704f, 102.2223f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.5926f, 101.3704f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-143.1482f, 47.70366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.66667f, 47.27774f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, 37.05563f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.96297f, 34.92591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.81482f, 34.92591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.62963f, 27.89817f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, 27.89817f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, 25.76859f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, 14.90746f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 15.12042f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.96297f, 13.20366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.62963f, 13.20366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.44444f, 6.175915f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, 6.814789f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, 4.685211f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, 4.685211f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.92593f, -6.814789f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.22223f, -6.814789f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, -9.370422f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.44444f, -9.370422f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.62963f, -15.7593f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, -15.33324f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, -17.67591f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.11111f, -17.03704f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.74074f, -28.32408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, -28.32408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, -30.2407f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.18519f, -30.2407f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.62963f, -36.84253f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.96297f, -37.05549f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.59259f, -38.97225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.48149f, -38.97225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.2963f, -47.70366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-142.5926f, -47.70366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-143.1482f, -43.87028f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-143.7037f, 43.23155f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-142.963f, 47.70366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.48149f, 48.12958f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 15, (AreaType)1));

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