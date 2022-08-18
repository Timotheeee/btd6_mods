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
using UnityEngine;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using System.Net;
using System.IO;

namespace troubleshooter
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("troubleshooter loaded. press F10 to use");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;


            if (Input.GetKeyDown(KeyCode.F10))
            {
                Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                {
                };

                Console.WriteLine("request");
                var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/Timotheeee/btd6_mods/master/troubleshooter/issues.txt");

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    var strContent = reader.ReadToEnd();
                    //Console.WriteLine(strContent);
                    string log = File.ReadAllText("MelonLoader/Latest2.log");
                    string result = "";

                    foreach (var line in strContent.Split('\n'))
                    {
                        string problems1 = line.Split('€')[0];
                        string[] problems = problems1.Split('£');
                        string solution = line.Split('€')[1];

                        foreach (var problem in problems)
                        {
                            if (log.Contains(problem))
                            {
                                result += solution + "\n";
                                break;
                            }
                        }

                    }


                    PopupScreen.instance.ShowSetNamePopup("Problems found:", strContent, mod, "");

                }

                
            }

        }




    }

}