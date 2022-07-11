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
using UnityEngine;
using System.Linq;

namespace inverted_scale
{
    public class Main : MelonMod
    {


        public static string[] filter = new string[]
        {
            "terrain",
            "camera",
        };

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            System.Console.WriteLine("inverted_scale loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
            {
                if (filter.Any(ob.name.ToLower().Contains))
                    continue;
                if (ob.transform.localScale.x > 0)
                {
                    Vector3 orig = ob.transform.localScale;
                    ob.transform.localScale = new Vector3(-orig.x, -orig.y, -orig.z);
                }

            }
        }





    }

}