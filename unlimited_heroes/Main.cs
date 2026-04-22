using MelonLoader;
using HarmonyLib;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Simulation.Input;
using Il2CppAssets.Scripts.Unity.Bridge;
using System;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.RightMenu;
using Il2CppAssets.Scripts.Unity.UI_New.InGame.StoreMenu;

[assembly: MelonInfo(typeof(unlimited_heroes.Main), unlimited_heroes.ModHelperData.Name, unlimited_heroes.ModHelperData.Version, unlimited_heroes.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace unlimited_heroes
{
    public class Main : BloonsTD6Mod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("unlimited_heroes loaded.");
        }

        // code based off of https://github.com/doombubbles/useful-utilities/blob/main/Utilities/InGameHeroSwitch.cs
        // used with permission
        private static void RefreshShop()
        {
            bool disallowSelectingDifferentTowers = ShopMenu.instance.disallowSelectingDifferentTowers;
            ShopMenu.instance.disallowSelectingDifferentTowers = true;
            ShopMenu.instance.RebuildTowerSet();
            ShopMenu.instance.disallowSelectingDifferentTowers = disallowSelectingDifferentTowers;
            foreach (ITowerPurchaseButton? button in ShopMenu.instance.ActiveTowerButtons)
            {
                TowerPurchaseButton purchaseButton = button.Cast<TowerPurchaseButton>();
                purchaseButton.SetAvailable();
                purchaseButton.Update();
            }
        }

        [HarmonyPatch(typeof(UnityToSimulation), nameof(UnityToSimulation.MatchReady))]
        internal static class UnityToSimulation_MatchReady
        {
            [HarmonyPostfix]
            internal static void Postfix()
            {
                TowerInventory towerInventory = InGame.instance.GetTowerInventory();
                foreach (TowerDetailsModel? hero in InGame.instance.GetGameModel().heroSet)
                {
                    towerInventory.towerMaxes[hero.towerId] = int.MaxValue;
                }
                RefreshShop();
            }
        }
    }
}