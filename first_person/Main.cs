using MelonLoader;
using HarmonyLib;
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
using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppSystem.Linq;

[assembly: MelonInfo(typeof(first_person.Main), first_person.ModHelperData.Name, first_person.ModHelperData.Version, first_person.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace first_person
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            Console.WriteLine("[FirstPerson] ========== MOD LOADED ==========");
        }

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                Console.WriteLine("[FirstPerson] TitleScreen Start Postfix triggered");
                foreach (var tower in Game.instance.model.towers)
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
                        }
                        catch
                        {
                        }
                    }
                }
                Console.WriteLine("[FirstPerson] TitleScreen patch completed");
            }
        }

        static GameObject cam;
        static Camera camComponent;
        static Camera sceneCamera;
        static bool following = false;
        static TowerToSimulation lastSelected = null;
        static float offset = 40;
        static float Yoffset = 0;
        static int frameCount = 0;

        // Store original camera settings
        static bool originalOrthographic;
        static float originalOrthographicSize;
        static float originalFOV;
        static float originalNearClip;
        static float originalFarClip;
        static Vector3 originalPosition;
        static Quaternion originalRotation;
        static List<MonoBehaviour> disabledBehaviours = new List<MonoBehaviour>();

        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.F3))
                {
                    Console.WriteLine("[FirstPerson] ========== F3 PRESSED ==========");

                    Camera sceneCam = InGame.instance.sceneCamera;
                    if (sceneCam != null)
                    {
                        // Store original settings BEFORE changing anything
                        originalOrthographic = sceneCam.orthographic;
                        originalOrthographicSize = sceneCam.orthographicSize;
                        originalFOV = sceneCam.fieldOfView;
                        originalNearClip = sceneCam.nearClipPlane;
                        originalFarClip = sceneCam.farClipPlane;
                        originalPosition = sceneCam.transform.position;
                        originalRotation = sceneCam.transform.rotation;

                        Console.WriteLine($"[FirstPerson] Stored - Ortho: {originalOrthographic}, OrthoSize: {originalOrthographicSize}, FOV: {originalFOV}");
                        Console.WriteLine($"[FirstPerson] Stored - Pos: {originalPosition}, Rot: {originalRotation.eulerAngles}");
                        Console.WriteLine($"[FirstPerson] Stored - NearClip: {originalNearClip}, FarClip: {originalFarClip}");

                        // Clear and store disabled behaviours
                        disabledBehaviours.Clear();

                        // Disable camera behaviours
                        var allBehaviours = sceneCam.gameObject.GetComponents<MonoBehaviour>();
                        foreach (var behaviour in allBehaviours)
                        {
                            if (behaviour != null && behaviour.enabled)
                            {
                                Console.WriteLine($"[FirstPerson] Disabling: {behaviour.GetIl2CppType().FullName}");
                                behaviour.enabled = false;
                                disabledBehaviours.Add(behaviour);
                            }
                        }

                        // Also disable on "Cameras" parent
                        GameObject camerasObj = GameObject.Find("Cameras");
                        if (camerasObj != null)
                        {
                            foreach (var behaviour in camerasObj.GetComponents<MonoBehaviour>())
                            {
                                if (behaviour != null && behaviour.enabled)
                                {
                                    Console.WriteLine($"[FirstPerson] Disabling on Cameras: {behaviour.GetIl2CppType().FullName}");
                                    behaviour.enabled = false;
                                    disabledBehaviours.Add(behaviour);
                                }
                            }
                        }

                        sceneCam.orthographic = false;
                        sceneCam.fieldOfView = 110;
                    }

                    following = true;
                    Console.WriteLine("[FirstPerson] ========== F3 COMPLETE ==========");
                }

                if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.F2))
                {
                    Console.WriteLine("[FirstPerson] ========== F2 PRESSED ==========");
                    following = false;

                    Camera sceneCam = InGame.instance.sceneCamera;
                    if (sceneCam != null)
                    {
                        // Restore original settings
                        sceneCam.orthographic = originalOrthographic;
                        sceneCam.orthographicSize = originalOrthographicSize;
                        sceneCam.fieldOfView = originalFOV;
                        sceneCam.nearClipPlane = originalNearClip;
                        sceneCam.farClipPlane = originalFarClip;
                        sceneCam.transform.position = originalPosition;
                        sceneCam.transform.rotation = originalRotation;

                        Console.WriteLine($"[FirstPerson] Restored - Ortho: {sceneCam.orthographic}, OrthoSize: {sceneCam.orthographicSize}, FOV: {sceneCam.fieldOfView}");
                        Console.WriteLine($"[FirstPerson] Restored - Pos: {sceneCam.transform.position}, Rot: {sceneCam.transform.rotation.eulerAngles}");

                        // Re-enable all behaviours we disabled
                        foreach (var behaviour in disabledBehaviours)
                        {
                            if (behaviour != null)
                            {
                                Console.WriteLine($"[FirstPerson] Re-enabling: {behaviour.GetIl2CppType().FullName}");
                                behaviour.enabled = true;
                            }
                        }
                        disabledBehaviours.Clear();
                    }

                    Console.WriteLine("[FirstPerson] ========== F2 COMPLETE ==========");
                }

                if (Input.GetKey(KeyCode.Alpha4))
                {
                    if (Input.GetKey(KeyCode.LeftControl))
                        offset += 0.12f;
                    else if (Input.GetKey(KeyCode.LeftShift))
                        Yoffset += 0.12f;
                    else if (lastSelected != null && lastSelected.tower != null)
                        lastSelected.tower.RotateTower(0.02f, true, true);
                }

                if (Input.GetKey(KeyCode.Alpha5))
                {
                    if (Input.GetKey(KeyCode.LeftControl))
                        offset -= 0.12f;
                    else if (Input.GetKey(KeyCode.LeftShift))
                        Yoffset -= 0.12f;
                    else if (lastSelected != null && lastSelected.tower != null)
                        lastSelected.tower.RotateTower(-0.02f, true, true);
                }
            }
        }

        public override void OnLateUpdate()
        {
            base.OnLateUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame && following)
            {
                frameCount++;

                var inputs = InGame.instance.InputManagers;
                if (inputs == null || inputs.Count() == 0) return;

                InputManager input = inputs.First();

                if (input != null && input.SelectedTower != null)
                    lastSelected = input.SelectedTower;

                Camera sceneCam = InGame.instance.sceneCamera;
                if (sceneCam == null) return;

                sceneCam.orthographic = false;
                sceneCam.fieldOfView = 110;
                sceneCam.nearClipPlane = 0.1f;
                sceneCam.farClipPlane = 2000f;

                if (lastSelected != null && lastSelected.tower != null && lastSelected.tower.Node != null)
                {
                    Vector3 newPos = new Vector3(lastSelected.tower.Node.position.X, offset, (lastSelected.tower.Node.position.Y * -1));
                    sceneCam.transform.position = newPos;

                    float eulerlol = lastSelected.tower.Rotation;
                    if (eulerlol >= 0)
                        eulerlol = 180 - eulerlol;
                    else
                        eulerlol = -180 - eulerlol;

                    sceneCam.transform.rotation = Quaternion.Euler(0, eulerlol, 0);
                }
                else
                {
                    sceneCam.transform.position = new Vector3(0, 130, -90);
                    sceneCam.transform.LookAt(new Vector3(0, 0, 0));
                }

                if (!sceneCam.enabled)
                {
                    sceneCam.enabled = true;
                }
            }
        }
    }
}