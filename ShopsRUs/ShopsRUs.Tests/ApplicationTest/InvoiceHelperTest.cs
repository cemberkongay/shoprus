using ShopsRUs.Application.Helpers;
using ShopsRUs.Application.Models.Invoices;
using System;
using Xunit;
using System.Collections.Generic;
using ShopsRUs.Application.Models;

namespace ShopsRUs.Tests.ApplicationTest
{
    public class InvoiceHelperTest : InvoiceHelperTestBase
    {
        [Fact]
        public void InvoiceHelper_Returns_CalculationSuccessCustomerType_1()
        {
            //Arrange
            int customerType = 1;
            var fakeRequest = FakeRequestData(customerType);

            //Act
            var result = _invoiceHelper.InvoiceCalculation(fakeRequest);

            //Assert
            Assert.Equal(2610.00M, result.SubTotal);
            Assert.Equal(871.50M, result.Discount);
            Assert.Equal(1738.50M, result.GrandTotal);
        }

        [Fact]
        public void InvoiceHelper_Returns_CalculationSuccessCustomerType_2()
        {
            //Arrange
            int customerType = 2;
            var fakeRequest = FakeRequestData(customerType);

            //Act
            var result = _invoiceHelper.InvoiceCalculation(fakeRequest);

            //Assert
            Assert.Equal(2610.00M, result.SubTotal);
            Assert.Equal(375.50M, result.Discount);
            Assert.Equal(2234.50M, result.GrandTotal);
        }

        [Fact]
        public void InvoiceHelper_Returns_CalculationSuccessCustomerType_3_And_OverTwoYearsMember()
        {
            //Arrange
            int customerType = 3;
            DateTime createOn = new(2019, 01, 02);
            var fakeRequest = FakeRequestData(customerType, createOn);

            //Act
            var result = _invoiceHelper.InvoiceCalculation(fakeRequest);

            //Assert
            Assert.Equal(2610.00M, result.SubTotal);
            Assert.Equal(250.25M, result.Discount);
            Assert.Equal(2359.75M, result.GrandTotal);
        }

        [Fact]
        public void InvoiceHelper_Returns_CalculationSuccessCustomerType_3_And_LessThanTwoYearsMember()
        {
            //Arrange
            int customerType = 3;
            DateTime createOn = new(2022, 01, 02);
            var fakeRequest = FakeRequestData(customerType, createOn);

            //Act
            var result = _invoiceHelper.InvoiceCalculation(fakeRequest);

            //Assert
            Assert.Equal(2610.00M, result.SubTotal);
            Assert.Equal(130.00M, result.Discount);
            Assert.Equal(2480.00M, result.GrandTotal);
        }
    }
}
