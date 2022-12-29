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
using UnityEngine;
using System.Linq;

[assembly: MelonInfo(typeof(cursed_btd.Main), cursed_btd.ModHelperData.Name, cursed_btd.ModHelperData.Version, cursed_btd.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace cursed_btd
{
    public class Main : MelonMod
    {

        public static System.Random r = new System.Random();
        public static float amount = 0.2f;
        public static string[] filter = new string[]
        {
            "terrain",
            "camera",
        };

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            System.Console.WriteLine("cursed_btd loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
            {
                if (filter.Any(ob.name.ToLower().Contains))
                    continue;
                ob.transform.position += new Vector3(r.NextDouble() > 0.5f ? amount : -amount, r.NextDouble() > 0.5f ? amount : -amount, r.NextDouble() > 0.5f ? amount : -amount);
            }
        }





    }

}