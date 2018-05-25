using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uml2
{
	public class Customer : ICustomer
	{
		public Customer()
		{

		}

		public Account Account
		{
			get => default(Account);
			set
			{
			}
		}

		public int Name
		{
			get => default(int);
			set
			{
			}
		}

		public Account CreateAccount()
		{
			throw new System.NotImplementedException();
		}

		public void GetBalance()
		{
			throw new System.NotImplementedException();
		}

		public void WithDraw()
		{
			throw new System.NotImplementedException();
		}

		public void Deposit()
		{
			throw new System.NotImplementedException();
		}

		private Account[] accounts;
	}
}