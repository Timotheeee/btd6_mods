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
using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using Il2CppAssets.Main.Scenes;
using UnityEngine;
using System.IO;
using System.Collections.Generic;

[assembly: MelonInfo(typeof(custom_rounds.Main), custom_rounds.ModHelperData.Name, custom_rounds.ModHelperData.Version, custom_rounds.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

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

        //static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + "/Ninja Kiwi/BloonsTD6/customrounds/";
        static string path = "Mods/customrounds/";


        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class GameModel_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {



                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (Directory.GetFiles(path).Length == 0)
                {
                    int i = 0;
                    foreach (var round in Game.instance.model.roundSets[1].rounds)
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
                        Console.WriteLine("loading round " + (roundIndex+1));
                        string[] lines = File.ReadAllLines(file);

                        try
                        {
                            List<BloonGroupModel> groups = new List<BloonGroupModel>();
                            for (int i = 0; i < lines.Length; i += 4)
                            {
                                groups.Add(new BloonGroupModel("",
                                    lines[i].Split(':')[1],
                                    float.Parse(lines[i + 1].Split(':')[1]),
                                    float.Parse(lines[i + 2].Split(':')[1]),
                                    int.Parse(lines[i + 3].Split(':')[1])
                                    ));
                            }
                            Game.instance.model.roundSets[1].rounds[roundIndex].groups = groups.ToArray();
                        }
                        catch
                        {
                            Console.WriteLine("loading round " + (roundIndex + 1) + " failed.");
                        }


                    }
                }

            }

        }




    }

}