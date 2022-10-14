using Assets.Scripts.Models.Map;
using Assets.Scripts.Models.Map.Spawners;
using Assets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;

namespace custommaps.Maps.BTDBattles2
{
    class Inflection
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(150.1, (float)-69.2));
            list.Add( MapHelper.AddPoint(139.6, (float)-68.6));
            list.Add( MapHelper.AddPoint(130.5, (float)-67.4));
            list.Add( MapHelper.AddPoint(123.2, (float)-66.2));
            list.Add( MapHelper.AddPoint(115.4, (float)-63.1));
            list.Add( MapHelper.AddPoint(109.6, (float)-59.8));
            list.Add( MapHelper.AddPoint(102.1, (float)-55.9));
            list.Add( MapHelper.AddPoint(97.1, (float)-50.8));
            list.Add( MapHelper.AddPoint(92.7, (float)-47.2));
            list.Add( MapHelper.AddPoint(88.5, (float)-43.3));
            list.Add( MapHelper.AddPoint(84.9, (float)-36.4));
            list.Add( MapHelper.AddPoint(81.8, (float)-29.5));
            list.Add( MapHelper.AddPoint(79.9, (float)-23.2));
            list.Add( MapHelper.AddPoint(77.1, (float)-15.3));
            list.Add( MapHelper.AddPoint(76.3, (float)-3.0));
            list.Add( MapHelper.AddPoint(76.0, (float)4.2));
            list.Add( MapHelper.AddPoint(74.5, (float)14.7));
            list.Add( MapHelper.AddPoint(74.2, (float)28.3));
            list.Add( MapHelper.AddPoint(74.0, (float)33.7));
            list.Add( MapHelper.AddPoint(72.1, (float)38.8));
            list.Add( MapHelper.AddPoint(70.8, (float)43.9));
            list.Add( MapHelper.AddPoint(67.4, (float)51.7));
            list.Add( MapHelper.AddPoint(62.5, (float)58.9));
            list.Add( MapHelper.AddPoint(58.6, (float)65.0));
            list.Add( MapHelper.AddPoint(52.3, (float)71.3));
            list.Add( MapHelper.AddPoint(47.9, (float)75.8));
            list.Add( MapHelper.AddPoint(41.4, (float)79.1));
            list.Add( MapHelper.AddPoint(32.3, (float)83.3));
            list.Add( MapHelper.AddPoint(24.5, (float)86.6));
            list.Add( MapHelper.AddPoint(16.4, (float)88.1));
            list.Add( MapHelper.AddPoint(9.1, (float)89.0));
            list.Add( MapHelper.AddPoint(1.0, (float)90.2));
            list.Add( MapHelper.AddPoint(-4.9, (float)89.9));
            list.Add( MapHelper.AddPoint(-13.5, (float)88.4));
            list.Add( MapHelper.AddPoint(-21.4, (float)87.2));
            list.Add( MapHelper.AddPoint(-28.9, (float)84.8));
            list.Add( MapHelper.AddPoint(-35.9, (float)82.4));
            list.Add( MapHelper.AddPoint(-41.4, (float)79.7));
            list.Add( MapHelper.AddPoint(-47.9, (float)75.8));
            list.Add( MapHelper.AddPoint(-53.1, (float)71.9));
            list.Add( MapHelper.AddPoint(-58.3, (float)67.1));
            list.Add( MapHelper.AddPoint(-63.0, (float)61.3));
            list.Add( MapHelper.AddPoint(-66.1, (float)56.8));
            list.Add( MapHelper.AddPoint(-68.5, (float)50.2));
            list.Add( MapHelper.AddPoint(-71.6, (float)43.3));
            list.Add( MapHelper.AddPoint(-72.9, (float)37.6));
            list.Add( MapHelper.AddPoint(-75.0, (float)30.7));
            list.Add( MapHelper.AddPoint(-75.3, (float)23.5));
            list.Add( MapHelper.AddPoint(-75.5, (float)15.0));
            list.Add( MapHelper.AddPoint(-75.5, (float)6.3));
            list.Add( MapHelper.AddPoint(-75.5, (float)1.2));
            list.Add( MapHelper.AddPoint(-76.3, (float)-6.6));
            list.Add( MapHelper.AddPoint(-76.8, (float)-13.8));
            list.Add( MapHelper.AddPoint(-78.1, (float)-20.1));
            list.Add( MapHelper.AddPoint(-79.9, (float)-24.1));
            list.Add( MapHelper.AddPoint(-82.8, (float)-31.6));
            list.Add( MapHelper.AddPoint(-85.4, (float)-36.4));
            list.Add( MapHelper.AddPoint(-88.3, (float)-41.5));
            list.Add( MapHelper.AddPoint(-92.2, (float)-46.3));
            list.Add( MapHelper.AddPoint(-96.1, (float)-51.7));
            list.Add( MapHelper.AddPoint(-101.3, (float)-56.5));
            list.Add( MapHelper.AddPoint(-105.7, (float)-59.8));
            list.Add( MapHelper.AddPoint(-109.4, (float)-61.9));
            list.Add( MapHelper.AddPoint(-113.8, (float)-65.3));
            list.Add( MapHelper.AddPoint(-118.2, (float)-66.8));
            list.Add( MapHelper.AddPoint(-124.2, (float)-69.2));
            list.Add( MapHelper.AddPoint(-131.8, (float)-68.9));
            list.Add( MapHelper.AddPoint(-139.6, (float)-69.8));
            list.Add( MapHelper.AddPoint(-146.1, (float)-69.8));
            list.Add( MapHelper.AddPoint(-149.9, (float)-70.4));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(149.5, (float)89.3));
            list.Add( MapHelper.AddPoint(116.9, (float)89.0));
            list.Add( MapHelper.AddPoint(90.9, (float)87.5));
            list.Add( MapHelper.AddPoint(68.8, (float)87.2));
            list.Add( MapHelper.AddPoint(50.5, (float)86.3));
            list.Add( MapHelper.AddPoint(40.9, (float)83.9));
            list.Add( MapHelper.AddPoint(32.8, (float)80.6));
            list.Add( MapHelper.AddPoint(21.6, (float)76.7));
            list.Add( MapHelper.AddPoint(16.7, (float)71.3));
            list.Add( MapHelper.AddPoint(11.5, (float)66.2));
            list.Add( MapHelper.AddPoint(7.0, (float)61.0));
            list.Add( MapHelper.AddPoint(4.4, (float)56.8));
            list.Add( MapHelper.AddPoint(2.1, (float)51.4));
            list.Add( MapHelper.AddPoint(0.5, (float)43.9));
            list.Add( MapHelper.AddPoint(-1.8, (float)34.0));
            list.Add( MapHelper.AddPoint(-2.6, (float)27.7));
            list.Add( MapHelper.AddPoint(-3.6, (float)18.0));
            list.Add( MapHelper.AddPoint(-4.2, (float)9.9));
            list.Add( MapHelper.AddPoint(-4.9, (float)2.1));
            list.Add( MapHelper.AddPoint(-6.5, (float)-9.0));
            list.Add( MapHelper.AddPoint(-9.4, (float)-18.6));
            list.Add( MapHelper.AddPoint(-13.0, (float)-26.8));
            list.Add( MapHelper.AddPoint(-16.1, (float)-33.4));
            list.Add( MapHelper.AddPoint(-20.1, (float)-39.1));
            list.Add( MapHelper.AddPoint(-26.3, (float)-45.4));
            list.Add( MapHelper.AddPoint(-30.7, (float)-49.6));
            list.Add( MapHelper.AddPoint(-35.4, (float)-53.5));
            list.Add( MapHelper.AddPoint(-41.7, (float)-56.2));
            list.Add( MapHelper.AddPoint(-48.2, (float)-59.5));
            list.Add( MapHelper.AddPoint(-57.0, (float)-62.5));
            list.Add( MapHelper.AddPoint(-65.9, (float)-64.7));
            list.Add( MapHelper.AddPoint(-72.1, (float)-65.3));
            list.Add( MapHelper.AddPoint(-90.4, (float)-67.7));
            list.Add( MapHelper.AddPoint(-102.1, (float)-68.9));
            list.Add( MapHelper.AddPoint(-113.3, (float)-69.5));
            list.Add( MapHelper.AddPoint(-125.3, (float)-68.9));
            list.Add( MapHelper.AddPoint(-131.8, (float)-68.9));
            list.Add( MapHelper.AddPoint(-139.6, (float)-69.8));
            list.Add( MapHelper.AddPoint(-146.1, (float)-69.8));
            list.Add( MapHelper.AddPoint(-149.9, (float)-70.4));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var trackMain = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var trackSecond = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();

            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)-78.8));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)128.1, (float)-76.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)111.5, (float)-72.2));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)96.9, (float)-63.1));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)83.6, (float)-51.1));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)77.1, (float)-36.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)71.9, (float)-25.0));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)69.5, (float)-15.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)68.5, (float)-7.2));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)68.5, (float)-0.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)67.2, (float)12.3));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)67.2, (float)21.0));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)66.9, (float)30.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)63.5, (float)39.7));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)59.1, (float)49.3));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)53.4, (float)59.2));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)45.8, (float)67.7));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)31.0, (float)74.6));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)12.8, (float)79.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)2.1, (float)80.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.7, (float)78.8));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-21.1, (float)77.3));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-38.5, (float)71.6));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-47.9, (float)64.7));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-55.7, (float)56.5));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-63.0, (float)44.2));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-65.9, (float)29.8));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-67.2, (float)15.6));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-68.0, (float)-1.8));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-68.2, (float)-12.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.4, (float)-25.0));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-76.3, (float)-34.6));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-81.8, (float)-44.8));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-86.5, (float)-52.6));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-91.4, (float)-58.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-95.8, (float)-63.7));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-135.4, (float)-60.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-125.3, (float)-57.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-113.8, (float)-54.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-103.6, (float)-48.1));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-96.1, (float)-38.8));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-91.4, (float)-31.6));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-87.0, (float)-20.7));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-85.9, (float)-12.0));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-84.6, (float)2.7));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-84.1, (float)5.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-83.9, (float)20.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-82.0, (float)33.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-77.9, (float)47.2));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-73.2, (float)57.1));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-68.2, (float)65.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-60.4, (float)76.7));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-46.1, (float)86.0));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-34.4, (float)92.3));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-20.6, (float)95.6));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-7.8, (float)98.0));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)4.9, (float)99.2));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)17.7, (float)97.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)31.0, (float)92.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)41.4, (float)89.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)53.1, (float)83.6));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)60.7, (float)75.5));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)69.5, (float)64.0));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)74.7, (float)53.8));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)78.9, (float)43.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)81.5, (float)34.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)82.0, (float)17.1));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)84.1, (float)-6.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)86.2, (float)-19.5));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)90.6, (float)-30.4));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)96.6, (float)-40.3));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)104.7, (float)-46.9));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)111.2, (float)-51.7));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)119.8, (float)-56.5));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)128.6, (float)-57.7));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)137.8, (float)-59.8));
            trackMain.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.5, (float)-58.0));

            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)79.1));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)58.3, (float)76.7));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)37.5, (float)73.7));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)25.0, (float)65.9));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)19.3, (float)62.2));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)8.1, (float)44.2));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)4.9, (float)26.2));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)3.9, (float)6.0));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)2.6, (float)-2.4));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-6.5, (float)-34.6));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-13.0, (float)-44.5));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-21.1, (float)-53.5));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-27.3, (float)-59.2));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-41.9, (float)-66.5));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-57.8, (float)-70.7));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-70.8, (float)-73.7));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-86.5, (float)-75.5));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-100.3, (float)-76.7));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-119.8, (float)-77.9));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-135.4, (float)-80.0));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-80.3));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-60.4));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-118.2, (float)-60.1));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-91.1, (float)-58.6));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-75.8, (float)-56.8));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-56.8, (float)-52.6));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-45.6, (float)-49.3));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-36.5, (float)-44.5));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-30.2, (float)-38.5));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-23.4, (float)-30.4));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-17.2, (float)-21.7));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.8, (float)-2.4));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.0, (float)9.6));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.0, (float)25.3));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-9.9, (float)38.5));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-7.6, (float)48.1));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-3.4, (float)57.1));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)4.4, (float)70.4));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)12.5, (float)79.1));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)19.3, (float)83.3));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)28.1, (float)87.5));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)41.4, (float)91.4));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)56.5, (float)93.8));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)73.2, (float)95.6));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)86.5, (float)96.8));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)102.3, (float)97.1));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)113.3, (float)97.4));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)130.2, (float)98.6));
            trackSecond.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.0, (float)98.9));

            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)5.7, (float)77.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-3.4, (float)63.1));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-8.3, (float)51.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.2, (float)40.3));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-13.3, (float)28.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-14.1, (float)20.1));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-17.7, (float)10.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.6, (float)8.7));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-39.3, (float)9.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-49.2, (float)15.0));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-52.9, (float)23.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-56.5, (float)32.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-56.0, (float)43.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-54.4, (float)53.2));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-48.4, (float)60.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-40.1, (float)67.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-31.8, (float)71.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-23.2, (float)75.2));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-17.4, (float)76.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-9.1, (float)78.2));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-2.6, (float)78.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)3.9, (float)77.6));

            newAreas.Add(new AreaModel("land0", new Assets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track0", new Assets.Scripts.Simulation.SMath.Polygon(trackMain), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("track1", new Assets.Scripts.Simulation.SMath.Polygon(trackSecond), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Assets.Scripts.Simulation.SMath.Polygon(water), Main.Empty(), 10, AreaType.water));

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
                        "MainPath",
                        "SecondPath"
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