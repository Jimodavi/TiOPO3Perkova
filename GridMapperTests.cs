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

        [TestMethod()]
        public void GridMapperDotToInt()
        {
            int expected = 0;
            int actual = GridMapper.ToInt('.');

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии char в int. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }

        [TestMethod()]
        public void GridMapper1ToInt()
        {
            int expected = 1;
            int actual = GridMapper.ToInt('1');

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии char в int. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }

        [TestMethod()]
        public void GridMapperAnyToInt()
        {
            int expected = 0;
            int actual = GridMapper.ToInt('?');

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии char в int. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }

        [TestMethod()]
        public void GridMapper9ToChar()
        {
            char expected = GridMapper.mine;
            char actual = GridMapper.ToChar(Grid.mine_value);

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии int в char. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }
        
        [TestMethod()]
        public void GridMapper0ToChar()
        {
            char expected = '.';
            char actual = GridMapper.ToChar(0);

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии int в char. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }
        
        [TestMethod()]
        public void GridMapper2ToChar()
        {
            char expected = '2';
            char actual = GridMapper.ToChar(2);

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии int в char. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }

        [TestMethod()]
        public void GridMapper4ToChar()
        {
            char expected = '4';
            char actual = GridMapper.ToChar(4);

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии int в char. Ожидается " + expected + ". Фактически " + actual + " .");
            }
        }

        [TestMethod()]
        public void StringArrayToGrid4by3()
        {
            int rows = 4;
            int columns = 3;
            Grid expected = new Grid(rows, columns);
            expected[0, 0] = 3; expected[0, 1] = 0; expected[0, 2] = 0;
            expected[1, 0] = 0; expected[1, 1] = 0; expected[1, 2] = 0;
            expected[2, 0] = 0; expected[2, 1] = 9; expected[2, 2] = 0;
            expected[3, 0] = 5; expected[3, 1] = 3; expected[3, 2] = 8;
            string[] array = { "3..", ".0.", ".9.", "538" };
            Grid actual = GridMapper.StringArrayToGrid(array);

            string message;
            if (!GridCalculatorTests.arrayEquals(expected.cells, actual.cells, out message))
            {
                throw new AssertFailedException("Сбой конверсии массива string в Grid. " + message);
            }
        }

        [TestMethod()]
        public void StringArrayToGrid2by1()
        {
            int rows = 2;
            int columns = 1;
            Grid expected = new Grid(rows, columns);
            expected[0, 0] = 0;
            expected[1, 0] = 0;
            string[] array = { ",", ":" };
            Grid actual = GridMapper.StringArrayToGrid(array);

            string message;
            if (!GridCalculatorTests.arrayEquals(expected.cells, actual.cells, out message))
            {
                throw new AssertFailedException("Сбой конверсии массива string в Grid. " + message);
            }
        }
        
        [TestMethod()]
        public void GridToStringArray1by4()
        {
            string[] expected = { "2", "1", "4", "-" };
            int rows = 1;
            int columns = 4;
            Grid grid = new Grid(rows, columns);
            grid[0, 0] = 2; grid[0, 1] = 1; grid[0, 2] = 4; grid[0, 3] = 0;
            string[] array = { "2", "1", "4", "-" };
            string[] actual = GridMapper.GridToStringArray(grid);

            string message;
            if (!arrayEquals(expected,actual,out message))
            {
                throw new AssertFailedException("Сбой конверсии Grid в массив string. " + message);
            }
        }

        public static bool arrayEquals(string[] expected, string[] actual, out string message)
        {
            message = "";
            if (expected.GetLength(0) != actual.GetLength(0))
            {
                message = "Ожидается " + expected.GetLength(0) + " элементов. Фактически " + actual.GetLength(0) + " элментов.";
                return false;
            }
            for (int i = 0; i < expected.GetLength(0); i++)
            {
                if (String.Compare(actual[i], expected[i]) != 0)
                {
                    message = "Ожидается [" + i + "] = " + expected[i] + ". Фактически [" + i + "] = " + actual[i] + ".";
                    return false;
                }
            }
            return true;
        }
    }
}
