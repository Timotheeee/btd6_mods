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

namespace custom_maps
{
    class HeartGateData
    {

        public static System.Random r = new System.Random();

        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.1521f, 75.19234f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(103.3912f, 60.81734f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(66.36272f, 53.07688f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(35.58581f, 49.20672f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-3.366222f, 46.44234f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-35.10492f, 48.6539f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-65.40094f, 51.41828f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-95.69697f, 57.5f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.633f, 73.5336f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-3.847116f, -114.447f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-3.366222f, 115f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.633f, -27.64408f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-118.2988f, -48.10094f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-86.07919f, -63.02876f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-37.99026f, -75.74516f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-38.47114f, -39.2547f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-51.45515f, -24.8797f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-54.82138f, -6.08172f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-50.97427f, 4.97594f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-37.50936f, 22.11532f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-37.50936f, 115f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.1521f, -26.53844f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(103.3912f, -55.28844f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(51.93605f, -71.875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(37.50937f, -73.5336f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(36.06671f, -35.9375f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(46.16537f, -22.11532f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(48.56982f, -5.528759f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(37.02848f, 17.69234f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(38.47114f, 115.553f) });
            return list.ToArray();
        }
        public static Il2CppReferenceArray<PointInfo> track5()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-147.633f, 72.98092f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-85.11741f, 56.39422f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-49.05071f, 48.6539f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-2.404443f, 46.9953f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(41.83736f, 49.75968f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(83.19385f, 56.39422f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(118.2988f, 66.89906f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(147.1521f, 75.19234f) });
            return list.ToArray();
        }





        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var area0_ = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0_.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, -115.2764f));
            area0_.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.1904f, -114.1706f));
            area0_.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6712f, 114.1708f));
            area0_.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, 114.7236f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0_), 0, (AreaType)2));
            var area0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.8735f, -114.447f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.8735f, -105.0481f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.34187f, 89.01438f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(98.34187f, 106.7067f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(140.6601f, 107.2597f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(140.6601f, 74.08656f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(100.7463f, 74.08656f));
            area0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-138.2557f, -114.447f));
            newareas.Add(new AreaModel("lol0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)0));
            var area1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, -114.447f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, -32.06734f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-133.2063f, -44.23078f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-113.4899f, -56.39408f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-91.36897f, -65.79328f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-63.47739f, -73.5336f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.62403f, -79.61532f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-6.732453f, -83.48562f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.9617701f, -83.48562f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(36.54758f, -77.95672f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(61.07294f, -74.63938f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.04096f, -67.45188f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(104.8339f, -60.81734f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(121.1841f, -50.86532f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.1521f, -31.51438f));
            area1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.1521f, -115f));
            newareas.Add(new AreaModel("lol1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area1), 10, (AreaType)0));
            var area2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1139f, -34.83172f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-93.77341f, -68.0047f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-43.28004f, -82.93266f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.14314f, -82.93266f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.66225f, -35.9375f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-47.12715f, -23.77406f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-48.56982f, -8.8461f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-45.20359f, 4.42312f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.21958f, 18.79812f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-32.21958f, 115.553f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.79915f, 115.553f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.31826f, 25.98562f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-56.74494f, 6.63468f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-58.6685f, -13.82204f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-54.82138f, -30.4086f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-41.83737f, -41.4664f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-42.31826f, -69.66344f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-98.58231f, -52.52406f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-141.3815f, -24.8797f));
            area2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, -21.00968f));
            newareas.Add(new AreaModel("lol2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)0));
            var area3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.633f, -30.96142f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(115.8943f, -54.18266f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(90.40719f, -65.79328f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(56.26406f, -75.74516f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.18136f, -77.95672f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.21959f, -33.17312f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.79915f, -18.79812f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.31826f, -1.10578f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.21959f, 15.48078f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.18136f, 114.447f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.83736f, 115f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.31826f, 19.9039f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.53159f, 7.1875f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.41694f, -7.1875f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(52.89782f, -18.79812f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(49.05072f, -28.19704f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.35649f, -39.2547f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(41.35649f, -68.55766f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.84361f, -63.58172f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(92.81164f, -54.18266f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(123.1077f, -36.49032f));
            area3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.1521f, -21.00968f));
            newareas.Add(new AreaModel("lol3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)0));
            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.175117f, -115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-8.656011f, 115.553f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(1.442664f, 115.553f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.404452f, -113.8942f));
            newareas.Add(new AreaModel("lol4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)0));
            var area5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-148.1139f, 68.55766f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-63.95828f, 47.54812f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-23.56358f, 42.57218f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(0.9617701f, 42.57218f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(42.79915f, 44.7836f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(88.00273f, 51.97124f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(147.1521f, 71.32218f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(146.6712f, 80.72124f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(85.5983f, 61.3703f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(38.47114f, 53.07688f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(2.404452f, 51.97124f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-35.58581f, 53.62984f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-100.9868f, 65.79328f));
            area5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-147.633f, 77.95672f));
            newareas.Add(new AreaModel("lol5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area5), 10, (AreaType)0));
            var area6 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.18136f, 25.43266f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-34.14314f, 115f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(33.66225f, 115f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.70047f, 21.5625f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(5.770674f, 46.44234f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.366222f, 53.07688f));
            area6.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.66225f, 25.43266f));
            newareas.Add(new AreaModel("lol6", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area6), 10, (AreaType)0));
            var area7 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.18136f, -56.39408f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-3.366222f, -61.37016f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.21959f, -54.73562f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(32.70047f, -38.70188f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(17.31202f, -44.7836f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(7.213338f, -40.91344f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-2.885337f, -34.83172f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-15.86935f, -42.57204f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-25.00624f, -44.7836f));
            area7.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-33.66225f, -41.4664f));
            newareas.Add(new AreaModel("lol7", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area7), 10, (AreaType)0));











            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "track1",
                        "track2",
                        "track3",
                        "track4",
                        "track5",
                    }), new SplitterModel("", new string[]
                    {
                        "track1",
                        "track2",
                        "track3",
                        "track4",
                        "track5",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("track1", track1(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track2", track2(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track3", track3(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track4", track4(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                        new PathModel("track5", track5(), true, false, new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), new Il2CppAssets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}
