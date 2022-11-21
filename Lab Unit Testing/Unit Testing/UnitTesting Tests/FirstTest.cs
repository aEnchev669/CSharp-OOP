using NUnit.Framework;

namespace UnitTesting_Tests
{
    public class FirstTest
    {
        [Test]
        public void Test()
        {
            int result = 1 + 6;
            Assert.AreEqual(5, result, " result should be equal to 5");
        }
        
    }
}