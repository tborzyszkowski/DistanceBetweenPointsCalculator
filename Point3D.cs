using System;

namespace DistanceBetweenPointsCalculator
{
	public class Point3D : Point
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }

		public Point3D(int x, int y, int z) 
		{
			X = x;
			Y = y; 
			Z = z;
		}
		public double distance(Point point)
		{
			var point3d = (point as Point3D);
			if (point3d != null)
				return Math.Sqrt(
					(X - point3d.X) * (X - point3d.X) + 
					(Y - point3d.Y) * (Y - point3d.Y) + 
					(Z - point3d.Z) * (Z - point3d.Z)
				);
			else
				throw new ArgumentException();
		}
		public override string ToString()
		{
			return $"X: {X}, Y: {Y}, Z: {Z}";
		}
	}
}
