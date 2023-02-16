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
using Il2CppAssets.Scripts.Unity.Scenes;
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
    class RinksRevengeData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.5926f, -33.64803f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(92.22222f, -34.28704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(104.2593f, -19.37958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(109.0741f, -0.851831f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(107.7778f, 18.95366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(99.25927f, 36.62958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(78.14816f, 42.59253f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(55.74074f, 46.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(39.07409f, 44.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.2222f, 45.36113f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(38.51853f, -113.9352f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(38.70371f, 81.9907f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(31.11111f, 95.83338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(21.66667f, 102.6482f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-0.3703684f, 106.2684f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-16.48148f, 106.4815f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-30.92593f, 102.4352f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40f, 90.50929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-46.48149f, 79.64817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.18518f, 64.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-44.25926f, -113.5093f) });
            return list.ToArray();
        }







        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.037f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.4074f, 114.787f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.8889f, -114.1482f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.1852f, 85.61112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.48148f, 100.9445f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(23.88888f, 107.7593f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(21.11111f, 112.8704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.333338f, 111.3796f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.296299f, 111.1668f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.25926f, 110.7407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.81482f, 108.6111f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.00001f, 96.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.81482f, 87.7407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.62963f, -114.5741f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.03704f, -114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-38.14815f, 85.61112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.37037f, 87.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.11111f, 95.83338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10f, 98.81493f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.48148f, 99.66676f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.59259f, 98.60183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.03704f, 86.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.40742f, -114.3611f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.4074f, -41.31479f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.07409f, -39.18521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(111.8519f, -22.57408f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.6296f, -5.749859f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.1852f, 7.240704f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(111.4815f, 26.62042f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105.3704f, 41.31493f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(93.33334f, 45.57409f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.70372f, 47.49084f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-146.1111f, 51.75f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.4074f, 39.18521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.1852f, 34.5f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.1111f, 26.83338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.8148f, 12.56493f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105.1852f, 1.277887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.1852f, -13.41662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(93.70371f, -24.06479f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.5926f, -27.47211f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -27.68521f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.2963f, 66.01859f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.07408f, 63.03704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.85186f, 63.67591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.48149f, 58.56479f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-70.92593f, 66.01859f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-69.25927f, 84.12042f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.74075f, 90.50929f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.37038f, 96.47225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.96297f, 96.89817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.5556f, 84.12042f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.9259f, 66.4445f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.62963f, -61.5462f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.37038f, -77.73141f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.51852f, -89.87042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(79.25927f, -89.87042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.74074f, -84.75929f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(91.66669f, -79.86098f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.37037f, -62.18521f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(74.81483f, -53.66662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.8889f, -58.13887f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.48149f, -55.79634f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.62963f, -61.33324f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.11112f, -77.30563f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)1));

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