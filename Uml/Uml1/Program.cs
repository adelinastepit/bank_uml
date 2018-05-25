using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BitcoinDBCodeFirst
{
    class Program
    {
        

        static void Main(string[] sargs)
        {
			Circle circle = new Circle(1,1,2);
			Console.WriteLine("area circle " +circle.Area());

			Square square = new Square(1, 1, 1, 1);
			Console.WriteLine("area square " + square.Area());
		}
    }
}
