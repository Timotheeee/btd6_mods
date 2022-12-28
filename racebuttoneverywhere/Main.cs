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

using System.Runtime.InteropServices;
using Il2CppAssets.Scripts.Models.ServerEvents;
using Il2CppAssets.Scripts.Models.Store;
using Il2CppAssets.Scripts.Models.Store.Loot;
using System.Runtime.CompilerServices;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Simulation.Map.Triggers;
using Il2CppAssets.Scripts.Unity.Towers.Projectiles.Behaviors;
using Age = Assets.Scripts.Simulation.Towers.Projectiles.Behaviors.Age;
using Il2CppAssets.Scripts.Simulation.Track;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Unity.Menu;
using Il2CppAssets.Scripts.Unity.UI_New.Pause;
using UnityEngine;
using TMPro;
using System;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.RightMenu;
using Il2CppAssets.Scripts.Unity.UI_New.ChallengeEditor;

[assembly: MelonInfo(typeof(racemod.Main), racemod.ModHelperData.Name, racemod.ModHelperData.Version, racemod.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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
        bool shiftOnly = false;

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
                        try {
                            var btn = FindObject(GameObject.Find("ShopMenu16:9"), "SendRound");
                            btn.active = true;
                            Console.WriteLine("btn pos: " + btn.transform.position.x);
                            btn.transform.position -= new Vector3(30, 0, 0);
                        } catch {

                        }
                        
                        enableButtonTimer = 0;
                    }

                }
                if (Input.GetKeyDown(KeyCode.F1))
                {
                    shiftOnly = !shiftOnly;
                    Console.WriteLine("only shift required: " + shiftOnly);
                }
                bool sending = shiftOnly ? Input.GetKeyDown(KeyCode.LeftShift) : Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Space);
                if (sending)
                {
                    Send();

                }
                if (Input.GetMouseButtonDown(0))
                {
                    var v3 = Input.mousePosition;
                    v3 = InGame.instance.sceneCamera.ScreenToWorldPoint(v3);
                    float x = v3.x;
                    float y = v3.y * -2.3f;
                    if (x > 145 && x < 165 && y > 90 && y < 110)
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

        //[HarmonyPatch(typeof(Spawner), "OnRoundEndProjectiles")]
        //public class OnRoundEndProjectiles_Patch
        //{

        //    [HarmonyPrefix]
        //    public static bool Prefix()
        //    {

        //        return false;
        //    }
        //}

        public static void Send()
        {
            try
            {
                //InGame.Bridge.GameSimulation.StartRaceRound(false);
                InGame.instance.bridge.simulation.StartRound();
                player.Play();
            }
            catch { }
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

            if (round <= InGame.instance.bridge.GetEndRound())
            {


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

        [HarmonyPatch(typeof(UnityToSimulation), nameof(UnityToSimulation.Lose))]
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
