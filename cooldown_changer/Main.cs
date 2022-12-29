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

using BTD_Mod_Helper.Extensions;

using Il2CppAssets.Scripts.Simulation.Towers;

using Il2CppAssets.Scripts.Utils;

using Il2CppSystem.Collections;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Simulation.Objects;
using Il2CppAssets.Scripts.Models;
using Il2CppTMPro;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using UnityEngine;

[assembly: MelonInfo(typeof(cooldown_changer.Main), cooldown_changer.ModHelperData.Name, cooldown_changer.ModHelperData.Version, cooldown_changer.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace cooldown_changer
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            System.Console.WriteLine("cooldown_changer loaded");
        }



        static bool change;

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

            if (Input.GetKeyDown(KeyCode.F3))
            {
                Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                {
                    var multi = float.Parse(s);
                    foreach (var tower in Game.instance.model.towers)
                    {
                        try
                        {
                            foreach (var bev in tower.behaviors.GetItemsOfType<Model, AbilityModel>())
                            {
                                bev.Cooldown *= multi;
                            }
                        }
                        catch
                        {

                        }


                    }

                };


                PopupScreen.instance.ShowSetNamePopup("ability", "multiply cooldown by", mod, "0.5");

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