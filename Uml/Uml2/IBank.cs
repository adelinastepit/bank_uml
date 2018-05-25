using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uml2
{
	public interface IBank
	{
		List<IAccount> GetAccounts();
		void AddAccount(Account account);
		Account FindAccount(string IBAN);
	}
}