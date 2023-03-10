using Il2CppAssets.Scripts.Models.Map;

namespace custommaps
{
    public static class MapHelper
    {
        private static System.Random random = new System.Random();

        public static PointInfo AddPoint(double x, double y)
        {
            return new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = random.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3((float)x, (float)y), bloonSpeedMultiplier = 1 };
        }

        public static PointInfo AddInvulnerablePoint(double x, double y)
        {
            return new PointInfo() { bloonScale = 1, bloonsInvulnerable = true, distance = 1, id = random.NextDouble() + "", moabScale = 1, moabsInvulnerable = true, rotation = 0, point = new Il2CppAssets.Scripts.Simulation.SMath.Vector3((float)x, (float)y), bloonSpeedMultiplier = 10 };
        }
    }
}


//public override void OnUpdate()
//{
//    base.OnUpdate();

//    bool inAGame = InGame.instance != null && InGame.instance.bridge != null;

//    bool flag = inAGame && Input.GetKeyDown(KeyCode.Mouse1);
//    bool flag2 = inAGame && Input.GetKeyDown(KeyCode.F1);

//    if (flag)
//    {
//        InputManager inputManager = InGame.instance.inputManager;
//        if (inputManager != null)
//        {
//            //MelonLogger.Msg("list.Add(MapHelper.AddPoint" + inputManager.cursorPositionWorld.ToString() + ");");

//            MelonLogger.Msg($"list.Add(MapHelper.AddPoint({inputManager.cursorPositionWorld.x.ToString().Replace(',', '.')}, {inputManager.cursorPositionWorld.y.ToString().Replace(',', '.')}));");
//        }
//    }

//    if (flag2)
//    {
//        MelonLogger.Msg("BTD_Battles_2_MapBTD_Battles_2_MapBTD_Battles_2_MapBTD_Battles_2_MapBTD_Battles_2_Map");
//    }

//}