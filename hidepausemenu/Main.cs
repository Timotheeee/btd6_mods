using MelonLoader;
using Harmony;

using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Il2CppAssets.Main.Scenes;
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

[assembly: MelonInfo(typeof(hidepausemenu.Main), hidepausemenu.ModHelperData.Name, hidepausemenu.ModHelperData.Version, hidepausemenu.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace hidepausemenu
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("hidepausemenu loaded");
        }






        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (Input.GetKeyDown(KeyCode.F2))
                {


                    foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
                    {
                        if (ob.name == "PauseMenuPanel")
                            ob.transform.position += new Vector3(1000, 1000, 0);
                    }

                }
            }
        }








    }

}