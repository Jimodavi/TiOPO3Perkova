using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace lr3_2.Tests
{
    [TestClass()]
    public class ConsoleGameTests
    {
        [TestMethod()]
        public void ConsoleGameCreationTest()
        {
            ConsoleGame actual = new ConsoleGame(new Grid(1, 1));
            Assert.IsNotNull(actual, "Сбой создания объекта ConsoleGame. Ожидается not null объект класса.");
        }

        [TestMethod()]
        public void ConsoleGameGridToString3by2Test()
        {
            string expected = "|??\n|??\n|??\n";
            int rows = 3;
            int columns = 2;
            Grid grid = new Grid(rows, columns);
            grid[0, 0] = 2; grid[0, 1] = 6;
            grid[1, 0] = 9; grid[1, 1] = 6;
            grid[2, 0] = 1; grid[2, 1] = 1;
            ConsoleGame game = new ConsoleGame(grid);
            string actual = game.GridToString();

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии Grid в string. Ожидается: " + expected + "Фактически: " + actual);
            }
        }
        
        [TestMethod()]
        public void ConsoleGameGridToString2by1Test()
        {
            string expected = "|?\n|?\n";
            int rows = 2;
            int columns = 1;
            Grid grid = new Grid(rows, columns);
            grid[0, 0] = 2;
            grid[1, 0] = 6;
            ConsoleGame game = new ConsoleGame(grid);
            string actual = game.GridToString();

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой конверсии Grid в string. Ожидается: " + expected + "Фактически: " + actual);
            }
        }
    }
}
