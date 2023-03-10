using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace custommaps.Maps.BTDBattles2
{
    public class BuildingSite
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(150.10017, -22.552704));
            list.Add(MapHelper.AddPoint(114.06249, -22.552704));
            list.Add(MapHelper.AddPoint(104.16668, -24.056244));
            list.Add(MapHelper.AddPoint(98.4375, -27.965363));
            list.Add(MapHelper.AddPoint(94.27085, -30.972382));
            list.Add(MapHelper.AddPoint(90.62498, -35.18225));
            list.Add(MapHelper.AddPoint(88.54167, -40.59491));
            list.Add(MapHelper.AddPoint(87.50001, -45.70688));
            list.Add(MapHelper.AddPoint(86.19792, -54.126587));
            list.Add(MapHelper.AddPoint(85.93748, -74.57437));
            list.Add(MapHelper.AddPoint(84.89585, -85.099));
            list.Add(MapHelper.AddPoint(80.72918, -93.8194));
            list.Add(MapHelper.AddPoint(78.38543, -97.127106));
            list.Add(MapHelper.AddPoint(74.47917, -100.434845));
            list.Add(MapHelper.AddPoint(67.70833, -102.840454));
            list.Add(MapHelper.AddPoint(59.63543, -104.04324));
            list.Add(MapHelper.AddPoint(5.4687557, -103.441895));
            list.Add(MapHelper.AddPoint(-3.3854127, -101.938354));
            list.Add(MapHelper.AddPoint(-7.812497, -98.630646));
            list.Add(MapHelper.AddPoint(-12.760412, -95.02219));
            list.Add(MapHelper.AddPoint(-15.364588, -90.21091));
            list.Add(MapHelper.AddPoint(-19.791662, -82.99411));
            list.Add(MapHelper.AddPoint(-20.833334, -76.07791));
            list.Add(MapHelper.AddPoint(-21.874996, -64.049774));
            list.Add(MapHelper.AddPoint(-21.614582, -45.406128));

            list.Add(MapHelper.AddInvulnerablePoint(-21.354166, -43.60193));
            list.Add(MapHelper.AddInvulnerablePoint(-21.874996, -32.175232));
            list.Add(MapHelper.AddInvulnerablePoint(-21.614582, -27.965363));
            list.Add(MapHelper.AddInvulnerablePoint(-20.572918, -21.650604));
            list.Add(MapHelper.AddInvulnerablePoint(-22.916677, -17.440735));
            list.Add(MapHelper.AddInvulnerablePoint(-24.479162, -14.133026));
            list.Add(MapHelper.AddInvulnerablePoint(-28.125, -9.923187));
            list.Add(MapHelper.AddInvulnerablePoint(-31.770838, -4.510498));
            list.Add(MapHelper.AddInvulnerablePoint(-35.677082, -3.3077087));
            list.Add(MapHelper.AddInvulnerablePoint(-39.32293, -3.3077087));
            list.Add(MapHelper.AddInvulnerablePoint(-39.32293, -3.3077087));
            list.Add(MapHelper.AddInvulnerablePoint(-43.75001, -3.0069885));
            list.Add(MapHelper.AddInvulnerablePoint(-45.833336, -2.7062988));

            list.Add(MapHelper.AddPoint(-50.260414, -1.2027588));
            list.Add(MapHelper.AddPoint(-57.552086, -0.6013794));
            list.Add(MapHelper.AddPoint(-62.50001, -0.6013794));
            list.Add(MapHelper.AddPoint(-68.48958, -2.1048584));
            list.Add(MapHelper.AddPoint(-72.65625, -3.3077087));
            list.Add(MapHelper.AddPoint(-77.604164, -5.7132874));
            list.Add(MapHelper.AddPoint(-83.333336, -9.622498));
            list.Add(MapHelper.AddPoint(-84.114586, -12.328827));
            list.Add(MapHelper.AddPoint(-84.89583, -15.937256));
            list.Add(MapHelper.AddPoint(-85.93749, -19.545715));
            list.Add(MapHelper.AddPoint(-86.458336, -24.056244));
            list.Add(MapHelper.AddPoint(-86.979164, -27.965363));
            list.Add(MapHelper.AddPoint(-88.020836, -36.08435));
            list.Add(MapHelper.AddPoint(-86.458336, -58.637085));
            list.Add(MapHelper.AddPoint(-86.458336, -70.06384));
            list.Add(MapHelper.AddPoint(-88.020836, -76.67932));
            list.Add(MapHelper.AddPoint(-89.84375, -80.88913));
            list.Add(MapHelper.AddPoint(-92.96874, -84.79831));
            list.Add(MapHelper.AddPoint(-97.91667, -87.50461));
            list.Add(MapHelper.AddPoint(-99.99999, -89.91028));
            list.Add(MapHelper.AddPoint(-107.03124, -92.31586));
            list.Add(MapHelper.AddPoint(-110.9375, -92.31586));
            list.Add(MapHelper.AddPoint(-115.625, -91.71448));
            list.Add(MapHelper.AddPoint(-119.270836, -90.81232));
            list.Add(MapHelper.AddPoint(-123.43749, -89.30887));
            list.Add(MapHelper.AddPoint(-125.520836, -87.8053));
            list.Add(MapHelper.AddPoint(-128.64583, -86.30182));
            list.Add(MapHelper.AddPoint(-130.98958, -83.59552));
            list.Add(MapHelper.AddPoint(-132.03125, -79.98703));
            list.Add(MapHelper.AddPoint(-132.29167, -73.67227));
            list.Add(MapHelper.AddPoint(-133.33333, 36.98654));
            list.Add(MapHelper.AddPoint(-133.33333, 43.00061));
            list.Add(MapHelper.AddPoint(-130.98958, 47.51117));
            list.Add(MapHelper.AddPoint(-129.6875, 51.1196));
            list.Add(MapHelper.AddPoint(-126.5625, 55.329407));
            list.Add(MapHelper.AddPoint(-125, 58.637177));
            list.Add(MapHelper.AddPoint(-123.43749, 61.042816));
            list.Add(MapHelper.AddPoint(-119.79167, 64.651245));
            list.Add(MapHelper.AddPoint(-116.927086, 66.756134));
            list.Add(MapHelper.AddPoint(-114.32292, 67.357574));
            list.Add(MapHelper.AddPoint(-109.63542, 68.86105));
            list.Add(MapHelper.AddPoint(-106.510414, 69.76318));
            list.Add(MapHelper.AddPoint(-82.81251, 69.76318));
            list.Add(MapHelper.AddPoint(-76.56249, 70.966034));
            list.Add(MapHelper.AddPoint(-69.531265, 73.97302));
            list.Add(MapHelper.AddPoint(-65.10418, 76.67935));
            list.Add(MapHelper.AddPoint(-60.9375, 80.28781));
            list.Add(MapHelper.AddPoint(-58.333336, 84.79837));
            list.Add(MapHelper.AddPoint(-55.72918, 87.80536));
            list.Add(MapHelper.AddPoint(-53.90625, 92.31595));
            list.Add(MapHelper.AddPoint(-53.645836, 97.42789));
            list.Add(MapHelper.AddPoint(-52.864586, 102.239136));
            list.Add(MapHelper.AddPoint(-51.822914, 115.47009));


            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(150.10017, -22.552704));
            list.Add(MapHelper.AddPoint(114.06249, -22.552704));
            list.Add(MapHelper.AddPoint(104.16668, -24.056244));
            list.Add(MapHelper.AddPoint(98.4375, -27.965363));
            list.Add(MapHelper.AddPoint(94.27085, -30.972382));
            list.Add(MapHelper.AddPoint(90.62498, -35.18225));
            list.Add(MapHelper.AddPoint(88.54167, -40.59491));
            list.Add(MapHelper.AddPoint(87.50001, -45.70688));
            list.Add(MapHelper.AddPoint(86.19792, -54.126587));
            list.Add(MapHelper.AddPoint(85.93748, -74.57437));
            list.Add(MapHelper.AddPoint(84.89585, -85.099));
            list.Add(MapHelper.AddPoint(80.72918, -93.8194));
            list.Add(MapHelper.AddPoint(78.38543, -97.127106));
            list.Add(MapHelper.AddPoint(74.47917, -100.434845));
            list.Add(MapHelper.AddPoint(67.70833, -102.840454));
            list.Add(MapHelper.AddPoint(59.63543, -104.04324));
            list.Add(MapHelper.AddPoint(5.4687557, -103.441895));
            list.Add(MapHelper.AddPoint(-3.3854127, -101.938354));
            list.Add(MapHelper.AddPoint(-7.812497, -98.630646));
            list.Add(MapHelper.AddPoint(-12.760412, -95.02219));
            list.Add(MapHelper.AddPoint(-15.364588, -90.21091));
            list.Add(MapHelper.AddPoint(-19.791662, -82.99411));
            list.Add(MapHelper.AddPoint(-20.833334, -76.07791));
            list.Add(MapHelper.AddPoint(-21.874996, -64.049774));
            list.Add(MapHelper.AddPoint(-21.614582, -45.406128));

            list.Add(MapHelper.AddInvulnerablePoint(-21.874996, -41.49704));
            list.Add(MapHelper.AddInvulnerablePoint(-21.874996, -36.98645));
            list.Add(MapHelper.AddInvulnerablePoint(-22.135412, -34.28015));
            list.Add(MapHelper.AddInvulnerablePoint(-22.135412, -31.273132));
            list.Add(MapHelper.AddInvulnerablePoint(-22.135412, -29.168182));
            list.Add(MapHelper.AddInvulnerablePoint(-22.135412, -25.860443));
            list.Add(MapHelper.AddInvulnerablePoint(-22.656261, -24.356934));
            list.Add(MapHelper.AddInvulnerablePoint(-21.874996, -19.846405));
            list.Add(MapHelper.AddInvulnerablePoint(-21.874996, -16.237915));
            list.Add(MapHelper.AddInvulnerablePoint(-21.874996, -13.531616));
            list.Add(MapHelper.AddInvulnerablePoint(-22.135412, -8.720398));
            list.Add(MapHelper.AddInvulnerablePoint(-21.614582, -4.8111877));
            list.Add(MapHelper.AddInvulnerablePoint(-21.874996, -3.3077087));
            list.Add(MapHelper.AddInvulnerablePoint(-17.968754, -2.4056091));
            list.Add(MapHelper.AddInvulnerablePoint(-15.625003, -2.4056091));
            list.Add(MapHelper.AddInvulnerablePoint(-13.020838, -2.4056091));
            list.Add(MapHelper.AddInvulnerablePoint(-10.416662, -2.4056091));
            list.Add(MapHelper.AddInvulnerablePoint(-7.03125, -2.4056091));

            list.Add(MapHelper.AddPoint(-5.7291627, -1.2027588));
            list.Add(MapHelper.AddPoint(-0.781247, -0.6013794));
            list.Add(MapHelper.AddPoint(17.447931, 3.0517578E-05));
            list.Add(MapHelper.AddPoint(32.8125, -0.6013794));
            list.Add(MapHelper.AddPoint(39.583324, 3.0517578E-05));
            list.Add(MapHelper.AddPoint(43.489586, 1.50354));
            list.Add(MapHelper.AddPoint(45.833336, 2.7063599));
            list.Add(MapHelper.AddPoint(47.91668, 4.2099));
            list.Add(MapHelper.AddPoint(50.520836, 6.3148193));
            list.Add(MapHelper.AddPoint(52.60418, 8.720428));
            list.Add(MapHelper.AddPoint(54.166676, 10.524658));
            list.Add(MapHelper.AddPoint(56.25, 14.734467));
            list.Add(MapHelper.AddPoint(56.25, 19.846466));
            list.Add(MapHelper.AddPoint(57.031258, 68.56036));
            list.Add(MapHelper.AddPoint(57.29168, 76.07794));
            list.Add(MapHelper.AddPoint(58.333324, 81.79135));
            list.Add(MapHelper.AddPoint(59.895836, 85.39978));
            list.Add(MapHelper.AddPoint(61.197926, 89.60959));
            list.Add(MapHelper.AddPoint(63.020824, 92.61667));
            list.Add(MapHelper.AddPoint(65.625, 95.62366));
            list.Add(MapHelper.AddPoint(68.75001, 99.53281));
            list.Add(MapHelper.AddPoint(71.09376, 101.036316));
            list.Add(MapHelper.AddPoint(73.1771, 103.141235));
            list.Add(MapHelper.AddPoint(76.302086, 104.644775));
            list.Add(MapHelper.AddPoint(79.94792, 106.148315));
            list.Add(MapHelper.AddPoint(82.81251, 106.449005));
            list.Add(MapHelper.AddPoint(89.0625, 107.050415));
            list.Add(MapHelper.AddPoint(93.48958, 107.050415));
            list.Add(MapHelper.AddPoint(97.13543, 106.449005));
            list.Add(MapHelper.AddPoint(101.3021, 104.945465));
            list.Add(MapHelper.AddPoint(104.16668, 102.840546));
            list.Add(MapHelper.AddPoint(107.55208, 99.23212));
            list.Add(MapHelper.AddPoint(111.458336, 96.52579));
            list.Add(MapHelper.AddPoint(114.06249, 92.31595));
            list.Add(MapHelper.AddPoint(115.62501, 88.70749));
            list.Add(MapHelper.AddPoint(117.1875, 83.29483));
            list.Add(MapHelper.AddPoint(117.70833, 79.68637));
            list.Add(MapHelper.AddPoint(119.01042, 74.27371));
            list.Add(MapHelper.AddPoint(119.79167, 65.553345));
            list.Add(MapHelper.AddPoint(120.31251, 58.035736));
            list.Add(MapHelper.AddPoint(121.61458, 53.825928));
            list.Add(MapHelper.AddPoint(122.13542, 50.51819));
            list.Add(MapHelper.AddPoint(124.47917, 46.00763));
            list.Add(MapHelper.AddPoint(126.5625, 43.90271));
            list.Add(MapHelper.AddPoint(129.9479, 42.3992));
            list.Add(MapHelper.AddPoint(133.33333, 41.19641));
            list.Add(MapHelper.AddPoint(139.3229, 39.99356));
            list.Add(MapHelper.AddPoint(142.44792, 39.39218));
            list.Add(MapHelper.AddPoint(146.6146, 39.39218));
            list.Add(MapHelper.AddPoint(150.10017, 39.09146));

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

            water.Add(new Vector2((float)-30.989582, (float)-50.217438));
            water.Add(new Vector2((float)-27.864584, (float)-63.749084));
            water.Add(new Vector2((float)-30.208334, (float)-83.29474));
            water.Add(new Vector2((float)-32.8125, (float)-95.6236));
            water.Add(new Vector2((float)-36.458336, (float)-98.329895));
            water.Add(new Vector2((float)-48.177086, (float)-104.945435));
            water.Add(new Vector2((float)-53.38543, (float)-104.644684));
            water.Add(new Vector2((float)-61.197914, (float)-102.840454));
            water.Add(new Vector2((float)-66.14583, (float)-101.336945));
            water.Add(new Vector2((float)-72.13543, (float)-97.728485));
            water.Add(new Vector2((float)-74.47918, (float)-91.4137));
            water.Add(new Vector2((float)-77.083336, (float)-82.39267));
            water.Add(new Vector2((float)-78.12501, (float)-70.66522));
            water.Add(new Vector2((float)-77.34375, (float)-61.644165));
            water.Add(new Vector2((float)-77.083336, (float)-51.720917));
            water.Add(new Vector2((float)-74.21875, (float)-41.19635));
            water.Add(new Vector2((float)-69.270836, (float)-37.28714));
            water.Add(new Vector2((float)-58.333336, (float)-35.18225));
            water.Add(new Vector2((float)-45.052082, (float)-36.38504));
            water.Add(new Vector2((float)-42.1875, (float)-37.88855));

            var track = new List<Vector2>();

            track.Add(new Vector2((float)119.01, (float)-115.17));
            track.Add(new Vector2((float)150.10017, (float)-30.371002));
            track.Add(new Vector2((float)118.229164, (float)-29.769592));
            track.Add(new Vector2((float)107.55208, (float)-30.972382));
            track.Add(new Vector2((float)101.04167, (float)-36.38504));
            track.Add(new Vector2((float)96.87501, (float)-42.39914));
            track.Add(new Vector2((float)94.53126, (float)-47.8118));
            track.Add(new Vector2((float)92.96873, (float)-54.427216));
            track.Add(new Vector2((float)92.18751, (float)-82.99411));
            track.Add(new Vector2((float)90.364586, (float)-91.11307));
            track.Add(new Vector2((float)86.19792, (float)-98.630646));
            track.Add(new Vector2((float)81.51042, (float)-105.246155));
            track.Add(new Vector2((float)75.78126, (float)-109.45593));
            track.Add(new Vector2((float)65.625, (float)-112.16223));
            track.Add(new Vector2((float)53.385418, (float)-112.16223));
            track.Add(new Vector2((float)-0.26041567, (float)-110.95944));
            track.Add(new Vector2((float)-12.499997, (float)-105.546844));
            track.Add(new Vector2((float)-20.052088, (float)-99.232056));
            track.Add(new Vector2((float)-24.479162, (float)-90.81232));
            track.Add(new Vector2((float)-31.510412, (float)-80.88913));
            track.Add(new Vector2((float)-27.604177, (float)-67.05676));
            track.Add(new Vector2((float)-27.343761, (float)-46.909637));
            track.Add(new Vector2((float)-36.458336, (float)-45.406128));
            track.Add(new Vector2((float)-37.5, (float)-31.874512));
            track.Add(new Vector2((float)-37.239586, (float)-18.342865));
            track.Add(new Vector2((float)-47.395832, (float)-22.252014));
            track.Add(new Vector2((float)-54.947914, (float)-20.447815));
            track.Add(new Vector2((float)-59.635414, (float)-18.944275));
            track.Add(new Vector2((float)-61.979164, (float)-9.622498));
            track.Add(new Vector2((float)-68.75, (float)-8.720398));
            track.Add(new Vector2((float)-73.697914, (float)-10.524597));
            track.Add(new Vector2((float)-77.86458, (float)-16.839355));
            track.Add(new Vector2((float)-81.24999, (float)-26.762573));
            track.Add(new Vector2((float)-80.989586, (float)-52.322327));
            track.Add(new Vector2((float)-79.427086, (float)-65.85397));
            track.Add(new Vector2((float)-82.55208, (float)-83.89615));
            track.Add(new Vector2((float)-88.28124, (float)-91.11307));
            track.Add(new Vector2((float)-96.09375, (float)-96.525696));
            track.Add(new Vector2((float)-104.68749, (float)-99.232056));
            track.Add(new Vector2((float)-113.28125, (float)-98.02927));
            track.Add(new Vector2((float)-122.91667, (float)-95.6236));
            track.Add(new Vector2((float)-129.42708, (float)-91.4137));
            track.Add(new Vector2((float)-133.07292, (float)-85.70041));
            track.Add(new Vector2((float)-140.10417, (float)-72.77017));
            track.Add(new Vector2((float)-139.58334, (float)-7.216858));
            track.Add(new Vector2((float)-140.88542, (float)31.874573));
            track.Add(new Vector2((float)-138.02083, (float)46.60904));
            track.Add(new Vector2((float)-133.33333, (float)56.231537));
            track.Add(new Vector2((float)-128.64583, (float)63.749146));
            track.Add(new Vector2((float)-123.69792, (float)70.063934));
            track.Add(new Vector2((float)-114.06249, (float)73.97302));
            track.Add(new Vector2((float)-104.166664, (float)76.98004));
            track.Add(new Vector2((float)-90.104164, (float)78.78427));
            track.Add(new Vector2((float)-78.645836, (float)78.18289));
            track.Add(new Vector2((float)-72.65625, (float)79.38568));
            track.Add(new Vector2((float)-67.187515, (float)84.49765));
            track.Add(new Vector2((float)-60.41668, (float)93.81946));
            track.Add(new Vector2((float)-58.59375, (float)103.141235));
            track.Add(new Vector2((float)-58.59375, (float)115.47009));
            track.Add(new Vector2((float)-44.01043, (float)115.47009));
            track.Add(new Vector2((float)-45.572914, (float)101.337006));
            track.Add(new Vector2((float)-46.35418, (float)90.51169));
            track.Add(new Vector2((float)-51.04168, (float)81.18991));
            track.Add(new Vector2((float)-57.291664, (float)74.57446));
            track.Add(new Vector2((float)-63.28125, (float)68.86105));
            track.Add(new Vector2((float)-69.531265, (float)65.553345));
            track.Add(new Vector2((float)-78.645836, (float)61.944916));
            track.Add(new Vector2((float)-90.364586, (float)60.140717));
            track.Add(new Vector2((float)-101.822914, (float)60.140717));
            track.Add(new Vector2((float)-109.37499, (float)60.140717));
            track.Add(new Vector2((float)-116.66667, (float)55.028717));
            track.Add(new Vector2((float)-121.614586, (float)50.2175));
            track.Add(new Vector2(-125, (float)44.50409));
            track.Add(new Vector2((float)-127.864586, (float)37.88864));
            track.Add(new Vector2((float)-127.08333, (float)-71.26663));
            track.Add(new Vector2((float)-124.21875, (float)-78.78421));
            track.Add(new Vector2((float)-117.1875, (float)-83.59552));
            track.Add(new Vector2((float)-105.208336, (float)-83.89615));
            track.Add(new Vector2((float)-98.69792, (float)-83.29474));
            track.Add(new Vector2((float)-92.96874, (float)-75.17575));
            track.Add(new Vector2((float)-91.92708, (float)-67.05676));
            track.Add(new Vector2((float)-91.66667, (float)-13.531616));
            track.Add(new Vector2((float)-89.0625, (float)-7.818268));
            track.Add(new Vector2((float)-82.291664, (float)-0.30065918));
            track.Add(new Vector2((float)-76.041664, (float)3.6084595));
            track.Add(new Vector2((float)-61.718746, (float)5.4127197));
            track.Add(new Vector2((float)-61.197914, (float)13.531677));
            track.Add(new Vector2((float)-59.374996, (float)17.440826));
            track.Add(new Vector2((float)-50.260414, (float)19.245026));
            track.Add(new Vector2((float)-42.447914, (float)19.846466));
            track.Add(new Vector2((float)-37.239586, (float)16.538727));
            track.Add(new Vector2((float)-24.739588, (float)13.832367));
            track.Add(new Vector2((float)-14.322916, (float)9.321838));
            track.Add(new Vector2((float)-8.072912, (float)5.1119995));
            track.Add(new Vector2((float)41.927074, (float)6.3148193));
            track.Add(new Vector2((float)46.614574, (float)11.426758));
            track.Add(new Vector2((float)49.21875, (float)18.342926));
            track.Add(new Vector2((float)51.302074, (float)82.99414));
            track.Add(new Vector2((float)55.729168, (float)95.32297));
            track.Add(new Vector2((float)64.06251, (float)107.952515));
            track.Add(new Vector2((float)73.43751, (float)111.560974));
            track.Add(new Vector2((float)87.50001, (float)113.66589));
            track.Add(new Vector2((float)100.52083, (float)113.365204));
            track.Add(new Vector2((float)111.19793, (float)109.45599));
            track.Add(new Vector2((float)117.44792, (float)101.938446));
            track.Add(new Vector2((float)123.69792, (float)87.50467));
            track.Add(new Vector2((float)125.260414, (float)75.47656));
            track.Add(new Vector2((float)125.78124, (float)62.847046));
            track.Add(new Vector2((float)128.90625, (float)52.021698));
            track.Add(new Vector2((float)133.85417, (float)47.81186));
            track.Add(new Vector2((float)150.10017, (float)46.00763));
            track.Add(new Vector2((float)150.10017, (float)30.070343));
            track.Add(new Vector2((float)131.51042, (float)29.468964));
            track.Add(new Vector2((float)120.31251, (float)37.58795));
            track.Add(new Vector2((float)114.32292, (float)47.51117));
            track.Add(new Vector2((float)113.541664, (float)63.749146));
            track.Add(new Vector2((float)109.37498, (float)88.10608));
            track.Add(new Vector2((float)103.64585, (float)95.32297));
            track.Add(new Vector2((float)93.48958, (float)98.32999));
            track.Add(new Vector2((float)81.24998, (float)97.72858));
            track.Add(new Vector2((float)73.1771, (float)93.21805));
            track.Add(new Vector2((float)65.625, (float)85.70047));
            track.Add(new Vector2((float)64.583336, (float)69.161804));
            track.Add(new Vector2((float)64.84373, (float)41.19641));
            track.Add(new Vector2((float)63.28125, (float)12.930267));
            track.Add(new Vector2((float)60.677074, (float)5.4127197));
            track.Add(new Vector2((float)55.989574, (float)0.3007202));
            track.Add(new Vector2((float)41.927074, (float)-6.314728));
            track.Add(new Vector2((float)30.729176, (float)-7.216858));
            track.Add(new Vector2((float)21.875006, (float)-7.818268));
            track.Add(new Vector2((float)8.593726, (float)-7.818268));
            track.Add(new Vector2((float)-0.52083135, (float)-9.622498));
            track.Add(new Vector2((float)-1.562503, (float)-14.7344055));
            track.Add(new Vector2((float)-0.26041567, (float)-28.566803));
            track.Add(new Vector2((float)1.562494, (float)-31.874512));
            track.Add(new Vector2((float)1.3020873, (float)-44.50403));
            track.Add(new Vector2((float)-14.843747, (float)-45.406128));
            track.Add(new Vector2((float)-14.843747, (float)-61.042786));
            track.Add(new Vector2((float)-14.843747, (float)-75.77716));
            track.Add(new Vector2((float)-7.552081, (float)-87.20392));
            track.Add(new Vector2((float)0.2604246, (float)-92.91727));
            track.Add(new Vector2((float)20.312477, (float)-92.91727));
            track.Add(new Vector2((float)38.281258, (float)-96.22507));
            track.Add(new Vector2((float)57.812477, (float)-94.42081));
            track.Add(new Vector2((float)67.44792, (float)-94.42081));
            track.Add(new Vector2((float)72.39583, (float)-92.61661));
            track.Add(new Vector2((float)76.302086, (float)-86.9032));
            track.Add(new Vector2((float)78.38543, (float)-76.67932));
            track.Add(new Vector2((float)78.645836, (float)-67.357544));
            track.Add(new Vector2((float)79.16667, (float)-54.427216));
            track.Add(new Vector2((float)81.24998, (float)-43.60193));
            track.Add(new Vector2((float)84.63542, (float)-33.67871));
            track.Add(new Vector2((float)89.84376, (float)-27.664673));
            track.Add(new Vector2((float)96.09375, (float)-21.951294));
            track.Add(new Vector2((float)106.51043, (float)-18.042175));
            track.Add(new Vector2((float)119.79167, (float)-12.629517));
            track.Add(new Vector2((float)131.25, (float)-12.028076));
            track.Add(new Vector2((float)142.44792, (float)-11.426697));
            track.Add(new Vector2((float)150.10017, (float)-11.727386));

          


            newAreas.Add(new AreaModel("land0", new Polygon(mainLand), Main.Empty(), 10, AreaType.land));

            newAreas.Add(new AreaModel("water", new Polygon(water), Main.Empty(), 10, AreaType.water));

            newAreas.Add(new AreaModel("track", new Polygon(track), Main.Empty(), 10, AreaType.track));

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
                        "SecondPath",
                        "MainPath"
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