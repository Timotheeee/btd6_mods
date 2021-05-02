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
using Assets.Scripts.Models;
using Assets.Scripts.Models.Bloons;
using Il2CppSystem.Collections.Generic;
using Assets.Scripts.Unity.Menu;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Weapons;
using Assets.Scripts.Models.Rounds;
using UnhollowerBaseLib;
using System.Linq;
using Assets.Scripts.Unity.UI_New.Races;
using Assets.Scripts.Models.Store;
using Assets.Scripts.Models.Store.Loot;
using Assets.Scripts.Unity.Gift;
using System.Text.RegularExpressions;
using Il2CppSystem;
using System;
using Assets.Scripts.Unity.Analytics;
using Assets.Scripts.Simulation.Towers.Projectiles;
using UnhollowerRuntimeLib;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models.Towers.Behaviors;
using UnityEngine;
using Assets.Scripts.Unity.UI_New.Popups;

namespace twitchcontrols
{
    public class Main : MelonMod
    {
        public static string[] effects = {
            "Give 500 cash",
            "Send next round early",
            "Send next 3 rounds early",
            "Lose 40% of cash",
            "Sell random tower",
            "Sell half of the towers",
            "lose 10% of cash",
            "move a random tower by 20 to 60 units",
            "move all towers by 20 to 60 units",
            "each type of bloon gets a random speed",//9
            "make bloons 3x as fast for 30 seconds",
            "make bloons 0.5x as fast for 55 seconds",
            "towers spin for 55 seconds",
            "nothing",
            "reset all cooldowns",
            "change all tower targeting to last",
            "delete all bloons on screen",
            "all bloons are camgrow fortified for 60s",
            "bloons are randomly stronger (25s)",
            "reset lives",
            "new towers turn to cave monkeys (40s)",
            "new towers turn to cold sentries (40s)",
            "new towers turn to energising totems (20s)",
            "new towers turn to portable lakes (20s)",
            "towers look at player",//24
            "towers are 2D",
            "towers are ants",
            "towers shoot half as fast for 20s",//27
            "blind for 20s",//28
            "every tower spins like a plane for 30s",//29
            "spawn sentries with left click for 15s",//30
            "teleport everything to the mouse (30s)",//31
            "camera spins (50s)",//32
            "spawn villages everywhere",//33

        };
        public static int prevChat = 0;

        public static string prevEffect = "nothing";
        public static string[] options = { "nothing", "Give 500 cash", "Send next round early" };
        public static int[] votes = { 0, 0, 0 };
        public static float voteTimer = 60;
        public static float voteTimerMax = 60;

        public static float getChatTimer = 0;
        public static System.Random random = new System.Random();
        static string chatFile = System.Environment.CurrentDirectory + @"\twitchchat.txt";

        string[] chat = { "" };

        static bool twitchMode = false;

        static string[] canBeSold = new string[] {
                                    "Dart",
                                    "Boomerang",
                                    "BombShooter",
                                    "TackShooter",
                                    "Ice",
                                    "GlueGunner",
                                    "Sniper",
                                    "Sub",
                                    "Buccaneer",
                                    "Ace",
                                    "HeliPilot",
                                    "Wizard",
                                    "Super",
                                    "Ninja",
                                    "Alchemist",
                                    "Druid",
                                    "SpikeFactory",
                                    "MonkeyVillage",
                                    "Engineer",
                                    "Etienne",
                                    "Quincy",
                                    "Etienne",
                                    "StrikerJones",
                                    "ObynGreenfoot",
                                    "Gwendolin",
                                    "Adora",
                                    "Benjamin",
                                    "AdmiralBrickell",
                                    "PatFusty",
                                    "Ezili",
                                    "PatFusty",
                                    "CaveMonkey",
                                    "EnergisingTotem",
                                    "PortableLake",
                                };

        public static float grieferTimer = 0;
        public static string selectedHero = "";
        static float planeAngle;
        static bool debug = false;
        static float camDist = 30f;
        static Vector3 camPos = new Vector3(-150, 0, -150);
        static float camAngle = 0;

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            System.Console.WriteLine("twitchcontrols mod loaded");
            try
            {
                System.IO.File.WriteAllText(chatFile, "");
            }
            catch
            {

            }
            debug = System.IO.File.Exists(System.Environment.CurrentDirectory + @"\debug.txt");
            System.Console.CursorVisible = false;

        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;

            //this was a pain to add
            if (Input.GetMouseButtonDown(0) && inAGame && prevEffect == effects[30] && voteTimer < 15)
            {
                var v3 = Input.mousePosition;
                v3.z = camDist;
                v3 = InGame.instance.sceneCamera.ScreenToWorldPoint(v3);

                spawnTower(v3.x, TowerType.Sentry);
                towerPlaced = false;

            }


            if (inAGame)
            {
                voteTimer += UnityEngine.Time.deltaTime;
                getChatTimer += UnityEngine.Time.deltaTime;
                grieferTimer += UnityEngine.Time.deltaTime;
                foreach (var item in InGame.instance.bridge.GetPlayerHeroes())
                {
                    selectedHero = item.Value;
                }
            }
            else
            {
                System.Console.WriteLine("get in a game to start the chaos mod");
                prevEffect = "none";
                options[0] = "nothing";
                voteTimer = voteTimerMax;
            }
            if (grieferTimer > 0.1f)
            {
                grieferSpawning = false;
                grieferPlaced = false;
            }


            //towers shoot half as fast for 20s, credit to hemidemisemipresent
            if (prevEffect == effects[27] && voteTimer < 10)
            {
                foreach (TowerToSimulation towerToSimulation in InGame.instance.bridge.GetAllTowers())
                {
                    StartOfRoundRateBuffModel rateBuffSORModel = new Assets.Scripts.Models.Towers.Behaviors.StartOfRoundRateBuffModel("69", 2f, 500000000000);
                    BehaviorMutator rateBuffModel = new Assets.Scripts.Models.Towers.Behaviors.StartOfRoundRateBuffModel.RateMutator(rateBuffSORModel);
                    towerToSimulation.tower.AddMutator(rateBuffModel, 600, true, true, false, true, false, false);
                }
                //prevEffect += " (applied)";
            }
            //camera spins
            if (prevEffect == effects[32] && voteTimer < 50)
            {
                var delta = UnityEngine.Time.deltaTime;
                var change1 = UnityEngine.Mathf.Sin(camAngle) * 3f * (delta * 60);
                var change2 = UnityEngine.Mathf.Cos(camAngle) * 3f * (delta * 60);
                camPos += new Vector3(change1, change2, change2);
                InGame.instance.sceneCamera.transform.position = camPos;
                camAngle += delta * 0.55f;
                camAngle %= (3.1415f * 2);
                InGame.instance.sceneCamera.transform.LookAt(new UnityEngine.Vector3(0, 0, 0));
            }
            if (prevEffect == effects[32] && voteTimer > 50)
            {
                InGame.instance.sceneCamera.transform.position = new UnityEngine.Vector3(0, 0, 0);
                InGame.instance.sceneCamera.transform.rotation = UnityEngine.Quaternion.Euler(60, 0, 0);
            }
            //teleport everything to mouse
            if (prevEffect == effects[31] && voteTimer < 30)
            {
                var v3 = UnityEngine.Input.mousePosition;
                v3 = InGame.instance.sceneCamera.ScreenToWorldPoint(v3);
                var towers = InGame.instance.bridge.GetAllTowers();
                foreach (var tower in towers)
                {
                    float x = v3.x;
                    float y = v3.y * -2.3f;
                    tower.tower.PositionTower(new Assets.Scripts.Simulation.SMath.Vector2(x, y));
                }
            }
            else if (prevEffect == effects[31] && voteTimer > 30)
            {
                prevEffect += " (done)";
                MoveAllTowers();
            }
            //towers spin like a plane
            if (prevEffect == effects[29] + " (started)" && voteTimer < (voteTimerMax - 26))
            {
                var towers = InGame.instance.bridge.GetAllTowers();
                var delta = UnityEngine.Time.deltaTime;
                var change1 = Mathf.Sin(planeAngle) * 0.6f * (delta * 60);
                var change2 = Mathf.Cos(planeAngle) * 0.6f * (delta * 60);
                foreach (var tower in towers)
                {
                    float x = tower.position.x + change1;
                    float y = tower.tower.Node.position.Y - change2;
                    tower.tower.PositionTower(new Assets.Scripts.Simulation.SMath.Vector2(x, y));
                }
                planeAngle += delta * 0.55f;
                planeAngle %= (3.1415f * 2);
            }

            //towers spin
            if (prevEffect == effects[12] && voteTimer < (voteTimerMax - 5))
            {
                var towers = InGame.instance.bridge.GetAllTowers();
                foreach (var tower in towers)
                {
                    tower.tower.RotateTower(5, false);
                }
            }
            //reset 3x speed
            if (prevEffect == effects[10] && voteTimer > (voteTimerMax - 30))
            {
                var models = InGame.instance.bridge.Model.bloons;
                foreach (var model in models)
                {
                    model.Speed /= 3;
                }
                prevEffect += " (done)";
            }
            //reset 0.5x speed
            if (prevEffect == effects[11] && voteTimer > (voteTimerMax - 5))
            {
                var models = InGame.instance.bridge.Model.bloons;
                foreach (var model in models)
                {
                    model.Speed /= 0.5f;
                }
                prevEffect += " (done)";
            }
            //reset each bloon gets a random speed
            if (prevEffect == effects[9] && voteTimer > 55)
            {
                var orig = Game.instance.model.bloons;
                var models = InGame.instance.bridge.Model.bloons;
                var i = 0;
                foreach (var model in models)
                {
                    model.speed = orig[i].speed;
                    i++;
                }
                prevEffect += " (done)";
            }

            //spawn villages
            if (prevEffect == effects[33] && voteTimer < 3)
            {
                var x = ((float)random.NextDouble() - 0.5f) * 300f;
                spawnTower(x, TowerType.MonkeyVillage);
            }


            if (getChatTimer > 3.8)
            {
                if (twitchMode)
                    try
                    {
                        chat = System.IO.File.ReadAllLines(chatFile);
                    }
                    catch
                    {

                    }

                for (var i = prevChat; i < chat.Length; i++)
                {
                    var line = chat[i];
                    if (line == "1") votes[0]++;
                    if (line == "2") votes[1]++;
                    if (line == "3") votes[2]++;
                }
                prevChat = chat.Length;

                if (voteTimer > voteTimerMax)
                {
                    if (votes[0] >= votes[1] && votes[0] >= votes[2])
                    {
                        prevEffect = options[0];
                    }
                    else if (votes[1] >= votes[0] && votes[1] >= votes[2])
                    {
                        prevEffect = options[1];
                    }
                    else
                    {
                        prevEffect = options[2];
                    }
                    //one time effects go here
                    try
                    {
                        //add 500 cash
                        if (prevEffect == effects[0])
                        {
                            InGame.instance.bridge.AddCash(500, Simulation.CashSource.Normal);
                        }
                        //start next round
                        if (prevEffect == effects[1])
                        {
                            InGame.instance.bridge.StartRaceRound();
                        }
                        //start next 3 rounds
                        if (prevEffect == effects[2])
                        {
                            InGame.instance.bridge.StartRaceRound();
                            InGame.instance.bridge.StartRaceRound();
                            InGame.instance.bridge.StartRaceRound();
                        }
                        //cash * 0.6
                        if (prevEffect == effects[3])
                        {
                            var cash = InGame.instance.bridge.GetCash() * 0.6;
                            InGame.instance.bridge.SetCash(cash);
                        }
                        //sell random tower
                        if (prevEffect == effects[4])
                        {
                            SellRandomTower();

                        }
                        //sell half of the towers
                        if (prevEffect == effects[5])
                        {
                            //var a = TowerUtils.GetTower(TowerType.PortableLake);

                            int sold = 0;
                            var towers = InGame.instance.bridge.GetAllTowers();
                            foreach (var t in towers)
                            {
                                var name = Regex.Replace(t.tower.namedMonkeyKey, @"\d+", "");
                                name = name.Replace("Monkey", "");
                                System.Console.WriteLine(name);
                                if (canBeSold.Contains(name) && sold < towers.Count * 0.5)
                                {
                                    InGame.instance.SellTower(t);
                                    sold++;
                                }

                            }

                        }
                        //cash * 0.9
                        if (prevEffect == effects[6])
                        {
                            var cash = InGame.instance.bridge.GetCash() * 0.9;
                            InGame.instance.bridge.SetCash(cash);
                        }
                        //move random tower
                        if (prevEffect == effects[7])
                        {
                            var towers = InGame.instance.bridge.GetAllTowers();
                            var tower = towers[random.Next(0, towers.Count)];
                            float x = tower.position.x + (float)((random.NextDouble() > 0.5 ? 1 : -1) * (20 + (random.NextDouble() * 40)));
                            float y = tower.tower.Node.position.Y + (float)((random.NextDouble() > 0.5 ? 1 : -1) * (20 + (random.NextDouble() * 40)));
                            tower.tower.PositionTower(new Assets.Scripts.Simulation.SMath.Vector2(x, y));
                        }
                        //move all towers
                        if (prevEffect == effects[8])
                        {
                            MoveAllTowers();
                        }
                        //each bloon gets a random speed
                        if (prevEffect == effects[9])
                        {
                            var models = InGame.instance.bridge.Model.bloons;
                            foreach (var model in models)
                            {
                                if (model.baseId != "Bfb" && model.baseId != "Zomg" && model.baseId != "Ddt" && model.baseId != "Bad")
                                    model.Speed = (((float)random.NextDouble()) * 95) + 40;
                            }
                        }
                        //3x speed
                        if (prevEffect == effects[10])
                        {
                            var models = InGame.instance.bridge.Model.bloons;
                            foreach (var model in models)
                            {
                                model.Speed *= 3;
                            }
                        }
                        //half speed
                        if (prevEffect == effects[11])
                        {
                            var models = InGame.instance.bridge.Model.bloons;
                            foreach (var model in models)
                            {
                                model.Speed *= 0.5f;
                            }
                        }
                        //towers spin happens each frame
                        if (prevEffect == effects[12])
                        {

                        }
                        //nothing effect
                        if (prevEffect == effects[13])
                        {

                        }
                        //reset all cooldowns
                        if (prevEffect == effects[14])
                        {
                            InGame.instance.bridge.ResetAbilityCooldowns(false);
                        }
                        //targeting to last
                        if (prevEffect == effects[15])
                        {
                            foreach (var t in InGame.instance.bridge.GetAllTowers())
                            {
                                string[] valid = new string[] {
                                    "Dart",
                                    "Boomerang",
                                    "BombShooter",
                                    "GlueGunner",
                                    "Sniper",
                                    "Sub",
                                    "Buccaneer",
                                    "Wizard",
                                    "Super",
                                    "Ninja",
                                    "Alchemist",
                                    "Druid",
                                    "Engineer",
                                };
                                var name = Regex.Replace(t.tower.namedMonkeyKey, @"\d+", "");
                                name = name.Replace("Monkey", "");
                                System.Console.WriteLine(name);
                                if (valid.Contains(name))
                                    t.tower.SetTargetType(TargetType.last);
                            }

                        }
                        //delete all bloons on screen
                        if (prevEffect == effects[16])
                        {
                            InGame.instance.DeleteAllBloons();
                        }
                        //camgrow fortified
                        if (prevEffect == effects[17])
                        {

                        }
                        //bloons randomly upgrade or take no dmg (30s)
                        if (prevEffect == effects[18])
                        {

                        }
                        //reset lives
                        if (prevEffect == effects[19])
                        {
                            InGame.instance.bridge.ResetHealth();
                        }
                        //spawnGriefer
                        if (prevEffect == "spawn Griefer Jones")
                        {
                            spawnGriefer();
                            prevEffect += " (done)";
                        }
                        //reset plane angle
                        if (prevEffect == effects[29])
                        {
                            planeAngle = 0;
                            prevEffect += " (started)";
                        }
                        //camera spin
                        if (prevEffect == effects[32])
                        {
                            camPos = new Vector3(-150, 0, -150);
                            camAngle = 0;
                        }

                        if (prevEffect == "Spawn Ceramic")
                        {
                            Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(1);
                            bme[0] = (new BloonEmissionModel("Ceramic", 1, "Ceramic"));
                            InGame.instance.bridge.SpawnBloons(bme, 38, 0);
                        }
                        if (prevEffect == "Spawn MOAB")
                        {
                            Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(1);
                            bme[0] = (new BloonEmissionModel("Moab", 1, "Moab"));
                            InGame.instance.bridge.SpawnBloons(bme, 40, 0);
                        }
                        if (prevEffect == "Spawn BFB")
                        {
                            Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(1);
                            bme[0] = (new BloonEmissionModel("Bfb", 1, "Bfb"));
                            InGame.instance.bridge.SpawnBloons(bme, 60, 0);
                        }
                        if (prevEffect == "Spawn ZOMG")
                        {
                            Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(1);
                            bme[0] = (new BloonEmissionModel("Zomg", 1, "Zomg"));
                            InGame.instance.bridge.SpawnBloons(bme, 80, 0);
                        }
                        if (prevEffect == "Spawn DDT")
                        {
                            Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(1);
                            bme[0] = (new BloonEmissionModel("Ddt", 1, "Ddt"));
                            InGame.instance.bridge.SpawnBloons(bme, 90, 0);
                        }
                        if (prevEffect == "Spawn BAD")
                        {
                            Il2CppReferenceArray<BloonEmissionModel> bme = new Il2CppReferenceArray<BloonEmissionModel>(1);
                            bme[0] = (new BloonEmissionModel("Bad", 1, "Bad"));
                            InGame.instance.bridge.SpawnBloons(bme, 100, 0);
                        }
                    }
                    catch
                    {
                        prevEffect += " (error)";
                    }



                    voteTimer = 0;
                    votes = new int[] { 0, 0, 0 };

                    string[] temp = new string[effects.Length];
                    effects.CopyTo(temp, 0);
                    var tempEffects = temp.ToList();
                    int round = InGame.instance.bridge.GetCurrentRound();
                    if (round > 10 && round < 40)
                        tempEffects.Add("Spawn Ceramic");
                    if (round > 30)
                        tempEffects.Add("Spawn MOAB");
                    if (round > 45)
                        tempEffects.Add("Spawn BFB");
                    if (round > 65)
                        tempEffects.Add("Spawn ZOMG");
                    if (round > 85)
                        tempEffects.Add("Spawn DDT");
                    if (round > 94)
                        tempEffects.Add("Spawn BAD");
                    if (selectedHero != TowerType.StrikerJones)
                        tempEffects.Add("spawn Griefer Jones");

                    //System.Console.WriteLine(tempEffects.Contains("spawn Griefer Jones"));

                    string[] r = tempEffects.OrderBy(x => random.Next()).ToArray();
                    options[0] = r[0];
                    options[1] = r[1];
                    options[2] = r[2];
                }


                //System.Console.SetCursorPosition(0, 0);
                //System.Console.Clear();
                var sb = new StringBuilder();
                if (twitchMode)
                {
                    sb.AppendLine(" \n \n \n  \n  \n  \n  \n  \n  \n  \n  \n  \n   \n  \n  \n  \n  \n  \n  \n  ");
                    sb.AppendLine("Last effect: " + prevEffect);
                    sb.AppendLine("Option 1: " + options[0] + " (" + votes[0] + " votes)");
                    sb.AppendLine("Option 2: " + options[1] + " (" + votes[1] + " votes)");
                    sb.AppendLine("Option 3: " + options[2] + " (" + votes[2] + " votes)");
                    sb.AppendLine("seconds left to vote: " + (voteTimerMax - voteTimer));
                }
                else
                {
                    sb.AppendLine(" \n \n \n  \n  \n  \n  \n  \n  \n  \n  \n  \n   \n  \n  \n  \n  \n  \n  \n  ");
                    sb.AppendLine("Last effect: " + prevEffect);
                    sb.AppendLine("Next effect: " + options[0]);
                    sb.AppendLine("Timer: " + (voteTimerMax - voteTimer));
                }
                System.Console.Write(sb);



                getChatTimer = 0;

            }


            if (Input.GetKeyDown(KeyCode.F8) && debug)
            {
                //options[0] = effects[29];
                Il2CppSystem.Action<int> deb = (Il2CppSystem.Action<int>)delegate (int eff)
                {
                    if (eff == 1337) getChatTimer = -9999;
                    options[0] = effects[eff];
                };
                PopupScreen.instance.ShowSetValuePopup("Debug mode",
                "which effect ?", deb, 1
                );
            }

            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                twitchMode = true;
                System.Console.WriteLine("Twitch mode activated");
            }


        }

        static void MoveAllTowers()
        {
            var towers = InGame.instance.bridge.GetAllTowers();
            foreach (var tower in towers)
            {
                float x = tower.position.x + (float)((random.NextDouble() > 0.5 ? 1 : -1) * (20 + (random.NextDouble() * 40)));
                float y = tower.tower.Node.position.Y + (float)((random.NextDouble() > 0.5 ? 1 : -1) * (20 + (random.NextDouble() * 40)));
                tower.tower.PositionTower(new Assets.Scripts.Simulation.SMath.Vector2(x, y));
            }
        }

        static void SellRandomTower()
        {
            int sold = 0;
            var towers = InGame.instance.bridge.GetAllTowers();
            foreach (var t in towers)
            {
                var name = Regex.Replace(t.tower.namedMonkeyKey, @"\d+", "");
                name = name.Replace("Monkey", "");
                //System.Console.WriteLine(name);
                //System.Console.WriteLine(canBeSold.Contains(name));
                //System.Console.WriteLine(sold < 1);
                if (canBeSold.Contains(name) && sold < 1)
                {
                    //System.Console.WriteLine("selling");
                    InGame.instance.SellTower(t);
                    sold++;
                }

            }
        }



        static bool grieferSpawning = false;
        static bool grieferPlaced = false;
        static Il2CppSystem.Action<bool> action = (Il2CppSystem.Action<bool>)delegate (bool s)
        {
            grieferPlaced = s;
        };
        static void spawnGriefer()
        {
            grieferTimer = 0;
            grieferSpawning = true;

            int attempts = 0;
            while (!grieferPlaced && attempts < 1000)
            {
                for (int i = -50; i < 200; i++)
                {
                    try
                    {
                        var x = (float)random.NextDouble() * 200;
                        var y = ((float)random.NextDouble() - 0.5f) * 200f;
                        InGame.instance.bridge.CreateTowerAt(new UnityEngine.Vector2(x, y), Game.instance.model.GetTowerFromId(TowerType.DartMonkey), i, true, action);
                        //System.Console.WriteLine(x + " " + y);
                        break;
                    }
                    catch// (System.Exception e2)
                    {
                        //System.Console.WriteLine(e2 + "");

                    }
                }
                attempts++;
            }
        }


        static string nextTowerShouldBe = "";
        static bool towerPlaced = false;
        static Il2CppSystem.Action<bool> action2 = (Il2CppSystem.Action<bool>)delegate (bool s)
        {
            towerPlaced = s;
        };

        //holy shit NK whyyyy
        static void spawnTower(float x, string type)
        {
            towerPlaced = false;
            nextTowerShouldBe = type;
            int attempts = 0;
            while (!towerPlaced && attempts < 100)
            {
                for (int i = -50; i < 200; i++)
                {
                    try
                    {
                        var x2 = x;// + ((float)random.NextDouble() - 0.5f) * 200;
                        //var x2 = (float)random.NextDouble() * 200;
                        var y = ((float)random.NextDouble() - 0.5f) * 200f;
                        InGame.instance.bridge.CreateTowerAt(new UnityEngine.Vector2(x2, y), Game.instance.model.GetTowerFromId(TowerType.DartMonkey), i, true, action2);
                        //System.Console.WriteLine(x + " " + y);
                        break;
                    }
                    catch// (System.Exception e2)
                    {
                        //System.Console.WriteLine(e2 + "");

                    }
                }
                attempts++;
            }
            if (!towerPlaced) nextTowerShouldBe = "";
        }


        [HarmonyPatch(typeof(Weapon), "Initialise")]
        public class WeaponInitialise_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(Weapon __instance)
            {
                if (grieferSpawning)
                {
                    __instance.attack.attackModel.range = 1000f;
                    __instance.attack.attackModel.attackThroughWalls = true;
                }
            }
        }

        [HarmonyPatch(typeof(TravelStrait), "Initialise")]
        internal class TravelStrait_Patch
        {

            [HarmonyPostfix]
            internal static void Postfix(ref TravelStrait __instance)
            {

                if (__instance.projectile.projectileModel.display == "3c27c2e53b36c6346a6dd2766052c9e5" && selectedHero != TowerType.StrikerJones)
                {
                    SellRandomTower();
                }

            }

        }


        [HarmonyPatch(typeof(Tower), "Initialise")]
        public class TowerInitialise_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix(Tower __instance, ref Model modelToUse)
            {

                if (prevEffect == effects[20] && voteTimer < 40)
                    modelToUse = Game.instance.model.GetTowerFromId(TowerType.CaveMonkey);//TowerUtils.GetTower(TowerType.CaveMonkey);

                if (prevEffect == effects[21] && voteTimer < 40)
                    modelToUse = Game.instance.model.GetTowerFromId(TowerType.SentryCold);

                if (prevEffect == effects[22] && voteTimer < 20)
                    modelToUse = Game.instance.model.GetTowerFromId(TowerType.EnergisingTotem);

                if (prevEffect == effects[23] && voteTimer < 20)
                    modelToUse = Game.instance.model.GetTowerFromId(TowerType.PortableLake);

                if (grieferSpawning)
                {
                    modelToUse = Game.instance.model.GetTowerFromId(TowerType.StrikerJones);
                }
                if (nextTowerShouldBe != "")
                {
                    modelToUse = Game.instance.model.GetTowerFromId(nextTowerShouldBe);
                    nextTowerShouldBe = "";
                }

                //var village = Game.instance.getTowerModel(TowerType.MonkeyVillage);
                ////var builder = new TowerBuilder((TowerModel)modelToUse);
                //var builder = new TowerBuilder(village);
                //builder.SetCost(5000);
                //builder.SetRadius(100);
                //builder.SetRange(100);
                //modelToUse = builder.build();


                //if (prevEffect == effects[27] && voteTimer < 20)
                //    modelToUse = TowerUtils.GetTower(TowerType.Etienne);



                return true;
            }

            [HarmonyPostfix]
            public static void Postfix(Tower __instance)
            {
                if (grieferSpawning)
                {
                    __instance.towerModel.range = 999999f;
                    __instance.towerModel.isGlobalRange = true;
                }


            }
        }



        [HarmonyPatch(typeof(InGame), "Update")]
        public class Update_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                if (!(InGame.instance != null && InGame.instance.bridge != null)) return;
                if (prevEffect == effects[24] && voteTimer < 50)
                    foreach (var tts in InGame.Bridge.GetAllTowers())
                    {
                        //credit to Baydock
                        var camera = InGame.instance.sceneCamera;
                        tts?.tower?.Node?.graphic?.transform.LookAt(camera.ScreenToWorldPoint(
                            new UnityEngine.Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, camera.nearClipPlane)));
                    }

                if (prevEffect == effects[25] && voteTimer < 50)
                    foreach (var tts in InGame.Bridge.GetAllTowers())
                    {
                        if (tts != null && tts.tower != null && tts.tower.Node != null && tts.tower.Node.graphic != null && tts.tower.Node.graphic.transform != null)
                            tts.tower.Node.graphic.transform.localScale = new UnityEngine.Vector3(3, 2, 0.1f);
                    }
                if (prevEffect == effects[26] && voteTimer < 50)
                    foreach (var tts in InGame.Bridge.GetAllTowers())
                    {
                        if (tts != null && tts.tower != null && tts.tower.Node != null && tts.tower.Node.graphic != null && tts.tower.Node.graphic.transform != null)
                            tts.tower.Node.graphic.transform.localScale = new UnityEngine.Vector3(0.001f, 0.001f, 0.001f);
                    }
                if (prevEffect == effects[28] && voteTimer < 20)
                    foreach (var tts in InGame.Bridge.GetAllTowers())
                    {
                        if (tts != null && tts.tower != null && tts.tower.Node != null && tts.tower.Node.graphic != null && tts.tower.Node.graphic.transform != null)
                            tts.tower.Node.graphic.transform.localScale = new UnityEngine.Vector3(50, 50, 50);
                    }
            }
        }



        [HarmonyPatch(typeof(Bloon), "Initialise")]
        public class BloonInitialise_Patch
        {

            [HarmonyPrefix]
            public static bool Prefix(Bloon __instance, ref Model modelToUse)
            {
                //System.Console.WriteLine(BloonUtils.GetBloonIdNum(modelToUse.name) + "");
                //camgrow fortified
                if (prevEffect == effects[17])
                {
                    try
                    {
                        modelToUse = BloonUtils.SetBloonStatus(modelToUse.name, true, true, true);
                    }
                    catch
                    {

                    }

                }
                //upgrade bloons randomly
                if (prevEffect == effects[18] && voteTimer < 25)// && BloonUtils.GetBloonIdNum(modelToUse.name) < 48
                {
                    try
                    {
                        //modelToUse = GetNextBloon(modelToUse.name);
                        //System.Console.WriteLine(modelToUse.name);
                        var name = modelToUse.name;
                        if (random.NextDouble() > 0.8) name = GetNextBloon(name);

                        modelToUse = BloonUtils.SetBloonStatus(name, false, false, false);
                    }
                    catch
                    {

                    }

                }

                return true;
            }

            public static string GetNextBloon(string currentBloon)
            {
                var clean = currentBloon.Replace("Regrow", "").Replace("Camo", "").Replace("Fortified", "").ToLower();
                var res = clean.Replace("rainbow", "ceramic").Replace("zebra", "rainbow").Replace("white", "zebra").Replace("black", "lead").Replace("pink", "purple")
                    .Replace("yellow", "pink").Replace("green", "yellow").Replace("blue", "green").Replace("red", "blue");

                res = char.ToUpper(res[0]) + res.Substring(1);
                //System.Console.WriteLine(res);
                return res;
            }


        }


    }

}