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

//using Il2CppSystem.Collections;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using System.Reflection;
using Il2CppAssets.Scripts.Models;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using System;
using System.Linq;
using Il2CppAssets.Scripts.Models.ServerEvents;
using Il2CppAssets.Scripts.Data.Cosmetics.Pets;
using Il2CppAssets.Main.Scenes;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Models.Store;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Map;

[assembly: MelonInfo(typeof(energy_bloons.Main), energy_bloons.ModHelperData.Name, energy_bloons.ModHelperData.Version, energy_bloons.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace energy_bloons
{
    public class Main : MelonMod
    {


        public static System.Random r = new System.Random();
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("energy_bloons loaded");
        }

        [HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        public class InitMap_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {
                map.mapWideBloonSpeed = 5;

                //map.areas[0].polygon.


                for (int p = 0; p < map.paths.Count; p++)
                {
                    Il2CppReferenceArray<PointInfo> arr = new Il2CppReferenceArray<PointInfo>(map.paths[p].points.Count);
                    for (int i = 0; i < map.paths[p].points.Count; i++)
                    {
                        PointInfo pointinfo = map.paths[p].points[i];
                        var vec = pointinfo.point;
                        //map.paths[0].points[i]
                        pointinfo.point = new Assets.Scripts.Simulation.SMath.Vector3(vec.x + ((float)r.NextDouble() * 10), vec.y + ((float)r.NextDouble() * 10), vec.z);
                        arr[i] = pointinfo;
                    }
                    map.paths[p].points = arr;
                }




                return true;
            }

        }

    }
}