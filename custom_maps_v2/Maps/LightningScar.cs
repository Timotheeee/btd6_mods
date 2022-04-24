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
    class LightningScar
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(90.1852f, -114.787f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.51852f, -39.82409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.7037f, -33.64803f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-8.888886f, -2.768451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-67.40742f, 39.18521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-28.14815f, 41.7407f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-122.0371f, 115f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(90.1852f, -114.787f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-13.51852f, -39.82409f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.7037f, -33.64803f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-8.888886f, -2.768451f) }); list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(83.33334f, 1.490704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(30.55557f, 61.54634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(35.74074f, 66.01859f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(109.6296f, 60.05549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(81.85185f, 115f) });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.1482f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.963f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.5926f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.14815f, -37.69437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.81482f, -30.2407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.70371f, -30.02775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.70371f, -27.04634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-74.07408f, 33.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.07409f, 39.82409f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-78.8889f, 46.42591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.03705f, 48.76845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.33334f, 50.68521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60.55556f, 51.32409f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-56.2963f, 48.76845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.44444f, 47.27774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-133.7037f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.8148f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80.92594f, 95.40746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.18519f, 90.29633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-73.14816f, 87.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.55556f, 86.03704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-57.96297f, 77.09267f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.14816f, 75.60183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.40741f, 71.12971f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.8889f, 71.12971f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.18518f, 63.25f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.33334f, 59.20366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.8889f, 58.13887f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20.92593f, 53.66676f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.62963f, 49.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.96296f, 49.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.03703f, 45.78704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.5926f, 44.5093f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10.92593f, 42.59253f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.29629f, 37.90746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.62963f, 38.97225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-16.85186f, 33.86113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.5926f, 33.86113f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.44444f, 27.47225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-21.66667f, 9.157464f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.333338f, 7.453802f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.777785f, 8.518591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(19.81482f, 9.370422f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.44445f, 5.962958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.55556f, 10.0093f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.5926f, 9.157464f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.25927f, 11.07408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.2963f, 8.731549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.11111f, 62.18521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.33334f, 67.29633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.18519f, 70.70366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.11112f, 71.12971f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.66668f, 73.04633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.14815f, 68.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.1111f, 66.65746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.11113f, 85.18521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.66669f, 92f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.77779f, 101.1575f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.40741f, 104.3518f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.18519f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.96297f, 115f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.25927f, 105.8427f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.3333f, 95.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.3333f, 93.4907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.5185f, 79.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.2222f, 73.89817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.2593f, 67.29633f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.4815f, 61.33338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(120.5556f, 55.37042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(118.7037f, 56.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.5926f, 52.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(116.1111f, 53.02774f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.9259f, 52.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.3333f, 52.17591f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.25927f, 54.94451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.1852f, 54.94451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.62965f, 59.84267f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.40742f, 55.37042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.2963f, 57.28704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.33334f, 56.64817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.96297f, 58.35183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.2963f, 60.90746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.40741f, 61.33338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.7037f, 57.07408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(45f, 51.53704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.37038f, 45.78704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.40741f, 36.84253f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(67.40741f, 34.07409f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.14816f, 30.2407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.88889f, 27.25929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.48149f, 22.57408f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.59261f, 11.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.96297f, 10.22225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.22224f, 6.175915f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.07409f, 0.2129578f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.2963f, -6.601831f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(76.48148f, -6.175915f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.22224f, -5.111126f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.22223f, -7.240704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.44445f, -7.66662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.62964f, -2.768451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.85186f, -3.620422f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.11111f, -4.898028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.37037f, -5.111126f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(19.81482f, -7.66662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.74075f, -5.111126f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.11111f, -6.814789f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(18.70371f, -19.37958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.92593f, -20.01845f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.18519f, -24.91662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.44445f, -25.98155f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.33334f, -36.62958f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.22223f, -41.10183f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.92594f, -40.46296f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.59259f, -44.29634f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.66667f, -43.65746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.14815f, -46f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.5926f, -47.4907f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.85186f, -43.44451f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.22222f, -43.87028f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.81481f, -46f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.814812f, -44.72225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.185194f, -45.14817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.92593f, -49.40746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.03703f, -56.64817f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.1852f, -114.787f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
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