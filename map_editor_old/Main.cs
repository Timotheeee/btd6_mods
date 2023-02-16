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

using Il2CppAssets.Scripts.Unity.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Unity.UI_New;

[assembly: MelonInfo(typeof(map_editor.Main), map_editor.ModHelperData.Name, map_editor.ModHelperData.Version, map_editor.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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
            Console.WriteLine("map_editor loaded");
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
                        write("list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + \"\", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(" + x + "f, " + y + "f) });");
                    }
                    if (writingArea)
                    {
                        write("area" + index + ".Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(" + x + "f, " + y + "f));");
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
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    type = (int)AreaType.unplaceable;
                    if (mapeditor) Console.WriteLine("unplaceable");
                }



                if (Input.GetKeyDown(KeyCode.F1))
                {
                    //Il2CppReferenceArray<PointInfo> arr = new Il2CppReferenceArray<PointInfo>(3);
                    //arr[0] = new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-95f, -130f) };

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
                    //arr[0] = new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3(-95f, -130f) };

                    if (!writingArea)
                    {
                        write("var area" + index + " = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();");
                    }
                    if (writingArea)
                    {
                        if (type != (int)AreaType.unplaceable)
                        {
                            write("newareas.Add(new AreaModel(\"lol" + index + "\", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area" + index + "), 10, (AreaType)" + type + "));");
                        }
                        else
                        {
                            write("newareas.Add(new AreaModel(\"lol" + index + "\", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(area" + index + "), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));");

                        }
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
                //if (Input.GetKeyDown(KeyCode.F4))
                //{
                //    mapeditor = !mapeditor;
                //    Console.WriteLine("mapeditor: " + mapeditor);
                //}

            }
        }




    }
}