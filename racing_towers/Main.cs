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
using UnityEngine;

using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper;
using System.Text.RegularExpressions;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.Stats;
using System.Linq;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Map;
using BTD_Mod_Helper.Api.ModOptions;

[assembly: MelonInfo(typeof(racing_towers.Main), racing_towers.ModHelperData.Name, racing_towers.ModHelperData.Version, racing_towers.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace racing_towers
{
    public class Main : BloonsMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("racing_towers loaded.");
        }

        private readonly static ModSettingInt speed = new ModSettingInt(50)
        {
            displayName = "speed",
        };
        private readonly static ModSettingInt margin = new ModSettingInt(12)
        {
            displayName = "how close the tower has to be to go to the next checkpoint",
        };

        static new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<PointInfo> path;

        [HarmonyPatch(typeof(UnityToSimulation), nameof(UnityToSimulation.InitMap))]
        internal class InitMap_Patch
        {
            [HarmonyPrefix]
            internal static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {
                path = map.paths[0].points;
                return true;
            }
        }



        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                var pointsCount = path.Count;
                var bridge = InGame.instance.bridge;
                foreach (var tower in bridge.GetAllTowers())
                {
                    try
                    {
                        int waypoint = int.Parse(tower.GetTower().model.name);
                        //Console.WriteLine("parsed waypoint: " + waypoint);
                        if (waypoint == 0)
                        {
                            tower.tower.PositionTower(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(path[0].point.x, path[0].point.y));
                            tower.GetTower().model.name = "1";
                        } else 
                        {

                            Vector2 towerpos = new Vector2(tower.tower.Node.position.X, tower.tower.Node.position.Y);
                            Vector2 pointpos = new Vector2(path[waypoint].point.x, path[waypoint].point.y);

                            //check if next waypoint is reached
                            if((towerpos-pointpos).magnitude<margin)
                                waypoint++;
                            if (waypoint == pointsCount)
                            {
                                waypoint = 0;
                            }

                            //move
                            towerpos += (pointpos - towerpos).normalized*UnityEngine.Time.deltaTime* speed;
                            tower.tower.PositionTower(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(towerpos.x, towerpos.y));
                            tower.GetTower().model.name = waypoint + "";

                            //debug
                            //if(new System.Random().NextDouble()>0.8)
                            //    Console.WriteLine("Towerpos: " + towerpos.x + "," + towerpos.y + " Pointpos: " + pointpos.x + ", " + pointpos.y);
                        }
                    } catch
                    {
                        //Console.WriteLine("assigning 0");
                        tower.GetTower().model = tower.GetTower().model.Duplicate();
                        tower.GetTower().model.name = "0";
                    }
                }

            }
        }






    }

}