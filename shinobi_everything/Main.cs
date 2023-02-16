using MelonLoader;
using Harmony;

using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Il2CppAssets.Scripts.Unity.Scenes;
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
using Il2CppAssets.Scripts.Simulation.Towers.TowerFilters;
using Il2CppAssets.Scripts.Models.Towers.TowerFilters;

[assembly: MelonInfo(typeof(shinobi_everything.Main), shinobi_everything.ModHelperData.Name, shinobi_everything.ModHelperData.Version, shinobi_everything.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace shinobi_everything
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("shinobi_everything mod loaded");
        }


        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                var models = Game.instance.model.towers;


                for (int i = 0; i < models.Count; i++)
                {
                    var tower = models[i];

                    if (Regex.IsMatch(tower.name, "NinjaMonkey-.3.") || Regex.IsMatch(tower.name, "NinjaMonkey-.4.") || Regex.IsMatch(tower.name, "NinjaMonkey-.5."))
                    {
                        tower.GetBehavior<SupportShinobiTacticsModel>().filters = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<Il2CppAssets.Scripts.Models.Towers.TowerFilters.TowerFilterModel>(0);
                        //var a = tower.GetBehavior<SupportShinobiTacticsModel>().filters[0].Cast<FilterInBaseTowerIdModel>();
                        //a.baseIds[0] = "DartMonkey";



                    }


                }

            }
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