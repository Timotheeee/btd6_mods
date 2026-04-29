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
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.Weapons;

[assembly: MelonInfo(typeof(rate_changer.Main), rate_changer.ModHelperData.Name, rate_changer.ModHelperData.Version, rate_changer.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace rate_changer
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            Console.WriteLine("fire rate changer loaded. press F9 in the MAIN MENU to use");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool flag = InGame.instance != null && InGame.instance.bridge != null;
            if (Main.change && PopupScreen.instance.GetFirstActivePopup() != null)
            {
                PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;
                Main.change = false;
            }
            if (Input.GetKeyDown(KeyCode.F9))
            {
                Action<string> action = delegate (string s)
                {
                    float num = float.Parse(s);
                    foreach (TowerModel towerModel in Game.instance.model.towers)
                    {
                        foreach (AttackModel attackModel in towerModel.GetAttackModels())
                        {
                            foreach (WeaponModel weaponModel in attackModel.weapons)
                            {
                                weaponModel.rate /= num;
                                weaponModel.Rate /= num;
                            }
                        }
                        foreach (AbilityModel model in towerModel.GetAbilities())
                        {
                            foreach (ActivateAttackModel activateAttackModel in model.GetBehaviors<ActivateAttackModel>())
                            {
                                foreach (AttackModel attackModel2 in activateAttackModel.attacks)
                                {
                                    foreach (WeaponModel weaponModel2 in attackModel2.weapons)
                                    {
                                        weaponModel2.rate /= num;
                                        weaponModel2.Rate /= num;
                                    }
                                }
                            }
                        }
                    }
                };
                if (flag)
                {
                    PopupScreen.instance.ShowSetNamePopup("use this in the main menu", "", action, "no");
                }
                else
                {
                    PopupScreen.instance.ShowSetNamePopup("fire rate (stacks with previous changes)", "multiply fire rate by", action, "0.5");
                }
                Main.change = true;
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