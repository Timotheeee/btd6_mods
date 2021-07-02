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
    class BrickWall
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.5926f, 0.6388733f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-91.11113f, 1.277887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-91.85186f, -71.98141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(88.33334f, -71.12958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(88.70372f, -25.76845f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(88.33334f, -70.70366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-90.92593f, -71.34254f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-90.55557f, 72.40746f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(87.40742f, 73.25929f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(89.81481f, 28.75f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(89.44446f, 72.62042f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-90.55557f, 73.04633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-91.11113f, -0.2129578f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.5926f, 0.6388733f) });
            return list.ToArray();
        }





        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, -114.5741f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.5926f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.8519f, 114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.4074f, 114.787f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, -7.66662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.33334f, -8.305493f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.14816f, -79.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.62963f, -79.64817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.66668f, -18.52775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.96297f, -19.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.85185f, -63.25f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.70371f, -63.46296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.8889f, 65.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.22223f, 64.7407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.66667f, 20.65746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.85186f, 20.23155f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(95.55556f, 80.28704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.14816f, 80.07408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.51853f, 8.731549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, 9.370422f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.55556f, 31.94451f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.2963f, 32.79634f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.51853f, 34.28704f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-51.29631f, 37.26859f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.33334f, 41.95366f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.14815f, 48.76845f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.07408f, 56.43521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.37038f, 56.43521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.37038f, 31.94451f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(72.5926f, -29.17591f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.55556f, -30.02775f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.33334f, -34.28704f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.03705f, -38.12042f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.85186f, -42.59253f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.5926f, -48.98141f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.37037f, -54.30549f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(72.22222f, -54.30549f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)1));

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