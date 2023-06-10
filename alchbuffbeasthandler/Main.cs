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
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers;

[assembly: MelonInfo(typeof(alchbuffbeasthandler.Main), alchbuffbeasthandler.ModHelperData.Name, alchbuffbeasthandler.ModHelperData.Version, alchbuffbeasthandler.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace alchbuffbeasthandler
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("alchbuffbeasthandler mod loaded");
        }

        //static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + " /Ninja Kiwi/BloonsTD6/";

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                //var models = Game.instance.model.towers;

                //for (int i = 0; i < models.Count; i++)
                //{
                //    var tower = models[i];



                //    if (Regex.IsMatch(tower.name, "Alchemist-3..") || Regex.IsMatch(tower.name, "Alchemist-4..") || Regex.IsMatch(tower.name, "Alchemist-5.."))
                //    {
                //        Console.WriteLine("processing " + tower.name);
                //        foreach (var attack in tower.GetAttackModels())
                //        {
                //            var btm = attack.GetBehavior<BrewTargettingModel>();
                //            if(btm != null)
                //            {
                //                var ig = btm.towerIgnoreList;
                //                for (int j = 0; j < ig.Length; j++)
                //                {
                //                    if (ig[j] == "BeastHandler")
                //                    {
                //                        ig[j] = "";
                //                        Console.WriteLine("1");
                //                    }
                //                }
                //            }


                //            var target = attack.targetProvider;
                //            if (target != null)
                //            {
                //                try
                //                {
                //                    var btm2 = target.Cast<BrewTargettingModel>();
                //                    var ig = btm2.towerIgnoreList;
                //                    for (int j = 0; j < ig.Length; j++)
                //                    {
                //                        if (ig[j] == "BeastHandler")
                //                        {
                //                            ig[j] = "";
                //                            Console.WriteLine(2);
                //                        }
                //                    }
                //                    //var imbo = btm.ignoreMutationsByOrder;
                //                    //for (int j = 0; j < imbo.Length; j++)
                //                    //{
                //                    //    if (imbo[j] == "BerserkerBrewBlockerMutation")
                //                    //    {
                //                    //        imbo[j] = "";
                //                    //        Console.WriteLine("1.5");
                //                    //    }
                //                    //}
                //                }
                //                catch
                //                {

                //                }

                //                //try
                //                //{
                //                //    var tfm = target.Cast<TargetFriendlyModel>();
                //                //    tfm.ignoreList = tfm.ignoreList.Replace("BeastHandler,", "");
                //                //    Console.WriteLine(2);
                //                //}
                //                //catch
                //                //{

                //                //}
                //            }



                //        }

                //    }

                //}
            }

        }




        [HarmonyPatch(typeof(BrewTargetting), "FilterTower")]
        public class fasfsaf
        {
            [HarmonyPrefix]
            public static bool Prefix(Tower tower, ref bool __result)
            {
                //Console.WriteLine("FilterTower");
                if (tower.model.name.ToLower().Contains("beast"))
                {
                    __result = true;
                    return false;
                }
                return true;
            }
        }





        public override void OnUpdate()
        {
            base.OnUpdate();

            //bool inAGame = InGame.instance != null && InGame.instance.bridge != null;


            //if (Input.GetKeyDown(KeyCode.F1))
            //{
            //    Console.WriteLine("deleting amd");
            //    foreach (TowerModel towerModel in Game.instance.model.towers)
            //    {
            //        if (towerModel.name.Contains("Alchemist"))
            //        {
            //            foreach (var at in towerModel.GetBehaviors<AttackModel>())
            //            {
            //                try
            //                {
            //                    //at.weapons[0].projectile.GetBehavior<AddAcidicMixtureToProjectileModel>().mutator = null;
            //                    at.weapons[0].projectile.RemoveBehavior<AddAcidicMixtureToProjectileModel>();
            //                    Console.WriteLine("removed");
            //                }
            //                catch
            //                {

            //                }

            //            }
            //            try
            //            {
            //                towerModel.GetBehavior<LoadAlchemistBrewInfoModel>().addAcidicMixtureToProjectileModel = null;
            //            }
            //            catch
            //            {

            //            }
            //        }
            //        try
            //        {

            //        }
            //        catch { Console.WriteLine("failed to fix " + towerModel.name); }
            //    }

            //}


        }
    }










}