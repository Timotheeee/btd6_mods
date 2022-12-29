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

using Il2CppSystem.Collections;
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
using UnityEngine;
using Il2CppAssets.Scripts.Unity.UI_New;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Unity.Bridge;
using System.IO;
using Il2CppAssets.Main.Scenes;
using Il2CppAssets.Scripts.Unity.Map;

[assembly: MelonInfo(typeof(cars.Main), cars.ModHelperData.Name, cars.ModHelperData.Version, cars.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace cars
{
    public class Main : MelonMod
    {

        static bool independentRotation = false;

        [HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        public class InitMap_Patch
        {
            [HarmonyPrefix]
            public static void Postfix()
            {
                if (car == null)
                {
                    if (assetBundle == null)
                    {
                        Console.WriteLine("loading assets...");
                        //assetBundle = AssetBundle.LoadFromMemory(File.ReadAllBytes(@"carbundle2"));//Properties.Resources.ingame_popup
                        assetBundle = AssetBundle.LoadFromMemory(Resource1.carbundle2);
                        Console.WriteLine("loaded assets: " + (assetBundle != null));
                    }
                    if (carAsset == null)
                    {
                        carAsset = assetBundle.LoadAsset("car").Cast<GameObject>();//.Cast<GameObject>();
                        Console.WriteLine("loaded car: " + (carAsset != null));
                    }
                    car = GameObject.Instantiate(carAsset);
                    car.transform.position = new Vector3(1000, 0, 0);
                    //car.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
                }
            }
        }

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("cars loaded");
        }

        public static GameObject car;
        public static AssetBundle assetBundle;
        public static GameObject carAsset;
        static TowerToSimulation lastSelected;



        static float speed = 0;
        public float convert(float orig)
        {
            if (orig >= 0)
            {
                orig = 180 - orig;
            }
            else
            {
                orig = -180 - orig;
            }
            return orig;
        }

        public override void OnUpdate()
        {
            base.OnUpdate();

            if (Input.GetKeyDown(KeyCode.F1))
            {
                independentRotation = !independentRotation;
                Console.WriteLine("independent rotation: " + independentRotation);
            }

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {


                if (InGame.instance.inputManager.SelectedTower != null)
                    lastSelected = InGame.instance.inputManager.SelectedTower;
                if (lastSelected != null && lastSelected.tower != null)
                {
                    speed *= 0.9f;
                    if (Input.GetKey(KeyCode.UpArrow))
                    {
                        speed = 2;
                    }
                    if (Input.GetKey(KeyCode.DownArrow))
                    {
                        speed = -1.3f;
                    }
                    if (Input.GetKey(KeyCode.LeftArrow))
                    {
                        if (!independentRotation)
                        {
                            lastSelected.tower.RotateTower(speed * 0.02f, true, true);
                        }
                        else
                        {
                            car.transform.RotateAround(new Vector3(0, 1, 0), speed * -0.02f);
                        }
                    }
                    if (Input.GetKey(KeyCode.RightArrow))
                    {
                        if (!independentRotation)
                        {
                            lastSelected.tower.RotateTower(speed * -0.02f, true,true);
                        }
                        else
                        {
                            car.transform.RotateAround(new Vector3(0, 1, 0), speed * 0.02f);
                        }
                    }

                    if (independentRotation)
                    {
                        Vector3 towerpos = new Vector3(lastSelected.tower.Node.position.X, 0, lastSelected.tower.Node.position.Y);
                        if ((car.transform.position - new Vector3(towerpos.x, 0, towerpos.z * -1)).magnitude > 5)
                        {
                            car.transform.rotation = Quaternion.Euler(0, convert(lastSelected.tower.Rotation), 0);
                            car.transform.position = new Vector3(towerpos.x, 0, towerpos.z * -1);
                        }
                        car.transform.position += car.transform.forward * speed;
                        lastSelected.tower.PositionTower(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(car.transform.position.x, -car.transform.position.z));
                    }
                    else
                    {
                        float eulerlol = lastSelected.tower.Rotation;

                        car.transform.rotation = Quaternion.Euler(0, eulerlol, 0);

                        Vector3 towerpos = new Vector3(lastSelected.tower.Node.position.X, 0, lastSelected.tower.Node.position.Y);
                        towerpos += car.transform.forward * speed;
                        lastSelected.tower.PositionTower(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(towerpos.x, towerpos.z));

                        //for some reason towers live in an alternate universe where rotations and y positions are inverted
                        car.transform.position = new Vector3(towerpos.x, 0, towerpos.z * -1);
                        eulerlol = convert(eulerlol);
                        car.transform.rotation = Quaternion.Euler(0, eulerlol, 0);
                    }

                }
                else
                {
                    car.transform.position = new Vector3(1000, 0, 0);
                    speed = 0;
                }


            }
        }








    }

}