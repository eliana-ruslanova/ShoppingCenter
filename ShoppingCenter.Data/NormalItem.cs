using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenter.Data
{
    class NormalItem : Item
    {
        public override decimal TotalPrice()
        {
            return Price;
        }
    }
}
