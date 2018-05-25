using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer = new Customer();

			Account account = customer.CreateAccount();
			Console.WriteLine(account.GetBalance());
			account.WithDraw(2.0);
		}
	}
}
