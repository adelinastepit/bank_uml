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
			throw new System.NotImplementedException();
		}

		public int Name
		{
			get => default(int);
			set
			{
			}
		}

		private List<IAccount> GetAccounts()
		{
			return mAccountList;
		}

		private List<IAccount> mAccountList;
	}
}