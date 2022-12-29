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
using UnityEngine;
using Il2CppAssets.Scripts.Unity.Display;
using System.Linq;
using System.IO;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity.Player;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;

[assembly: MelonInfo(typeof(model_dumper.Main), model_dumper.ModHelperData.Name, model_dumper.ModHelperData.Version, model_dumper.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace model_dumper
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("model_dumper loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();




            if (Input.GetKeyDown(KeyCode.F1))
            {
                Console.WriteLine("getting player");
                var playerInstance = Game.instance.GetBtd6Player();
                Console.WriteLine("saving player data");
                FileIOUtil.SaveObject("Model\\playerdata.json", player2.Data);

                Console.WriteLine("saving towers");
                foreach (TowerModel towerModel in Game.instance.model.towers)
                {
                    if (towerModel.name.Contains("Alchemist"))
                    {
                        foreach (var at in towerModel.GetBehaviors<AttackModel>())
                        {
                            try
                            {
                                //at.weapons[0].projectile.GetBehavior<AddAcidicMixtureToProjectileModel>().mutator = null;
                                at.weapons[0].projectile.RemoveBehavior<AddAcidicMixtureToProjectileModel>();
                                //Console.WriteLine("removed");
                            }
                            catch
                            {

                            }

                        }
                        try
                        {
                            towerModel.GetBehavior<LoadAlchemistBrewInfoModel>().addAcidicMixtureToProjectileModel = null;
                        }
                        catch
                        {

                        }
                        //FileIOUtil.SaveObject("Model\\Towers\\" + towerModel.baseId + "\\" + towerModel.name + ".json", towerModel);
                    }
                    try
                    {
                        FileIOUtil.SaveObject("Model\\Towers\\" + towerModel.baseId + "\\" + towerModel.name + ".json", towerModel);
                    }
                    catch { Console.WriteLine("failed to save " + towerModel.name); }
                }
                var towers = Game.instance.model.towers;

                for (int i = 0; i < towers.Count; i++)
                {
                    towers[i] = null;

                }
                Console.WriteLine("saving entire model");
                FileIOUtil.SaveObject("Model\\entiremodel.json", Game.instance.model);
            }


        }


        static Btd6Player player2;


        [HarmonyPatch(typeof(MapButton), "ShowMedal")]
        public class ShowMedal_Patch2
        {
            [HarmonyPrefix]
            public static bool Prefix(MapButton __instance, Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode)
            {
                player2 = player;


                return true;
            }
        }

    }

}