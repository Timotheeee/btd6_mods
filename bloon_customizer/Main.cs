using MelonLoader;
using Harmony;

using Il2CppAssets.Scripts.Unity.UI_New.InGame.Races;
using Il2CppAssets.Scripts.Simulation.Towers.Weapons;

using Il2CppAssets.Scripts.Simulation;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using Il2CppAssets.Scripts.Unity.UI_New.Main;

using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppAssets.Scripts.Models.Bloons;

using Il2CppAssets.Scripts.Unity;



using Il2CppAssets.Scripts.Simulation.Bloons;


using Il2CppAssets.Scripts.Utils;


using Il2CppSystem.Collections;

using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Simulation.Objects;
using Il2CppAssets.Scripts.Models;
using TMPro;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Il2CppAssets.Scripts.Simulation.Bloons.Behaviors;
using UnityEngine;
using Il2CppAssets.Scripts.Unity.Display;
using System.Linq;
using System.IO;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity.Player;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using Il2CppAssets.Main.Scenes;

[assembly: MelonInfo(typeof(bloon_customizer.Main), bloon_customizer.ModHelperData.Name, bloon_customizer.ModHelperData.Version, bloon_customizer.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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




            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F2))
            {


                Console.WriteLine("loading custom bloons");

                if (Directory.Exists(appdataCustom))
                    Directory.Delete(appdataCustom, true);
                Directory.CreateDirectory(appdataCustom);

                //Console.WriteLine("created directory");

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