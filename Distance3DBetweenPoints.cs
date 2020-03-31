using System;

namespace DistanceBetweenPointsCalculator
{
    public class Distance3DBetweenPoints : Distance2DBetweenPoints
    {
        private readonly double zDistance;
        private readonly double squareZDistance;

        public Distance3DBetweenPoints(Point3D firstPoint, Point3D secondPoint): base(firstPoint, secondPoint)
        {
            this.zDistance = base.CalculateDistance(firstPoint.z, secondPoint.z);
            this.squareZDistance = SquareRootDistance(this.zDistance);
        }

        public new double CalculateDistance()
            => Math.Sqrt(this.squareXDistance + this.squareYDistance + this.squareZDistance);
    }
}
