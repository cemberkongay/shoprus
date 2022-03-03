using ShopsRUs.Application.Models.ValidationMessages;

namespace ShopsRUs.Application.Models.Invoices
{
    public class InvoiceResponse
    {
        public ValidationMessage Message { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Discount { get; set; }
        public decimal? GrandTotal { get; set; }
    }
}
