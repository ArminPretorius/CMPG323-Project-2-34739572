# CMPG323-Project-2-34739572
## How to use the API
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
## Reference List
