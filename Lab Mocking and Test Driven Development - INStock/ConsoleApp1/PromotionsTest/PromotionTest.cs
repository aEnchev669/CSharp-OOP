using ConsoleApp1;
using NUnit.Framework;
using System;

namespace PromotionsTest
{
    public class PromotionTest
    {
        

        [Test]
        [TestCase("22/11/2022", 20)]
        [TestCase("23/11/2022", 0)]
        public void Test_TuesdayPromotion_ShouldReturn_20(string date, decimal result)
        {
            DateTime dateToday = DateTime.Parse(date); 
            Promotions promotions = new Promotions(dateToday);
            Assert.AreEqual(result, promotions.GetPromotion(new Product()));
        }
    }
}