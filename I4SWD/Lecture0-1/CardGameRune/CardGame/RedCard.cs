﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
	public class RedCard : ICard
	{
		private int _multiplier = 1;
		private int _number;
		private string _suit = "Red";
		public RedCard(int number)
		{
			_number = number;
		}

		public string Suit
		{
			get { return _suit; }
		}

		public int Number
		{
			get { return _number; }
		}

		public int Value
		{
			get { return _multiplier * Number; }
		}
	}
}
