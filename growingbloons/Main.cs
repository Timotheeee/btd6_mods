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
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Map;

[assembly: MelonInfo(typeof(growingbloons.Main), growingbloons.ModHelperData.Name, growingbloons.ModHelperData.Version, growingbloons.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace growingbloons
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("growingbloons loaded");
        }

        [HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        public class InitMap_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {


                for (int p = 0; p < map.paths.Count; p++)
                {
                    var c = map.paths[p].points.Count;
                    Il2CppReferenceArray<PointInfo> arr = new Il2CppReferenceArray<PointInfo>(map.paths[p].points.Count);
                    for (int i = 0; i < c; i++)
                    {
                        PointInfo pointinfo = map.paths[p].points[i];
                        pointinfo.bloonScale = mapFloat(i, 0, c, 0.8f, 1.2f);
                        pointinfo.moabScale = mapFloat(i, 0, c, 0.8f, 1.2f);
                        arr[i] = pointinfo;
                    }
                    map.paths[p].points = arr;
                }




                return true;
            }

        }

        public static float mapFloat(float value, float from1, float to1, float from2, float to2)
        {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }




        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {

            }
        }








    }

}