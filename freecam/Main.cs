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

namespace freecam
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            Logger.Log("experiments loaded");
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
                    InGame.instance.sceneCamera.transform.position += InGame.instance.sceneCamera.transform.right * -5;//new UnityEngine.Vector3(5, 0, 0);
                }
                if (UnityEngine.Input.GetKey(UnityEngine.KeyCode.D))
                {
                    InGame.instance.sceneCamera.transform.position += InGame.instance.sceneCamera.transform.right * 5; //new UnityEngine.Vector3(-5, 0, 0);
                }
                if (UnityEngine.Input.GetKey(UnityEngine.KeyCode.LeftControl))
                {
                    InGame.instance.sceneCamera.transform.position += new UnityEngine.Vector3(0, -5, 0);
                }
                if (UnityEngine.Input.GetKey(UnityEngine.KeyCode.Space))
                {
                    InGame.instance.sceneCamera.transform.position += new UnityEngine.Vector3(0, 5, 0);
                }
                InGame.instance.sceneCamera.transform.LookAt(new UnityEngine.Vector3(0, 0, 0));
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