using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class BasaltColumns
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(MapHelper.AddPoint(-149.9, -96.2));
            list.Add(MapHelper.AddPoint(-78.9, (float)-57.4));
            list.Add(MapHelper.AddPoint(-76.3, (float)-54.4));
            list.Add(MapHelper.AddPoint(-75.3, (float)-50.8));
            list.Add(MapHelper.AddPoint(-74.7, (float)52.0));
            list.Add(MapHelper.AddPoint(-74.2, (float)56.5));
            list.Add(MapHelper.AddPoint(-71.6, (float)58.6));
            list.Add(MapHelper.AddPoint(-1.0, (float)105.2));
            list.Add(MapHelper.AddPoint(2.1, (float)107.7));
            list.Add(MapHelper.AddPoint(6.0, (float)106.1));
            list.Add(MapHelper.AddPoint(79.4, (float)59.2));
            list.Add(MapHelper.AddPoint(81.8, (float)56.8));
            list.Add(MapHelper.AddPoint(82.8, (float)52.6));
            list.Add(MapHelper.AddPoint(83.1, (float)-46.0));
            list.Add(MapHelper.AddPoint(83.1, (float)-52.0));
            list.Add(MapHelper.AddPoint(85.2, (float)-55.6));
            list.Add(MapHelper.AddPoint(149.2, (float)-99.5));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(-149.7, (float)107.7));
            list.Add(MapHelper.AddPoint(-76.8, (float)60.7));
            list.Add(MapHelper.AddPoint(-74.7, (float)57.4));
            list.Add(MapHelper.AddPoint(-73.7, (float)51.1));
            list.Add(MapHelper.AddPoint(-74.0, (float)-48.1));
            list.Add(MapHelper.AddPoint(-73.4, (float)-52.0));
            list.Add(MapHelper.AddPoint(-69.5, (float)-55.9));
            list.Add(MapHelper.AddPoint(-0.3, (float)-101.6));
            list.Add(MapHelper.AddPoint(3.6, (float)-104.6));
            list.Add(MapHelper.AddPoint(7.8, (float)-102.2));
            list.Add(MapHelper.AddPoint(76.3, (float)-58.3));
            list.Add(MapHelper.AddPoint(80.2, (float)-54.1));
            list.Add(MapHelper.AddPoint(82.8, (float)-46.6));
            list.Add(MapHelper.AddPoint(83.1, (float)48.1));
            list.Add(MapHelper.AddPoint(83.1, (float)52.9));
            list.Add(MapHelper.AddPoint(86.7, (float)58.3));
            list.Add(MapHelper.AddPoint(150.0, (float)103.1));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var track1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var track2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var waterLeft = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var waterRight = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();


            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)98.3));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-82.0, (float)49.6));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-67.2, (float)48.1));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)3.4, (float)97.1));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)75.8, (float)48.1));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)91.4, (float)49.6));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)93.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)114.0));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)83.1, (float)67.1));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)4.4, (float)115.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-72.7, (float)68.3));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-146.1, (float)115.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)115.5));
            track1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)98.3));

            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-113.4));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-72.1, (float)-63.7));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)1.6, (float)-114.9));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)10.2, (float)-114.9));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)81.8, (float)-63.1));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-111.6));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-86.3));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)90.4, (float)-48.7));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)91.9, (float)51.7));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)76.3, (float)52.6));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)77.9, (float)-46.6));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)4.9, (float)-94.7));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-68.2, (float)-47.2));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-80.5, (float)-46.3));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.2, (float)-92.6));
            track2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)-114.6));

            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-65.4, (float)-44.8));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-65.9, (float)45.7));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-46.6, (float)62.5));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-32.3, (float)49.9));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-32.3, (float)27.7));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-23.7, (float)18.9));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-24.5, (float)4.2));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-20.8, (float)0.6));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-21.9, (float)-15.9));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-33.3, (float)-24.1));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-32.0, (float)-41.2));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-40.1, (float)-46.6));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-34.4, (float)-52.9));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-43.8, (float)-59.2));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-65.4, (float)-44.8));

            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)53.4, (float)62.8));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)73.2, (float)46.3));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)73.2, (float)-45.7));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)53.9, (float)-60.7));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)36.7, (float)-50.2));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)37.8, (float)-26.2));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)33.6, (float)-20.7));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)35.7, (float)-5.1));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)29.2, (float)0.3));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)30.7, (float)9.0));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)39.1, (float)18.6));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)39.8, (float)49.9));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)53.4, (float)62.8));

            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));


            newAreas.Add(new AreaModel("land0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track1), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("track0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track2), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(waterLeft), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(waterRight), Main.Empty(), 10, AreaType.water));

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