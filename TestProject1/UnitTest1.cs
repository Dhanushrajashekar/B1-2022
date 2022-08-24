using B1_2022;
namespace TestProject1
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            calculator c = new calculator();
            int result = c.Add(10, 20);
            Assert.AreEqual(30, result);
        }
    }
}