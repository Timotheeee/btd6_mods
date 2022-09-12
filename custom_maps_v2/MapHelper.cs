using Assets.Scripts.Models.Map;
using Assets.Scripts.Simulation.SMath;

namespace custommaps
{
    public static class MapHelper
    {
        private static System.Random random = new System.Random();

        public static PointInfo AddPoint(double x, double y)
        {
            return new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = random.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Vector3((float)x, (float)y), bloonSpeedMultiplier = 1 };
        }
    }
}
