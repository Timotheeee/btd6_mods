using MelonLoader;
using Harmony;
using NKHook6.Api;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using NKHook6;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
using Assets.Scripts.Unity.UI_New.Main;
using NKHook6.Api.Events;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using static NKHook6.Api.Events._Towers.TowerEvents;
using Assets.Scripts.Simulation.Towers;

using static NKHook6.Api.Events._Weapons.WeaponEvents;
using Assets.Scripts.Utils;

using static NKHook6.Api.Events._TimeManager.TimeManagerEvents;
//using Il2CppSystem.Collections;
using NKHook6.Api.Events._Bloons;
using NKHook6.Api.Events._Weapons;
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

namespace tar_pits
{
    class Data
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-125.993f, -29.30282f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-116.8561f, -33.72594f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-106.2765f, -43.125f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-88.96452f, -53.6297f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-69.72895f, -54.73562f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-56.26405f, -45.88938f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-48.08893f, -35.38468f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-42.79915f, -21.00968f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-46.64627f, -2.21142f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-54.34049f, 7.74032f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-66.84361f, 17.13938f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-77.90407f, 19.35094f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-90.88808f, 18.79812f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-100.5059f, 12.16358f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-108.2001f, -0.5528198f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-112.5281f, -12.16344f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-111.5663f, -27.0914f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-122.6268f, -29.30282f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track2()
        {

            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-30.77692f, -112.2356f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-17.79291f, -106.1538f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-4.328001f, -107.8125f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(9.617789f, -108.9183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(21.64001f, -105.0481f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(29.33425f, -98.9664f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(34.14315f, -90.12016f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(37.02848f, -79.0625f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(37.02848f, -68.0047f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(31.7387f, -54.73562f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25.00624f, -46.99516f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(14.90757f, -40.36062f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(2.404452f, -37.5961f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-8.656011f, -38.14906f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-21.15913f, -46.44234f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-28.37247f, -54.73562f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32.70048f, -63.58172f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-35.10492f, -77.40376f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32.21958f, -86.25f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-29.33425f, -95.64906f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-22.6018f, -103.9423f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-30.29602f, -112.7884f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track3()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(113.9708f, -54.18266f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(107.2383f, -45.33642f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(113.9708f, -35.38468f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(119.2606f, -23.2211f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(120.2223f, -11.61062f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(112.5281f, 3.31734f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(107.2383f, 12.16358f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(98.10142f, 19.35094f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(88.96452f, 21.00968f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(74.53785f, 23.22124f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(65.88183f, 17.13938f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(56.74493f, 11.61062f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.49338f, 0.5529602f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(48.56982f, -8.8461f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(47.60804f, -20.45672f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(48.56982f, -29.30282f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(53.8596f, -37.04328f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(59.63028f, -43.67782f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(67.80539f, -47.54812f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(79.82763f, -49.20672f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(91.84985f, -51.41828f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(102.9103f, -45.88938f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(113.4899f, -53.07688f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track4()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(91.36897f, 95.64906f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(79.34673f, 92.33172f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(71.6525f, 101.178f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(63.47739f, 106.7067f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(52.41694f, 108.9183f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(36.54758f, 106.1539f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(26.44892f, 97.86062f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(20.19735f, 87.9086f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(16.83113f, 71.32218f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(19.23558f, 61.92312f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(25.96802f, 53.62984f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(37.02848f, 45.88938f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(50.01249f, 42.57218f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(61.55384f, 44.23078f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(73.09518f, 51.41828f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(80.7894f, 60.81734f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(84.63651f, 71.875f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(81.27029f, 85.69704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(92.33074f, 93.99032f) });
            return list.ToArray();


        }
        public static Il2CppReferenceArray<PointInfo> track5()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-87.04096f, 106.1539f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-79.82763f, 98.9664f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-86.56007f, 87.9086f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-88.96452f, 72.42796f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-87.04096f, 57.5f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-79.82763f, 48.6539f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-69.24806f, 45.33656f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-60.11116f, 42.57218f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-49.53159f, 42.01922f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-39.91381f, 43.125f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-32.21958f, 48.6539f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-26.9298f, 54.73562f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-19.71646f, 64.13468f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-17.79291f, 74.08656f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-20.19735f, 85.69704f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-25.00624f, 95.64906f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-31.7387f, 103.3894f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-40.87559f, 109.4712f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-50.01249f, 110.5769f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-59.14938f, 111.1298f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-69.72895f, 107.8125f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-74.05695f, 103.9423f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-77.90407f, 98.9664f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-87.52186f, 106.7067f) });
            return list.ToArray();


        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();

            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, -115.2764f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.1904f, -114.1706f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.6712f, 114.1708f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.633f, 114.7236f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, -51.69469f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-146.6712f, 0.2764099f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-116.8561f, -3.59375f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-111.0854f, 10.22843f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.5059f, 19.07453f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-88.48363f, 22.39187f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-73.09518f, 21.28609f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-62.03472f, 18.52171f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.89782f, 14.09859f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.08893f, 5.25249f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.28004f, -3.59375f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.91381f, -11.88703f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-38.95203f, -24.60329f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.87559f, -36.76687f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.16537f, -42.29563f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.41693f, -48.37735f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-57.70672f, -53.35329f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.3245f, -56.67063f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.01873f, -58.88219f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.19385f, -57.77641f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-98.10142f, -55.56485f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.2001f, -50.03595f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-113.9708f, -56.11781f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.7797f, -58.32923f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.1521f, -52.24751f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 10, (AreaType)0));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-107.7192f, -25.15625f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-103.8721f, -34.55531f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-95.21608f, -41.18985f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-87.04096f, -46.16593f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-76.94229f, -48.93031f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.88184f, -46.71875f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.6685f, -40.63703f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-52.89782f, -33.44953f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-48.56982f, -24.05047f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.60804f, -13.54563f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-49.53159f, -5.25235f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.37871f, -0.2764099f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-58.6685f, 5.25249f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.40094f, 10.22843f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.49962f, 13.54577f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-86.07919f, 11.88703f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.77341f, 7.46405f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.9868f, 1.93515f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105.3148f, -4.69953f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-108.681f, -12.99281f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-109.1619f, -22.39187f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-106.7574f, -31.23797f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 10, (AreaType)2));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.43292f, -0.2764099f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-33.18136f, -10.78125f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-25.00624f, -20.73313f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.4649f, -26.26203f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.4808939f, -30.68515f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.38846f, -26.81485f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.52536f, -19.07453f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.2578f, -11.33407f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(35.10492f, -0.2764099f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(34.62402f, 12.43985f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.7387f, 28.47359f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.48713f, 38.42547f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(18.27379f, 44.50719f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.617789f, 46.16593f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-0.9617789f, 46.71875f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.38845f, 43.40141f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.6018f, 37.87265f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-30.29602f, 31.23811f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.54759f, 21.83905f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.87559f, 8.56969f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.91381f, -1.93515f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.50936f, -6.91095f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 10, (AreaType)1));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-66.12228f, -114.1706f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.14802f, -113.6178f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.97914f, -104.2188f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(38.23069f, -94.81969f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.0396f, -80.44469f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.63515f, -62.19953f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(33.9027f, -47.27157f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(19.9569f, -36.21391f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.972891f, -32.34375f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.858228f, -33.44953f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.36135f, -37.87251f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.46003f, -48.93031f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.15426f, -63.30531f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.11604f, -78.78595f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-40.63515f, -88.18515f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.64139f, -114.1706f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)0));
            var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.47602f, -95.92547f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.530227f, -104.2188f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.82001f, -104.2188f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(20.91869f, -97.58421f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.61292f, -88.73797f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.94091f, -76.57453f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.0938f, -61.09375f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(19.9569f, -50.58891f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(5.049333f, -42.84859f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.377342f, -45.61297f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.03335f, -52.80047f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.20847f, -63.30531f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-28.61291f, -77.12735f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.68936f, -89.29079f));
            area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.47602f, -96.47829f));
            newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5), 10, (AreaType)2));
            var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(146.4308f, -71.59859f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(105.5552f, 20.73313f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.72408f, 29.02641f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.45029f, 27.36781f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.58094f, 19.07453f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.36759f, 7.46405f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.52047f, -6.35813f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.0396f, -21.28595f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(47.36759f, -38.42547f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.02361f, -46.71875f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(65.16051f, -55.01203f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.14452f, -56.67063f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(107.4788f, -81.55047f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.4468f, -83.76203f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(137.2939f, -84.31485f));
            area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.3926f, -68.28125f));
            newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6), 10, (AreaType)0));
            var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.7463f, -40.63703f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.845f, -26.26203f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.2494f, -10.78125f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(110.3641f, 1.38219f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(101.2272f, 11.33407f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(90.16674f, 17.41593f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.18273f, 16.86311f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(67.08406f, 12.99281f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(56.98538f, 4.69953f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.13826f, -5.80531f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.65739f, -20.73313f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(55.54272f, -31.79093f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.31339f, -36.76687f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.96939f, -42.84859f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(84.87696f, -45.61297f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.4183f, -42.84859f));
            area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.7463f, -39.53125f));
            newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7), 10, (AreaType)2));
            var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(111.8068f, 77.12749f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.38983f, 36.21405f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(44.00137f, 36.76687f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(31.97914f, 38.97843f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.88046f, 45.61311f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.10979f, 53.90625f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.26267f, 64.41109f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.78179f, 73.25719f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(12.26267f, 83.76203f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.07158f, 90.94953f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.84225f, 104.7717f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.05559f, 110.3005f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.52047f, 114.7236f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(117.0965f, 114.7236f));
            area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(114.2112f, 78.23313f));
            newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8), 10, (AreaType)0));
            var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.62541f, 85.42077f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.93118f, 98.13703f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(58.90894f, 105.8775f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(48.81027f, 106.4303f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(41.11604f, 103.113f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.46002f, 100.3486f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.76581f, 92.60813f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.39957f, 80.44469f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.88046f, 66.06969f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.32312f, 58.32937f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.0938f, 54.45907f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(36.30714f, 48.37749f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(43.52047f, 46.71875f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.65739f, 44.50719f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.23695f, 48.37749f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.45029f, 53.90625f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(76.70185f, 62.75249f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.54895f, 70.49281f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.54895f, 79.89187f));
            area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.10629f, 84.86781f));
            newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9), 10, (AreaType)2));
            var area10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-120.4628f, 114.7236f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-82.9534f, 46.16593f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.93117f, 41.18985f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-57.94716f, 37.87265f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.40582f, 37.87265f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.38359f, 42.29577f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-26.20847f, 48.37749f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.99512f, 58.32937f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.14802f, 68.83407f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.6289f, 82.65625f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.51424f, 92.60813f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.84224f, 104.2188f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-34.38359f, 115.2764f));
            area10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-118.0583f, 114.1708f));
            newareas.Add(new AreaModel("lol10", new Assets.Scripts.Simulation.SMath.Polygon(area10), 10, (AreaType)0));
            var area11 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.74007f, 96.47843f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-82.47252f, 85.42077f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-83.4343f, 73.25719f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.99163f, 62.75249f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-76.22095f, 55.01203f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.08406f, 50.58905f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-56.98538f, 48.37749f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.48226f, 48.37749f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-36.30714f, 52.24765f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-29.09381f, 61.64671f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.32313f, 69.93985f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-23.32313f, 82.65625f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-27.65113f, 92.05531f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-32.94091f, 99.24281f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.0396f, 104.7717f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-53.13827f, 106.4303f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-63.23695f, 106.4303f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.93117f, 102.0072f));
            area11.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.74007f, 97.03125f));
            newareas.Add(new AreaModel("lol11", new Assets.Scripts.Simulation.SMath.Polygon(area11), 10, (AreaType)2));










            return newareas.ToArray();


        }


    }
}
