﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uml2
{
	public class CheckingAccount : Account
	{
		public CheckingAccount()
		{
			throw new System.NotImplementedException();
		}

		public double Amount
		{
			get => default(int);
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
	}
}