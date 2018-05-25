using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uml2
{
	public class Account : IAccount
	{
		public Account()
		{
			this.Amount = 0.0;
			this.IBAN = "";

		}

		private double Amount;


		private string IBAN;
		

	

		public void Deposit()
		{
			throw new System.NotImplementedException();
		}

		public double GetBalance()
		{
			return Amount;
		}

		public int WithDraw(double withDrawAmount)
		{  if (Amount < withDrawAmount )
			{
				 Console.WriteLine("The sum is not available");
				return -1;
			}
			Amount = Amount - withDrawAmount;
			return 0;
		}
	}
}