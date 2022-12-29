using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class CastleRuinsDouble
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(-149.9f, 79.1f));
            list.Add( MapHelper.AddPoint(-75.8, (float)80.0f));
            list.Add( MapHelper.AddPoint(-72.9, (float)88.4));
            list.Add( MapHelper.AddPoint(-69.3, (float)93.8));
            list.Add( MapHelper.AddPoint(-64.3, (float)98.9));
            list.Add( MapHelper.AddPoint(-58.3, (float)102.2));
            list.Add( MapHelper.AddPoint(-51.6, (float)104.6));
            list.Add( MapHelper.AddPoint(-42.7, (float)105.5));
            list.Add( MapHelper.AddPoint(-34.9, (float)104.6));
            list.Add( MapHelper.AddPoint(-27.1, (float)102.2));
            list.Add( MapHelper.AddPoint(-19.0, (float)97.4));
            list.Add( MapHelper.AddPoint(-12.5, (float)89.0));
            list.Add( MapHelper.AddPoint(-7.8, (float)79.1));
            list.Add( MapHelper.AddPoint(-6.5, (float)66.8));
            list.Add( MapHelper.AddPoint(-9.6, (float)56.5));
            list.Add( MapHelper.AddPoint(-14.6, (float)46.0));
            list.Add( MapHelper.AddPoint(-23.2, (float)38.5));
            list.Add( MapHelper.AddPoint(-32.3, (float)35.8));
            list.Add( MapHelper.AddPoint(-40.4, (float)37.3));
            list.Add( MapHelper.AddPoint(-50.5, (float)40.0));
            list.Add( MapHelper.AddPoint(-60.7, (float)45.1));
            list.Add( MapHelper.AddPoint(-68.2, (float)48.1));
            list.Add( MapHelper.AddPoint(-72.7, (float)45.1));
            list.Add( MapHelper.AddPoint(-75.3, (float)24.7));
            list.Add( MapHelper.AddPoint(-74.7, (float)5.4));
            list.Add( MapHelper.AddPoint(-75.8, (float)-3.0));
            list.Add( MapHelper.AddPoint(-81.2, (float)-6.6));
            list.Add( MapHelper.AddPoint(-90.4, (float)-7.8));
            list.Add( MapHelper.AddPoint(-99.2, (float)-6.0));
            list.Add( MapHelper.AddPoint(-109.1, (float)-6.0));
            list.Add( MapHelper.AddPoint(-118.2, (float)-9.3));
            list.Add( MapHelper.AddPoint(-126.6, (float)-13.8));
            list.Add( MapHelper.AddPoint(-134.6, (float)-19.8));
            list.Add( MapHelper.AddPoint(-140.1, (float)-27.4));
            list.Add( MapHelper.AddPoint(-142.2, (float)-37.6));
            list.Add( MapHelper.AddPoint(-141.4, (float)-49.6));
            list.Add( MapHelper.AddPoint(-139.6, (float)-58.3));
            list.Add( MapHelper.AddPoint(-134.6, (float)-65.6));
            list.Add( MapHelper.AddPoint(-127.3, (float)-71.9));
            list.Add( MapHelper.AddPoint(-118.5, (float)-77.9));
            list.Add( MapHelper.AddPoint(-106.8, (float)-80.9));
            list.Add( MapHelper.AddPoint(-97.7, (float)-77.6));
            list.Add( MapHelper.AddPoint(-90.4, (float)-72.5));
            list.Add( MapHelper.AddPoint(-82.8, (float)-65.0));
            list.Add( MapHelper.AddPoint(-77.1, (float)-55.6));
            list.Add( MapHelper.AddPoint(-73.4, (float)-46.0));
            list.Add( MapHelper.AddPoint(-60.7, (float)-44.8));
            list.Add( MapHelper.AddPoint(-40.6, (float)-44.2));
            list.Add( MapHelper.AddPoint(-18.0, (float)-44.2));
            list.Add( MapHelper.AddPoint(9.1, (float)-43.9));
            list.Add( MapHelper.AddPoint(22.4, (float)-45.7));
            list.Add( MapHelper.AddPoint(29.9, (float)-47.2));
            list.Add( MapHelper.AddPoint(38.0, (float)-45.4));
            list.Add( MapHelper.AddPoint(48.4, (float)-41.8));
            list.Add( MapHelper.AddPoint(61.5, (float)-43.9));
            list.Add( MapHelper.AddPoint(69.5, (float)-45.1));
            list.Add( MapHelper.AddPoint(74.5, (float)-51.7));
            list.Add( MapHelper.AddPoint(78.9, (float)-58.3));
            list.Add( MapHelper.AddPoint(85.4, (float)-64.7));
            list.Add( MapHelper.AddPoint(91.1, (float)-72.2));
            list.Add( MapHelper.AddPoint(98.2, (float)-76.1));
            list.Add( MapHelper.AddPoint(107.6, (float)-78.8));
            list.Add( MapHelper.AddPoint(116.9, (float)-77.0));
            list.Add( MapHelper.AddPoint(125.0, (float)-72.8));
            list.Add( MapHelper.AddPoint(133.3, (float)-67.4));
            list.Add( MapHelper.AddPoint(139.8, (float)-59.2));
            list.Add( MapHelper.AddPoint(143.0, (float)-50.2));
            list.Add( MapHelper.AddPoint(143.5, (float)-40.6));
            list.Add( MapHelper.AddPoint(141.7, (float)-32.5));
            list.Add( MapHelper.AddPoint(137.8, (float)-25.0));
            list.Add( MapHelper.AddPoint(134.1, (float)-20.4));
            list.Add( MapHelper.AddPoint(129.7, (float)-16.5));
            list.Add( MapHelper.AddPoint(124.7, (float)-12.9));
            list.Add( MapHelper.AddPoint(120.8, (float)-9.6));
            list.Add( MapHelper.AddPoint(113.0, (float)-6.9));
            list.Add( MapHelper.AddPoint(106.5, (float)-6.6));
            list.Add( MapHelper.AddPoint(98.2, (float)-6.6));
            list.Add( MapHelper.AddPoint(90.6, (float)-9.0));
            list.Add( MapHelper.AddPoint(86.5, (float)-10.8));
            list.Add( MapHelper.AddPoint(82.0, (float)-8.4));
            list.Add( MapHelper.AddPoint(77.1, (float)-3.0));
            list.Add( MapHelper.AddPoint(75.8, (float)3.3));
            list.Add( MapHelper.AddPoint(74.7, (float)12.0));
            list.Add( MapHelper.AddPoint(75.5, (float)25.3));
            list.Add( MapHelper.AddPoint(74.2, (float)35.8));
            list.Add( MapHelper.AddPoint(72.4, (float)42.7));
            list.Add( MapHelper.AddPoint(68.5, (float)45.4));
            list.Add( MapHelper.AddPoint(62.8, (float)46.3));
            list.Add( MapHelper.AddPoint(56.3, (float)43.3));
            list.Add( MapHelper.AddPoint(49.0, (float)39.4));
            list.Add( MapHelper.AddPoint(40.6, (float)37.3));
            list.Add( MapHelper.AddPoint(31.3, (float)36.7));
            list.Add( MapHelper.AddPoint(25.0, (float)38.2));
            list.Add( MapHelper.AddPoint(16.1, (float)44.8));
            list.Add( MapHelper.AddPoint(11.2, (float)54.4));
            list.Add( MapHelper.AddPoint(8.1, (float)61.9));
            list.Add( MapHelper.AddPoint(6.8, (float)67.4));
            list.Add( MapHelper.AddPoint(6.5, (float)76.1));
            list.Add( MapHelper.AddPoint(10.2, (float)85.1));
            list.Add( MapHelper.AddPoint(14.6, (float)92.9));
            list.Add( MapHelper.AddPoint(20.8, (float)98.9));
            list.Add( MapHelper.AddPoint(30.7, (float)103.4));
            list.Add( MapHelper.AddPoint(39.8, (float)105.8));
            list.Add( MapHelper.AddPoint(48.2, (float)105.2));
            list.Add( MapHelper.AddPoint(56.0, (float)103.4));
            list.Add( MapHelper.AddPoint(63.8, (float)99.5));
            list.Add( MapHelper.AddPoint(69.8, (float)92.6));
            list.Add( MapHelper.AddPoint(73.7, (float)86.6));
            list.Add( MapHelper.AddPoint(76.6, (float)81.8));
            list.Add( MapHelper.AddPoint(80.5, (float)80.0));
            list.Add( MapHelper.AddPoint(92.4, (float)79.7));
            list.Add( MapHelper.AddPoint(106.8, (float)80.0));
            list.Add( MapHelper.AddPoint(121.6, (float)80.0));
            list.Add( MapHelper.AddPoint(136.5, (float)79.1));
            list.Add( MapHelper.AddPoint(150.1, (float)79.7));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var waterRight = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var waterLeft = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var stoneRight = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var stoneLeft = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bushLeft = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bushRight = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bushTop = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var cratesRight = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var cratesLeft = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();

            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-38.5, (float)-55.0));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-27.1, (float)-76.7));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-38.3, (float)-85.1));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-44.3, (float)-77.9));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-48.7, (float)-94.7));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-59.1, (float)-90.2));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-58.9, (float)-71.6));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-52.9, (float)-69.2));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-58.9, (float)-59.5));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-50.8, (float)-54.1));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-46.6, (float)-59.2));
            cratesLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-38.5, (float)-55.0));

            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)45.5, (float)-59.0));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)38.8, (float)-53.5));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)26.6, (float)-75.5));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)37.0, (float)-83.6));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)44.0, (float)-79.7));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)48.7, (float)-94.7));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)60.2, (float)-90.5));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)59.1, (float)-72.2));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)53.1, (float)-68.6));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)59.1, (float)-61.3));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)51.3, (float)-53.8));
            cratesRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)45.5, (float)-59.0));


            bushLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)95.0));
            bushLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-141.1, (float)97.7));
            bushLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-134.4, (float)100.4));
            bushLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-128.9, (float)109.8));
            bushLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-127.9, (float)115.5));
            bushLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.2, (float)115.5));
            bushLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)95.0));

            bushRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)93.8));
            bushRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.7, (float)96.5));
            bushRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)131.8, (float)101.0));
            bushRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)131.5, (float)108.9));
            bushRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)125.5, (float)115.5));
            bushRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)115.5));
            bushRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)93.8));

            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)-77.0));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-145.8, (float)-82.4));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-137.5, (float)-90.2));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-132.6, (float)-99.5));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-120.6, (float)-99.5));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-115.9, (float)-108.9));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-106.8, (float)-108.3));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-99.5, (float)-104.9));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-88.8, (float)-103.4));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-79.2, (float)-103.7));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-72.7, (float)-106.1));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-64.8, (float)-105.5));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-60.7, (float)-109.8));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-56.3, (float)-112.8));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-48.7, (float)-106.7));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-42.2, (float)-107.4));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-36.7, (float)-110.7));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-31.3, (float)-108.0));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-23.2, (float)-100.4));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-18.0, (float)-96.8));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-7.8, (float)-96.2));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-7.8, (float)-85.4));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-0.8, (float)-83.3));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)5.7, (float)-85.4));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)8.6, (float)-94.4));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)16.9, (float)-95.0));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)21.4, (float)-103.1));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)30.5, (float)-104.3));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)32.3, (float)-113.1));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)34.9, (float)-113.4));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)47.4, (float)-102.8));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)59.9, (float)-113.1));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)66.7, (float)-104.9));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)73.4, (float)-105.2));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)77.6, (float)-102.2));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)82.6, (float)-107.7));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)88.0, (float)-104.0));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)94.3, (float)-105.2));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)99.5, (float)-104.3));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)105.2, (float)-108.3));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)116.9, (float)-105.2));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)119.8, (float)-100.4));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)125.3, (float)-96.2));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)129.9, (float)-102.5));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)135.4, (float)-100.1));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)133.1, (float)-90.2));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.1, (float)-84.2));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)-79.1));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-114.3));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-115.5));
            bushTop.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)-77.0));


            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-146.6, (float)50.8));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-130.7, (float)70.1));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-124.2, (float)63.4));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-114.1, (float)68.3));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-111.2, (float)66.8));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-105.5, (float)60.1));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-98.2, (float)52.3));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-102.3, (float)46.3));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-110.2, (float)51.1));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-120.3, (float)46.3));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-128.6, (float)36.4));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-138.5, (float)31.9));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-141.9, (float)39.7));
            stoneLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-146.6, (float)50.8));

            stoneRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)147.9, (float)51.4));
            stoneRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)129.9, (float)71.0));
            stoneRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)123.7, (float)63.4));
            stoneRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)113.0, (float)68.3));
            stoneRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)96.9, (float)51.4));
            stoneRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)102.1, (float)45.7));
            stoneRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)110.7, (float)51.4));
            stoneRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.0, (float)31.6));
            stoneRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)147.7, (float)52.3));

            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-53.1, (float)95.0));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-43.5, (float)80.0));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-37.0, (float)67.7));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-28.6, (float)50.2));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-39.3, (float)46.0));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-47.7, (float)46.3));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-54.4, (float)48.7));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-60.4, (float)53.8));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-64.6, (float)59.8));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-67.2, (float)67.7));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-68.0, (float)77.6));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-63.5, (float)85.7));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-58.1, (float)89.3));
            waterLeft.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-53.1, (float)95.0));

            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)54.2, (float)98.0));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)65.9, (float)87.8));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)69.5, (float)73.4));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)67.4, (float)64.0));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)61.7, (float)54.4));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)53.1, (float)46.6));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)44.8, (float)43.9));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)35.7, (float)43.6));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)26.6, (float)47.2));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)33.1, (float)60.4));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)39.1, (float)71.9));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)44.3, (float)80.9));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)49.2, (float)89.6));
            waterRight.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)54.2, (float)98.0));

            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)74.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-117.2, (float)73.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-75.5, (float)73.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-70.1, (float)78.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-62.5, (float)90.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-53.4, (float)97.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-38.5, (float)98.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-24.5, (float)94.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-15.1, (float)82.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-11.2, (float)68.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-14.6, (float)56.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-23.4, (float)43.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-35.7, (float)40.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-47.1, (float)41.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-56.8, (float)47.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-67.7, (float)49.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-78.9, (float)47.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-79.9, (float)31.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-81.8, (float)12.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-79.7, (float)4.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-87.0, (float)0.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-103.9, (float)3.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-119.5, (float)4.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-133.9, (float)-7.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-144.0, (float)-20.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.2, (float)-37.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-146.9, (float)-52.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-141.7, (float)-65.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-131.8, (float)-77.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-120.8, (float)-82.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-109.4, (float)-85.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-94.8, (float)-81.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-85.7, (float)-76.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-76.6, (float)-65.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-71.1, (float)-53.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-51.8, (float)-49.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-33.9, (float)-51.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-9.1, (float)-50.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)20.6, (float)-51.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)50.0, (float)-49.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)69.0, (float)-50.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)74.7, (float)-64.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)89.6, (float)-78.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)105.2, (float)-84.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)121.4, (float)-81.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)133.3, (float)-74.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.5, (float)-60.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.2, (float)-46.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)147.4, (float)-31.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.4, (float)-17.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)130.7, (float)-5.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)122.7, (float)1.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)110.2, (float)5.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)98.2, (float)3.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)90.1, (float)-2.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)82.8, (float)0.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)80.2, (float)6.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)83.1, (float)15.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)80.7, (float)29.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)78.6, (float)37.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)80.7, (float)44.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)77.6, (float)50.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)53.4, (float)48.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)38.8, (float)41.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)25.5, (float)45.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)17.2, (float)54.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)12.2, (float)66.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)14.1, (float)81.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)20.8, (float)91.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)35.2, (float)98.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)49.7, (float)98.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)61.5, (float)90.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)68.5, (float)80.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)73.4, (float)74.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)86.2, (float)73.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)106.8, (float)74.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)125.0, (float)74.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)140.4, (float)74.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)73.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)88.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)126.3, (float)86.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)105.5, (float)86.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)90.1, (float)87.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)79.4, (float)86.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)73.4, (float)98.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)65.6, (float)104.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)54.9, (float)110.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)44.0, (float)115.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)34.4, (float)114.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)13.0, (float)115.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)7.3, (float)108.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)1.3, (float)97.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)0.0, (float)82.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)2.1, (float)59.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)7.8, (float)47.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)16.1, (float)37.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)25.8, (float)32.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)41.7, (float)30.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)51.3, (float)34.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)59.1, (float)39.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)63.3, (float)39.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)67.7, (float)39.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)68.8, (float)23.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)69.0, (float)11.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)69.0, (float)-3.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)74.2, (float)-8.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)81.5, (float)-15.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)90.9, (float)-14.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)105.7, (float)-11.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)115.6, (float)-13.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)125.0, (float)-19.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)129.9, (float)-24.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)136.5, (float)-34.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.5, (float)-51.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)131.3, (float)-61.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)119.0, (float)-70.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)105.5, (float)-74.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)95.8, (float)-71.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)87.0, (float)-60.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)81.0, (float)-49.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)74.7, (float)-40.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)72.1, (float)-37.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)57.8, (float)-36.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)35.7, (float)-38.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)42.2, (float)-27.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)31.5, (float)-18.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)19.8, (float)-28.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)21.4, (float)-37.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)2.1, (float)-36.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-12.0, (float)-36.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-22.9, (float)-37.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-18.0, (float)-29.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-26.6, (float)-24.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-31.5, (float)-18.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-43.2, (float)-28.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-37.0, (float)-36.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-62.5, (float)-37.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-74.0, (float)-39.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-83.6, (float)-53.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-91.9, (float)-66.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-102.6, (float)-72.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-110.7, (float)-74.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-119.5, (float)-71.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-129.4, (float)-65.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-133.6, (float)-57.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-137.5, (float)-44.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-136.5, (float)-35.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-130.2, (float)-23.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-121.6, (float)-15.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-109.9, (float)-12.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-96.4, (float)-13.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-88.5, (float)-18.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-76.0, (float)-11.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-68.8, (float)-4.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-69.0, (float)7.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-69.0, (float)22.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-69.5, (float)37.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-68.0, (float)40.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-54.7, (float)34.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-41.1, (float)31.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-31.8, (float)30.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-22.9, (float)31.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-13.5, (float)37.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-8.3, (float)47.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-2.3, (float)56.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-2.9, (float)83.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-8.6, (float)95.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-10.7, (float)109.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-11.2, (float)115.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-54.4, (float)115.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-67.2, (float)104.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-78.1, (float)91.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-79.4, (float)85.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-100.3, (float)85.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-119.3, (float)84.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-137.5, (float)85.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.2, (float)85.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)74.0));

            var area4 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.51852f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(62.96297f, 109.25f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.48149f, 105.2037f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(66.48149f, 102.0093f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(70.74075f, 98.81493f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(87.40742f, 105.8427f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(89.25928f, 110.5277f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(77.77779f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(68.70372f, 115f));
            area4.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(63.33334f, 108.8241f));

            newAreas.Add(new AreaModel("land0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("water0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(waterRight), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(waterLeft), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("track1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));

            newAreas.Add(new AreaModel("stone0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(stoneLeft), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("stone1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(stoneRight), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bushTop), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bushLeft), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bushRight), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crates0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(cratesLeft), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("crates1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(cratesRight), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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