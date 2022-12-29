using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class CastleRuins
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(60.2, (float)115.5));
            list.Add( MapHelper.AddPoint(59.4, (float)11.4));
            list.Add( MapHelper.AddPoint(59.4, (float)9.3));
            list.Add( MapHelper.AddPoint(62.0, (float)7.2));
            list.Add( MapHelper.AddPoint(66.7, (float)3.9));
            list.Add( MapHelper.AddPoint(71.6, (float)0.0));
            list.Add( MapHelper.AddPoint(76.0, (float)-2.7));
            list.Add( MapHelper.AddPoint(81.2, (float)-6.9));
            list.Add( MapHelper.AddPoint(86.2, (float)-13.2));
            list.Add( MapHelper.AddPoint(91.9, (float)-19.2));
            list.Add( MapHelper.AddPoint(96.6, (float)-26.5));
            list.Add( MapHelper.AddPoint(101.0, (float)-34.6));
            list.Add( MapHelper.AddPoint(102.3, (float)-40.9));
            list.Add( MapHelper.AddPoint(104.4, (float)-48.7));
            list.Add( MapHelper.AddPoint(104.7, (float)-56.2));
            list.Add( MapHelper.AddPoint(102.6, (float)-62.2));
            list.Add( MapHelper.AddPoint(100.3, (float)-71.0));
            list.Add( MapHelper.AddPoint(100.0, (float)-71.3));
            list.Add( MapHelper.AddPoint(96.4, (float)-79.4));
            list.Add( MapHelper.AddPoint(93.0, (float)-83.9));
            list.Add( MapHelper.AddPoint(89.6, (float)-89.3));
            list.Add( MapHelper.AddPoint(85.4, (float)-93.2));
            list.Add( MapHelper.AddPoint(82.6, (float)-95.9));
            list.Add( MapHelper.AddPoint(78.4, (float)-98.0));
            list.Add( MapHelper.AddPoint(75.0, (float)-100.4));
            list.Add( MapHelper.AddPoint(72.1, (float)-101.6));
            list.Add( MapHelper.AddPoint(67.7, (float)-103.1));
            list.Add( MapHelper.AddPoint(64.8, (float)-104.3));
            list.Add( MapHelper.AddPoint(60.7, (float)-104.9));
            list.Add( MapHelper.AddPoint(57.3, (float)-105.5));
            list.Add( MapHelper.AddPoint(52.3, (float)-105.5));
            list.Add( MapHelper.AddPoint(47.4, (float)-104.6));
            list.Add( MapHelper.AddPoint(44.3, (float)-102.8));
            list.Add( MapHelper.AddPoint(40.1, (float)-101.3));
            list.Add( MapHelper.AddPoint(35.9, (float)-99.2));
            list.Add( MapHelper.AddPoint(33.1, (float)-98.3));
            list.Add( MapHelper.AddPoint(30.5, (float)-95.6));
            list.Add( MapHelper.AddPoint(28.6, (float)-93.8));
            list.Add( MapHelper.AddPoint(26.8, (float)-91.1));
            list.Add( MapHelper.AddPoint(25.0, (float)-89.0));
            list.Add( MapHelper.AddPoint(23.7, (float)-86.9));
            list.Add( MapHelper.AddPoint(21.6, (float)-82.1));
            list.Add( MapHelper.AddPoint(19.8, (float)-78.8));
            list.Add( MapHelper.AddPoint(17.4, (float)-74.9));
            list.Add( MapHelper.AddPoint(14.8, (float)-70.4));
            list.Add( MapHelper.AddPoint(13.8, (float)-67.4));
            list.Add( MapHelper.AddPoint(13.0, (float)-64.0));
            list.Add( MapHelper.AddPoint(12.0, (float)-60.7));
            list.Add( MapHelper.AddPoint(11.2, (float)-57.1));
            list.Add( MapHelper.AddPoint(10.2, (float)-53.5));
            list.Add( MapHelper.AddPoint(9.9, (float)-49.9));
            list.Add( MapHelper.AddPoint(9.4, (float)-45.4));
            list.Add( MapHelper.AddPoint(9.4, (float)-42.1));
            list.Add( MapHelper.AddPoint(9.9, (float)-37.6));
            list.Add( MapHelper.AddPoint(10.4, (float)-32.5));
            list.Add( MapHelper.AddPoint(10.7, (float)-26.2));
            list.Add( MapHelper.AddPoint(10.7, (float)-22.3));
            list.Add( MapHelper.AddPoint(10.4, (float)-17.1));
            list.Add( MapHelper.AddPoint(11.5, (float)-14.7));
            list.Add( MapHelper.AddPoint(10.2, (float)-11.7));
            list.Add( MapHelper.AddPoint(7.3, (float)-6.0));
            list.Add( MapHelper.AddPoint(5.2, (float)-3.9));
            list.Add( MapHelper.AddPoint(3.4, (float)-2.7));
            list.Add( MapHelper.AddPoint(-1.3, (float)-1.2));
            list.Add( MapHelper.AddPoint(-7.0, (float)0.6));
            list.Add( MapHelper.AddPoint(-44.3, (float)0.0));
            list.Add( MapHelper.AddPoint(-49.2, (float)0.0));
            list.Add( MapHelper.AddPoint(-51.8, (float)0.3));
            list.Add( MapHelper.AddPoint(-53.6, (float)6.0));
            list.Add( MapHelper.AddPoint(-54.4, (float)10.2));
            list.Add( MapHelper.AddPoint(-54.4, (float)16.2));
            list.Add( MapHelper.AddPoint(-54.4, (float)21.0));
            list.Add( MapHelper.AddPoint(-52.1, (float)31.6));
            list.Add( MapHelper.AddPoint(-50.3, (float)35.8));
            list.Add( MapHelper.AddPoint(-48.2, (float)44.5));
            list.Add( MapHelper.AddPoint(-46.9, (float)52.0));
            list.Add( MapHelper.AddPoint(-46.4, (float)58.9));
            list.Add( MapHelper.AddPoint(-45.8, (float)66.2));
            list.Add( MapHelper.AddPoint(-47.9, (float)75.5));
            list.Add( MapHelper.AddPoint(-51.0, (float)86.0));
            list.Add( MapHelper.AddPoint(-56.5, (float)93.5));
            list.Add( MapHelper.AddPoint(-61.5, (float)98.0));
            list.Add( MapHelper.AddPoint(-66.7, (float)101.3));
            list.Add( MapHelper.AddPoint(-70.6, (float)102.8));
            list.Add( MapHelper.AddPoint(-76.8, (float)104.6));
            list.Add( MapHelper.AddPoint(-81.5, (float)105.8));
            list.Add( MapHelper.AddPoint(-87.0, (float)106.7));
            list.Add( MapHelper.AddPoint(-92.2, (float)107.1));
            list.Add( MapHelper.AddPoint(-98.7, (float)104.6));
            list.Add( MapHelper.AddPoint(-104.7, (float)102.8));
            list.Add( MapHelper.AddPoint(-105.7, (float)102.2));
            list.Add( MapHelper.AddPoint(-110.4, (float)99.5));
            list.Add( MapHelper.AddPoint(-114.6, (float)97.1));
            list.Add( MapHelper.AddPoint(-117.7, (float)94.4));
            list.Add( MapHelper.AddPoint(-122.9, (float)89.0));
            list.Add( MapHelper.AddPoint(-126.8, (float)84.5));
            list.Add( MapHelper.AddPoint(-128.9, (float)76.4));
            list.Add( MapHelper.AddPoint(-130.5, (float)69.8));
            list.Add( MapHelper.AddPoint(-132.0, (float)62.8));
            list.Add( MapHelper.AddPoint(-132.3, (float)54.7));
            list.Add( MapHelper.AddPoint(-133.9, (float)48.7));
            list.Add( MapHelper.AddPoint(-134.4, (float)41.8));
            list.Add( MapHelper.AddPoint(-134.4, (float)32.5));
            list.Add( MapHelper.AddPoint(-134.1, (float)27.7));
            list.Add( MapHelper.AddPoint(-130.2, (float)21.0));
            list.Add( MapHelper.AddPoint(-126.6, (float)17.1));
            list.Add( MapHelper.AddPoint(-122.7, (float)12.9));
            list.Add( MapHelper.AddPoint(-119.3, (float)7.8));
            list.Add( MapHelper.AddPoint(-114.8, (float)3.9));
            list.Add( MapHelper.AddPoint(-110.9, (float)2.4));
            list.Add( MapHelper.AddPoint(-105.5, (float)0.9));
            list.Add( MapHelper.AddPoint(-102.6, (float)-1.8));
            list.Add( MapHelper.AddPoint(-101.0, (float)-6.9));
            list.Add( MapHelper.AddPoint(-100.8, (float)-12.3));
            list.Add( MapHelper.AddPoint(-100.5, (float)-19.5));
            list.Add( MapHelper.AddPoint(-100.8, (float)-114.6));


            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var water = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var chest = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var crate = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var decrease = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush0 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush1 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();
            var bush2 = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();

            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)103.1, (float)-114.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)103.4, (float)-112.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)107.0, (float)-111.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)108.6, (float)-107.4));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)110.7, (float)-104.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)114.6, (float)-102.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)118.2, (float)-102.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)121.1, (float)-101.9));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)121.4, (float)-98.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)123.2, (float)-94.7));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)122.9, (float)-92.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)125.0, (float)-90.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)127.6, (float)-89.9));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)130.5, (float)-89.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)133.6, (float)-89.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)136.5, (float)-90.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.8, (float)-91.1));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)139.3, (float)-88.7));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.0, (float)-86.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)135.2, (float)-82.4));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)133.9, (float)-78.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)132.0, (float)-73.4));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)132.0, (float)-69.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)133.1, (float)-66.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)135.7, (float)-66.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)136.7, (float)-66.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.3, (float)-64.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.7, (float)-62.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)145.1, (float)-62.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.5, (float)-60.1));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.9, (float)-58.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)140.9, (float)-55.9));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.7, (float)-52.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.2, (float)-49.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)144.3, (float)-47.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.2, (float)-45.7));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.1, (float)-44.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.4, (float)-41.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)139.6, (float)-39.1));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)139.6, (float)-34.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)140.1, (float)-30.7));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)140.1, (float)-29.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.8, (float)-28.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.3, (float)-24.1));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)135.9, (float)-22.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)134.9, (float)-18.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)135.7, (float)-15.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.3, (float)-12.9));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.8, (float)-10.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.8, (float)-9.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)137.2, (float)-6.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)135.4, (float)-4.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)134.1, (float)-1.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)136.2, (float)0.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)137.2, (float)0.9));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.8, (float)1.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)139.6, (float)3.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.3, (float)7.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.8, (float)15.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)139.8, (float)16.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.2, (float)19.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)145.6, (float)22.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)146.1, (float)23.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)147.4, (float)26.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)148.2, (float)28.9));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)146.4, (float)30.4));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)145.6, (float)34.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)144.3, (float)35.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.8, (float)37.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)142.7, (float)41.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)141.1, (float)41.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)139.3, (float)45.1));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)140.9, (float)48.1));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.0, (float)50.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.0, (float)52.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)144.3, (float)55.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)146.9, (float)60.4));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)147.1, (float)61.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)146.1, (float)65.9));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)143.8, (float)68.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)140.9, (float)69.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)138.0, (float)74.0));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)135.4, (float)77.3));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)134.1, (float)79.1));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)132.6, (float)83.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)130.7, (float)83.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)127.3, (float)83.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)125.3, (float)83.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)124.7, (float)86.6));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)123.4, (float)88.7));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)122.4, (float)91.1));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)121.6, (float)97.1));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)119.8, (float)99.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)115.1, (float)103.7));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)113.3, (float)106.7));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)111.5, (float)109.8));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)109.4, (float)115.5));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.2, (float)115.2));
            bush2.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-114.6));

            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-123.7, (float)-114.9));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-129.4, (float)-107.7));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-128.4, (float)-99.2));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-128.4, (float)-95.3));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-134.6, (float)-94.1));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-135.9, (float)-89.0));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-140.1, (float)-86.3));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-143.2, (float)-86.3));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-144.8, (float)-87.2));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-146.9, (float)-87.5));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-148.7, (float)-85.4));
            bush1.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-114.0));

            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)115.5));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)54.7));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.8, (float)79.7));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-130.5, (float)99.5));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-120.1, (float)108.0));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-109.6, (float)112.8));
            bush0.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-93.8, (float)115.5));

            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)20.6, (float)-65.3));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)27.3, (float)-61.0));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)25.3, (float)-55.6));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)42.4, (float)-47.8));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)44.0, (float)-51.7));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)52.9, (float)-50.5));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)52.3, (float)-47.5));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)60.2, (float)-43.9));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)68.0, (float)-36.1));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)75.8, (float)-26.8));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)84.1, (float)-21.7));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)85.2, (float)-20.7));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)80.7, (float)-16.8));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)17.4, (float)-53.8));
            decrease.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)20.6, (float)-63.1));

            crate.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)99.2, (float)-12.9));
            crate.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)110.9, (float)-1.2));
            crate.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)101.0, (float)10.8));
            crate.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)95.6, (float)11.1));
            crate.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)82.8, (float)0.6));
            crate.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)92.7, (float)-11.7));

            chest.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)26.0, (float)68.6));
            chest.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)37.8, (float)84.5));
            chest.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)46.4, (float)83.3));
            chest.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)55.7, (float)71.3));
            chest.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)51.3, (float)65.3));
            chest.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)46.4, (float)59.2));
            chest.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)39.6, (float)53.8));
            chest.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)37.5, (float)52.0));
            chest.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)29.4, (float)63.7));

            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-63.3, (float)72.8));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-56.8, (float)60.7));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-57.8, (float)45.1));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-63.0, (float)27.4));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-73.4, (float)15.9));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-84.4, (float)12.0));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-96.4, (float)8.1));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-104.4, (float)10.8));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-112.2, (float)14.7));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-118.0, (float)20.7));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-123.2, (float)28.0));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-126.8, (float)33.7));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-126.8, (float)34.3));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-103.9, (float)50.5));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-83.3, (float)62.5));
            water.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-64.1, (float)73.1));

            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-108.9, (float)-114.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-108.3, (float)-5.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-120.1, (float)0.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-129.9, (float)10.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-139.8, (float)25.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-145.8, (float)42.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-147.1, (float)57.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-142.2, (float)74.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-135.9, (float)91.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-125.5, (float)102.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-112.2, (float)111.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-101.8, (float)115.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-89.1, (float)115.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-74.5, (float)113.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-62.0, (float)106.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-52.9, (float)97.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-44.5, (float)86.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-38.3, (float)71.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-39.1, (float)55.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-41.7, (float)38.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-49.5, (float)24.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-52.9, (float)12.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-42.7, (float)8.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-21.1, (float)8.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)6.0, (float)8.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)21.1, (float)-9.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)18.0, (float)-25.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)16.7, (float)-46.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)18.5, (float)-62.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)29.7, (float)-80.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)39.6, (float)-94.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)56.8, (float)-97.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)70.3, (float)-95.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)82.8, (float)-88.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)91.7, (float)-75.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)97.9, (float)-55.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)95.3, (float)-39.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)87.0, (float)-23.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)77.1, (float)-14.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)66.7, (float)-7.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)52.3, (float)4.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)53.4, (float)26.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)50.8, (float)56.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)52.1, (float)114.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)67.7, (float)115.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)66.9, (float)8.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)79.9, (float)2.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)96.1, (float)-12.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)104.9, (float)-26.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)110.4, (float)-42.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)110.2, (float)-65.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)102.3, (float)-80.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)93.0, (float)-94.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)78.9, (float)-104.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)62.2, (float)-113.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)42.4, (float)-111.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)29.4, (float)-104.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)16.1, (float)-94.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)5.7, (float)-80.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-1.0, (float)-67.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-0.8, (float)-54.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)1.3, (float)-40.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)4.2, (float)-25.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)7.8, (float)-18.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)4.9, (float)-15.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-3.9, (float)-7.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-26.3, (float)-8.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-39.6, (float)-6.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-58.9, (float)-7.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-58.6, (float)13.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-59.6, (float)26.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-59.4, (float)33.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-56.0, (float)45.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-52.6, (float)54.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-55.5, (float)72.5));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-62.5, (float)87.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-74.0, (float)94.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-84.1, (float)98.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-94.5, (float)98.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-103.6, (float)93.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-112.2, (float)88.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-120.1, (float)80.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-123.4, (float)70.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-126.8, (float)56.2));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-126.6, (float)42.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-124.5, (float)31.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-116.9, (float)17.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-108.9, (float)10.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-100.8, (float)7.8));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-94.0, (float)0.9));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-92.7, (float)-8.4));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-94.3, (float)-34.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-93.5, (float)-49.6));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-94.8, (float)-61.0));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-94.8, (float)-76.1));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-94.3, (float)-82.7));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-93.0, (float)-98.3));
            track.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2((float)-93.8, (float)-113.7));

            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            newAreas.Add(new AreaModel("land0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(water), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("chest", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(chest), Main.Empty(), 10, AreaType.unplaceable));
            newAreas.Add(new AreaModel("crate", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(crate), Main.Empty(), 10, AreaType.unplaceable));
            newAreas.Add(new AreaModel("decrease", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(decrease), Main.Empty(), 10, AreaType.unplaceable));

            newAreas.Add(new AreaModel("bush0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush0), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush1", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush1), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bush2), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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