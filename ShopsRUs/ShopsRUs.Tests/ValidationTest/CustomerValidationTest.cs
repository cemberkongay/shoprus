using ShopsRUs.Api.Validations;
using ShopsRUs.Application.Models;
using ShopsRUs.Application.Models.ValidationMessages;
using System;
using Xunit;

namespace ShopsRUs.Tests.ValidationTest
{
    public class CustomerValidationTest
    {
        [Fact]
        public void CustomerValidation_Returns_CustomerCannotBeNullMessage_Error()
        {
            //Act
            ValidationMessage validationMessage = Validation.CustomerValidation(null);

            //Assert
            Assert.Equal((int)MessageCode.Error, validationMessage.Code);
            Assert.Equal("Customer cannot be null.", validationMessage.Message);
        }

        [Fact]
        public void CustomerValidation_Returns_CustomerTypeRequiredMessage_Error()
        {
            //Act
            ValidationMessage validationMessage = Validation.CustomerValidation(new Customer { Type = 0});

            //Assert
            Assert.Equal((int)MessageCode.Error, validationMessage.Code);
            Assert.Equal("Customer Type required.", validationMessage.Message);
        }

        [Fact]
        public void CustomerValidation_Returns_IfTheEmployeeIsIdRequiredMessage_Error()
        {
            //Act
            ValidationMessage validationMessage = Validation.CustomerValidation(new Customer { Id = 0, Type = 1 });

            //Assert
            Assert.Equal((int)MessageCode.Error, validationMessage.Code);
            Assert.Equal("Customer Id required.", validationMessage.Message);
        }

        [Fact]
        public void CustomerValidation_Returns_SuccessMessage()
        {
            //Act
            ValidationMessage validationMessage = Validation.CustomerValidation(new Customer { Id = 1, Type = 2 });

            //Assert
            Assert.Equal((int)MessageCode.Success, validationMessage.Code);
            Assert.Equal("", validationMessage.Message);
        }
    }
}
