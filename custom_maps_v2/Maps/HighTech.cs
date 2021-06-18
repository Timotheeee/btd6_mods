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
    class HighTech
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(76.66668f, -114.787f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(76.66668f, -34.07409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.81482f, -34.07409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-34.81482f, 29.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-91.2963f, 29.17591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-91.2963f, 115f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.7778f, -33.86113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(21.48149f, -33.86113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(21.48149f, 29.60183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.963f, 29.60183f) });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.7037f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.5185f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, -44.72225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.25926f, -44.5093f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.8889f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.55557f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.25928f, -44.93507f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.96297f, -44.29634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.77778f, -37.48155f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.33334f, 19.37958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.5926f, 19.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, 35.13901f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.14816f, 35.9907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.14816f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-82.77779f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.14816f, 35.77774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(25f, 36.62958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.25926f, 29.81479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.44445f, -27.68521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, -27.47211f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.51852f, -28.32408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.70371f, 18.74084f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.51851f, 18.10183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.51851f, -27.47211f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 150, (AreaType)2));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.44445f, 40.03704f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.44445f, 79.22225f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.888895f, 79.43521f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.259254f, 41.95366f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.14816f, -51.11098f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.77778f, -87.31479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.259254f, -86.67591f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.444452f, -51.32409f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)1));

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
                        new PathModel("Path1", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path2", track2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}