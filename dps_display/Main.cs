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
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using System.Linq;
using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles;
using UnityEngine;
using Il2CppTMPro;

[assembly: MelonInfo(typeof(dps_display.Main), dps_display.ModHelperData.Name, dps_display.ModHelperData.Version, dps_display.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace dps_display
{
    public class Main : MelonMod
    {

        static GameObject upgradeTreeButton;
        static TowerToSimulation lastSelected;
        static long lastDamage = 0;
        static float timer = 0;

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("dps_display loaded");
        }


        static void Write(string t)
        {
            if (upgradeTreeButton == null)
            {
                upgradeTreeButton = GameObject.Find("UpgradeTreeButton");
            }
            upgradeTreeButton.GetComponentInChildren<TextMeshProUGUI>().text = t;
        }




        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {

                if (InGame.instance.inputManager.SelectedTower != null)
                {
                    lastSelected = InGame.instance.inputManager.SelectedTower;
                    if (timer == 0)
                    {
                        timer = 0.001f;
                        lastDamage = lastSelected.damageDealt;
                    }
                    timer += UnityEngine.Time.deltaTime;
                    if (timer > 1)
                    {
                        timer = 0;
                        Write("" + (lastSelected.damageDealt - lastDamage));
                    }
                }
                else
                {
                    timer = 0;
                    lastDamage = 0;
                    if (upgradeTreeButton != null)
                        Write("UPGRADES");

                }



            }
        }








    }

}