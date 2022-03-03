using ShopsRUs.Application.Models;
using ShopsRUs.Application.Models.Invoices;
using System;

namespace ShopsRUs.Application.Helpers
{
    public class InvoiceHelper : IInvoiceHelper
    {
        public InvoiceResponse InvoiceCalculation(InvoiceRequest request)
        {
            double discountPercentageValue = GetDiscountPercentageValue(request.Customer);
            decimal subtotal = 0;
            decimal grandtotal = 0;

            foreach (var product in request.Products)
            {
                if(product.Type != (int)ProductType.Groceries)
                {
                    grandtotal +=  product.Price * (decimal)discountPercentageValue;
                }
                else
                {
                    grandtotal += product.Price;
                }
                subtotal += product.Price; 
            }

            grandtotal -= (grandtotal / 100) >= 1 ? (Convert.ToInt32(Math.Floor(grandtotal / 100)) * 5) : 0;

            decimal discount = subtotal - grandtotal;

            var result = new InvoiceResponse
            {
                SubTotal = subtotal,
                Discount = discount,
                GrandTotal = grandtotal
            };

            return result;
        }

        private static double GetDiscountPercentageValue(Customer customer)
        {
            int customerType = customer.Type;
            bool isOverTwoYears = customer.CreatedOn.HasValue && (DateTime.Now > customer.CreatedOn.Value.AddYears(2));            
            double discountPercentageValue = 1;

            switch (customerType)
            {
                case (int)CustomerType.EmployeeOfStore:
                    discountPercentageValue = 1 - 0.30;
                    break;
                case (int)CustomerType.AffilateOfStore:
                    discountPercentageValue = 1 - 0.10;
                    break;
                case ((int)CustomerType.StandartCustomer):
                    if (isOverTwoYears)
                        discountPercentageValue = 1 - 0.05;
                    break;
                default:
                    break;
            }

            return discountPercentageValue;
        }
    }
}
