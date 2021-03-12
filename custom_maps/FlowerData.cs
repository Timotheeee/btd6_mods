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

namespace custom_maps
{
    class FlowerData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-151.4815f, -87.95366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-127.5926f, -11.71296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-108.5185f, 24.7038f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-86.66667f, 51.11113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-62.03704f, 69.21296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-33.7037f, 83.6945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-1.296294f, 90.08338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(31.48148f, 90.72225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(62.96297f, 81.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(87.77779f, 69.63887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(99.44445f, 57.07408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(111.6667f, 40.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(118.3334f, 13.20366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(119.6296f, -8.518451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(113.5185f, -30.02775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(102.7778f, -51.11098f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(87.22223f, -69.42591f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(69.07407f, -79.22225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.55557f, -84.97211f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25.92593f, -86.46296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(4.259259f, -81.56479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-8.888886f, -72.1945f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.44445f, -59.20366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-36.85186f, -43.87028f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-45.37038f, -18.95366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-41.66667f, 11.71296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-24.81482f, 37.05563f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-8.888886f, 48.12958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(13.14815f, 50.68521f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(31.48148f, 46f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.74075f, 32.79634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(63.8889f, 15.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(66.66667f, -8.944366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(52.77778f, -24.06479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(31.85186f, -29.38887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(14.81481f, -25.98155f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(5.555553f, -18.95366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(0.9259344f, -0.851831f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(9.074075f, 16.82422f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(28.33334f, 22.14817f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(38.88889f, 15.33338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(42.59259f, 3.620422f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(41.11111f, -1.490704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(34.81483f, -10.00916f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(27.03704f, -11.07408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.07409f, -8.305493f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(15.74074f, -4.259295f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.81482f, 0.6388733f) });
            return list.ToArray();
        }



        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0_ = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-154.6297f, -114.787f));
            area0_.Add(new Assets.Scripts.Simulation.SMath.Vector2(153.5185f, -114.787f));
            area0_.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1852f, 115f));
            area0_.Add(new Assets.Scripts.Simulation.SMath.Vector2(-154.6297f, 115f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0_), 10, AreaType.track));
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.3333f, -113.7221f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.6667f, -98.38887f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-132f, -87.14436f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140.8889f, -84.07774f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.4444f, -86.12225f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)1));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-139.1111f, -63.63324f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-129.3333f, -63.63324f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-122.6667f, -57.5f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-119.5555f, -49.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120.8889f, -42.16662f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-130.6667f, -35.01113f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 10, (AreaType)1));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-140.4444f, -22.74437f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.8889f, -23.76662f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.8889f, -46.25563f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120.8889f, -10.98887f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.3333f, -10.47775f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.2222f, -7.411127f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.8889f, -3.322113f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.11111f, 3.322253f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.8889f, 8.944507f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.2222f, 16.1f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-131.1111f, 0.2554932f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-137.3333f, 7.922253f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-139.1111f, 13.03338f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-136.8889f, 19.16662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-131.5556f, 23.76662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-124.4445f, 25.81113f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.2222f, 23.76662f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)1));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-91.11111f, 35.52225f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-85.33334f, 32.96662f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-78.66667f, 33.47775f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-73.33333f, 37.56662f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.11111f, 42.16676f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.55555f, 48.3f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-74.66666f, 51.87789f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5), 10, (AreaType)1));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.4444f, 37.56662f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.4444f, 42.16676f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.3333f, 46.76676f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.3333f, 53.92225f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.8889f, 57.5f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-102.6667f, 59.54451f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92f, 54.94451f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6), 10, (AreaType)1));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.11111f, 65.16662f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.33334f, 69.76662f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.77778f, 75.38887f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.99999f, 79.98887f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.55556f, 84.07774f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68f, 84.58887f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-60f, 78.45549f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7), 10, (AreaType)1));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.22222f, 84.58887f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.55556f, 90.21113f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.33334f, 96.34451f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40f, 99.41113f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.77777f, 98.38887f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.33334f, 91.23338f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8), 10, (AreaType)1));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.22223f, 75.90014f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.77778f, 70.27775f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.11111f, 68.23338f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.55555f, 69.76662f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12f, 74.36662f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10.66666f, 82.03338f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9), 10, (AreaType)1));
            var area10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-16.88889f, 94.3f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-16.88889f, 99.41113f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.55555f, 104.5223f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.11111f, 107.5889f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-4.888889f, 109.1223f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.444442f, 106.0556f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.999996f, 102.4777f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.111112f, 96.34451f));
            newareas.Add(new AreaModel("lol10", new Assets.Scripts.Simulation.SMath.Polygon(area10), 10, (AreaType)1));
            var area11 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.222228f, 84.58887f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.111112f, 77.9445f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.888894f, 75.90014f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.11112f, 74.36662f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.88888f, 76.92225f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.55555f, 82.5445f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.11111f, 85.61112f));
            newareas.Add(new AreaModel("lol11", new Assets.Scripts.Simulation.SMath.Polygon(area11), 10, (AreaType)1));
            var area12 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.44445f, 98.38887f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.00001f, 104.0111f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(16f, 108.6111f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.11111f, 110.1445f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.99999f, 108.1f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.55556f, 104.0111f));
            area12.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.55556f, 97.87775f));
            newareas.Add(new AreaModel("lol12", new Assets.Scripts.Simulation.SMath.Polygon(area12), 10, (AreaType)1));
            var area13 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.33333f, 98.38887f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.11112f, 102.4777f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.55556f, 103.5f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.55555f, 102.9889f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(46.22222f, 99.92225f));
            area13.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.11111f, 95.83338f));
            newareas.Add(new AreaModel("lol13", new Assets.Scripts.Simulation.SMath.Polygon(area13), 10, (AreaType)1));
            var area14 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.22223f, 83.05549f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.55556f, 76.41113f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.8889f, 72.32225f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(51.55556f, 72.32225f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.88889f, 74.36662f));
            area14.Add(new Assets.Scripts.Simulation.SMath.Vector2(58.66667f, 77.43338f));
            newareas.Add(new AreaModel("lol14", new Assets.Scripts.Simulation.SMath.Polygon(area14), 10, (AreaType)1));
            var area15 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.33334f, 90.72225f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.88889f, 94.81113f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.33334f, 97.36676f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(76f, 97.87775f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.8889f, 94.81113f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.44445f, 92.76662f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.22222f, 87.14451f));
            area15.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.33334f, 79.98887f));
            newareas.Add(new AreaModel("lol15", new Assets.Scripts.Simulation.SMath.Polygon(area15), 10, (AreaType)1));
            var area16 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.66666f, 62.61113f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.55555f, 54.43338f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.55555f, 49.83338f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(83.55555f, 43.7f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.66666f, 41.65563f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.88889f, 40.63338f));
            area16.Add(new Assets.Scripts.Simulation.SMath.Vector2(102.2222f, 42.16676f));
            newareas.Add(new AreaModel("lol16", new Assets.Scripts.Simulation.SMath.Polygon(area16), 10, (AreaType)1));
            var area17 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(98.22223f, 67.21113f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(103.1111f, 69.76662f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.7778f, 69.76662f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.6667f, 67.72225f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.1111f, 64.14451f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.5555f, 57.5f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(115.1111f, 52.38887f));
            area17.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.5556f, 50.34451f));
            newareas.Add(new AreaModel("lol17", new Assets.Scripts.Simulation.SMath.Polygon(area17), 10, (AreaType)1));
            var area18 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.3333f, 38.07775f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.4445f, 39.1f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.2222f, 37.56662f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.3333f, 32.96662f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.1111f, 28.36662f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(134.6667f, 22.74451f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(128.8889f, 17.63338f));
            area18.Add(new Assets.Scripts.Simulation.SMath.Vector2(123.1111f, 15.58887f));
            newareas.Add(new AreaModel("lol18", new Assets.Scripts.Simulation.SMath.Polygon(area18), 10, (AreaType)1));
            var area19 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.3333f, 29.9f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.33334f, 23.76662f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.44444f, 17.63338f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.44444f, 12.01113f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.11111f, 7.922253f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(106.6667f, 5.36662f));
            area19.Add(new Assets.Scripts.Simulation.SMath.Vector2(112f, 5.877887f));
            newareas.Add(new AreaModel("lol19", new Assets.Scripts.Simulation.SMath.Polygon(area19), 10, (AreaType)1));
            var area20 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(112f, -4.855493f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.7778f, -3.322113f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(99.99999f, -5.36662f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(94.66667f, -10.47775f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(93.77777f, -16.1f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(96f, -22.23338f));
            area20.Add(new Assets.Scripts.Simulation.SMath.Vector2(104.8889f, -27.85549f));
            newareas.Add(new AreaModel("lol20", new Assets.Scripts.Simulation.SMath.Polygon(area20), 10, (AreaType)1));
            var area21 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(124.4445f, 3.322253f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(132.8889f, -0.2554932f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(132.8889f, -6.388873f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(132f, -11.5f));
            area21.Add(new Assets.Scripts.Simulation.SMath.Vector2(124f, -13.54437f));
            newareas.Add(new AreaModel("lol21", new Assets.Scripts.Simulation.SMath.Polygon(area21), 10, (AreaType)1));
            var area22 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.7778f, -25.3f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(126.2222f, -31.43338f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(128.8889f, -37.05549f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(125.7778f, -43.18887f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.7778f, -45.23338f));
            area22.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.3333f, -43.7f));
            newareas.Add(new AreaModel("lol22", new Assets.Scripts.Simulation.SMath.Polygon(area22), 10, (AreaType)1));
            var area23 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area23.Add(new Assets.Scripts.Simulation.SMath.Vector2(108f, -56.98887f));
            area23.Add(new Assets.Scripts.Simulation.SMath.Vector2(112.8889f, -64.65549f));
            area23.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.3333f, -73.34437f));
            area23.Add(new Assets.Scripts.Simulation.SMath.Vector2(108f, -77.43338f));
            area23.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.44444f, -77.43338f));
            area23.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.88889f, -73.85549f));
            newareas.Add(new AreaModel("lol23", new Assets.Scripts.Simulation.SMath.Polygon(area23), 10, (AreaType)1));
            var area24 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area24.Add(new Assets.Scripts.Simulation.SMath.Vector2(91.55556f, -51.87775f));
            area24.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.8889f, -46.76662f));
            area24.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.33333f, -48.81099f));
            area24.Add(new Assets.Scripts.Simulation.SMath.Vector2(67.55555f, -51.87775f));
            area24.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.55555f, -59.03324f));
            area24.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.22223f, -67.72225f));
            area24.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.44445f, -74.87775f));
            newareas.Add(new AreaModel("lol24", new Assets.Scripts.Simulation.SMath.Polygon(area24), 10, (AreaType)1));
            var area25 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area25.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.11111f, -85.1f));
            area25.Add(new Assets.Scripts.Simulation.SMath.Vector2(76.44444f, -93.78887f));
            area25.Add(new Assets.Scripts.Simulation.SMath.Vector2(75.55556f, -99.41113f));
            area25.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.55556f, -104.5223f));
            area25.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.33334f, -105.0334f));
            area25.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.44444f, -105.0334f));
            area25.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.88889f, -94.81113f));
            newareas.Add(new AreaModel("lol25", new Assets.Scripts.Simulation.SMath.Polygon(area25), 10, (AreaType)1));
            var area26 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.44444f, -83.56662f));
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.66667f, -74.36662f));
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(40f, -70.27775f));
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.88889f, -65.16662f));
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(32f, -63.12211f));
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.11111f, -62.1f));
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.77778f, -61.07774f));
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.44444f, -62.1f));
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.55556f, -65.16662f));
            area26.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.444438f, -75.38887f));
            newareas.Add(new AreaModel("lol26", new Assets.Scripts.Simulation.SMath.Polygon(area26), 10, (AreaType)1));
            var area27 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area27.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.1111f, -95.32225f));
            area27.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.555551f, -100.4334f));
            area27.Add(new Assets.Scripts.Simulation.SMath.Vector2(2.222228f, -102.4777f));
            area27.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.555554f, -101.4555f));
            area27.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.888885f, -97.36662f));
            area27.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10.66666f, -92.25549f));
            area27.Add(new Assets.Scripts.Simulation.SMath.Vector2(-7.555559f, -84.58887f));
            newareas.Add(new AreaModel("lol27", new Assets.Scripts.Simulation.SMath.Polygon(area27), 10, (AreaType)1));
            var area28 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area28.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.66667f, -72.32225f));
            area28.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.11111f, -75.9f));
            area28.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.88889f, -77.94437f));
            area28.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.55556f, -76.41113f));
            area28.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.44445f, -72.32225f));
            area28.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.66666f, -64.65549f));
            area28.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44f, -59.54451f));
            area28.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.44445f, -53.92211f));
            newareas.Add(new AreaModel("lol28", new Assets.Scripts.Simulation.SMath.Polygon(area28), 10, (AreaType)1));
            var area29 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area29.Add(new Assets.Scripts.Simulation.SMath.Vector2(-42.66667f, -49.32225f));
            area29.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.66666f, -53.41113f));
            area29.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.77778f, -52.38887f));
            area29.Add(new Assets.Scripts.Simulation.SMath.Vector2(-59.11111f, -48.3f));
            area29.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.66667f, -44.21112f));
            area29.Add(new Assets.Scripts.Simulation.SMath.Vector2(-61.77777f, -37.05549f));
            area29.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.22222f, -31.94451f));
            area29.Add(new Assets.Scripts.Simulation.SMath.Vector2(-50.66667f, -29.9f));
            newareas.Add(new AreaModel("lol29", new Assets.Scripts.Simulation.SMath.Polygon(area29), 10, (AreaType)1));
            var area30 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area30.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.44445f, -25.3f));
            area30.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.88889f, -26.32225f));
            area30.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.66666f, -27.34437f));
            area30.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.66667f, -31.94451f));
            area30.Add(new Assets.Scripts.Simulation.SMath.Vector2(-21.33333f, -38.58887f));
            area30.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.55555f, -45.74451f));
            area30.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.44444f, -48.81099f));
            newareas.Add(new AreaModel("lol30", new Assets.Scripts.Simulation.SMath.Polygon(area30), 10, (AreaType)1));
            var area31 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area31.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.44445f, -21.21113f));
            area31.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.22223f, -21.72225f));
            area31.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.55555f, -19.67775f));
            area31.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.88889f, -15.07775f));
            area31.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.44444f, -9.455493f));
            area31.Add(new Assets.Scripts.Simulation.SMath.Vector2(-31.55555f, -4.344367f));
            area31.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.77778f, 0.2554932f));
            newareas.Add(new AreaModel("lol31", new Assets.Scripts.Simulation.SMath.Polygon(area31), 10, (AreaType)1));
            var area32 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area32.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.44445f, -5.877747f));
            area32.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.22223f, -2.811127f));
            area32.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.33334f, 3.83338f));
            area32.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.88889f, 10.47775f));
            area32.Add(new Assets.Scripts.Simulation.SMath.Vector2(-61.77777f, 17.63338f));
            area32.Add(new Assets.Scripts.Simulation.SMath.Vector2(-56.44444f, 18.65549f));
            area32.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.66666f, 18.14451f));
            newareas.Add(new AreaModel("lol32", new Assets.Scripts.Simulation.SMath.Polygon(area32), 10, (AreaType)1));
            var area33 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area33.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.66667f, 12.01113f));
            area33.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.11111f, 12.01113f));
            area33.Add(new Assets.Scripts.Simulation.SMath.Vector2(-21.77778f, 15.58887f));
            area33.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.55556f, 19.67775f));
            area33.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.66667f, 30.41113f));
            area33.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32f, 24.27775f));
            newareas.Add(new AreaModel("lol33", new Assets.Scripts.Simulation.SMath.Polygon(area33), 10, (AreaType)1));
            var area34 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area34.Add(new Assets.Scripts.Simulation.SMath.Vector2(-35.11111f, 33.98887f));
            area34.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.22222f, 39.1f));
            area34.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40f, 44.72225f));
            area34.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.11111f, 50.85563f));
            area34.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.66667f, 55.45549f));
            area34.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.44444f, 55.96676f));
            area34.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.11111f, 55.45549f));
            area34.Add(new Assets.Scripts.Simulation.SMath.Vector2(-16.44444f, 48.3f));
            newareas.Add(new AreaModel("lol34", new Assets.Scripts.Simulation.SMath.Polygon(area34), 10, (AreaType)1));
            var area35 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area35.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.111112f, 51.87789f));
            area35.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.222219f, 58.52225f));
            area35.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.777786f, 62.61113f));
            area35.Add(new Assets.Scripts.Simulation.SMath.Vector2(8.444452f, 63.63338f));
            area35.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.33333f, 63.12225f));
            area35.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.44444f, 58.01112f));
            area35.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.77777f, 52.9f));
            newareas.Add(new AreaModel("lol35", new Assets.Scripts.Simulation.SMath.Polygon(area35), 10, (AreaType)1));
            var area36 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area36.Add(new Assets.Scripts.Simulation.SMath.Vector2(4.88888f, 40.12225f));
            area36.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.8888841f, 32.96662f));
            area36.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.66667f, 30.92225f));
            area36.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.000001f, 30.41113f));
            area36.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.33333f, 36.03338f));
            area36.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.777782f, 40.12225f));
            newareas.Add(new AreaModel("lol36", new Assets.Scripts.Simulation.SMath.Polygon(area36), 10, (AreaType)1));
            var area37 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area37.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.55556f, 41.1445f));
            area37.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.11112f, 31.94451f));
            area37.Add(new Assets.Scripts.Simulation.SMath.Vector2(19.11111f, 23.25549f));
            area37.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.1111f, 22.23338f));
            area37.Add(new Assets.Scripts.Simulation.SMath.Vector2(40f, 32.45563f));
            area37.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.11111f, 40.63338f));
            newareas.Add(new AreaModel("lol37", new Assets.Scripts.Simulation.SMath.Polygon(area37), 10, (AreaType)1));
            var area38 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area38.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.88889f, 49.83338f));
            area38.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.88889f, 55.96676f));
            area38.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.22223f, 59.03338f));
            area38.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.33334f, 57.5f));
            area38.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.88889f, 52.9f));
            area38.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.33334f, 47.78887f));
            area38.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.77778f, 41.65563f));
            newareas.Add(new AreaModel("lol38", new Assets.Scripts.Simulation.SMath.Polygon(area38), 10, (AreaType)1));
            var area39 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area39.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.22221f, 35.52225f));
            area39.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.55555f, 38.07775f));
            area39.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.44445f, 35.52225f));
            area39.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.77778f, 31.43338f));
            area39.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.88889f, 27.34451f));
            area39.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.77778f, 25.81113f));
            newareas.Add(new AreaModel("lol39", new Assets.Scripts.Simulation.SMath.Polygon(area39), 10, (AreaType)1));
            var area40 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area40.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.66667f, 26.32225f));
            area40.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.22221f, 25.81113f));
            area40.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.66667f, 24.78887f));
            area40.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.33333f, 19.67775f));
            area40.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.33333f, 15.07775f));
            area40.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.66667f, 11.5f));
            area40.Add(new Assets.Scripts.Simulation.SMath.Vector2(68.44445f, 10.98901f));
            newareas.Add(new AreaModel("lol40", new Assets.Scripts.Simulation.SMath.Polygon(area40), 10, (AreaType)1));
            var area41 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area41.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.22221f, -0.7666199f));
            area41.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.33333f, -0.2554932f));
            area41.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.66667f, -0.7666199f));
            area41.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.8889f, -5.36662f));
            area41.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.33334f, -10.98887f));
            area41.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.8889f, -15.58887f));
            area41.Add(new Assets.Scripts.Simulation.SMath.Vector2(76.88889f, -18.14437f));
            area41.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.22221f, -19.16662f));
            area41.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.33334f, -17.63324f));
            newareas.Add(new AreaModel("lol41", new Assets.Scripts.Simulation.SMath.Polygon(area41), 10, (AreaType)1));
            var area42 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area42.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.11111f, -26.32225f));
            area42.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.88888f, -30.92225f));
            area42.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.44444f, -34.49986f));
            area42.Add(new Assets.Scripts.Simulation.SMath.Vector2(56f, -38.07775f));
            area42.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.77777f, -38.07775f));
            area42.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.8889f, -34.49986f));
            newareas.Add(new AreaModel("lol42", new Assets.Scripts.Simulation.SMath.Polygon(area42), 10, (AreaType)1));
            var area43 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area43.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.22221f, 6.9f));
            area43.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.66666f, 2.3f));
            area43.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.77777f, 3.322253f));
            area43.Add(new Assets.Scripts.Simulation.SMath.Vector2(14.22222f, 6.389014f));
            area43.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.44444f, 11.5f));
            area43.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.8889f, 12.01113f));
            area43.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.55556f, 10.47775f));
            newareas.Add(new AreaModel("lol43", new Assets.Scripts.Simulation.SMath.Polygon(area43), 10, (AreaType)1));
            var area44 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.444442f, 7.922253f));
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.222219f, 11.5f));
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.000001f, 12.01113f));
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.88889f, 12.01113f));
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.33334f, 7.411127f));
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.55556f, 4.344367f));
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.55556f, -3.322113f));
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(-17.33334f, -7.922253f));
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.44445f, -12.01113f));
            area44.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.777782f, -12.01113f));
            newareas.Add(new AreaModel("lol44", new Assets.Scripts.Simulation.SMath.Polygon(area44), 10, (AreaType)1));
            var area45 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.88889f, 26.32225f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(39.55556f, 16.61113f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.55555f, 10.47775f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.33334f, 5.36662f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.33334f, -1.277747f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.88888f, -8.43324f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.88889f, -19.16662f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(57.33333f, -14.05549f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.77778f, -8.944366f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.66667f, -3.322113f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(62.22223f, 3.83338f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(60.44444f, 9.455493f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.55556f, 19.67775f));
            area45.Add(new Assets.Scripts.Simulation.SMath.Vector2(49.33334f, 24.78887f));
            newareas.Add(new AreaModel("lol45", new Assets.Scripts.Simulation.SMath.Polygon(area45), 10, (AreaType)1));
            var area46 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(37.77777f, -12.52225f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(45.33334f, -22.23338f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.22221f, -27.85549f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.11111f, -28.36662f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.44444f, -25.81113f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.33333f, -22.74437f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.999992f, -16.61113f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.777782f, -9.966619f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.111108f, -0.2554932f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.77777f, -2.811127f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.33333f, -8.944366f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.44444f, -12.52225f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.77778f, -15.07775f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.44445f, -15.07775f));
            area46.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.22223f, -11.5f));
            newareas.Add(new AreaModel("lol46", new Assets.Scripts.Simulation.SMath.Polygon(area46), 10, (AreaType)1));






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
