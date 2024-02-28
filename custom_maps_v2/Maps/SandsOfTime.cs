using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class SandsOfTime
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-149.9, (float)105.5));
            list.Add( MapHelper.AddPoint(-134.9, (float)97.7));
            list.Add( MapHelper.AddPoint(107.0, (float)-75.8));
            list.Add( MapHelper.AddPoint(111.2, (float)-76.1));
            list.Add( MapHelper.AddPoint(113.8, (float)-72.2));
            list.Add( MapHelper.AddPoint(114.8, (float)71.6));
            list.Add( MapHelper.AddPoint(112.8, (float)75.8));
            list.Add( MapHelper.AddPoint(109.1, (float)77.3));
            list.Add( MapHelper.AddPoint(104.4, (float)75.8));
            list.Add( MapHelper.AddPoint(-135.4, (float)-96.8));
            list.Add( MapHelper.AddPoint(-149.9, (float)-107.4));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(150.0, (float)-105.8));
            list.Add( MapHelper.AddPoint(-104.4, (float)77.3));
            list.Add( MapHelper.AddPoint(-108.9, (float)79.1));
            list.Add( MapHelper.AddPoint(-111.5, (float)76.1));
            list.Add( MapHelper.AddPoint(-113.5, (float)71.9));
            list.Add( MapHelper.AddPoint(-113.5, (float)-71.6));
            list.Add( MapHelper.AddPoint(-112.8, (float)-74.0));
            list.Add( MapHelper.AddPoint(-109.6, (float)-76.1));
            list.Add( MapHelper.AddPoint(-105.2, (float)-74.0));
            list.Add( MapHelper.AddPoint(150.0, (float)107.4));

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
            var bush0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush3 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush5 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();

            bush5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)106.8, (float)114.6));
            bush5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)120.8, (float)105.2));
            bush5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)133.3, (float)105.5));
            bush5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.0, (float)102.5));
            bush5.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.2, (float)114.6));

            bush4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-11.5, (float)115.5));
            bush4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-6.8, (float)106.4));
            bush4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)5.7, (float)100.7));
            bush4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)14.6, (float)99.5));
            bush4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)20.6, (float)108.9));
            bush4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)21.6, (float)114.3));

            bush3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)115.5));
            bush3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)73.7));
            bush3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-145.8, (float)89.3));
            bush3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-134.6, (float)97.7));
            bush3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-125.0, (float)104.9));
            bush3.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-118.2, (float)115.2));

            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)100.3, (float)-114.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)104.4, (float)-102.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)118.8, (float)-94.7));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)130.7, (float)-95.9));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.5, (float)-96.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-92.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-114.6));

            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-47.1, (float)-114.6));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-44.3, (float)-104.9));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-37.5, (float)-93.5));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-28.1, (float)-88.4));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-17.2, (float)-83.3));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-8.1, (float)-86.0));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)0.0, (float)-88.4));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)5.2, (float)-93.2));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)6.2, (float)-101.3));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)10.9, (float)-106.1));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)3.1, (float)-110.4));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)1.8, (float)-114.3));

            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-114.9));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-118.0, (float)-114.9));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-131.5, (float)-96.8));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)-90.5));

            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)63.3, (float)-28.3));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)63.5, (float)31.9));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)103.9, (float)61.3));
            water1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)104.2, (float)-58.6));

            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-70.6, (float)-34.3));
            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-20.3, (float)1.2));
            water0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-69.8, (float)37.0));

            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)147.9, (float)-114.6));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-103.4, (float)59.2));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-104.9, (float)-58.3));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.8, (float)115.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)94.1));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-124.5, (float)-103.4));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-121.6, (float)102.2));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-92.3));

            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-148.4, (float)92.3));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)123.4, (float)-101.9));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)122.4, (float)103.4));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-90.8));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.3, (float)-114.3));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)104.4, (float)61.9));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)104.4, (float)-58.9));
            track0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-137.8, (float)110.7));

            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));


            newAreas.Add(new AreaModel("land0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track0), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("track1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track1), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(water0), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(water1), Main.Empty(), 10, AreaType.water));


            newAreas.Add(new AreaModel("bush0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush0), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush1), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush2), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush3", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush3), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush4", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush4), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush5", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush5), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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