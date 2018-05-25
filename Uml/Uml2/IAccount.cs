using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uml2
{
	public interface IAccount
	{
		void Deposit();
		void GetBalance();
		void WithDraw();
	}
}