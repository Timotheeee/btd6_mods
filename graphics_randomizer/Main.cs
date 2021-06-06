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
using System;
using Assets.Scripts.Simulation.Towers.Behaviors;
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using System.Linq;
using Assets.Main.Scenes;
using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Unity.Display;
using System.IO;
using UnityEngine;

namespace graphics_randomizer
{
    public class Main : MelonMod
    {

        //static string[] fac =
        //{

        //};

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("graphics_randomizer loaded");
        }



        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {

            [HarmonyPostfix]
            public static void Postfix()
            {
                foreach (var tower in Game.instance.model.towers)
                {



                }
            }
        }


        [HarmonyPatch(typeof(Factory), nameof(Factory.FindAndSetupPrototypeAsync))]
        public class lol
        {

            [HarmonyPrefix]
            public static bool Prefix(Factory __instance, ref string objectId, Il2CppSystem.Action<UnityDisplayNode> onComplete)
            {
                //File.AppendAllText("factory.txt", "\""+objectId + "\",\n");
                //objectId = "";

                return false;
            }
        }

        //[HarmonyPatch(typeof(ResourceLoader), nameof(ResourceLoader.LoadSpriteFromSpriteReferenceAsync))]
        //public class lolol
        //{
        //    [HarmonyPrefix]
        //    public static bool Prefix(SpriteReference reference, bool forceNoFade = false)
        //    {
        //        //File.AppendAllText("sprite.txt", "\"" + reference.guidRef + "\",\n");
        //        reference.guidRef = "";


        //        return false;
        //    }
        //}



        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                {
                    if (ob.GetComponent<TextMeshProUGUI>())
                        ob.GetComponent<TextMeshProUGUI>().text = "lol";
                }
            }
        }








    }

}