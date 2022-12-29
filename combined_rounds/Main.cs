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
using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;

[assembly: MelonInfo(typeof(combined_rounds.Main), combined_rounds.ModHelperData.Name, combined_rounds.ModHelperData.Version, combined_rounds.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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
                    var rounds = InGame.instance.bridge.Model.roundSets;
                    var def = rounds[0];
                    var abr = rounds[1];
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