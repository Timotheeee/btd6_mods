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
            public override string BaseDisplay => Game.instance.model.bloonsByName["Red"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "red"); }
        }
        class Blue : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Blue"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "blue"); }
        }
        class Green : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Green"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "green"); }
        }
        class Yellow : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Yellow"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "yellow"); }
        }
        class Pink : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Pink"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "pink"); }
        }
        class White : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["White"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "white"); }
        }
        class Black : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Black"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "black"); }
        }
        class Zebra : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Zebra"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "zebra"); }
        }
        class Lead : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Lead"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "lead"); }
        }
        class Purple : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Purple"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "purple"); }
        }
        class Rainbow : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Rainbow"].display;
            public override void ModifyDisplayNode(UnityDisplayNode node) { Set2DTexture(node, "rainbow"); }
        }
        class Ceramic : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.bloonsByName["Ceramic"].display;
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




            gameModel.bloonsByName["Red"].display = ModContent.GetDisplayGUID<Red>();
            gameModel.bloonsByName["Blue"].display = ModContent.GetDisplayGUID<Blue>();
            gameModel.bloonsByName["Green"].display = ModContent.GetDisplayGUID<Green>();
            gameModel.bloonsByName["Yellow"].display = ModContent.GetDisplayGUID<Yellow>();
            gameModel.bloonsByName["Pink"].display = ModContent.GetDisplayGUID<Pink>();
            gameModel.bloonsByName["White"].display = ModContent.GetDisplayGUID<White>();
            gameModel.bloonsByName["Black"].display = ModContent.GetDisplayGUID<Black>();
            gameModel.bloonsByName["Zebra"].display = ModContent.GetDisplayGUID<Zebra>();
            gameModel.bloonsByName["Lead"].display = ModContent.GetDisplayGUID<Lead>();
            gameModel.bloonsByName["Purple"].display = ModContent.GetDisplayGUID<Purple>();
            gameModel.bloonsByName["Rainbow"].display = ModContent.GetDisplayGUID<Rainbow>();
            gameModel.bloonsByName["Ceramic"].display = ModContent.GetDisplayGUID<Ceramic>();
            gameModel.bloonsByName["Ceramic"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["RedRegrow"].display = ModContent.GetDisplayGUID<Red>();
            gameModel.bloonsByName["BlueRegrow"].display = ModContent.GetDisplayGUID<Blue>();
            gameModel.bloonsByName["GreenRegrow"].display = ModContent.GetDisplayGUID<Green>();
            gameModel.bloonsByName["YellowRegrow"].display = ModContent.GetDisplayGUID<Yellow>();
            gameModel.bloonsByName["PinkRegrow"].display = ModContent.GetDisplayGUID<Pink>();
            gameModel.bloonsByName["WhiteRegrow"].display = ModContent.GetDisplayGUID<White>();
            gameModel.bloonsByName["BlackRegrow"].display = ModContent.GetDisplayGUID<Black>();
            gameModel.bloonsByName["ZebraRegrow"].display = ModContent.GetDisplayGUID<Zebra>();
            gameModel.bloonsByName["LeadRegrow"].display = ModContent.GetDisplayGUID<Lead>();
            gameModel.bloonsByName["PurpleRegrow"].display = ModContent.GetDisplayGUID<Purple>();
            gameModel.bloonsByName["RainbowRegrow"].display = ModContent.GetDisplayGUID<Rainbow>();
            gameModel.bloonsByName["CeramicRegrow"].display = ModContent.GetDisplayGUID<Ceramic>();
            gameModel.bloonsByName["CeramicRegrow"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["RedCamo"].display = ModContent.GetDisplayGUID<Red>();
            gameModel.bloonsByName["BlueCamo"].display = ModContent.GetDisplayGUID<Blue>();
            gameModel.bloonsByName["GreenCamo"].display = ModContent.GetDisplayGUID<Green>();
            gameModel.bloonsByName["YellowCamo"].display = ModContent.GetDisplayGUID<Yellow>();
            gameModel.bloonsByName["PinkCamo"].display = ModContent.GetDisplayGUID<Pink>();
            gameModel.bloonsByName["WhiteCamo"].display = ModContent.GetDisplayGUID<White>();
            gameModel.bloonsByName["BlackCamo"].display = ModContent.GetDisplayGUID<Black>();
            gameModel.bloonsByName["ZebraCamo"].display = ModContent.GetDisplayGUID<Zebra>();
            gameModel.bloonsByName["LeadCamo"].display = ModContent.GetDisplayGUID<Lead>();
            gameModel.bloonsByName["PurpleCamo"].display = ModContent.GetDisplayGUID<Purple>();
            gameModel.bloonsByName["RainbowCamo"].display = ModContent.GetDisplayGUID<Rainbow>();
            gameModel.bloonsByName["CeramicCamo"].display = ModContent.GetDisplayGUID<Ceramic>();
            gameModel.bloonsByName["CeramicCamo"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["RedRegrowCamo"].display = ModContent.GetDisplayGUID<Red>();
            gameModel.bloonsByName["BlueRegrowCamo"].display = ModContent.GetDisplayGUID<Blue>();
            gameModel.bloonsByName["GreenRegrowCamo"].display = ModContent.GetDisplayGUID<Green>();
            gameModel.bloonsByName["YellowRegrowCamo"].display = ModContent.GetDisplayGUID<Yellow>();
            gameModel.bloonsByName["PinkRegrowCamo"].display = ModContent.GetDisplayGUID<Pink>();
            gameModel.bloonsByName["WhiteRegrowCamo"].display = ModContent.GetDisplayGUID<White>();
            gameModel.bloonsByName["BlackRegrowCamo"].display = ModContent.GetDisplayGUID<Black>();
            gameModel.bloonsByName["ZebraRegrowCamo"].display = ModContent.GetDisplayGUID<Zebra>();
            gameModel.bloonsByName["LeadRegrowCamo"].display = ModContent.GetDisplayGUID<Lead>();
            gameModel.bloonsByName["PurpleRegrowCamo"].display = ModContent.GetDisplayGUID<Purple>();
            gameModel.bloonsByName["RainbowRegrowCamo"].display = ModContent.GetDisplayGUID<Rainbow>();
            gameModel.bloonsByName["CeramicRegrowCamo"].display = ModContent.GetDisplayGUID<Ceramic>();
            gameModel.bloonsByName["CeramicRegrowCamo"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicFortified"].display = ModContent.GetDisplayGUID<Ceramic>();
            gameModel.bloonsByName["CeramicFortified"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicFortifiedCamo"].display = ModContent.GetDisplayGUID<Ceramic>();
            gameModel.bloonsByName["CeramicFortifiedCamo"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicRegrowFortified"].display = ModContent.GetDisplayGUID<Ceramic>();
            gameModel.bloonsByName["CeramicRegrowFortified"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);

            gameModel.bloonsByName["CeramicRegrowFortifiedCamo"].display = ModContent.GetDisplayGUID<Ceramic>();
            gameModel.bloonsByName["CeramicRegrowFortifiedCamo"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);


        }

    }
}