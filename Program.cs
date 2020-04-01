using System;

namespace DistanceBetweenPointsCalculator
{
	static class Program
	{
		static public void Main()
		{
			// 3D points
			var first3DPoint = new Point3D(-20, -20, -20);
			Console.WriteLine(first3DPoint);
			var second3DPoint = new Point3D(10, 10, 10);
			Console.WriteLine(second3DPoint);
			Console.WriteLine(first3DPoint.distance(second3DPoint));

			// 2D points
			var first2DPoint = new Point2D(-20, -20);
			Console.WriteLine(first2DPoint);
			var second2DPoint = new Point2D(10, 10);
			Console.WriteLine(second2DPoint);
			Console.WriteLine(first2DPoint.distance(second2DPoint));

			// mixed points
			try
			{
				Console.WriteLine(first2DPoint.distance(second3DPoint));
			}
			catch(ArgumentException e)
			{
				Console.WriteLine($"Some exception: {e}");
			}
		}
	}
}
