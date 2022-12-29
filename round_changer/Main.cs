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
using UnityEngine;

[assembly: MelonInfo(typeof(round_changer.Main), round_changer.ModHelperData.Name, round_changer.ModHelperData.Version, round_changer.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace round_changer
{
    public class Main : MelonMod
    {


        static bool change;
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            System.Console.WriteLine("round_changer loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;

            if (change)
            {
                if (PopupScreen.instance.GetFirstActivePopup() != null)
                {
                    PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;
                    change = false;
                }

            }
            if (inAGame)
            {

            }
            if (Input.GetKeyDown(KeyCode.F8))
            {
                Il2CppSystem.Action<int> mod = (Il2CppSystem.Action<int>)delegate (int s)
                {

                    InGame.instance.bridge.SetRound(s);
                };
                

                PopupScreen.instance.ShowSetValuePopup("round", "change round to", mod, 3);
                change = true;

            }

        }





        //[HarmonyPatch(typeof(Weapon), "Initialise")]
        //public class WeaponInitialise_Patch
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix(Weapon __instance)
        //    {
        //        __instance.attack.attackModel.range *= rangeMultiplier;
        //    }
        //}



    }

}