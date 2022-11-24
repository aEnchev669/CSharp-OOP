using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Promotions
    {
        private DateTime dateToday;

        public Promotions(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }

        public decimal GetPromotion(Product product)
        {
            decimal percentage = 0;
            if (dateToday.DayOfWeek == DayOfWeek.Tuesday)
            {
                percentage = 20;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Wednesday)
            {
                percentage = 35;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Thursday)
            {
                percentage = 45;
            }
            if (dateToday.DayOfWeek == DayOfWeek.Sunday)
            {
                percentage = 100;
            }
            return product.Price - (percentage / 100 * product.Price);
        }
    }
}
