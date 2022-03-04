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

using Assets.Scripts.Models.TowerSets;
using Assets.Scripts.Simulation.Input;

using Il2CppSystem.Collections.Generic;


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

using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Main.Scenes;
using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Simulation.Input;
using BTD_Mod_Helper;
using Assets.Scripts.Unity.Player;
using Assets.Scripts.Unity.UI_New.Main.MapSelect;
using System.Linq;

namespace unlimited_heroes
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("unlimited_heroes loaded.");
        }




        [HarmonyPatch(typeof(TowerInventory), "Init")]
        public class ShowMedal_Patch2
        {
            [HarmonyPrefix]
            public static bool Prefix(ref IEnumerable<TowerDetailsModel> allTowersInTheGame)
            {
                //Console.WriteLine("infinite heroes step 1");

                //allTowersInTheGame = allTowersInTheGame.Cast<List<TowerDetailsModel>>();
                var allTowersInTheGame2 = allTowersInTheGame.ToIl2CppList();
                //allTowersInTheGame.ToIl2CppReferenceArray

                for (int i = 0; i < allTowersInTheGame2.Count; i++)
                {
                    //Console.WriteLine("infinite heroes loop ");
  
                    if (allTowersInTheGame2[i].IsHero()) {
                        //Console.WriteLine(allTowersInTheGame2[i].name);
                        //Console.WriteLine(allTowersInTheGame2[i].towerCount);
                        allTowersInTheGame2[i].towerCount = -1;
                    }


                }

                
                allTowersInTheGame = allTowersInTheGame2.Cast<IEnumerable<TowerDetailsModel>>();

                return true;
            }
        }




    }

}