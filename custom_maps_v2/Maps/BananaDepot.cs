using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace custommaps.Maps.BTDBattles2
{
    public class BananaDepot
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(52.08335, 115.47009));
            list.Add(MapHelper.AddPoint(52.343758, 12.028137));
            list.Add(MapHelper.AddPoint(51.5625, 3.9091492));
            list.Add(MapHelper.AddPoint(47.91668, -1.5035095));
            list.Add(MapHelper.AddPoint(40.104176, -5.412628));
            list.Add(MapHelper.AddPoint(-5.7291627, -5.412628));
            list.Add(MapHelper.AddPoint(-11.458334, -2.7062988));
            list.Add(MapHelper.AddPoint(-14.322916, 0.3007202));
            list.Add(MapHelper.AddPoint(-15.364588, 7.216919));
            list.Add(MapHelper.AddPoint(-16.666666, 61.944916));
            list.Add(MapHelper.AddPoint(-14.843747, 66.455444));
            list.Add(MapHelper.AddPoint(-11.458334, 69.161804));
            list.Add(MapHelper.AddPoint(-5.208331, 73.07092));
            list.Add(MapHelper.AddPoint(103.64585, 74.27371));
            list.Add(MapHelper.AddPoint(107.29167, 70.364624));
            list.Add(MapHelper.AddPoint(110.41667, 65.252625));
            list.Add(MapHelper.AddPoint(112.23958, 59.238586));
            list.Add(MapHelper.AddPoint(114.32292, -85.39972));
            list.Add(MapHelper.AddPoint(113.02083, -92.01517));
            list.Add(MapHelper.AddPoint(109.114586, -96.525696));
            list.Add(MapHelper.AddPoint(103.125, -100.735565));
            list.Add(MapHelper.AddPoint(-56.510414, -101.938354));
            list.Add(MapHelper.AddPoint(-60.9375, -99.532684));
            list.Add(MapHelper.AddPoint(-65.364586, -96.22507));
            list.Add(MapHelper.AddPoint(-66.40625, -90.51166));
            list.Add(MapHelper.AddPoint(-69.79168, 18.944336));
            list.Add(MapHelper.AddPoint(-71.614586, 24.356995));
            list.Add(MapHelper.AddPoint(-74.21875, 26.461914));
            list.Add(MapHelper.AddPoint(-77.86458, 28.867554));
            list.Add(MapHelper.AddPoint(-80.20833, 30.070343));
            list.Add(MapHelper.AddPoint(-149.89983, 30.371063));

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
            water.Add(new Vector2((float)7.2916746, (float)-80.28772));
            water.Add(new Vector2((float)7.2916746, (float)-24.657623));
            water.Add(new Vector2((float)41.666668, (float)-24.356934));
            water.Add(new Vector2((float)42.968758, (float)-79.08493));

            var track = new List<Vector2>();

            track.Add(new Vector2((float)119.01, (float)-115.17));
            track.Add(new Vector2((float)42.968758, (float)115.47009));
            track.Add(new Vector2((float)42.447926, (float)83.29483));
            track.Add(new Vector2((float)-4.166669, (float)83.59555));
            track.Add(new Vector2((float)-16.666666, (float)78.78427));
            track.Add(new Vector2((float)-21.614582, (float)71.56741));
            track.Add(new Vector2((float)-25.260427, (float)62.546295));
            track.Add(new Vector2((float)-27.343761, (float)54.728027));
            track.Add(new Vector2((float)-25.520834, (float)5.1119995));
            track.Add(new Vector2((float)-22.135412, (float)-2.4056091));
            track.Add(new Vector2((float)-15.364588, (float)-10.223877));
            track.Add(new Vector2((float)-8.593753, (float)-15.035126));
            track.Add(new Vector2((float)10.677088, (float)-16.538605));
            track.Add(new Vector2((float)27.083338, (float)-16.538605));
            track.Add(new Vector2((float)39.84375, (float)-16.237915));
            track.Add(new Vector2((float)44.53125, (float)-13.832306));
            track.Add(new Vector2((float)51.041668, (float)-9.622498));
            track.Add(new Vector2((float)61.197926, (float)-1.5035095));
            track.Add(new Vector2((float)63.020824, (float)5.4127197));
            track.Add(new Vector2((float)63.020824, (float)23.755585));
            track.Add(new Vector2((float)62.760418, (float)38.79077));
            track.Add(new Vector2((float)61.45835, (float)50.81888));
            track.Add(new Vector2((float)60.9375, (float)60.742096));
            track.Add(new Vector2((float)101.82293, (float)60.742096));
            track.Add(new Vector2((float)103.90626, (float)34.580902));
            track.Add(new Vector2((float)104.427086, (float)-82.09192));
            track.Add(new Vector2((float)101.04167, (float)-88.10602));
            track.Add(new Vector2((float)95.57292, (float)-89.6095));
            track.Add(new Vector2((float)-54.947914, (float)-89.6095));
            track.Add(new Vector2((float)-58.333336, (float)-84.1969));
            track.Add(new Vector2((float)-58.07293, (float)-76.67932));
            track.Add(new Vector2((float)-59.374996, (float)17.741547));
            track.Add(new Vector2((float)-61.458332, (float)25.559784));
            track.Add(new Vector2((float)-71.614586, (float)35.182312));
            track.Add(new Vector2((float)-80.989586, (float)39.39218));
            track.Add(new Vector2((float)-90.88542, (float)41.79779));
            track.Add(new Vector2((float)-149.89983, (float)41.79779));
            track.Add(new Vector2((float)-149.89983, (float)18.643646));
            track.Add(new Vector2((float)-83.072914, (float)20.447876));
            track.Add(new Vector2((float)-78.645836, (float)15.335907));
            track.Add(new Vector2((float)-78.385414, (float)10.825348));
            track.Add(new Vector2((float)-77.083336, (float)-89.91028));
            track.Add(new Vector2((float)-74.21875, (float)-96.22507));
            track.Add(new Vector2((float)-67.708336, (float)-103.14114));
            track.Add(new Vector2((float)-61.197914, (float)-107.65173));
            track.Add(new Vector2((float)-53.12501, (float)-112.16223));
            track.Add(new Vector2((float)107.55208, (float)-112.46301));
            track.Add(new Vector2((float)109.89583, (float)-108.85455));
            track.Add(new Vector2((float)118.229164, (float)-99.833466));
            track.Add(new Vector2((float)122.916664, (float)-92.31586));
            track.Add(new Vector2((float)125.260414, (float)-82.69336));
            track.Add(new Vector2((float)121.35417, (float)58.937866));
            track.Add(new Vector2((float)118.229164, (float)69.76318));
            track.Add(new Vector2((float)112.5, (float)76.37866));
            track.Add(new Vector2((float)107.03123, (float)79.98712));
            track.Add(new Vector2((float)60.416668, (float)82.69345));
            track.Add(new Vector2((float)59.375008, (float)115.47009));

            var land = new List<Vector2>();

            land.Add(new Vector2((float)40.88543, (float)5.4127197));
            land.Add(new Vector2((float)42.70835, (float)61.343506));
            land.Add(new Vector2((float)-2.34375, (float)60.742096));
            land.Add(new Vector2((float)-7.2916656, (float)54.427307));
            land.Add(new Vector2((float)-7.03125, (float)8.720428));


            newAreas.Add(new AreaModel("land0", new Polygon(mainLand), Main.Empty(), 10, AreaType.land));

            newAreas.Add(new AreaModel("water", new Polygon(water), Main.Empty(), 10, AreaType.water));

            newAreas.Add(new AreaModel("track", new Polygon(track), Main.Empty(), 10, AreaType.track));

            newAreas.Add(new AreaModel("land1", new Polygon(land), Main.Empty(), 10, AreaType.land));

            return (Il2CppReferenceArray<AreaModel>)newAreas.ToArray();
        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "MainPath",
                    }, ""), new SplitterModel("", new string[]
                    {
                        "MainPath"
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