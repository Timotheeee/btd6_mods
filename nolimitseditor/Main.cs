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

using Il2CppTMPro;

using Il2CppAssets.Scripts.Simulation.Towers;

using Il2CppAssets.Scripts.Utils;

using Il2CppSystem.Collections;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Simulation.Objects;
using Il2CppAssets.Scripts.Models;

using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using UnityEngine;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Unity.Scenes;
using System.Linq;
using BTD_Mod_Helper;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Collections.Generic;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Unity.UI_New.ChallengeEditor;
using UnityEngine.UI;
using static Il2CppTMPro.TMP_InputField;

[assembly: MelonInfo(typeof(nolimitseditor.Main), nolimitseditor.ModHelperData.Name, nolimitseditor.ModHelperData.Version, nolimitseditor.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace nolimitseditor
{
    public class Main : BloonsTD6Mod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("nolimitseditor loaded");
        }



        [HarmonyPatch(typeof(ChallengeEditor), "SetupUI")]
        public class ChallengeEditor_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(ChallengeEditor __instance)
            {
                TMP_InputField cash = __instance.cash;
                TMP_InputField lives = __instance.lives;
                TMP_InputField maxLives = __instance.maxLives;
                TMP_InputField round = __instance.round;

                __instance.endRound.characterLimit = 9999;
                round.characterLimit = 9999;
                maxLives.characterLimit = 9999;

                lives.characterLimit = 9999;
                cash.characterLimit = 9999;
                Slider bloonSpeed = __instance.bloonSpeed;
                Slider regrowSpeed = __instance.regrowSpeed;
                Slider moabSpeed = __instance.moabSpeed;
                Slider ceramicHealth = __instance.ceramicHealth;
                Slider moabHealth = __instance.moabHealth;

                moabHealth.maxValue = 9999;
                ceramicHealth.maxValue = 9999;
                moabSpeed.maxValue = 9999;
                regrowSpeed.maxValue = 9999;
                bloonSpeed.maxValue = 9999;

                moabHealth.minValue = 0.0001f;
                ceramicHealth.minValue = 0.0001f;
                moabSpeed.minValue = 0.0001f;
                regrowSpeed.minValue = 0.0001f;
                bloonSpeed.minValue = 0.0001f;

                moabHealth.wholeNumbers = false;
                ceramicHealth.wholeNumbers = false;
                moabSpeed.wholeNumbers = false;
                regrowSpeed.wholeNumbers = false;
                bloonSpeed.wholeNumbers = false;


                ((TMP_InputField)__instance.chalName).characterLimit = 9999;
                ((TMP_InputField)__instance.chalName).characterValidation = (CharacterValidation)0;
            }
        }



        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {

            }
        }


        public override void OnTitleScreen()
        {




        }


    }

}