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
    }
}
