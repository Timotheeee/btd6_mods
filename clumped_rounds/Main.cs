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
using UnhollowerBaseLib;
using System;
using Assets.Main.Scenes;

namespace clumped_rounds
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("clumped_rounds loaded");
        }


        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Game_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                for (int i = 0; i < Game.instance.model.roundSets.Length; i++)
                {
                    RoundSetModel roundSet = Game.instance.model.roundSets[i];
                    for (int j = 0; j < roundSet.rounds.Length; j++)
                    {
                        RoundModel round = roundSet.rounds[j];
                        foreach (var group in round.groups)
                        {
                            group.start = 0;
                            group.end = 0;
                        }

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