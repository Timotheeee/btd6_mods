using MelonLoader;
using HarmonyLib;
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

//using Il2CppSystem.Collections;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using System.Reflection;
using Il2CppAssets.Scripts.Models;
using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using System;
using System.Linq;
using Il2CppAssets.Scripts.Models.ServerEvents;
using Il2CppAssets.Scripts.Data.Cosmetics.Pets;
using Il2CppAssets.Main.Scenes;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Models.Store;
using Il2CppAssets.Scripts.Unity.Bridge;
using Il2CppAssets.Scripts.Models.Map;
using UnityEngine;
using System.IO;
using UnhollowerRuntimeLib;
using Il2CppAssets.Scripts.Unity.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Unity.UI_New;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper;
using System.Collections;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Color = UnityEngine.Color;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;
using Screen = UnityEngine.Screen;
using Il2CppAssets.Scripts.Data.MapSets;
using BTD_Mod_Helper.Api.ModOptions;



[assembly: MelonInfo(typeof(map_editor.Main), map_editor.ModHelperData.Name, map_editor.ModHelperData.Version, map_editor.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
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


        //public static int TextOutlineThickness = 2;
        public static ModSettingInt TextOutlineThickness = new ModSettingInt(2)
        {
            isSlider = false,
            displayName = "Text Outline Thickness",
            maxValue = 40,
            minValue = 0,
        };

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
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
                    if (writingPoint)
                    {
                        ListOfPaths.Last().Add(new Rect(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y), new Vector2(5f, 5f)));
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

                    }
                    if (writingPoint)
                    {
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
                    if (type == (int)AreaType.track) ListOfPathAreas.Add(new List<Rect>());
                    if (type == (int)AreaType.water) ListOfWaterAreas.Add(new List<Rect>());
                    if (type == (int)AreaType.land) ListOfLandAreas.Add(new List<Rect>());
                    if (type == (int)AreaType.unplaceable) ListOfUnplaceableAreas.Add(new List<Rect>());
                    TextToDisplay.Add("Writing Area: " + writingArea);
                    TimePassed.Add(0);

                }
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
            writingPoint = false;
            writingArea = false;
        }
        static string lastMap;


        [HarmonyPatch(typeof(MapLoader), nameof(MapLoader.LoadScene))]
        public class LoadMap
        {
            [HarmonyPrefix]
            internal static bool Fix(ref MapLoader __instance)
            {
                lastMap = __instance.currentMapName;
                //System.Console.WriteLine("map editor prefix " + __instance.currentMapName);
                return true;
            }
            [HarmonyPostfix]
            internal static void Fix2(ref MapLoader __instance)
            {
                //lastMap = __instance.currentMapName;
                //System.Console.WriteLine("map editor postfix " + __instance.currentMapName);
            }
        }

        public static Il2CppReferenceArray<Assets.Scripts.Simulation.SMath.Polygon> Empty()
        {
            return new Il2CppReferenceArray<Assets.Scripts.Simulation.SMath.Polygon>(0);
        }




    }
}