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
    class BattleSands
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.4074f, 71.98154f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-97.40742f, 72.83338f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-97.5926f, 21.72225f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-61.29631f, 21.50929f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-61.29631f, -28.32408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-24.44445f, -27.68521f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-24.25926f, -78.7962f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(13.70371f, -77.73141f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(14.44445f, 70.70366f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(50.74075f, 70.27775f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(50.55557f, 23.21296f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(87.59261f, 22.36113f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(89.07408f, -28.32408f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(123.8889f, -28.53704f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(124.6296f, -77.51845f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.7778f, -76.66662f), bloonSpeedMultiplier = 1 });
            return list.ToArray();
        }







        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-150.1852f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.3704f, -114.787f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.7408f, 115f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.8148f, 115f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.7778f, 56.64817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-108.3333f, 56.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-107.5926f, 12.77775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-102.5926f, 7.453802f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.03704f, 5.75f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-71.2963f, -37.26845f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-64.81482f, -43.87028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.00001f, -43.65746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.7037f, -87.31479f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-28.51852f, -91.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(18.51853f, -91.57408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(24.44444f, -85.61112f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25f, 55.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(40f, 56.22225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(39.81482f, 15.97225f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(44.25926f, 8.305634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.40742f, 5.75f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(78.33335f, -36.62958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(82.59261f, -41.52774f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.33334f, -44.5093f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(112.2222f, -43.87028f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(113.8889f, -49.83338f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(114.8148f, -88.59254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.5926f, -90.2962f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(123.1482f, -93.4907f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(148.1482f, -93.27775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, -70.70366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(135.5556f, -69.85183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(135.9259f, -28.96296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(131.1111f, -23.21296f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.88889f, -21.50929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.88889f, 20.65746f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(93.70371f, 27.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(64.81482f, 27.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.85185f, 32.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(60.37038f, 73.89817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(53.51852f, 79.00929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(11.48148f, 78.37042f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.888882f, 69.85183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(3.703702f, -68.14817f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-0.5555571f, -70.70366f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-12.40741f, -70.27775f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.51852f, -65.80549f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-13.51852f, -31.09254f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-17.59259f, -23.85183f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.48149f, -21.50929f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50.18519f, -19.37958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-51.29631f, 23f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.48149f, 27.04634f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-83.70371f, 27.68521f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.22223f, 36.2038f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.40742f, 69.42591f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.2963f, 76.87958f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.5926f, 78.79633f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.963f, 56.64817f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.96297f, 81.9907f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.2222f, 79.00929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(110.9259f, 58.13887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.4815f, 73.68521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(142.2222f, 67.08338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(133.3333f, 84.75929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(123.8889f, 89.23154f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(134.8148f, 89.4445f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.4815f, 107.1204f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(126.4815f, 104.5648f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(119.6296f, 93.91662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(118.3334f, 105.8427f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(109.0741f, 115f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(102.0371f, 115f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.8148f, 96.89817f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(113.1482f, 92.63902f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.8148f, 94.55563f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.77779f, 83.05549f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(86.85187f, 81.13887f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.4074f, 78.15746f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.92594f, -91.36112f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.00001f, -79.64817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.18519f, -81.35183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-63.88889f, -75.38887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.74075f, -54.73155f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-50f, -67.72225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-49.44445f, -81.13887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.51852f, -70.91662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.07408f, -69.63887f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.51852f, -84.12028f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.55556f, -84.33338f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.00001f, -88.16662f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-26.48149f, -107.3334f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.66667f, -100.0925f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.51853f, -114.787f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.22223f, -95.40733f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.55556f, -91.78704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-63.70371f, -79.22225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.2963f, -80.92591f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.33334f, -44.5093f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-103.8889f, -46.42591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.8519f, -48.76845f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.6667f, -57.71296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-116.4815f, -68.14817f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-117.5926f, -77.09254f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-115.1852f, -84.54633f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-110.7408f, -91.78704f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105f, -98.17591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-96.11112f, -102.0093f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.40742f, -100.7314f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-80.92594f, -97.96296f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-73.51852f, -93.70366f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-66.48149f, -89.23141f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-64.44445f, -85.18521f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-64.44445f, -78.15746f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-67.40742f, -67.08338f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-70.55556f, -59.41662f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-76.66668f, -52.17591f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-85.92593f, -48.12958f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.77779f, -44.93507f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.8889f, -45.57409f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.1852f, -47.4907f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 10, (AreaType)1));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(117.963f, 59.84267f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(112.7778f, 57.5f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.2222f, 50.2593f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(105f, 39.18521f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.963f, 26.62042f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(112.963f, 18.74084f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(118.3334f, 14.90746f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(126.1111f, 13.84254f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(136.4815f, 15.54634f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(142.4074f, 17.25f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.1111f, 22.78704f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.7778f, 31.73155f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.963f, 54.09253f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(143.1482f, 59.41662f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(134.6297f, 62.61113f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(125.5556f, 61.54634f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(120.1852f, 60.90746f));
            newareas.Add(new AreaModel("lol5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 10, (AreaType)1));

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