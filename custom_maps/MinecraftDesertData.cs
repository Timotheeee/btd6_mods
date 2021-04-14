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

namespace custom_maps
{
    class MinecraftDesertData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-94.62964f, 115f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-94.44445f, 38.97225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-78.33334f, 39.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-79.07409f, 2.981549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-62.5926f, 2.981549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-63.14816f, -15.54634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-15.92593f, -16.18507f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-16.2963f, 2.981549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9259255f, 1.91662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-0.9259255f, 20.44451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(46.11111f, 20.65746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(46.48149f, -16.39817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(92.77778f, -15.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(92.77778f, 2.555493f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.7778f, 2.981549f) });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.5185f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.4815f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.8519f, 29.81479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-86.85186f, 29.81479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-86.66667f, -6.388873f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.92593f, -6.601831f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.37038f, -24.4907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.148149f, -24.70366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.148149f, -6.814789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.407404f, -7.027746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.407404f, 11.07408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.14815f, 10.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.33333f, -24.91662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.7408f, -25.12958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.2963f, -7.453662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, -6.601831f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, 12.35183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.55556f, 11.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(85.37038f, -5.962958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.44445f, -6.388873f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.07407f, 29.81479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.148149f, 30.45366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.518517f, 12.56493f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.44445f, 11.92592f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.88889f, -6.388873f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.62964f, -5.962958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-55.00001f, 12.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.74075f, 12.35183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.55556f, 47.70366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-86.48149f, 48.34267f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-85.55556f, 115f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.96297f, 67.50929f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.888886f, 67.72225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.259264f, 84.12042f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.96297f, 83.48154f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.07408f, 12.9907f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.55556f, 12.77775f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.37037f, 28.75f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.44445f, 29.17591f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.148141f, -41.52774f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.85185f, -41.52774f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.03703f, -25.12958f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.962961f, -25.12958f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.70371f, -77.94437f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.62963f, -77.94437f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.62963f, -61.33324f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.70371f, -61.33324f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.37038f, 31.51845f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.44446f, 30.66662f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.8889f, 47.06479f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.00001f, 47.91662f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.5926f, 67.50929f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(131.2963f, 68.14817f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(131.8519f, 84.54633f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.5926f, 83.90746f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.0371f, -96.04633f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.2963f, -96.47225f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.2963f, -80.28704f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.4074f, -80.07408f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.2222f, 114.3611f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-117.2222f, 66.65746f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.0371f, 65.59254f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.0371f, 11.5f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-86.29631f, 11.5f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-86.11111f, -61.97225f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.11111f, -61.33324f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.92593f, -114.787f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.5926f, -114.787f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, 115f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9), 10, (AreaType)1));
            var area10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.222224f, -96.89817f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.407404f, -79.00929f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.59259f, -79.00929f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.33334f, -60.90746f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.70371f, -61.75929f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.33333f, -79.00929f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.62963f, -79.64817f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.81481f, -96.47225f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.81483f, -97.32408f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.44445f, -114.787f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.51852f, -114.787f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.14815f, -97.53704f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.962961f, -96.89817f));
            newareas.Add(new AreaModel("lol10", new Assets.Scripts.Simulation.SMath.Polygon(area10), 10, (AreaType)1));
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