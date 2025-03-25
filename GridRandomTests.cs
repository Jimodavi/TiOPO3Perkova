using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lr3_2.Tests
{
    [TestClass()]
    public class GridRandomTests
    {
        [TestMethod()]
        public void GridRandomCreationTest()
        {
            GridRandom actual = new GridRandom();
            Assert.IsNotNull(actual, "Сбой создания объекта GridRandom. Ожидается not null объект класса.");
        }
    }
}
