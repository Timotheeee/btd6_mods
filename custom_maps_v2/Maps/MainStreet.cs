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

using Il2CppAssets.Scripts.Models.Map.Spawners;

namespace custommaps.Maps
{
    class MainStreet
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.963f, 2.129718f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.4074f, 2.129718f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.3703684f, -114.787f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.3703684f, 115f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150.1852f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(149.6296f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1852f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.222219f, 115f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.703702f, 2.768451f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150.1852f, 2.981549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150.3704f, -4.472253f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.777776f, -5.962958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.222219f, -114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.333342f, -114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.333342f, -4.685211f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.5185f, -4.898028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.5185f, 3.620422f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.407408f, 3.620422f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.333342f, 115f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.259259f, 115f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.5926f, -60.26845f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.03704f, -114.787f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, -114.787f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, -60.6945f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 10, (AreaType)1));

            return newareas.ToArray();
        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                    }), new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path1", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path2", track2(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}