using Assets.Scripts.Models.Map;
using Assets.Scripts.Models.Map.Spawners;
using Assets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;

namespace custommaps.Maps.BTDBattles2
{
    class Koru
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-23.7, (float)-22.3));
            list.Add( MapHelper.AddPoint(-18.2, (float)-31.9));
            list.Add( MapHelper.AddPoint(-11.2, (float)-35.8));
            list.Add( MapHelper.AddPoint(-1.8, (float)-37.9));
            list.Add( MapHelper.AddPoint(6.8, (float)-37.3));
            list.Add( MapHelper.AddPoint(14.8, (float)-34.6));
            list.Add( MapHelper.AddPoint(22.9, (float)-29.2));
            list.Add( MapHelper.AddPoint(29.7, (float)-20.4));
            list.Add( MapHelper.AddPoint(33.1, (float)-10.5));
            list.Add( MapHelper.AddPoint(34.9, (float)1.2));
            list.Add( MapHelper.AddPoint(34.4, (float)10.2));
            list.Add( MapHelper.AddPoint(31.3, (float)18.0));
            list.Add( MapHelper.AddPoint(26.3, (float)30.1));
            list.Add( MapHelper.AddPoint(18.8, (float)37.6));
            list.Add( MapHelper.AddPoint(11.7, (float)43.0));
            list.Add( MapHelper.AddPoint(3.4, (float)46.3));
            list.Add( MapHelper.AddPoint(-5.5, (float)48.7));
            list.Add( MapHelper.AddPoint(-16.9, (float)49.3));
            list.Add( MapHelper.AddPoint(-23.4, (float)49.0));
            list.Add( MapHelper.AddPoint(-32.6, (float)45.4));
            list.Add( MapHelper.AddPoint(-42.2, (float)40.0));
            list.Add( MapHelper.AddPoint(-50.0, (float)33.7));
            list.Add( MapHelper.AddPoint(-56.0, (float)28.0));
            list.Add( MapHelper.AddPoint(-60.2, (float)21.3));
            list.Add( MapHelper.AddPoint(-63.8, (float)14.7));
            list.Add( MapHelper.AddPoint(-68.0, (float)5.4));
            list.Add( MapHelper.AddPoint(-69.0, (float)-6.9));
            list.Add( MapHelper.AddPoint(-69.8, (float)-15.6));
            list.Add( MapHelper.AddPoint(-68.8, (float)-25.0));
            list.Add( MapHelper.AddPoint(-66.7, (float)-36.4));
            list.Add( MapHelper.AddPoint(-63.0, (float)-45.7));
            list.Add( MapHelper.AddPoint(-59.1, (float)-54.7));
            list.Add( MapHelper.AddPoint(-52.6, (float)-65.0));
            list.Add( MapHelper.AddPoint(-44.8, (float)-72.2));
            list.Add( MapHelper.AddPoint(-35.9, (float)-77.9));
            list.Add( MapHelper.AddPoint(-25.8, (float)-80.3));
            list.Add( MapHelper.AddPoint(-11.7, (float)-83.6));
            list.Add( MapHelper.AddPoint(-5.5, (float)-83.9));
            list.Add( MapHelper.AddPoint(3.6, (float)-84.5));
            list.Add( MapHelper.AddPoint(9.1, (float)-84.5));
            list.Add( MapHelper.AddPoint(19.8, (float)-84.5));
            list.Add( MapHelper.AddPoint(27.3, (float)-80.9));
            list.Add( MapHelper.AddPoint(35.4, (float)-77.6));
            list.Add( MapHelper.AddPoint(42.2, (float)-74.3));
            list.Add( MapHelper.AddPoint(50.8, (float)-66.5));
            list.Add( MapHelper.AddPoint(56.0, (float)-58.9));
            list.Add( MapHelper.AddPoint(59.4, (float)-54.7));
            list.Add( MapHelper.AddPoint(64.6, (float)-44.8));
            list.Add( MapHelper.AddPoint(68.0, (float)-40.3));
            list.Add( MapHelper.AddPoint(71.1, (float)-32.2));
            list.Add( MapHelper.AddPoint(74.0, (float)-25.6));
            list.Add( MapHelper.AddPoint(76.6, (float)-18.0));
            list.Add( MapHelper.AddPoint(77.9, (float)-11.1));
            list.Add( MapHelper.AddPoint(79.2, (float)-2.1));
            list.Add( MapHelper.AddPoint(80.2, (float)2.1));
            list.Add( MapHelper.AddPoint(81.0, (float)7.8));
            list.Add( MapHelper.AddPoint(80.2, (float)18.3));
            list.Add( MapHelper.AddPoint(76.8, (float)29.8));
            list.Add( MapHelper.AddPoint(72.1, (float)38.8));
            list.Add( MapHelper.AddPoint(69.3, (float)46.6));
            list.Add( MapHelper.AddPoint(64.8, (float)55.0));
            list.Add( MapHelper.AddPoint(58.3, (float)60.7));
            list.Add( MapHelper.AddPoint(51.3, (float)68.3));
            list.Add( MapHelper.AddPoint(46.4, (float)72.8));
            list.Add( MapHelper.AddPoint(39.6, (float)77.6));
            list.Add( MapHelper.AddPoint(29.4, (float)86.0));
            list.Add( MapHelper.AddPoint(20.1, (float)90.2));
            list.Add( MapHelper.AddPoint(11.7, (float)93.2));
            list.Add( MapHelper.AddPoint(2.1, (float)95.0));
            list.Add( MapHelper.AddPoint(-6.8, (float)95.9));
            list.Add( MapHelper.AddPoint(-16.4, (float)96.2));
            list.Add( MapHelper.AddPoint(-24.2, (float)95.3));
            list.Add( MapHelper.AddPoint(-31.8, (float)94.1));
            list.Add( MapHelper.AddPoint(-39.8, (float)92.0));
            list.Add( MapHelper.AddPoint(-50.8, (float)86.9));
            list.Add( MapHelper.AddPoint(-58.1, (float)82.4));
            list.Add( MapHelper.AddPoint(-66.9, (float)76.4));
            list.Add( MapHelper.AddPoint(-74.5, (float)70.4));
            list.Add( MapHelper.AddPoint(-83.6, (float)60.4));
            list.Add( MapHelper.AddPoint(-88.5, (float)55.9));
            list.Add( MapHelper.AddPoint(-95.8, (float)45.1));
            list.Add( MapHelper.AddPoint(-102.3, (float)37.3));
            list.Add( MapHelper.AddPoint(-109.6, (float)27.7));
            list.Add( MapHelper.AddPoint(-118.0, (float)13.8));
            list.Add( MapHelper.AddPoint(-125.3, (float)0.3));
            list.Add( MapHelper.AddPoint(-134.1, (float)-15.6));
            list.Add( MapHelper.AddPoint(-141.9, (float)-29.8));
            list.Add( MapHelper.AddPoint(-146.4, (float)-40.9));
            list.Add( MapHelper.AddPoint(-149.9, (float)-48.1));
            list.Add( MapHelper.AddPoint(-149.9, (float)-49.6));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-23.7, (float)-22.3));
            list.Add( MapHelper.AddPoint(-18.2, (float)-31.9));
            list.Add( MapHelper.AddPoint(-11.2, (float)-35.8));
            list.Add( MapHelper.AddPoint(-1.8, (float)-37.9));
            list.Add( MapHelper.AddPoint(6.8, (float)-37.3));
            list.Add( MapHelper.AddPoint(14.8, (float)-34.6));
            list.Add( MapHelper.AddPoint(22.9, (float)-29.2));
            list.Add( MapHelper.AddPoint(29.7, (float)-20.4));
            list.Add( MapHelper.AddPoint(33.1, (float)-10.5));
            list.Add( MapHelper.AddPoint(34.9, (float)1.2));
            list.Add( MapHelper.AddPoint(34.4, (float)10.2));
            list.Add( MapHelper.AddPoint(31.3, (float)18.0));
            list.Add( MapHelper.AddPoint(26.3, (float)30.1));
            list.Add( MapHelper.AddPoint(18.8, (float)37.6));
            list.Add( MapHelper.AddPoint(11.7, (float)43.0));
            list.Add( MapHelper.AddPoint(3.4, (float)46.3));
            list.Add( MapHelper.AddPoint(-5.5, (float)48.7));
            list.Add( MapHelper.AddPoint(-16.9, (float)49.3));
            list.Add( MapHelper.AddPoint(-23.4, (float)49.0));
            list.Add( MapHelper.AddPoint(-32.6, (float)45.4));
            list.Add( MapHelper.AddPoint(-42.2, (float)40.0));
            list.Add( MapHelper.AddPoint(-50.0, (float)33.7));
            list.Add( MapHelper.AddPoint(-56.0, (float)28.0));
            list.Add( MapHelper.AddPoint(-60.2, (float)21.3));
            list.Add( MapHelper.AddPoint(-63.8, (float)14.7));
            list.Add( MapHelper.AddPoint(-68.0, (float)5.4));
            list.Add( MapHelper.AddPoint(-69.0, (float)-6.9));
            list.Add( MapHelper.AddPoint(-69.8, (float)-15.6));
            list.Add( MapHelper.AddPoint(-68.8, (float)-25.0));
            list.Add( MapHelper.AddPoint(-66.7, (float)-36.4));
            list.Add( MapHelper.AddPoint(-63.0, (float)-45.7));
            list.Add( MapHelper.AddPoint(-59.1, (float)-54.7));
            list.Add( MapHelper.AddPoint(-52.6, (float)-65.0));
            list.Add( MapHelper.AddPoint(-44.8, (float)-72.2));
            list.Add( MapHelper.AddPoint(-35.9, (float)-77.9));
            list.Add( MapHelper.AddPoint(-25.8, (float)-80.3));
            list.Add( MapHelper.AddPoint(-11.7, (float)-83.6));
            list.Add( MapHelper.AddPoint(-5.5, (float)-83.9));
            list.Add( MapHelper.AddPoint(3.6, (float)-84.5));
            list.Add( MapHelper.AddPoint(9.1, (float)-84.5));
            list.Add( MapHelper.AddPoint(19.8, (float)-84.5));
            list.Add( MapHelper.AddPoint(27.3, (float)-80.9));
            list.Add( MapHelper.AddPoint(35.4, (float)-77.6));
            list.Add( MapHelper.AddPoint(42.2, (float)-74.3));
            list.Add( MapHelper.AddPoint(51.0, (float)-71.0));
            list.Add( MapHelper.AddPoint(61.5, (float)-66.5));
            list.Add( MapHelper.AddPoint(69.0, (float)-62.5));
            list.Add( MapHelper.AddPoint(76.0, (float)-58.6));
            list.Add( MapHelper.AddPoint(85.9, (float)-53.5));
            list.Add( MapHelper.AddPoint(91.9, (float)-49.9));
            list.Add( MapHelper.AddPoint(101.0, (float)-43.3));
            list.Add( MapHelper.AddPoint(108.1, (float)-37.6));
            list.Add( MapHelper.AddPoint(115.1, (float)-32.2));
            list.Add( MapHelper.AddPoint(119.3, (float)-27.4));
            list.Add( MapHelper.AddPoint(127.6, (float)-18.0));
            list.Add( MapHelper.AddPoint(133.3, (float)-11.4));
            list.Add( MapHelper.AddPoint(140.1, (float)-3.9));
            list.Add( MapHelper.AddPoint(145.8, (float)3.0));
            list.Add( MapHelper.AddPoint(150.1, (float)9.0));
            list.Add( MapHelper.AddPoint(150.1, (float)13.2));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var trunk = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var bush0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var bush1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var bush2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var bush3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();

            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)115.5));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)98.2, (float)115.5));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)101.6, (float)109.2));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)112.0, (float)100.4));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)119.8, (float)97.7));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)128.9, (float)93.2));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)130.5, (float)90.5));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)133.6, (float)81.8));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)138.8, (float)70.7));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.7, (float)58.9));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)149.2, (float)108.0));
            bush3.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)147.1, (float)111.3));

            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)115.5));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.7, (float)27.7));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-142.4, (float)47.8));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.1, (float)60.4));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-127.3, (float)71.3));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-123.7, (float)83.0));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-119.8, (float)91.4));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-109.4, (float)102.2));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-99.0, (float)111.0));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-87.5, (float)115.5));
            bush2.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.0, (float)114.6));

            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.1, (float)-114.9));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)-54.1));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)140.9, (float)-63.7));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)128.6, (float)-71.0));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)119.5, (float)-65.0));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)116.7, (float)-73.7));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)116.1, (float)-84.5));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)113.5, (float)-90.8));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)104.7, (float)-93.5));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)96.6, (float)-98.3));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)87.0, (float)-101.6));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)78.4, (float)-108.6));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.9, (float)-114.0));
            bush1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)147.1, (float)-114.3));

            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)-115.2));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.0, (float)-67.4));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-140.9, (float)-62.2));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.9, (float)-70.4));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-127.3, (float)-81.2));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-119.8, (float)-90.2));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-109.1, (float)-97.7));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-98.2, (float)-101.9));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-84.9, (float)-105.5));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.7, (float)-109.8));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-62.8, (float)-114.3));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-146.1, (float)-114.3));
            bush0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-147.7, (float)-112.5));

            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-49.2, (float)1.2));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-44.3, (float)6.6));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-37.0, (float)9.3));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-31.5, (float)11.1));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-21.6, (float)12.3));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-16.9, (float)12.9));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.2, (float)-0.3));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-7.6, (float)-7.5));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-3.9, (float)-19.5));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-34.9, (float)-34.3));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-41.1, (float)-31.9));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-42.7, (float)-24.1));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-45.1, (float)-14.7));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-48.2, (float)-2.4));
            trunk.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-44.3, (float)3.6));

            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)85.7, (float)-12.6));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)87.2, (float)-5.7));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)88.3, (float)5.4));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)88.3, (float)12.9));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)85.9, (float)21.0));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)84.4, (float)28.6));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)82.0, (float)35.5));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)78.1, (float)44.8));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)75.0, (float)51.7));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)71.4, (float)57.4));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)69.0, (float)62.5));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)68.5, (float)68.6));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)70.1, (float)71.9));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)75.8, (float)72.8));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)86.2, (float)76.4));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)95.1, (float)75.8));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)100.5, (float)71.9));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)107.8, (float)66.2));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)109.1, (float)64.0));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)112.8, (float)57.7));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)116.9, (float)50.2));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)120.1, (float)43.6));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)121.9, (float)37.9));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)121.9, (float)32.2));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)123.2, (float)21.7));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)123.2, (float)12.9));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)120.3, (float)4.2));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)114.3, (float)-4.8));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)107.8, (float)-8.7));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)99.5, (float)-13.5));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)93.8, (float)-13.8));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)88.8, (float)-14.1));
            water1.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)86.7, (float)-14.1));

            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-71.1, (float)17.4));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-80.7, (float)20.7));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-87.0, (float)20.7));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-92.4, (float)18.0));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-99.2, (float)12.0));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-105.2, (float)3.3));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-109.6, (float)-6.0));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-112.5, (float)-14.7));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-113.3, (float)-24.4));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-110.9, (float)-32.8));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-108.1, (float)-40.6));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-105.5, (float)-48.7));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-101.0, (float)-62.8));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-98.4, (float)-68.9));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-91.4, (float)-75.8));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-85.4, (float)-80.3));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-79.4, (float)-81.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.5, (float)-81.8));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-67.2, (float)-81.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-62.5, (float)-78.2));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-57.8, (float)-74.0));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-62.8, (float)-64.7));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-64.3, (float)-61.0));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-68.8, (float)-51.4));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-71.4, (float)-44.8));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.5, (float)-35.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-76.0, (float)-26.5));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-77.1, (float)-18.6));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-77.1, (float)-11.4));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-77.3, (float)-2.1));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.7, (float)7.8));
            water0.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.9, (float)15.3));

            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-27.9, (float)-28.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-18.2, (float)-40.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-16.9, (float)-40.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-11.5, (float)-43.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-0.8, (float)-44.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)3.6, (float)-44.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)10.2, (float)-44.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)16.7, (float)-41.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)22.1, (float)-38.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)27.3, (float)-34.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)32.3, (float)-27.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)35.7, (float)-23.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)37.8, (float)-17.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)39.8, (float)-9.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)40.6, (float)-3.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)40.9, (float)5.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)40.6, (float)14.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)35.9, (float)26.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)34.9, (float)31.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)28.9, (float)39.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)20.3, (float)46.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)15.1, (float)49.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)7.6, (float)52.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)0.3, (float)54.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-7.0, (float)55.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-15.6, (float)56.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-24.0, (float)56.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.3, (float)54.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-35.9, (float)52.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-41.1, (float)48.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-46.6, (float)45.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-52.1, (float)41.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-57.6, (float)35.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-63.0, (float)27.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-68.8, (float)18.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.5, (float)6.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-77.6, (float)-5.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-78.9, (float)-15.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-78.9, (float)-24.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-77.9, (float)-32.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.5, (float)-40.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-71.9, (float)-47.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-67.4, (float)-58.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-64.6, (float)-64.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-58.9, (float)-71.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-49.7, (float)-79.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-41.4, (float)-83.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-30.5, (float)-87.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-23.2, (float)-89.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.7, (float)-92.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)1.0, (float)-94.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)9.9, (float)-92.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)20.6, (float)-91.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)28.9, (float)-88.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)38.5, (float)-83.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)46.9, (float)-80.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)58.1, (float)-77.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)71.1, (float)-69.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)80.2, (float)-63.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)94.8, (float)-56.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)106.5, (float)-47.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)115.6, (float)-39.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)121.6, (float)-31.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)132.0, (float)-22.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)141.9, (float)-10.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)-2.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)150.0, (float)26.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)138.0, (float)3.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)129.2, (float)-9.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)118.2, (float)-18.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)105.7, (float)-31.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)96.6, (float)-39.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)82.3, (float)-46.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)73.2, (float)-52.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)66.7, (float)-56.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)69.5, (float)-47.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)78.6, (float)-33.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)81.5, (float)-22.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)85.9, (float)-9.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)87.5, (float)1.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)88.3, (float)13.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)84.9, (float)27.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)79.9, (float)40.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.7, (float)56.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)61.7, (float)70.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)48.2, (float)81.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)33.6, (float)88.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)20.1, (float)95.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)3.1, (float)99.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-7.3, (float)101.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-17.2, (float)101.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-29.9, (float)99.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-38.0, (float)98.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-54.9, (float)91.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.9, (float)78.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-88.0, (float)61.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-101.8, (float)48.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-108.1, (float)39.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-118.5, (float)27.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-124.2, (float)17.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-130.2, (float)6.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-137.0, (float)-5.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-139.8, (float)-15.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-36.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)-60.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-140.4, (float)-40.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-132.0, (float)-24.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-123.7, (float)-10.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-118.2, (float)0.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-112.0, (float)12.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-104.7, (float)22.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-94.5, (float)36.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-84.9, (float)49.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-75.0, (float)61.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-66.7, (float)71.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-57.3, (float)77.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-45.6, (float)83.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.6, (float)87.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-20.3, (float)88.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-8.6, (float)88.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-2.6, (float)86.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)5.7, (float)84.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)14.6, (float)80.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)25.0, (float)75.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)33.6, (float)71.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)38.5, (float)67.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.4, (float)59.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)52.1, (float)54.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)57.3, (float)47.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)62.2, (float)40.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)69.8, (float)29.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.1, (float)18.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)73.7, (float)2.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)71.9, (float)-9.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)66.1, (float)-23.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)60.2, (float)-37.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)56.8, (float)-49.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)47.9, (float)-57.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)42.7, (float)-62.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)31.8, (float)-71.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)21.9, (float)-73.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)10.2, (float)-76.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)4.2, (float)-77.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-1.6, (float)-77.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-15.4, (float)-77.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-22.4, (float)-73.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-32.6, (float)-71.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-39.6, (float)-66.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-46.1, (float)-60.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-51.0, (float)-51.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-56.3, (float)-37.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-58.6, (float)-28.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-59.4, (float)-21.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-60.4, (float)-11.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-58.3, (float)-1.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-55.7, (float)11.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-52.9, (float)18.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-49.7, (float)24.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-43.5, (float)30.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-39.6, (float)34.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-29.7, (float)39.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-23.2, (float)40.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-15.1, (float)42.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-6.3, (float)41.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)1.3, (float)39.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)9.6, (float)36.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)16.4, (float)30.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)22.4, (float)23.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)28.9, (float)8.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)28.6, (float)-0.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)27.3, (float)-13.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)25.0, (float)-21.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)18.2, (float)-28.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)12.0, (float)-31.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)2.9, (float)-33.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-6.3, (float)-32.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-13.0, (float)-28.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-14.6, (float)-23.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.0, (float)-28.9));



            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));

            newAreas.Add(new AreaModel("land0", new Assets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track0", new Assets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water0", new Assets.Scripts.Simulation.SMath.Polygon(water0), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water1", new Assets.Scripts.Simulation.SMath.Polygon(water1), Main.Empty(), 10, AreaType.water));

            newAreas.Add(new AreaModel("trunk0", new Assets.Scripts.Simulation.SMath.Polygon(trunk), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush0", new Assets.Scripts.Simulation.SMath.Polygon(bush0), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush1", new Assets.Scripts.Simulation.SMath.Polygon(bush1), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush2", new Assets.Scripts.Simulation.SMath.Polygon(bush2), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            newAreas.Add(new AreaModel("bush3", new Assets.Scripts.Simulation.SMath.Polygon(bush3), Main.Empty(), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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