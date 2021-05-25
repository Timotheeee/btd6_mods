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

namespace teleporting_towers
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("teleporting_towers loaded");
        }



        System.Random r = new System.Random();




        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (!Input.GetKey(KeyCode.F7))
                    foreach (var tower in InGame.Bridge.GetAllTowers())
                    {
                        float x = ((float)(r.NextDouble() - 0.5) * 2) * 147f;
                        float y = ((float)(r.NextDouble() - 0.5) * 2) * 114;

                        tower.tower.PositionTower(new Assets.Scripts.Simulation.SMath.Vector2(x, y));
                    }
            }
        }








    }

}