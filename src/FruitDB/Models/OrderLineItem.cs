﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitDB.Models
{
    public class OrderLineItem : LineItem
    {
		public double Quantity { get; set; }
	}
}
