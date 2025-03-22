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

        [TestMethod()]
        public void GridGetRowsTest()
        {
            int expected_rows = 6;
            Grid actual = new Grid(expected_rows, expected_rows);
            try
            {
                Assert.AreEqual(expected_rows, actual.rows);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой получения строк сетки. Ожидается " + expected_rows + "строк. Фактически " + actual.rows + " строк.");
            }
        }

        [TestMethod()]
        public void GridGetColumnsTest()
        {
            int expected_columns = 7;
            Grid actual = new Grid(expected_columns, expected_columns);
            try
            {
                Assert.AreEqual(expected_columns, actual.columns);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой получения столбцов сетки. Ожидается " + expected_columns + "столбцов. Фактически " + actual.columns + " столбцов.");
            }
        }

        [TestMethod()]
        public void GridGetCellTest()
        {
            int expected = 9;
            int rows = 2;
            int columns = 3;
            Grid actual = new Grid(rows, columns);
            int cell_row = 0;
            int cell_column = 1;
            actual[cell_row, cell_column] = expected;

            try
            {
                Assert.AreEqual(expected, actual[cell_row, cell_column]);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой получения значения ячейки сетки. Ожидается " + expected + ". Фактически " + actual[cell_row, cell_column] + " .");
            }
        }
    }
}
