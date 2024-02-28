using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class InTheWall
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(150.1, (float)69.8));
            list.Add( MapHelper.AddPoint(145.3, (float)69.5));
            list.Add( MapHelper.AddPoint(141.9, (float)68.9));
            list.Add( MapHelper.AddPoint(139.8, (float)67.1));
            list.Add( MapHelper.AddPoint(138.5, (float)64.0));
            list.Add( MapHelper.AddPoint(138.0, (float)61.0));
            list.Add( MapHelper.AddPoint(137.2, (float)20.1));
            list.Add( MapHelper.AddPoint(137.0, (float)16.5));
            list.Add( MapHelper.AddPoint(134.6, (float)13.2));
            list.Add( MapHelper.AddPoint(131.8, (float)11.1));
            list.Add( MapHelper.AddPoint(127.6, (float)11.4));
            list.Add( MapHelper.AddPoint(116.7, (float)11.7));
            list.Add( MapHelper.AddPoint(114.3, (float)11.7));
            list.Add( MapHelper.AddPoint(111.2, (float)9.6));
            list.Add( MapHelper.AddPoint(110.2, (float)7.5));
            list.Add( MapHelper.AddPoint(108.6, (float)3.9));
            list.Add( MapHelper.AddPoint(108.6, (float)1.5));
            list.Add( MapHelper.AddPoint(107.6, (float)-37.3));
            list.Add( MapHelper.AddPoint(107.8, (float)-40.6));
            list.Add( MapHelper.AddPoint(107.0, (float)-43.6));
            list.Add( MapHelper.AddPoint(106.0, (float)-46.6));
            list.Add( MapHelper.AddPoint(104.7, (float)-48.1));
            list.Add( MapHelper.AddPoint(102.3, (float)-48.7));
            list.Add( MapHelper.AddPoint(97.7, (float)-48.4));
            list.Add( MapHelper.AddPoint(85.7, (float)-48.7));
            list.Add( MapHelper.AddPoint(83.6, (float)-48.7));
            list.Add( MapHelper.AddPoint(80.5, (float)-50.2));
            list.Add( MapHelper.AddPoint(78.4, (float)-53.2));
            list.Add( MapHelper.AddPoint(77.9, (float)-55.9));
            list.Add( MapHelper.AddPoint(76.8, (float)-91.7));
            list.Add( MapHelper.AddPoint(76.3, (float)-96.2));
            list.Add( MapHelper.AddPoint(74.2, (float)-99.5));
            list.Add( MapHelper.AddPoint(71.9, (float)-101.6));
            list.Add( MapHelper.AddPoint(65.9, (float)-101.6));
            list.Add( MapHelper.AddPoint(48.4, (float)-102.2));
            list.Add( MapHelper.AddPoint(46.1, (float)-101.9));
            list.Add( MapHelper.AddPoint(43.2, (float)-101.3));
            list.Add( MapHelper.AddPoint(41.4, (float)-99.8));
            list.Add( MapHelper.AddPoint(40.4, (float)-94.7));
            list.Add( MapHelper.AddPoint(39.1, (float)70.4));
            list.Add( MapHelper.AddPoint(38.0, (float)77.6));
            list.Add( MapHelper.AddPoint(36.2, (float)80.3));
            list.Add( MapHelper.AddPoint(33.1, (float)82.1));
            list.Add( MapHelper.AddPoint(32.6, (float)82.1));
            list.Add( MapHelper.AddPoint(27.9, (float)82.1));
            list.Add( MapHelper.AddPoint(7.3, (float)82.4));
            list.Add( MapHelper.AddPoint(2.9, (float)82.4));
            list.Add( MapHelper.AddPoint(0.3, (float)80.3));
            list.Add( MapHelper.AddPoint(-1.0, (float)77.6));
            list.Add( MapHelper.AddPoint(-1.6, (float)73.4));
            list.Add( MapHelper.AddPoint(-2.1, (float)-88.7));
            list.Add( MapHelper.AddPoint(-2.3, (float)-93.5));
            list.Add( MapHelper.AddPoint(-2.3, (float)-96.5));
            list.Add( MapHelper.AddPoint(-5.5, (float)-100.1));
            list.Add( MapHelper.AddPoint(-9.6, (float)-101.9));
            list.Add( MapHelper.AddPoint(-30.5, (float)-102.2));
            list.Add( MapHelper.AddPoint(-33.6, (float)-101.9));
            list.Add( MapHelper.AddPoint(-37.5, (float)-100.1));
            list.Add( MapHelper.AddPoint(-39.1, (float)-97.4));
            list.Add( MapHelper.AddPoint(-39.8, (float)-92.9));
            list.Add( MapHelper.AddPoint(-40.9, (float)-58.0));
            list.Add( MapHelper.AddPoint(-41.4, (float)-55.9));
            list.Add( MapHelper.AddPoint(-42.4, (float)-51.7));
            list.Add( MapHelper.AddPoint(-44.0, (float)-50.8));
            list.Add( MapHelper.AddPoint(-47.7, (float)-50.2));
            list.Add( MapHelper.AddPoint(-62.8, (float)-49.3));
            list.Add( MapHelper.AddPoint(-65.6, (float)-49.3));
            list.Add( MapHelper.AddPoint(-69.8, (float)-46.6));
            list.Add( MapHelper.AddPoint(-70.1, (float)-43.9));
            list.Add( MapHelper.AddPoint(-70.8, (float)-40.0));
            list.Add( MapHelper.AddPoint(-71.1, (float)1.8));
            list.Add( MapHelper.AddPoint(-72.1, (float)5.7));
            list.Add( MapHelper.AddPoint(-73.4, (float)7.8));
            list.Add( MapHelper.AddPoint(-75.8, (float)10.2));
            list.Add( MapHelper.AddPoint(-78.9, (float)10.8));
            list.Add( MapHelper.AddPoint(-91.4, (float)11.1));
            list.Add( MapHelper.AddPoint(-94.5, (float)10.8));
            list.Add( MapHelper.AddPoint(-98.7, (float)13.2));
            list.Add( MapHelper.AddPoint(-99.7, (float)15.6));
            list.Add( MapHelper.AddPoint(-99.7, (float)19.2));
            list.Add( MapHelper.AddPoint(-101.6, (float)57.4));
            list.Add( MapHelper.AddPoint(-102.1, (float)61.6));
            list.Add( MapHelper.AddPoint(-103.4, (float)64.0));
            list.Add( MapHelper.AddPoint(-105.5, (float)67.1));
            list.Add( MapHelper.AddPoint(-108.1, (float)67.4));
            list.Add( MapHelper.AddPoint(-111.5, (float)68.0));
            list.Add( MapHelper.AddPoint(-149.9, (float)68.9));


            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var water0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var water1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var wall = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var rubble0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var rubble1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();

            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)47.7, (float)115.5));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)52.3, (float)109.5));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)62.0, (float)114.0));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)79.4, (float)107.7));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)83.3, (float)112.8));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)93.2, (float)108.3));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)92.4, (float)104.3));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)100.3, (float)102.2));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)104.2, (float)94.7));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)111.5, (float)89.0));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)114.3, (float)87.5));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)115.9, (float)88.7));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)124.2, (float)84.8));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)130.5, (float)84.8));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)136.7, (float)84.2));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)144.0, (float)84.2));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)86.3));
            rubble1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.0, (float)115.5));

            rubble0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.2, (float)115.5));
            rubble0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-148.7, (float)98.9));
            rubble0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-141.1, (float)98.3));
            rubble0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-125.3, (float)104.6));
            rubble0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-125.8, (float)105.8));
            rubble0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-128.4, (float)114.9));

            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)9.4, (float)-113.7));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)10.4, (float)-83.6));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)6.5, (float)-83.9));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)2.3, (float)-64.4));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)7.3, (float)-64.0));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)7.6, (float)-61.6));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)2.9, (float)-59.5));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)6.0, (float)-51.1));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)9.4, (float)-52.6));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)10.2, (float)11.7));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)6.8, (float)8.1));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)3.4, (float)13.8));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)8.3, (float)24.1));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)1.0, (float)25.6));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)4.7, (float)43.6));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)3.6, (float)50.5));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)6.0, (float)55.6));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)10.4, (float)54.7));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)3.4, (float)59.5));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)6.8, (float)69.5));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)26.3, (float)69.5));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)31.0, (float)67.1));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)35.7, (float)59.2));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)35.4, (float)20.7));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)40.9, (float)10.2));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)40.9, (float)-49.3));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)35.7, (float)-55.6));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)35.7, (float)-80.6));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)39.8, (float)-84.2));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)40.4, (float)-108.9));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)42.4, (float)-109.2));
            wall.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)43.0, (float)-114.9));

            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)67.7, (float)-34.6));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)64.8, (float)-23.5));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)65.4, (float)15.6));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)77.1, (float)19.2));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)92.4, (float)18.3));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)95.3, (float)-9.0));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)91.4, (float)-33.1));

            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-144.8, (float)55.0));
            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-116.1, (float)53.8));
            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-113.3, (float)29.2));
            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-116.4, (float)2.4));
            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-143.5, (float)0.6));

            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)58.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)146.6, (float)58.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)145.6, (float)9.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)137.8, (float)0.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)117.2, (float)0.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)117.4, (float)-49.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)107.3, (float)-58.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)85.9, (float)-59.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)85.9, (float)-113.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)34.9, (float)-112.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)31.5, (float)73.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)6.0, (float)74.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)5.2, (float)-112.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-48.4, (float)-113.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-48.2, (float)-58.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-69.5, (float)-58.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-78.1, (float)-48.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-78.6, (float)0.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-100.0, (float)1.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-108.6, (float)13.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-109.4, (float)58.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)58.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)78.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-101.8, (float)79.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-93.5, (float)70.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-92.2, (float)21.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-73.4, (float)20.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-64.3, (float)10.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-62.8, (float)-38.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-42.2, (float)-39.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-33.6, (float)-49.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-32.6, (float)-89.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-9.6, (float)-90.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-9.6, (float)80.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-6.5, (float)88.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-1.8, (float)92.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)38.5, (float)92.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)44.0, (float)89.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)46.6, (float)83.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)47.4, (float)-91.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)69.5, (float)-91.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)70.6, (float)-49.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)72.4, (float)-45.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)78.6, (float)-39.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)100.3, (float)-38.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)102.1, (float)7.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)104.2, (float)17.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)111.5, (float)20.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)128.9, (float)20.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)130.2, (float)68.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)133.6, (float)75.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)137.8, (float)78.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)78.2));

            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            newAreas.Add(new AreaModel("land0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(water0), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(water1), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("rubble0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(rubble0), Main.Empty(), 10, AreaType.unplaceable));
            newAreas.Add(new AreaModel("rubble1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(rubble1), Main.Empty(), 10, AreaType.unplaceable));

            newAreas.Add(new AreaModel("wall", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(wall), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

            return (Il2CppReferenceArray<AreaModel>)newAreas.ToArray();
        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "MainPath",
                    }, ""), new SplitterModel("", new string[]
                    {
                        "MainPath",
                    }, ""));
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