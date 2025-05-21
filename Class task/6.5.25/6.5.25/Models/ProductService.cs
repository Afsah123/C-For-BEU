using System.Collections.Generic;

namespace _6._5._25.Models
{
    public static class ProductService
    {
        private static List<Product> _products = new List<Product>();
        private static int _nextId = 1;

        public static List<Product> GetAllProducts()
        {
            return _products;
        }

        public static void AddProduct(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.Find(p => p.Id == id);
        }

        public static void UpdateProduct(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                _products[index] = product;
            }
        }

        public static bool DeleteProduct(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if (product != null)
            {
                return _products.Remove(product);
            }
            return false;
        }
    }
} 