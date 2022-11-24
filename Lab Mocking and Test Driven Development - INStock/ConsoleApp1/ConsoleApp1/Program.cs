using Promotion;
using Promotion.Contracts;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductsDatebase db = new TextProductsDatebase("../../../products.txt");

            List<Product> products = new List<Product>()
            {
                new Product(1, "Olio", 999),
                new Product(2, "Zehtin", 20),
                new Product(3, "Domati", 13)

            };
            db.Save(products);

            ProductService service = new ProductService(db);

            foreach (var product in service.GetAllProductsForToday())
            {
                Console.WriteLine(product);
            };
        }
    }
}
