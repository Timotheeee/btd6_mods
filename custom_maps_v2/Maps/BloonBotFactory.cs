using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace custommaps.Maps.BTDBattles2
{
    public class BloonBotFactory
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(150.10017, -107.050354));
            list.Add(MapHelper.AddPoint(101.56251, -107.050354));
            list.Add(MapHelper.AddPoint(101.3021, -89.00812));
            list.Add(MapHelper.AddPoint(95.83333, -82.99411));
            list.Add(MapHelper.AddPoint(56.510426, -82.39267));
            list.Add(MapHelper.AddPoint(50.520836, -88.7074));
            list.Add(MapHelper.AddPoint(50.000008, -105.84747));
            list.Add(MapHelper.AddPoint(8.593726, -106.148254));
            list.Add(MapHelper.AddPoint(8.593726, -25.860443));
            list.Add(MapHelper.AddPoint(32.031227, -24.958344));
            list.Add(MapHelper.AddPoint(32.031227, 29.168243));
            list.Add(MapHelper.AddPoint(8.854169, 30.371063));
            list.Add(MapHelper.AddPoint(9.114575, 110.658844));
            list.Add(MapHelper.AddPoint(-8.593753, 110.0574));
            list.Add(MapHelper.AddPoint(-8.072912, 29.468964));
            list.Add(MapHelper.AddPoint(-32.552086, 28.266144));
            list.Add(MapHelper.AddPoint(-32.29168, -24.958344));
            list.Add(MapHelper.AddPoint(-8.333338, -24.356934));
            list.Add(MapHelper.AddPoint(-7.812497, -106.148254));
            list.Add(MapHelper.AddPoint(-49.479164, -107.35104));
            list.Add(MapHelper.AddPoint(-49.999996, -90.51166));
            list.Add(MapHelper.AddPoint(-54.166664, -84.49762));
            list.Add(MapHelper.AddPoint(-94.27083, -82.99411));
            list.Add(MapHelper.AddPoint(-99.99999, -89.91028));
            list.Add(MapHelper.AddPoint(-101.30208, -106.74963));
            list.Add(MapHelper.AddPoint(-149.89983, -107.65173));


            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint(150.10017, 110.35809));
            list.Add(MapHelper.AddPoint(101.04167, 110.0574));
            list.Add(MapHelper.AddPoint(100.78125, 94.12015));
            list.Add(MapHelper.AddPoint(95.83333, 87.50467));
            list.Add(MapHelper.AddPoint(56.510426, 87.80536));
            list.Add(MapHelper.AddPoint(50.781227, 93.51877));
            list.Add(MapHelper.AddPoint(50.000008, 110.658844));
            list.Add(MapHelper.AddPoint(8.854169, 110.35809));
            list.Add(MapHelper.AddPoint(8.854169, 29.168243));
            list.Add(MapHelper.AddPoint(33.33335, 29.769653));
            list.Add(MapHelper.AddPoint(32.8125, -24.356934));
            list.Add(MapHelper.AddPoint(9.375, -26.762573));
            list.Add(MapHelper.AddPoint(9.114575, -106.74963));
            list.Add(MapHelper.AddPoint(-7.552081, -106.74963));
            list.Add(MapHelper.AddPoint(-8.854169, -25.559723));
            list.Add(MapHelper.AddPoint(-30.989582, -25.860443));
            list.Add(MapHelper.AddPoint(-32.03126, 29.769653));
            list.Add(MapHelper.AddPoint(-8.072912, 31.273193));
            list.Add(MapHelper.AddPoint(-7.812497, 109.756714));
            list.Add(MapHelper.AddPoint(-48.69793, 110.658844));
            list.Add(MapHelper.AddPoint(-50.520836, 94.12015));
            list.Add(MapHelper.AddPoint(-56.770832, 87.20398));
            list.Add(MapHelper.AddPoint(-92.708336, 86.60257));
            list.Add(MapHelper.AddPoint(-100.520836, 93.21805));
            list.Add(MapHelper.AddPoint(-100.520836, 110.95953));
            list.Add(MapHelper.AddPoint(-149.89983, 110.0574));

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

            var water1 = new List<Vector2>();

            water1.Add(new Vector2((float)-42.97, (float)-41.50));

            water1.Add(new Vector2((float)60.677074, (float)115.47009));
            water1.Add(new Vector2((float)60.9375, (float)104.043365));
            water1.Add(new Vector2((float)65.625, (float)97.42789));
            water1.Add(new Vector2((float)86.71875, (float)98.32999));
            water1.Add(new Vector2((float)92.708336, (float)104.043365));
            water1.Add(new Vector2((float)93.22917, (float)115.47009));


            var water2 = new List<Vector2>();

            water2.Add(new Vector2((float)-42.97, (float)-41.50));

            water2.Add(new Vector2((float)59.63543, (float)-114.86859));
            water2.Add(new Vector2((float)59.63543, (float)-99.532684));
            water2.Add(new Vector2((float)64.583336, (float)-92.91727));
            water2.Add(new Vector2((float)86.45833, (float)-92.01517));
            water2.Add(new Vector2((float)92.96873, (float)-98.630646));
            water2.Add(new Vector2((float)92.96873, (float)-114.86859));


            var track = new List<Vector2>();

            track.Add(new Vector2((float)119.01, (float)-115.17));
            track.Add(new Vector2((float)150.10017, (float)115.1694));
            track.Add(new Vector2((float)150.10017, (float)106.449005));
            track.Add(new Vector2((float)105.20833, (float)106.148315));
            track.Add(new Vector2((float)103.38542, (float)90.51169));
            track.Add(new Vector2((float)96.6146, (float)83.59555));
            track.Add(new Vector2((float)53.124977, (float)83.89624));
            track.Add(new Vector2((float)46.614574, (float)88.70749));
            track.Add(new Vector2((float)45.57293, (float)105.246185));
            track.Add(new Vector2((float)13.281226, (float)104.644775));
            track.Add(new Vector2((float)13.802075, (float)35.783722));
            track.Add(new Vector2((float)36.979168, (float)35.783722));
            track.Add(new Vector2((float)39.583324, (float)-31.874512));
            track.Add(new Vector2((float)16.666676, (float)-32.47592));
            track.Add(new Vector2((float)17.447931, (float)-96.22507));
            track.Add(new Vector2((float)39.322918, (float)-97.42786));
            track.Add(new Vector2((float)40.625008, (float)-80.58841));
            track.Add(new Vector2((float)47.39585, (float)-74.27365));
            track.Add(new Vector2((float)99.99998, (float)-73.07086));
            track.Add(new Vector2((float)108.33335, (float)-77.88211));
            track.Add(new Vector2((float)108.59376, (float)-101.637665));
            track.Add(new Vector2((float)150.10017, (float)-102.539825));
            track.Add(new Vector2((float)149.21875, (float)-114.86859));
            track.Add(new Vector2((float)96.6146, (float)-114.5679));
            track.Add(new Vector2((float)94.27085, (float)-98.329895));
            track.Add(new Vector2((float)85.41668, (float)-91.11307));
            track.Add(new Vector2((float)63.541676, (float)-91.71448));
            track.Add(new Vector2((float)59.375008, (float)-98.02927));
            track.Add(new Vector2((float)57.031258, (float)-113.6658));
            track.Add(new Vector2((float)-56.770832, (float)-114.86859));
            track.Add(new Vector2((float)-57.552086, (float)-100.735565));
            track.Add(new Vector2((float)-61.979164, (float)-92.01517));
            track.Add(new Vector2((float)-83.072914, (float)-92.31586));
            track.Add(new Vector2((float)-92.1875, (float)-98.931366));
            track.Add(new Vector2((float)-93.489586, (float)-114.5679));
            track.Add(new Vector2((float)-149.21875, (float)-114.86859));
            track.Add(new Vector2((float)-148.4375, (float)-104.945435));
            track.Add(new Vector2((float)-101.30208, (float)-105.246155));
            track.Add(new Vector2((float)-101.04167, (float)-87.8053));
            track.Add(new Vector2((float)-96.09375, (float)-80.28772));
            track.Add(new Vector2((float)-55.72918, (float)-78.18283));
            track.Add(new Vector2((float)-47.395832, (float)-85.39972));
            track.Add(new Vector2((float)-43.75001, (float)-101.637665));
            track.Add(new Vector2((float)-15.104162, (float)-100.134155));
            track.Add(new Vector2((float)-15.364588, (float)-31.874512));
            track.Add(new Vector2((float)-38.281246, (float)-33.07733));
            track.Add(new Vector2((float)-40.624996, (float)37.88864));
            track.Add(new Vector2((float)-18.75, (float)38.18936));
            track.Add(new Vector2((float)-19.270832, (float)99.83353));
            track.Add(new Vector2((float)-38.281246, (float)100.13422));
            track.Add(new Vector2((float)-40.624996, (float)82.69345));
            track.Add(new Vector2((float)-48.177086, (float)76.07794));
            track.Add(new Vector2((float)-100.78125, (float)75.47656));
            track.Add(new Vector2((float)-105.98958, (float)82.99414));
            track.Add(new Vector2((float)-108.33333, (float)102.840546));
            track.Add(new Vector2((float)-148.95833, (float)103.742676));
            track.Add(new Vector2((float)-149.47917, (float)115.47009));
            track.Add(new Vector2((float)-90.62499, (float)115.47009));
            track.Add(new Vector2((float)-91.40625, (float)104.945465));
            track.Add(new Vector2((float)-86.979164, (float)97.42789));
            track.Add(new Vector2((float)-65.10418, (float)95.62366));
            track.Add(new Vector2((float)-58.07293, (float)103.742676));
            track.Add(new Vector2((float)-57.291664, (float)115.47009));
            track.Add(new Vector2((float)57.29168, (float)115.47009));
            track.Add(new Vector2((float)57.552086, (float)101.63776));
            track.Add(new Vector2((float)65.10417, (float)95.92435));
            track.Add(new Vector2((float)84.11458, (float)96.2251));
            track.Add(new Vector2((float)93.22917, (float)102.239136));
            track.Add(new Vector2((float)92.96873, (float)115.47009));
            track.Add(new Vector2((float)150.10017, (float)115.47009));

            var land = new List<Vector2>();

            land.Add(new Vector2((float)-24.479162, (float)-13.832306));
            land.Add(new Vector2((float)-23.958332, (float)15.335907));
            land.Add(new Vector2((float)24.479181, (float)17.140137));
            land.Add(new Vector2((float)24.999977, (float)-13.531616));



            newAreas.Add(new AreaModel("land0", new Polygon(mainLand), Main.Empty(), 10, AreaType.land));

            newAreas.Add(new AreaModel("track", new Polygon(track), Main.Empty(), 10, AreaType.track));

            newAreas.Add(new AreaModel("land1", new Polygon(land), Main.Empty(), 10, AreaType.land));

            newAreas.Add(new AreaModel("water1", new Polygon(water1), Main.Empty(), 10, AreaType.water));
            newAreas.Add(new AreaModel("water2", new Polygon(water2), Main.Empty(), 10, AreaType.water));

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