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

        [TestMethod()]
        public void GridRandomCreateRandomGrid1MineTest()
        {
            int expected = 1;
            int rows = 7;
            int columns = 8;
            Grid grid = GridRandom.CreateRandomGrid(rows, columns, expected);
            int actual = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (grid[i, j] == Grid.mine_value) actual += 1;

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой создания радномной Grid. Ожидается " + expected + " мина. Фактически " + actual + " мина.");
            }
        }

        [TestMethod()]
        public void GridRandomCreateRandomGrid2MineTest()
        {
            int expected = 2;
            int rows = 6;
            int columns = 6;
            Grid grid = GridRandom.CreateRandomGrid(rows, columns, expected);
            int actual = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (grid[i, j] == Grid.mine_value) actual += 1;

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой создания радномной Grid. Ожидается " + expected + " мина. Фактически " + actual + " мина.");
            }
        }
    }
}
