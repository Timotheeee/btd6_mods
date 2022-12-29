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
using Il2CppAssets.Scripts.Unity.Display;
using System.IO;
using UnityEngine;

[assembly: MelonInfo(typeof(graphics_randomizer.Main), graphics_randomizer.ModHelperData.Name, graphics_randomizer.ModHelperData.Version, graphics_randomizer.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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