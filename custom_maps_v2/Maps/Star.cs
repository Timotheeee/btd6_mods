using Harmony;
using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppAssets.Scripts.Simulation.Track;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace custommaps.Maps.BTDBattles2
{
    public class Star
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(128.91, -115.17));
            list.Add(MapHelper.AddPoint(-136.46, -9.02));
            list.Add(MapHelper.AddPoint(-75.26, -115.17));
            list.Add(MapHelper.AddPoint(28.65, 58.34));
            list.Add(MapHelper.AddPoint(28.65, -115.17));


            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(128.91, -115.17));
            list.Add(MapHelper.AddPoint(-136.46, -9.02));
            list.Add(MapHelper.AddPoint(-75.26, -115.17));
            list.Add(MapHelper.AddPoint(28.65, 58.34));
            list.Add(MapHelper.AddPoint(27.34, 100.74));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new List<Vector2>();

            mainLand.Add(new Vector2(-149.9f, -115.5f));
            mainLand.Add(new Vector2(150.1f, -115.5f));
            mainLand.Add(new Vector2(150.1f, 115.5f));
            mainLand.Add(new Vector2(-149.9f, 115.5f));

            var water = new List<Vector2>();

            water.Add(new Vector2((float)-42.97, (float)-41.50));
            water.Add(new Vector2((float)14.58, (float)56.53));
            water.Add(new Vector2((float)13.54, (float)115.47));
            water.Add(new Vector2((float)-149.90, (float)115.47));
            water.Add(new Vector2((float)-149.90, (float)3.01));
            water.Add(new Vector2((float)-42.19, (float)-40.59));

            var track = new List<Vector2>();

            track.Add(new Vector2((float)119.01, (float)-115.17));
            track.Add(new Vector2((float)32.29, (float)-80.89));
            track.Add(new Vector2((float)33.85, (float)-115.17));
            track.Add(new Vector2((float)25.52, (float)-114.87));
            track.Add(new Vector2((float)26.30, (float)-79.69));
            track.Add(new Vector2((float)-33.07, (float)-54.73));
            track.Add(new Vector2((float)-67.71, (float)-115.17));
            track.Add(new Vector2((float)-81.77, (float)-115.17));
            track.Add(new Vector2((float)-146.09, (float)0.00));
            track.Add(new Vector2((float)-41.93, (float)-41.80));
            track.Add(new Vector2((float)14.84, (float)55.33));
            track.Add(new Vector2((float)14.58, (float)115.47));
            track.Add(new Vector2((float)34.64, (float)115.47));
            track.Add(new Vector2((float)34.37, (float)-72.17));
            track.Add(new Vector2((float)141.41, (float)-114.87));

            var trackHole1 = new List<Vector2>();

            trackHole1.Add(new Vector2((float)26.30, (float)-69.76));
            trackHole1.Add(new Vector2((float)-30.21, (float)-47.51));
            trackHole1.Add(new Vector2((float)26.04, (float)47.51));

            var trackHole2 = new List<Vector2>();

            trackHole2.Add(new Vector2((float)-41.15, (float)-51.72));
            trackHole2.Add(new Vector2((float)-75.00, (float)-109.76));
            trackHole2.Add(new Vector2((float)-128.39, (float)-16.54));


            newAreas.Add(new AreaModel("land0", new Polygon(mainLand), Main.Empty(), 10, AreaType.land));

            newAreas.Add(new AreaModel("water", new Polygon(water), Main.Empty(), 10, AreaType.water));

            //newAreas.Add(new AreaModel("track", new Polygon(water), new Il2CppReferenceArray<Polygon>(2) { new Polygon(trackHole1), new Polygon(trackHole2) }, 10, AreaType.track));
            newAreas.Add(new AreaModel("track", new Polygon(track), Main.Empty(), 10, AreaType.track));

            newAreas.Add(new AreaModel("land1", new Polygon(trackHole1), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("land2", new Polygon(trackHole2), Main.Empty(), 10, AreaType.land));

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
                        "SecondPath",
                        "MainPath"
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