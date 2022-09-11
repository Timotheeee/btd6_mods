using Assets.Scripts.Models.Map;
using Assets.Scripts.Models.Map.Spawners;
using Assets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;

namespace custommaps.Maps.BTDBattles2
{
    class Ports
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(132.8, (float)115.5));
            list.Add(MapHelper.AddPoint(134.1, (float)-91.1));
            list.Add(MapHelper.AddPoint(134.1, (float)-95.3));
            list.Add(MapHelper.AddPoint(132.6, (float)-98.3));
            list.Add(MapHelper.AddPoint(130.2, (float)-100.7));
            list.Add(MapHelper.AddPoint(125.8, (float)-101.6));
            list.Add(MapHelper.AddPoint(47.4, (float)-101.9));
            list.Add(MapHelper.AddPoint(5.2, (float)-101.3));
            list.Add(MapHelper.AddPoint(2.1, (float)-101.0));
            list.Add(MapHelper.AddPoint(0.5, (float)-99.5));
            list.Add(MapHelper.AddPoint(-0.5, (float)-98.0));
            list.Add(MapHelper.AddPoint(-1.3, (float)-93.8));
            list.Add(MapHelper.AddPoint(-1.8, (float)-74.0));
            list.Add(MapHelper.AddPoint(-1.8, (float)-70.1));
            list.Add(MapHelper.AddPoint(-2.6, (float)-68.0));
            list.Add(MapHelper.AddPoint(-4.4, (float)-66.8));
            list.Add(MapHelper.AddPoint(-7.8, (float)-65.3));
            list.Add(MapHelper.AddPoint(-46.4, (float)-65.3));
            list.Add(MapHelper.AddPoint(-48.2, (float)-65.3));
            list.Add(MapHelper.AddPoint(-50.5, (float)-65.3));
            list.Add(MapHelper.AddPoint(-52.1, (float)-67.4));
            list.Add(MapHelper.AddPoint(-53.6, (float)-69.5));
            list.Add(MapHelper.AddPoint(-53.9, (float)-72.8));
            list.Add(MapHelper.AddPoint(-53.9, (float)-92.6));
            list.Add(MapHelper.AddPoint(-53.9, (float)-95.3));
            list.Add(MapHelper.AddPoint(-55.5, (float)-98.9));
            list.Add(MapHelper.AddPoint(-58.1, (float)-101.0));
            list.Add(MapHelper.AddPoint(-60.7, (float)-101.6));
            list.Add(MapHelper.AddPoint(-104.4, (float)-101.6));
            list.Add(MapHelper.AddPoint(-108.3, (float)-101.6));
            list.Add(MapHelper.AddPoint(-110.9, (float)-103.7));
            list.Add(MapHelper.AddPoint(-112.2, (float)-105.8));
            list.Add(MapHelper.AddPoint(-112.2, (float)-114.3));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(132.8, (float)115.5));
            list.Add(MapHelper.AddPoint(134.1, (float)-91.1));
            list.Add(MapHelper.AddPoint(134.1, (float)-95.3));
            list.Add(MapHelper.AddPoint(132.6, (float)-98.3));
            list.Add(MapHelper.AddPoint(130.2, (float)-100.7));
            list.Add(MapHelper.AddPoint(125.8, (float)-101.6));
            list.Add(MapHelper.AddPoint(47.4, (float)-101.9));
            list.Add(MapHelper.AddPoint(44.8, (float)-101.6));
            list.Add(MapHelper.AddPoint(42.4, (float)-99.8));
            list.Add(MapHelper.AddPoint(41.7, (float)-97.7));
            list.Add(MapHelper.AddPoint(40.9, (float)-93.8));
            list.Add(MapHelper.AddPoint(39.8, (float)93.5));
            list.Add(MapHelper.AddPoint(39.3, (float)96.2));
            list.Add(MapHelper.AddPoint(38.5, (float)98.3));
            list.Add(MapHelper.AddPoint(37.2, (float)99.5));
            list.Add(MapHelper.AddPoint(33.6, (float)101.0));
            list.Add(MapHelper.AddPoint(-40.4, (float)101.9));
            list.Add(MapHelper.AddPoint(-43.2, (float)101.0));
            list.Add(MapHelper.AddPoint(-45.1, (float)99.5));
            list.Add(MapHelper.AddPoint(-46.9, (float)97.4));
            list.Add(MapHelper.AddPoint(-46.6, (float)93.8));
            list.Add(MapHelper.AddPoint(-48.2, (float)74.0));
            list.Add(MapHelper.AddPoint(-48.4, (float)70.7));
            list.Add(MapHelper.AddPoint(-49.7, (float)67.4));
            list.Add(MapHelper.AddPoint(-52.1, (float)67.1));
            list.Add(MapHelper.AddPoint(-54.4, (float)66.8));
            list.Add(MapHelper.AddPoint(-88.3, (float)66.2));
            list.Add(MapHelper.AddPoint(-91.4, (float)65.9));
            list.Add(MapHelper.AddPoint(-93.5, (float)67.4));
            list.Add(MapHelper.AddPoint(-94.0, (float)69.8));
            list.Add(MapHelper.AddPoint(-94.8, (float)73.1));
            list.Add(MapHelper.AddPoint(-95.8, (float)93.2));
            list.Add(MapHelper.AddPoint(-95.8, (float)96.2));
            list.Add(MapHelper.AddPoint(-97.4, (float)99.5));
            list.Add(MapHelper.AddPoint(-100.0, (float)101.0));
            list.Add(MapHelper.AddPoint(-103.1, (float)101.6));
            list.Add(MapHelper.AddPoint(-149.0, (float)102.5));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var containers0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var containers1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var sewers = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();

            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)139.3, (float)114.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)140.1, (float)-98.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)134.4, (float)-111.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-2.6, (float)-109.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-5.2, (float)-107.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-8.6, (float)-102.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-8.3, (float)-73.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.9, (float)-71.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-46.1, (float)-73.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-47.4, (float)-75.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-47.1, (float)-100.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-48.7, (float)-105.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-54.7, (float)-109.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-104.9, (float)-111.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-105.2, (float)-115.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-120.1, (float)-114.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-120.1, (float)-104.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-117.7, (float)-96.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-115.6, (float)-92.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-61.5, (float)-91.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-61.5, (float)-62.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-57.8, (float)-59.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)1.0, (float)-57.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)4.2, (float)-63.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)5.2, (float)-90.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)7.6, (float)-93.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)32.3, (float)-92.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)32.0, (float)92.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-40.6, (float)91.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-41.1, (float)65.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-44.5, (float)58.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-101.6, (float)57.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-103.6, (float)89.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.2, (float)91.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)113.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-97.4, (float)110.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-92.2, (float)107.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-90.6, (float)103.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-89.6, (float)75.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-54.9, (float)74.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-55.2, (float)99.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-50.8, (float)109.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)39.3, (float)111.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)45.6, (float)106.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.4, (float)102.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.7, (float)-91.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)125.5, (float)-92.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)126.3, (float)114.6));

            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)124.2, (float)-90.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)83.6, (float)-91.4));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)83.9, (float)-37.0));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)80.7, (float)-31.6));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)79.4, (float)47.8));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)82.3, (float)50.2));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)81.2, (float)103.4));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)124.5, (float)102.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)124.5, (float)-85.4));

            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-54.2, (float)-53.8));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-54.2, (float)53.2));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.2, (float)54.4));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-9.9, (float)-54.1));

            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-122.4, (float)-56.5));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-123.7, (float)-92.0));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-91.1));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)91.4));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-105.5, (float)91.4));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-105.2, (float)59.2));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-99.7, (float)54.1));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-98.2, (float)-53.2));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-118.5, (float)-55.0));

            containers0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)140.4, (float)98.6));
            containers0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)139.8, (float)-98.6));
            containers0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-99.5));
            containers0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)99.8));

            containers1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)78.6, (float)106.4));
            containers1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.4, (float)106.1));
            containers1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.1, (float)-90.8));
            containers1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)79.4, (float)-91.1));

            sewers.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.2, (float)-55.0));
            sewers.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.4, (float)56.2));
            sewers.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)1.8, (float)55.0));
            sewers.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)0.3, (float)-55.3));

            newAreas.Add(new AreaModel("land0", new Assets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track0", new Assets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Assets.Scripts.Simulation.SMath.Polygon(water0), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Assets.Scripts.Simulation.SMath.Polygon(water1), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water2", new Assets.Scripts.Simulation.SMath.Polygon(water2), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("containers0", new Assets.Scripts.Simulation.SMath.Polygon(containers0), Main.Empty(), 10, AreaType.unplaceable));
            newAreas.Add(new AreaModel("containers1", new Assets.Scripts.Simulation.SMath.Polygon(containers1), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("sewers", new Assets.Scripts.Simulation.SMath.Polygon(sewers), Main.Empty(), 10, AreaType.unplaceable));

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