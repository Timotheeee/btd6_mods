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
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Simulation.Objects;
using Il2CppAssets.Scripts.Models;

using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using UnityEngine;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using System.Net;
using System.IO;

[assembly: MelonInfo(typeof(troubleshooter.Main), troubleshooter.ModHelperData.Name, troubleshooter.ModHelperData.Version, troubleshooter.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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

                Console.WriteLine("obtaining latest list of known issues");
                var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/Timotheeee/btd6_mods/master/troubleshooter/issues.txt");

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    var strContent = reader.ReadToEnd();
                    strContent = strContent.Replace("\"", "");
                    //Console.WriteLine(strContent);
                    File.Copy("MelonLoader/Latest.log", "MelonLoader/Latest_temp.log",true);
                    string log = File.ReadAllText("MelonLoader/Latest_temp.log");
                    //Console.WriteLine(log);
                    string result = "";

                    foreach (var line in strContent.Split('\n'))
                    {
                        string problems1 = line.Split('€')[0];
                        string[] problems = problems1.Split('£');
                        string solution = line.Split('€')[1];

                        foreach (var problem in problems)
                        {
                            //Console.WriteLine("checking problem: " + problem);
                            if (log.Contains(problem))
                            {
                                result += solution + "\n";
                                break;
                            }
                        }

                    }


                    PopupScreen.instance.ShowSetNamePopup("Problems found:", result, mod, "");

                }

                
            }

        }




    }

}