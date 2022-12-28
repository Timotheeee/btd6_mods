using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class BloontoniumMinesDouble
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-149.9, (float)73.1));
            list.Add( MapHelper.AddPoint(-22.7, (float)-1.8));
            list.Add( MapHelper.AddPoint(-123.4, (float)-87.5));
            list.Add( MapHelper.AddPoint(-123.4, (float)95.0));
            list.Add( MapHelper.AddPoint(-53.1, (float)55.9));
            list.Add( MapHelper.AddPoint(-1.8, (float)96.8));
            list.Add( MapHelper.AddPoint(52.3, (float)55.9));
            list.Add( MapHelper.AddPoint(124.5, (float)96.5));
            list.Add( MapHelper.AddPoint(123.7, (float)-82.4));
            list.Add( MapHelper.AddPoint(23.7, (float)-2.7));
            list.Add( MapHelper.AddPoint(149.7, (float)74.3));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var waterLeft = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var waterRight = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crystal10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();

            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            crystal1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-115.2));
            crystal1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-142.2, (float)-115.5));
            crystal1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.9, (float)-97.1));
            crystal1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-141.9, (float)-72.5));
            crystal1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-74.9));
            crystal1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-115.5));

            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-28.6));
            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.6, (float)-11.4));
            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-135.7, (float)3.3));
            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.0, (float)9.3));
            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.5, (float)18.9));
            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-136.7, (float)34.9));
            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-133.1, (float)41.5));
            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-132.8, (float)51.1));
            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)52.3));
            crystal2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-28.6));

            crystal3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)93.5));
            crystal3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-128.1, (float)115.5));
            crystal3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)115.5));
            crystal3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)93.2));

            crystal4.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-92.7, (float)-16.2));
            crystal4.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-90.4, (float)34.9));
            crystal4.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-57.3, (float)15.0));
            crystal4.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-91.1, (float)-16.8));

            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-106.5, (float)115.5));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-101.8, (float)101.6));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-83.1, (float)98.3));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-82.3, (float)108.3));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-56.8, (float)106.4));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-52.3, (float)99.5));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-49.0, (float)104.9));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-36.7, (float)101.6));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.0, (float)94.4));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.3, (float)102.8));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-16.7, (float)106.4));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-7.8, (float)115.5));
            crystal5.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-108.6, (float)115.5));

            crystal6.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)59.1, (float)13.2));
            crystal6.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)89.1, (float)32.2));
            crystal6.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)91.7, (float)-12.6));
            crystal6.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)58.6, (float)13.8));

            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)18.5, (float)115.5));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)31.3, (float)95.3));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)38.3, (float)103.4));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.4, (float)105.2));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)50.5, (float)96.8));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)54.7, (float)98.6));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)54.2, (float)105.8));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)84.1, (float)108.3));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)83.3, (float)97.7));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)104.4, (float)103.4));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)105.2, (float)109.8));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)111.2, (float)115.5));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)9.6, (float)115.5));
            crystal7.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)18.5, (float)115.5));

            crystal8.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-114.9));
            crystal8.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-70.7));
            crystal8.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)132.3, (float)-115.2));
            crystal8.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.2, (float)-115.5));

            crystal9.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)148.2, (float)-31.3));
            crystal9.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.2, (float)54.4));
            crystal9.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)133.3, (float)49.3));
            crystal9.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)143.8, (float)7.8));
            crystal9.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)135.2, (float)0.3));
            crystal9.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)135.4, (float)-13.8));
            crystal9.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.2, (float)-29.2));
            crystal9.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)148.2, (float)-31.3));

            crystal10.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)115.5));
            crystal10.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)91.4));
            crystal10.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)127.9, (float)115.2));
            crystal10.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)115.5));

            waterLeft.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-53.1, (float)61.9));
            waterLeft.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-107.8, (float)96.8));
            waterLeft.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-106.5, (float)107.4));
            waterLeft.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.5, (float)105.5));
            waterLeft.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-6.0, (float)100.7));
            waterLeft.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-53.1, (float)61.9));

            waterRight.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)52.3, (float)60.4));
            waterRight.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)8.1, (float)99.2));
            waterRight.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)9.1, (float)107.1));
            waterRight.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)106.5, (float)104.3));
            waterRight.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)109.6, (float)96.8));
            waterRight.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)52.3, (float)62.2));

            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-113.5, (float)-113.7));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-101.6, (float)-104.6));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-86.7, (float)-109.8));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-79.7, (float)-103.4));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-76.8, (float)-85.1));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.9, (float)-81.5));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-62.8, (float)-90.2));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-48.4, (float)-97.4));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-46.6, (float)-95.0));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-45.1, (float)-83.3));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-40.6, (float)-74.0));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-35.4, (float)-78.2));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.0, (float)-82.7));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-22.9, (float)-86.9));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-13.5, (float)-76.7));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-18.0, (float)-60.4));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-13.8, (float)-51.1));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.2, (float)-50.8));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.2, (float)-33.4));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-15.6, (float)-25.0));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-14.8, (float)-19.5));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.5, (float)-12.9));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.2, (float)-8.7));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)0.5, (float)-1.8));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)12.2, (float)-7.2));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)13.0, (float)-15.0));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)17.7, (float)-20.4));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)17.2, (float)-28.0));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)8.9, (float)-37.6));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)10.9, (float)-50.2));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)16.9, (float)-55.0));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)19.3, (float)-61.9));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)14.8, (float)-77.6));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)24.7, (float)-86.0));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)35.2, (float)-81.8));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)38.3, (float)-74.9));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.7, (float)-89.9));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)45.8, (float)-95.3));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)49.7, (float)-98.9));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)56.8, (float)-93.5));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)66.9, (float)-91.4));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)69.5, (float)-84.5));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)74.5, (float)-82.4));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)78.1, (float)-91.1));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)79.4, (float)-100.7));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)84.1, (float)-111.0));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)88.8, (float)-107.1));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)100.8, (float)-101.3));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)108.9, (float)-102.8));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)119.0, (float)-113.7));
            crystal0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-113.5, (float)-113.7));

            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)68.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-28.9, (float)-2.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-119.5, (float)-75.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-119.5, (float)87.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-52.3, (float)48.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-1.3, (float)92.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)51.3, (float)49.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)118.8, (float)86.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)119.3, (float)-73.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)30.5, (float)-2.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)68.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)80.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)12.5, (float)-1.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)129.7, (float)-95.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)128.1, (float)104.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)52.9, (float)61.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)3.4, (float)101.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-52.6, (float)62.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-128.6, (float)105.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-128.4, (float)-96.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.0, (float)-0.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)79.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)68.6));


            newAreas.Add(new AreaModel("land0", new Assets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("water0", new Assets.Scripts.Simulation.SMath.Polygon(waterLeft), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Assets.Scripts.Simulation.SMath.Polygon(waterRight), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("crystal0", new Assets.Scripts.Simulation.SMath.Polygon(crystal0), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal1", new Assets.Scripts.Simulation.SMath.Polygon(crystal1), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal2", new Assets.Scripts.Simulation.SMath.Polygon(crystal2), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal3", new Assets.Scripts.Simulation.SMath.Polygon(crystal3), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal4", new Assets.Scripts.Simulation.SMath.Polygon(crystal4), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal5", new Assets.Scripts.Simulation.SMath.Polygon(crystal5), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal6", new Assets.Scripts.Simulation.SMath.Polygon(crystal6), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal7", new Assets.Scripts.Simulation.SMath.Polygon(crystal7), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal8", new Assets.Scripts.Simulation.SMath.Polygon(crystal8), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal9", new Assets.Scripts.Simulation.SMath.Polygon(crystal9), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal10", new Assets.Scripts.Simulation.SMath.Polygon(crystal10), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("track", new Assets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));


            //newAreas.Add(new AreaModel("bush2", new Assets.Scripts.Simulation.SMath.Polygon(bushRight), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

            return (Il2CppReferenceArray<AreaModel>)newAreas.ToArray();
        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "MainPath",
                    }), new SplitterModel("", new string[]
                    {
                        "MainPath",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("MainPath", mainTrack(), true, false, new Vector3(), new Vector3(), null, null),
                    };
        }
    }
}