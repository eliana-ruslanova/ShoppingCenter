﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenter.Data
{
    class DiscountItem : Item
    {
        public int Discount { get; set; }

        public override decimal FinalPrice()
        {
            return Price * (1 - Discount/100);
        }
    }
}
