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
using Il2CppSystem.Collections;
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
using UnityEngine;

namespace first_person
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("first_person BETA!!!!! loaded");
        }

        static GameObject cam;
        //static int towerID = 0;
        static bool following = false;

        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {


                if (cam == null)
                {
                    cam = new GameObject();//GameObject.Instantiate(new GameObject(), new Vector3(5, 5, 5), Quaternion.identity);
                    cam.transform.position = new Vector3(0, 300, -200);
                    cam.transform.LookAt(new Vector3(0, 0, 0));
                    cam.AddComponent<Camera>();
                    cam.GetComponent<Camera>().orthographic = false;
                    cam.tag = "MainCamera";
                    cam.name = "newcam";
                    InGame.instance.sceneCamera = cam.GetComponent<Camera>();
                    foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                    {
                        if (ob.GetComponent<Camera>() && ob.name.Contains("Cameras"))
                        {
                            //Console.WriteLine("1:" + ob.name);
                            GameObject.Destroy(ob);
                        }
                        if (ob.GetComponentInChildren<Camera>() && ob.name.Contains("Cameras"))
                        {
                            //Console.WriteLine("2:" + ob.name);
                            GameObject.Destroy(ob);
                        }

                    }
                }


                //var towers = InGame.instance.bridge.GetAllTowers();
                //if (towers.Count == 0) return;
                //if (towerID == towers.Count) towerID = 0;
                //var tower = towers[towerID];
                //InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(tower.position.x, 5, tower.tower.Node.position.Y);
                //InGame.instance.sceneCamera.transform.position -= InGame.instance.sceneCamera.transform.forward * 0.1f;
                //var old = tower.tower.Node.rotationQuat.EulerAngles;
                //var eu = new Vector3(old.x, old.y, old.z);
                //InGame.instance.sceneCamera.transform.rotation.SetEulerAngles(eu);


                //DartlingMuzzleFlash
                if (following)
                {
                    foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                    {
                        //if (ob.GetComponent<Renderer>() && ob.name.Contains("DartlingMuzzleFlash"))
                        //{
                        //    //Console.WriteLine("1:" + ob.name);
                        //    cam.transform.LookAt(ob.transform);
                        //    var newpos = cam.transform.position + cam.transform.forward * 200;
                        //    cam.transform.LookAt(new Vector3(newpos.x, 35, newpos.z));
                        //    break;

                        //}
                        if (ob.name.Contains("DartlingMuzzleFlash"))
                        {
                            //Console.WriteLine("2:" + ob.name);
                            cam.transform.LookAt(ob.transform);
                            var newpos = cam.transform.position + cam.transform.forward * 200;
                            cam.transform.LookAt(new Vector3(newpos.x, 25, newpos.z));
                            break;
                        }

                    }
                }


                if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.F3))
                {
                    //towerID++;
                    //cam.transform.position = new Vector3(InGame.instance.inputManager.cursorPositionWorld.x, 5, InGame.instance.inputManager.cursorPositionWorld.y);
                    foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                    {
                        //if (ob.GetComponent<Renderer>() && ob.name.Contains("DartlingGunner(Clone)"))
                        //{
                        //    //Console.WriteLine("1:" + ob.name);
                        //    cam.transform.position = new Vector3(ob.transform.position.x, 35, ob.transform.position.z);
                        //    break;

                        //}
                        if (ob.name.Contains("DartlingGunner(Clone)"))
                        {
                            //Console.WriteLine("2:" + ob.name);
                            cam.transform.position = new Vector3(ob.transform.position.x, 35, ob.transform.position.z);
                            break;
                        }

                    }
                    following = true;

                }
                if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.F2))
                {
                    //foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                    //{
                    //    if (ob.GetComponent<Renderer>() && ob.name.ToLower().Contains("dartling"))
                    //    {
                    //        Console.WriteLine("1:" + ob.name);

                    //    }
                    //    if (ob.GetComponentInChildren<Renderer>() && ob.name.ToLower().Contains("dartling"))
                    //    {
                    //        Console.WriteLine("2:" + ob.name);

                    //    }
                    //}
                    following = false;
                    cam.transform.position = new Vector3(0, 300, -200);
                    cam.transform.LookAt(new Vector3(0, 0, 0));
                }
            }
        }




        [EventAttribute("KeyPressEvent")]
        public static void onEvent(KeyEvent e)
        {


            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {


                if (e.key == UnityEngine.KeyCode.F8)
                {


                    InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(0, 0, 0);
                    InGame.instance.sceneCamera.transform.rotation = UnityEngine.Quaternion.Euler(60, 0, 0);
                    InGame.instance.sceneCamera.orthographicSize = 100;
                }

            }


        }





    }

}