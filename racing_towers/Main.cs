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
using UnityEngine;
using BloonsTD6_Mod_Helper.Extensions;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Main.Scenes;
using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Models.Towers.Behaviors.Abilities;
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper;
using System.Text.RegularExpressions;
using Assets.Scripts.Unity.UI_New.InGame.Stats;
using System.Linq;
using System.Collections.Generic;
using Assets.Scripts.Models.Map;
using BTD_Mod_Helper.Api.ModOptions;

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
        private readonly static ModSettingInt margin = new ModSettingInt(4)
        {
            displayName = "how close the tower has to be to go to the next checkpoint",
        };

        static new UnhollowerBaseLib.Il2CppReferenceArray<PointInfo> path;

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
                            tower.tower.PositionTower(new Assets.Scripts.Simulation.SMath.Vector2(path[0].point.x, path[0].point.y));
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
                            tower.tower.PositionTower(new Assets.Scripts.Simulation.SMath.Vector2(towerpos.x, towerpos.y));
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