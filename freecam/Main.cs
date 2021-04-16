using MelonLoader;
using Harmony;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Scripts.Unity.UI_New.Main;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using Assets.Scripts.Simulation.Towers;

using Assets.Scripts.Utils;

using Il2CppSystem.Collections;
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

namespace freecam
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("experiments loaded");
        }



        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (UnityEngine.Input.GetKey(UnityEngine.KeyCode.W))
                {
                    InGame.instance.sceneCamera.orthographicSize -= 0.3f;//.transform.position += InGame.instance.sceneCamera.transform.forward*5;//new UnityEngine.Vector3(0, 0, 5);
                }
                if (UnityEngine.Input.GetKey(UnityEngine.KeyCode.S))
                {
                    InGame.instance.sceneCamera.orthographicSize += 0.3f;//.transform.position += InGame.instance.sceneCamera.transform.forward * -5;//new UnityEngine.Vector3(0, 0, -5);
                }
                if (UnityEngine.Input.GetKey(UnityEngine.KeyCode.A))
                {
                    if (InGame.instance.sceneCamera.transform.position == new UnityEngine.Vector3(0, 0, 0)) InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(5, 5, 5);
                    InGame.instance.sceneCamera.transform.position += InGame.instance.sceneCamera.transform.right * -0.2f;//new UnityEngine.Vector3(5, 0, 0);
                }
                if (UnityEngine.Input.GetKey(UnityEngine.KeyCode.D))
                {
                    if (InGame.instance.sceneCamera.transform.position == new UnityEngine.Vector3(0, 0, 0)) InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(5, 5, 5);
                    InGame.instance.sceneCamera.transform.position += InGame.instance.sceneCamera.transform.right * 0.2f; //new UnityEngine.Vector3(-5, 0, 0);
                }
                if (UnityEngine.Input.GetKey(UnityEngine.KeyCode.LeftControl))
                {
                    if (InGame.instance.sceneCamera.transform.position == new UnityEngine.Vector3(0, 0, 0)) InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(5, 5, 5);
                    InGame.instance.sceneCamera.transform.position += new UnityEngine.Vector3(0, -0.2f, 0);
                }
                if (UnityEngine.Input.GetKey(UnityEngine.KeyCode.Space))
                {
                    if (InGame.instance.sceneCamera.transform.position == new UnityEngine.Vector3(0, 0, 0)) InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(5, 5, 5);
                    InGame.instance.sceneCamera.transform.position += new UnityEngine.Vector3(0, 0.2f, 0);
                }
                InGame.instance.sceneCamera.transform.LookAt(new UnityEngine.Vector3(0, 0, 0));
            }



            if (inAGame)
            {


                if (Input.GetKeyDown(KeyCode.F8))
                {


                    InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(0, 0, 0);
                    InGame.instance.sceneCamera.transform.rotation = UnityEngine.Quaternion.Euler(60, 0, 0);
                    InGame.instance.sceneCamera.orthographicSize = 100;
                }

            }
        }









    }

}