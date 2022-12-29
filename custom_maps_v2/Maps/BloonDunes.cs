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
    class BloonDunes
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-95.55556f, -114.787f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-95.55556f, 8.731549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-6.666667f, 8.731549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-6.666667f, 50.04634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25f, 50.04634f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(25f, 7.66662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(55.55556f, 7.66662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(55.55556f, 95.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-25.92593f, 95.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-25.92593f, 115f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(5.555553f, -114.787f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(5.555553f, -77.30563f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(47.5926f, -77.30563f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(47.5926f, -25.34254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-19.25926f, -25.34254f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-19.25926f, -76.2407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-55.74074f, -76.2407f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-55.74074f, 40.46296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-86.66667f, 40.46296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-86.66667f, 79.22225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-58.51853f, 79.22225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-58.51853f, 115f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1852f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.55556f, -114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.1852f, -4.898028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.5926f, -4.685211f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-63.88889f, -80.28704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.14815f, -88.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.55555f, -89.01845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-9.814812f, -77.51845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-10.37037f, -40.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(40.37038f, -38.97225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.11111f, -70.4907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.370373f, -70.70366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.3703684f, -75.81479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-1.851851f, -114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15f, -114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(14.44445f, -90.50929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.92593f, -91.14803f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(57.40741f, -83.48154f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(57.40741f, -27.47211f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.18519f, -18.52775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-19.81482f, -19.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.14815f, -26.62028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.2963f, -68.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.85186f, -68.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.2963f, -5.749859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-5.555553f, -4.472253f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.592588f, 5.324084f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.962965f, 36.41662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.59259f, 35.77774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.70371f, 3.194507f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25f, -5.749859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.25927f, -5.324084f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.44446f, 2.555493f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(65.55556f, 92f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.25927f, 102.4352f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.59259f, 100.9445f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.22223f, 115f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.07408f, 115f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.81482f, 91.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.8889f, 80.92591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.8889f, 82.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(48.8889f, 12.77775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.74074f, 12.9907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.00001f, 46.63887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(28.8889f, 55.15746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-5.555553f, 56.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.77778f, 48.55563f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.33333f, 15.12042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.55556f, 14.48155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.55556f, 40.46296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-52.40741f, 48.76845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.40742f, 48.34267f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.5926f, 66.87042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.18519f, 68.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.70371f, 76.66662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.70371f, 115f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.92593f, 115f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.74075f, 86.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.48149f, 86.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.62964f, 78.79633f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.62964f, 38.12042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-89.07408f, 30.45366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.77779f, 27.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.96297f, 14.69451f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.77779f, 14.48155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-101.4815f, 4.259295f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-103.7037f, -114.787f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.00001f, -114.787f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));

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