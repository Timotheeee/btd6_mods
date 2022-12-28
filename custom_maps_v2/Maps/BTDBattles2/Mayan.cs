using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class Mayan
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> track = new List<PointInfo>();

            track.Add( MapHelper.AddPoint(-149.9, (float)-73.7));
            track.Add( MapHelper.AddPoint(-44.0, (float)-72.5));
            track.Add( MapHelper.AddPoint(-43.2, (float)-71.6));
            track.Add( MapHelper.AddPoint(-41.9, (float)-70.1));
            track.Add( MapHelper.AddPoint(-40.6, (float)41.5));
            track.Add( MapHelper.AddPoint(-40.1, (float)45.4));
            track.Add( MapHelper.AddPoint(-38.3, (float)46.3));
            track.Add( MapHelper.AddPoint(83.9, (float)44.5));
            track.Add( MapHelper.AddPoint(85.7, (float)44.2));
            track.Add( MapHelper.AddPoint(86.5, (float)46.6));
            track.Add( MapHelper.AddPoint(87.5, (float)92.9));
            track.Add( MapHelper.AddPoint(86.2, (float)96.8));
            track.Add( MapHelper.AddPoint(82.8, (float)97.4));
            track.Add( MapHelper.AddPoint(28.4, (float)99.5));
            track.Add( MapHelper.AddPoint(26.8, (float)99.5));
            track.Add( MapHelper.AddPoint(21.6, (float)96.5));
            track.Add( MapHelper.AddPoint(22.4, (float)-21.3));
            track.Add( MapHelper.AddPoint(22.1, (float)-24.1));
            track.Add( MapHelper.AddPoint(16.1, (float)-27.4));
            track.Add( MapHelper.AddPoint(-95.3, (float)-28.0));
            track.Add( MapHelper.AddPoint(-98.2, (float)-29.8));
            track.Add( MapHelper.AddPoint(-100.5, (float)-33.4));
            track.Add( MapHelper.AddPoint(-102.9, (float)-114.3));


            return (Il2CppReferenceArray<PointInfo>)track.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> track = new List<PointInfo>();

            track.Add( MapHelper.AddPoint(-102.9, (float)-114.3));
            track.Add( MapHelper.AddPoint(-100.5, (float)-33.4));
            track.Add( MapHelper.AddPoint(-98.2, (float)-29.8));
            track.Add( MapHelper.AddPoint(-95.3, (float)-28.0));
            track.Add( MapHelper.AddPoint(16.1, (float)-27.4));
            track.Add( MapHelper.AddPoint(22.1, (float)-24.1));
            track.Add( MapHelper.AddPoint(22.4, (float)-21.3));
            track.Add( MapHelper.AddPoint(21.6, (float)96.5));
            track.Add( MapHelper.AddPoint(26.8, (float)99.5));
            track.Add( MapHelper.AddPoint(28.4, (float)99.5));
            track.Add( MapHelper.AddPoint(82.8, (float)97.4));
            track.Add( MapHelper.AddPoint(86.2, (float)96.8));
            track.Add( MapHelper.AddPoint(87.5, (float)92.9));
            track.Add( MapHelper.AddPoint(86.5, (float)46.6));
            track.Add( MapHelper.AddPoint(85.7, (float)44.2));
            track.Add( MapHelper.AddPoint(83.9, (float)44.5));
            track.Add( MapHelper.AddPoint(-38.3, (float)46.3));
            track.Add( MapHelper.AddPoint(-40.1, (float)45.4));
            track.Add( MapHelper.AddPoint(-40.6, (float)41.5));
            track.Add( MapHelper.AddPoint(-41.9, (float)-70.1));
            track.Add( MapHelper.AddPoint(-43.2, (float)-71.6));
            track.Add( MapHelper.AddPoint(-44.0, (float)-72.5));
            track.Add( MapHelper.AddPoint(-149.9, (float)-73.7));

            return (Il2CppReferenceArray<PointInfo>)track.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();

            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-44.8, (float)57.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)11.2, (float)56.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)10.9, (float)115.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-43.5, (float)115.5));

            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-68.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-48.2, (float)-67.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-47.7, (float)54.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)78.9, (float)53.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)78.6, (float)90.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)30.2, (float)90.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)30.5, (float)-39.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-92.4, (float)-38.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-93.0, (float)-115.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-111.5, (float)-114.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-109.1, (float)-18.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)14.6, (float)-17.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)13.5, (float)106.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.8, (float)106.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)96.1, (float)35.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.6, (float)35.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-33.9, (float)-82.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-82.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)-68.9));

            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            newAreas.Add(new AreaModel("land0", new Assets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track0", new Assets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Assets.Scripts.Simulation.SMath.Polygon(water), Main.Empty(), 10, AreaType.water));

            return (Il2CppReferenceArray<AreaModel>)newAreas.ToArray();
        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "MainPath",
                        "SecondPath",
                    }), new SplitterModel("", new string[]
                    {
                        "MainPath",
                        "SecondPath",
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