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

namespace custommaps.Maps
{
    class MonkeyLane
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.5926f, 12.77775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-81.85185f, 12.77775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-81.85185f, -25.98155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-36.85186f, -25.98155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-36.85186f, 94.98154f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(26.29629f, 94.98154f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(26.29629f, 81.9907f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 0, bloonsInvulnerable = true, distance = 1, id = r.NextDouble() + "", moabScale = 0, moabsInvulnerable = true, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(27.96296f, 10.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25.92593f, -56.86113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-80.18519f, -56.86113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-80.18519f, -95.62042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(61.66668f, -95.62042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(61.66668f, -63.88887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(100.9259f, -63.88887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(100.9259f, -23.63887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(64.25926f, -23.63887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(64.25926f, 44.29634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-4.629627f, 44.29634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 0, bloonsInvulnerable = true, distance = 1, id = r.NextDouble() + "", moabScale = 0, moabsInvulnerable = true, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-69.07407f, 49.19451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-81.11111f, 49.19451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-81.11111f, 115f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }







        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, -114.5741f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.4074f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 114.787f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, 5.75f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.1852f, 2.129718f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-88.14816f, -32.7962f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-31.11111f, -31.09254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.51852f, -22.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.8889f, 86.03704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.85186f, 88.16662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.77777f, 81.35197f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.48148f, 81.77775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.92592f, 102.0093f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.33334f, 102.0093f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.00001f, -15.7593f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.03704f, -16.39817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-75.00001f, 18.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1482f, 19.16662f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(19.07409f, 11.71296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.14815f, -51.11098f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.22223f, -55.58338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-88.51852f, -104.1389f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.55557f, -102.4351f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.85186f, -69f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.4445f, -64.52775f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.4074f, -18.31479f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.40742f, -13.62958f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(69.62963f, 50.89817f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-5.370373f, 56.86113f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-5.555553f, 38.7593f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(51.66666f, 37.90746f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.07407f, -27.89817f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.81483f, -29.38887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.07409f, -52.17591f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.92592f, -56.00929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.62963f, -86.88887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-74.07408f, -88.37958f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-73.51852f, -69.21296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.74074f, -64.52775f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(37.22223f, 11.5f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.77779f, 40.88887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.55557f, 40.25f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.11113f, 114.787f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-74.07408f, 115f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.03704f, 59.41662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-68.51853f, 58.77789f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(118.7037f, 44.93521f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.3704f, 35.9907f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(118.1482f, 27.04634f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.4074f, 17.25f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(128.1482f, 13.41676f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(134.6297f, 11.28704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(143.1482f, 15.97225f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.4815f, 21.50929f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.5926f, 31.30549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, 40.88887f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(145f, 46.21296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(135.1852f, 52.17591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(134.0741f, 53.4538f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.2222f, 49.40746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.6667f, 44.72225f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(118.3334f, 39.82409f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, -1.064789f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(140.3704f, -4.259295f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(134.2593f, -8.305493f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(130f, -14.90746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.7408f, -21.72225f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(123.7037f, -30.2407f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.7408f, -38.75916f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(129.6296f, -47.70366f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(138.5185f, -54.30549f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, -57.5f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, -0.2129578f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, -18.31479f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-143.8889f, -22.57408f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-139.2593f, -26.83338f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-132.2222f, -33.0093f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.4074f, -37.26845f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125f, -41.10183f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-125.3704f, -55.15732f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-127.7778f, -61.75929f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-130.7408f, -67.08338f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-137.963f, -70.4907f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-144.0741f, -73.25929f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, -73.89817f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, -20.44437f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area7 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, 45.14817f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-144.2593f, 48.98155f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-142.4074f, 57.28704f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-140f, 65.80563f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-143.1482f, 72.62042f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.2222f, 76.24084f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, 46.21296f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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