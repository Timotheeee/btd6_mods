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
using Il2CppAssets.Main.Scenes;

[assembly: MelonInfo(typeof(custom_projectiles.Main), custom_projectiles.ModHelperData.Name, custom_projectiles.ModHelperData.Version, custom_projectiles.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace custom_projectiles
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("custom_projectiles loaded. press shift+F9 to use while a tower is selected");
        }

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                try
                {
                    MelonLogger.Msg("printing tower names:");
                    foreach (var tower in Game.instance.model.towers)
                    {
                        Console.WriteLine(tower.name);
                    }
                }
                catch(Exception e)
                {
                    MelonLogger.Msg(e.Message);
                    MelonLogger.Msg(e.StackTrace);
                }


            }

        }

        static TowerToSimulation lastSelected;

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (PopupScreen.instance.GetFirstActivePopup() != null)
                {
                    if (PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>() != null)
                    {
                        PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;

                    }
                }


                if (InGame.instance.inputManager.SelectedTower != null)
                {
                    lastSelected = InGame.instance.inputManager.SelectedTower;
                }

                if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F9))
                {
                    if (lastSelected != null && lastSelected.tower != null)
                    {


                        Il2CppSystem.Action<string> message1 = (Il2CppSystem.Action<string>)delegate (string s)
                        {
                            TowerModel tower = null;
                            try
                            {
                                tower = InGame.instance.GetGameModel().GetTowerFromId(s);
                                MelonLogger.Msg("found tower: " + tower.name);
                            }
                            catch
                            {
                                MelonLogger.Msg("could not find tower: " + s);
                                return;
                            }
                            try
                            {
                                lastSelected.tower.towerModel.GetAttackModel();
                            }
                            catch
                            {
                                MelonLogger.Msg("selected tower has no attackmodel: " + s);
                                return;
                            }
                            try
                            {
                                var a = tower.GetAttackModel().weapons[0];
                            }
                            catch
                            {
                                MelonLogger.Msg("tower has no weapons: " + s); 
                                return;
                            }
                            var weapons = tower.GetAttackModel().weapons;
                            var weapon = weapons[0];
                            string oldname = lastSelected.tower.towerModel.GetAttackModel().weapons[0].projectile.name;
                            string newname = weapon.projectile.name;
                            lastSelected.tower.towerModel.GetBehavior<AttackModel>().weapons[0].projectile = weapon.projectile;
                            MelonLogger.Msg("success, replaced " + oldname + " with " + newname);

                        };



                        PopupScreen.instance.ShowSetNamePopup("Choose a tower to take the projectile from. Examples: NinjaMonkey-003. Tower names are in the console."
                            , "Tower name:", message1, "DartlingGunner-050");


                    }
                    else
                    {
                        MelonLogger.Msg("no tower selected");
                    }
                }


            }


        }







    }

}