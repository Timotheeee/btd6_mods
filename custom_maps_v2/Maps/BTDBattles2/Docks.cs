using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class Docks
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-149.9, (float)104.3));
            list.Add( MapHelper.AddPoint(-89.3, (float)106.4));
            list.Add( MapHelper.AddPoint(-84.6, (float)104.0));
            list.Add( MapHelper.AddPoint(-82.8, (float)100.7));
            list.Add( MapHelper.AddPoint(-81.2, (float)56.8));
            list.Add( MapHelper.AddPoint(-83.3, (float)52.9));
            list.Add( MapHelper.AddPoint(-85.7, (float)51.1));
            list.Add( MapHelper.AddPoint(-107.8, (float)50.8));
            list.Add( MapHelper.AddPoint(-110.2, (float)50.8));
            list.Add( MapHelper.AddPoint(-110.9, (float)49.0));
            list.Add( MapHelper.AddPoint(-112.0, (float)47.8));
            list.Add( MapHelper.AddPoint(-112.2, (float)10.5));
            list.Add( MapHelper.AddPoint(-111.5, (float)7.5));
            list.Add( MapHelper.AddPoint(-107.6, (float)4.8));
            list.Add( MapHelper.AddPoint(-84.6, (float)4.5));
            list.Add( MapHelper.AddPoint(-83.6, (float)3.0));
            list.Add( MapHelper.AddPoint(-81.5, (float)-1.2));
            list.Add( MapHelper.AddPoint(-81.5, (float)-42.1));
            list.Add( MapHelper.AddPoint(-83.1, (float)-46.3));
            list.Add( MapHelper.AddPoint(-85.9, (float)-48.7));
            list.Add( MapHelper.AddPoint(-108.3, (float)-49.3));
            list.Add( MapHelper.AddPoint(-111.2, (float)-50.8));
            list.Add( MapHelper.AddPoint(-112.2, (float)-55.3));
            list.Add( MapHelper.AddPoint(-112.0, (float)-90.5));
            list.Add( MapHelper.AddPoint(-112.0, (float)-93.8));
            list.Add( MapHelper.AddPoint(-108.1, (float)-95.6));
            list.Add( MapHelper.AddPoint(10.2, (float)-96.2));
            list.Add( MapHelper.AddPoint(8.1, (float)-94.4));
            list.Add( MapHelper.AddPoint(10.7, (float)-91.4));
            list.Add( MapHelper.AddPoint(10.2, (float)-56.2));
            list.Add( MapHelper.AddPoint(9.6, (float)-52.0));
            list.Add( MapHelper.AddPoint(6.0, (float)-49.3));
            list.Add( MapHelper.AddPoint(-14.8, (float)-49.6));
            list.Add( MapHelper.AddPoint(-19.5, (float)-47.5));
            list.Add( MapHelper.AddPoint(-20.8, (float)-43.3));
            list.Add( MapHelper.AddPoint(-21.1, (float)-3.6));
            list.Add( MapHelper.AddPoint(-19.8, (float)0.0));
            list.Add( MapHelper.AddPoint(-15.6, (float)2.4));
            list.Add( MapHelper.AddPoint(5.7, (float)4.5));
            list.Add( MapHelper.AddPoint(8.3, (float)6.9));
            list.Add( MapHelper.AddPoint(10.4, (float)10.2));
            list.Add( MapHelper.AddPoint(10.9, (float)44.8));
            list.Add( MapHelper.AddPoint(10.2, (float)48.7));
            list.Add( MapHelper.AddPoint(6.2, (float)51.1));
            list.Add( MapHelper.AddPoint(-13.8, (float)51.7));
            list.Add( MapHelper.AddPoint(-18.2, (float)52.9));
            list.Add( MapHelper.AddPoint(-20.1, (float)56.5));
            list.Add( MapHelper.AddPoint(-20.6, (float)99.2));
            list.Add( MapHelper.AddPoint(-19.3, (float)103.1));
            list.Add( MapHelper.AddPoint(-16.7, (float)104.9));
            list.Add( MapHelper.AddPoint(99.5, (float)105.5));
            list.Add( MapHelper.AddPoint(102.3, (float)104.3));
            list.Add( MapHelper.AddPoint(103.4, (float)102.2));
            list.Add( MapHelper.AddPoint(104.9, (float)98.3));
            list.Add( MapHelper.AddPoint(105.2, (float)59.5));
            list.Add( MapHelper.AddPoint(103.4, (float)55.3));
            list.Add( MapHelper.AddPoint(101.0, (float)52.0));
            list.Add( MapHelper.AddPoint(81.5, (float)51.1));
            list.Add( MapHelper.AddPoint(76.6, (float)49.3));
            list.Add( MapHelper.AddPoint(74.7, (float)45.7));
            list.Add( MapHelper.AddPoint(74.2, (float)12.9));
            list.Add( MapHelper.AddPoint(76.0, (float)5.1));
            list.Add( MapHelper.AddPoint(99.5, (float)3.6));
            list.Add( MapHelper.AddPoint(103.4, (float)0.9));
            list.Add( MapHelper.AddPoint(104.7, (float)-39.7));
            list.Add( MapHelper.AddPoint(103.4, (float)-45.7));
            list.Add( MapHelper.AddPoint(99.2, (float)-48.4));
            list.Add( MapHelper.AddPoint(80.7, (float)-49.0));
            list.Add( MapHelper.AddPoint(75.8, (float)-49.9));
            list.Add( MapHelper.AddPoint(74.5, (float)-53.8));
            list.Add( MapHelper.AddPoint(74.7, (float)-91.4));
            list.Add( MapHelper.AddPoint(77.1, (float)-94.4));
            list.Add( MapHelper.AddPoint(150.0, (float)-95.6));


            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var anchor = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var wheel = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crates0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var crates1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();

            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            crates1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-49.2, (float)50.2));
            crates1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-50.3, (float)52.9));
            crates1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-49.5, (float)58.3));
            crates1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-46.4, (float)61.6));
            crates1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-44.3, (float)65.6));
            crates1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-27.1, (float)56.5));
            crates1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-30.2, (float)42.1));
            crates1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-48.7, (float)49.3));

            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.1, (float)-7.8));
            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-51.0, (float)-13.8));
            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-51.0, (float)-10.2));
            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-38.0, (float)-15.9));
            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.6, (float)0.9));
            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-37.5, (float)10.8));
            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-46.4, (float)0.0));
            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-68.2, (float)6.6));
            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.1, (float)2.4));
            crates0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.2, (float)-5.1));

            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-61.7, (float)-56.2));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-60.7, (float)-34.9));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-47.4, (float)-33.4));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-39.1, (float)-38.2));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-36.2, (float)-46.0));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-37.2, (float)-55.9));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-43.8, (float)-60.1));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-45.6, (float)-56.2));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-52.3, (float)-54.7));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-56.3, (float)-58.9));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-62.0, (float)-56.8));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-63.3, (float)-50.5));
            anchor.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-61.7, (float)-56.2));

            wheel.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)130.5, (float)65.0));
            wheel.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)143.8, (float)65.0));
            wheel.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)147.1, (float)58.3));
            wheel.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)147.4, (float)51.7));
            wheel.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)142.4, (float)44.5));
            wheel.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)131.0, (float)45.7));
            wheel.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)130.5, (float)65.0));

            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)94.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-91.1, (float)95.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-90.4, (float)61.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.1, (float)60.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-121.1, (float)52.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-121.9, (float)3.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.8, (float)-5.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-90.9, (float)-5.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-90.4, (float)-39.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-113.3, (float)-39.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-121.6, (float)-48.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-121.4, (float)-97.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.3, (float)-106.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)11.7, (float)-106.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)18.5, (float)-98.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)19.3, (float)-47.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)14.6, (float)-40.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.2, (float)-38.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.5, (float)-5.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)11.2, (float)-6.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)19.0, (float)2.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)19.5, (float)51.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)13.8, (float)60.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.2, (float)61.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.5, (float)94.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.8, (float)95.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.3, (float)62.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)74.0, (float)62.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)65.1, (float)52.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)65.1, (float)2.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.7, (float)-6.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)96.1, (float)-6.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.8, (float)-39.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)73.2, (float)-38.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)65.4, (float)-47.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)65.4, (float)-96.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.9, (float)-106.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)-106.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-89.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)82.0, (float)-89.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)81.8, (float)-56.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)105.2, (float)-55.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)112.0, (float)-50.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)112.8, (float)2.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)106.0, (float)10.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)81.8, (float)10.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)82.0, (float)43.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)104.4, (float)44.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)112.5, (float)51.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)112.5, (float)104.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)105.5, (float)111.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-19.0, (float)112.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.6, (float)105.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.6, (float)54.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)4.4, (float)51.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)4.9, (float)11.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-19.0, (float)10.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.3, (float)4.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.8, (float)-46.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-19.8, (float)-55.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)4.7, (float)-55.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)4.9, (float)-88.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-106.3, (float)-89.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-106.0, (float)-57.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-82.8, (float)-55.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-75.0, (float)-49.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.2, (float)1.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-81.5, (float)10.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-106.8, (float)11.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-104.7, (float)43.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-82.8, (float)44.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-75.5, (float)50.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-75.0, (float)103.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-80.7, (float)112.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)111.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)94.5));

            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)95.0));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-90.9, (float)94.7));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-91.4, (float)61.9));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.8, (float)62.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-122.1, (float)53.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-122.1, (float)2.7));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.8, (float)-6.3));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-91.4, (float)-7.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-91.7, (float)-38.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-113.0, (float)-38.2));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-122.4, (float)-46.9));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-121.9, (float)-97.7));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.1, (float)-106.7));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)12.2, (float)-106.7));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)20.8, (float)-97.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)20.3, (float)-48.1));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)12.0, (float)-38.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.2, (float)-37.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.7, (float)-6.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)12.5, (float)-6.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)21.6, (float)3.0));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)20.1, (float)50.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)12.2, (float)61.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.2, (float)62.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.7, (float)94.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.6, (float)95.0));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)96.4, (float)61.9));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.4, (float)62.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.3, (float)53.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.1, (float)3.0));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.9, (float)-7.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.6, (float)-7.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.6, (float)-38.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.7, (float)-38.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.8, (float)-48.1));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.3, (float)-97.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)73.2, (float)-108.0));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-107.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-115.2));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-114.9));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)95.0));

            newAreas.Add(new AreaModel("land0", new Assets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("water0", new Assets.Scripts.Simulation.SMath.Polygon(water), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("track0", new Assets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("crates0", new Assets.Scripts.Simulation.SMath.Polygon(crates0), Main.Empty(), 10, AreaType.unplaceable));
            newAreas.Add(new AreaModel("crates1", new Assets.Scripts.Simulation.SMath.Polygon(crates1), Main.Empty(), 10, AreaType.unplaceable));

            newAreas.Add(new AreaModel("anchor0", new Assets.Scripts.Simulation.SMath.Polygon(anchor), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("wheel0", new Assets.Scripts.Simulation.SMath.Polygon(wheel), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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