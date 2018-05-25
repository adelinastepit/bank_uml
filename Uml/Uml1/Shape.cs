using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinDBCodeFirst
{
	public abstract class Shape
	{
		protected double x;
		protected double y;

		public Shape(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public abstract double Area();

		public abstract double Perimeter();
	}
}