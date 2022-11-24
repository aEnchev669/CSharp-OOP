using ConsoleApp1;
using Promotion.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Promotion
{
    public class ProductService
    {
        private IProductsDatebase productsDatebase;
        private List<Product> products;
        private Promotions promotionsService = new Promotions(DateTime.Now);
        public ProductService(IProductsDatebase db)
        {
            this.productsDatebase = db;
            products = db.GetAll();
        }

        public void Add(Product product)
        {
            products.Add(product);

            productsDatebase.Save(products);
        }
        public void Delete(int id)
        {
            Product productToDelete = FindId(id);
            if (productToDelete == null)
            {
                throw new ArgumentException("The product can not be null or empty");
            }
            products.Remove(productToDelete);
            productsDatebase.Save(products);
        }
        public List<Product> GetAllProductsForToday()
        {
            List<Product> productsWithPromotionApplied = new List<Product>();

            foreach (var product in products)
            {
                decimal price = promotionsService.GetPromotion(product);
                productsWithPromotionApplied.Add(new Product(product.ID, product.Name, price));
            }
            return productsWithPromotionApplied;

        }
        private Product FindId(int id)
        {
            return products.FirstOrDefault(i => i.ID == id);
        }
    }
}
