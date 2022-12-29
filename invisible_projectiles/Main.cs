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
using Il2CppAssets.Main.Scenes;
using Il2CppAssets.Scripts.Models.GenericBehaviors;

[assembly: MelonInfo(typeof(invisible_projectiles.Main), invisible_projectiles.ModHelperData.Name, invisible_projectiles.ModHelperData.Version, invisible_projectiles.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace invisible_projectiles
{
    public class Main : MelonMod
    {


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("invisible_projectiles loaded");
        }



        [HarmonyPatch(typeof(TravelStrait), "Initialise")]
        internal class TravelStrait_Patch
        {

            [HarmonyPostfix]
            internal static void Postfix(ref TravelStrait __instance)
            {
                
                __instance.projectile.projectileModel.display = new PrefabReference() { guidRef = "" };


            }

        }












    }

}