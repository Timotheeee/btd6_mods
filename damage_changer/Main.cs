using MelonLoader;
using Harmony;

using Assets.Scripts.Unity.UI_New.InGame;

using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity;
using Assets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Assets.Main.Scenes;
using UnityEngine;
using System.Linq;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Simulation.Track;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Simulation.Bloons;
using UnhollowerBaseLib;
using Assets.Scripts.Simulation.Towers.Projectiles;
using Assets.Scripts.Simulation.Towers;
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Assets.Scripts.Unity.UI_New.Popups;
using TMPro;

namespace damage_changer
{
    public class Main : MelonMod
    {

        static float multi = 2;

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("damage_changer loaded");
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


                PopupScreen.instance.ShowSetNamePopup("damage", "multiply damage values by", mod, "2");

                change = true;
            }

        }

        static bool change;








    }

}