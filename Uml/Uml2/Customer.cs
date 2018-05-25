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
			return new Account();
		}

		private List<IAccount> accounts;
	}
}