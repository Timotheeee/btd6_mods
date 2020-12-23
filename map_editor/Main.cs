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
using Assets.Scripts.Unity.Map;
using Assets.Scripts.Models.Map.Spawners;
using Assets.Scripts.Unity.UI_New;

namespace map_editor
{
    public class Main : MelonMod
    {


        public static System.Random r = new System.Random();
        public static bool writingPoint = false;
        public static bool writingArea = false;
        public static int index = 0;
        public static int indexTrack = 1;
        public static int type = 0;
        public static bool mapeditor = true;




        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            NKHook6.Logger.Log("map_editor loaded");
            File.WriteAllText("map.txt", "");
        }
        public void write(string stuff)
        {
            if (mapeditor)
                File.AppendAllText("map.txt", stuff + "\n");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {

                if (Input.GetMouseButtonDown(0))//GetKeyDown(KeyCode.F3)
                {
                    var v3 = Input.mousePosition;
                    v3 = InGame.instance.sceneCamera.ScreenToWorldPoint(v3);
                    float x = v3.x;
                    float y = v3.y * -2.3f;
                    //Console.WriteLine(x + " " + y);
                    if (writingPoint)
                    {
                        write("list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + \"\", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(" + x + "f, " + y + "f) });");
                    }
                    if (writingArea)
                    {
                        write("area" + index + ".Add(new Assets.Scripts.Simulation.SMath.Vector2(" + x + "f, " + y + "f));");
                    }
                }

                if (Input.GetKeyDown(KeyCode.Alpha0))
                {
                    type = (int)AreaType.track;
                    if (mapeditor) Console.WriteLine("track");
                }

                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    type = (int)AreaType.water;
                    if (mapeditor) Console.WriteLine("water");
                }
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    type = (int)AreaType.land;
                    if (mapeditor) Console.WriteLine("land");
                }



                if (Input.GetKeyDown(KeyCode.F1))
                {
                    //Il2CppReferenceArray<PointInfo> arr = new Il2CppReferenceArray<PointInfo>(3);
                    //arr[0] = new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-95f, -130f) };

                    if (!writingPoint)
                    {
                        write("public static Il2CppReferenceArray<PointInfo> track" + indexTrack + "(){");
                        write("List<PointInfo> list = new List<PointInfo>();");
                    }
                    if (writingPoint)
                    {
                        write("return list.ToArray();");
                        write("}");
                        indexTrack++;
                    }
                    writingPoint = !writingPoint;
                    Console.WriteLine("writingPoint: " + writingPoint);
                }
                if (Input.GetKeyDown(KeyCode.F2))
                {
                    //Il2CppReferenceArray<PointInfo> arr = new Il2CppReferenceArray<PointInfo>(3);
                    //arr[0] = new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-95f, -130f) };

                    if (!writingArea)
                    {
                        write("var area" + index + " = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();");
                    }
                    if (writingArea)
                    {
                        write("newareas.Add(new AreaModel(\"lol" + index + "\", new Assets.Scripts.Simulation.SMath.Polygon(area" + index + "), 10, (AreaType)" + type + "));");
                        index++;
                    }
                    writingArea = !writingArea;
                    Console.WriteLine("writingArea: " + writingArea);

                }
                if (Input.GetKeyDown(KeyCode.F3))
                {
                    Il2CppSystem.Action<int> deb = (Il2CppSystem.Action<int>)delegate (int s)
                    {
                        index = s;
                    };
                    PopupScreen.instance.ShowSetValuePopup("index",
                    "which index ? ", deb, 11);

                }
                if (Input.GetKeyDown(KeyCode.F4))
                {
                    mapeditor = !mapeditor;
                    Console.WriteLine("mapeditor: " + mapeditor);
                }

            }
        }




    }
}