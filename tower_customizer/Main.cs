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
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using TMPro;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Assets.Scripts.Simulation.Towers.Behaviors;
using UnityEngine;
using Assets.Scripts.Unity.Display;
using System.Linq;
using System.IO;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Unity.Player;
using Assets.Scripts.Unity.UI_New.Main.MapSelect;
using Assets.Main.Scenes;

namespace tower_customizer
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("tower_customizer loaded");

            Directory.CreateDirectory(origFolder);
            Directory.CreateDirectory(customFolder);

            
        }

        static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + "/Ninja Kiwi/BloonsTD6/tower_customizer/";
        static string appdataCustom = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).Replace("Roaming", "LocalLow") + "/Ninja Kiwi/BloonsTD6/tower_customizer/custom/";
        static string origFolder = "Mods/tower_customizer/original/";
        static string customFolder = "Mods/tower_customizer/custom/";


        public override void OnUpdate()
        {
            base.OnUpdate();




            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F1))
            {


                Console.WriteLine("loading custom towers");


                if(Directory.Exists(appdataCustom))
                    Directory.Delete(appdataCustom, true);
                Directory.CreateDirectory(appdataCustom);




                foreach (var file in Directory.EnumerateFiles(customFolder))
                {


                    try
                    {
                        File.Copy(file, appdataCustom + Path.GetFileName(file));
                        TowerModel t = FileIOUtil.LoadObject<TowerModel>("tower_customizer/custom/" + Path.GetFileName(file));
                        //Console.WriteLine("loaded t");
                        //Console.WriteLine(t.name);
                        for (int i = 0; i < Game.instance.model.towers.Count; i++)
                        {
                            if (Game.instance.model.towers[i].name == t.name)
                            {
                                Game.instance.model.towers[i] = t;
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


                    Console.WriteLine("saving towers");
                    foreach (TowerModel towerModel in Game.instance.model.towers)
                    {
                        try
                        {
                            FileIOUtil.SaveObject("tower_customizer\\" + towerModel.name + ".json", towerModel);
                            Console.WriteLine("saving " + towerModel.name + " worked");
                        }
                        catch (Exception e) { 
                            Console.WriteLine("saving " + towerModel.name + " failed. error: " + e.Message);
                        }
                        //break;
                    }

                    foreach (var file in Directory.EnumerateFiles(appdata))
                    {
                        try
                        {
                            var o = FileIOUtil.LoadObject<TowerModel>("tower_customizer/" + Path.GetFileName(file));
                            if (o == null)
                            {
                                //Console.WriteLine(Path.GetFileNameWithoutExtension(file) + " is null");
                                continue;
                            }
                            Console.WriteLine("loading " + Path.GetFileNameWithoutExtension(file) + " worked");
                            //Console.WriteLine(file);
                            //Console.WriteLine(origFolder + Path.GetFileName(file));
                            File.Copy(file, origFolder + Path.GetFileName(file));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("loading " + Path.GetFileNameWithoutExtension(file) + " failed. error: " + e.Message);
                        }
                    }
                    Console.WriteLine("done");

                }


            }
        }


    }

}