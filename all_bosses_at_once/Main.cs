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
using Assets.Scripts.Models.Rounds;
//using UnhollowerBaseLib;
using System;
using Assets.Main.Scenes;

namespace all_bosses_at_once
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("all_bosses_at_once loaded");
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
                    string[] bosses = { "Bloonarius", "Lych", "Vortex", "Dreadbloon" };
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
            }
        }




    }

}