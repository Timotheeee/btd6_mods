using MelonLoader;
using HarmonyLib;
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

//using Il2CppSystem.Collections;
using Assets.Scripts.Unity.UI_New.Popups;
using System.Reflection;
using Assets.Scripts.Models;
using System.Collections.Generic;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.GenericBehaviors;
using System;
using System.Linq;
using Assets.Scripts.Models.ServerEvents;
using Assets.Scripts.Data.Cosmetics.Pets;
using Assets.Main.Scenes;
using UnhollowerBaseLib;

using Assets.Scripts.Models.Rounds;
using Assets.Scripts.Models.Store;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Map;
using UnityEngine;
using System.IO;
using UnhollowerRuntimeLib;
using Assets.Scripts.Unity.Map;
using Assets.Scripts.Models.Map.Spawners;
using Assets.Scripts.Unity.UI_New;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper;
using System.Collections;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Color = UnityEngine.Color;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;
using Screen = UnityEngine.Screen;
using Assets.Scripts.Data.MapSets;
using BTD_Mod_Helper.Api.ModOptions;

namespace map_editor
{
    public class Main : BloonsTD6Mod
    {


        public static System.Random r = new System.Random();
        public static bool writingPoint = false;
        public static bool writingArea = false;

        //type and height of areas
        public static int type = 0;
        public static bool blocker = false;


        //public static ModSettingBool GenCustomMap = new ModSettingBool(true)
        //{
        //    IsButton = false,
        //    displayName = "Generate Custom Map",
        //};
        public static ModSettingInt TextOutlineThickness = new ModSettingInt(2)
        {
            isSlider = false,
            displayName = "Text Outline Thickness",
            maxValue = 40,
            minValue = 0,
        };
        //public static ModSettingBool DeleteMapDataOnGameLaunch = new ModSettingBool(true)
        //{
        //    IsButton = false,
        //    displayName = "Delete Map Data on Game Launch",
        //};
        //public override void OnGameModelLoaded(GameModel model)
        //{
        //    base.OnGameModelLoaded(model);
        //    if (!Directory.Exists(@"Mods/MapEditor"))
        //    {
        //        Directory.CreateDirectory(@"Mods/MapEditor");
        //        File.Create(@"Mods/MapEditor/INSERT_MAP_PNG_HERE_(SAME_NAME_AS_OTHER_FILE)");
        //        File.Create(@"Mods/MapEditor/CustomMap.png");
        //        if (PopupScreen.instance != null)
        //        {
        //            PopupScreen.instance.ShowMapLockedPopup("Restart game and add a png called CustomMap to Mods/MapEditor!");
        //        }
        //    }
        //    if (Directory.Exists(@"Mods/MapEditor") && GenCustomMap)
        //    {
        //        string guid;
        //        Game.instance.GetSpriteRegister().RegisterSpriteFromImage(@"Mods/MapEditor/CustomMap.png", default, out guid);
        //        var listOfMaps = new List<MapDetails>();
        //        listOfMaps.Add(new Assets.Scripts.Data.MapSets.MapDetails
        //        {
        //            id = "Test Custom Map",
        //            isBrowserOnly = false,
        //            isDebug = false,
        //            coopMapDivisionType = Assets.Scripts.Data.MapSets.CoopDivision.DEFAULT,
        //            difficulty = Assets.Scripts.Data.MapSets.MapDifficulty.Beginner,
        //            unlockDifficulty = Assets.Scripts.Data.MapSets.MapDifficulty.Beginner,
        //            mapMusic = "MusicDarkA",
        //            mapSprite = new SpriteReference(guid),
        //            odysseyStatue = null,
        //        });
        //        foreach (var map in GameData._instance.mapSet.Maps.items)
        //        {
        //            listOfMaps.Add(map);
        //        }
        //        GameData._instance.mapSet.Maps.items = listOfMaps.ToArray();
        //    }
        //}
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //EventRegistry.instance.listen(typeof(Main));
            //NKHook6.Logger.Log("map_editor loaded");
            //if (!File.Exists("map.txt") && !DeleteMapDataOnGameLaunch)
            //{
            //    File.WriteAllText("map.txt", "");
            //}
        }
        public static List<List<Rect>> ListOfPaths = new List<List<Rect>>();

        public static List<List<Rect>> ListOfPathAreas = new List<List<Rect>>();
        public static List<List<Rect>> ListOfWaterAreas = new List<List<Rect>>();
        public static List<List<Rect>> ListOfLandAreas = new List<List<Rect>>();
        public static List<List<Rect>> ListOfUnplaceableAreas = new List<List<Rect>>();


        List<string> TextToDisplay = new List<string>();
        List<int> TimePassed = new List<int>();
        public static void writePath(string stuff)
        {
            File.AppendAllText("Mods/map_editor/" + lastMap + "/paths.txt", stuff + "\n");
        }

        public static void writeArea(string stuff)
        {
            File.AppendAllText("Mods/map_editor/" + lastMap + "/areas.txt", stuff + "\n");
        }

        public static void OkayButtonClicked()
        {

        }
        //public static Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.List<PointInfo>> ListOfPaths2 = new Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.List<PointInfo>>();
        //public static Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>> ListOfLandAreas2 = new Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>>();
        //public static Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>> ListOfWaterAreas2 = new Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>>();
        //public static Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>> ListOfUnplaceableAreas2 = new Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>>();
        public override void OnUpdate()
        {
            base.OnUpdate();

            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (Input.GetMouseButtonDown(0))//GetKeyDown(KeyCode.F3)
                {
                    var v3 = Input.mousePosition;
                    v3 = InGame.instance.sceneCamera.ScreenToWorldPoint(v3);
                    float x = v3.x;
                    float y = v3.y * -2.3f;
                    //Console.WriteLine(x + " " + y);
                    if (writingPoint)
                    {
                        //ListOfPaths2.Last().Add(new PointInfo()
                        //{
                        //    bloonScale = 1,
                        //    bloonsInvulnerable = false,
                        //    distance = 1,
                        //    id = r.NextDouble() + "",
                        //    moabScale = 1,
                        //    moabsInvulnerable = false,
                        //    rotation = 0,
                        //    point = new Assets.Scripts.Simulation.SMath.Vector3(x, y)
                        //});
                        ListOfPaths.Last().Add(new Rect(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), new Vector2(5f, 5f)));
                        //writeTrack("list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + \"\", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(" + x + "f, " + y + "f) });");
                        writePath(x + "," + y);
                    }

                    if (writingArea)
                    {
                        if (type == (int)AreaType.track) ListOfPathAreas.Last().Add(new Rect(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), new Vector2(5f, 5f)));
                        if (type == (int)AreaType.water) ListOfWaterAreas.Last().Add(new Rect(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), new Vector2(5f, 5f)));
                        if (type == (int)AreaType.land) ListOfLandAreas.Last().Add(new Rect(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), new Vector2(5f, 5f)));
                        if (type == (int)AreaType.unplaceable) ListOfUnplaceableAreas.Last().Add(new Rect(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), new Vector2(5f, 5f)));
                        writeArea(x + "," + y);
                    }

                    //if (writingArea && type == (int)AreaType.unplaceable)
                    //{
                    //    ListOfUnplaceableAreas.Last().Add(new Rect(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), new Vector2(5f, 5f)));
                    //    ListOfUnplaceableAreas2.Last().Add(new Assets.Scripts.Simulation.SMath.Vector2(x, y));
                    //    write("area" + index + ".Add(new Assets.Scripts.Simulation.SMath.Vector2(" + x + "f, " + y + "f));");
                    //}
                    //if (writingArea && type == (int)AreaType.water)
                    //{
                    //    ListOfWaterAreas.Last().Add(new Rect(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), new Vector2(5f, 5f)));
                    //    ListOfWaterAreas2.Last().Add(new Assets.Scripts.Simulation.SMath.Vector2(x, y));
                    //    write("area" + index + ".Add(new Assets.Scripts.Simulation.SMath.Vector2(" + x + "f, " + y + "f));");
                    //}
                    //if (writingArea && type == (int)AreaType.land)
                    //{
                    //    ListOfLandAreas.Last().Add(new Rect(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), new Vector2(5f, 5f)));
                    //    ListOfLandAreas2.Last().Add(new Assets.Scripts.Simulation.SMath.Vector2(x, y));
                    //    write("area" + index + ".Add(new Assets.Scripts.Simulation.SMath.Vector2(" + x + "f, " + y + "f));");
                    //}
                }
                if (!writingArea)
                {
                    if (Input.GetKeyDown(KeyCode.Alpha0))
                    {
                        type = (int)AreaType.track;
                        Console.WriteLine("track");
                        TextToDisplay.Add("Area Type: Track");
                        TimePassed.Add(0);
                    }

                    if (Input.GetKeyDown(KeyCode.Alpha1))
                    {
                        type = (int)AreaType.water;
                        Console.WriteLine("water");
                        TextToDisplay.Add("Area Type: Water");
                        TimePassed.Add(0);
                    }
                    if (Input.GetKeyDown(KeyCode.Alpha2))
                    {
                        type = (int)AreaType.land;
                        Console.WriteLine("land");
                        TextToDisplay.Add("Area Type: Land");
                        TimePassed.Add(0);
                    }
                    if (Input.GetKeyDown(KeyCode.Alpha3))
                    {
                        type = (int)AreaType.unplaceable;
                        Console.WriteLine("unplaceable");
                        TextToDisplay.Add("Area Type: Unplaceable");
                        TimePassed.Add(0);
                    }
                    if (Input.GetKeyDown(KeyCode.Alpha4))
                    {
                        blocker = !blocker;
                        TextToDisplay.Add(blocker ? "The next area will block LOS" : "The next area will not block LOS");
                        TimePassed.Add(0);
                    }
                } else if(Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3))
                {
                    TextToDisplay.Add("You are already adding an area! Finish this one first before changing the area type.");
                    TimePassed.Add(0);
                }



                //called when a track is started or stopped
                if (Input.GetKeyDown(KeyCode.F1) && !writingArea)
                {
                    if (!writingPoint)
                    {
                        //write("public static Il2CppReferenceArray<PointInfo> track" + indexTrack + "(){");
                        //write("List<PointInfo> list = new List<PointInfo>();");
                        //ListOfPaths2.Add(new Il2CppSystem.Collections.Generic.List<PointInfo>());
                    }
                    if (writingPoint)
                    {
                        //write("return list.ToArray();");
                        //write("}");
                        //indexTrack++;
                        writePath("next");
                    }
                    writingPoint = !writingPoint;
                    ListOfPaths.Add(new List<Rect>());
                    TextToDisplay.Add("Writing path: " + writingPoint);
                    TimePassed.Add(0);
                }

                //called when an area is started or stopped
                if (Input.GetKeyDown(KeyCode.F2) && !writingPoint)
                {
                    //when starting a new area, save the type
                    if (!writingArea)
                    {
                        writeArea(type + " " + blocker);
                    }
                    writingArea = !writingArea;
                    //Console.WriteLine("writingArea: " + writingArea);
                    if (type == (int)AreaType.track) ListOfPathAreas.Add(new List<Rect>());
                    if (type == (int)AreaType.water) ListOfWaterAreas.Add(new List<Rect>());
                    if (type == (int)AreaType.land) ListOfLandAreas.Add(new List<Rect>());
                    if (type == (int)AreaType.unplaceable) ListOfUnplaceableAreas.Add(new List<Rect>());
                    //ListOfWaterAreas.Add(new List<Rect>());
                    //ListOfWaterAreas2.Add(new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>());
                    TextToDisplay.Add("Writing Area: " + writingArea);
                    TimePassed.Add(0);

                }



                //if (Input.GetKeyDown(KeyCode.F2) && type == (int)AreaType.water)
                //{
                //    //Il2CppReferenceArray<PointInfo> arr = new Il2CppReferenceArray<PointInfo>(3);
                //    //arr[0] = new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-95f, -130f) };

                //    if (!writingArea)
                //    {
                //        writeArea(type + "");
                //        //write("var area" + index + " = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();");
                //    }
                //    if (writingArea)
                //    {
                //        //write("newareas.Add(new AreaModel(\"lol" + index + "\", new Assets.Scripts.Simulation.SMath.Polygon(area" + index + "), 10, (AreaType)" + type + "));");
                //        //index++;
                //    }
                //    writingArea = !writingArea;
                //    Console.WriteLine("writingArea: " + writingArea);
                //    ListOfWaterAreas.Add(new List<Rect>());
                //    //ListOfWaterAreas2.Add(new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>());
                //    TextToDisplay.Add("Writing Area: " + writingArea);
                //    TimePassed.Add(0);

                //}
                //if (Input.GetKeyDown(KeyCode.F2) && type == (int)AreaType.unplaceable)
                //{
                //    //Il2CppReferenceArray<PointInfo> arr = new Il2CppReferenceArray<PointInfo>(3);
                //    //arr[0] = new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-95f, -130f) };

                //    if (!writingArea)
                //    {
                //        writeArea(type + "");
                //        //write("var area" + index + " = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();");
                //    }
                //    if (writingArea)
                //    {
                //        //write("newareas.Add(new AreaModel(\"lol" + index + "\", new Assets.Scripts.Simulation.SMath.Polygon(area" + index + "), 10, (AreaType)" + type + "));");
                //        //index++;
                //    }
                //    writingArea = !writingArea;
                //    Console.WriteLine("writingArea: " + writingArea);
                //    ListOfUnplaceableAreas.Add(new List<Rect>());
                //    //ListOfUnplaceableAreas2.Add(new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>());
                //    TextToDisplay.Add("Writing Area: " + writingArea);
                //    TimePassed.Add(0);

                //}
                //if (Input.GetKeyDown(KeyCode.F2) && type == (int)AreaType.land)
                //{
                //    //Il2CppReferenceArray<PointInfo> arr = new Il2CppReferenceArray<PointInfo>(3);
                //    //arr[0] = new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-95f, -130f) };

                //    if (!writingArea)
                //    {
                //        writeArea(type + "");
                //        //write("var area" + index + " = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();");
                //    }
                //    if (writingArea)
                //    {
                //        //write("newareas.Add(new AreaModel(\"lol" + index + "\", new Assets.Scripts.Simulation.SMath.Polygon(area" + index + "), 10, (AreaType)" + type + "));");
                //        //index++;
                //    }
                //    writingArea = !writingArea;
                //    Console.WriteLine("writingArea: " + writingArea);
                //    ListOfLandAreas.Add(new List<Rect>());
                //    //ListOfLandAreas2.Add(new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>());
                //    TextToDisplay.Add("Writing Area: " + writingArea);
                //    TimePassed.Add(0);
                //}




                //if (Input.GetKeyDown(KeyCode.F2) && type == 0)
                //{
                //    PopupScreen.instance.ShowPopup(PopupScreen.Placement.inGameCenter, "Hey!", "You forgot to set an area type! Press 1-3 to select one!", (PopupScreen.ReturnCallback)OkayButtonClicked, "Okay", (PopupScreen.ReturnCallback)OkayButtonClicked, "Okay", Popup.TransitionAnim.Scale);

                //}
                //if (Input.GetKeyDown(KeyCode.F3))
                //{
                //    Il2CppSystem.Action<int> deb = (Il2CppSystem.Action<int>)delegate (int s)
                //    {
                //        index = s;
                //    };
                //    PopupScreen.instance.ShowSetValuePopup("index",
                //    "which index ? ", deb, 11);

                //}
                //if (Input.GetKeyDown(KeyCode.F4))
                //{
                //    mapeditor = !mapeditor;
                //    Console.WriteLine("mapeditor: " + mapeditor);
                //}

            }
        }
        public static Texture2D lineTex = null;
        public static Texture2D unplaceablelineTex = null;
        public static Texture2D waterlineTex = null;
        public static Texture2D landlineTex = null;
        public static void RenderLines(List<List<Rect>> points, Texture2D lineTex, Color color, bool isArea)
        {
            foreach (var pointList in points)
            {
                for (int i = 0; i < pointList.Count(); i++)
                {
                    GUI.Box(pointList[i], GUIContent.none);
                    if (pointList.Count != 1 && i < pointList.Count - 1)
                    {
                        Matrix4x4 matrix = GUI.matrix;
                        if (lineTex == null)
                        {
                            lineTex = new Texture2D(1, 1);
                            lineTex.SetPixel(0, 0, color);
                            lineTex.Apply();
                        }
                        Vector2 point1 = new Vector2(pointList[i].x, pointList[i].y);
                        Vector2 point2 = new Vector2(pointList[i + 1].x, pointList[i + 1].y);
                        float num = Vector3.Angle(point2 - point1, Vector2.right);
                        if (point1.y > point2.y)
                        {
                            num = -num;
                        }
                        GUIUtility.ScaleAroundPivot(new Vector2((point2 - point1).magnitude, 1f), new Vector2(point1.x, point1.y + 0.5f));
                        GUIUtility.RotateAroundPivot(num, point1);
                        GUI.DrawTexture(new Rect(point1.x, point1.y, 1f, 1f), lineTex);
                        GUI.matrix = matrix;
                        if (isArea && !writingArea)
                        {
                            Vector2 first = new Vector2(pointList.First().x, pointList.First().y);
                            Vector2 last = new Vector2(pointList.Last().x, pointList.Last().y);
                            float num2 = Vector3.Angle(last - first, Vector2.right);
                            if (first.y > last.y)
                            {
                                num2 = -num2;
                            }
                            GUIUtility.ScaleAroundPivot(new Vector2((last - first).magnitude, 1f), new Vector2(first.x, first.y + 0.5f));
                            GUIUtility.RotateAroundPivot(num2, first);
                            GUI.DrawTexture(new Rect(first.x, first.y, 1f, 1f), lineTex);
                            GUI.matrix = matrix;
                        }
                    }
                }
            }
        }
        public override void OnGUI()
        {
            base.OnGUI();

            if (InGame.instance != null && InGame.instance.bridge != null)
            {
                RenderLines(ListOfPaths, lineTex, Color.red, false);
                RenderLines(ListOfWaterAreas, waterlineTex, Color.blue, true);
                RenderLines(ListOfUnplaceableAreas, unplaceablelineTex, Color.black, true);
                RenderLines(ListOfLandAreas, landlineTex, Color.green, true);
                RenderLines(ListOfPathAreas, unplaceablelineTex, Color.black, true);
                for (int i = 0; i < TextToDisplay.Count; i++)
                {
                    var text = TextToDisplay[i];
                    TimePassed[i]++;
                    Rect rect = new Rect(Screen.width / 2 - 400, 50f * i, 800f, 50f);
                    GUIContent content = new GUIContent(text);
                    GUIStyle style = new GUIStyle();
                    style.alignment = TextAnchor.MiddleCenter;
                    style.normal.textColor = Color.white;
                    style.fontSize = 40;
                    /*Texture2D tex = new Texture2D(1, 1);
                    tex.SetPixel(0, 0, new Color(0, 0, 0, 0.75f));
                    tex.Apply(false, false);
                    style.normal.background = tex;
                    GUI.Label(rect, content, style);*/
                    DrawTextWithOutline(rect, text, style, Color.black, Color.white, TextOutlineThickness);
                    if (TimePassed[i] > 200)
                    {
                        TextToDisplay.Remove(text);
                        TimePassed.Remove(TimePassed[i]);
                    }
                }
                if (!writingArea && !writingPoint && type == 0)
                {
                    var text = "Welcome to Map Editor. Press F1 to create bloon path. Press the numbers 1-3 to change between water, land, and unplaceable area type. Press F2 to create areas";
                    Rect rect = new Rect(Screen.width / 2 - 400, 50f, 800f, 50f);
                    GUIContent content = new GUIContent(text);
                    GUIStyle style = new GUIStyle();
                    style.alignment = TextAnchor.MiddleCenter;
                    style.normal.textColor = Color.white;
                    style.fontSize = 20;
                    DrawTextWithOutline(rect, text, style, Color.black, Color.white, TextOutlineThickness / 2);
                }
            }
        }
        //dunno where this comes from but i didnt make it
        void DrawTextWithOutline(Rect centerRect, string text, GUIStyle style, Color borderColor, Color innerColor, int borderWidth)
        {
            // assign the border color
            style.normal.textColor = borderColor;

            // draw an outline color copy to the left and up from original
            Rect modRect = centerRect;
            modRect.x -= borderWidth;
            modRect.y -= borderWidth;
            GUI.Label(modRect, text, style);


            // stamp copies from the top left corner to the top right corner
            while (modRect.x <= centerRect.x + borderWidth)
            {
                modRect.x++;
                GUI.Label(modRect, text, style);
            }

            // stamp copies from the top right corner to the bottom right corner
            while (modRect.y <= centerRect.y + borderWidth)
            {
                modRect.y++;
                GUI.Label(modRect, text, style);
            }

            // stamp copies from the bottom right corner to the bottom left corner
            while (modRect.x >= centerRect.x - borderWidth)
            {
                modRect.x--;
                GUI.Label(modRect, text, style);
            }

            // stamp copies from the bottom left corner to the top left corner
            while (modRect.y >= centerRect.y - borderWidth)
            {
                modRect.y--;
                GUI.Label(modRect, text, style);
            }

            // draw the inner color version in the center
            style.normal.textColor = innerColor;
            GUI.Label(centerRect, text, style);
        }
        public override void OnMainMenu()
        {
            base.OnMainMenu();
            //ListOfPaths.Clear();
            //ListOfLandAreas.Clear();
            //ListOfUnplaceableAreas.Clear();
            //ListOfWaterAreas.Clear();
            writingPoint = false;
            writingArea = false;
            //type = 0;
        }
        static string lastMap;
        [HarmonyPatch(typeof(MapLoader), "Load")]
        public class MapLoad_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(MapLoader __instance, ref string map, Il2CppSystem.Action<MapModel> loadedCallback)
            {
                lastMap = map;
                //Console.WriteLine("map editor patch: " + map);
                //if (lastMap == "Test Custom Map")
                //{
                //    map = "MuddyPuddles";
                //}


                return true;
            }
        }

        //public override void OnKeyDown(KeyCode keyCode)
        //{
        //    base.OnKeyDown(keyCode);
        //    if(keyCode == KeyCode.F4)
        //    {
        //        ListOfLandAreas2.Clear();
        //        ListOfPaths2.Clear();
        //        ListOfUnplaceableAreas2.Clear();
        //        ListOfWaterAreas2.Clear();
        //    }
        //    if(keyCode == KeyCode.F5)
        //    {
        //        File.WriteAllText("map.txt", "");
        //    }
        //}

        //[HarmonyPatch(typeof(UnityToSimulation), "InitMap")]
        //public class InitMap_Patch
        //{

        //    [HarmonyPrefix]
        //    public static bool Prefix(UnityToSimulation __instance, ref MapModel map)
        //    {


        //        if (lastMap != "Test Custom Map") return true;

        //        Texture2D tex = null;
        //        string filePath = @"Mods\MapEditor\CustomMap.png";
        //        byte[] fileData = File.ReadAllBytes(filePath);
        //        fileData = Resize(fileData, 1652, 1064);

        //        if (File.Exists(filePath))
        //        {
        //            //fileData = File.ReadAllBytes(filePath);
        //            //float divx = 2;
        //            //float divy = 1.21f;
        //            //int marginx = 190;
        //            //int marginy = 430;
        //            float divx = 2;
        //            float divy = 1.21f;
        //            int marginx = 450;
        //            int marginy = 890;

        //            Bitmap old = new Bitmap(Image.FromStream(new MemoryStream(fileData)));//new Bitmap(filePath);
        //            Bitmap newImage = new Bitmap(old.Width + marginx, old.Height + marginy);
        //            //var paddingColor = new System.Drawing.Color(255, 255, 255);
        //            using (var graphics = System.Drawing.Graphics.FromImage(newImage))
        //            {
        //                //graphics.Clear(paddingColor);
        //                int x = (int)((newImage.Width - old.Width) / divx);
        //                int y = (int)((newImage.Height - old.Height) / divy);
        //                graphics.DrawImage(old, x, y);
        //                using (MemoryStream ms = new MemoryStream())
        //                {
        //                    newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        //                    fileData = ms.ToArray();
        //                }
        //            }


        //            tex = new Texture2D(2, 2);
        //            ImageConversion.LoadImage(tex, fileData);;
        //        }
        //        var ob2 = GameObject.Find("MuddyPuddlesTerrain");
        //        ob2.GetComponent<Renderer>().material.mainTexture = tex;
        //        //ob2.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, 0);
        //        //ob2.GetComponent<Renderer>().material.mainTextureScale = new Vector2(1, 1);
        //        foreach (var ob in UnityEngine.Object.FindObjectsOfType<GameObject>())
        //        {
        //            if (ob.name.Contains("Candy") || ob.name.Contains("Gift") || ob.name.Contains("Snow") || ob.name.Contains("Ripples") || ob.name.Contains("Grass") || ob.name.Contains("Christmas") || ob.name.Contains("WhiteFlower") || ob.name.Contains("Tree") || ob.name.Contains("Rock") || ob.name.Contains("Shadow") || ob.name.Contains("WaterSplashes"))// || ob.name.Contains("Body")   || ob.name.Contains("Ouch") || ob.name.Contains("Statue")|| ob.name.Contains("Chute")  || ob.name.Contains("Jump") || ob.name.Contains("Timer") || ob.name.Contains("Wheel") || ob.name.Contains("Body") || ob.name.Contains("Axle") || ob.name.Contains("Leg") || ob.name.Contains("Clock") ||
        //                if (ob.name != "MuddyPuddlesTerrain")
        //                    ob.transform.position = new Vector3(1000, 1000, 1000);
        //            //if (ob.name.Contains("Tree"))
        //            //    GameObject.Destroy(ob);
        //        }


        //        var areas = new List<AreaModel>();
        //        if (ListOfLandAreas2.Count > 0)
        //        {
        //            foreach (var area in ListOfLandAreas2)
        //            {
        //                List<AreaModel> newareas = new List<AreaModel>();
        //                newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area), 10f, AreaType.land));
        //                foreach (var newarea in newareas)
        //                {
        //                    areas.Add(newarea);
        //                }
        //            }
        //        }
        //        if (ListOfWaterAreas2.Count > 0)
        //        {
        //            foreach (var area in ListOfWaterAreas2)
        //            {
        //                List<AreaModel> newareas = new List<AreaModel>();
        //                newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area), 10f, AreaType.water));
        //                foreach(var newarea in newareas)
        //                {
        //                    areas.Add(newarea);
        //                }
        //            }
        //        }
        //        if (ListOfUnplaceableAreas2.Count > 0)
        //        {
        //            foreach (var area in ListOfUnplaceableAreas2)
        //            {
        //                List<AreaModel> newareas = new List<AreaModel>();
        //                newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area), 100f, AreaType.unplaceable, 0, null, null, null, false, false));
        //                foreach (var newarea in newareas)
        //                {
        //                    areas.Add(newarea);
        //                }
        //            }
        //        }
        //        map.areas = areas.ToArray();
        //        MelonLogger.Msg(ListOfPaths2.Count);
        //        List<string> stringList = new List<string>();
        //        List<PathModel> paths = new List<PathModel>();
        //        for (int i = 0; i < ListOfPaths2.Count; i++)
        //        {
        //            stringList.Add("Path" + i);
        //            paths.Add(new PathModel("Path" + i, ListOfPaths2[i].ToIl2CppReferenceArray(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null));

        //        }
        //        var spawner = new PathSpawnerModel("", new SplitterModel("", stringList.ToArray()), new SplitterModel("", stringList.ToArray()));
        //        map.spawner = spawner;
        //        map.paths = paths.ToArray();

        //        if (GameObject.Find("Rain"))
        //            GameObject.Find("Rain").active = false;
        //        map.name = "Test Custom Map";
        //        map.mapName = "Test Custom Map";
        //        return true;
        //    }

        //}


        public static byte[] Resize(byte[] data, int width, int height)
        {
            using (var stream = new MemoryStream(data))
            {
                var image = Image.FromStream(stream);

                //var height = (width * image.Height) / image.Width;
                //var thumbnail = image.GetThumbnailImage(width, height, null, IntPtr.Zero);
                Bitmap b = ResizeImage(image, width, height);//new Bitmap(image, 1652, 1064);
                //b.Save("test.png", ImageFormat.Png);

                using (var thumbnailStream = new MemoryStream())
                {
                    b.Save(thumbnailStream, ImageFormat.Png);
                    return thumbnailStream.ToArray();
                }
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = System.Drawing.Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

    }
}