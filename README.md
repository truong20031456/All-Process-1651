
# Assignment2 - Product Catalog and User Management

This is a C# program that demonstrates the use of a product catalog, user management, and the Singleton pattern. It includes various classes to represent products, users, admins, suppliers, and customers.

## Table of Contents

- [Description](#description)
- [Usage](#usage)
- [Classes](#classes)
- [Singleton Pattern](#singleton-pattern)
- [License](#license)

## Description

The program consists of several classes:

- **IProduct**: An interface representing a product with methods for getting product details.
- **Product**: A class that implements the `IProduct` interface, representing products with properties like ProductId, Name, Description, and Price.
- **ProductCatalog**: A class that manages a list of products using the `IProduct` interface, allowing for adding, removing, and retrieving products.
- **Singleton**: A Singleton pattern implementation that ensures there is only one instance of the `ProductCatalog` in the application.
- **User**: A class representing a user with properties like UserId and Username.
- **Admin**: A class representing an admin, implementing the `IProduct` interface. Admins have unique product details with a description and a price.
- **Supplier**: A class representing a supplier, also implementing the `IProduct` interface with custom product details.
- **Customer**: A class representing a customer, implementing the `IProduct` interface with custom product details.

## Usage

1. Clone the repository to your local machine.
2. Open the `Assignment2` project in your C# IDE (e.g., Visual Studio or Visual Studio Code).
3. Build and run the project to see a demonstration of product catalog management and user details.

## Classes

- **IProduct**: An interface with methods for product details.
- **Product**: A class implementing the `IProduct` interface, representing products.
- **ProductCatalog**: A class for managing products using the Singleton pattern.
- **Singleton**: A class ensuring a single instance of the `ProductCatalog`.
- **User**: A class representing a user.
- **Admin**: A class representing an admin user, implementing the `IProduct` interface.
- **Supplier**: A class representing a supplier, implementing the `IProduct` interface.
- **Customer**: A class representing a customer, implementing the `IProduct` interface.

## Singleton Pattern

The `Singleton` class ensures that there is only one instance of the `ProductCatalog` in the application. This prevents the creation of multiple product catalogs and maintains consistency in managing products.

## License

This project is open source and available under the [MIT License](LICENSE). You are free to use and modify the code as needed.
