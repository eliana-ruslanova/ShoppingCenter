using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenter.Data
{
    public class Journal 
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Employee Employee { get; set; }
        public List<Item> Items { get; set; }
        public decimal TotalCost { get; set; }

    }
}
