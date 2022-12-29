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
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using System;
using UnityEngine;
using Il2CppAssets.Main.Scenes;

[assembly: MelonInfo(typeof(price_changer.Main), price_changer.ModHelperData.Name, price_changer.ModHelperData.Version, price_changer.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace price_changer
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("price_changer loaded");
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

            if (Input.GetKeyDown(KeyCode.F11))
            {
                Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                {
                    var multi = float.Parse(s);
                    foreach (TowerModel towerModel in Game.instance.model.towers)
                    {
                        towerModel.cost *= multi;
                    }
                    foreach (UpgradeModel upgradeModel in Game.instance.model.upgrades)
                    {
                        upgradeModel.cost = (int)(upgradeModel.cost * multi);
                    }
                    if (inAGame)
                    {
                        foreach (TowerModel towerModel in InGame.Bridge.Model.towers)
                        {
                            towerModel.cost *= multi;
                        }
                        foreach (UpgradeModel upgradeModel in InGame.Bridge.Model.upgrades)
                        {
                            upgradeModel.cost = (int)(upgradeModel.cost * multi);
                        }
                    }

                };


                PopupScreen.instance.ShowSetNamePopup("prices", "multiply prices by", mod, "1.56");

                change = true;
            }

        }

        static bool change;

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                {
                };

                PopupScreen.instance.ShowSetNamePopup("Price Changer", "Press F11 to multiply prices", mod, "");
            }
        }




    }

}