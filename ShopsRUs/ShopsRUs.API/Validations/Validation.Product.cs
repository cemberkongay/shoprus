using ShopsRUs.Application.Models;
using ShopsRUs.Application.Models.ValidationMessages;
using System.Collections.Generic;
using System.Linq;

namespace ShopsRUs.Api.Validations
{
    public partial class Validation
    {
        public static ValidationMessage ProductValidation(List<Product> products)
        {
            var message = new ValidationMessage()
            {
                Code = (int)MessageCode.Success,
                Message = ""
            };

            if (products == null)
            {
                message.Code = (int)MessageCode.Error;
                message.Message = "Products cannot be null.";
                return message;
            }

            else if (products.Count > 0)
            {
                if (products.Where(x => x.Id < 1).ToList().Count > 0)
                {
                    message.Code = (int)MessageCode.Error;
                    message.Message = "Product Id required.";
                    return message;
                }

                if (products.Where(x => x.Price <= -1).ToList().Count > 0)
                {
                    message.Code = (int)MessageCode.Error;
                    message.Message = "Product price cannot be less than 0.";
                    return message;
                }

                if (products.Where(x => x.Type < 1).ToList().Count > 0)
                {
                    message.Code = (int)MessageCode.Error;
                    message.Message = "Product type required.";
                    return message;
                }
            }

            return message;
        }
    }
}
