using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenter.Data
{
    public class GiftItem : Item
    {
        public override decimal FinalPrice()
        {
            return 0;
        }
    }
}
