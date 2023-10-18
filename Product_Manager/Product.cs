using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manager
{
    internal class Product
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
}
