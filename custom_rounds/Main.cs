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
using UnityEngine;
using System.IO;

namespace custom_rounds
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("custom_rounds loaded");
            Directory.CreateDirectory("Mods/customrounds/");
        }


        [HarmonyPatch(typeof(TitleScreen), "UpdateVersion")] // this method is called soon after the game is done initializing the models, hence why it's used to modify said models
        public class GameModel_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                Console.WriteLine(Game.instance.model.roundSetsByName["DefaultRoundSet"].rounds.Count);

                string json = JsonUtility.ToJson(Game.instance.model.roundSetsByName["DefaultRoundSet"]);
                File.WriteAllText("Mods/customrounds/orig.json", json);


                
            }

        }

        //bool updated = false;

        //public override void OnUpdate()
        //{
        //    base.OnUpdate();
        //    bool inAGame = InGame.instance != null && InGame.instance.bridge != null;


        //    if (inAGame)
        //    {
        //        if (!updated)
        //        {
        //            var rounds = InGame.instance.bridge.Model.roundSetsByName;
        //            var rsm = rounds["DefaultRoundSet"];
        //            for (int i = 0; i < rsm.rounds.Count; i++)
        //            {
        //                Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(rsm.rounds[i].emissions.Count);
        //                for (int j = 0; j < rsm.rounds[i].emissions.Count; j++)
        //                {
        //                    bme[j] = new BloonEmissionModel(rsm.rounds[i].emissions[j].bloon, 0, rsm.rounds[i].emissions[j].bloon);
        //                }
        //                rsm.rounds[i].emissions_ = bme;
        //            }

        //            rsm = rounds["AlternateRoundSet"];
        //            for (int i = 0; i < rsm.rounds.Count; i++)
        //            {
        //                Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(rsm.rounds[i].emissions.Count);
        //                for (int j = 0; j < rsm.rounds[i].emissions.Count; j++)
        //                {
        //                    bme[j] = new BloonEmissionModel(rsm.rounds[i].emissions[j].bloon, 0, rsm.rounds[i].emissions[j].bloon);
        //                }
        //                rsm.rounds[i].emissions_ = bme;
        //            }
        //            updated = true;
        //        }


        //    }
        //    else
        //    {
        //        updated = false;
        //    }
        //}




    }

}