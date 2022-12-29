using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class BloontoniumMines
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-120.6, (float)115.5));
            list.Add( MapHelper.AddPoint(-70.3, (float)35.5));
            list.Add( MapHelper.AddPoint(-122.1, (float)-73.7));
            list.Add( MapHelper.AddPoint(109.1, (float)-74.3));
            list.Add( MapHelper.AddPoint(2.3, (float)82.4));
            list.Add( MapHelper.AddPoint(-53.4, (float)-29.2));
            list.Add( MapHelper.AddPoint(27.9, (float)-28.9));
            list.Add( MapHelper.AddPoint(-69.8, (float)115.5));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-94.3, (float)-115.2));
            list.Add( MapHelper.AddPoint(1.8, (float)82.7));
            list.Add( MapHelper.AddPoint(109.4, (float)-74.0));
            list.Add( MapHelper.AddPoint(-123.4, (float)-74.3));
            list.Add( MapHelper.AddPoint(-71.1, (float)36.1));
            list.Add( MapHelper.AddPoint(-124.2, (float)115.5));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var track0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var track1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var water = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var crystal0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var crystal1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var crystal2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var crystal3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var crystal4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();

            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-60.7));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.9, (float)-59.5));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.0, (float)-54.1));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)134.9, (float)-44.2));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)135.4, (float)-37.9));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)134.6, (float)-31.3));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)137.5, (float)-26.8));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)139.1, (float)-21.3));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)145.8, (float)-17.4));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)146.1, (float)-14.7));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)134.4, (float)-6.3));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)124.5, (float)-4.8));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)121.6, (float)-0.9));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)117.2, (float)1.2));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)116.9, (float)6.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)118.2, (float)8.4));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)119.3, (float)13.8));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)122.1, (float)28.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)127.9, (float)38.8));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)128.1, (float)44.2));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)123.7, (float)44.8));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)118.8, (float)46.6));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)112.5, (float)49.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)110.4, (float)49.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)108.3, (float)52.6));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)103.4, (float)53.2));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)100.5, (float)55.9));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)102.9, (float)61.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)107.0, (float)64.4));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)109.6, (float)65.3));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)112.0, (float)72.2));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)112.2, (float)72.2));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)113.8, (float)82.7));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)109.9, (float)84.5));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)106.3, (float)92.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)102.6, (float)96.8));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)96.1, (float)93.5));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)88.0, (float)89.6));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)82.3, (float)89.6));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)76.3, (float)90.5));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)71.9, (float)93.8));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)66.7, (float)101.3));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)60.4, (float)102.2));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)52.9, (float)100.4));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)49.7, (float)101.3));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)44.3, (float)98.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)39.3, (float)94.4));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)30.2, (float)91.1));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)25.8, (float)91.1));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)21.1, (float)95.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)16.7, (float)98.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)12.2, (float)98.0));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)7.8, (float)105.2));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)6.5, (float)113.1));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)5.7, (float)115.5));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)115.5));
            crystal4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-55.0));

            crystal3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)99.5, (float)-113.1));
            crystal3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)99.5, (float)-102.2));
            crystal3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)103.9, (float)-100.1));
            crystal3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)106.5, (float)-102.8));
            crystal3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)115.4, (float)-93.8));
            crystal3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)126.0, (float)-90.2));
            crystal3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)134.6, (float)-83.3));
            crystal3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-94.1));
            crystal3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-114.3));

            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-66.1, (float)-114.3));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-65.1, (float)-107.7));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-63.8, (float)-98.6));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-64.8, (float)-89.9));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-60.9, (float)-88.4));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-52.3, (float)-88.4));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-50.0, (float)-93.5));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-43.2, (float)-93.5));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-35.4, (float)-100.1));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-31.8, (float)-97.1));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-26.6, (float)-98.3));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-23.2, (float)-105.2));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-21.1, (float)-101.9));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-14.1, (float)-103.1));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-10.4, (float)-103.7));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-6.0, (float)-98.6));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-2.1, (float)-92.0));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)4.9, (float)-94.4));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)14.3, (float)-90.8));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)19.3, (float)-92.6));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)21.9, (float)-93.2));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)26.3, (float)-97.1));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)29.9, (float)-99.2));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)34.1, (float)-103.7));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)39.1, (float)-112.8));
            crystal2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)37.5, (float)-114.0));

            crystal1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)-114.6));
            crystal1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)-80.6));
            crystal1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-143.2, (float)-82.4));
            crystal1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-137.2, (float)-88.4));
            crystal1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-133.3, (float)-92.0));
            crystal1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-132.0, (float)-101.9));
            crystal1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-126.6, (float)-102.2));
            crystal1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-118.5, (float)-115.2));

            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)104.9));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-144.0, (float)102.5));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-133.9, (float)92.3));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-131.0, (float)74.0));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-121.9, (float)70.1));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-122.4, (float)61.3));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-127.9, (float)61.6));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-131.5, (float)46.6));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-128.4, (float)39.7));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-126.3, (float)37.6));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-127.1, (float)33.1));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-134.6, (float)33.7));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-134.9, (float)29.5));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-133.1, (float)13.2));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-133.1, (float)8.1));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.6, (float)-1.5));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.6, (float)-1.5));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.6, (float)-10.8));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.6, (float)-14.1));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-132.6, (float)-10.8));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-122.9, (float)-11.7));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-126.8, (float)-16.5));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-128.6, (float)-22.9));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-131.5, (float)-26.2));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-134.4, (float)-27.4));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-136.7, (float)-32.2));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-132.3, (float)-32.8));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-129.2, (float)-39.1));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-134.6, (float)-43.9));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-140.6, (float)-43.9));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-143.2, (float)-49.3));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-142.7, (float)-55.3));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.0, (float)-61.6));
            crystal0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.2, (float)101.9));


            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-81.5, (float)35.8));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-101.6, (float)0.0));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-124.0, (float)-49.0));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.1, (float)-43.9));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-140.6, (float)97.7));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-129.2, (float)106.4));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-119.0, (float)87.2));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-98.4, (float)58.3));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-81.2, (float)35.8));

            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-76.0, (float)115.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)16.7, (float)-22.0));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-45.8, (float)-21.3));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-52.9, (float)-35.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)41.7, (float)-35.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-61.2, (float)115.5));

            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-126.8, (float)115.2));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-76.6, (float)35.8));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-133.3, (float)-81.2));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)123.4, (float)-80.3));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)4.4, (float)96.8));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-99.0, (float)-113.7));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-85.9, (float)-113.7));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)4.7, (float)70.7));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)99.2, (float)-66.8));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-110.7, (float)-68.6));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-59.9, (float)36.7));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-115.1, (float)115.5));


            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            newAreas.Add(new AreaModel("land0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track0), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("track1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track1), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(water), Main.Empty(), 10, AreaType.water));

            newAreas.Add(new AreaModel("crystal0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(crystal0), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(crystal1), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(crystal2), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(crystal3), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crystal4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(crystal4), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

            return (Il2CppReferenceArray<AreaModel>)newAreas.ToArray();
        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "MainPath",
                        "SecondPath"
                    }), new SplitterModel("", new string[]
                    {
                        "MainPath",
                        "SecondPath"
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("MainPath", mainTrack(), true, false, new Vector3(), new Vector3(), null, null),
                        new PathModel("SecondPath", secondTrack(), true, false, new Vector3(), new Vector3(), null, null),
                    };
        }
    }
}