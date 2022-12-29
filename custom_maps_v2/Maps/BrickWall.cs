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
    class BrickWall
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.5926f, 0.6388733f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-91.11113f, 1.277887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-91.85186f, -71.98141f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(88.33334f, -71.12958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(88.70372f, -25.76845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(88.33334f, -70.70366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-90.92593f, -71.34254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-90.55557f, 72.40746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(87.40742f, 73.25929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(89.81481f, 28.75f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(89.44446f, 72.62042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-90.55557f, 73.04633f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-91.11113f, -0.2129578f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.5926f, 0.6388733f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }





        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -114.5741f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.5926f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.8519f, 114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.4074f, 114.787f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -7.66662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.33334f, -8.305493f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.14816f, -79.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.62963f, -79.64817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(96.66668f, -18.52775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.96297f, -19.16662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(81.85185f, -63.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.70371f, -63.46296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.8889f, 65.16662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.22223f, 64.7407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(81.66667f, 20.65746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(96.85186f, 20.23155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(95.55556f, 80.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.14816f, 80.07408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.51853f, 8.731549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 9.370422f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-75.55556f, 31.94451f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-66.2963f, 32.79634f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.51853f, 34.28704f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-51.29631f, 37.26859f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.33334f, 41.95366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-38.14815f, 48.76845f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.07408f, 56.43521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-75.37038f, 56.43521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-75.37038f, 31.94451f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 10, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.5926f, -29.17591f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60.55556f, -30.02775f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.33334f, -34.28704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.03705f, -38.12042f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.85186f, -42.59253f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.5926f, -48.98141f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(30.37037f, -54.30549f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(72.22222f, -54.30549f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 10, (AreaType)1));

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