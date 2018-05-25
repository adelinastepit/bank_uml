using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinDBCodeFirst
{
	public class Circle : Shape
	{
		private double radius;

		public Circle(double x, double y, double radius):
			base(x,y)
		{
			this.radius = radius;
		}

		public override double Area()
		{
			return Math.PI * radius * radius;
		}

		public override double Perimeter()
		{
			return 2 * Math.PI * radius;
		}

	}
}