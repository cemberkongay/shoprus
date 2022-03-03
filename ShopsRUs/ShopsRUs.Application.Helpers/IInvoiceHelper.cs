using ShopsRUs.Application.Models.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Application.Helpers
{
    public interface IInvoiceHelper
    {
        public InvoiceResponse InvoiceCalculation(InvoiceRequest request);
    }
}
