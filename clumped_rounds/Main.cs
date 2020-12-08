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

namespace clumped_rounds
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.instance.listen(typeof(Main));
            Logger.Log("clumped_rounds loaded");
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
                    var rsm = rounds["DefaultRoundSet"];
                    for (int i = 0; i < rsm.rounds.Count; i++)
                    {
                        Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(rsm.rounds[i].emissions.Count);
                        for (int j = 0; j < rsm.rounds[i].emissions.Count; j++)
                        {
                            bme[j] = new BloonEmissionModel(rsm.rounds[i].emissions[j].bloon, 0, rsm.rounds[i].emissions[j].bloon);
                        }
                        rsm.rounds[i].emissions_ = bme;
                    }

                    rsm = rounds["AlternateRoundSet"];
                    for (int i = 0; i < rsm.rounds.Count; i++)
                    {
                        Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(rsm.rounds[i].emissions.Count);
                        for (int j = 0; j < rsm.rounds[i].emissions.Count; j++)
                        {
                            bme[j] = new BloonEmissionModel(rsm.rounds[i].emissions[j].bloon, 0, rsm.rounds[i].emissions[j].bloon);
                        }
                        rsm.rounds[i].emissions_ = bme;
                    }
                    updated = true;
                }


            } else
            {
                updated = false;
            }
        }




    }

}