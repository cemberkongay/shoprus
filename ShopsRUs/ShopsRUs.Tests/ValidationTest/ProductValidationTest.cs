using ShopsRUs.Api.Validations;
using ShopsRUs.Application.Models;
using ShopsRUs.Application.Models.ValidationMessages;
using System;
using System.Collections.Generic;
using Xunit;

namespace ShopsRUs.Tests.ValidationTest
{
    public class ProductValidationTest
    {
        [Fact]
        public void ProductValidation_Returns_ProductCannotBeNull_ErrorMessage()
        {
            //Act
            ValidationMessage validationMessage = Validation.ProductValidation(null);

            //Assert
            Assert.Equal((int)MessageCode.Error, validationMessage.Code);
            Assert.Equal("Products cannot be null.", validationMessage.Message);
        }

        [Fact]
        public void ProductValidation_Returns_ProductIdRequired_ErrorMessage()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Laptop",
                Price = 2500,
                Type = (int)ProductType.Electronics
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Parfume",
                Price = 25,
                Type = (int)ProductType.Cosmetic
            });
            products.Add(new Product()
            {
                Id = 0,
                Name = "Shirt",
                Price = 50,
                Type = (int)ProductType.Clothing
            });

            //Act
            ValidationMessage validationMessage = Validation.ProductValidation(products);

            //Assert
            Assert.Equal((int)MessageCode.Error, validationMessage.Code);
            Assert.Equal("Product Id required.", validationMessage.Message);
        }

        [Fact]
        public void ProductValidation_Returns_ProductPriceCannotBeLessThenZero_ErrorMessage()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Laptop",
                Price = 2500,
                Type = (int)ProductType.Electronics
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Parfume",
                Price = -1,
                Type = (int)ProductType.Cosmetic
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Shirt",
                Price = 50,
                Type = (int)ProductType.Clothing
            });

            //Act
            ValidationMessage validationMessage = Validation.ProductValidation(products);

            //Assert
            Assert.Equal((int)MessageCode.Error, validationMessage.Code);
            Assert.Equal("Product price cannot be less than 0.", validationMessage.Message);
        }

        [Fact]
        public void ProductValidation_Returns_ProductTypeRequired_ErrorMessage()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Laptop",
                Price = 2500,
                Type = (int)ProductType.Electronics
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Parfume",
                Price = 0,
                Type = (int)ProductType.Cosmetic
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Shirt",
                Price = 50,
                Type = (int)ProductType.Clothing
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Water",
                Price = 2,                
            });
            //Act
            ValidationMessage validationMessage = Validation.ProductValidation(products);

            //Assert
            Assert.Equal((int)MessageCode.Error, validationMessage.Code);
            Assert.Equal("Product type required.", validationMessage.Message);
        }

        [Fact]
        public void ProductValidation_Returns_SuccessMessage()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Laptop",
                Price = 2500,
                Type = (int)ProductType.Electronics
            });
            
            //Act
            ValidationMessage validationMessage = Validation.ProductValidation(products);

            //Assert
            Assert.Equal((int)MessageCode.Success, validationMessage.Code);
            Assert.Equal("", validationMessage.Message);
        }
    }
}
