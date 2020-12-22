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
using Assets.Scripts.Models.Rounds;
using UnhollowerBaseLib;

namespace combined_rounds
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            Logger.Log("combined_rounds loaded");
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
                    for (int i = 0; i < def.rounds.Count; i++)
                    {
                        var total = def.rounds[i].emissions.Count + abr.rounds[i].emissions.Count;
                        Il2CppReferenceArray<BloonEmissionModel> new_emissions = new Il2CppReferenceArray<BloonEmissionModel>(total);
                        for (int j = 0; j < def.rounds[i].emissions.Count; j++)
                        {
                            new_emissions[j] = new BloonEmissionModel(def.rounds[i].emissions[j].bloon, def.rounds[i].emissions[j].time, def.rounds[i].emissions[j].bloon);
                        }
                        for (int j = 0; j < abr.rounds[i].emissions.Count; j++)
                        {
                            new_emissions[j+ def.rounds[i].emissions.Count] = new BloonEmissionModel(abr.rounds[i].emissions[j].bloon, abr.rounds[i].emissions[j].time, abr.rounds[i].emissions[j].bloon);
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