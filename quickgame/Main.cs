using MelonLoader;
using BTD_Mod_Helper;
using quickgame;
using Il2CppAssets.Scripts.Unity.UI_New;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using UnityEngine;
using UnityEngine.UI;
using BTD_Mod_Helper.Api.ModOptions;
using System;


[assembly: MelonInfo(typeof(quickgame.quickgame), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace quickgame;

public class quickgame : BloonsTD6Mod
{
    public bool GameStart = true;

    public override void OnApplicationStart()
    {

    }

    public override void OnMainMenu()
    {
        if (GameStart)
        {
            LoadGame();
        }
    }

    public void LoadGame()
    {
        InGameData.Editable.selectedMode = "Standard";
        InGameData.Editable.selectedMap = "Logs";
        InGameData.Editable.selectedDifficulty = "Hard";
        UI.instance.LoadGame();
        GameStart = false;
    }

    public override void OnTitleScreen()
    {
        var button = GameObject.Find("Canvas/ScreenBoxer/TitleScreen/Start");
        button.GetComponent<Button>().onClick.Invoke();
    }
}