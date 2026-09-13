using Tyuiu.AgafonovAO.Sprint0.Task5.V0.Lib;

namespace Tyuiu.AgafonovAO.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));

        }

        [TestMethod]
        public void CheckSubtractionlValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));

        }

        [TestMethod]
        public void CheckMultiplicationlValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));

        }

        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));

        }
    }
}
