using ShopsRUs.Application.Models;
using ShopsRUs.Application.Models.Invoices;
using ShopsRUs.Application.Models.ValidationMessages;

namespace ShopsRUs.Api.Validations
{
    public partial class Validation
    {
        public static ValidationMessage IsValid(InvoiceRequest request)
        {
            var messageBase = new ValidationMessage()
            {
                Code = (int)MessageCode.Success,
                Message = ""
            };

            if (CustomerValidation(request.Customer).Code != (int)MessageCode.Success)
            {
                messageBase = CustomerValidation(request.Customer);
                return messageBase;
            }

            if(ProductValidation(request.Products).Code != (int)MessageCode.Success)
            {
                messageBase = ProductValidation(request.Products);
                return messageBase;
            }

            return messageBase;
        }
    }
}