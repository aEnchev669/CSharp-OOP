using OpenClosed.Promotions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Promotions
{
    public class FridayPromotion : IPromotion
    {
        public decimal GetDiscount(Product product)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return 120;
            }
            return 0;
        }
    }
}
