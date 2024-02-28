using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace custommaps.Maps.BTDBattles2
{
    public class Oasis
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            System.Collections.Generic.List<PointInfo> list = new System.Collections.Generic.List<PointInfo>();

            list.Add(MapHelper.AddPoint(-38.802086, 115.47009));
            list.Add(MapHelper.AddPoint(-39.583336, 61.944916));
            list.Add(MapHelper.AddPoint(-39.06251, -3.6083984));
            list.Add(MapHelper.AddPoint(-38.802086, -31.874512));
            list.Add(MapHelper.AddPoint(-38.020832, -37.88855));
            list.Add(MapHelper.AddPoint(-37.5, -41.19635));
            list.Add(MapHelper.AddPoint(-36.97918, -45.10544));
            list.Add(MapHelper.AddPoint(-35.15625, -49.014587));
            list.Add(MapHelper.AddPoint(-34.114586, -53.224426));
            list.Add(MapHelper.AddPoint(-33.593746, -58.637085));
            list.Add(MapHelper.AddPoint(-33.593746, -58.637085));
            list.Add(MapHelper.AddPoint(-30.46875, -63.147675));
            list.Add(MapHelper.AddPoint(-28.125, -67.65817));
            list.Add(MapHelper.AddPoint(-25.78125, -73.07086));
            list.Add(MapHelper.AddPoint(-22.395838, -78.48352));
            list.Add(MapHelper.AddPoint(-16.40625, -84.79831));
            list.Add(MapHelper.AddPoint(-8.593753, -91.11307));
            list.Add(MapHelper.AddPoint(-1.562503, -95.02219));
            list.Add(MapHelper.AddPoint(6.2499943, -98.329895));
            list.Add(MapHelper.AddPoint(11.979175, -99.532684));
            list.Add(MapHelper.AddPoint(16.40625, -99.833466));
            list.Add(MapHelper.AddPoint(21.875006, -99.833466));
            list.Add(MapHelper.AddPoint(26.562506, -99.833466));
            list.Add(MapHelper.AddPoint(31.770838, -99.232056));
            list.Add(MapHelper.AddPoint(36.458336, -97.42786));
            list.Add(MapHelper.AddPoint(42.447926, -94.42081));
            list.Add(MapHelper.AddPoint(49.7396, -89.91028));
            list.Add(MapHelper.AddPoint(55.468727, -86.60251));
            list.Add(MapHelper.AddPoint(62.760418, -82.09192));
            list.Add(MapHelper.AddPoint(67.70833, -76.37857));
            list.Add(MapHelper.AddPoint(72.13542, -70.66522));
            list.Add(MapHelper.AddPoint(76.04168, -64.350464));
            list.Add(MapHelper.AddPoint(78.645836, -57.434296));
            list.Add(MapHelper.AddPoint(78.90623, -57.434296));
            list.Add(MapHelper.AddPoint(80.20835, -50.518127));
            list.Add(MapHelper.AddPoint(82.03125, -43.90265));
            list.Add(MapHelper.AddPoint(82.81251, -38.18924));
            list.Add(MapHelper.AddPoint(83.59373, -30.371002));
            list.Add(MapHelper.AddPoint(85.15626, -23.154114));
            list.Add(MapHelper.AddPoint(85.677086, -14.7344055));
            list.Add(MapHelper.AddPoint(85.677086, -8.720398));
            list.Add(MapHelper.AddPoint(85.15626, -3.0069885));
            list.Add(MapHelper.AddPoint(85.15626, 1.50354));
            list.Add(MapHelper.AddPoint(83.85417, 9.021118));
            list.Add(MapHelper.AddPoint(83.07293, 15.035217));
            list.Add(MapHelper.AddPoint(79.6875, 23.154175));
            list.Add(MapHelper.AddPoint(76.302086, 31.273193));
            list.Add(MapHelper.AddPoint(74.21873, 38.49008));
            list.Add(MapHelper.AddPoint(70.83335, 43.60199));
            list.Add(MapHelper.AddPoint(65.88542, 52.623108));
            list.Add(MapHelper.AddPoint(56.77085, 60.140717));
            list.Add(MapHelper.AddPoint(52.08335, 64.049835));
            list.Add(MapHelper.AddPoint(45.833336, 67.357574));
            list.Add(MapHelper.AddPoint(38.802086, 70.063934));
            list.Add(MapHelper.AddPoint(35.15625, 71.26672));
            list.Add(MapHelper.AddPoint(30.208324, 72.46951));
            list.Add(MapHelper.AddPoint(22.656227, 72.77023));
            list.Add(MapHelper.AddPoint(17.708338, 72.77023));
            list.Add(MapHelper.AddPoint(11.458325, 70.966034));
            list.Add(MapHelper.AddPoint(4.166669, 68.86105));
            list.Add(MapHelper.AddPoint(4.166669, 68.86105));
            list.Add(MapHelper.AddPoint(0, 67.658264));
            list.Add(MapHelper.AddPoint(-5.9895873, 64.049835));
            list.Add(MapHelper.AddPoint(-13.541669, 58.035736));
            list.Add(MapHelper.AddPoint(-18.489584, 53.525208));
            list.Add(MapHelper.AddPoint(-21.614582, 48.11255));
            list.Add(MapHelper.AddPoint(-27.604177, 37.28723));
            list.Add(MapHelper.AddPoint(-32.29168, 29.769653));
            list.Add(MapHelper.AddPoint(-39.583336, 18.342926));
            list.Add(MapHelper.AddPoint(-51.302086, -6.916168));
            list.Add(MapHelper.AddPoint(-71.354164, -44.50403));
            list.Add(MapHelper.AddPoint(-78.645836, -59.839874));
            list.Add(MapHelper.AddPoint(-84.375, -66.45538));
            list.Add(MapHelper.AddPoint(-86.458336, -67.95892));
            list.Add(MapHelper.AddPoint(-92.1875, -71.86807));
            list.Add(MapHelper.AddPoint(-96.35417, -73.67227));
            list.Add(MapHelper.AddPoint(-100.26042, -74.87512));
            list.Add(MapHelper.AddPoint(-103.90625, -75.47653));
            list.Add(MapHelper.AddPoint(-107.29167, -75.47653));
            list.Add(MapHelper.AddPoint(-109.895836, -75.47653));
            list.Add(MapHelper.AddPoint(-109.895836, -75.47653));
            list.Add(MapHelper.AddPoint(-112.5, -73.37155));
            list.Add(MapHelper.AddPoint(-112.5, -73.37155));
            list.Add(MapHelper.AddPoint(-115.625, -71.86807));
            list.Add(MapHelper.AddPoint(-116.40624, -71.86807));
            list.Add(MapHelper.AddPoint(-119.01042, -69.76312));
            list.Add(MapHelper.AddPoint(-120.572914, -67.65817));
            list.Add(MapHelper.AddPoint(-123.177086, -64.95187));
            list.Add(MapHelper.AddPoint(-123.177086, -64.95187));
            list.Add(MapHelper.AddPoint(-124.73958, -62.846985));
            list.Add(MapHelper.AddPoint(-126.82292, -58.637085));
            list.Add(MapHelper.AddPoint(-129.16667, -50.217438));
            list.Add(MapHelper.AddPoint(-129.16667, -39.9935));
            list.Add(MapHelper.AddPoint(-130.20834, 115.47009));

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

            water.Add(new Vector2((float)2.8645813, (float)-18.643585));
            water.Add(new Vector2((float)5.9895873, (float)7.5176086));
            water.Add(new Vector2((float)8.593726, (float)28.566864));
            water.Add(new Vector2((float)16.40625, (float)43.00061));
            water.Add(new Vector2((float)30.729176, (float)49.91678));
            water.Add(new Vector2((float)40.625008, (float)50.81888));
            water.Add(new Vector2((float)49.21875, (float)46.90973));
            water.Add(new Vector2((float)55.729168, (float)41.19641));
            water.Add(new Vector2((float)61.45835, (float)28.266144));
            water.Add(new Vector2((float)65.10417, (float)15.937317));
            water.Add(new Vector2((float)66.40626, (float)-7.818268));
            water.Add(new Vector2((float)64.583336, (float)-25.259033));
            water.Add(new Vector2((float)60.9375, (float)-42.09845));
            water.Add(new Vector2((float)56.510426, (float)-56.832886));
            water.Add(new Vector2((float)50.26043, (float)-64.350464));
            water.Add(new Vector2((float)42.70835, (float)-72.46945));
            water.Add(new Vector2((float)34.635418, (float)-76.97995));
            water.Add(new Vector2((float)25.260418, (float)-76.67932));
            water.Add(new Vector2((float)19.010426, (float)-71.56732));
            water.Add(new Vector2((float)10.937476, (float)-59.839874));
            water.Add(new Vector2((float)6.7708254, (float)-44.80475));
            water.Add(new Vector2((float)3.3854306, (float)-23.755493));

            var track = new List<Vector2>();

            track.Add(new Vector2((float)-135.67708, (float)115.47009));
            track.Add(new Vector2((float)-134.375, (float)-51.119537));
            track.Add(new Vector2((float)-131.77083, (float)-62.846985));
            track.Add(new Vector2((float)-126.04167, (float)-71.56732));
            track.Add(new Vector2((float)-119.270836, (float)-76.67932));
            track.Add(new Vector2((float)-108.59375, (float)-82.09192));
            track.Add(new Vector2((float)-108.59375, (float)-82.09192));
            track.Add(new Vector2((float)-97.135414, (float)-81.49051));
            track.Add(new Vector2((float)-85.677086, (float)-76.97995));
            track.Add(new Vector2((float)-77.083336, (float)-68.56033));
            track.Add(new Vector2((float)-71.354164, (float)-61.042786));
            track.Add(new Vector2((float)-21.354166, (float)36.98654));
            track.Add(new Vector2((float)-11.458334, (float)48.41327));
            track.Add(new Vector2((float)-5.7291627, (float)54.126617));
            track.Add(new Vector2((float)2.0833254, (float)58.336487));
            track.Add(new Vector2((float)11.71875, (float)61.343506));
            track.Add(new Vector2((float)21.6146, (float)62.546295));
            track.Add(new Vector2((float)36.979168, (float)61.042816));
            track.Add(new Vector2((float)47.656258, (float)56.532257));
            track.Add(new Vector2((float)58.854176, (float)49.91678));
            track.Add(new Vector2((float)67.44792, (float)38.79077));
            track.Add(new Vector2((float)71.09376, (float)22.853455));
            track.Add(new Vector2((float)73.69793, (float)9.622559));
            track.Add(new Vector2((float)74.73958, (float)-17.741486));
            track.Add(new Vector2((float)72.13542, (float)-33.67871));
            track.Add(new Vector2((float)67.70833, (float)-57.434296));
            track.Add(new Vector2((float)60.9375, (float)-69.16174));
            track.Add(new Vector2((float)49.21875, (float)-80.28772));
            track.Add(new Vector2((float)38.54168, (float)-87.20392));
            track.Add(new Vector2((float)23.177074, (float)-91.4137));
            track.Add(new Vector2((float)8.854169, (float)-92.91727));
            track.Add(new Vector2(0, (float)-86.9032));
            track.Add(new Vector2((float)-8.593753, (float)-81.79132));
            track.Add(new Vector2((float)-16.666666, (float)-75.77716));
            track.Add(new Vector2((float)-20.572918, (float)-67.95892));
            track.Add(new Vector2((float)-26.041666, (float)-55.630096));
            track.Add(new Vector2((float)-29.427088, (float)-40.29422));
            track.Add(new Vector2((float)-32.03126, (float)-24.958344));
            track.Add(new Vector2((float)-33.593746, (float)-1.5035095));
            track.Add(new Vector2((float)-32.29168, (float)55.028717));
            track.Add(new Vector2((float)-32.552086, (float)115.47009));
            track.Add(new Vector2((float)-45.833336, (float)115.47009));
            track.Add(new Vector2((float)-43.489586, (float)22.252075));
            track.Add(new Vector2((float)-45.572914, (float)-27.664673));
            track.Add(new Vector2((float)-40.364582, (float)-60.441345));
            track.Add(new Vector2((float)-28.385416, (float)-81.49051));
            track.Add(new Vector2((float)-15.625003, (float)-95.6236));
            track.Add(new Vector2((float)-2.6041656, (float)-104.945435));
            track.Add(new Vector2((float)14.583349, (float)-110.05734));
            track.Add(new Vector2((float)28.64585, (float)-110.05734));
            track.Add(new Vector2((float)43.749977, (float)-104.945435));
            track.Add(new Vector2((float)56.510426, (float)-97.42786));
            track.Add(new Vector2((float)65.10417, (float)-90.81232));
            track.Add(new Vector2((float)73.1771, (float)-76.97995));
            track.Add(new Vector2((float)81.51042, (float)-66.15466));
            track.Add(new Vector2((float)86.19792, (float)-50.818817));
            track.Add(new Vector2((float)91.9271, (float)-30.070282));
            track.Add(new Vector2((float)93.75, (float)-11.125977));
            track.Add(new Vector2((float)91.14583, (float)16.839447));
            track.Add(new Vector2((float)82.03125, (float)43.3013));
            track.Add(new Vector2((float)65.625, (float)57.434357));
            track.Add(new Vector2((float)54.166676, (float)70.063934));
            track.Add(new Vector2((float)30.46875, (float)85.70047));
            track.Add(new Vector2((float)11.979175, (float)85.70047));
            track.Add(new Vector2((float)-11.979166, (float)71.56741));
            track.Add(new Vector2((float)-25.520834, (float)51.420288));
            track.Add(new Vector2((float)-30.989582, (float)41.79779));
            track.Add(new Vector2((float)-54.947914, (float)-0.30065918));
            track.Add(new Vector2((float)-70.052086, (float)-28.566803));
            track.Add(new Vector2((float)-82.291664, (float)-51.420227));
            track.Add(new Vector2((float)-90.88542, (float)-62.546204));
            track.Add(new Vector2((float)-96.61458, (float)-66.75607));
            track.Add(new Vector2((float)-106.25, (float)-66.45538));
            track.Add(new Vector2((float)-114.06249, (float)-64.350464));
            track.Add(new Vector2((float)-116.40624, (float)-58.637085));
            track.Add(new Vector2((float)-119.79167, (float)-52.923798));
            track.Add(new Vector2((float)-121.875, (float)-43.90265));
            track.Add(new Vector2((float)-122.91667, (float)115.47009));

            var bones = new List<Vector2>();

            bones.Add(new Vector2((float)-62.76043, (float)-0.30065918));
            bones.Add(new Vector2((float)-54.427082, (float)7.5176086));
            bones.Add(new Vector2((float)-46.614586, (float)13.531677));
            bones.Add(new Vector2((float)-38.020832, (float)22.552765));
            bones.Add(new Vector2((float)-38.020832, (float)26.461914));
            bones.Add(new Vector2((float)-41.145836, (float)25.259094));
            bones.Add(new Vector2((float)-43.75001, (float)22.853455));
            bones.Add(new Vector2((float)-44.53125, (float)25.559784));
            bones.Add(new Vector2((float)-46.09376, (float)29.468964));
            bones.Add(new Vector2((float)-46.614586, (float)30.671753));
            bones.Add(new Vector2((float)-49.21875, (float)32.475983));
            bones.Add(new Vector2((float)-51.822914, (float)32.776672));
            bones.Add(new Vector2((float)-51.5625, (float)38.79077));
            bones.Add(new Vector2((float)-49.999996, (float)40.89566));
            bones.Add(new Vector2((float)-50.78126, (float)42.69989));
            bones.Add(new Vector2((float)-53.38543, (float)42.09851));
            bones.Add(new Vector2((float)-57.031246, (float)37.28723));
            bones.Add(new Vector2((float)-57.291664, (float)32.475983));
            bones.Add(new Vector2((float)-60.15626, (float)30.972473));
            bones.Add(new Vector2((float)-63.541664, (float)28.566864));
            bones.Add(new Vector2((float)-65.10418, (float)25.559784));
            bones.Add(new Vector2((float)-64.0625, (float)21.951355));
            bones.Add(new Vector2((float)-64.583336, (float)18.342926));
            bones.Add(new Vector2((float)-68.75, (float)13.832367));
            bones.Add(new Vector2((float)-70.83333, (float)9.321838));
            bones.Add(new Vector2((float)-70.83333, (float)5.7134094));
            bones.Add(new Vector2((float)-70.83333, (float)1.2028198));
            bones.Add(new Vector2((float)-70.052086, (float)1.2028198));
            bones.Add(new Vector2((float)-67.187515, (float)0.6014404));
            bones.Add(new Vector2((float)-64.322914, (float)1.50354));
            bones.Add(new Vector2((float)-61.197914, (float)4.5105896));
            bones.Add(new Vector2((float)-58.59375, (float)6.9162292));
            bones.Add(new Vector2((float)-56.510414, (float)8.419708));

            newAreas.Add(new AreaModel("land0", new Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("water", new Polygon(water), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("track", new Polygon(track), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("bones", new Polygon(bones), Main.Empty(), 100, AreaType.unplaceable));

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