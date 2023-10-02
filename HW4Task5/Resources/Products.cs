using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4Task5.Resources
{
    public class Products : Goods
    {
        public DateTime ExpirationDate { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }
    }
}
