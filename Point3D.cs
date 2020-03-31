namespace DistanceBetweenPointsCalculator
{
    public class Point3D : Point
    {
        public readonly int z;

        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }
}
