using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed.Promotions.Interfaces
{
    public interface IPromotion
    {
        public decimal GetDiscount(Product product);
    }
}
