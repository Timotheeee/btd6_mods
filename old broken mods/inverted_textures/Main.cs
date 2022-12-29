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
using System;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using UnityEngine;
using Il2CppAssets.Scripts.Unity.Display;
using System.Linq;
using System.IO;

[assembly: MelonInfo(typeof(inverted_textures.Main), inverted_textures.ModHelperData.Name, inverted_textures.ModHelperData.Version, inverted_textures.ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace inverted_textures
{
    public class Main : MelonMod
    {



        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Console.WriteLine("inverted_textures loaded");
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


        //static Texture2D tex = null;
        //static string filePath = @"pixels.png";
        //static byte[] fileData;


        [HarmonyPatch(typeof(InGame), "Update")]
        public class Update_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                if (!(InGame.instance != null && InGame.instance.bridge != null)) return;
                foreach (var tts in InGame.Bridge.GetAllTowers())
                {
                    try
                    {


                        //if (!tts.namedMonkeyKey.ToLower().Contains("handkanonier")) continue;
                        if (tts?.tower?.Node?.graphic?.transform != null)
                        {
                            var parent = tts.tower.Node.graphic.transform;
                            //make sure it only runs once
                            if (parent.FindChild("processed") == null)
                            {
                                var proc = new GameObject("processed");
                                proc.transform.parent = parent;
                                var node = tts.tower.Node.graphic;
                                foreach (Renderer renderer in node.genericRenderers)
                                {
                                    var texture = renderer.material.mainTexture;

                                    //File.WriteAllBytes("textures/" + tts.tower.model.name + ".png", ImageConversion.EncodeToPNG(makeReadable(texture)));

                                    renderer.material.mainTexture = FlipTexture(makeReadable(texture));


                                }
                            }

                        }
                    }
                    catch
                    {

                    }
                }

            }
        }


        //[HarmonyPatch(typeof(Factory), "FindAndSetupPrototypeAsync")]
        //public class UnityDisplayNodeFactory_Patch
        //{

        //    [HarmonyPostfix]
        //    public static void Postfix(Factory __instance, UnityDisplayNode __result, string objectId)
        //    {
        //        //if (fileData == null)
        //        //{
        //        //    fileData = File.ReadAllBytes(filePath);
        //        //}
        //        //if (tex == null)
        //        //{
        //        //    tex = new Texture2D(2, 2);
        //        //    ImageConversion.LoadImage(tex, fileData);
        //        //}
        //        //Console.WriteLine("loading");
        //        try
        //        {
        //            foreach (Renderer renderer in __result.genericRenderers)
        //            {
        //                //renderer18.material.mainTexture = tex;
        //                var texture = renderer.material.mainTexture;




        //                //File.WriteAllBytes("textures/" + objectId + ".png", ImageConversion.EncodeToPNG(myTexture2D));


        //                renderer.material.mainTexture = FlipTexture(makeReadable(texture));


        //            }
        //        }
        //        catch (Exception)
        //        {
        //        }

        //    }
        //}

        static Texture2D FlipTexture(Texture2D original)
        {
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            Texture2D flipped = new Texture2D(original.width, original.height);
            var orig = original.GetPixels32();
            var rev = original.GetPixels32();
            //this loop legit takes 400 ms to run
            for (int i = 0; i < orig.Count; i++)
            {
                rev[i] = orig[orig.Count - i - 1];
            }

            flipped.SetPixels32(rev);
            flipped.Apply();

            //int xN = original.width;
            //int yN = original.height;


            ////original.GetPixels32().Reverse()

            //for (int i = 0; i < xN; i++)
            //{
            //    for (int j = 0; j < yN; j++)
            //    {
            //        flipped.SetPixel(xN - i - 1, yN - j - 1, original.GetPixel(i, j));
            //    }
            //}
            //flipped.Apply();
            //Console.WriteLine("took: " + (DateTimeOffset.Now.ToUnixTimeMilliseconds() - milliseconds));
            return flipped;
        }














        [HarmonyPatch(typeof(ResourceLoader), "LoadSpriteFromSpriteReferenceAsync")]
        public class SpriteRegister_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(ref SpriteReference reference, ref UnityEngine.UI.Image image)
            {

                try
                {
                    //Console.WriteLine(image.sprite.texture == null);
                    //Console.WriteLine(image.mainTexture == null);
                    //Texture2D tex = FlipTexture(makeReadable(image.mainTexture));
                    //image.canvasRenderer.SetTexture(tex);
                    //image.sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), default);
                    //Console.WriteLine("success");
                }
                catch
                {
                    //Console.WriteLine("fail");
                }
                //Console.WriteLine(SpriteRegister.register == null);
                //Console.WriteLine(SpriteRegister.register.Count);


                //if (reference != null && image != null && SpriteRegister.register.Count > 0)
                //{
                //    foreach (KeyValuePair<string, Sprite> entry in SpriteRegister.register)
                //    {
                //        Console.WriteLine(entry.Key == null);
                //        Console.WriteLine(reference.GUID == null);
                //        Console.WriteLine(entry.Value == null);
                //        Console.WriteLine(entry.Value.texture == null);


                //        if (entry.Key == reference.GUID)
                //        {
                //            var val = entry.Value;
                //            if (entry.Value == null)
                //            {
                //                Texture2D pngTexture = SpriteRegister.TextureFromPNG(entry.Key);
                //                val = Sprite.Create(pngTexture, new Rect(0.0f, 0.0f, pngTexture.width, pngTexture.height), default);
                //            }
                //            var temp = val.texture;
                //            if (temp == null) Console.WriteLine("tex null");
                //            image.canvasRenderer.SetTexture(val.texture);
                //            image.sprite = val;
                //        }
                //    }
                //}
            }
        }


    }

}