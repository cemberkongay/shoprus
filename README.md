<h1 align="center">Welcome to ShopRUs 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-.Net 5.0 Sdk 3.1-blue.svg?cacheSeconds=2592000" />
</p>

> ShopsRUs is an existing retail outlet. They would like to provide discount to their customers
on all their web/mobile platforms. They require a set of APIs to be built that provide
capabilities to calculate discounts, generate the total costs and generate the invoices for
customers.

Upon request, a rest API example was introduced using .Net 5.0.


The following discounts apply:
1. If the user is an employee of the store, he gets a 30% discount
2. If the user is an affiliate of the store, he gets a 10% discount
3. If the user has been a customer for over 2 years, he gets a 5% discount.
4. For every $100 on the bill, there would be a $ 5 discount (e.g. for $ 990, you get $ 45
as a discount).
5. The percentage based discounts do not apply on groceries.
6. A user can get only one of the percentage based discounts on a bill.

The model structure can be viewed from the images below.

<img alt="Model Class Diagram" src="https://github.com/cemberkongay/shoprus/blob/main/ShopsRUs/ModelClassDiagram.png?raw=true" />
<img alt="Helper Class Diagram" src="https://github.com/cemberkongay/shoprus/blob/main/ShopsRUs/HelperClassDiagram.png" />

## Project Run

For project setup, simply download the repository and compile the code in your locale with the help of VS Code or Visual Studio.
After running the project, you can review the API with the help of the swagger.

## Run tests

The project has unit tests that test many cases. Without running the project, you can only run the tests and review existing cases.

## User tests
You can also use the following sample request models to test the API.

The Request models have two fields to consider. These are 
1. CustomerType 
2. ProductType

You can review model details from the enum classes in the diagram image.

```sh
{
  "customer": {
    "id": 1,
    "type": 1,
    "createdOn": "2018-03-01T12:35:57.312Z"
  },
  "products": [
    {
      "id": 1,
      "type": 1,
      "price": 100.00
    },{
      "id": 2,
      "type": 2,
      "price": 50.00
    },{
      "id": 3,
      "type": 2,
      "price": 120.00
    },{
      "id": 4,
      "type": 2,
      "price": 30.00
    },
  ]
}
```

```sh
{
  "customer": {
    "id": 1,
    "type": 2,
    "createdOn": "2018-03-01T12:35:57.312Z"
  },
  "products": [
    {
      "id": 1,
      "type": 1,
      "price": 100.00
    },{
      "id": 2,
      "type": 2,
      "price": 50.00
    },{
      "id": 3,
      "type": 2,
      "price": 120.00
    },{
      "id": 4,
      "type": 2,
      "price": 30.00
    },
  ]
}
```

```sh
{
  "customer": {
    "id": 1,
    "type": 3,
    "createdOn": "2018-03-01T12:35:57.312Z"
  },
  "products": [
    {
      "id": 1,
      "type": 2,
      "price": 2490.00
    },{
      "id": 2,
      "type": 2,
      "price": 45.00
    },{
      "id": 3,
      "type": 2,
      "price": 70.00
    },{
      "id": 4,
      "type": 1,
      "price": 5.00
    }
  ]
}
```

