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

		// de facut getAccount care sa genereze IBAN-uri random 
			double deposit = 356.8;
			account.Deposit(deposit);

			Console.WriteLine(account.GetBalance());

			double sum = 2.0;
			account.WithDraw(sum);

			Console.WriteLine(account.GetBalance());

			double deposit2 = 12.2;
			account.Deposit(deposit2);
			Console.WriteLine(account.GetBalance());

			Bank bank = new Bank();
			bank.Name = "EBRD";
			bank.AddAccount(account);
			var foundAccount = bank.FindAccount(account.getIBAN());
			Console.WriteLine("balance " + foundAccount.GetBalance());
		


		}
	}
}
