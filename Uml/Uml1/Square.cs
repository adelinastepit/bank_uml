using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinDBCodeFirst
{
	public class Square : Shape
	{
		private int w;
		private int h;

		public Square(double x, double y, int w, int h)
			:base(x,y)
		{
			this.w = w;
			this.h = h;
		}

		public override double Area()
		{
			return w * h;
		}

		public override double Perimeter()
		{
			return 2*(w + h);
		}
	}
}