﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F18I4DABH2Gr30
{
	public class PhoneNumber
	{
		private string _phoneType;
		private uint _number;
		private string _provider;

        public PhoneNumber(uint number, string phoneType, string provider)
        {
            _phoneType = phoneType;
            _number = number;
            _provider = provider;
        }
	}
}
