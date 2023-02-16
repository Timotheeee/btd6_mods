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




using Il2CppAssets.Scripts.Utils;

using Il2CppSystem.Collections;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;

using UnityEngine;
using BTD_Mod_Helper.Api.Helpers;
using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppAssets.Scripts.Models.Rounds;
using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Data.Rounds;

[assembly: MelonInfo(typeof(all_bosses_at_once.Main), all_bosses_at_once.ModHelperData.Name, all_bosses_at_once.ModHelperData.Version, all_bosses_at_once.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace all_bosses_at_once
{
    public class Main : MelonMod
    {

        public static int speed = 3;
        public static int slowAmount = 1;
        public static int customspeed = 100;
        public static int maxSimulationStepsPerUpdate = 3;
        public static bool slow = false;
        static string[] bosses = { "Bloonarius", "Lych", "Vortex", "Dreadbloon" };

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            System.Console.WriteLine("all_bosses_at_once loaded");
        }

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Game_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                try
                {

                    //RoundSetModel rs = Game.instance.model.roundSets[0];
                    //Console.WriteLine(rs.rounds.Count);
                    //return;

                    //foreach (var bl in Game.instance.model.bloons)
                    //{
                    //    Console.WriteLine(bl.id);
                    //}
                    
                    for (int i = 0; i < Game.instance.model.roundSets.Length; i++)
                    {
                        RoundSetModel roundSet = Game.instance.model.roundSets[i];
                        for (int j = 0; j < 4; j++)
                        {
                            //Console.WriteLine("j = " + j);
                            int round = (j * 20) + 39;
                            roundSet.rounds[round].groups = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<BloonGroupModel>(4);
                            for (int k = 0; k < 4; k++)
                            {
                                string bloon = bosses[k] + "Elite" + (j + 1);
                                roundSet.rounds[round].groups[k] = new BloonGroupModel("", bloon, 0, 0.1f, 1);
                                Console.WriteLine("round " + round + " group " + k + " updated to " + bloon);
                            }


                            //Console.WriteLine("j = " + j);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }

            }
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;

            if (inAGame)
            {
                if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F7))
                {
                    Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(4);
                    for (int k = 0; k < 4; k++)
                    {
                        string bloon = bosses[k] + "Elite" + "5";
                        bme[k] = (new BloonEmissionModel("", 1, bloon));
                    }

                    InGame.instance.bridge.SpawnBloons(bme, 120, 0);
                }
            }
        }




    }

}