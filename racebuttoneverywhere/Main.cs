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

using System.Runtime.InteropServices;
using Assets.Scripts.Models.ServerEvents;
using Assets.Scripts.Models.Store;
using Assets.Scripts.Models.Store.Loot;
using System.Runtime.CompilerServices;
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Simulation.Map.Triggers;
using Assets.Scripts.Unity.Towers.Projectiles.Behaviors;
using Age = Assets.Scripts.Simulation.Towers.Projectiles.Behaviors.Age;
using Assets.Scripts.Simulation.Track;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Unity.Menu;
using Assets.Scripts.Unity.UI_New.Pause;
using UnityEngine;
using TMPro;
using System;
using Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;
using Assets.Scripts.Unity.UI_New.InGame.RightMenu;
using Assets.Scripts.Unity.UI_New.ChallengeEditor;

namespace racemod
{
    public class Main : MelonMod
    {
        static public int round;
        static public int defaultRound;
        static public float timer = 0;
        static public float enableButtonTimer = 0;
        static public bool simulateRaceRounds = false;
        static public bool wasntInGame = true;
        static public GameObject roundPanel;
        static public GameObject upgradeTreeButton;
        static public System.Media.SoundPlayer player;

        public static GameObject FindObject(GameObject parent, string name)
        {
            Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
            foreach (Transform t in trs)
            {
                if (t.name == name)
                {
                    return t.gameObject;
                }
            }
            return null;
        }
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("race mod loaded");

            player = new System.Media.SoundPlayer(Resource1.raceSound);//@"raceSound.wav");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            if (InGame.instance != null && InGame.instance.bridge != null)
            {
                if (enableButtonTimer > 0)
                {
                    enableButtonTimer += UnityEngine.Time.deltaTime;
                    if (enableButtonTimer > 2)
                    {
                        try { FindObject(GameObject.Find("ShopMenu16:9"), "SendRound").active = true; } catch { }
                        enableButtonTimer = 0;
                    }

                }
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Send();

                }
                if (Input.GetMouseButtonDown(0))
                {
                    var v3 = Input.mousePosition;
                    v3 = InGame.instance.sceneCamera.ScreenToWorldPoint(v3);
                    float x = v3.x;
                    float y = v3.y * -2.3f;
                    if (x > 150 && x < 170 && y > 90 && y < 110)
                        Send();
                }
                if (wasntInGame)
                {
                    round = InGame.instance.bridge.GetCurrentRound();
                    defaultRound = round;
                    timer = 0;
                    //Console.WriteLine("Round Counter reset to " + round);
                    wasntInGame = false;
                    enableButtonTimer = 0.001f;

                }
                if (timer > 0)
                {
                    timer += UnityEngine.Time.deltaTime;
                    if (upgradeTreeButton == null)
                    {
                        upgradeTreeButton = GameObject.Find("UpgradeTreeButton");
                    }
                    upgradeTreeButton.GetComponentInChildren<TextMeshProUGUI>().text = "" + timer;
                    //Console.WriteLine("Round: " + (round - 1) + " Timer: " + timer);
                }
                if (Input.GetKeyDown(KeyCode.F7))
                {
                    foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                    {
                        if (ob.name == "PauseMenuPanel")
                            ob.transform.position += new Vector3(1000, 1000, 0);
                    }
                }

            }
            else
            {
                wasntInGame = true;
            }
            //TimeManager.compromisedFastFowardRate = speed;
            //TimeManager.maxSimulationStepsPerUpdate = speed;

        }


        //[HarmonyPatch(typeof(PowerButton), "OnPointerClick")]
        //[HarmonyPatch(typeof(RightMenu), "ShowPowersMenu")]
        //public class OnPointerClick_Patch
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix()
        //    {
        //        Console.WriteLine("ShowPowersMenu");
        //        Send();
        //    }
        //}


        [HarmonyPatch(typeof(InGame), "Restart")]
        public class ResetRound_Patch
        {
            [HarmonyPostfix]
            public static void Postfix() // after the function happens, it will additionally run:
            {
                round = InGame.instance.bridge.GetCurrentRound();
                defaultRound = round;
                timer = 0;
                //Console.WriteLine("Round Counter reset to " + round);
            }
        }

        [HarmonyPatch(typeof(Spawner), "OnRoundEndProjectiles")]
        public class OnRoundEndProjectiles_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix()
            {

                return false;
            }
        }

        public static void Send()
        {
            if (round <= InGame.instance.bridge.GetEndRound())
            {
                try
                {
                    InGame.Bridge.GameSimulation.StartRaceRound(false);
                }
                catch
                {

                }
                try
                {
                    player.Play();
                }
                catch
                {

                }
                if (timer == 0)
                {
                    timer = 0.001f;
                }
                round++;
                if (roundPanel == null)
                {
                    roundPanel = GameObject.Find("RoundPanel");
                }
                roundPanel.GetComponentInChildren<TextMeshProUGUI>().text = "Race: " + round;
                //var ob = GameObject.Find("RoundPanel");
                //ob.GetComponentInChildren<TextMeshProUGUI>().text = "Race: " + round;
            }
        }

        //public override void OnUpdate()
        //{
        //    if (Input.GetKeyDown(KeyCode.LeftShift))
        //    {
        //        Send();
        //        player.Play();
        //    }
        //}

        [HarmonyPatch(typeof(InGame), "OnVictory")]
        class VictoryHook
        {
            [HarmonyPrefix]
            internal static bool Prefix(ref InGame __instance)
            {
                Console.WriteLine("Victory! Your time was: " + timer + " seconds!");
                round = defaultRound;
                timer = 0;
                return true;
            }
        }

        [HarmonyPatch(typeof(Simulation), "OnDefeat")]
        class DefeatedHook
        {
            [HarmonyPrefix]
            internal static bool Prefix(ref Simulation __instance)
            {
                //Console.WriteLine("Defeat");
                round = defaultRound;
                timer = 0;

                return true;
            }
        }




        //[HarmonyPatch(typeof(ChallengeEditor), "ValidateInputFields")]
        //public class Validation_Patch
        //{
        //    [HarmonyPrefix]
        //    public static bool Prefix()
        //    {
        //        return false;
        //    }
        //}

        //[HarmonyPatch(typeof(ChallengeEditor), "SetupUI")]
        //public class ChallengeEditor_Patch
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix(ChallengeEditor __instance)
        //    {
        //        __instance.cash.characterLimit = __instance.lives.characterLimit = __instance.maxLives.characterLimit = __instance.round.characterLimit =
        //            __instance.endRound.characterLimit = 9999;
        //        __instance.bloonSpeed.maxValue = __instance.moabSpeed.maxValue = __instance.ceramicHealth.maxValue = __instance.moabHealth.maxValue = 9999;
        //        __instance.regrowSpeed.minValue = 0.05f;
        //        __instance.regrowSpeed.maxValue = 9999;
        //        __instance.chalName.characterLimit = 9999;
        //        __instance.chalName.characterValidation = TMP_InputField.CharacterValidation.None;
        //    }
        //}

    }



}
