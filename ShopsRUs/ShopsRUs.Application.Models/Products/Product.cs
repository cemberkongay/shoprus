using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Application.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; } // 1: Groceries, 2: Electronics, 3: Clothing, 4: Cosmetic ...etc.
        public decimal Price { get; set; }
    }
}
