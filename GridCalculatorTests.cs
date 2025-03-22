using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lr3_2.Tests
{
    [TestClass()]
    class GridCalculatorTests
    {
        [TestMethod()]
        public void GridCalculatorCreationTest()
        {
            GridCalculator actual = new GridCalculator();
            Assert.IsNotNull(actual, "Сбой создания объекта GridCalculator. Ожидается not null объект класса.");
        }
    }
}