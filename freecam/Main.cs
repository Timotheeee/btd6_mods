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

[assembly: MelonInfo(typeof(freecam.Main), freecam.ModHelperData.Name, freecam.ModHelperData.Version, freecam.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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