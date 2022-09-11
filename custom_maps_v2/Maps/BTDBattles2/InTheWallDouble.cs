using Assets.Scripts.Models.Map;
using Assets.Scripts.Models.Map.Spawners;
using Assets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;

namespace custommaps.Maps.BTDBattles2
{
    class InTheWallDouble
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-31.5, (float)115.5));
            list.Add( MapHelper.AddPoint(-30.5, (float)84.5));
            list.Add( MapHelper.AddPoint(-33.6, (float)80.0));
            list.Add( MapHelper.AddPoint(-63.5, (float)78.5));
            list.Add( MapHelper.AddPoint(-65.9, (float)77.9));
            list.Add( MapHelper.AddPoint(-68.0, (float)74.0));
            list.Add( MapHelper.AddPoint(-68.0, (float)62.8));
            list.Add( MapHelper.AddPoint(-69.8, (float)58.0));
            list.Add( MapHelper.AddPoint(-72.7, (float)57.1));
            list.Add( MapHelper.AddPoint(-100.5, (float)56.2));
            list.Add( MapHelper.AddPoint(-104.9, (float)55.0));
            list.Add( MapHelper.AddPoint(-107.0, (float)52.3));
            list.Add( MapHelper.AddPoint(-107.0, (float)40.3));
            list.Add( MapHelper.AddPoint(-108.1, (float)37.6));
            list.Add( MapHelper.AddPoint(-110.7, (float)33.1));
            list.Add( MapHelper.AddPoint(-134.9, (float)32.5));
            list.Add( MapHelper.AddPoint(-139.6, (float)31.0));
            list.Add( MapHelper.AddPoint(-140.9, (float)28.3));
            list.Add( MapHelper.AddPoint(-141.4, (float)8.7));
            list.Add( MapHelper.AddPoint(-139.8, (float)5.1));
            list.Add( MapHelper.AddPoint(-135.7, (float)3.6));
            list.Add( MapHelper.AddPoint(-29.4, (float)3.0));
            list.Add( MapHelper.AddPoint(-25.5, (float)3.3));
            list.Add( MapHelper.AddPoint(-22.9, (float)-0.6));
            list.Add( MapHelper.AddPoint(-22.1, (float)-19.8));
            list.Add( MapHelper.AddPoint(-22.1, (float)-23.8));
            list.Add( MapHelper.AddPoint(-25.8, (float)-27.7));
            list.Add( MapHelper.AddPoint(-140.6, (float)-30.7));
            list.Add( MapHelper.AddPoint(-141.1, (float)-35.2));
            list.Add( MapHelper.AddPoint(-140.4, (float)-51.1));
            list.Add( MapHelper.AddPoint(-139.3, (float)-55.9));
            list.Add( MapHelper.AddPoint(-137.8, (float)-57.1));
            list.Add( MapHelper.AddPoint(-113.8, (float)-58.3));
            list.Add( MapHelper.AddPoint(-109.4, (float)-59.2));
            list.Add( MapHelper.AddPoint(-108.1, (float)-61.3));
            list.Add( MapHelper.AddPoint(-106.8, (float)-76.4));
            list.Add( MapHelper.AddPoint(-105.2, (float)-79.4));
            list.Add( MapHelper.AddPoint(-102.1, (float)-81.8));
            list.Add( MapHelper.AddPoint(-74.5, (float)-82.4));
            list.Add( MapHelper.AddPoint(-71.1, (float)-83.3));
            list.Add( MapHelper.AddPoint(-69.8, (float)-85.4));
            list.Add( MapHelper.AddPoint(-68.5, (float)-97.4));
            list.Add( MapHelper.AddPoint(-67.7, (float)-100.7));
            list.Add( MapHelper.AddPoint(-63.5, (float)-103.7));
            list.Add( MapHelper.AddPoint(60.2, (float)-104.6));
            list.Add( MapHelper.AddPoint(64.1, (float)-103.1));
            list.Add( MapHelper.AddPoint(67.7, (float)-99.2));
            list.Add( MapHelper.AddPoint(69.0, (float)-86.9));
            list.Add( MapHelper.AddPoint(70.8, (float)-83.9));
            list.Add( MapHelper.AddPoint(73.4, (float)-82.7));
            list.Add( MapHelper.AddPoint(100.8, (float)-81.5));
            list.Add( MapHelper.AddPoint(103.1, (float)-80.9));
            list.Add( MapHelper.AddPoint(105.2, (float)-78.5));
            list.Add( MapHelper.AddPoint(108.1, (float)-63.1));
            list.Add( MapHelper.AddPoint(107.8, (float)-60.7));
            list.Add( MapHelper.AddPoint(110.7, (float)-58.9));
            list.Add( MapHelper.AddPoint(135.7, (float)-58.3));
            list.Add( MapHelper.AddPoint(139.8, (float)-56.8));
            list.Add( MapHelper.AddPoint(140.4, (float)-54.1));
            list.Add( MapHelper.AddPoint(141.7, (float)-35.2));
            list.Add( MapHelper.AddPoint(141.1, (float)-32.2));
            list.Add( MapHelper.AddPoint(134.9, (float)-31.0));
            list.Add( MapHelper.AddPoint(30.5, (float)-28.6));
            list.Add( MapHelper.AddPoint(24.7, (float)-27.4));
            list.Add( MapHelper.AddPoint(23.4, (float)-25.0));
            list.Add( MapHelper.AddPoint(22.1, (float)-3.3));
            list.Add( MapHelper.AddPoint(22.4, (float)0.0));
            list.Add( MapHelper.AddPoint(25.3, (float)1.8));
            list.Add( MapHelper.AddPoint(134.9, (float)3.0));
            list.Add( MapHelper.AddPoint(140.1, (float)4.2));
            list.Add( MapHelper.AddPoint(141.4, (float)7.2));
            list.Add( MapHelper.AddPoint(140.4, (float)28.0));
            list.Add( MapHelper.AddPoint(137.5, (float)30.7));
            list.Add( MapHelper.AddPoint(133.6, (float)31.3));
            list.Add( MapHelper.AddPoint(112.0, (float)32.2));
            list.Add( MapHelper.AddPoint(109.1, (float)33.7));
            list.Add( MapHelper.AddPoint(108.6, (float)36.7));
            list.Add( MapHelper.AddPoint(107.6, (float)49.3));
            list.Add( MapHelper.AddPoint(107.0, (float)52.3));
            list.Add( MapHelper.AddPoint(103.1, (float)55.9));
            list.Add( MapHelper.AddPoint(75.5, (float)57.4));
            list.Add( MapHelper.AddPoint(72.1, (float)57.4));
            list.Add( MapHelper.AddPoint(70.1, (float)60.4));
            list.Add( MapHelper.AddPoint(68.2, (float)73.4));
            list.Add( MapHelper.AddPoint(66.9, (float)77.0));
            list.Add( MapHelper.AddPoint(64.1, (float)78.5));
            list.Add( MapHelper.AddPoint(39.6, (float)79.7));
            list.Add( MapHelper.AddPoint(35.9, (float)79.4));
            list.Add( MapHelper.AddPoint(32.8, (float)81.2));
            list.Add( MapHelper.AddPoint(31.5, (float)85.7));
            list.Add( MapHelper.AddPoint(31.3, (float)115.5));


            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var wall0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var wall1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();

            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            wall1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)32.0, (float)-24.7));
            wall1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-30.4));
            wall1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-6.9));
            wall1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)30.7, (float)-4.8));
            wall1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)31.0, (float)-23.8));


            wall0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)-31.9));
            wall0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.6, (float)-25.3));
            wall0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.0, (float)-4.2));
            wall0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-6.0));
            wall0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-29.8));

            water3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)41.4, (float)90.8));
            water3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)40.1, (float)113.7));
            water3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)74.2, (float)112.5));
            water3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)75.8, (float)88.4));

            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.6, (float)-69.8));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.3, (float)-49.3));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)97.1, (float)-49.0));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)97.7, (float)-71.3));
            water2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)65.1, (float)-69.8));

            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.2, (float)90.5));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-75.0, (float)112.5));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-40.4, (float)114.0));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-40.6, (float)90.5));

            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-97.1, (float)-72.8));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-97.7, (float)-50.2));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-63.8, (float)-50.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-62.8, (float)-71.0));

            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-37.5, (float)115.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-37.5, (float)85.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-69.0, (float)84.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-75.0, (float)80.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-73.7, (float)64.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-108.9, (float)62.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.6, (float)56.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-113.8, (float)39.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.2, (float)37.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.2, (float)-5.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-28.4, (float)-3.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-28.9, (float)-22.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)-22.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-65.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-113.5, (float)-64.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-113.3, (float)-86.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.7, (float)-88.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-75.5, (float)-102.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-70.8, (float)-111.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)68.5, (float)-111.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)75.3, (float)-105.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)75.5, (float)-89.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)107.8, (float)-89.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)114.8, (float)-82.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)114.6, (float)-64.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.5, (float)-65.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)147.9, (float)-22.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)28.9, (float)-23.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)28.9, (float)-4.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)148.7, (float)-4.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)40.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)115.4, (float)40.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)114.3, (float)55.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)109.4, (float)63.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)76.3, (float)63.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)75.0, (float)76.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)69.8, (float)86.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)38.0, (float)86.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)38.0, (float)115.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)25.0, (float)115.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)24.0, (float)78.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)28.4, (float)72.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)60.7, (float)74.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)61.7, (float)57.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)66.9, (float)49.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)100.8, (float)50.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)100.8, (float)32.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)106.3, (float)26.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)135.4, (float)25.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)135.7, (float)10.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)21.1, (float)9.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)15.9, (float)3.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)15.4, (float)-28.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)19.3, (float)-34.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)135.7, (float)-34.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)135.7, (float)-53.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)108.3, (float)-52.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)101.3, (float)-58.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)101.3, (float)-73.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)67.7, (float)-76.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)61.7, (float)-81.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)62.8, (float)-96.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-62.0, (float)-97.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-62.0, (float)-85.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-69.0, (float)-75.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-98.7, (float)-74.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-99.0, (float)-61.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-104.2, (float)-52.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.9, (float)-52.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-136.7, (float)-34.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-23.2, (float)-34.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-15.6, (float)-29.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-14.8, (float)1.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-18.8, (float)9.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.1, (float)9.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.6, (float)24.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-109.4, (float)27.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-100.5, (float)32.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-100.8, (float)47.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-68.8, (float)49.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-61.2, (float)56.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-61.2, (float)70.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-30.7, (float)74.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-24.2, (float)78.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-23.7, (float)115.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-37.2, (float)115.5));


            newAreas.Add(new AreaModel("land0", new Assets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track", new Assets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Assets.Scripts.Simulation.SMath.Polygon(water0), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Assets.Scripts.Simulation.SMath.Polygon(water1), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water2", new Assets.Scripts.Simulation.SMath.Polygon(water2), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water3", new Assets.Scripts.Simulation.SMath.Polygon(water3), Main.Empty(), 10, AreaType.water));

            newAreas.Add(new AreaModel("wall0", new Assets.Scripts.Simulation.SMath.Polygon(wall0), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("wall1", new Assets.Scripts.Simulation.SMath.Polygon(wall1), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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