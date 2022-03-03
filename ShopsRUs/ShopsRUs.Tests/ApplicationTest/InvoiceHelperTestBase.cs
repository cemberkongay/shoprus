﻿using ShopsRUs.Application.Helpers;
using ShopsRUs.Application.Models;
using ShopsRUs.Application.Models.Invoices;
using System;
using System.Collections.Generic;

namespace ShopsRUs.Tests.ApplicationTest
{
    public class InvoiceHelperTestBase
    {
        protected readonly InvoiceHelper _invoiceHelper = new();

        public InvoiceRequest FakeRequestData(int customerType)
        {
            Customer customer = new()
            {
                Id = 1,
                Name = "John",
                Lastname = "Doe",
                Type = customerType,
                CreatedOn = new DateTime(2018, 03, 01)
            };

            List<Product> products = new();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Laptop",
                Price = 2490.00M,
                Type = (int)ProductType.Electronics
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Parfume",
                Price = 45.00M,
                Type = (int)ProductType.Cosmetic
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Shirt",
                Price = 70.00M,
                Type = (int)ProductType.Clothing
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Water",
                Price = 5.00M,
                Type = (int)ProductType.Groceries
            });

            InvoiceRequest request = new();
            request.Customer = customer;
            request.Products = products;

            return request;
        }

        public InvoiceRequest FakeRequestData(int customerType, DateTime createOn)
        {
            Customer customer = new()
            {
                Id = 1,
                Name = "John",
                Lastname = "Doe",
                Type = customerType,
                CreatedOn = createOn
            };

            List<Product> products = new();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Laptop",
                Price = 2490.00M,
                Type = (int)ProductType.Electronics
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Parfume",
                Price = 45.00M,
                Type = (int)ProductType.Cosmetic
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Shirt",
                Price = 70.00M,
                Type = (int)ProductType.Clothing
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Water",
                Price = 5.00M,
                Type = (int)ProductType.Groceries
            });

            InvoiceRequest request = new();
            request.Customer = customer;
            request.Products = products;

            return request;
        }
    }
}