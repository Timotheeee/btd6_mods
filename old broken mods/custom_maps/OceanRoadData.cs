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

namespace custom_maps
{
    class OceanRoadData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(118.1482f, -114.787f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(118.1482f, -51.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(72.03704f, -51.96296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(72.77778f, -83.48154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-114.4445f, -83.48154f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-114.0741f, 2.342676f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-76.11112f, 1.703662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-76.11112f, -35.9907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-38.51852f, -35.77774f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-39.81482f, 1.703662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-3.518522f, 0.851831f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-3.518522f, -35.9907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(33.14816f, -37.05549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(32.77778f, 42.59253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(76.48148f, 42.16676f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(75.00001f, -6.601831f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(120.1852f, -8.518451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(120f, 77.30563f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-10.74075f, 77.30563f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-9.444444f, 43.65746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.5926f, 43.23155f) });
            return list.ToArray();
        }




        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            /*var area0_ = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0_.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, -115.2764f));
            area0_.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.1904f, -114.1706f));
            area0_.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6712f, 114.1708f));
            area0_.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, 114.7236f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0_), 0, (AreaType)2));
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.8735f, -114.447f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.8735f, -105.0481f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.34187f, 89.01438f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.34187f, 106.7067f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(140.6601f, 107.2597f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(140.6601f, 74.08656f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.7463f, 74.08656f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-138.2557f, -114.447f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)0));*/
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -114.3611f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -114.1482f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.4815f, -114.1482f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.4815f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(108.3333f, -112.8703f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.4074f, -65.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(83.33334f, -64.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80f, -93.4907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-122.5926f, -92.85183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.8889f, -92.85183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-123.3334f, 11.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-66.85186f, 9.370422f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.37038f, -22.36099f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-51.66667f, -22.36099f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.70371f, 10.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(4.999996f, 12.35183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.555553f, -22.36099f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(20.55556f, -23f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(23.7037f, 50.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(84.44446f, 52.17591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.29631f, 5.537042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.037f, 6.814789f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.4074f, 64.52775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.1851887f, 63.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.481483f, 34.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.2222f, 30.45366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-146.8519f, 54.73155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.51852f, 55.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-20.55556f, 85.18521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(129.0741f, 87.10183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.5185f, -18.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.48149f, -18.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.85187f, -19.16662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(65.37038f, 29.17591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.8889f, 28.53704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(40.74074f, -45.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.77778f, -46.63887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.51852f, -12.77775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.33334f, -13.20366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-29.07408f, -14.05549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30f, -46.63887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-84.25926f, -46.21296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.48149f, -13.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-102.5926f, -12.56479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-103.8889f, -70.06479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(58.88889f, -70.91662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.48149f, -43.44451f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.963f, -42.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.1482f, -113.5093f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-61.85186f, 12.35183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.55556f, 6.175915f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.66667f, 4.259295f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-40.92593f, 13.84254f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.25927f, 20.87042f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.37038f, 27.25929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.40741f, 29.38887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.14815f, 27.25929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-60.18519f, 22.57408f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-141.6667f, -6.388873f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-135f, -3.407465f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-131.6667f, 3.194507f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-134.6296f, 10.22225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-137.5926f, 14.48155f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-142.5926f, 13.62972f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.4074f, 11.5f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, 4.898169f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-146.4815f, -0.2129578f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.55556f, 87.52789f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-19.07408f, 91.78704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.33333f, 98.81493f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.03703f, 106.9075f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-21.2963f, 109.8889f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.59259f, 110.9538f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.77778f, 105.8427f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.88889f, 99.45366f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.5926f, 94.12958f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(135f, -31.73141f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(144.6296f, -40.46296f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.1111f, -25.98155f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(141.4815f, -25.55549f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, 64.9538f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-142.7778f, 66.87042f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.3333f, 63.25f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-93.51852f, 69.21296f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-61.48148f, 63.25f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-40.37037f, 70.70366f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.66667f, 79.64817f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.03704f, 100.3055f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.14816f, 112.8704f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.92593f, 112.8704f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.22223f, 112.6575f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-146.8519f, 113.5093f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6), 10, (AreaType)1));











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