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
using Assets.Scripts.Unity.UI_New;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Unity.Bridge;

namespace first_person
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("first_person (BETA!!!!!) loaded");
        }

        static GameObject cam;
        //static int towerID = 0;
        static bool following = false;
        static TowerToSimulation lastSelected = null;
        static float offset = 40;
        static float Yoffset = 0;

        [HarmonyPatch(typeof(Game), "GetVersionString")]
        public class Awake_Patch
        {
            // Token: 0x060004FA RID: 1274 RVA: 0x0001940C File Offset: 0x0001760C
            [HarmonyPostfix]
            public static void Postfix()
            {
                foreach (var tower in Game.instance.getAllTowerModels())
                {
                    var n = tower.name.ToLower();
                    if (n.Contains("spike") || n.Contains("alch") || n.Contains("sniper"))
                        continue;
                    foreach (var bev in tower.behaviors)
                    {
                        try
                        {
                            var at = bev.Cast<AttackModel>();
                            at.fireWithoutTarget = true;
                            //at.AddBehaviour();
                        }
                        catch
                        {

                        }
                    }


                }
                //var dar = Game.instance.model.GetTower("DartlingGunner");
                //var atk = dar.GetBehavior<AttackModel>();


            }
        }

        //public static T GetBehavior<T>(this TowerModel towerModel) where T : TowerBehaviorModel
        //{
        //    var behaviors = towerModel.behaviors;
        //    var result = behaviors.FirstOrDefault(behavior => behavior.name.Contains(typeof(T).Name));
        //    return result.TryCast<T>();
        //}

        public override void OnUpdate()
        {
            base.OnUpdate();

            //Input.GetAxis("Mouse X");
            //Console.WriteLine(Input.GetAxis("Mouse X"));
            //Console.WriteLine(Input.GetAxis("Horizontal"));

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {





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
                    if (InGame.instance.inputManager.SelectedTower != null)
                        lastSelected = InGame.instance.inputManager.SelectedTower;

                    if(lastSelected != null && lastSelected.tower != null)
                    {
                        cam.transform.position = new Vector3(lastSelected.tower.getPos().x, offset, lastSelected.tower.getPos().y+ Yoffset);
                        float eulerlol = lastSelected.tower.Rotation;
                        if (eulerlol >= 0)
                        {
                            eulerlol = 180 - eulerlol;
                        }
                        else
                        {
                            eulerlol = -180 - eulerlol;
                        }

                        cam.transform.rotation = Quaternion.Euler(0, eulerlol, 0);
                    }



                    //InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(tower.position.x, 5, tower.tower.Node.position.Y);

                    //foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                    //{
                    //    //if (ob.GetComponent<Renderer>() && ob.name.Contains("DartlingMuzzleFlash"))
                    //    //{
                    //    //    //Console.WriteLine("1:" + ob.name);
                    //    //    cam.transform.LookAt(ob.transform);
                    //    //    var newpos = cam.transform.position + cam.transform.forward * 200;
                    //    //    cam.transform.LookAt(new Vector3(newpos.x, 35, newpos.z));
                    //    //    break;

                    //    //}
                    //    //if (ob.name.Contains("DartlingMuzzleFlash"))
                    //    //{
                    //    //    //Console.WriteLine("2:" + ob.name);
                    //    //    cam.transform.LookAt(ob.transform);
                    //    //    var newpos = cam.transform.position + cam.transform.forward * 200;
                    //    //    cam.transform.LookAt(new Vector3(newpos.x, 25, newpos.z));
                    //    //    break;
                    //    //}
                    //    if (ob.name.Contains("SuperMonkey(Clone)"))//DartlingGunner
                    //    {
                    //        cam.transform.position = new Vector3(ob.transform.position.x, 45, ob.transform.position.z);
                    //        var newpos = ob.transform.position + ob.transform.forward * 200;
                    //        cam.transform.LookAt(new Vector3(newpos.x, 25, newpos.z));
                    //        break;
                    //    }

                    //}
                }


                if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.F3))
                {
                    //towerID++;
                    //cam.transform.position = new Vector3(InGame.instance.inputManager.cursorPositionWorld.x, 5, InGame.instance.inputManager.cursorPositionWorld.y);
                    //foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                    //{
                    //    //if (ob.GetComponent<Renderer>() && ob.name.Contains("DartlingGunner(Clone)"))
                    //    //{
                    //    //    //Console.WriteLine("1:" + ob.name);
                    //    //    cam.transform.position = new Vector3(ob.transform.position.x, 35, ob.transform.position.z);
                    //    //    break;

                    //    //}
                    //    if (ob.name.Contains("SuperMonkey(Clone)"))
                    //    {
                    //        //Console.WriteLine("2:" + ob.name);
                    //        cam.transform.position = new Vector3(ob.transform.position.x, 55, ob.transform.position.z);
                    //        break;
                    //    }

                    //}
                    following = true;
                    if (cam == null)
                    {
                        cam = new GameObject();//GameObject.Instantiate(new GameObject(), new Vector3(5, 5, 5), Quaternion.identity);
                        cam.transform.position = new Vector3(0, 130, -90);
                        cam.transform.LookAt(new Vector3(0, 0, 0));
                        cam.AddComponent<Camera>();
                        cam.GetComponent<Camera>().orthographic = false;
                        cam.GetComponent<Camera>().fieldOfView = 110;
                        cam.tag = "MainCamera";
                        cam.name = "newcam";
                        
                        InGame.instance.sceneCamera = cam.GetComponent<Camera>();
                        GameObject.Find("Scene").GetComponent<Camera>().enabled = false;
                        //foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                        //{
                        //    //if (ob.GetComponent<Camera>() && ob.name.Contains("Cameras"))
                        //    //{
                        //    //    //Console.WriteLine("1:" + ob.name);
                        //    //    GameObject.Destroy(ob);
                        //    //}
                        //    //if (ob.GetComponentInChildren<Camera>() && ob.name.Contains("Cameras"))
                        //    //{
                        //    //    //Console.WriteLine("2:" + ob.name);
                        //    //    GameObject.Destroy(ob);
                        //    //}

                        //}
                    }

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
                    cam.transform.position = new Vector3(0, 130, -90);
                    cam.transform.LookAt(new Vector3(0, 0, 0));
                }
                //if (Input.GetKey(KeyCode.Alpha4) && !Input.GetKey(KeyCode.LeftControl))
                //{
                //    lastSelected.tower.RotateTower(0.02f, true);
                //    //var towers = InGame.instance.bridge.GetAllTowers();
                //    //var t = InGame.instance.inputManager.SelectedTower.tower;
                //    //foreach (var tower in towers)
                //    //{
                //    //    if (tower.tower.towerModel.baseId == TowerType.SuperMonkey)
                //    //    {
                //    //        tower.tower.RotateTower(0.02f, true);
                //    //    }
                //    //}
                //}

                if (Input.GetKey(KeyCode.Alpha4))
                {
                    if (Input.GetKey(KeyCode.LeftControl))
                    {
                        offset += 0.12f;
                    }
                    else if (Input.GetKey(KeyCode.LeftShift))
                    {
                        Yoffset += 0.12f;
                    }
                    else
                    {
                        lastSelected.tower.RotateTower(0.02f, true);
                    }
                }

                if (Input.GetKey(KeyCode.Alpha5))
                {
                    if (Input.GetKey(KeyCode.LeftControl))
                    {
                        offset -= 0.12f;
                    } else if (Input.GetKey(KeyCode.LeftShift))
                    {
                        Yoffset -= 0.12f;
                    } else
                    {
                        lastSelected.tower.RotateTower(-0.02f, true);
                    }
                }

            }
        }




        //[EventAttribute("KeyPressEvent")]
        //public static void onEvent(KeyEvent e)
        //{


        //    bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
        //    if (inAGame)
        //    {


        //        if (e.key == UnityEngine.KeyCode.F8)
        //        {


        //            InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(0, 0, 0);
        //            InGame.instance.sceneCamera.transform.rotation = UnityEngine.Quaternion.Euler(60, 0, 0);
        //            InGame.instance.sceneCamera.orthographicSize = 100;
        //        }

        //    }


        //}





    }

}