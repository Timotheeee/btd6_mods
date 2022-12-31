using MelonLoader;
//using Harmony;
using HarmonyLib;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.Races;
using Il2CppAssets.Scripts.Simulation.Towers.Weapons;
using Il2CppAssets.Scripts.Simulation;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppAssets.Scripts.Unity.UI_New.Main;
using Il2CppAssets.Scripts.Simulation.Bloons;
using Il2CppAssets.Scripts.Models.Towers;

using Il2CppAssets.Scripts.Unity;

using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Simulation.Input;

using Il2CppSystem.Collections.Generic;


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

using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Main.Scenes;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Input;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Unity.Player;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using System.Linq;
using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Simulation.Track;

[assembly: MelonInfo(typeof(mastery_mode_v2.Main), mastery_mode_v2.ModHelperData.Name, mastery_mode_v2.ModHelperData.Version, mastery_mode_v2.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace mastery_mode_v2
{
    public class Main : MelonMod
    {

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


        public static double roundbonus = 0;
        [HarmonyPatch(typeof(Simulation), "RoundEnd")]
        class RoundEndHook
        {
            [HarmonyPrefix]
            public static void Prefix(int round, int highestCompletedRound)
            {
                //int round = InGame.instance.bridge.GetCurrentRound();
                //InGame.instance.bridge.simulation.cashManagers.TryGetValue(0, out var manager);
                //manager.cash.Value += moneyOnRound[round];
                //InGame.instance.bridge.OnCashChangedSim();
                //InGame.instance.bridge.AddCash(9999999, Simulation.CashSource.Normal);
                //Console.WriteLine(round + " " + highestCompletedRound);
                roundbonus = moneyOnRound[round];
                //Console.WriteLine("set bonus to: " + roundbonus); 
            }
        }

        public static readonly System.Collections.Generic.Dictionary<string, string> promotionMap = new System.Collections.Generic.Dictionary<string, string>()
        {
            { "Red", "Blue" },
            { "RedCamo", "BlueCamo" },
            { "RedRegrow", "BlueRegrow" },
            { "RedRegrowCamo", "BlueRegrowCamo" },

            { "Blue", "Green" },
            { "BlueCamo", "GreenCamo" },
            { "BlueRegrow", "GreenRegrow" },
            { "BlueRegrowCamo", "GreenRegrowCamo" },

            { "Green", "Yellow" },
            { "GreenCamo", "YellowCamo" },
            { "GreenRegrow", "YellowRegrow" },
            { "GreenRegrowCamo", "YellowRegrowCamo" },

            { "Yellow", "Pink" },
            { "YellowCamo", "PinkCamo" },
            { "YellowRegrow", "PinkRegrow" },
            { "YellowRegrowCamo", "PinkRegrowCamo" },

            { "Pink", "Black" },
            { "PinkCamo", "BlackCamo" },
            { "PinkRegrow", "BlackRegrow" },
            { "PinkRegrowCamo", "BlackRegrowCamo" },

            { "Black", "Zebra" },
            { "BlackCamo", "ZebraCamo" },
            { "BlackRegrow", "ZebraRegrow" },
            { "BlackRegrowCamo", "ZebraRegrowCamo" },

            { "White", "Purple" },
            { "WhiteCamo", "PurpleCamo" },
            { "WhiteRegrow", "PurpleRegrow" },
            { "WhiteRegrowCamo", "PurpleRegrowCamo" },

            { "Purple", "LeadFortified" },
            { "PurpleCamo", "LeadFortifiedCamo" },
            { "PurpleRegrow", "LeadRegrowFortified" },
            { "PurpleRegrowCamo", "LeadRegrowFortifiedCamo" },

            { "Lead", "Rainbow" },
            { "LeadCamo", "RainbowCamo" },
            { "LeadRegrow", "RainbowRegrow" },
            { "LeadRegrowCamo", "RainbowRegrowCamo" },
            { "LeadFortified", "RainbowRegrowCamo" },
            { "LeadRegrowFortified", "RainbowRegrowCamo" },
            { "LeadFortifiedCamo", "RainbowRegrowCamo" },
            { "LeadRegrowFortifiedCamo", "RainbowRegrowCamo" },

            { "Zebra", "Rainbow" },
            { "ZebraCamo", "RainbowCamo" },
            { "ZebraRegrow", "RainbowRegrow" },
            { "ZebraRegrowCamo", "RainbowRegrowCamo" },

            { "Rainbow", "Ceramic" },
            { "RainbowCamo", "CeramicCamo" },
            { "RainbowRegrow", "CeramicRegrow" },
            { "RainbowRegrowCamo", "CeramicRegrowCamo" },

            { "Ceramic", "Moab" },
            { "CeramicCamo", "Moab" },
            { "CeramicRegrow", "Moab" },
            { "CeramicRegrowCamo", "Moab" },
            { "CeramicFortified", "MoabFortified" },
            { "CeramicFortifiedCamo", "MoabFortified" },
            { "CeramicRegrowFortified", "MoabFortified" },
            { "CeramicRegrowFortifiedCamo", "MoabFortified" },

            { "Moab", "Bfb" },
            { "MoabFortified", "BfbFortified" },

            { "Bfb", "DdtCamo" },
            { "BfbFortified", "DdtFortifiedCamo" },

            { "DdtCamo", "Zomg" },
            { "DdtFortifiedCamo", "ZomgFortified" },

            { "Zomg", "Bad" },
            { "ZomgFortified", "BadFortified" },

            { "Bad", "BadFortified" },
            { "BadFortified", "BadFortified" }
        };

        public static System.Random random = new System.Random();



        [HarmonyPatch(typeof(Simulation), "AddCash")]
        public class AddCash_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(ref double c, ref Simulation.CashSource source)
            {
                //Console.WriteLine(source);
                if (source != Simulation.CashSource.CoopTransferedCash && source != Simulation.CashSource.TowerSold)
                {
                    c = 0;
                    if (roundbonus > 0)
                    {
                        c = roundbonus;
                        roundbonus = 0;
                        //Console.WriteLine("applied bonus: " + c);
                    }
                }
                return true;
            }
        }

        // rng
        //[HarmonyPatch(typeof(Spawner), "Emit")]
        //public class GetBloonModel_Patch
        //{
        //    public static BloonModel BloonsendRng(BloonModel bloon, string bloonToPatch, bool randCond, string randBloon1, string randBloon2)
        //    {
        //        string bloonId = bloon.id;
        //        if (bloonId.Contains(bloonToPatch))
        //        {
        //            string mod = string.Empty;
        //            if (bloonId != bloonToPatch) // if it's not the same as bloonToPatch but contains, it has modifiers
        //            {
        //                mod = bloonId.Substring(4, bloonId.Length - 4).Replace("Fortified", "");
        //            }

        //            return randCond ? Game.instance.model.GetBloon(randBloon1 + mod) : Game.instance.model.GetBloon(randBloon2 + mod);
        //        }

        //        return bloon;
        //    }

        //    [HarmonyPrefix]
        //    public static bool Prefix(ref BloonModel bloon)
        //    {
        //        bloon = BloonsendRng(bloon, "Pink", Main.random.Next(1, 3) == 1, "White", "Black");
        //        bloon = BloonsendRng(bloon, "Lead", Main.random.Next(1, 12) >= 8, "Zebra", "Rainbow");

        //        return true;
        //    }
        //}

        // promote bloons in roundsets
        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Game_Patch
        {
            public static string PromoteBloon(string bloon)
            {
                //if (bloon.Contains("Pink") || bloon.Contains("Lead")) return bloon;
                string temp = bloon;
                Main.promotionMap.TryGetValue(bloon, out temp);
                return temp;
            }

            [HarmonyPostfix]
            public static void Postfix()
            {
                // promotion
                for (int i = 0; i < Game.instance.model.roundSets.Length; i++)
                {
                    RoundSetModel roundSet = Game.instance.model.roundSets[i];
                    for (int j = 0; j < roundSet.rounds.Length; j++)
                    {
                        RoundModel round = roundSet.rounds[j];

                        if (j == 99) // round 100 patch (3 spaced fortified BADs)
                        {
                            round.groups[0].count += 2;
                            round.groups[0].end += 2666;
                        }

                        for (int k = 0; k < round.groups.Length; k++)
                        {
                            BloonGroupModel bloonGroup = round.groups[k];
                            bloonGroup.bloon = PromoteBloon(bloonGroup.bloon);
                        }
                    }
                }
            }
        }
    }



}