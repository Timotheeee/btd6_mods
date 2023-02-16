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

//using Il2CppSystem.Collections;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using System.Reflection;
using Il2CppAssets.Scripts.Models;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using System;
using System.Linq;
using Il2CppAssets.Scripts.Models.ServerEvents;
using Il2CppAssets.Scripts.Data.Cosmetics.Pets;
using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Models.Store;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Map;
using UnityEngine;
using Il2CppAssets.Scripts.Unity.Map;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
//using Newtonsoft.Json.Linq;
using Il2CppAssets.Scripts.Unity.UI_New;
using Il2CppAssets.Scripts.Data.MapSets;



using Il2CppAssets.Scripts.Unity.Scenes;
using Il2CppAssets.Scripts.Models.Powers;
using Il2CppAssets.Scripts.Models.Profile;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Simulation.Input;
using Il2CppAssets.Scripts.Unity;
using Harmony;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using System;
using System.Linq;
using System.IO;
using System.Drawing;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Unity.Player;
using UnityEngine.SceneManagement;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;

using Il2CppAssets.Scripts.Unity.UI_New.ChallengeEditor;
using static Il2CppAssets.Scripts.Unity.Player.Btd6Player;
using Il2CppAssets.Scripts.Unity.UI_New.Main.MapSelect;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;
using Il2CppAssets.Scripts.Models.Bloons;

[assembly: MelonInfo(typeof(infinite_xp.Main), infinite_xp.ModHelperData.Name, infinite_xp.ModHelperData.Version, infinite_xp.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace infinite_xp
{
    public class Main : MelonMod
    {

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            System.Console.WriteLine("infinite_xp loaded");
        }

        static string[] towers =
        {
            "Sentry",
            "SentryBoom",
            "SentryCrushing",
            "SentryCold",
            "SentryEnergy",
            "SentryParagon",
            "SunAvatarMini",
            "TrueSunAvatarMini",
            "BuccaneerLesserPlane",
            "BuccaneerLesserPlaneCamo",
            "BuccaneerGreaterPlane",
            "BuccaneerGreaterPlaneCamo",
            "Marine",
            "NaturesWardTotem",
            "Pontoon",
            "PortableLake",
            "BananaFarmer",
            "TechBot",
            "EnergisingTotem",
            "SacrificialTotem",
            "WizardPhoenix",
            "WizardLordPhoenix",
            "AdoraBallOfLight",
            "CaveMonkey",
            "AdmiralBrickell",
            "Etienne",
            "EtienneDrone",
            "EtienneUAV",
            "EtienneUCAV",
            "Adora",
            "Sauda",
            "ObynGreenfoot",
            "Benjamin",
            "DartMonkey",
            "BoomerangMonkey",
            "BombShooter",
            "TackShooter",
            "IceMonkey",
            "GlueGunner",
            "SniperMonkey",
            "MonkeySub",
            "MonkeyBuccaneer",
            "MonkeyAce",
            "HeliPilot",
            "MortarMonkey",
            "DartlingGunner",
            "WizardMonkey",
            "SuperMonkey",
            "NinjaMonkey",
            "Alchemist",
            "Druid",
            "BananaFarm",
            "EngineerMonkey",
            "SpikeFactory",
            "MonkeyAcademy",
            "MonkeyVillage",
            "Quincy",
            "StrikerJones",
            "Ezili",
            "CaptainChurchill",
            "Gwendolin",
            "PatFusty",
            "Psi",
        };

        public override void OnUpdate()
        {



            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                foreach (string t in towers)
                {
                    player2.AddTowerXP(t, 100000);
                    player2.GainPlayerXP(100000);
                }



            }

        }

        static Btd6Player player2;


        [HarmonyPatch(typeof(MapButton), "ShowMedal")]
        public class ShowMedal_Patch2
        {
            [HarmonyPrefix]
            public static bool Prefix(MapButton __instance, Btd6Player player, Animator medalAnimator, string mapId, string difficulty, string mode)
            {
                player2 = player;


                return true;
            }
        }



    }

}