using System;

namespace DistanceBetweenPointsCalculator
{
    public static class DisplayDistances
    {
        public static void DisplayDistancesBetweenPoints(Point3D firstPoint, Point3D secondPoint)
        {
            Display1DDistances(firstPoint, secondPoint);
            Display2DDistance(firstPoint, secondPoint);
            Display3DDistance(firstPoint, secondPoint);
        }

        private static void Display1DDistances(Point3D firstPoint, Point3D secondPoint)
        {
            Distance1DBetweenPoints distance1D = new Distance1DBetweenPoints();
            Console.WriteLine("X distance: " + distance1D.CalculateDistance(firstPoint.x, secondPoint.x));
            Console.WriteLine("Y distance: " + distance1D.CalculateDistance(firstPoint.y, secondPoint.y));
            Console.WriteLine("Z distance: " + distance1D.CalculateDistance(firstPoint.z, secondPoint.z));
        }

        private static void Display2DDistance(Point3D firstPoint, Point3D secondPoint)
        {
            Distance2DBetweenPoints distance2D = new Distance2DBetweenPoints(firstPoint, secondPoint);
            Console.WriteLine("XY distance: " + distance2D.CalculateDistance());
        }

        private static void Display3DDistance(Point3D firstPoint, Point3D secondPoint)
        {
            Distance3DBetweenPoints distance3D = new Distance3DBetweenPoints(firstPoint, secondPoint);
            Console.WriteLine("distance between points: " + distance3D.CalculateDistance());
        }
    }
}
