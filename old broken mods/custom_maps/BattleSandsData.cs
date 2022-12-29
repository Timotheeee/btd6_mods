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
    class BattleSandsData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.4074f, 83.6945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-110.7408f, 82.84254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-110.7408f, 31.30549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-76.48149f, 30.2407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-75.74075f, -21.08338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-41.2963f, -21.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.92593f, -75.60183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-7.407404f, -73.68507f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-4.814816f, 82.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(28.8889f, 81.35197f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(29.25926f, 31.94451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(63.7037f, 31.09267f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(63.8889f, -21.93521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(98.51853f, -22.36099f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(99.62965f, -75.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(146.8519f, -75.81479f) });
            return list.ToArray();
        }





        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.5185f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.5926f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1482f, 68.78704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.4445f, 68.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-119.0741f, 17.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.11111f, 16.61113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-84.25926f, -30.2407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.74075f, -34.07409f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-74.25927f, -36.20366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.03704f, -38.54634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50.55556f, -83.05549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.2963f, -87.95366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-41.11111f, -90.08324f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.148145f, -89.4445f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.111114f, -86.03704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.592588f, -80.07408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(4.259259f, 68.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.62962f, 68.78704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.25926f, 28.11113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.77779f, 20.44451f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(27.77778f, 17.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.07407f, 15.54634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.44445f, -32.58324f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.81482f, -35.56479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.33334f, -38.54634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(89.25928f, -81.35183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.03704f, -87.7407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.4074f, -90.72225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, -66.23154f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.0741f, -66.87042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.6296f, -23.85183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105.9259f, -17.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.1111f, -14.26845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(75.37038f, -13.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.70371f, 33.0093f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.70372f, 38.12042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.62964f, 40.88887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.77779f, 39.82409f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(40.37038f, 40.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(39.07409f, 83.90746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.11112f, 89.65746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.51852f, 91.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10f, 91.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.51852f, 85.61112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.92593f, 79.64817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.48148f, -66.44437f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30f, -66.87042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.18519f, -23.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.77778f, -18.52775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-38.8889f, -14.48141f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.55556f, -13.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.37038f, 31.51845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-70f, 37.48155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.96297f, 40.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.81483f, 38.7593f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.8889f, 40.88887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.4815f, 86.88887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.6667f, 91.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, 91.14817f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-129.2593f, -37.90732f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.3704f, -47.27774f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.9259f, -55.37028f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-132.2222f, -60.6945f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-128.8889f, -69.42591f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.037f, -78.15746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.3704f, -80.71296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.18519f, -78.15746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.1852f, -71.55549f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.22223f, -60.48141f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-88.8889f, -46.85183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.03704f, -40.46296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.96297f, -34.49986f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-103.8889f, -30.66662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-112.4074f, -29.60183f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-121.1111f, -29.38887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-126.6667f, -33.43521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.3704f, -46.85183f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.14816f, 63.03704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.2963f, 55.37042f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(76.66668f, 51.32409f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.22223f, 44.93521f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.51852f, 39.61113f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(96.66668f, 38.33338f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.963f, 40.67591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(113.8889f, 47.06479f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.1111f, 54.94451f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(123.7037f, 68.36112f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.4074f, 75.38887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.1852f, 86.03704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.9259f, 92f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(108.1482f, 96.47225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(96.11112f, 98.17591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.33334f, 97.96296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.03705f, 93.4907f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(76.2963f, 88.59267f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.70372f, 71.55549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.25928f, 60.6945f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.14816f, 53.87958f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.62965f, 49.40746f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)1));
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