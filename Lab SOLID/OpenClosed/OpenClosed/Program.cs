using OpenClosed.Promotions;
using OpenClosed.Promotions.Interfaces;
using System;
using System.Collections.Generic;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(new List<IPromotion>()
            {
                new TuesdayPromotion(),
                new FridayPromotion(),
                new WednesdayPromotion(),
            });

            store.Buy(new Product());
        }
    }
}
