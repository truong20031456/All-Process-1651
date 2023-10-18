using Product_Manager;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
{
    // Create an instance of the Singleton
    Singleton singleton = Singleton.GetInstance();

    // Create some sample products
    Product product1 = new Product(1, "Product 1", "Description 1", 10.99);
    Product product2 = new Product(2, "Product 2", "Description 2", 19.99);

    // Add products to the catalog using Singleton
    singleton.AddProduct(product1);
    singleton.AddProduct(product2);

    // Get a product by ID using Singleton
    Product retrievedProduct = singleton.GetProductById(1);
    if (retrievedProduct != null)
    {
        Console.WriteLine($"Retrieved Product: {retrievedProduct.GetName()}, Price: {retrievedProduct.GetPrice()}");
    }
    else
    {
        Console.WriteLine("Product not found.");
    }

    // List all products in the catalog
    List<Product> allProducts = singleton.GetAllProducts();
    Console.WriteLine("All Products in Catalog:");
    foreach (Product product in allProducts)
    {
        Console.WriteLine($"{product.GetName()}, Price: {product.GetPrice()}");
    }

    // Create sample users, admins, suppliers, and customers
    User user = new User(1, "User1");
    Admin admin = new Admin(1, "Admin1");
    Supplier supplier = new Supplier(1, "Supplier1");
    Customer customer = new Customer(1, "John", "Doe");

    Console.WriteLine($"User: {user.GetUsername()}");
    Console.WriteLine($"Admin: {admin.GetUsername()}");
    Console.WriteLine($"Supplier: {supplier.GetCompanyName()}");
    Console.WriteLine($"Customer: {customer.GetFullName()}");
}
}