using ConsoleApp2;
namespace calculatorUnitTest
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void Testadd()
        {
            calculator c = new calculator();
            int result = c.add(10, 20);
            Assert.AreEqual(30, result);
        }
    }
}