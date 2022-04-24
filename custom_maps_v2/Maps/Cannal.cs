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
    class Cannal
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-148.1482f, -87.31479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-60.18519f, -86.03704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-59.25927f, -52.81479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-98.33334f, -51.75f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-96.85186f, 67.50929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-60.74075f, 69.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-59.62963f, 104.5648f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-149.2593f, 104.1389f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.037f, -89.87042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(57.59259f, -88.37958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(58.70371f, -54.94437f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(95.55556f, -53.66662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(96.2963f, 68.14817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(56.85186f, 69.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(57.96297f, 103.713f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(146.6667f, 104.1389f) });
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

            var area13 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.33333f, -114.7445f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.11111f, -114.7445f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.66667f, 114.2334f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.33333f, 112.7f));
            newareas.Add(new AreaModel("lol13", new Assets.Scripts.Simulation.SMath.Polygon(area13),Main.Empty(), 10, (AreaType)1));
            var area14 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.4444f, -114.2334f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.33333f, -113.7221f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.33333f, 114.7445f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.4444f, 115.2555f));
            newareas.Add(new AreaModel("lol14", new Assets.Scripts.Simulation.SMath.Polygon(area14),Main.Empty(), 10, (AreaType)0));
            var area15 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.2222f, -87.14436f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-124.4445f, 96.85563f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.55556f, 96.34451f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64f, 70.27775f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.3333f, 69.25549f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.7778f, -60.05563f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64f, -60.56662f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.33334f, -86.63338f));
            newareas.Add(new AreaModel("lol15", new Assets.Scripts.Simulation.SMath.Polygon(area15),Main.Empty(), 10, (AreaType)2));
            var area16 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            newareas.Add(new AreaModel("lol16", new Assets.Scripts.Simulation.SMath.Polygon(area16),Main.Empty(), 10, (AreaType)2));
            var area17 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.66667f, -113.7221f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.1111f, -113.7221f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.1111f, 115.2555f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.66667f, 113.2111f));
            newareas.Add(new AreaModel("lol17", new Assets.Scripts.Simulation.SMath.Polygon(area17),Main.Empty(), 10, (AreaType)0));
            var area18 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.33334f, -87.65549f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.8889f, -90.21113f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.4444f, 67.21113f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.8889f, 69.76662f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.4445f, 94.3f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.88889f, 93.78887f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.66667f, 70.27775f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.99999f, 68.74451f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.11111f, -61.58887f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.66667f, -61.58887f));
            newareas.Add(new AreaModel("lol18", new Assets.Scripts.Simulation.SMath.Polygon(area18),Main.Empty(), 10, (AreaType)2));
            var area21 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.88889f, -52.38887f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.33334f, -51.36662f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.77778f, 58.01112f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(-90.66666f, 61.07788f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.88889f, -50.85549f));
            newareas.Add(new AreaModel("lol21", new Assets.Scripts.Simulation.SMath.Polygon(area21),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area22 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.22221f, -52.9f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.11111f, 58.01112f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.44444f, 58.52225f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.55556f, -52.38887f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.22221f, -53.92211f));
            newareas.Add(new AreaModel("lol22", new Assets.Scripts.Simulation.SMath.Polygon(area22),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));












            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new AlternateRoundSplitterModel("", new string[]
                    {
                        "Path",
                        "Path (1)",
                    }), new AlternateRoundSplitterModel("", new string[]
                    {
                        "Path",
                        "Path (1)",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (1)", track2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}