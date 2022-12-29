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
    class ExpressShipping
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-125.7408f, -113.2963f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-125.1852f, -34.28704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-65.92593f, -34.92591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-66.48149f, -106.6944f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-126.4815f, -106.6944f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-126.6667f, 38.54634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.7407368f, 38.33338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-1.296294f, -106.0556f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-126.6667f, -106.2684f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-126.4815f, 103.5f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(59.62964f, 102.6482f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(60f, -107.1204f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-126.2963f, -105.2037f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-125.7408f, 103.0741f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(120.5556f, 103.5f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(120.5556f, -113.2963f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.4074f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.8519f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6667f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.6296f, -114.3611f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.7037f, -31.94451f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.03704f, -30.45366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.5926f, -109.8889f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.8519f, -109.6759f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.0371f, -39.18521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-70f, -40.46296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-69.25927f, -101.5832f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.2222f, -102.8611f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.8519f, -113.2963f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.0741f, -113.5093f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.7037f, 41.10183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.222228f, 42.59253f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.592588f, -109.6759f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.6667f, -109.6759f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120.9259f, 33.43521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-5.185184f, 33.86113f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-4.444448f, -102.4351f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.4815f, -102.8611f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.4815f, -113.0834f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.6296f, -114.3611f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.7037f, 109.25f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.96297f, 107.3334f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.8889f, -109.8889f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.6667f, -109.6759f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.7778f, 99.2407f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.62963f, 98.38887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.11112f, -101.5832f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.6667f, -102.6482f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.6667f, -112.8703f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.4445f, -113.7221f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.2593f, 108.3982f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(124.8148f, 107.7593f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.3704f, -113.2963f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(116.1111f, -113.2963f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(116.4815f, 98.38887f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-120.1852f, 98.60183f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.4815f, -114.1482f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));



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
                        new PathModel("Path1", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}