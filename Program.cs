namespace DistanceBetweenPointsCalculator
{
    static class Program
    {
        static public void Main()
        {
            Point3D firstPoint = new Point3D(-20, -20, -20);
            DisplayCoordinates.DisplayPointCoordinates(firstPoint);
            Point3D secondPoint = new Point3D(10, 10, 10);
            DisplayCoordinates.DisplayPointCoordinates(secondPoint);
            DisplayDistances.DisplayDistancesBetweenPoints(firstPoint, secondPoint);
        }
    }
}
