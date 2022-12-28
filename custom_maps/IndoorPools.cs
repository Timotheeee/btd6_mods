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

namespace custom_maps
{
    class IndoorPoolsData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.4074f, 92f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.148145f, 92.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(3.518522f, -92.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.4074f, -92.21296f) });
            return list.ToArray();
        }








        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.2222f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.3333f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.5926f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.8519f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.8519f, 81.9907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.92593f, 80.92591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.370373f, -102.8611f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.3333f, -102.2223f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, -81.35183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.40742f, -81.56479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.03704f, 102.4352f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.2222f, 102.8611f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.2222f, -52.81479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.2963f, -53.2407f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.48148f, 52.60197f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.2222f, 52.60197f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-143.5185f, 47.91662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-143.3333f, -47.91662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.66667f, -48.12958f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.92593f, 48.34267f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-143.5185f, 48.34267f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.66668f, -53.02774f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, -52.60183f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.5926f, 52.81479f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.11112f, 53.02774f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.48149f, 44.29634f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.66667f, -46.85183f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.7778f, -45.14817f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.5926f, 46.42591f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.29631f, 45.36113f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-142.963f, -47.91662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.48149f, -47.91662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.48149f, 47.49084f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-142.7778f, 47.27774f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)1));

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