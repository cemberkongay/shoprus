using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace ShopsRUs.Tests.ApiTest
{
    public class InvoiceControllerTest : InvoiceControllerTestBase
    {
        [Fact]
        public void InvoiceApi_GetInvoiceTotal_Return_Ok()
        {
            //Arrange
            var fakeRequest = FakeRequestData(1);

            //Act
            var okResult = _controller.GetAsyncInvoiceTotal(fakeRequest);

            //Assert
            Assert.IsType<OkObjectResult>(okResult);
        }
    }
}
