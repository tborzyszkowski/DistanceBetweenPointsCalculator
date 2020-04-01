using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPointsCalculator
{
	public interface Point
	{
		double distance(Point point);
	}
}
