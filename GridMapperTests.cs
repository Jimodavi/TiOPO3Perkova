using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lr3_2.Tests
{
    [TestClass()]
    class GridMapperTests
    {
        [TestMethod()]
        public void GridMapperCreationTest()
        {
            GridMapper actual = new GridMapper();
            Assert.IsNotNull(actual, "Сбой создания объекта GridMapper. Ожидается not null объект класса.");
        }
    }
}
