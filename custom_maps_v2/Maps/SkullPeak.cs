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
    class SkullPeak
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.4074f, 70.06493f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.4074f, 70.06493f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-53.51852f, 69f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-54.07408f, 37.90746f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-83.33334f, 35.77774f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-84.62964f, -8.092535f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-30.18519f, -8.092535f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-25.92593f, 67.08338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(38.51853f, 68.36112f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(40.92594f, -26.40732f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 0, bloonsInvulnerable = true, distance = 1, id = r.NextDouble() + "", moabScale = 0, moabsInvulnerable = true, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(1.666671f, -26.40732f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(1.481474f, 25.55549f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(94.07409f, 24.06479f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(90.55557f, -64.95366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(77.40742f, -74.11112f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(49.44445f, -74.53704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 0, bloonsInvulnerable = true, distance = 1, id = r.NextDouble() + "", moabScale = 0, moabsInvulnerable = true, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-8.333338f, -69f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-37.22223f, -69f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-39.81482f, -36.41662f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.92593f, -36.20366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-87.40742f, -113.0834f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }






        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, -114.3611f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.4074f, -114.3611f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6667f, 113.9352f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 114.5741f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, 63.03704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.92593f, 63.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.85186f, 40.25f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-86.85186f, 42.16676f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.59261f, -11.92592f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-24.25926f, -12.13887f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-20.55556f, 61.75929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.92592f, 60.48155f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.55556f, 33.43521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.55556f, 32.15746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.777776f, 32.15746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.777776f, -22.78704f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.666667f, -22.36099f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(6.851847f, 19.16662f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.962961f, 18.52775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(34.44445f, 18.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.37037f, -20.87042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.48149f, -21.93521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.48149f, 19.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.92593f, 17.67591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.1852f, 0f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.29631f, -38.54634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.1852f, -65.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.55557f, -64.10183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60.37038f, -72.83324f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.70371f, -70.70366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(45.1852f, -78.15746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.07409f, -82.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.33334f, -82.20366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.55556f, -78.15746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(95.37038f, -70.06479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.62965f, -62.61113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(101.6667f, -53.2407f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(106.1111f, -39.18521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.25927f, -26.83338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.8148f, -17.46296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105.9259f, -10.86113f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.5926f, -5.749859f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.0371f, 5.537042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.8148f, 13.41676f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.62965f, 22.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.7408f, 29.81479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.7408f, 32.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.66667f, 32.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.96297f, 74.11112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-29.81482f, 73.47225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.48149f, -0.851831f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.44444f, -1.277747f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-78.33334f, 29.81479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50.37038f, 32.15746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.22223f, 74.96296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-77.77779f, 79.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 77.30563f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-11.11111f, -62.61113f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.33334f, -59.41662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.85186f, -27.68521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.81483f, -27.47211f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.18519f, -113.7221f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.55556f, -113.9352f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.37038f, -44.08324f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.85186f, -41.95366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-39.07408f, -77.09254f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.111114f, -76.66662f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.22223f, -1.277747f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.22223f, -1.91662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.14816f, 78.58338f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.96297f, 84.54633f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.74074f, 94.76859f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-79.81483f, 101.3704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.92593f, 99.66676f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-102.963f, 92.21296f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-63.51852f, 91.78704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.22223f, 84.97225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.85186f, 6.601831f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.48149f, -1.064789f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.3333f, -112.8703f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.5556f, -81.77775f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.6667f, -65.80549f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-109.2593f, -48.34253f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.1482f, -22.78704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.4815f, -12.9907f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.3333f, -6.175915f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.9259f, 26.62042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.1852f, 44.29634f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-104.4445f, 61.12042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.74075f, 61.75929f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.1852f, 46f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.96297f, 13.41676f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.1852f, -12.9907f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-27.96296f, -15.97225f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.03704f, -31.94451f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-19.25926f, -56.86113f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-31.11111f, -55.58338f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.96297f, -25.98155f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-68.14816f, -24.4907f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.1852f, -26.19437f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-94.62964f, -32.37042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-97.22224f, -49.62042f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.18519f, -62.82408f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-95.92593f, -113.2963f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6667f, 51.32409f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(116.8519f, 49.40746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.6296f, 43.44451f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.62965f, 26.40746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105.5556f, 13.84254f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105.7408f, -17.88887f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.14816f, -27.68521f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.963f, -43.44451f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(99.62965f, -57.28704f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(97.77779f, -68.14817f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(83.14815f, -78.15746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.51852f, -82.20366f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(65.1852f, -92.85183f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(65.1852f, -104.9907f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.18519f, -113.5093f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.4445f, -114.3611f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(108.8889f, -99.66662f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(110.5556f, -79.00929f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.1852f, -76.02775f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.3704f, -59.62958f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.7778f, -41.10183f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(123.3334f, -40.25f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.1852f, -29.38887f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(113.7037f, -10.43521f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.4445f, 4.898169f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(122.2222f, 11.28704f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(131.1111f, 16.18521f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(137.4074f, 6.814789f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(145.7408f, 11.71296f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.4815f, 49.83338f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.7407368f, 34.07409f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.518522f, 39.82409f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.9259255f, 56.64817f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(14.07407f, 60.26845f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.92592f, 57.28704f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.00001f, 33.0093f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 10, (AreaType)1));
            var area7 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.66667f, 33.64817f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.66667f, 55.79634f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(57.40741f, 59.20366f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.66667f, 58.77789f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.2963f, 56.64817f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(78.51853f, 57.28704f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.74075f, 50.89817f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.22223f, 33.22225f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 10, (AreaType)1));
            var area8 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.962961f, -4.472253f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.77778f, -3.407465f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.07408f, -4.259295f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.00001f, -5.324084f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.74074f, 18.95366f));
            area8.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(8.333338f, 20.01845f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area8),Main.Empty(), 10, (AreaType)1));
            var area9 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(46.48149f, -3.194507f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(54.44445f, -4.898028f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(74.62963f, -3.620422f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(80.37038f, 8.305634f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.55556f, 20.44451f));
            area9.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(47.03704f, 19.80563f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area9),Main.Empty(), 10, (AreaType)1));
            var area10 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-9.629632f, -63.88887f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.777781f, -37.26845f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(9.814812f, -27.47211f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(31.11111f, -26.19437f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(37.59259f, -28.96296f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.51851f, -26.40732f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.00001f, -12.35183f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.62963f, -8.731549f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.777781f, -8.944366f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.592597f, -14.48141f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.03704f, -24.70366f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-14.81482f, -52.81479f));
            area10.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-7.962961f, -66.01845f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area10),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area11 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(50.00001f, -31.30563f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.66668f, -32.15746f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(55.74074f, -19.80549f));
            area11.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.25926f, -14.48141f));
            newareas.Add(new AreaModel("lol5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area11),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));

            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                    }, ""), new SplitterModel("", new string[]
                    {
                        "Path1",
                    }, ""));
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