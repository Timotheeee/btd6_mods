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

[assembly: MelonInfo(typeof(rate_changer.Main), rate_changer.ModHelperData.Name, rate_changer.ModHelperData.Version, rate_changer.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace rate_changer
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("fire rate changer loaded. press F9 in the MAIN MENU to use");
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
            if (Input.GetKeyDown(KeyCode.F9))
            {

                Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                {
                    var multiplier = float.Parse(s);
                    foreach (var tower in Game.instance.model.towers)
                    {
                        foreach (var attack in tower.GetAttackModels())
                        {
                            foreach (var wep in attack.weapons)
                            {
                                wep.Rate /= multiplier;
                            }
                        }
                        foreach (var ability in tower.GetAbilities())
                        {
                            foreach (var activateAttackModel in ability.GetBehaviors<ActivateAttackModel>())
                            {
                                foreach (var attack in activateAttackModel.attacks)
                                {
                                    foreach (var wep in attack.weapons)
                                    {
                                        wep.Rate /= multiplier;
                                    }
                                }
                            }
                        }
                    }

                };


                if(inAGame)
                    PopupScreen.instance.ShowSetNamePopup("use this in the main menu", "", mod, "no");
                else
                    PopupScreen.instance.ShowSetNamePopup("fire rate (stacks with previous changes)", "multiply fire rate by", mod, "0.5");

                change = true;
            }

        }

        static bool change;




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