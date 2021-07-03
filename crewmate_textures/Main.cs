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
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].RemoveBehavior<DamageStateModel>();
            gameModel.bloonsByName["Ceramic"].damageDisplayStates = new UnhollowerBaseLib.Il2CppReferenceArray<DamageStateModel>(0);
        }

    }
}