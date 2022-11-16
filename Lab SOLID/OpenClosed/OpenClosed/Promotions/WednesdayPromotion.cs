using OpenClosed.Promotions.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Promotions
{
    public class WednesdayPromotion : IPromotion
    {
        public decimal GetDiscount(Product product)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                return 50;
            }
            return 0;
        }
    }
}
