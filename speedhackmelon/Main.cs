using MelonLoader;
using Harmony;
using NKHook6.Api;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using NKHook6;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
using Assets.Scripts.Unity.UI_New.Main;
using NKHook6.Api.Events;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using static NKHook6.Api.Events._Towers.TowerEvents;
using Assets.Scripts.Simulation.Towers;

using static NKHook6.Api.Events._Weapons.WeaponEvents;
using Assets.Scripts.Utils;

using static NKHook6.Api.Events._TimeManager.TimeManagerEvents;
using Il2CppSystem.Collections;
using NKHook6.Api.Events._Bloons;
using NKHook6.Api.Events._Weapons;
using Assets.Scripts.Unity.UI_New.Popups;
using TMPro;
using UnityEngine;

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
            EventRegistry.instance.listen(typeof(Main));
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
            } else
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

        }

        //[EventAttribute("WeaponCreatedEvent")]
        //public static void WeaponCreatedEvent(WeaponEvents.CreatedEvent e)
        //{
            
        //    //System.Console.WriteLine("WeaponCreatedEvent");
        //    if (hypersonic)
        //        e.instance.weaponModel.rate = 0;
        //}



        [EventAttribute("KeyPressEvent")]
        public static void onEvent(KeyEvent e)
        {

            string key = e.key + "";

            //if (key == "Alpha4")
            //{
            //    System.Console.WriteLine("added cash");
            //    InGame.instance.addCash(1000000);

            //}
            //if (key == "Alpha5")
            //{
            //    hypersonic = true;
            //    System.Console.WriteLine("hypersonic on");
            //}
            if (key == "Alpha6")
            {
                speed = 3;
                maxSimulationStepsPerUpdate = 2;
                System.Console.WriteLine("speed = 3");
            }
            if (key == "Alpha7")
            {
                speed = 10;
                maxSimulationStepsPerUpdate = 9999;
                System.Console.WriteLine("speed = 10");
            }
            if (key == "Alpha8")
            {
                speed = 50;
                maxSimulationStepsPerUpdate = 9999;
                System.Console.WriteLine("speed = 50");
            }
            if (key == "Alpha9")
            {
                speed = customspeed;
                maxSimulationStepsPerUpdate = 9999;
                System.Console.WriteLine("speed = " + customspeed);
            }
            if (key == "F1" && Input.GetKey(KeyCode.LeftControl))
            {
                slow = !slow;// = maxSimulationStepsPerUpdate == 1 ? 2 : 1;
                System.Console.WriteLine("slow = " + slow);
            }
            if (key == "F2" && Input.GetKey(KeyCode.LeftControl))
            {
                slowAmount = slowAmount == 1 ? 2 : 1;// = maxSimulationStepsPerUpdate == 1 ? 2 : 1;
                System.Console.WriteLine("slow amount = " + slowAmount);
            }
            if (key == "F5")
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