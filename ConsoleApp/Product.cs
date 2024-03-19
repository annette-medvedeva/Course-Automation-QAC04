using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product> FilterProductsByPrice(List<Product> products, int priceThreshold)
        {
            return products.Where(product => product.Price > priceThreshold).ToList();
        }

        public static void ProcessProducts()
        {
            List<Product> productsList = new List<Product>
        {
            new Product("Milk", 5422),
            new Product("Bread", 1200),
            new Product("Cookies", 694),
            new Product("Water", 10)
        };

            int priceThreshold = 1000;
            List<Product> filteredProducts = FilterProductsByPrice(productsList, priceThreshold);
            Console.WriteLine("Products with a higher price " + priceThreshold + " monetary units: ");
            foreach (var product in filteredProducts)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
