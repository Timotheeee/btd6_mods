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
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Simulation.Objects;
using Il2CppAssets.Scripts.Models;

using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using UnityEngine;
using Il2CppAssets.Scripts.Unity.Display;
using System.Linq;
using System.IO;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Bloons;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Unity.Scenes;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Display;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppNinjaKiwi.Common.ResourceUtils;
using static Il2CppSystem.TypeIdentifiers;

[assembly: MelonInfo(typeof(crewmate_textures.Main), crewmate_textures.ModHelperData.Name, crewmate_textures.ModHelperData.Version, crewmate_textures.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace crewmate_textures
{
    public class Main : BloonsTD6Mod
    {


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("crewmate_textures loaded");
        }

        public override void OnTitleScreen()
        {
            //Console.WriteLine("Game.instance.model.bloons == null: " + (Game.instance.model.bloons == null));
            //Console.WriteLine("dict: ");
            //foreach (var thing in Game.instance.model.bloons)
            //{
            //    Console.WriteLine(thing.name);
            //    Console.WriteLine(thing.display);
            //    Console.WriteLine(thing.display.guidRef);
            //}
            //Console.WriteLine("Game.instance.model.bloonsByName[\"Red\"].display == null: " + Game.instance.model.bloonsByName["Red"].display == null);
            //Console.WriteLine("Game.instance.model.bloonsByName[\"Red\"].display.guidRef == null: " + Game.instance.model.bloonsByName["Red"].display.guidRef == null);
        }

        static string red = "9d3c0064c3ace7448bf8fefa4a97a70f";

        class Red : ModDisplay
        {
            public override string BaseDisplay => red;

            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "red"); }
        }
        class Blue : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "blue"); }
        }
        class Green : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "green"); }
        }
        class Yellow : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "yellow"); }
        }
        class Pink : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "pink"); }
        }
        class White : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "white"); }
        }
        class Black : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "black"); }
        }
        class Zebra : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "zebra"); }
        }
        class Lead : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "lead"); }
        }
        class Purple : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "purple"); }
        }
        class Rainbow : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "rainbow"); }
        }
        class Ceramic : ModDisplay
        {
            public override string BaseDisplay => red;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "ceramic"); }
        }

        public override void OnNewGameModel(GameModel gameModel)
        {
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();




            gameModel.bloonsByName["Red"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Red>() };
            gameModel.bloonsByName["Blue"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Blue>() };
            gameModel.bloonsByName["Green"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Green>() };
            gameModel.bloonsByName["Yellow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Yellow>() };
            gameModel.bloonsByName["Pink"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Pink>() };
            gameModel.bloonsByName["White"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<White>() };
            gameModel.bloonsByName["Black"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Black>() };
            gameModel.bloonsByName["Zebra"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Zebra>() };
            gameModel.bloonsByName["Lead"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Lead>() };
            gameModel.bloonsByName["Purple"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Purple>() };
            gameModel.bloonsByName["Rainbow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Rainbow>() };
            gameModel.bloonsByName["Ceramic"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["Ceramic"].damageDisplayStates = new Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["RedRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Red>() };
            gameModel.bloonsByName["BlueRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Blue>() };
            gameModel.bloonsByName["GreenRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Green>() };
            gameModel.bloonsByName["YellowRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Yellow>() };
            gameModel.bloonsByName["PinkRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Pink>() };
            gameModel.bloonsByName["WhiteRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<White>() };
            gameModel.bloonsByName["BlackRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Black>() };
            gameModel.bloonsByName["ZebraRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Zebra>() };
            gameModel.bloonsByName["LeadRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Lead>() };
            gameModel.bloonsByName["PurpleRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Purple>() };
            gameModel.bloonsByName["RainbowRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Rainbow>() };
            gameModel.bloonsByName["CeramicRegrow"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicRegrow"].damageDisplayStates = new Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["RedCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Red>() };
            gameModel.bloonsByName["BlueCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Blue>() };
            gameModel.bloonsByName["GreenCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Green>() };
            gameModel.bloonsByName["YellowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Yellow>() };
            gameModel.bloonsByName["PinkCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Pink>() };
            gameModel.bloonsByName["WhiteCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<White>() };
            gameModel.bloonsByName["BlackCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Black>() };
            gameModel.bloonsByName["ZebraCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Zebra>() };
            gameModel.bloonsByName["LeadCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Lead>() };
            gameModel.bloonsByName["PurpleCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Purple>() };
            gameModel.bloonsByName["RainbowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Rainbow>() };
            gameModel.bloonsByName["CeramicCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicCamo"].damageDisplayStates = new Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["RedRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Red>() };
            gameModel.bloonsByName["BlueRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Blue>() };
            gameModel.bloonsByName["GreenRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Green>() };
            gameModel.bloonsByName["YellowRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Yellow>() };
            gameModel.bloonsByName["PinkRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Pink>() };
            gameModel.bloonsByName["WhiteRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<White>() };
            gameModel.bloonsByName["BlackRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Black>() };
            gameModel.bloonsByName["ZebraRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Zebra>() };
            gameModel.bloonsByName["LeadRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Lead>() };
            gameModel.bloonsByName["PurpleRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Purple>() };
            gameModel.bloonsByName["RainbowRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Rainbow>() };
            gameModel.bloonsByName["CeramicRegrowCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicRegrowCamo"].damageDisplayStates = new Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicFortified"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicFortified"].damageDisplayStates = new Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicFortifiedCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicFortifiedCamo"].damageDisplayStates = new Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicRegrowFortified"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicRegrowFortified"].damageDisplayStates = new Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicRegrowFortifiedCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicRegrowFortifiedCamo"].damageDisplayStates = new Il2CppReferenceArray<DamageStateModel>(0);


        }

    }
}