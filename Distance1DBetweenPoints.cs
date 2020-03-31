using System;

namespace DistanceBetweenPointsCalculator
{
    public class Distance1DBetweenPoints
    {
        public int CalculateDistance(int firstCoordinate, int secondCoordinate)
            => Math.Abs(firstCoordinate - secondCoordinate);
    }
}
