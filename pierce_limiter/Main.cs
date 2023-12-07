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

[assembly: MelonInfo(typeof(pierce_limiter.Main), pierce_limiter.ModHelperData.Name, pierce_limiter.ModHelperData.Version, pierce_limiter.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace pierce_limiter
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("pierce_limiter loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();

            //var pierce = 1;



            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;

            if (change)
            {
                if (PopupScreen.instance.GetFirstActivePopup() != null)
                {
                    PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;
                    change = false;
                }

            }
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F8))
            {


                Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                {
                    var pierce = float.Parse(s);
                    foreach (var tower in Game.instance.model.towers)
                    {
                        foreach (var attack in tower.GetAttackModels())
                        {
                            foreach (var proj in attack.GetAllProjectiles())
                            {
                                proj.pierce = pierce;
                                proj.maxPierce = pierce;
                                proj.CapPierce(pierce);
                                proj.ignorePierceExhaustion = false;
                                Console.WriteLine(tower.name + ", " + proj.name + " set pierce to " + pierce);
                            }
                        }
                        foreach (var ability in tower.GetAbilities())
                        {
                            foreach (var activateAttackModel in ability.GetBehaviors<ActivateAttackModel>())
                            {
                                foreach (var attack in activateAttackModel.attacks)
                                {
                                    foreach (var proj in attack.GetAllProjectiles())
                                    {
                                        proj.pierce = pierce;
                                        proj.maxPierce = pierce;
                                        proj.CapPierce(pierce);
                                        proj.ignorePierceExhaustion = false;
                                        Console.WriteLine(tower.name + ", " + proj.name + " set pierce to " + pierce);
                                    }
                                }
                            }
                        }
                    }

                };


                if (inAGame)
                    PopupScreen.instance.ShowSetNamePopup("use this in the main menu", "", mod, "no");
                else
                    PopupScreen.instance.ShowSetNamePopup("max pierce", "what should the max pierce of all weapons be", mod, "1");

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