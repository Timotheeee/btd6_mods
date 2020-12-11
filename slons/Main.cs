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

namespace slons
{
    public class Main : MelonMod
    {


        public static System.Random r = new System.Random();
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            NKHook6.Logger.Log("slons loaded");
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

                }
            }
        }



        [HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        public class InitMap_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {
                //Console.WriteLine(map.mapName);
                if (map.mapName != "FourCircles") return true;//FourCircles//#ouch


                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(0, 0.0f, 0);
                cube.transform.localScale = new Vector3(-300, 0.001f, -235);

                Texture2D tex = null;
                byte[] fileData;
                string filePath = @"Mods\slons.png";//C:\Program Files (x86)\Steam\steamapps\common\BloonsTD6\
                Console.WriteLine(File.Exists(filePath) ? "map loaded" : "make sure slons.png is in the mods folder");
                if (File.Exists(filePath))
                {
                    fileData = File.ReadAllBytes(filePath);
                    tex = new Texture2D(2, 2);
                    ImageConversion.LoadImage(tex, fileData);
                }

                //Material mat = (Material)Resources.Load("FourCirclesObjects", Il2CppType.Of<Material>());
                //Console.WriteLine(mat.name);
                foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (ob.GetComponent<Renderer>())
                    {
                        //Console.WriteLine(ob.name);// || ob.name.Contains("Terrain") || ob.name.Contains("Range") 
                        if (ob.name.Contains("Candy") || ob.name.Contains("Gift")|| ob.name.Contains("SnowPatch") || ob.name.Contains("Jump") || ob.name.Contains("Timer") || ob.name.Contains("Ripples") || ob.name.Contains("Clock") || ob.name.Contains("RoundGrass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower"))
                            ob.transform.position -= new Vector3(1000, 1000, 1000);
                    }
                }


                foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (ob.GetComponent<Renderer>())
                    {
                        //Console.WriteLine(ob.GetComponent<Renderer>().material.name);
                        if (ob.GetComponent<Renderer>().material.name.Contains("Sprites-Default"))//FourCirclesObject
                        {
                            cube.GetComponent<Renderer>().material = ob.GetComponent<Renderer>().material;// new Material(Shader.Find("Specular"));
                                                                                                          //Console.WriteLine(cube.GetComponent<Renderer>().material.name);
                            cube.GetComponent<Renderer>().material.mainTexture = tex;
                            break;
                        }
                        //mat = ob.GetComponent<Renderer>().material;
                        //FourCirclesObject
                    }
                    //Console.WriteLine(ob.GetComponent<Renderer>().material.name);
                }

                Il2CppReferenceArray<AreaModel> newareas = new Il2CppReferenceArray<AreaModel>(map.areas.Count + 2);

                bool seenWater = false;
                for (int i = 0; i < map.areas.Count; i++)
                {
                    if (map.areas[i] == null) continue;
                    newareas[i] = map.areas[i];
                    if (newareas[i].type == AreaType.water && seenWater)
                    {
                        newareas[i].type = AreaType.land;
                    }
                    if (newareas[i].type == AreaType.water && !seenWater)
                    {
                        seenWater = true;
                    }
                    if (i > -1 && newareas[i].type == AreaType.track) newareas[i].type = AreaType.land;
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

                newareas[map.areas.Length] = new AreaModel("lol", new Assets.Scripts.Simulation.SMath.Polygon(track1),0,AreaType.track);//map.areas[1];
                newareas[map.areas.Length + 1] = new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(track2), 0, AreaType.track); //map.areas[2];


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