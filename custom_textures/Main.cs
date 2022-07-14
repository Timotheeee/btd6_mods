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

namespace custom_textures
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("custom_textures loaded");
            Directory.CreateDirectory("Mods/customtextures/");
            Directory.CreateDirectory("Mods/customtextures/custom");
            Directory.CreateDirectory("Mods/customtextures/original");
        }



        //static Texture2D tex = null;
        static string filePath = @"Mods/customtextures/";
        //static byte[] fileData;

        static bool processBloons = true;

        public override void OnUpdate()
        {
            base.OnUpdate();


            bool inAGame = InGame.instance != null && InGame.instance.bridge != null;
            if (inAGame)
            {
                if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F2))
                {
                    processBloons = !processBloons;
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
                foreach (var tts in InGame.Bridge.GetAllTowers())
                {
                    //if (!tts.namedMonkeyKey.ToLower().Contains("handkanonier")) continue;
                    if (tts?.tower?.Node?.graphic?.transform != null)
                    {
                        var parent = tts.tower.Node.graphic;
                        Process(tts.tower.model.name, parent);

                    }

                }

                foreach (var bloon in InGame.instance.GetAllBloonToSim())
                {
                    if (processBloons)
                    {
                        if (bloon.GetBaseModel().isMoab)
                        {
                            if (bloon.GetSimBloon().Node?.graphic?.transform != null)
                            {
                                var g = bloon.GetSimBloon().Node.graphic;
                                Process(bloon.GetSimBloon().model.name, g);

                            }
                        }
                    }

                }






            }
        }


        //[HarmonyPatch(typeof(BloonToSimulation),new Type[] { typeof(UnityToSimulation) , typeof(int) , typeof(Vector3) , typeof(BloonModel) })]
        //public class BloonInitialise_Patch
        //{
        //    [HarmonyPostfix]
        //    public static void Postfix(BloonToSimulation __instance)
        //    {

        //        var bloon = __instance;
        //        if (bloon.GetBaseModel().isMoab)
        //        {
        //            if (bloon.GetSimBloon().Node?.graphic?.transform != null)
        //            {
        //                var g = bloon.GetSimBloon().Node.graphic;
        //                Process(bloon.GetSimBloon().model.name, g);

        //            }
        //        }

        //    }
        //}


        static Dictionary<string, bool> origFiles = new Dictionary<string, bool>();
        static Dictionary<string, bool> customFiles = new Dictionary<string, bool>();
        static Dictionary<string, Texture2D> customTexture = new Dictionary<string, Texture2D>();


        public static void Process(string towername, UnityDisplayNode node)
        {
            var parent = node.transform;
            //make sure it only runs once
            if (parent.FindChild("processed") == null)
            {
                var proc = new GameObject("processed");
                proc.transform.parent = parent;
                var towerlocation = towername;
                var orig = filePath + "original/" + towerlocation;
                var custom = filePath + "custom/" + towerlocation;
                //Console.WriteLine("processing: " + towername);

                //create orig
                try
                {
                    bool fileExists = true;
                    if (!origFiles.TryGetValue(orig,out fileExists))
                    {
                        origFiles.Add(orig, File.Exists(orig + "_0.png"));
                        origFiles.TryGetValue(orig, out fileExists);
                    }

                    if (!fileExists)
                    {
                        //string counter = "";
                        int i = 0;
                        foreach (Renderer renderer in node.genericRenderers)
                        {
                            try
                            {
                                var texture = renderer.material.mainTexture;

                                File.WriteAllBytes(filePath + "original/" + towerlocation + "_" + i + ".png", ImageConversion.EncodeToPNG(makeReadable(texture)));
                                
                                //break;
                            }
                            catch
                            {

                            }
                            i++;
                            //counter += "_";
                            //renderer.material.mainTexture = FlipTexture(makeReadable(texture));


                        }
                        //Console.WriteLine("dumped texture for: " + towername);
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine("could not create orig: " + e.Message);
                }

                //read custom
                try
                {
                    bool fileExists = true;
                    if (!customFiles.TryGetValue(custom, out fileExists))
                    {
                        customFiles.Add(custom, File.Exists(custom + "_0.png"));
                        customFiles.TryGetValue(custom, out fileExists);
                    }


                    //Console.WriteLine("file for " + towername + "exists: " + fileExists);
                    if (fileExists)
                    {
                        int i = 0;
                        foreach (Renderer renderer in node.genericRenderers)
                        {
                            Texture2D tex;
                            if (!customTexture.TryGetValue(custom + "_" + i, out tex))
                            {
                                tex = new Texture2D(2, 2);
                                //Console.WriteLine("loading custom texture for " + towername);
                                ImageConversion.LoadImage(tex, File.ReadAllBytes(filePath + "custom/" + towerlocation + "_" + i + ".png"));
                                //Console.WriteLine("adding to dict");
                                customTexture.Add(custom + "_" + i, tex);
                                //Console.WriteLine("found custom texture for " + towername);
                            }
                            else
                            {
                                //Console.WriteLine("texture was cached");
                            }

                            renderer.material.mainTexture = tex;
                            i++;

                        }
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine("could not read custom texture: " + e.Message);
                }
            }
        }




        static Texture2D makeReadable(Texture texture)
        {
            // Create a temporary RenderTexture of the same size as the texture
            RenderTexture tmp = RenderTexture.GetTemporary(
                                texture.width,
                                texture.height,
                                0,
                                RenderTextureFormat.Default,
                                RenderTextureReadWrite.Linear);

            // Blit the pixels on texture to the RenderTexture
            UnityEngine.Graphics.Blit(texture, tmp);
            // Backup the currently set RenderTexture
            RenderTexture previous = RenderTexture.active;
            // Set the current RenderTexture to the temporary one we created
            RenderTexture.active = tmp;
            // Create a new readable Texture2D to copy the pixels to it
            Texture2D myTexture2D = new Texture2D(texture.width, texture.height);
            // Copy the pixels from the RenderTexture to the new Texture
            myTexture2D.ReadPixels(new Rect(0, 0, tmp.width, tmp.height), 0, 0);
            myTexture2D.Apply();
            // Reset the active RenderTexture
            RenderTexture.active = previous;
            // Release the temporary RenderTexture
            RenderTexture.ReleaseTemporary(tmp);

            return myTexture2D;
        }




    }

}