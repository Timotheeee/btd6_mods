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

//using Il2CppSystem.Collections;
using Assets.Scripts.Unity.UI_New.Popups;
using System.Reflection;
using Assets.Scripts.Models;
using System.Collections.Generic;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.GenericBehaviors;
using System;
using System.Linq;
using Assets.Scripts.Models.ServerEvents;
using Assets.Scripts.Data.Cosmetics.Pets;
using Assets.Main.Scenes;
using UnhollowerBaseLib;

using Assets.Scripts.Models.Rounds;
using Assets.Scripts.Models.Store;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Map;
using UnityEngine;
using Assets.Scripts.Unity.Map;
using Assets.Scripts.Models.Towers.Upgrades;
//using Newtonsoft.Json.Linq;
using Assets.Scripts.Unity.UI_New;
using Assets.Scripts.Data.MapSets;
using UnhollowerRuntimeLib;
using TMPro;

using Assets.Main.Scenes;
using Assets.Scripts.Models.Powers;
using Assets.Scripts.Models.Profile;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.TowerSets;
using Assets.Scripts.Simulation.Input;
using Assets.Scripts.Unity;
using Harmony;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using System;
using System.Linq;
using System.IO;
using System.Drawing;
using Assets.Scripts.Models.Towers.Weapons;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Unity.Player;
using UnityEngine.SceneManagement;
using Assets.Scripts.Simulation.Towers.Behaviors;
using Assets.Scripts.Unity.Display;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;

using Assets.Scripts.Unity.UI_New.ChallengeEditor;
using static Assets.Scripts.Unity.Player.Btd6Player;
using Assets.Scripts.Unity.UI_New.Main.MapSelect;
using Assets.Scripts.Simulation.Towers.Behaviors.Attack;
using Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;
using Assets.Scripts.Models.Bloons;

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



            if (Input.GetKeyDown(KeyCode.Z))
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
