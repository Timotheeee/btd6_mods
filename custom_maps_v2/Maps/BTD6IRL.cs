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
    class BTD6IRL
    {
        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(36.54758f, -123.5697f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(48.56982f, -66.62251f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-126.9548f, -64.41095f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-116.8561f, 66.06969f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-99.06319f, 77.68031f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(88.00273f, 77.68031f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(114.4517f, 85.97359f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(136.5726f, 116.3822f), bloonSpeedMultiplier = 1 });
            return list.ToArray();




        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(136.5726f, 116.3822f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(113.4899f, 84.31485f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(88.00273f, 77.68031f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-99.06319f, 77.68031f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-117.337f, 67.72843f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-127.4357f, -58.88219f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-107.7192f, -64.41095f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(34.62402f, -66.06969f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(47.12716f, -72.15141f), bloonSpeedMultiplier = 1 });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(38.95203f, -115.8292f), bloonSpeedMultiplier = 1 });
            return list.ToArray();


        }



        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-146.1904f, -113.3414f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.1904f, -113.3414f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.1521f, 112.7886f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-146.1904f, 113.3414f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.1521f, -113.8942f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 0, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(29.81514f, -115.8292f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.06671f, -76.57453f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-141.8624f, -72.70423f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-133.6872f, 88.18515f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(71.6525f, 88.73797f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(73.57606f, 98.13703f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(107.7192f, 94.81969f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.665f, 114.7236f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.633f, 115.2764f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(127.4357f, 83.20921f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.10142f, 74.36297f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(94.7352f, 65.51687f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-71.65251f, 65.51687f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-72.61429f, 56.67077f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-100.5059f, 56.11781f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.4899f, -51.14187f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-92.33074f, -50.58891f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.84986f, -59.43515f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.20984f, -60.54093f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(59.14938f, -114.1706f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(30.29603f, -115.2764f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 0, (AreaType)0));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, -115.8292f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-65.40094f, -115.2764f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.18761f, -72.70423f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-141.8624f, -72.15141f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-133.6872f, 114.7236f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, 115.2764f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 0, (AreaType)1));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-106.7574f, 15.75719f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-78.38496f, 10.78125f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.08893f, -50.58891f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-90.88808f, -57.77641f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.36897f, -32.34375f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-111.5663f, -31.79093f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-105.3148f, 15.75719f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 0, (AreaType)1));












            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new AlternateRoundSplitterModel("", new string[]
                    {
                        "Path",
                        "Path (1)",
                    }, false, 1, 0,""), new AlternateRoundSplitterModel("", new string[]
                    {
                        "Path",
                        "Path (1)",
                    }, false, 1, 0, ""));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("Path (1)", track2(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }
    }
}