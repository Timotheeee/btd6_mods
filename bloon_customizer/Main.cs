using MelonLoader;
using Harmony;

using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;

using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;

using Assets.Scripts.Unity.UI_New.Main;

using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Bloons;

using Assets.Scripts.Unity;



using Assets.Scripts.Simulation.Bloons;


using Assets.Scripts.Utils;


using Il2CppSystem.Collections;

using Assets.Scripts.Unity.UI_New.Popups;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Bloons.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using TMPro;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Assets.Scripts.Simulation.Bloons.Behaviors;
using UnityEngine;
using Assets.Scripts.Unity.Display;
using System.Linq;
using System.IO;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Unity.Player;
using Assets.Scripts.Unity.UI_New.Main.MapSelect;
using Assets.Main.Scenes;

namespace bloon_customizer
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("bloon_customizer loaded");

            Directory.CreateDirectory(origFolder);
            Directory.CreateDirectory(customFolder);

            
        }

        static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + "/Ninja Kiwi/BloonsTD6/bloon_customizer/";
        static string appdataCustom = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + "/Ninja Kiwi/BloonsTD6/bloon_customizer/custom/";
        static string origFolder = "Mods/bloon_customizer/original/";
        static string customFolder = "Mods/bloon_customizer/custom/";


        public override void OnUpdate()
        {
            base.OnUpdate();




            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F1))
            {


                Console.WriteLine("loading custom bloons");


                Directory.Delete(appdataCustom, true);
                Directory.CreateDirectory(appdataCustom);

                Console.WriteLine("created directory");

                foreach (var file in Directory.EnumerateFiles(customFolder))
                {


                    try
                    {
                        File.Copy(file, appdataCustom + Path.GetFileName(file));
                        BloonModel t = FileIOUtil.LoadObject<BloonModel>("bloon_customizer/custom/" + Path.GetFileName(file));
                        //Console.WriteLine("loaded t");
                        //Console.WriteLine(t.name);
                        for (int i = 0; i < Game.instance.model.bloons.Count; i++)
                        {
                            if (Game.instance.model.bloons[i].name == t.name)
                            {
                                Game.instance.model.bloons[i] = t;
                            }
                        }

                        Console.WriteLine("loading " + Path.GetFileNameWithoutExtension(file) + " worked");
                    }
                    catch (Exception e) { Console.WriteLine("loading " + Path.GetFileNameWithoutExtension(file) + " failed: " + e.Message); }
                }

            }


        }

        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {

                if (Directory.GetFiles(origFolder).Length==0)
                {


                    Console.WriteLine("saving bloons");
                    foreach (BloonModel bloonModel in Game.instance.model.bloons)
                    {
                        try
                        {
                            FileIOUtil.SaveObject("bloon_customizer\\" + bloonModel.name + ".json", bloonModel);
                            //Console.WriteLine("saving " + bloonModel.name + " worked");
                        }
                        catch { 
                            //Console.WriteLine("saving " + bloonModel.name + " failed");
                        }
                        //break;
                    }

                    foreach (var file in Directory.EnumerateFiles(appdata))
                    {
                        try
                        {
                            var o = FileIOUtil.LoadObject<BloonModel>("bloon_customizer/" + Path.GetFileName(file));
                            if (o == null)
                            {
                                //Console.WriteLine(Path.GetFileNameWithoutExtension(file) + " is null");
                                continue;
                            }
                            //Console.WriteLine("loading " + Path.GetFileNameWithoutExtension(file) + " worked");
                            //Console.WriteLine(file);
                            //Console.WriteLine(origFolder + Path.GetFileName(file));
                            File.Copy(file, origFolder + Path.GetFileName(file));
                        }
                        catch { 
                            //Console.WriteLine("loading " + Path.GetFileNameWithoutExtension(file) + " failed"); 
                        }
                    }
                    Console.WriteLine("done");

                }


            }
        }


    }

}