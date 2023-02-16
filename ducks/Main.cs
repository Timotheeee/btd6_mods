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
using Il2CppAssets.Scripts.Simulation.Towers.Pets;
using UnityEngine;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;

[assembly: MelonInfo(typeof(ducks.Main), ducks.ModHelperData.Name, ducks.ModHelperData.Version, ducks.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace ducks
{
    public class Main : MelonMod
    {

        static string duck = "ffa2218b0c489d44d9b811001a802150";
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("ducks loaded");
        }

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {



                foreach (var tower in Game.instance.model.towers)
                {
                    tower.display = new PrefabReference() { guidRef = duck };

                    foreach (var disp in tower.GetBehaviors<DisplayModel>())
                    {
                        disp.display = new PrefabReference() { guidRef = duck };
                    }

                    if (tower.HasBehavior<AirUnitModel>())
                        foreach (var disp in tower.GetBehaviors<AirUnitModel>())
                        {
                            disp.display = new PrefabReference() { guidRef = duck };
                        }


                }

                foreach (var bloon in Game.instance.model.bloons)
                {
                    bloon.display = new PrefabReference() { guidRef = duck };
                    bloon.GetBehavior<DisplayModel>().display = new PrefabReference() { guidRef = duck };
                    foreach (var dmg in bloon.damageDisplayStates)
                    {
                        dmg.displayPath = new PrefabReference() { guidRef = duck };
                    }
                    if (bloon.HasBehavior<DamageStateModel>())
                    {
                        foreach (var state in bloon.GetBehaviors<DamageStateModel>())
                        {
                            state.displayPath = new PrefabReference() { guidRef = duck };
                        }
                    }



                }



            }
        }


        [HarmonyPatch(typeof(TravelStrait), "Initialise")]
        internal class TravelStrait_Patch
        {

            [HarmonyPostfix]
            internal static void Postfix(ref TravelStrait __instance)
            {

                __instance.projectile.projectileModel.display = new PrefabReference() { guidRef = duck };


            }

        }






        //static List<Pet> pets = new List<Pet>();

        //[HarmonyPatch(typeof(Pet), "Initialise")]
        //class petinitpatch
        //{
        //    [HarmonyPostfix]
        //    static void Postfix(ref Pet __instance)
        //    {
        //        pets.Add(__instance);
        //    }
        //}

        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                //if (Input.GetKeyDown(KeyCode.F2))
                //{
                //    foreach (var pet in pets)
                //    {
                //        Console.WriteLine(pet.petModel.name + " " + pet.petModel.display);
                //    }
                //}
            }
        }








    }

}