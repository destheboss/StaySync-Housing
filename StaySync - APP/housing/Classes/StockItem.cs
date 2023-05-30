using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housing.Classes
{
    internal class StockItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public int ListNumber { get; set; }
        public string Description { get; set; }

        public string GetInfo()
        {
            return $"{Name},{Amount},{ListNumber},{Description}";
        }

        public string GetLeft()
        {
            return $"{Amount} {Description} left.";
        }
    }
}
