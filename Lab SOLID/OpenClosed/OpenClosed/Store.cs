using OpenClosed.Promotions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public class Store
    {
        private List<IPromotion> promotions;

        public Store(List<IPromotion> promotions)
        {
            this.promotions = promotions;
        }

        public void Buy(Product product)
        {
            decimal discount = 0;

            foreach (IPromotion promotion in promotions)
            {
                discount += promotion.GetDiscount(product);
            }


            Console.WriteLine($"Applying {discount}lv discount");

            Console.WriteLine("Buying produvt...");
        }
    }
}
