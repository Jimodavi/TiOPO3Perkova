using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lr3_2.Tests
{
    [TestClass()]
    public class GridMapperTests
    {
        [TestMethod()]
        public void GridMapperCreationTest()
        {
            GridMapper actual = new GridMapper();
            Assert.IsNotNull(actual, "Сбой создания объекта GridMapper. Ожидается not null объект класса.");
        }

        [TestMethod()]
        public void GridMapper9ToInt()
        {
            int expected = 9;
            int actual = GridMapper.ToInt('9');

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии char в int. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }
    }
}
