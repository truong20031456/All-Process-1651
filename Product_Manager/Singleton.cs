using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Manager
{
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

        public void AddProduct(Product product)
        {
            productCatalog.AddProduct(product);
        }

        public void RemoveProduct(Product product)
        {
            productCatalog.RemoveProduct(product);
        }

        public Product GetProductById(int productId)
        {
            return productCatalog.GetProductById(productId);
        }

        public List<Product> GetAllProducts()
        {
            return productCatalog.GetAllProducts();
        }
    }

}


