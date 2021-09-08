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
using System.Collections.Generic;

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


                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (Directory.GetFiles(path).Length == 0)
                {
                    int i = 0;
                    foreach (var round in Game.instance.model.roundSetsByName["DefaultRoundSet"].rounds)
                    {
                        List<string> lines = new List<string>();
                        foreach (var group in round.groups)
                        {
                            lines.Add("bloon:" + group.bloon);
                            lines.Add("start:" + group.start);
                            lines.Add("end:" + group.end);
                            lines.Add("count:" + group.count);
                        }

                        File.WriteAllLines(path + (i + 1) + ".txt", lines.ToArray());
                        
                        i++;
                    }
                    Console.WriteLine("saved the rounds");
                } else
                {
                    Console.WriteLine("round files are present");
                }

                Console.WriteLine("a reminder of what the bloon names are:");
                foreach (var bl in Game.instance.model.bloons)
                {
                    Console.WriteLine(bl.id);
                }





            }

        }



        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;


            if (!inAGame)
            {
                if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F7))
                {

                    foreach (var file in Directory.EnumerateFiles(path))
                    {
                        int roundIndex = int.Parse(Path.GetFileNameWithoutExtension(file))-1;
                        Console.WriteLine("loading round " + roundIndex);
                        string[] lines = File.ReadAllLines(file);
                        List<BloonGroupModel> groups = new List<BloonGroupModel>();
                        for (int i = 0; i < lines.Length; i+=4)
                        {
                            groups.Add(new BloonGroupModel("", 
                                lines[i].Split(':')[1],
                                float.Parse(lines[i+1].Split(':')[1]),
                                float.Parse(lines[i+2].Split(':')[1]),
                                int.Parse(lines[i+3].Split(':')[1])
                                ));
                        }

                        Game.instance.model.roundSetsByName["DefaultRoundSet"].rounds[roundIndex].groups = groups.ToArray();

                    }
                }

            }

        }




    }

}