using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class Glade
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(109.9, (float)115.5));
            list.Add( MapHelper.AddPoint(96.1, (float)107.4));
            list.Add( MapHelper.AddPoint(82.3, (float)104.0));
            list.Add( MapHelper.AddPoint(73.2, (float)99.2));
            list.Add( MapHelper.AddPoint(66.7, (float)92.3));
            list.Add( MapHelper.AddPoint(62.0, (float)87.8));
            list.Add( MapHelper.AddPoint(57.3, (float)77.0));
            list.Add( MapHelper.AddPoint(55.7, (float)66.2));
            list.Add( MapHelper.AddPoint(55.7, (float)56.2));
            list.Add( MapHelper.AddPoint(58.6, (float)46.9));
            list.Add( MapHelper.AddPoint(62.5, (float)36.7));
            list.Add( MapHelper.AddPoint(69.0, (float)28.9));
            list.Add( MapHelper.AddPoint(74.7, (float)24.1));
            list.Add( MapHelper.AddPoint(81.0, (float)18.3));
            list.Add( MapHelper.AddPoint(87.8, (float)9.3));
            list.Add( MapHelper.AddPoint(91.4, (float)3.9));
            list.Add( MapHelper.AddPoint(96.4, (float)-5.7));
            list.Add( MapHelper.AddPoint(98.4, (float)-10.5));
            list.Add( MapHelper.AddPoint(100.3, (float)-18.6));
            list.Add( MapHelper.AddPoint(99.2, (float)-35.5));
            list.Add( MapHelper.AddPoint(94.0, (float)-47.5));
            list.Add( MapHelper.AddPoint(89.1, (float)-53.5));
            list.Add( MapHelper.AddPoint(83.9, (float)-57.7));
            list.Add( MapHelper.AddPoint(78.1, (float)-61.3));
            list.Add( MapHelper.AddPoint(70.6, (float)-63.1));
            list.Add( MapHelper.AddPoint(57.0, (float)-61.9));
            list.Add( MapHelper.AddPoint(49.7, (float)-59.8));
            list.Add( MapHelper.AddPoint(43.2, (float)-56.5));
            list.Add( MapHelper.AddPoint(35.7, (float)-52.0));
            list.Add( MapHelper.AddPoint(28.1, (float)-44.8));
            list.Add( MapHelper.AddPoint(21.6, (float)-37.0));
            list.Add( MapHelper.AddPoint(13.8, (float)-27.7));
            list.Add( MapHelper.AddPoint(9.1, (float)-20.1));
            list.Add( MapHelper.AddPoint(0.0, (float)-5.7));
            list.Add( MapHelper.AddPoint(-16.1, (float)23.8));
            list.Add( MapHelper.AddPoint(-25.8, (float)39.7));
            list.Add( MapHelper.AddPoint(-38.0, (float)55.0));
            list.Add( MapHelper.AddPoint(-52.6, (float)67.4));
            list.Add( MapHelper.AddPoint(-65.9, (float)71.3));
            list.Add( MapHelper.AddPoint(-78.4, (float)72.5));
            list.Add( MapHelper.AddPoint(-89.8, (float)71.0));
            list.Add( MapHelper.AddPoint(-100.0, (float)65.3));
            list.Add( MapHelper.AddPoint(-108.3, (float)56.8));
            list.Add( MapHelper.AddPoint(-113.5, (float)47.5));
            list.Add( MapHelper.AddPoint(-119.0, (float)37.0));
            list.Add( MapHelper.AddPoint(-121.9, (float)23.2));
            list.Add( MapHelper.AddPoint(-121.4, (float)9.9));
            list.Add( MapHelper.AddPoint(-120.3, (float)-2.4));
            list.Add( MapHelper.AddPoint(-115.4, (float)-15.3));
            list.Add( MapHelper.AddPoint(-111.2, (float)-24.4));
            list.Add( MapHelper.AddPoint(-105.2, (float)-36.1));
            list.Add( MapHelper.AddPoint(-96.9, (float)-51.1));
            list.Add( MapHelper.AddPoint(-88.5, (float)-62.8));
            list.Add( MapHelper.AddPoint(-82.3, (float)-71.9));
            list.Add( MapHelper.AddPoint(-76.0, (float)-83.9));
            list.Add( MapHelper.AddPoint(-72.7, (float)-94.7));
            list.Add( MapHelper.AddPoint(-70.6, (float)-107.1));
            list.Add( MapHelper.AddPoint(-68.2, (float)-114.6));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(150.1, (float)-46.3));
            list.Add( MapHelper.AddPoint(129.9, (float)-51.4));
            list.Add( MapHelper.AddPoint(114.1, (float)-55.9));
            list.Add( MapHelper.AddPoint(103.1, (float)-58.6));
            list.Add( MapHelper.AddPoint(92.4, (float)-60.4));
            list.Add( MapHelper.AddPoint(57.0, (float)-61.9));
            list.Add( MapHelper.AddPoint(49.7, (float)-59.8));
            list.Add( MapHelper.AddPoint(43.2, (float)-56.5));
            list.Add( MapHelper.AddPoint(35.7, (float)-52.0));
            list.Add( MapHelper.AddPoint(28.1, (float)-44.8));
            list.Add( MapHelper.AddPoint(21.6, (float)-37.0));
            list.Add( MapHelper.AddPoint(13.8, (float)-27.7));
            list.Add( MapHelper.AddPoint(9.1, (float)-20.1));
            list.Add( MapHelper.AddPoint(0.0, (float)-5.7));
            list.Add( MapHelper.AddPoint(-16.1, (float)23.8));
            list.Add( MapHelper.AddPoint(-25.8, (float)39.7));
            list.Add( MapHelper.AddPoint(-38.0, (float)55.0));
            list.Add( MapHelper.AddPoint(-52.6, (float)67.4));
            list.Add( MapHelper.AddPoint(-65.9, (float)71.3));
            list.Add( MapHelper.AddPoint(-78.4, (float)72.5));
            list.Add( MapHelper.AddPoint(-89.8, (float)71.0));
            list.Add( MapHelper.AddPoint(-97.9, (float)70.7));
            list.Add( MapHelper.AddPoint(-109.9, (float)69.8));
            list.Add( MapHelper.AddPoint(-123.4, (float)68.6));
            list.Add( MapHelper.AddPoint(-137.0, (float)65.6));
            list.Add( MapHelper.AddPoint(-149.9, (float)58.0));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var bush = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();

            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.8, (float)91.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-137.2, (float)94.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-133.3, (float)101.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-128.1, (float)99.2));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-124.7, (float)100.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-121.9, (float)101.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-112.8, (float)103.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-111.5, (float)99.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-100.5, (float)98.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-98.4, (float)97.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-93.5, (float)101.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-89.3, (float)104.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-82.8, (float)107.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.9, (float)106.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-65.6, (float)106.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-60.9, (float)107.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-58.9, (float)111.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-56.8, (float)112.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-49.0, (float)111.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-43.8, (float)110.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-36.5, (float)110.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-31.8, (float)107.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-30.7, (float)103.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-24.2, (float)100.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-19.3, (float)103.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.0, (float)107.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.2, (float)104.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-5.2, (float)103.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-0.5, (float)104.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)5.7, (float)104.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)11.2, (float)103.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)18.5, (float)107.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)22.1, (float)108.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)25.5, (float)108.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)29.4, (float)105.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)35.2, (float)102.2));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)42.4, (float)107.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)46.9, (float)107.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)53.1, (float)106.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)56.8, (float)104.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)59.9, (float)102.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.8, (float)101.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)70.8, (float)101.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)74.5, (float)103.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)79.4, (float)106.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)83.6, (float)107.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)91.9, (float)107.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.6, (float)106.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)100.3, (float)105.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)105.7, (float)106.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)110.4, (float)108.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)117.2, (float)109.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)121.9, (float)110.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)124.2, (float)109.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)124.0, (float)105.2));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)126.3, (float)98.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)128.9, (float)92.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)130.2, (float)86.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)134.9, (float)79.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)137.8, (float)66.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)135.2, (float)60.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)133.6, (float)53.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)136.2, (float)48.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)132.6, (float)44.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)130.5, (float)40.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)131.8, (float)37.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)134.9, (float)34.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)137.0, (float)26.2));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)136.7, (float)17.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)139.8, (float)9.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)134.9, (float)6.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)131.8, (float)-1.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)134.6, (float)-3.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)140.1, (float)-2.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)143.2, (float)-10.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)142.7, (float)-16.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)138.3, (float)-17.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)136.5, (float)-25.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)135.7, (float)-30.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)134.6, (float)-39.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)131.3, (float)-48.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)129.2, (float)-52.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)131.0, (float)-55.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)131.0, (float)-65.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)128.1, (float)-77.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)127.6, (float)-78.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)125.5, (float)-84.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)117.4, (float)-89.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)106.8, (float)-94.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)99.5, (float)-93.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)90.9, (float)-95.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)84.1, (float)-99.2));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)80.5, (float)-101.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)78.9, (float)-99.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.1, (float)-98.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)60.4, (float)-102.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)54.9, (float)-102.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)49.5, (float)-102.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.1, (float)-100.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)42.2, (float)-97.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)36.2, (float)-95.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)22.1, (float)-96.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)17.4, (float)-99.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)9.1, (float)-98.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)3.4, (float)-96.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-2.6, (float)-95.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.7, (float)-94.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-15.1, (float)-94.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-22.1, (float)-98.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-25.3, (float)-101.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-28.6, (float)-105.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-29.7, (float)-107.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-30.5, (float)-107.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-33.1, (float)-103.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-35.2, (float)-99.2));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-37.2, (float)-95.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-42.4, (float)-95.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-48.4, (float)-98.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-54.2, (float)-99.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-61.5, (float)-103.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-69.0, (float)-104.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.7, (float)-104.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-80.5, (float)-101.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-85.4, (float)-100.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-96.6, (float)-98.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-101.0, (float)-98.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-106.8, (float)-98.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.8, (float)-103.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-120.1, (float)-104.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-129.2, (float)-104.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-128.6, (float)-100.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-128.9, (float)-92.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-133.6, (float)-85.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-133.3, (float)-79.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.9, (float)-74.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-138.0, (float)-68.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-138.0, (float)-57.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-135.2, (float)-49.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-137.8, (float)-43.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-139.6, (float)-38.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.5, (float)-32.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-144.5, (float)-27.1));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-144.3, (float)-20.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-146.6, (float)-15.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-145.8, (float)-9.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.2, (float)-6.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.0, (float)3.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-140.4, (float)10.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-138.5, (float)13.8));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-139.6, (float)18.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-139.3, (float)22.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-139.1, (float)28.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-138.5, (float)34.0));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-142.2, (float)39.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.5, (float)41.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-144.8, (float)46.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.8, (float)52.3));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-140.9, (float)55.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-136.5, (float)61.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-136.2, (float)64.7));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-135.9, (float)72.2));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-136.2, (float)78.2));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-138.5, (float)82.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-138.5, (float)88.4));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-139.8, (float)89.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)101.6));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-114.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.5, (float)-115.2));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)114.9));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)115.5));
            bush.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.0, (float)87.5));

            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)99.5, (float)29.2));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)83.6, (float)30.4));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)71.9, (float)41.2));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)66.1, (float)54.7));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)65.1, (float)69.2));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)68.8, (float)78.5));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)74.5, (float)87.2));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)83.3, (float)93.8));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.3, (float)95.3));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)102.6, (float)96.8));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)107.3, (float)89.9));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)106.5, (float)82.7));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)101.0, (float)73.7));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)98.2, (float)63.1));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)100.8, (float)51.1));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)104.7, (float)43.9));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)108.3, (float)36.7));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)102.9, (float)29.2));

            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-111.2, (float)7.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-108.3, (float)25.6));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-100.8, (float)48.1));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-93.2, (float)57.1));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-79.2, (float)62.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-66.1, (float)61.9));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-61.5, (float)60.1));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-59.4, (float)48.4));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-61.2, (float)43.3));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-68.5, (float)35.8));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.1, (float)23.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-76.8, (float)18.0));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-82.3, (float)12.3));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-80.5, (float)-1.2));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-77.9, (float)-12.6));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-75.5, (float)-24.4));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-81.5, (float)-37.0));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-89.8, (float)-41.2));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-94.5, (float)-35.2));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-104.9, (float)-15.9));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-111.2, (float)4.8));

            track2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-94.8, (float)77.3));
            track2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-117.4, (float)76.1));
            track2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.6, (float)71.3));
            track2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-142.4, (float)68.9));
            track2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-147.4, (float)53.2));
            track2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-135.2, (float)57.7));
            track2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-119.3, (float)61.6));
            track2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-109.4, (float)64.0));

            track1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)140.6, (float)-43.3));
            track1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)100.0, (float)-52.6));
            track1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)81.8, (float)-70.7));
            track1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)114.6, (float)-63.4));
            track1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)141.4, (float)-53.8));

            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)97.1, (float)115.5));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.6, (float)100.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)53.6, (float)86.0));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)49.5, (float)67.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)49.0, (float)52.9));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)54.4, (float)34.3));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.1, (float)26.5));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)73.7, (float)16.2));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)89.6, (float)-2.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)93.5, (float)-13.8));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)90.9, (float)-36.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)80.5, (float)-48.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)64.1, (float)-54.1));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.7, (float)-51.1));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)34.9, (float)-41.8));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)18.2, (float)-22.0));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-4.9, (float)17.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-21.4, (float)48.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.3, (float)59.5));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-48.7, (float)72.2));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-64.8, (float)79.1));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-84.9, (float)78.8));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-101.3, (float)74.3));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.3, (float)61.9));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-122.1, (float)45.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-127.9, (float)22.0));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-127.9, (float)3.0));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-125.0, (float)-13.2));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-121.1, (float)-24.1));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-112.8, (float)-40.9));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-101.6, (float)-56.8));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-92.7, (float)-70.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-81.5, (float)-86.0));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-76.6, (float)-100.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-76.8, (float)-108.6));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-63.0, (float)-107.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-65.9, (float)-85.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-78.1, (float)-63.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-94.5, (float)-40.9));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-106.5, (float)-15.3));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-112.5, (float)3.6));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-114.8, (float)21.0));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-109.1, (float)44.5));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-96.6, (float)59.2));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-80.7, (float)64.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-65.1, (float)65.3));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-48.2, (float)55.6));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.8, (float)38.2));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-21.4, (float)16.8));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-5.5, (float)-13.5));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)6.8, (float)-29.8));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)23.2, (float)-50.5));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)41.1, (float)-63.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)56.3, (float)-69.5));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)74.2, (float)-69.5));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)87.5, (float)-64.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)99.7, (float)-54.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)104.9, (float)-40.6));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)108.9, (float)-24.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)105.2, (float)-5.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)97.1, (float)11.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)91.7, (float)22.9));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)77.3, (float)35.8));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)66.7, (float)50.5));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)62.8, (float)63.4));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)66.7, (float)80.6));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)77.1, (float)92.3));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)90.6, (float)98.6));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)102.3, (float)100.7));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)110.7, (float)104.6));
            track0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)119.0, (float)112.2));

            newAreas.Add(new AreaModel("land0", new Assets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track0", new Assets.Scripts.Simulation.SMath.Polygon(track0), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("track1", new Assets.Scripts.Simulation.SMath.Polygon(track1), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("track2", new Assets.Scripts.Simulation.SMath.Polygon(track2), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Assets.Scripts.Simulation.SMath.Polygon(water0), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Assets.Scripts.Simulation.SMath.Polygon(water1), Main.Empty(), 10, AreaType.water));

            newAreas.Add(new AreaModel("bush", new Assets.Scripts.Simulation.SMath.Polygon(bush), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

            return (Il2CppReferenceArray<AreaModel>)newAreas.ToArray();
        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new MoabOnlySplitterModel("", new string[]
                    {
                        "MainPath",
                        "SecondPath"
                    }, new bool[]
                    {
                        false,
                        true
                    }), new MoabOnlySplitterModel("", new string[]
                    {
                        "MainPath",
                        "SecondPath"
                    }, new bool[]
                    {
                        false,
                        true
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