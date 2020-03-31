using System;

namespace DistanceBetweenPointsCalculator
{
    public class Distance2DBetweenPoints: Distance1DBetweenPoints
    {
        private readonly double xDistance;
        private readonly double yDistance;
        protected double squareXDistance;
        protected double squareYDistance;

        public Distance2DBetweenPoints(Point3D firstPoint, Point3D secondPoint)
        {
            this.xDistance = base.CalculateDistance(firstPoint.x, secondPoint.x);
            this.yDistance = base.CalculateDistance(firstPoint.y, secondPoint.y);
            this.squareXDistance = SquareRootDistance(this.xDistance);
            this.squareYDistance = SquareRootDistance(this.yDistance);
        }

        protected double SquareRootDistance(double distance) => Math.Pow(distance, 2);

        public double CalculateDistance() 
            => Math.Sqrt(this.squareXDistance + this.squareYDistance);
    }
}
