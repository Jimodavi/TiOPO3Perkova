using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lr3_2.Tests
{
    [TestClass()]
    public class GridCalculatorTests
    {
        [TestMethod()]
        public void GridCalculatorCreationTest()
        {
            GridCalculator actual = new GridCalculator();
            Assert.IsNotNull(actual, "Сбой создания объекта GridCalculator. Ожидается not null объект класса.");
        }

        [TestMethod()]
        public void GridCalculator2MinesTest()
        {
            int[,] expected =
            {
                {1, Grid.mine_value, 1, 0, 0, 0, 0},
                {0, 1, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1, Grid.mine_value, 1},
                {0, 0, 0, 0, 0, 1, 0}
            };
            int rows = 4;
            int columns = 7;
            Grid actual = new Grid(rows, columns);
            actual[0, 1] = Grid.mine_value;
            actual[2, 5] = Grid.mine_value;
            GridCalculator calc = new GridCalculator();
            calc.CalculateGrid(actual);

            string message;
            if (!arrayEquals(expected, actual.cells, out message))
            {
                throw new AssertFailedException("Сбой вычисления значений сетки. " + message);
            }

        }
    }
}