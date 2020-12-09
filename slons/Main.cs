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

namespace slons
{
    public class Main : MelonMod
    {


        public static System.Random r = new System.Random();
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            Logger.Log("slons loaded");
        }



        [HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        public class InitMap_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {
                if (map.mapName != "FourCircles") return true;

                //map.mapWideBloonSpeed *= 4;
                Il2CppReferenceArray<AreaModel> newareas = new Il2CppReferenceArray<AreaModel>(map.areas.Count + 2);

                for (int i = 0; i < map.areas.Count; i++)
                {

                    newareas[i] = map.areas[i];
                    if (i > 2 && newareas[i].type == AreaType.track) newareas[i].type = AreaType.land;
                }

                var track1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>(4);
                track1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-85f, -130f));
                track1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105f, -130f));
                track1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-85f, -65f));
                track1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-105f, -65f));

                var track2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>(4);
                track2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-95f, -55f));
                track2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-95f, -75f));
                track2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-160f, -55f));
                track2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-160f, -75f));

                newareas[map.areas.Length] = map.areas[1];
                newareas[map.areas.Length].polygon = new Assets.Scripts.Simulation.SMath.Polygon(track1);

                newareas[map.areas.Length + 1] = map.areas[2];
                newareas[map.areas.Length + 1].polygon = new Assets.Scripts.Simulation.SMath.Polygon(track2);

                map.areas = newareas;

                //Console.WriteLine(map.areas.Length);
                //Console.WriteLine(map.blockers.Length);

                //foreach (var area in map.areas)
                //{
                //    Console.WriteLine("type: " + area.type);
                //    Console.WriteLine("polygon: ");
                //    foreach (var point in area.polygon.points)
                //    {
                //        Console.WriteLine("point: " + point.x + " " + point.y);
                //    }
                //}


                Il2CppReferenceArray<PointInfo> arr = new Il2CppReferenceArray<PointInfo>(3);
                PointInfo pointinfo;

                pointinfo = map.paths[0].points[0];
                pointinfo.point = new Assets.Scripts.Simulation.SMath.Vector3(-95f, -130f);
                arr[0] = pointinfo;

                pointinfo = map.paths[0].points[1];
                pointinfo.point = new Assets.Scripts.Simulation.SMath.Vector3(-95f, -65f);
                arr[1] = pointinfo;

                pointinfo = map.paths[0].points[2];
                pointinfo.point = new Assets.Scripts.Simulation.SMath.Vector3(-160f, -65f);
                arr[2] = pointinfo;


                map.paths[0].points = arr;




                return true;
            }

        }

    }
}