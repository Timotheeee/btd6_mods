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

using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Simulation.Input;

using Il2CppSystem.Collections.Generic;


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
using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Input;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Unity.Player;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using System.Linq;

[assembly: MelonInfo(typeof(unlimited_heroes.Main), unlimited_heroes.ModHelperData.Name, unlimited_heroes.ModHelperData.Version, unlimited_heroes.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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