# CMPG323-Project-2-34739572
## How to use the API
#### POST:/api/Authenticate/login
> This is where you can log in with a registered account in order to recieve your token to use the API.
#### POST:/api/Authenticate/register
> This is where you can register a normal account.
#### POST:/api/Authenticate/register-admin
> This is where you can register an admin account.
-------------------------------------------------------------------------------------------------------------
#### GET:/api/Customers
> Gets all customers on the database.
#### POST:/api/Customers
> Adds a new customer to the database.
#### GET:/api/Customers/{id}
> Gets a specific customer on the database with a given id.
#### PUT:/api/Customers/{id}
> Updates a specific customer (PUT method) on the database with a given id.
#### PATCH:/api/Customers/{id}
> Updates a specific customer (PATCH method) on the database with a given id.
#### DELETE:/api/Customers/{id}
> Deletes a specific customer on the database with a given id.
-------------------------------------------------------------------------------------------------------------
#### GET:/api/OrderDetails
> Gets all order details on the database.
#### POST:/api/OrderDetails
> Adds a new order detail to the database.
#### GET:/api/OrderDetails/{id}
> Gets a specific order detail on the database with a given id.
#### PUT:/api/OrderDetails/{id}
> Updates a specific order detail (PUT method) on the database with a given id.
#### PATCH:/api/OrderDetails/{id}
> Updates a specific order detail (PATCH method) on the database with a given id.
#### DELETE:/api/OrderDetails/{id}
> Deletes a specific order detail on the database with a given id.
#### GET:/api/OrderDetails/{orderId}/GetProducts
> Gets all the products for a specific order with a given id.
-------------------------------------------------------------------------------------------------------------
#### GET:/api/Orders
> Gets all orders on the database.
#### POST:/api/Orders
> Adds a new order to the database.
#### GET:/api/Orders/{id}
> Gets a specific order on the database with a given id.
#### PUT:/api/Orders/{id}
> Updates a specific order (PUT method) on the database with a given id.
#### PATCH:/api/Orders/{id}
> Updates a specific order (PATCH method) on the database with a given id.
#### DELETE:/api/Orders/{id}
> Deletes a specific order on the database with a given id.
#### GET:/api/Orders/{customerId}/Orders
> Gets all the orders from a specific customer with a given id.
-------------------------------------------------------------------------------------------------------------
#### GET:/api/Products
> Gets all products on the database.
#### POST:/api/Products
> Adds a new product to the database.
#### GET:/api/Products/{id}
> Gets a specific product on the database with a given id.
#### PUT:/api/Products/{id}
> Updates a specific product (PUT method) on the database with a given id.
#### PATCH:/api/Products/{id}
> Updates a specific product (PATCH method) on the database with a given id.
#### DELETE:/api/Products/{id}
> Deletes a specific product on the database with a given id.
-------------------------------------------------------------------------------------------------------------
## Reference List
1. Microsoft (2023) Reverse Engineering - EF Core, Reverse Engineering - EF Core | Microsoft Learn. Available at: https://learn.microsoft.com/en-za/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli (Accessed: 24 August 2023). 
2. Microsoft (2023) Connectivity settings for Azure SQL database and Azure Synapse Analytics - Azure SQL database and Azure Synapse Analytics, Connectivity settings for Azure SQL Database and Azure Synapse Analytics - Azure SQL Database and Azure Synapse Analytics | Microsoft Learn. Available at: https://learn.microsoft.com/en-za/azure/azure-sql/database/connectivity-settings?view=azuresql&amp;tabs=azure-portal#deny-public-network-access (Accessed: 24 August 2023). 
3. Auth0 (no date) JSON web tokens introduction, JSON Web Token Introduction. Available at: https://jwt.io/introduction (Accessed: 24 August 2023).
4. Auth0 (no date) Jwt Token Debugger, JSON Web Tokens. Available at: https://jwt.io/ (Accessed: 24 August 2023).
5. IBM (2023) JSON Web Token (JWT), JSON web token (JWT). Available at: https://www.ibm.com/docs/en/cics-ts/6.1?topic=cics-json-web-token-jwt (Accessed: 24 August 2023). 
6. Fortinet (no date) What is API security?, Fortinet. Available at: https://www.fortinet.com/resources/cyberglossary/api-security (Accessed: 24 August 2023). 
7. Yasar, K. (2023) What is API security?: Definition from TechTarget, App Architecture. Available at: https://www.techtarget.com/searchapparchitecture/definition/API-security (Accessed: 24 August 2023). 
8. Red Hat (no date) What is API security? Available at: https://www.redhat.com/en/topics/security/api-security (Accessed: 24 August 2023). 
9. Microsoft (no date) Azure SQL database – managed cloud database service: Microsoft azure, Managed Cloud Database Service | Microsoft Azure. Available at: https://azure.microsoft.com/en-us/products/azure-sql/database (Accessed: 24 August 2023). 
10. Microsoft (no date) App Service - build and host web apps: Microsoft azure, Build and Host Web Apps | Microsoft Azure. Available at: https://azure.microsoft.com/en-us/products/app-service (Accessed: 24 August 2023). 
11. Microsoft (no date) Azure App Service Documentation - Azure App Service, Azure App Service documentation - Azure App Service | Microsoft Learn. Available at: https://learn.microsoft.com/en-us/azure/app-service/ (Accessed: 24 August 2023). 
12. Microsoft (no date) Create web apis with ASP.NET CORE, Microsoft Learn. Available at: https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-7.0&amp;WT.mc_id=dotnet-35129-website (Accessed: 24 August 2023). 
13. Red Hat (2020) What is a rest api?, Red Hat - We make open source technologies for the enterprise. Available at: https://www.redhat.com/en/topics/api/what-is-a-rest-api (Accessed: 24 August 2023). 
14. Amazon (no date) What is RESTful API, Amazon. Available at: https://aws.amazon.com/what-is/restful-api/#:~:text=RESTful%20API%20is%20an%20interface,applications%20to%20perform%20various%20tasks. (Accessed: 24 August 2023). 
15. IBM (no date) What is a rest api?, IBM. Available at: https://www.ibm.com/topics/rest-apis (Accessed: 24 August 2023). 
16. SoftwareAG (no date) Building an effective enterprise API security strategy&nbsp;, Software AG. Available at: https://www.softwareag.com/en_corporate/resources/api/wp/api-security-strategy.html?utm_source=google&amp;utm_medium=cpc&amp;utm_campaign=aim_api-intg&amp;utm_region=hq&amp;utm_subcampaign=stg-1&amp;utm_content=stg-1_whitepaper_build-an-effective-enterprise-api-strategy&amp;gclid=Cj0KCQjw0bunBhD9ARIsAAZl0E3s45uuq6OEzDvSGWo1EJAvBJl_O0dwD6rxOe_TlOfsNhkC4m_iq1saAsFrEALw_wcB (Accessed: 24 August 2023). 
17. GitHub (2022) Keeping your API credentials secure - github enterprise server 3.9 docs, GitHub Docs. Available at: https://docs.github.com/en/enterprise-server@3.9/rest/overview/keeping-your-api-credentials-secure?apiVersion=2022-11-28 (Accessed: 24 August 2023). 
18. Pincovai, M. (2020) 5 best practices for secure API key storage, Amadeus IT Group SA. Available at: https://developers.amadeus.com/blog/best-practices-api-key-storage (Accessed: 24 August 2023). 
19. Jackson, M. (2023) API Keys &amp; Secrets Management Best Practices, GitGuardian Blog - Automated Secrets Detection. Available at: https://blog.gitguardian.com/secrets-api-management/ (Accessed: 24 August 2023). 
20. Solo.io (no date) Azure API management: How it works and a quick tutorial, Solo.io. Available at: https://www.solo.io/topics/api-management/azure-api-management/ (Accessed: 24 August 2023). 
## Endpoints
### POST:/api/Authenticate/login
#### Parameters: None
#### Request Body:
```
{
  "username": "string",
  "password": "string"
}
```
### POST:/api/Authenticate/register
#### Parameters: None
#### Request Body:
```
{
  "username": "string",
  "email": "user@example.com",
  "password": "string"
}
```
### POST:/api/Authenticate/register-admin
#### Parameters: None
#### Request Body:
```
{
  "username": "string",
  "email": "user@example.com",
  "password": "string"
}
```
-------------------------------------------------------------------------------------------------------------
### GET:/api/Customers
#### Parameters: None
#### Request Body: None

### POST:/api/Customers
#### Parameters: None
#### Request Body:
```
{
  "customerId": 0,
  "customerTitle": "string",
  "customerName": "string",
  "customerSurname": "string",
  "cellPhone": "string",
  "orders": [
    {
      "orderId": 0,
      "orderDate": "2023-08-29T15:26:53.150Z",
      "customerId": 0,
      "deliveryAddress": "string",
      "customer": "string",
      "orderDetails": [
        {
          "orderDetailsId": 0,
          "orderId": 0,
          "productId": 0,
          "quantity": 0,
          "discount": 0,
          "order": "string",
          "product": {
            "productId": 0,
            "productName": "string",
            "productDescription": "string",
            "unitsInStock": 0,
            "orderDetails": [
              "string"
            ]
          }
        }
      ]
    }
  ]
}
```
### GET:/api/Customers/{id}
#### Parameters: id
#### Request Body: None

### PUT:/api/Customers/{id}
#### Parameters: id
#### Request Body:
```
{
  "customerId": 0,
  "customerTitle": "string",
  "customerName": "string",
  "customerSurname": "string",
  "cellPhone": "string",
  "orders": [
    {
      "orderId": 0,
      "orderDate": "2023-08-29T15:30:04.264Z",
      "customerId": 0,
      "deliveryAddress": "string",
      "customer": "string",
      "orderDetails": [
        {
          "orderDetailsId": 0,
          "orderId": 0,
          "productId": 0,
          "quantity": 0,
          "discount": 0,
          "order": "string",
          "product": {
            "productId": 0,
            "productName": "string",
            "productDescription": "string",
            "unitsInStock": 0,
            "orderDetails": [
              "string"
            ]
          }
        }
      ]
    }
  ]
}
```
### PATCH:/api/Customers/{id}
#### Parameters: id
#### Request Body:
```
{
  "customerId": 0,
  "customerTitle": "string",
  "customerName": "string",
  "customerSurname": "string",
  "cellPhone": "string",
  "orders": [
    {
      "orderId": 0,
      "orderDate": "2023-08-29T15:30:04.264Z",
      "customerId": 0,
      "deliveryAddress": "string",
      "customer": "string",
      "orderDetails": [
        {
          "orderDetailsId": 0,
          "orderId": 0,
          "productId": 0,
          "quantity": 0,
          "discount": 0,
          "order": "string",
          "product": {
            "productId": 0,
            "productName": "string",
            "productDescription": "string",
            "unitsInStock": 0,
            "orderDetails": [
              "string"
            ]
          }
        }
      ]
    }
  ]
}
```

### DELETE:/api/Customers/{id}
#### Parameters: id
#### Request Body: None

-------------------------------------------------------------------------------------------------------------
### GET:/api/OrderDetails
#### Parameters: None
#### Request Body: None

### POST:/api/OrderDetails
#### Parameters: None
#### Request Body:
```
{
  "orderDetailsId": 0,
  "orderId": 0,
  "productId": 0,
  "quantity": 0,
  "discount": 0,
  "order": {
    "orderId": 0,
    "orderDate": "2023-08-29T15:33:21.586Z",
    "customerId": 0,
    "deliveryAddress": "string",
    "customer": {
      "customerId": 0,
      "customerTitle": "string",
      "customerName": "string",
      "customerSurname": "string",
      "cellPhone": "string",
      "orders": [
        "string"
      ]
    },
    "orderDetails": [
      "string"
    ]
  },
  "product": {
    "productId": 0,
    "productName": "string",
    "productDescription": "string",
    "unitsInStock": 0,
    "orderDetails": [
      "string"
    ]
  }
}
```
### GET:/api/OrderDetails/{id}
#### Parameters: id
#### Request Body: None

### PUT:/api/OrderDetails/{id}
#### Parameters: id
#### Request Body:
```
{
  "orderDetailsId": 0,
  "orderId": 0,
  "productId": 0,
  "quantity": 0,
  "discount": 0,
  "order": {
    "orderId": 0,
    "orderDate": "2023-08-29T15:34:17.847Z",
    "customerId": 0,
    "deliveryAddress": "string",
    "customer": {
      "customerId": 0,
      "customerTitle": "string",
      "customerName": "string",
      "customerSurname": "string",
      "cellPhone": "string",
      "orders": [
        "string"
      ]
    },
    "orderDetails": [
      "string"
    ]
  },
  "product": {
    "productId": 0,
    "productName": "string",
    "productDescription": "string",
    "unitsInStock": 0,
    "orderDetails": [
      "string"
    ]
  }
}
```
### PATCH:/api/OrderDetails/{id}
#### Parameters: id
#### Request Body:
```
{
  "orderDetailsId": 0,
  "orderId": 0,
  "productId": 0,
  "quantity": 0,
  "discount": 0,
  "order": {
    "orderId": 0,
    "orderDate": "2023-08-29T15:34:34.020Z",
    "customerId": 0,
    "deliveryAddress": "string",
    "customer": {
      "customerId": 0,
      "customerTitle": "string",
      "customerName": "string",
      "customerSurname": "string",
      "cellPhone": "string",
      "orders": [
        "string"
      ]
    },
    "orderDetails": [
      "string"
    ]
  },
  "product": {
    "productId": 0,
    "productName": "string",
    "productDescription": "string",
    "unitsInStock": 0,
    "orderDetails": [
      "string"
    ]
  }
}
```
### DELETE:/api/OrderDetails/{id}
#### Parameters: id
#### Request Body: None

### GET:/api/OrderDetails/{orderId}/GetProducts
#### Parameters: id
#### Request Body: None

-------------------------------------------------------------------------------------------------------------
### GET:/api/Orders
#### Parameters: None
#### Request Body:

### POST:/api/Orders
#### Parameters: None
#### Request Body:
```
{
  "orderId": 0,
  "orderDate": "2023-08-29T15:42:13.128Z",
  "customerId": 0,
  "deliveryAddress": "string",
  "customer": {
    "customerId": 0,
    "customerTitle": "string",
    "customerName": "string",
    "customerSurname": "string",
    "cellPhone": "string",
    "orders": [
      "string"
    ]
  },
  "orderDetails": [
    {
      "orderDetailsId": 0,
      "orderId": 0,
      "productId": 0,
      "quantity": 0,
      "discount": 0,
      "order": "string",
      "product": {
        "productId": 0,
        "productName": "string",
        "productDescription": "string",
        "unitsInStock": 0,
        "orderDetails": [
          "string"
        ]
      }
    }
  ]
}
```
### GET:/api/Orders/{id}
#### Parameters: id
#### Request Body: None

### PUT:/api/Orders/{id}
#### Parameters: id
#### Request Body:
```
{
  "orderId": 0,
  "orderDate": "2023-08-29T15:43:26.108Z",
  "customerId": 0,
  "deliveryAddress": "string",
  "customer": {
    "customerId": 0,
    "customerTitle": "string",
    "customerName": "string",
    "customerSurname": "string",
    "cellPhone": "string",
    "orders": [
      "string"
    ]
  },
  "orderDetails": [
    {
      "orderDetailsId": 0,
      "orderId": 0,
      "productId": 0,
      "quantity": 0,
      "discount": 0,
      "order": "string",
      "product": {
        "productId": 0,
        "productName": "string",
        "productDescription": "string",
        "unitsInStock": 0,
        "orderDetails": [
          "string"
        ]
      }
    }
  ]
}
```
### PATCH:/api/Orders/{id}
#### Parameters: id
#### Request Body:
```
{
  "orderId": 0,
  "orderDate": "2023-08-29T15:43:26.108Z",
  "customerId": 0,
  "deliveryAddress": "string",
  "customer": {
    "customerId": 0,
    "customerTitle": "string",
    "customerName": "string",
    "customerSurname": "string",
    "cellPhone": "string",
    "orders": [
      "string"
    ]
  },
  "orderDetails": [
    {
      "orderDetailsId": 0,
      "orderId": 0,
      "productId": 0,
      "quantity": 0,
      "discount": 0,
      "order": "string",
      "product": {
        "productId": 0,
        "productName": "string",
        "productDescription": "string",
        "unitsInStock": 0,
        "orderDetails": [
          "string"
        ]
      }
    }
  ]
}
```
### DELETE:/api/Orders/{id}
#### Parameters: id
#### Request Body: None

### GET:/api/Orders/{customerId}/Orders
#### Parameters: id
#### Request Body: None

-------------------------------------------------------------------------------------------------------------
### GET:/api/Products
#### Parameters: None
#### Request Body: None

### POST:/api/Products
#### Parameters: None
#### Request Body: 
```
{
  "productId": 0,
  "productName": "string",
  "productDescription": "string",
  "unitsInStock": 0,
  "orderDetails": [
    {
      "orderDetailsId": 0,
      "orderId": 0,
      "productId": 0,
      "quantity": 0,
      "discount": 0,
      "order": {
        "orderId": 0,
        "orderDate": "2023-08-29T15:45:52.450Z",
        "customerId": 0,
        "deliveryAddress": "string",
        "customer": {
          "customerId": 0,
          "customerTitle": "string",
          "customerName": "string",
          "customerSurname": "string",
          "cellPhone": "string",
          "orders": [
            "string"
          ]
        },
        "orderDetails": [
          "string"
        ]
      },
      "product": "string"
    }
  ]
}
```
### GET:/api/Products/{id}
#### Parameters: id
#### Request Body: None

### PUT:/api/Products/{id}
#### Parameters: id
#### Request Body:
```
{
  "productId": 0,
  "productName": "string",
  "productDescription": "string",
  "unitsInStock": 0,
  "orderDetails": [
    {
      "orderDetailsId": 0,
      "orderId": 0,
      "productId": 0,
      "quantity": 0,
      "discount": 0,
      "order": {
        "orderId": 0,
        "orderDate": "2023-08-29T15:46:51.790Z",
        "customerId": 0,
        "deliveryAddress": "string",
        "customer": {
          "customerId": 0,
          "customerTitle": "string",
          "customerName": "string",
          "customerSurname": "string",
          "cellPhone": "string",
          "orders": [
            "string"
          ]
        },
        "orderDetails": [
          "string"
        ]
      },
      "product": "string"
    }
  ]
}
```
### PATCH:/api/Products/{id}
#### Parameters: id
#### Request Body:
```
{
  "productId": 0,
  "productName": "string",
  "productDescription": "string",
  "unitsInStock": 0,
  "orderDetails": [
    {
      "orderDetailsId": 0,
      "orderId": 0,
      "productId": 0,
      "quantity": 0,
      "discount": 0,
      "order": {
        "orderId": 0,
        "orderDate": "2023-08-29T15:46:51.790Z",
        "customerId": 0,
        "deliveryAddress": "string",
        "customer": {
          "customerId": 0,
          "customerTitle": "string",
          "customerName": "string",
          "customerSurname": "string",
          "cellPhone": "string",
          "orders": [
            "string"
          ]
        },
        "orderDetails": [
          "string"
        ]
      },
      "product": "string"
    }
  ]
}
```
### DELETE:/api/Products/{id}
#### Parameters: id
#### Request Body: None