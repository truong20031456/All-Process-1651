using System;
using System.Collections.Generic;

namespace Assignment2
{
    // Product interface
    public interface IProduct
    {
        int GetProductId();
        string GetName();
        string GetDescription();
        double GetPrice();
    }

    // Product class implements IProduct
    public class Product : IProduct
    {
        private int ProductId { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }

        public Product(int productId, string name, string description, double price)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
        }

        public int GetProductId()
        {
            return ProductId;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }

        public double GetPrice()
        {
            return Price;
        }
    }

    // ProductCatalog class
    public class ProductCatalog
    {
        private List<IProduct> products; // Use the interface IProduct

        public ProductCatalog()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            products.Remove(product);
        }

        public IProduct GetProductById(int productId)
        {
            return products.Find(product => product.GetProductId() == productId);
        }

        public List<IProduct> GetAllProducts()
        {
            return products;
        }
    }

    // Singleton class
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object lockObject = new object();
        private ProductCatalog productCatalog;

        private Singleton()
        {
            productCatalog = new ProductCatalog();
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }

        public void AddProduct(IProduct product)
        {
            productCatalog.AddProduct(product);
        }

        public void RemoveProduct(IProduct product)
        {
            productCatalog.RemoveProduct(product);
        }

        public IProduct GetProductById(int productId)
        {
            return productCatalog.GetProductById(productId);
        }

        public List<IProduct> GetAllProducts()
        {
            return productCatalog.GetAllProducts();
        }
    }

    // User class
    public class User
    {
        private int UserId { get; set; }
        private string Username { get; set; }

        public User(int userId, string username)
        {
            UserId = userId;
            Username = username;
        }

        public int GetUserId()
        {
            return UserId;
        }

        public string GetUsername()
        {
            return Username;
        }
    }

    // Admin class
    public class Admin : IProduct
    {
        private int AdminId { get; set; }
        private string Username { get; set; }

        public Admin(int adminId, string username)
        {
            AdminId = adminId;
            Username = username;
        }

        public int GetProductId()
        {
            return AdminId;
        }

        public string GetName()
        {
            return Username;
        }

        public string GetDescription()
        {
            return "Admin User";
        }

        public double GetPrice()
        {
            return 0.0; // Admins are free!
        }
    }

    // Supplier class
    public class Supplier : IProduct
    {
        private int SupplierId { get; set; }
        private string CompanyName { get; set; }

        public Supplier(int supplierId, string companyName)
        {
            SupplierId = supplierId;
            CompanyName = companyName;
        }

        public int GetProductId()
        {
            return SupplierId;
        }

        public string GetName()
        {
            return CompanyName;
        }

        public string GetDescription()
        {
            return "Supplier";
        }

        public double GetPrice()
        {
            return 0.0; // Suppliers are also free!
        }
    }

    // Customer class
    public class Customer : IProduct
    {
        private int CustomerId { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }

        public Customer(int customerId, string firstName, string lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
        }

        public int GetProductId()
        {
            return CustomerId;
        }

        public string GetName()
        {
            return GetFullName();
        }

        public string GetDescription()
        {
            return "Customer";
        }

        public double GetPrice()
        {
            return 0.0; // Customers are not products, so they have a price of 0.
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Singleton
            Singleton singleton = Singleton.GetInstance();

            // Create some sample products
            IProduct product1 = new Product(1, "Product 1", "Description 1", 10.99);
            IProduct product2 = new Product(2, "Product 2", "Description 2", 19.99);

            // Add products to the catalog using Singleton
            singleton.AddProduct(product1);
            singleton.AddProduct(product2);

            // Get a product by ID using Singleton
            IProduct retrievedProduct = singleton.GetProductById(1);
            if (retrievedProduct != null)
            {
                Console.WriteLine($"Retrieved Product: {retrievedProduct.GetName()}, Price: {retrievedProduct.GetPrice()}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            // List all products in the catalog
            List<IProduct> allProducts = singleton.GetAllProducts();
            Console.WriteLine("All Products in Catalog:");
            foreach (IProduct product in allProducts)
            {
                Console.WriteLine($"{product.GetName()}, Price: {product.GetPrice()}");
            }

            // Create sample users, admins, suppliers, and customers
            User user = new User(1, "User1");
            Admin admin = new Admin(1, "Admin1");
            Supplier supplier = new Supplier(1, "Supplier1");
            Customer customer = new Customer(1, "John", "Doe");

            Console.WriteLine($"User: {user.GetUsername()}");
            Console.WriteLine($"Admin: {admin.GetName()}, Description: {admin.GetDescription()}, Price: {admin.GetPrice()}");
            Console.WriteLine($"Supplier: {supplier.GetName()}, Description: {supplier.GetDescription()}, Price: {supplier.GetPrice()}");
            Console.WriteLine($"Customer: {customer.GetName()}, Description: {customer.GetDescription()}, Price: {customer.GetPrice()}");
        }
    }
}
