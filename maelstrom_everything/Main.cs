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
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[assembly: MelonInfo(typeof(maelstrom_everything.Main), maelstrom_everything.ModHelperData.Name, maelstrom_everything.ModHelperData.Version, maelstrom_everything.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace maelstrom_everything
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            Console.WriteLine("maelstrom_everything loaded");
        }

        static AbilityModel mael;





        [HarmonyPatch(typeof(TitleScreen), "Start")]
        public class Awake_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                var models = Game.instance.model.towers;
                mael = Game.instance.model.GetTowerFromId("TackShooter-040").GetBehavior<AbilityModel>();


                for (int i = 0; i < models.Count; i++)
                {
                    var tower = models[i];
                    if (tower.name.ToLower().Contains("helipilot")) continue;
                    if (tower.name.ToLower().Contains("monkeyace")) continue;
                    //Console.WriteLine(tower.name);


                    try
                    {
                        if (tower.HasBehavior<AttackModel>())// && tower.GetBehavior<AttackModel>().weapons[0].projectile.HasBehavior<TravelStraitModel>()
                        {
                            var temp = mael.Duplicate();
                            bool modified = false;
                            foreach (var proj in tower.GetBehavior<AttackModel>().GetAllProjectiles())
                            {
                                if (proj.HasBehavior<TravelStraitModel>() || tower.name.ToLower().Contains("boomer"))
                                {
                                    var cloned = temp.GetBehavior<ActivateAttackModel>().attacks[0].weapons[0].Duplicate();
                                    cloned.projectile = proj.Duplicate();

                                    if (!modified)
                                    {
                                        temp.GetBehavior<ActivateAttackModel>().attacks[0].weapons = new UnhollowerBaseLib.Il2CppReferenceArray<Assets.Scripts.Models.Towers.Weapons.WeaponModel>(0);
                                    }

                                    temp.GetBehavior<ActivateAttackModel>().attacks[0].AddWeapon(cloned);//weapons[0].projectile = proj.Duplicate();
                                    modified = true;


                                }
                            }
                            if (modified)
                            {
                                tower.AddBehavior(temp);
                            }




                        }
                    }
                    catch {
                        //Console.WriteLine(tower.name + " failed");
                    }





                }

            }
        }



        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {

            }
        }








    }

}