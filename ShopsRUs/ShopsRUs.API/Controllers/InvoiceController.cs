using Microsoft.AspNetCore.Mvc;
using ShopsRUs.Api.Validations;
using ShopsRUs.Application.Helpers;
using ShopsRUs.Application.Models.Invoices;
using ShopsRUs.Application.Models.ValidationMessages;

namespace ShopsRUs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceHelper _invoiceHelper;
        public InvoiceController(IInvoiceHelper invoiceHelper)
        {
            _invoiceHelper = invoiceHelper;
        }

        [HttpPost("GetInvoiceTotal")]
        public IActionResult GetAsyncInvoiceTotal([FromBody]InvoiceRequest request)
        {
            var validation = Validation.IsValid(request);

            if (validation.Code != (int)MessageCode.Success)
            {
                return BadRequest(new InvoiceResponse()
                {
                    Message = validation
                });
            }

            var result = _invoiceHelper.InvoiceCalculation(request);
            result.Message = new ValidationMessage()
            {
                Code = (int)MessageCode.Success,
                Message = "Success"
            };

            return Ok(result);
        }
    }
}
