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
using UnhollowerRuntimeLib;
using Il2CppAssets.Scripts.Models.Map.Spawners;

namespace custommaps.Maps
{
    class BloontoniumLab
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.55557f, -114.787f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(10.18519f, -28.96296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(20.55556f, -13.20366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25.18519f, 2.342676f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(32.22222f, 7.879578f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(148.1482f, 8.944507f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.963f, 10.64817f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-36.11111f, 9.157464f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-27.59259f, 1.277887f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-26.11111f, -7.240704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.44445f, -13.20366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-21.48148f, -17.67591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-17.59259f, -23f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.14815f, -28.32408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-15f, -37.05549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-52.5926f, -114.787f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(57.96297f, 115f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.7037f, 48.98155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(21.48149f, 34.92591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(16.66668f, 28.32408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(11.66666f, 25.55549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(0f, 29.17591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-9.074075f, 26.19451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-20f, 27.04634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.74074f, 37.48155f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-65.92593f, 115f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.8148f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.8148f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.6297f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.74075f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.55556f, 24.7038f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-21.48148f, 23f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.81482f, 21.50929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.703707f, 21.93521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.92593f, 22.78704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.222219f, 24.4907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.037031f, 23.63887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.037045f, 22.36113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.814812f, 21.72225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.37036f, 22.57408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(20f, 26.19451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.81482f, 31.09267f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.51852f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.44445f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.5926f, 29.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.18519f, 30.87972f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.777785f, 33.43521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.518522f, 33.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.11111f, 31.94451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.18518f, 29.60183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.44445f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-74.62964f, 115f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, -2.981409f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.85186f, -0.851831f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.25927f, -0.6388733f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.8889f, -2.555493f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.51852f, -6.601831f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.77778f, -11.07408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.25926f, -19.59254f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.11111f, -24.4907f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.37036f, -29.81479f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(58.33333f, -114.787f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.14815f, -114.787f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.148141f, -44.5093f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.666667f, -35.35183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.851847f, -26.62028f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.11111f, -20.65746f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.92592f, -16.18507f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(19.81482f, -7.453662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.48149f, 1.277887f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.48149f, 10.43521f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.66668f, 13.84254f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.3333f, 16.39817f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.0741f, -2.555493f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.4445f, -3.194507f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.88889f, 3.620422f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.92593f, 2.129718f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-54.25926f, 0.851831f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.11111f, 0f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.81482f, 0.6388733f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.22223f, -5.324084f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30f, -12.77775f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.25926f, -22.78704f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.14815f, -29.38887f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20f, -34.71296f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.40741f, -114.787f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.25926f, -114.787f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.518517f, -33.43521f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10.55556f, -25.34254f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.51852f, -20.65746f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.74074f, -18.95366f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.33334f, -17.25f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.74075f, -12.56479f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.03704f, -5.749859f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.5926f, 0.6388733f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.74074f, 7.453802f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.14816f, 10.86113f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.40741f, 14.90746f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.92593f, 13.20366f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-97.40742f, 14.05549f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.07409f, 15.7593f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.0741f, 16.82422f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.5185f, -3.194507f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                    }), new SplitterModel("", new string[]
                    {
                        "Path1",
                        "Path2",
                        "Path3",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path1", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path2", track2(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path3", track3(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}