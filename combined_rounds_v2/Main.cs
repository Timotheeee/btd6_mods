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
using UnityEngine;
using TMPro;
using BTD_Mod_Helper.Api.ModOptions;
using BTD_Mod_Helper;

namespace combined_rounds_v2
{
    public class Main : BloonsMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("combined_rounds_v2 loaded");
        }

        private readonly static ModSettingBool Income = new ModSettingBool(true)
        {
            IsButton = false,
            displayName = "disable normal income",
        };

        static double[] moneyOnRound = new double[]
{
            121
            ,137
            ,138
            ,175
            ,164
            ,163
            ,182
            ,200
            ,199
            ,314
            ,189
            ,192
            ,282
            ,259
            ,266
            ,268
            ,165
            ,358
            ,260
            ,186
            ,351
            ,298
            ,277
            ,167
            ,335
            ,333
            ,662
            ,266
            ,389
            ,337
            ,537
            ,627
            ,205
            ,912
            ,1150
            ,896
            ,1339
            ,1277
            ,1759
            ,521
            ,2181
            ,659
            ,1278
            ,1294
            ,2422
            ,716
            ,1637
            ,2843
            ,4758
            ,3016
            ,1098.5
            ,1595.5
            ,924.5
            ,2197.5
            ,2483
            ,1286.5
            ,1859
            ,2298
            ,2159
            ,922.5
            ,1232
            ,1386.4
            ,2826
            ,849.8
            ,3071.6
            ,1004.2
            ,1023.6
            ,777.8
            ,1391
            ,2618.8
            ,1503
            ,1504
            ,1392.6
            ,3044
            ,2667.4
            ,1316
            ,2540.2
            ,4862
            ,6709
            ,1400.2
            ,5366
            ,4757
            ,4749
            ,7044
            ,2625.4
            ,948.5
            ,2627.4
            ,3314
            ,2171
            ,339.3
            ,4191
            ,4537.4
            ,1946.6
            ,7667.1
            ,3718
            ,9955.6
            ,1417.2
            ,9653.8
            ,2827.9
            ,1534.6
            ,426.2
            ,1101.68
            ,2589.96
            ,3159
            ,1883.5
            ,914.66
            ,1670.48
            ,2526.38
            ,3184.7
            ,1201.1
            ,3993.62
            ,1195.52
            ,1401.6
            ,2371.66
            ,2372.66
            ,1789.16
            ,594.9
            ,1910.84
            ,1019.76
            ,2233.12
            ,1593.48
            ,2083.5
            ,2723.16
            ,2511.5
            ,4548.48
            ,980.52
            ,1324.76
            ,1820.18
            ,2240.76
            ,1784.48
            ,2427.36
            ,3184.48
            ,3305.94
            ,1454
            ,2103.3
            ,1699.52
            ,3531.12
            ,1198.12
            ,2166.86
            ,773.84

};

        [HarmonyPatch(typeof(Simulation), "RoundEnd")]
        class RoundEndHook
        {
            [HarmonyPostfix]
            public static void Postfix(int round, int highestCompletedRound)
            {
                if ((bool)Income.GetValue())
                {
                    InGame.instance.bridge.simulation.cashManagers.entries[0].value.cash.Value += moneyOnRound[round];
                    InGame.instance.bridge.OnCashChangedSim();
                }
                
 
            }
        }



        //remove income
        [HarmonyPatch(typeof(Simulation), "AddCash")]
        public class AddCash_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(ref double c, ref Simulation.CashSource source)
            {
                if ((bool)Income.GetValue())
                {
                    if (source != Simulation.CashSource.CoopTransferedCash && source != Simulation.CashSource.TowerSold) c = 0;
                }
                    
                return true;
            }
        }




        bool updated = false;
        static bool change;
        static int normalRoundsCount = 1;
        static int abrRoundsCount = 1;

        public override void OnUpdate()
        {
            base.OnUpdate();

            //MelonLogger.Msg((bool)Income.GetValue());
            //MelonLogger.Msg(Income.GetValue());

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (change && PopupScreen.instance.GetFirstActivePopup() != null)
            {
                PopupScreen.instance.GetFirstActivePopup().GetComponentInChildren<TMP_InputField>().characterValidation = TMP_InputField.CharacterValidation.None;
                change = false;
            }



            if (!inAGame)
            {
                if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.F6))
                {
                    Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                    {
                        try
                        {
                            normalRoundsCount = int.Parse(s);
                        }
                        catch
                        {
                            MelonLogger.Msg("could not parse input");
                        }

                    };
                    PopupScreen.instance.ShowSetNamePopup("how many times should the normal rounds show up ?", "enter a whole number between 0 and 10", mod, "3");

                    change = true;
                }
                if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F6))
                {
                    Il2CppSystem.Action<string> mod = (Il2CppSystem.Action<string>)delegate (string s)
                    {
                        try
                        {
                            abrRoundsCount = int.Parse(s);
                        }
                        catch
                        {
                            MelonLogger.Msg("could not parse input");
                        }

                    };
                    PopupScreen.instance.ShowSetNamePopup("how many times should the ABR rounds show up ?", "enter a whole number between 0 and 10", mod, "3");

                    change = true;
                }
            }

            if (inAGame)
            {
                if (!updated)
                {
                    var rounds = InGame.instance.bridge.Model.roundSetsByName;
                    var def = rounds["DefaultRoundSet"];
                    var abr = rounds["AlternateRoundSet"];
                    for (int i = 0; i < 100; i++)
                    {
                        var normal = def.rounds[i].emissions.Count;
                        var ABR = abr.rounds[i].emissions.Count;
                        var totalNormal = normal * normalRoundsCount;
                        var totalABR = ABR * abrRoundsCount;
                        var total = totalNormal + totalABR;
                        int newidx = 0;
                        Il2CppReferenceArray<BloonEmissionModel> newEmissions = new Il2CppReferenceArray<BloonEmissionModel>(total);
                        MelonLogger.Msg("i: " + i + " normal: " + normal + " ABR: " + ABR + " total: " + total);
                        for (int j = 0; j < totalNormal; j++)
                        {
                            //MelonLogger.Msg("normal. j: " + j + " normal size: " + normal + " j%normal: " + (j%normal));
                            newEmissions[newidx] = new BloonEmissionModel(def.rounds[i].emissions[j % normal].bloon, def.rounds[i].emissions[j % normal].time, def.rounds[i].emissions[j % normal].bloon);
                            newidx++;
                        }
                        for (int j = 0; j < totalABR; j++)
                        {
                            //MelonLogger.Msg("abr. j: " + j + " ABR size: " + ABR + " j%ABR: " + (j % ABR));
                            newEmissions[newidx] = new BloonEmissionModel(abr.rounds[i].emissions[j % ABR].bloon, abr.rounds[i].emissions[j % ABR].time, abr.rounds[i].emissions[j % ABR].bloon);
                            newidx++;
                        }
                        def.rounds[i].emissions_ = newEmissions;
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