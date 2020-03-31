using System;

namespace DistanceBetweenPointsCalculator
{
    public static class DisplayCoordinates
    {
        public static void DisplayPointCoordinates(Point3D point)
        {
            Console.WriteLine("X: " + point.x);
            Console.WriteLine("Y: " + point.y);
            Console.WriteLine("Z: " + point.z);
        }
    }
}
