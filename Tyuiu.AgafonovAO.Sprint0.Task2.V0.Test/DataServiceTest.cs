using Tyuiu.AgafonovAO.Sprint0.Task2.V0.lib;

namespace Tyuiu.AgafonovAO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Артур";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Артур", res);
        }
    }
}
