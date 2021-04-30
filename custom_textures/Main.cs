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

        public static void Process(string towername, UnityDisplayNode node)
        {
            var parent = node.transform;
            //make sure it only runs once
            if (parent.FindChild("processed") == null)
            {
                var proc = new GameObject("processed");
                proc.transform.parent = parent;
                var towerlocation = towername + ".png";
                //Console.WriteLine("processing: " + towername);

                //create orig
                try
                {
                    if (!File.Exists(filePath + "original/" + towerlocation))
                    {
                        //string counter = "";
                        foreach (Renderer renderer in node.genericRenderers)
                        {
                            try
                            {
                                var texture = renderer.material.mainTexture;

                                File.WriteAllBytes(filePath + "original/" + towerlocation, ImageConversion.EncodeToPNG(makeReadable(texture)));
                                break;
                            }
                            catch
                            {

                            }
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
                    //Console.WriteLine("file for " + towername + "exists: " + File.Exists(filePath + "custom/" + towerlocation));
                    if (File.Exists(filePath + "custom/" + towerlocation))
                    {
                        foreach (Renderer renderer in node.genericRenderers)
                        {
                            Texture2D tex = new Texture2D(2, 2);
                            ImageConversion.LoadImage(tex, File.ReadAllBytes(filePath + "custom/" + towerlocation));
                            //Console.WriteLine("loaded custom texture for " + towername);

                            renderer.material.mainTexture = tex;


                        }
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine("could not read custom texture: " + e.Message);
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
                        Process(tts.tower.model.name,parent);

                    }

                }

                foreach (var bloon in InGame.Bridge.GetAllBloons())
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