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
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Models.Towers.Upgrades;
using System;
using UnityEngine;
using Assets.Main.Scenes;

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