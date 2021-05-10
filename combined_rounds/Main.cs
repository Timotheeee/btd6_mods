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
using Assets.Scripts.Models.Rounds;
using UnhollowerBaseLib;
using System;

namespace combined_rounds
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("combined_rounds loaded");
        }

        bool updated = false;

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;


            if (inAGame)
            {
                if (!updated)
                {
                    var rounds = InGame.instance.bridge.Model.roundSetsByName;
                    var def = rounds["DefaultRoundSet"];
                    var abr = rounds["AlternateRoundSet"];
                    for (int i = 0; i < 100; i++)
                    {
                        var total = def.rounds[i].emissions.Count + abr.rounds[i].emissions.Count;
                        Il2CppReferenceArray<BloonEmissionModel> new_emissions = new Il2CppReferenceArray<BloonEmissionModel>(total);
                        for (int j = 0; j < def.rounds[i].emissions.Count; j++)
                        {
                            new_emissions[j] = new BloonEmissionModel(def.rounds[i].emissions[j].bloon, def.rounds[i].emissions[j].time, def.rounds[i].emissions[j].bloon);
                        }
                        for (int j = 0; j < abr.rounds[i].emissions.Count; j++)
                        {
                            new_emissions[j + def.rounds[i].emissions.Count] = new BloonEmissionModel(abr.rounds[i].emissions[j].bloon, abr.rounds[i].emissions[j].time, abr.rounds[i].emissions[j].bloon);
                        }
                        def.rounds[i].emissions_ = new_emissions;
                    }

                    updated = true;
                }


            }
            else
            {
                updated = false;
            }
        }




    }

}