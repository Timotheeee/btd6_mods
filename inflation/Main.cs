using MelonLoader;
//using Harmony;
using HarmonyLib;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.Races;
using Il2CppAssets.Scripts.Simulation.Towers.Weapons;
using Il2CppAssets.Scripts.Simulation;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppAssets.Scripts.Unity.UI_New.Main;
using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppAssets.Scripts.Models.Towers;

using Il2CppAssets.Scripts.Unity;

using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Simulation.Input;

//using Il2CppSystem.Collections.Generic;


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
using Il2CppAssets.Main.Scenes;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Input;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Unity.Player;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using System.Linq;
using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Simulation.Track;
using Il2CppAssets.Scripts.Unity.Difficulty.Mods;
using Il2CppAssets.Scripts.Unity.Towers;
using System.Collections.Generic;
using BTD_Mod_Helper.Api.ModOptions;
using Il2CppAssets.Scripts.Unity.UI_New.GameOver;
//using Harmony;

[assembly: MelonInfo(typeof(inflation.Main), inflation.ModHelperData.Name, inflation.ModHelperData.Version, inflation.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace inflation
{
    public class Main : BloonsMod
    {
         
        public static Dictionary<string,float> dict;

        static void changeFireRate(TowerModel tower, float multi)
        {
            //if (tower.name.ToLower().Contains("dartmonkey"))
            //{
            //    Console.WriteLine(tower.name + " ");
            //}
            foreach (var attack in tower.GetAttackModels())
            {
                foreach (var wep in attack.weapons)
                {
                    //if (tower.name.ToLower().Contains("dartmonkey"))
                    //{
                    //    Console.WriteLine(tower.name + " old rate: " + wep.Rate + " new rate: " + (wep.Rate * multi));
                    //}
                    wep.Rate *= multi;
                }
            }
            foreach (var ability in tower.GetAbilities())
            {
                foreach (var activateAttackModel in ability.GetBehaviors<ActivateAttackModel>())
                {
                    foreach (var attack in activateAttackModel.attacks)
                    {
                        foreach (var wep in attack.weapons)
                        {
                            wep.Rate *= multi;
                        }
                    }
                }
            }
        }


        static void changeCooldowns(TowerModel tower, float multi)
        {
            try
            {
                foreach (var bev in tower.behaviors.GetItemsOfType<Model, AbilityModel>())
                {
                    bev.Cooldown *= multi;
                }
            }
            catch
            {
            }
        }



        public static float lastround = 0;
        public static float currentcashmulti = 1;

        public readonly static ModSettingDouble ratemulti = new ModSettingDouble(1.02f)
        {
            displayName = "fire rate and cooldown multiplier",
            stepSize = 0.001f,
        };

        //public readonly static ModSettingDouble cooldownmulti = new ModSettingDouble(1.02f)
        //{
        //    displayName = "cooldown multiplier",
        //    stepSize = 0.001f,
        //};

        public readonly static ModSettingDouble pricemulti = new ModSettingDouble(1.03f)
        {
            displayName = "price multiplier",
            stepSize = 0.001f,
        };

        public readonly static ModSettingDouble cashmulti = new ModSettingDouble(1.028f)
        {
            displayName = "income multiplier",
            stepSize = 0.001f,
        };

        //public static float ratemulti = 1.5f;
        //public static float pricemulti = 1.5f;
        //public static float cashmulti = 1.5f;

        [HarmonyPatch(typeof(Simulation), "RoundEnd")]
        class RoundEndHook
        {
            [HarmonyPrefix]
            public static void Prefix(int round, int highestCompletedRound)
            {
                try
                {
                    lastround = round;
                    currentcashmulti *= cashmulti;
                    //ratemulti *= 1.5f;
                    //pricemulti *= 1.5f;
                    //MelonLogger.Msg("inflation mod: cashmulti: " + cashmulti + " ratemulti: " + ratemulti + " pricemulti: " + pricemulti);
                    MelonLogger.Msg("inflation mod: cashmulti: " + currentcashmulti + " round: " + round);




                    foreach (TowerModel towerModel in InGame.Bridge.Model.towers)
                    {
                        towerModel.cost *= pricemulti;
                    }
                    foreach (UpgradeModel upgradeModel in InGame.Bridge.Model.upgrades)
                    {
                        upgradeModel.cost = (int)(upgradeModel.cost * pricemulti);
                    }

                    updateCurrent();

                } catch (Exception e)
                {
                    MelonLogger.Msg("something went wrong with the inflation mod: " + e.Message);
                    MelonLogger.Msg(e.StackTrace);
                }
                


            }
        }

        public static void updateCurrent()
        {
            var towers = InGame.instance.GetTowers();
            for (int i = 0; i < towers.Count; i++)
            {
                
                var name = "";
                var key = "";
                if (towers[i] != null && towers[i].towerModel != null)
                {
                    name = towers[i].towerModel.name;
                    key = towers[i].uniqueId;
                    //MelonLogger.Msg("processing: " + i + ", " + name + ", " + towers[i].uniqueId);// + ", " + towers[i].GetTowerToSim().Abilities[0].ability.cooldownTimeRemaining + ", " + towers[i].GetTowerToSim().Abilities[0].ability.CooldownRemaining
                }
                else
                {
                    //MelonLogger.Msg("processing: " + i + ", tower is null");
                    continue;
                }
                try
                {
                    var temp = towers[i].GetTowerToSim().Abilities;
                } catch
                {
                    continue;
                }

                List<(float, float)> cooldowns = new List<(float, float)>();
                var abilities = towers[i].GetTowerToSim().Abilities;
                foreach (var cooldown in abilities)
                {
                    cooldowns.Add((cooldown.ability.cooldownTimeRemaining, cooldown.ability.CooldownRemaining)); 
                }

                float oldrate = 1;
                if (dict.ContainsKey(key))
                {
                    oldrate = dict[key];
                }
                else
                {
                    dict[key] = oldrate;
                }
                float newrate = oldrate * ratemulti;
                var slower = InGame.Bridge.Model.GetTowerFromId(name).Duplicate();
                changeFireRate(slower, newrate);
                changeCooldowns(slower, newrate);
                towers[i].SetTowerModel(slower);
                dict[key] = newrate;

                for(int j = 0; j < cooldowns.Count; j++)
                {
                    var cache = cooldowns[j];
                    abilities[j].ability.cooldownTimeRemaining = cache.Item1;
                    abilities[j].ability.CooldownRemaining = cache.Item2;
                }

                //MelonLogger.Msg("processing: " + i + ", " + name + ", " + towers[i].uniqueId + ", " + towers[i].GetTowerToSim().Abilities[0].ability.cooldownTimeRemaining + ", " + towers[i].GetTowerToSim().Abilities[0].ability.CooldownRemaining);
            }
        }

        [HarmonyPatch(typeof(Simulation), "AddCash")]
        public class AddCash_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(ref double c, ref Simulation.CashSource source)
            {
                //Console.WriteLine(source);
                if (source != Simulation.CashSource.CoopTransferedCash && source != Simulation.CashSource.TowerSold)
                {
                    c *= currentcashmulti;
                }
                return true;
            }
        }

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Game_Patch
        {

            [HarmonyPostfix]
            public static void Postfix()
            {
                reset();
            }
        }


        [HarmonyPatch(typeof(DefeatScreen), "RestartClick")]
        public class adfsafa
        {

            [HarmonyPostfix]
            public static void Postfix()
            {
                reset();
            }
        }

        [HarmonyPatch(typeof(DefeatScreen), "RetryLastRoundClicked")]
        public class adfsdasafa
        {

            [HarmonyPostfix]
            public static void Postfix()
            {
                MelonLogger.Msg("RetryLastRoundClicked");
                updateCurrent();
            }
        }

        public static void reset()
        {
            dict = new Dictionary<string, float>();
            currentcashmulti = 1f;
            MelonLogger.Msg("reset inflation mod");
        }


        bool wasInGame = false;
        public override void OnUpdate()
        {
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                wasInGame = true;
            }
            else
            {
                if (wasInGame)
                {
                    reset();
                }


                wasInGame = false;
            }
        }



    }



}