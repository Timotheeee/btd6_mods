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
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using TMPro;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using UnityEngine;

namespace range_changer
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("range_changer loaded");
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
            if (Input.GetKeyDown(KeyCode.F4))
            {
                Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                {
                    var rangeMultiplier = float.Parse(s);
                    foreach (var tower in Game.instance.model.towers)
                    {
                        tower.range *= rangeMultiplier;
                        foreach (var bev in tower.behaviors)
                        {
                            try
                            {
                                bev.Cast<AttackModel>().range *= rangeMultiplier;
                            }
                            catch
                            {

                            }
                        }

                    }

                };



                PopupScreen.instance.ShowSetNamePopup("range", "multiply range by", mod, "0.5");

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