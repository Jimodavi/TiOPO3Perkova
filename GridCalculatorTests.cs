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
                {1, 1, 1, 0, 1, 1, 1},
                {0, 0, 0, 0, 1, Grid.mine_value, 1},
                {0, 0, 0, 0, 1, 1, 1}
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

        [TestMethod()]
        public void GridCalculator3MinesTest()
        {
            int[,] expected =
            {
                {Grid.mine_value, Grid.mine_value},
                {Grid.mine_value, 3}
            };
            int rows = 2;
            int columns = 2;
            Grid actual = new Grid(rows, columns);
            actual[0, 0] = Grid.mine_value;
            actual[0, 1] = Grid.mine_value;
            actual[1, 0] = Grid.mine_value;
            GridCalculator calc = new GridCalculator();
            calc.CalculateGrid(actual);

            string message;
            if (!arrayEquals(expected, actual.cells, out message))
            {
                throw new AssertFailedException("Сбой вычисления значений сетки. " + message);
            }

        }

        public static bool arrayEquals(int[,] expected, int[,] actual, out string message)
        {
            message = "";
            if (expected.GetLength(0) != actual.GetLength(0))
            {
                message = "Ожидается " + expected.GetLength(0) + " столбцов. Фактически " + actual.GetLength(0) + " столбцов.";
                return false;
            }
            if (expected.GetLength(1) != actual.GetLength(1))
            {
                message = "Ожидается " + expected.GetLength(1) + " колонок. Фактически " + actual.GetLength(1) + " колонок.";
                return false;
            }
            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    if (expected[i, j] != actual[i, j])
                    {
                        message = "Ожидается [" + i + ", " + j + "] = " + expected[i, j] + ". Фактически [" + i + ", " + j + "] = " + actual[i, j] + ".";
                        return false;
                    }
                }
            }
            return true;
        }
    }
}