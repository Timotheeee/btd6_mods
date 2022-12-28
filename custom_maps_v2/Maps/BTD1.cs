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
    class BTD1
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-147.4074f, -5.537042f), bloonSpeedMultiplier=1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-57.03704f, -5.537042f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-57.03704f, -59.62958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-15.37037f, -59.62958f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-15.37037f, 46.42591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-73.14816f, 46.42591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-73.14816f, 83.26859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(66.85187f, 83.26859f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(66.85187f, 26.19451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(22.77779f, 26.19451f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(22.77779f, -23.42591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(68.70372f, -23.42591f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(68.70372f, -83.05549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(7.037045f, -83.05549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(7.037045f, -114.787f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.8148f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.0741f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.6296f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.4445f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, -18.10183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.07408f, -18.31479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.74075f, -59.41662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.03704f, -74.53704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-16.66667f, -74.75f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.000005f, -57.71296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.888891f, 40.88887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.92593f, 55.37042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.25926f, 56.00929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.62964f, 70.70366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.81482f, 72.40746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.1852f, 33.0093f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.55556f, 31.51845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.92594f, 33.0093f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.44445f, 25.55549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.62963f, -25.12958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.18518f, -31.51845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.55556f, -35.56479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.55556f, -37.05549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.2963f, -74.75f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.14816f, -76.87958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.851851f, -75.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.03704f, -89.23141f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.666671f, -114.5741f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.11112f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.55556f, -92f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.14816f, -96.25916f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.37038f, -87.31479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.33335f, -27.04634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.48148f, -20.01845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.55557f, -17.25f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.37037f, 13.20366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.48149f, 12.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(76.2963f, 22.36113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.55556f, 83.05549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(65f, 90.50929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.92593f, 89.01845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80.18519f, 81.56479f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.85185f, 74.53704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80.74075f, 48.76845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.11111f, 36.41662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.92593f, 33.86113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-21.48148f, -53.87958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.03704f, -53.66662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.55556f, -47.70366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.77778f, -16.82408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-55.92593f, -0.2129578f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.70371f, 1.490704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.1482f, 1.277887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, -18.95366f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));

            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            //PathModel_Path1
            var a = new PathSpawnerModel("1", new SplitterModel("2", new string[]
                    {
                        "Path1",
                    }), new SplitterModel("3", new string[]
                    {
                        "Path1",
                    }));
            //Console.WriteLine("PathSpawnerModel: " + a.name);
            //Console.WriteLine("PathSpawnerModel: " + a.forwardSplitter.name);
            //Console.WriteLine("PathSpawnerModel: " + a.reverseSplitter.name);
            //Console.WriteLine("PathSpawnerModel: " + a.reverseSplitter.paths[0]);
            return a;
        }

        public static PathModel[] pathmodel()
        {
            var a = new PathModel("Path1", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null);
            //a.name = "Path1";
            //Console.WriteLine("PathModel: " + a.name);
            //Console.WriteLine("PathModel: " + a.points.Count);
            //Console.WriteLine("PathModel: " + a.points[0].point.x);

            return new PathModel[]
                    {
                        a,
                    };
        }


    }
}