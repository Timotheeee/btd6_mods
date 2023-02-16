using MelonLoader;
using Harmony;

using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Il2CppAssets.Scripts.Unity.Scenes;
using UnityEngine;
using System.Linq;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Track;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles;
using Il2CppAssets.Scripts.Simulation.Towers;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using Il2CppTMPro;

[assembly: MelonInfo(typeof(damage_changer.Main), damage_changer.ModHelperData.Name, damage_changer.ModHelperData.Version, damage_changer.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace damage_changer
{
    public class Main : MelonMod
    {

        static float multi = 2;

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("damage_changer loaded. use keys 9+F1 in the main menu");
        }


        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                

            }
        }



        [HarmonyPatch(typeof(Damage), "Initialise")]
        public class WeakenPatch
        {
            [HarmonyPrefix]
            public static bool Prefix(Damage __instance, ref Model modelToUse)
            {
                if (!modelToUse.name.Contains("modified"))
                {
                    modelToUse.name += "modified";

                    DamageModel damageModel = modelToUse.Cast<DamageModel>();
                    damageModel.damage *= multi;
                    damageModel.maxDamage *= multi;

                }
                return true;
            }
        }

        //[HarmonyPatch(typeof(Bloon), "RecieveDamage")]
        //public class lol
        //{
        //    [HarmonyPrefix]
        //    public static bool Prefix(Bloon __instance, ref float amount, Projectile projectile, bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, Tower tower, bool blockSpawnChildren)
        //    {

        //        amount *= 2;
        //        return true;
        //    }
        //}



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

            if (Input.GetKey(KeyCode.Alpha9) && Input.GetKeyDown(KeyCode.F1))
            {
                Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                {
                    multi = float.Parse(s);

                };
                if (!inAGame)
                {
  


                    PopupScreen.instance.ShowSetNamePopup("damage", "multiply damage values by", mod, "2");

                    change = true;
                } else
                {
                    PopupScreen.instance.ShowSetNamePopup("hey", "this only works in the main menu", mod, "lol");
                }

            }

        }

        static bool change;








    }

}