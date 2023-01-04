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




using Il2CppAssets.Scripts.Utils;

using Il2CppSystem.Collections;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;

using UnityEngine;


[assembly: MelonInfo(typeof(speedhackmelon.Main), speedhackmelon.ModHelperData.Name, speedhackmelon.ModHelperData.Version, speedhackmelon.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace speedhackmelon
{
    public class Main : MelonMod
    {

        public static int speed = 3;
        public static int slowAmount = 1;
        public static int customspeed = 100;
        public static int maxSimulationStepsPerUpdate = 3;
        public static bool slow = false;

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            System.Console.WriteLine("speed mod loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            //System.Console.WriteLine(TimeManager.maxSimulationStepsPerUpdate);
            if (TimeManager.FastForwardActive)
            {
                TimeManager.timeScaleWithoutNetwork = speed;
                TimeManager.networkScale = speed;
            }
            else
            {
                TimeManager.timeScaleWithoutNetwork = 1;
                TimeManager.networkScale = 1;
            }


            int max;
            if (speed == 3)
            {
                max = 3;
            }
            else
            {
                max = speed * 2;
            }
            TimeManager.maxSimulationStepsPerUpdate = slow ? slowAmount : max;



            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                speed = 3;
                maxSimulationStepsPerUpdate = 2;
                System.Console.WriteLine("speed = 3");
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                speed = 10;
                maxSimulationStepsPerUpdate = 9999;
                System.Console.WriteLine("speed = 10");
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                speed = 50;
                maxSimulationStepsPerUpdate = 9999;
                System.Console.WriteLine("speed = 50");
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                speed = customspeed;
                maxSimulationStepsPerUpdate = 9999;
                System.Console.WriteLine("speed = " + customspeed);
            }
            if (Input.GetKeyDown(KeyCode.F1) && Input.GetKey(KeyCode.LeftControl))
            {
                slow = !slow;// = maxSimulationStepsPerUpdate == 1 ? 2 : 1;
                System.Console.WriteLine("slow = " + slow);
            }
            if (Input.GetKeyDown(KeyCode.F2) && Input.GetKey(KeyCode.LeftControl))
            {
                slowAmount = slowAmount == 1 ? 2 : 1;// = maxSimulationStepsPerUpdate == 1 ? 2 : 1;
                System.Console.WriteLine("slow amount = " + slowAmount);
            }
            if (Input.GetKeyDown(KeyCode.F5))
            {
                Il2CppSystem.Action<int> deb = (Il2CppSystem.Action<int>)delegate (int s)
                {
                    customspeed = s;
                    speed = customspeed;
                };
                PopupScreen.instance.ShowSetValuePopup("speed",
                "which speed ? ", deb, 100);
                //PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;
            }


        }





    }

}