
namespace DataBaseTests
{
    using Database;
    using NUnit.Framework;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16})]
        public void ConstructorShouldInitializedDataWithCurrCount(int[] data)
        {
            Database db = new Database();


            int expectedCount = data.Length;

            int actualCount = db.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}