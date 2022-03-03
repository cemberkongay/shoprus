using System;

namespace ShopsRUs.Application.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Type { get; set; } // 1: Employee of store 2: Affillate of the store 3: Standart Customer
        public DateTime? CreatedOn { get; set; }
    }
}
