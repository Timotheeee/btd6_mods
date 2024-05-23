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
    class CustomMapTestData
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-48.70371f, -113.0834f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.00001f, 23.85197f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-31.2963f, 33.22225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-17.96296f, 38.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(0.5555571f, 38.97225f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(20.37038f, 32.58338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(32.77778f, 18.52775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(38.51853f, 0.6388733f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(34.81483f, -23f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(23.33334f, -42.16662f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(1.851851f, -53.45366f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-19.81482f, -52.81479f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.92593f, -43.87028f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-48.33334f, 1.064789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-40.55556f, 28.11113f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-14.62963f, 42.37972f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(15.55556f, 35.35183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(36.2963f, 5.962958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(32.5926f, -25.55549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(10.00001f, -50.0462f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-23.88889f, -48.98141f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.92593f, -26.40732f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-47.40741f, 9.157464f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-35.92593f, 31.94451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-17.22223f, 38.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(4.814816f, 38.7593f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(23.51852f, 27.04634f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(35.18518f, -1.064789f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(29.44445f, -31.94451f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(10.74075f, -51.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-19.62963f, -51.53704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-20.74075f, -49.83338f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.74074f, -34.71296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.55556f, 19.37958f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.92593f, 73.04633f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-45.92593f, 114.1482f) });
            return list.ToArray();
        }





        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.2222f, -113.7221f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(145.9259f, -114.1482f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6667f, 113.5093f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.2222f, 113.2963f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), map_editor.Main.Empty(), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.37038f, -114.1482f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-55.00001f, 113.7223f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-37.03704f, 114.1482f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-41.11111f, -114.1482f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), map_editor.Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.18518f, -50.68521f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-22.77778f, -56.00929f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.222219f, -58.77774f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(12.5926f, -56.22211f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.81481f, -51.32409f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.66668f, -37.90732f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.22223f, -20.01845f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(43.51852f, -3.407465f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(40.37038f, 11.71296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(35.55556f, 25.55549f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(25.92593f, 34.71296f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(16.85186f, 39.61113f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.111114f, 43.87042f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-16.48148f, 44.08338f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.74075f, 44.5093f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.92593f, 39.61113f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.5926f, 13.84254f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.85186f, -5.111126f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-46.11111f, -34.49986f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-36.48149f, -53.66662f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-30.92593f, -31.51845f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-20f, -41.52774f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.592597f, -41.95366f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(15.74074f, -36.84253f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(26.29629f, -16.39817f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.44445f, 8.305634f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(22.77779f, 22.57408f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.222219f, 34.92591f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-21.11111f, 31.94451f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.00001f, 16.39817f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), map_editor.Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-88.33334f, -113.9352f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-87.96297f, 113.7223f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-61.11112f, 114.1482f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.77779f, 19.59268f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.8889f, 19.59268f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.96297f, 11.28704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.40741f, 4.472253f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-61.29631f, -8.092535f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.77778f, -9.157324f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.59259f, -13.62958f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-61.11112f, -16.39817f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-57.22223f, -21.50929f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-59.44445f, -33.22225f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.33334f, -41.95366f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-66.48149f, -48.98141f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.33334f, -53.2407f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-61.85186f, -60.48141f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-64.81482f, -69f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-60.37038f, -71.98141f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-64.07408f, -81.35183f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-61.11112f, -92f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-62.03704f, -114.3611f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3), map_editor.Main.Empty(), 10, (AreaType)1));




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