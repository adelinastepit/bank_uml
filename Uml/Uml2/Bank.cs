using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uml2
{
	public class Bank : IBank
	{
		public Bank()
		{
			mAccountList = new List<IAccount>();
			this.Name = "";

		}

		public string Name
		{
			get => default(string);
			set
			{
			}
		}

		public List<IAccount> GetAccounts()
		{
			return mAccountList;
		}

		public Account FindAccount(string IBAN)
		{
			foreach (Account account in mAccountList)
			{
				if (IBAN == account.getIBAN())
				{
					return account;
				}
			}
			return null;
		}

		public void AddAccount(Account account)
		{
			mAccountList.Add(account);
		}

		private List<IAccount> mAccountList;
	}
}