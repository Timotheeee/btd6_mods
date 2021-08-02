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
            System.Console.WriteLine("fire rate changer loaded, prss F9 to use");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;

            if (change)
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
            if (Input.GetKeyDown(KeyCode.F9))
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
            if (Input.GetKeyDown(KeyCode.F10))
            {


                //GameObject.Find("SetNamePopup(Clone)").transform.FindChild("InputField").gameObject.GetComponent<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;


            }
        }



        static Il2CppSystem.Action<float> rateDel = (Il2CppSystem.Action<float>)delegate (float s)
        {
            rate = s;
        };

        static bool change;





    }

}