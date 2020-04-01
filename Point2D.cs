using System;

namespace DistanceBetweenPointsCalculator
{
	public class Point2D : Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Point2D(int x, int y)
		{
			X = x;
			Y = y;
		}

		public double distance(Point point)
		{
			var point2d = (point as Point2D);
			if (point2d != null)
				return Math.Sqrt((X - point2d.X) * (X - point2d.X) + (Y - point2d.Y) * (Y - point2d.Y));
			else
				throw new ArgumentException();
		}

		public override string ToString()
		{
			return $"X: {X}, Y: {Y}";
		}
	}
}
