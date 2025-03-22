using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lr3_2.Tests
{
    [TestClass()]
    public class GridTests
    {
        [TestMethod()]
        public void GridCreationTest()
        {
            int expected_rows = 6;
            int expected_columns = 6;
            Grid actual = new Grid(expected_rows, expected_columns);
            Assert.IsNotNull(actual, "Сбой создания сетки. Ожидается not null объект класса.");
        }
    }
}
