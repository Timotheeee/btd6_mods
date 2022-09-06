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
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using TMPro;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using System;
using Assets.Scripts.Simulation.Towers.Behaviors;
using UnityEngine;
using Assets.Scripts.Unity.Display;
using System.Linq;
using System.IO;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Bloons;
using System.Collections.Generic;
using Assets.Main.Scenes;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Display;
using Assets.Scripts.Models.Bloons.Behaviors;

namespace crewmate_textures
{
    public class Main : BloonsTD6Mod
    {


        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("crewmate_textures loaded");
        }

        class Red : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Red"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "red"); }
        }
        class Blue : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Blue"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "blue"); }
        }
        class Green : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Green"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "green"); }
        }
        class Yellow : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Yellow"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "yellow"); }
        }
        class Pink : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Pink"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "pink"); }
        }
        class White : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["White"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "white"); }
        }
        class Black : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Black"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "black"); }
        }
        class Zebra : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Zebra"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "zebra"); }
        }
        class Lead : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Lead"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "lead"); }
        }
        class Purple : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Purple"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "purple"); }
        }
        class Rainbow : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Rainbow"].display.guidRef;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "rainbow"); }
        }
        class Ceramic : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Ceramic"].display.guidRef;
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
            gameModel.bloonsByName["Ceramic"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

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
            gameModel.bloonsByName["CeramicRegrow"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

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
            gameModel.bloonsByName["CeramicCamo"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

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
            gameModel.bloonsByName["CeramicRegrowCamo"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicFortified"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicFortified"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicFortifiedCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicFortifiedCamo"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicRegrowFortified"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicRegrowFortified"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicRegrowFortifiedCamo"].display = new PrefabReference() { guidRef = ModContent.GetDisplayGUID<Ceramic>() };
            gameModel.bloonsByName["CeramicRegrowFortifiedCamo"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);


        }

    }
}