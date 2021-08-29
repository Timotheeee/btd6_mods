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
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using System.Collections.Generic;
using System.Linq;
using Assets.Main.Scenes;
using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Simulation.Towers.Pets;
using UnityEngine;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Models.Bloons.Behaviors;
using BTD_Mod_Helper;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using System.Text.RegularExpressions;
using Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Assets.Scripts.Models.Map;

namespace btd6ai
{
    public class Main : BloonsTD6Mod
    {

        public static System.Random random = new System.Random();

        static string hero = TowerType.Sauda;
        static List<string> allowedTowers = new List<string>()
        {
            TowerType.NinjaMonkey + "-302",
            TowerType.Druid + "-220",
            TowerType.BoomerangMonkey + "-024",
            TowerType.BoomerangMonkey + "-052",
            TowerType.NinjaMonkey + "-402",
            TowerType.NinjaMonkey + "-204",
            TowerType.NinjaMonkey + "-040",
            TowerType.Alchemist + "-300",
            TowerType.BoomerangMonkey + "-402",
            TowerType.BoomerangMonkey + "-302",
            TowerType.BoomerangMonkey + "-502",
            TowerType.BombShooter + "-203",
            TowerType.BombShooter + "-204",
            TowerType.BombShooter + "-031",
            TowerType.GlueGunner + "-023",
            TowerType.WizardMonkey + "-032",
            TowerType.WizardMonkey + "-022",
            TowerType.WizardMonkey + "-024",
            TowerType.WizardMonkey + "-025",
            TowerType.WizardMonkey + "-003",
            TowerType.IceMonkey + "-024",
            TowerType.IceMonkey + "-205",
            //TowerType.TackShooter + "-205",
            //TowerType.TackShooter + "-204",
            TowerType.HeliPilot + "-230",
            TowerType.SuperMonkey + "-203",
            //TowerType.SuperMonkey + "-201",
            TowerType.SuperMonkey + "-302",
            TowerType.SniperMonkey + "-110",
            //TowerType.SniperMonkey + "-025",
            TowerType.SniperMonkey + "-420",
            TowerType.SpikeFactory + "-320",
            TowerType.SpikeFactory + "-205",
            TowerType.SpikeFactory + "-240",
            TowerType.MonkeyVillage + "-210",
            TowerType.MonkeyAce + "-520",
            TowerType.MonkeyAce + "-203",
            TowerType.MonkeyAce + "-420",
            TowerType.MonkeyAce + "-250",
            TowerType.MortarMonkey + "-023",
            TowerType.SniperMonkey,
            TowerType.DartMonkey,
            //TowerType.BombShooter,
            TowerType.Alchemist,
            TowerType.NinjaMonkey,
            hero,
            //TowerType.IceMonkey,
            //TowerType.TackShooter,
            //TowerType.EngineerMonkey,
            TowerType.SpikeFactory,
            //TowerType.MonkeySub + "-203",
        };

        static Dictionary<string, int> towersPlaced = new Dictionary<string, int>();

        static bool towerPlaced = false;
        static Il2CppSystem.Action<bool> callbackTowerPlaced = (Il2CppSystem.Action<bool>)delegate (bool s)
        {
            //Console.WriteLine(s);
            towerPlaced = s;
        };
        static Il2CppSystem.Action<bool> callbackUpgraded = (Il2CppSystem.Action<bool>)delegate (bool s)
        {
            //Console.WriteLine(s);
        };
        static bool AIactive = false;
        static int generation = 1;
        static int selectedNet = 0;

        static int networkCount = 15;
        static List<NeuralNetwork> networks = new List<NeuralNetwork>();

        //static int mapXsize = 175;
        //static int mapYsize = 120;
        //static int tilesX = 5;
        //static int tilesY = 4;
        //static int tileXsize = mapXsize / tilesX;
        //static int tileYsize = mapYsize / tilesY;
        //static int tilesCount = tilesX * tilesY;
        static int mapSectionsCount = 8;

        static int initialOutputSize = 5 + mapSectionsCount;
        static int[] networkSize = new int[] { 11, 30, 50, initialOutputSize };//gets increased below

        static (string, (float, float)[]) nextAction = ("", new (float, float)[] { });

        static float MutationChance = 0.01f;

        static float MutationStrength = 0.4f;

        static string savePath = "Mods/btd6AI/";

        static TowerToSimulation upgradeTarget;
        static bool placedBaseTower = false;

        static float getCash()
        {
            return (float)InGame.instance.bridge.simulation.cashManagers.entries[0].value.cash.Value;
        }

        public override void OnTitleScreen()
        {
            base.OnTitleScreen();
            Console.WriteLine("fixing costs");
            foreach (var tower in Game.instance.model.towers)
            {
                if (tower.name.Contains("-"))
                {
                    float cost = tower.cost;
                    foreach (var up in tower.appliedUpgrades)
                    {
                        cost += Game.instance.model.upgradesByName[up].cost;
                    }
                    tower.cost = cost;
                }
                tower.cost *= 1.07f;//hard mode
                if (tower.name.Contains(TowerType.SniperMonkey) || tower.name.Contains(TowerType.GlueGunner))
                {
                    tower.GetBehavior<AttackModel>().RemoveBehavior<TargetFirstModel>();
                    tower.GetBehavior<AttackModel>().RemoveBehavior<TargetLastModel>();
                    tower.GetBehavior<AttackModel>().RemoveBehavior<TargetCloseModel>();
                }
                if (Regex.IsMatch(tower.name, TowerType.HeliPilot + "-2.."))
                {
                    //tower.TargetTypes[0].id = "Pursuit";
                    foreach (var att in tower.GetAttackModels())
                    {
                        att.RemoveBehavior<PatrolPointsSettingModel>();
                        att.RemoveBehavior<LockInPlaceSettingModel>();
                        att.RemoveBehavior<FollowTouchSettingModel>();
                    }
                }
            }
        }

        static void resetTowerCount()
        {
            towersPlaced = new Dictionary<string, int>();
            foreach (var t in allowedTowers)
            {
                towersPlaced.Add(t, 0);
            }
        }

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("btd6ai loaded");

            //each tower gets its own output neuron
            //networkSize[0] += allowedTowers.Count;
            networkSize[3] += allowedTowers.Count;

            for (int i = 0; i < networkCount; i++)
            {
                //init the networks randomly
                networks.Add(new NeuralNetwork(networkSize));
            }
            resetTowerCount();

        }
        static void useAllAbilities()
        {
            foreach (var ab in InGame.instance.bridge.GetAllAbilities(false))
            {
                try
                {
                    ab.Activate();
                }
                catch { }
            }
        }

        static float randomf()
        {
            return ((float)random.NextDouble() - 0.5f) * 2;
        }

        //WARNING: always uses medium mode prices and ignores MK
        static void spawnTower((float, float)[] coords, string id)
        {
            //Console.WriteLine("called spawntower with " + id);
            TowerModel t = Game.instance.model.GetTowerFromId(id);
            if (t.cost > getCash())
            {
                //Console.WriteLine("too expensive");
                return;
            }



            for (int position = 0; position < coords.Length; position++)
            {
                int attempts = 0;
                float x = coords[position].Item1;
                float y = coords[position].Item2;
                //Console.WriteLine("attempting to place " + id + " at " + x + ", " + y);
                while (!towerPlaced && attempts < 500)
                {

                    try
                    {

                        //float expensiveMultiplier = t.cost > 10000 && attempts > 150 ? 2 : 1;
                        float accuracyMultiplier = 1;
                        if (attempts < 5) accuracyMultiplier = 0.0f;
                        if (attempts < 10) accuracyMultiplier = 0.02f;
                        if (attempts < 20) accuracyMultiplier = 0.03f;
                        if (attempts < 40) accuracyMultiplier = 0.07f;
                        if (attempts < 60) accuracyMultiplier = 0.15f;
                        if (attempts < 100) accuracyMultiplier = 0.30f;
                        if (attempts < 150) accuracyMultiplier = 0.40f;
                        if (attempts < 200) accuracyMultiplier = 0.50f;
                        float x2 = x + randomf() * 40 * accuracyMultiplier;// * expensiveMultiplier;
                        float y2 = y + randomf() * 40 * accuracyMultiplier;// * expensiveMultiplier;
                        InGame.instance.bridge.CreateTowerAt(new UnityEngine.Vector2(x2, y2), t, -1, 0, false, callbackTowerPlaced);
                        //Console.WriteLine("nudged");


                    }
                    catch// (System.Exception e2)
                    {
                        //System.Console.WriteLine(e2 + "");

                    }
                    attempts++;
                }
            }
            if (towerPlaced == false)
            {
                Console.WriteLine("FAILED TO PLACE TOWER " + id);
                //placedBaseTower = false;
                //upgradeTarget = null;
                spawnTower(coords, id);
            }

            towerPlaced = false;
        }

        static bool restart = false;
        static int startNextRound = 99;
        static bool gameEnded = false;
        static float abilityTimer = 0;
        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (AIactive)
                {
                    abilityTimer += UnityEngine.Time.deltaTime;
                    if (abilityTimer > 10)
                    {
                        abilityTimer = 0;
                        useAllAbilities();
                    }
                    if (nextAction.Item1 != "")
                    {
                        //place down the base tower if it hasn't been placed
                        if (!placedBaseTower)
                        {
                            string baseTower = Game.instance.model.GetTowerFromId(nextAction.Item1).baseId;
                            float cost = Game.instance.model.GetTowerWithName(baseTower).cost;
                            //Console.WriteLine("saving up to buy " + baseTower + " (costs " + cost + ")" + " (target is " + nextAction.Item1 + ")");
                            
                            //for some reason, it sometimes tries to place down towers while missing 0.5 dollars. increasing the cost in the if statement prevents it from placing sauda as she costs 650
                            if (cost+2 <= getCash() || nextAction.Item1 == hero)
                            {
                                //Console.WriteLine("got enough money, placing base tower");
                                spawnTower(nextAction.Item2, baseTower);
                                //Console.WriteLine("placed");
                                placedBaseTower = true;
                                foreach (var tower in InGame.instance.GetAllTowerToSim())
                                {
                                    upgradeTarget = tower;
                                }
                                //Console.WriteLine(upgradeTarget.tower.model.name);
                            }

                        } else if(nextAction.Item1.Contains("-"))//upgrade it if needed
                        {
                            //Console.WriteLine("buying upgrades up to " + nextAction.Item1 + " for " + upgradeTarget.tower.model.name);
                            var targetTiers = Game.instance.model.GetTowerWithName(nextAction.Item1).tiers;
                            var currentTiers = upgradeTarget.tower.model.Cast<TowerModel>().tiers;
                            if(targetTiers[0] > currentTiers[0]) upgradeTarget.Upgrade(0, false, callbackUpgraded);
                            if(targetTiers[1] > currentTiers[1]) upgradeTarget.Upgrade(1, false, callbackUpgraded);
                            if(targetTiers[2] > currentTiers[2]) upgradeTarget.Upgrade(2, false, callbackUpgraded);

                        }

                        if (upgradeTarget != null && upgradeTarget.tower.model.name == nextAction.Item1) {
                            nextAction.Item1 = "";
                            placedBaseTower = false;
                            upgradeTarget = null;
                            //Console.WriteLine("tower successfully upgraded to target tiers");
                        }


                    }
                    if (nextAction.Item1 == "")
                    {
                        Step();
                    }

                }

                if (restart)
                {
                    InGame.instance.bridge.Restart();
                    startNextRound = 0;
                    restart = false;
                    gameEnded = false;
                    nextAction.Item1 = "";
                    placedBaseTower = false;
                    upgradeTarget = null;
                }
                startNextRound++;
                if (startNextRound == 200)
                {
                    InGame.instance.bridge.StartRound();
                }
                if (startNextRound == 220)
                {
                    InGame.instance.bridge.SetFastForward(true);
                }

                //Console.WriteLine(InGame.instance.bridge.GetCurrentRound() + ", " + (InGame.instance.bridge.GetEndRound() - 1));

                //victory
                if (InGame.instance.bridge.GetCurrentRound() == InGame.instance.bridge.GetEndRound() - 1)
                {
                    NextRound(true);
                }

                if (Input.GetKeyDown(KeyCode.F1))
                {
                    for (int i = 0; i < networkCount; i++)
                    {
                        networks[i].Load(savePath + "Save" + i + ".txt");
                    }
                    //SortNetworks();
                    Console.WriteLine("loaded from file");
                }

                if (Input.GetKeyDown(KeyCode.F2))
                {

                    AIactive = !AIactive;
                    Console.WriteLine("active: " + AIactive);
                }

                if (Input.GetKeyDown(KeyCode.F3))
                {
                    Step();

                }
                if (Input.GetKeyDown(KeyCode.F4))
                {
                    
                    foreach (var tower in InGame.instance.GetAllTowerToSim())
                    {
                        upgradeTarget = tower;
                    }
                    upgradeTarget.Upgrade(1, false, callbackUpgraded);
                    Console.WriteLine(upgradeTarget.tower.model.Cast<TowerModel>().tiers[0]);
                    Console.WriteLine(upgradeTarget.tower.model.Cast<TowerModel>().tiers[1]);
                    Console.WriteLine(upgradeTarget.tower.model.Cast<TowerModel>().tiers[2]);
                }

                //if (Input.GetKeyDown(KeyCode.F5))
                //{
                //    Console.WriteLine("restarting");
                //    InGame.instance.bridge.Restart();

                //}

                if (Input.GetKeyDown(KeyCode.F6))
                {
                    Console.WriteLine("calling abilities");
                    useAllAbilities();

                }

            }
        }

        //take a number and convert it so it goes from -1 to 1 
        static float Convert(float v)
        {
            return (Mathf.Clamp(v, 0f, 1f) - 0.5f) * 2;
        }

        //runs the AI one time
        static void Step()
        {
            //********** collect inputs and give them to the AI **************
            int round = InGame.instance.bridge.GetCurrentRound();
            int roundcategory = Mathf.RoundToInt(round * 0.1f);
            //float cash = getCash();

            float[] input = new float[networkSize[0]];
            for (int i = 0; i <= 10; i++)
            {
                input[i] = roundcategory == i ? 1 : -1;
            }
            //input[11] = Convert(cash / 20000f);
            //input[11] = (float)(random.NextDouble() - 0.5f) * 2;


            //int inpIndex = 13;
            //foreach (var pair in towersPlaced)
            //{
            //    input[inpIndex] = Convert(pair.Value / 5f);
            //    inpIndex++;
            //}

            //Console.WriteLine(string.Join(", ", input));


            /*
             *  collect the Ai's output and process them 
             *  
             */

            float[] output = networks[selectedNet].FeedForward(input);


            //the map is divided into 9 tiles, we take the Ai's favorite one, unless there is no space left
            //float max = -10;
            //int selectedTile = -1;
            //for (int i = 0; i < 9; i++)
            //{
            //    if (output[i] > max)
            //    {
            //        max = output[i];
            //        selectedTile = i;
            //    }
            //}
            //Console.WriteLine("initialOutputSize: " + initialOutputSize);
            List<(int, float)> mapSections = new List<(int, float)>();
            List<(float, float)> coords = new List<(float, float)>();
            for (int i = 0; i < mapSectionsCount; i++)
            {
                mapSections.Add((i, output[i]));
            }
            //Console.WriteLine("tiles count: " + tiles.Count);
            mapSections.Sort(delegate ((int, float) a, (int, float) b)
            {
                return a.Item2 < b.Item2 ? 1 : -1;
            });

            foreach (var section in mapSections)
            {
                int index = (path.Count / (mapSectionsCount + 1)) * (section.Item1 + 1);
                float x = path[index].point.x;
                float y = path[index].point.y;
                coords.Add((x, y));
            }
            //Console.WriteLine("coords count: " + coords.Count);
            //for (int i = 0; i < tiles.Count; i++)
            //{
            //    Console.WriteLine(tiles[i].Item1 + ": " + tiles[i].Item2);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < coords.Count; i++)
            //{
            //    Console.WriteLine(coords[i].Item1 + "," + coords[i].Item2);
            //}

            //Console.WriteLine("selected tile: " + selectedTile + ", " + "x & y: " + x + ", " + y);

            //the range's id, and the value the ai gave it
            List<(int, float)> ranges = new List<(int, float)>();
            //Console.WriteLine("tilesCount " + tilesCount);
            //Console.WriteLine("initialOutputSize " + initialOutputSize);
            for (int i = mapSectionsCount; i < initialOutputSize; i++)
            {
                ranges.Add((i - mapSectionsCount, output[i]));
            }
            ranges.Sort(delegate ((int, float) a, (int, float) b)
            {
                return a.Item2 < b.Item2 ? 1 : -1;
            });

            //Console.WriteLine("ranges count: " + ranges.Count);

            //Console.WriteLine("ordered");
            //for (int i = 0; i < ranges.Count; i++)
            //{
            //    Console.WriteLine(ranges[i].Item1 + ": " + ranges[i].Item2);
            //}

            //select the tower
            float max = -10;
            string towerToPlace = "";
            for (int rangeIndex = 0; rangeIndex < ranges.Count - 1; rangeIndex++)
            {
                int selectedPriceRange = ranges[rangeIndex].Item1;
                max = -10;
                for (int i = 0; i < allowedTowers.Count; i++)
                {
                    int index = i + initialOutputSize;
                    //check the price range
                    bool correctPriceRange = false;
                    var cost = Game.instance.model.GetTowerWithName(allowedTowers[i]).cost;
                    if (selectedPriceRange == 0) { correctPriceRange = cost < 650; }
                    if (selectedPriceRange == 1) { correctPriceRange = cost > 650 && cost < 5000; }
                    if (selectedPriceRange == 2) { correctPriceRange = cost > 5000 && cost < 10000; }
                    if (selectedPriceRange == 3) { correctPriceRange = cost > 10000 && cost < 20000; }
                    if (selectedPriceRange == 4) { correctPriceRange = cost > 20000; }

                    //queue the tower the AI wants to place the most, within the price range, with a limit of 4 per tower
                    if (correctPriceRange && output[index] > max && towersPlaced[allowedTowers[i]] <= 3 && output[index] > 0.5 && !((allowedTowers[i].Contains("5") || allowedTowers[i] == hero) && towersPlaced[allowedTowers[i]] == 1))
                    {
                        max = output[index];
                        towerToPlace = allowedTowers[i];
                    }
                }
                if (towerToPlace != "") break;
            }

            //cheating to speed up the mess that is round 6
            if (InGame.instance.bridge.GetCurrentRound() == 5 && getCash() > 300) towerToPlace = hero;
            
            //towerToPlace = "MortarMonkey-023";

            nextAction = (towerToPlace, coords.ToArray());
            towersPlaced[towerToPlace]++;

            

            Console.WriteLine("net " + selectedNet + " (gen " + generation + ") tower: " + towerToPlace + " " + coords[0] + " section " + mapSections[0].Item1);


        }


        static void NextRound(bool victory)
        {
            if (gameEnded == true) return;
            gameEnded = true;

            resetTowerCount();

            if (victory)
            {
                networks[selectedNet].fitness = 1000 + getCash();
                Console.WriteLine("this network won, fitness is:" + networks[selectedNet].fitness);
            }
            else
            {
                networks[selectedNet].fitness = InGame.instance.bridge.GetCurrentRound();
                Console.WriteLine("this network lost, fitness is:" + networks[selectedNet].fitness);
            }
            selectedNet++;
            if (selectedNet >= networkCount)
            {
                SortNetworks();//create the next generation
                selectedNet = 0;
                generation++;
            }

            //this took ages to figure out, the game crashes if you restart too quickly and also crashes if you restart from another thread
            Il2CppSystem.Action action = (Il2CppSystem.Action)delegate ()
            {
                //Console.WriteLine("restarting soon");
                Thread.Sleep(1000);
                Main.restart = true;

            };

            Task.Run(action);



        }




        static void SortNetworks()
        {

            //index 0 means the worst
            networks.Sort();


            Console.WriteLine("networks finished one gen, scores:");
            for (int i = 0; i < networks.Count; i++)
            {
                Console.WriteLine(i + ": " + networks[i].fitness);
            }

            List<NeuralNetwork> networkstemp = new List<NeuralNetwork>();

            for (int i = 0; i < 3; i++)
                networkstemp.Add(networks[networkCount - 1].copy(new NeuralNetwork(networkSize)));

            for (int i = 0; i < 2; i++)
                networkstemp.Add(networks[networkCount - 2].copy(new NeuralNetwork(networkSize)));

            //for (int i = 0; i < 1; i++)
            //    networkstemp.Add(networks[networkCount - 3].copy(new NeuralNetwork(networkSize)));

            //for (int i = 0; i < 1; i++)
            //    networkstemp.Add(networks[networkCount - 4].copy(new NeuralNetwork(networkSize)));

            for (int i = 3; i < 13; i++)
                networkstemp.Add(networks[networkCount - i].copy(new NeuralNetwork(networkSize)));

            Console.WriteLine("created next gen with " + networkstemp.Count + " networks");

            networks = networkstemp;


            //mutate all except best
            for (int i = 0; i < networkCount - 1; i++)
            {
                //networks[i] = networks[i].copy(new NeuralNetwork(layers));
                networks[i].Mutate((int)(1 / MutationChance), MutationStrength);
            }

            for (int i = 0; i < networkCount; i++)
            {
                networks[i].Save(savePath + "Save" + i + ".txt");//save them all
            }


        }


        static new UnhollowerBaseLib.Il2CppReferenceArray<PointInfo> path;

        [HarmonyPatch(typeof(UnityToSimulation), nameof(UnityToSimulation.InitMap))]
        internal class InitMap_Patch
        {
            [HarmonyPrefix]
            internal static bool Prefix(UnityToSimulation __instance, ref MapModel map)
            {
                path = map.paths[0].points;
                return true;
            }
        }


        //doesn't work in challenge editor
        //public override void OnVictory()
        //{
        //    NextRound(true);
        //    base.OnVictory();
        //}

        public override void OnDefeat()
        {
            NextRound(false);
            base.OnDefeat();
        }

    }

}