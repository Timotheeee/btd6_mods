using Il2CppAssets.Scripts.Models.Map;
using Il2CppAssets.Scripts.Models.Map.Spawners;
using Il2CppAssets.Scripts.Simulation.SMath;
using Il2CppSystem.Collections.Generic;
using Il2CppInterop.Runtime; using Il2CppInterop.Runtime.InteropTypes; using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace custommaps.Maps.BTDBattles2
{
    class Other
    {
        public static Il2CppReferenceArray<PointInfo> mainTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint((float)-149.9, (float)79.1));
            list.Add(MapHelper.AddPoint((float)150.1, (float)79.7));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<PointInfo> secondTrack()
        {
            List<PointInfo> list = new List<PointInfo>();

            list.Add(MapHelper.AddPoint((float)-149.7, (float)54.7));
            list.Add(MapHelper.AddPoint((float)98.7, (float)52.9));
            list.Add(MapHelper.AddPoint((float)105.5, (float)51.1));
            list.Add(MapHelper.AddPoint((float)108.9, (float)44.8));
            list.Add(MapHelper.AddPoint((float)109.1, (float)-43.0));
            list.Add(MapHelper.AddPoint((float)109.6, (float)-48.4));
            list.Add(MapHelper.AddPoint((float)99.7, (float)-53.8));
            list.Add(MapHelper.AddPoint((float)-149.9, (float)-53.2));

            return (Il2CppReferenceArray<PointInfo>)list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newAreas = new List<AreaModel>();

            var mainLand = new Il2CppSystem.Collections.Generic.List<Il2CppAssets.Scripts.Simulation.SMath.Vector2>();

            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, -115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(150.1f, 115.5f));
            mainLand.Add(new Il2CppAssets.Scripts.Simulation.SMath.Vector2(-149.9f, 115.5f));


            //newAreas.Add(new AreaModel("land0", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(mainLand), 10, AreaType.land));
            //newAreas.Add(new AreaModel("bush2", new Il2CppAssets.Scripts.Simulation.SMath.Polygon(bushRight), 100, AreaType.unplaceable, 0f, null, null, null, true, false, default));

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
                        "MainPath",
                        "SecondPath"
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