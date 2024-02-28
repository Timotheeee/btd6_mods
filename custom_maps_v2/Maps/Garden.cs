using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class Garden
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-96.6, (float)-114.9));
            list.Add( MapHelper.AddPoint(-96.9, (float)84.2));
            list.Add( MapHelper.AddPoint(-95.1, (float)89.6));
            list.Add( MapHelper.AddPoint(-91.4, (float)92.9));
            list.Add( MapHelper.AddPoint(-86.2, (float)95.3));
            list.Add( MapHelper.AddPoint(-37.0, (float)95.3));
            list.Add( MapHelper.AddPoint(-31.8, (float)93.5));
            list.Add( MapHelper.AddPoint(-29.7, (float)89.3));
            list.Add( MapHelper.AddPoint(-28.9, (float)83.9));
            list.Add( MapHelper.AddPoint(-27.1, (float)-41.2));
            list.Add( MapHelper.AddPoint(-26.3, (float)-45.4));
            list.Add( MapHelper.AddPoint(-22.9, (float)-49.0));
            list.Add( MapHelper.AddPoint(-18.5, (float)-50.8));
            list.Add( MapHelper.AddPoint(30.2, (float)-51.7));
            list.Add( MapHelper.AddPoint(34.6, (float)-49.6));
            list.Add( MapHelper.AddPoint(37.5, (float)-46.3));
            list.Add( MapHelper.AddPoint(39.8, (float)-41.2));
            list.Add( MapHelper.AddPoint(40.9, (float)83.3));
            list.Add( MapHelper.AddPoint(42.2, (float)89.0));
            list.Add( MapHelper.AddPoint(44.5, (float)92.9));
            list.Add( MapHelper.AddPoint(48.7, (float)95.3));
            list.Add( MapHelper.AddPoint(101.8, (float)94.7));
            list.Add( MapHelper.AddPoint(105.7, (float)92.9));
            list.Add( MapHelper.AddPoint(108.6, (float)89.3));
            list.Add( MapHelper.AddPoint(109.4, (float)85.7));
            list.Add( MapHelper.AddPoint(110.2, (float)-115.2));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-149.7, (float)54.7));
            list.Add( MapHelper.AddPoint(98.7, (float)52.9));
            list.Add( MapHelper.AddPoint(105.5, (float)51.1));
            list.Add( MapHelper.AddPoint(108.9, (float)44.8));
            list.Add( MapHelper.AddPoint(109.1, (float)-43.0));
            list.Add( MapHelper.AddPoint(109.6, (float)-48.4));
            list.Add( MapHelper.AddPoint(99.7, (float)-53.8));
            list.Add( MapHelper.AddPoint(-149.9, (float)-53.2));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var track0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var track1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var water0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var water1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var water2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var house = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();

            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-62.0, (float)-115.2));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-61.7, (float)-71.9));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-42.7, (float)-65.9));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)46.6, (float)-66.8));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)47.1, (float)-71.6));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)65.6, (float)-68.0));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)73.4, (float)-82.7));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)69.5, (float)-104.6));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)68.8, (float)-109.5));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)95.3, (float)-109.2));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)95.3, (float)-114.9));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-92.7, (float)-115.2));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-91.1, (float)-108.9));
            house.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-62.5, (float)-108.0));

            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-115.5));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-112.2, (float)-115.2));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-112.2, (float)-96.8));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-117.4, (float)-82.1));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-131.3, (float)-80.9));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.1, (float)-67.7));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-147.4, (float)-57.7));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-141.7, (float)-51.7));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-143.0, (float)-41.2));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-145.8, (float)-40.0));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.1, (float)-31.0));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-141.7, (float)-16.8));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-137.5, (float)-8.7));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-148.7, (float)5.4));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-143.2, (float)16.5));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-138.3, (float)23.5));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-147.9, (float)43.0));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-146.6, (float)55.9));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-140.1, (float)58.3));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-126.0, (float)81.5));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-112.2, (float)87.8));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-107.6, (float)97.7));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-109.1, (float)115.2));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)115.5));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-114.3));

            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)115.5));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)124.2, (float)115.5));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)123.7, (float)95.9));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)135.7, (float)79.1));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)145.6, (float)79.1));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)144.0, (float)61.9));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.0, (float)52.9));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.4, (float)38.8));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.0, (float)23.8));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)148.7, (float)-6.0));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.2, (float)-31.0));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)145.1, (float)-40.0));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)145.1, (float)-50.8));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.0, (float)-58.9));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)148.2, (float)-85.7));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.7, (float)-77.6));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)131.0, (float)-83.9));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)124.5, (float)-94.7));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)129.2, (float)-114.6));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)-114.6));

            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-83.1, (float)37.6));
            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-40.9, (float)38.8));
            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-39.6, (float)0.3));
            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-83.6, (float)0.6));

            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-15.4, (float)68.0));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)26.8, (float)67.4));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)26.3, (float)102.5));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-14.3, (float)102.8));

            water2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)56.5, (float)37.9));
            water2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)55.5, (float)1.2));
            water2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)98.2, (float)0.6));
            water2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)99.5, (float)38.5));

            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-103.4, (float)-114.9));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-102.9, (float)88.1));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-99.0, (float)96.2));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-90.6, (float)102.5));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-36.5, (float)102.8));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-27.3, (float)98.6));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-21.4, (float)90.2));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-21.1, (float)-39.7));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-19.0, (float)-44.2));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)29.4, (float)-43.0));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)32.8, (float)-40.6));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)34.6, (float)89.3));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)38.3, (float)96.2));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)45.6, (float)102.2));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)104.7, (float)102.8));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)112.2, (float)97.1));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)116.4, (float)89.3));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)117.2, (float)-115.5));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)102.6, (float)-114.0));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)103.1, (float)80.0));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)100.0, (float)85.7));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)50.5, (float)87.2));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)47.4, (float)83.9));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)46.9, (float)-45.4));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)42.4, (float)-52.3));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)30.5, (float)-59.8));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-22.4, (float)-59.2));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-31.0, (float)-54.1));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-35.4, (float)-43.3));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-34.9, (float)80.3));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-37.5, (float)86.6));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-85.2, (float)86.0));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-88.5, (float)83.3));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-89.1, (float)-114.6));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-103.1, (float)-114.9));

            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)-60.7));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)116.7, (float)-61.3));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)117.4, (float)61.9));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)62.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)45.4));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)102.1, (float)42.7));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)102.3, (float)-44.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-46.3));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-57.7));



            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));


            newAreas.Add(new AreaModel("land0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track0), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("track1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track1), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(water0), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(water1), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(water2), Main.Empty(), 10, AreaType.water));

            newAreas.Add(new AreaModel("bush0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush0), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush1), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("house", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(house), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

            return (Il2CppReferenceArray<AreaModel>)newAreas.ToArray();
        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "MainPath",
                        "SecondPath"
                    }, ""), new SplitterModel("", new string[]
                    {
                        "MainPath",
                        "SecondPath"
                    }, ""));
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