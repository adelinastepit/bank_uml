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

		public double Amount
		{
			get => default(double);
			set
			{
			}
		}

		public string IBAN
		{
			get => default(string);
			set
			{
			}
		}

		public void Deposit()
		{
			throw new System.NotImplementedException();
		}

		public double GetBalance()
		{
			return Amount;
		}

		public void WithDraw(double amount)
		{
			throw new System.NotImplementedException();
		}
	}
}