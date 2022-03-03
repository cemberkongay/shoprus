using ShopsRUs.Application.Models;
using ShopsRUs.Application.Models.ValidationMessages;

namespace ShopsRUs.Api.Validations
{
    public partial class Validation
    {
        public static ValidationMessage CustomerValidation(Customer customer)
        {
            var message = new ValidationMessage()
            {
                Code = (int)MessageCode.Success,
                Message = ""
            };

            if (customer == null)
            {
                message.Code = (int)MessageCode.Error;
                message.Message = "Customer cannot be null.";
                return message;
            }

            else if (customer.Type < 1)
            {
                message.Code = (int)MessageCode.Error;
                message.Message = "Customer Type required.";
                return message;
            }

            else if (customer.Id < 1 && (customer.Type == (int)CustomerType.EmployeeOfStore || customer.Type == (int)CustomerType.AffilateOfStore))
            {
                message.Code = (int)MessageCode.Error;
                message.Message = "Customer Id required.";
                return message;
            }

            return message;
        }
    }
}
