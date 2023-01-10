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

[assembly: MelonInfo(typeof(range_changer.Main), range_changer.ModHelperData.Name, range_changer.ModHelperData.Version, range_changer.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace range_changer
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("range_changer loaded. press F4 to use");
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
                    if (inAGame)
                    {
                        foreach (var tower in InGame.instance.GetGameModel().towers)
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