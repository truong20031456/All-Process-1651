using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manager
{
    public class ProductCatalog
    {
        private List<Product> products;

        public ProductCatalog()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public Product GetProductById(int productId)
        {
            return products.Find(product => product.GetProductId() == productId);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}

