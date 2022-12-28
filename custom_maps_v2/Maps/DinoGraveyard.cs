using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class DinoGraveyard
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add( MapHelper.AddPoint(-134.9, (float)-115.2));
            list.Add( MapHelper.AddPoint(-135.7, (float)-95.6));
            list.Add( MapHelper.AddPoint(-135.7, (float)-74.9));
            list.Add( MapHelper.AddPoint(-134.4, (float)-52.9));
            list.Add( MapHelper.AddPoint(-134.1, (float)-37.3));
            list.Add( MapHelper.AddPoint(-128.9, (float)-22.3));
            list.Add( MapHelper.AddPoint(-124.5, (float)-12.9));
            list.Add( MapHelper.AddPoint(-119.3, (float)-5.1));
            list.Add( MapHelper.AddPoint(-113.3, (float)0.9));
            list.Add( MapHelper.AddPoint(-107.6, (float)6.0));
            list.Add( MapHelper.AddPoint(-101.3, (float)9.3));
            list.Add( MapHelper.AddPoint(-98.2, (float)10.5));
            list.Add( MapHelper.AddPoint(-93.0, (float)13.8));
            list.Add( MapHelper.AddPoint(-85.7, (float)15.0));
            list.Add( MapHelper.AddPoint(-78.1, (float)15.6));
            list.Add( MapHelper.AddPoint(-72.1, (float)15.6));
            list.Add( MapHelper.AddPoint(-64.6, (float)14.4));
            list.Add( MapHelper.AddPoint(-56.5, (float)11.4));
            list.Add( MapHelper.AddPoint(-48.7, (float)8.1));
            list.Add( MapHelper.AddPoint(-42.4, (float)3.6));
            list.Add( MapHelper.AddPoint(-35.9, (float)-1.8));
            list.Add( MapHelper.AddPoint(-29.2, (float)-7.8));
            list.Add( MapHelper.AddPoint(-25.0, (float)-14.4));
            list.Add( MapHelper.AddPoint(-20.8, (float)-20.4));
            list.Add( MapHelper.AddPoint(-17.4, (float)-28.3));
            list.Add( MapHelper.AddPoint(-15.9, (float)-36.1));
            list.Add( MapHelper.AddPoint(-14.1, (float)-46.6));
            list.Add( MapHelper.AddPoint(-12.5, (float)-56.8));
            list.Add( MapHelper.AddPoint(-11.7, (float)-64.7));
            list.Add( MapHelper.AddPoint(-10.7, (float)-70.7));
            list.Add( MapHelper.AddPoint(-10.9, (float)-75.2));
            list.Add( MapHelper.AddPoint(-10.7, (float)-78.5));
            list.Add( MapHelper.AddPoint(-9.9, (float)-80.3));
            list.Add( MapHelper.AddPoint(-8.1, (float)-82.1));
            list.Add( MapHelper.AddPoint(-6.0, (float)-83.3));
            list.Add( MapHelper.AddPoint(-2.6, (float)-84.5));
            list.Add( MapHelper.AddPoint(9.9, (float)-86.3));
            list.Add( MapHelper.AddPoint(24.2, (float)-86.3));
            list.Add( MapHelper.AddPoint(45.8, (float)-85.1));
            list.Add( MapHelper.AddPoint(104.4, (float)-86.6));
            list.Add( MapHelper.AddPoint(107.8, (float)-86.0));
            list.Add( MapHelper.AddPoint(109.9, (float)-84.8));
            list.Add( MapHelper.AddPoint(112.0, (float)-83.0));
            list.Add( MapHelper.AddPoint(113.8, (float)-81.5));
            list.Add( MapHelper.AddPoint(115.1, (float)-79.4));
            list.Add( MapHelper.AddPoint(116.4, (float)-76.4));
            list.Add( MapHelper.AddPoint(116.4, (float)-74.0));
            list.Add( MapHelper.AddPoint(118.5, (float)25.3));
            list.Add( MapHelper.AddPoint(119.5, (float)32.5));
            list.Add( MapHelper.AddPoint(118.5, (float)39.4));
            list.Add( MapHelper.AddPoint(117.2, (float)47.2));
            list.Add( MapHelper.AddPoint(115.1, (float)56.8));
            list.Add( MapHelper.AddPoint(111.2, (float)66.2));
            list.Add( MapHelper.AddPoint(106.3, (float)75.8));
            list.Add( MapHelper.AddPoint(100.0, (float)84.8));
            list.Add( MapHelper.AddPoint(91.4, (float)91.4));
            list.Add( MapHelper.AddPoint(84.6, (float)95.6));
            list.Add( MapHelper.AddPoint(76.8, (float)99.8));
            list.Add( MapHelper.AddPoint(70.8, (float)101.9));
            list.Add( MapHelper.AddPoint(61.7, (float)103.4));
            list.Add( MapHelper.AddPoint(51.0, (float)102.5));
            list.Add( MapHelper.AddPoint(43.0, (float)100.7));
            list.Add( MapHelper.AddPoint(33.9, (float)95.9));
            list.Add( MapHelper.AddPoint(29.2, (float)91.4));
            list.Add( MapHelper.AddPoint(21.6, (float)85.1));
            list.Add( MapHelper.AddPoint(17.2, (float)79.1));
            list.Add( MapHelper.AddPoint(11.5, (float)72.5));
            list.Add( MapHelper.AddPoint(8.1, (float)67.4));
            list.Add( MapHelper.AddPoint(3.1, (float)61.0));
            list.Add( MapHelper.AddPoint(-1.3, (float)57.4));
            list.Add( MapHelper.AddPoint(-6.5, (float)54.7));
            list.Add( MapHelper.AddPoint(-12.8, (float)54.1));
            list.Add( MapHelper.AddPoint(-19.0, (float)52.9));
            list.Add( MapHelper.AddPoint(-149.9, (float)54.1));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }


        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var track = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            var water = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();

            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-1.6, (float)-57.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-5.2, (float)-30.7));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-14.1, (float)-9.6));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.0, (float)7.8));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-30.2, (float)16.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-30.2, (float)24.1));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.6, (float)30.1));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-19.5, (float)35.2));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-10.9, (float)38.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)7.6, (float)39.1));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)24.0, (float)32.5));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)34.9, (float)20.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)40.9, (float)2.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)37.5, (float)-19.2));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)30.7, (float)-37.3));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)23.4, (float)-51.4));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)17.2, (float)-58.0));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)9.4, (float)-61.0));
            water.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)1.8, (float)-60.1));

            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.2, (float)-114.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-143.5, (float)-94.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-142.4, (float)-74.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-140.9, (float)-51.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-139.3, (float)-31.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-134.1, (float)-17.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-122.1, (float)-1.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-112.2, (float)9.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-99.5, (float)16.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-88.3, (float)21.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-74.5, (float)21.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-60.9, (float)19.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-46.9, (float)13.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-29.4, (float)1.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-18.8, (float)-10.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-12.0, (float)-25.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-8.3, (float)-44.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-7.8, (float)-59.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-6.3, (float)-67.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-4.7, (float)-76.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)109.1, (float)-80.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)112.5, (float)-70.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)113.0, (float)40.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)108.6, (float)59.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)98.4, (float)76.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)86.2, (float)86.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)72.1, (float)93.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)59.9, (float)96.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)43.2, (float)92.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)29.7, (float)82.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)14.6, (float)67.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)5.5, (float)53.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)5.5, (float)55.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-3.4, (float)46.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-39.6, (float)46.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.9, (float)48.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-149.5, (float)61.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-7.8, (float)58.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)6.0, (float)75.2));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)21.4, (float)93.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)35.9, (float)104.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)51.8, (float)110.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)65.4, (float)107.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)83.6, (float)102.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)96.9, (float)92.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)110.7, (float)79.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)119.8, (float)63.7));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)123.2, (float)44.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)125.0, (float)18.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)124.2, (float)-14.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)124.5, (float)-55.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)121.9, (float)-78.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)118.5, (float)-88.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)108.3, (float)-94.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)80.5, (float)-94.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)43.0, (float)-93.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)10.2, (float)-94.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-4.2, (float)-93.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-15.1, (float)-88.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-19.3, (float)-66.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-20.3, (float)-42.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-26.6, (float)-22.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-37.8, (float)-8.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-51.8, (float)2.1));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-72.4, (float)8.4));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-94.0, (float)3.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-112.0, (float)-9.0));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-123.2, (float)-25.3));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-128.1, (float)-44.8));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-127.6, (float)-68.6));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-128.9, (float)-89.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-127.3, (float)-102.5));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-127.1, (float)-114.9));
            track.Add(new Assets.Scripts.Simulation.SMath.Vector2((float)-129.9, (float)-115.2));

            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));


            newAreas.Add(new AreaModel("land0", new Assets.Scripts.Simulation.SMath.Polygon(mainLand), Main.Empty(), 10, AreaType.land));
            newAreas.Add(new AreaModel("track", new Assets.Scripts.Simulation.SMath.Polygon(track), Main.Empty(), 10, AreaType.track));
            newAreas.Add(new AreaModel("water", new Assets.Scripts.Simulation.SMath.Polygon(water), Main.Empty(), 10, AreaType.water));

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