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
            //Directory.CreateDirectory("Mods/customrounds/");
        }

        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + "/Ninja Kiwi/BloonsTD6/customrounds/";


        [HarmonyPatch(typeof(TitleScreen), "UpdateVersion")] // this method is called soon after the game is done initializing the models, hence why it's used to modify said models
        public class GameModel_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                Console.WriteLine(path);



                if(!Directory.Exists(path) || Directory.GetFiles(path).Length == 0)
                {
                    int i = 0;
                    foreach (var round in Game.instance.model.roundSetsByName["DefaultRoundSet"].rounds)
                    {
                        FileIOUtil.SaveObject("customrounds/" + (i + 1) + ".json", round);
                        Console.WriteLine("saved round " + (i + 1));
                        i++;
                    }
                } else
                {
                    Console.WriteLine("round files are present");
                }





            }

        }



        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;


            if (!inAGame)
            {
                if (Input.GetKeyDown(KeyCode.F7))
                {

                    foreach (var file in Directory.EnumerateFiles(path))
                    {
                        int i = int.Parse(Path.GetFileNameWithoutExtension(file))-1;
                        Console.WriteLine("loading round " + i);

                        Game.instance.model.roundSetsByName["DefaultRoundSet"].rounds[i] = FileIOUtil.LoadObject<RoundModel>(file);
                        Console.WriteLine(Game.instance.model.roundSetsByName["DefaultRoundSet"].rounds[i]);
                        Console.WriteLine(Game.instance.model.roundSetsByName["DefaultRoundSet"].rounds[i].groups.Count);
                        Console.WriteLine(Game.instance.model.roundSetsByName["DefaultRoundSet"].rounds[i].groups[0].bloon);
                    }
                }

            }

        }




    }

}