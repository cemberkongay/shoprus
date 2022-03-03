using System.Collections.Generic;

namespace ShopsRUs.Application.Models.Invoices
{
    public class InvoiceRequest
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
    }
}
