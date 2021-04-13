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
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using TMPro;
using UnityEngine;

namespace rate_changer
{
    public class Main : MelonMod
    {



        static float rate = 1;
        static float timer = 0;


        static System.Random random = new System.Random();

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            NKHook6.Logger.Log("rate changer loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;

            if(change)
            {
                if (PopupScreen.instance.GetFirstActivePopup() != null)
                {
                    PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;
                    change = false;
                }

            }
            if (inAGame)
            {
                timer += UnityEngine.Time.deltaTime;
                if (rate != 1 && timer > 1)
                {
                    foreach (TowerToSimulation towerToSimulation in InGame.instance.bridge.GetAllTowers())
                    {
                        StartOfRoundRateBuffModel rateBuffSORModel = new StartOfRoundRateBuffModel("69", 1 / rate, 2);
                        BehaviorMutator rateBuffModel = new StartOfRoundRateBuffModel.RateMutator(rateBuffSORModel);
                        towerToSimulation.tower.AddMutator(rateBuffModel, 600, true, true, false, true, false, false);

                        //towerToSimulation.tower.mutators
                    }
                    timer = 0;
                }

            }
        }



        static Il2CppSystem.Action<float> rateDel = (Il2CppSystem.Action<float>)delegate (float s)
        {
            rate = s;
        };

        static bool change;

        [EventAttribute("KeyPressEvent")]
        public static void onEvent(KeyEvent e)
        {

            string key = e.key + "";

            if (key == "F9")
            {
                Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                {
                    rate = float.Parse(s);

                };
                PopupScreen.instance.ShowSetNamePopup("rate", "multiply fire rate by", mod, "0.33");
                change = true;

                //GameObject.Find("SetNamePopup(Clone)").transform.FindChild("InputField").gameObject.GetComponent<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;

                //PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;
            }
            if (key == "F10")
            {

                
                //GameObject.Find("SetNamePopup(Clone)").transform.FindChild("InputField").gameObject.GetComponent<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;


            }




        }



    }

}