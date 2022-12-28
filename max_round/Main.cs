using MelonLoader;
using Harmony;

using Il2CppAssets.Scripts.Unity.UI_New.InGame;

using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Text.RegularExpressions;
using System.IO;
using Il2CppAssets.Main.Scenes;
using UnityEngine;
using System.Linq;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Simulation.Track;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using Il2CppAssets.Scripts.Unity.Player;

[assembly: MelonInfo(typeof(max_round.Main), max_round.ModHelperData.Name, max_round.ModHelperData.Version, max_round.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace max_round
{
    public class Main : BloonsTD6Mod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("max_round loaded");
        }

        [HarmonyPatch(typeof(MapButton), "ShowMedal")]
        public class ShowMedal_Patch2
        {
            [HarmonyPrefix]
            public static bool Prefix(MapButton __instance, Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode)
            {
                player.HasSeenRound(99999);
                player.SeenRound(99999);
                player.debugSeenAllRounds = true;


                return true;
            }
        }








    }


}