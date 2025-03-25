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

        [TestMethod()]
        public void ConsoleGameGridToString1by5Test()
        {
            string expected = "|??31?\n";
            int rows = 1;
            int columns = 5;
            Grid grid = new Grid(rows, columns);
            grid[0, 0] = 5; grid[0, 1] = 6; grid[0, 2] = 3; grid[0, 3] = 1; grid[0, 4] = 0;
            ConsoleGame game = new ConsoleGame(grid);
            game.show[0, 2] = true;
            game.show[0, 3] = true;
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

        [TestMethod(), Timeout(2000)]
        public void ConsoleGamePlayExitTest()
        {
            ConsoleGame game = new ConsoleGame(new Grid(1, 1));
            string input = "\n";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            game.Play();
            string actual = stringWriter.ToString();
            string expected = "|?\n|Введите ход: <строка> <столбец>; пустая строка – выход.\r\n|Конец игры\r\n|?\n";

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой метода ConsoleGame.Play. Ожидается вывод: " + expected + "Фактически вывод: " + actual);
            }
        }

        [TestMethod(), Timeout(2000)]
        public void ConsoleGamePlay12MovesTest()
        {
            int rows = 4;
            int columns = 3;
            Grid grid = new Grid(rows, columns);
            grid[0, 0] = 0; grid[0, 1] = 1; grid[0, 2] = 0;
            grid[1, 0] = 7; grid[1, 1] = 1; grid[1, 2] = 1;
            grid[2, 0] = 6; grid[2, 1] = 0; grid[2, 2] = 0;
            grid[3, 0] = 5; grid[3, 1] = 1; grid[3, 2] = 3;
            ConsoleGame game = new ConsoleGame(grid);
            string input = "";
            for (int i = 0; i < grid.rows; i++)
                for (int j = 0; j < grid.columns; j++)
                    input += i.ToString() + " " + j.ToString() + "\n";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            game.Play();
            string actual = stringWriter.ToString();
            int substring_length = 13 + rows * columns + rows * 2;
            actual = actual.Substring(actual.Length - substring_length, substring_length);
            string expected = "|Конец игры\r\n|.1.\n|711\n|6..\n|513\n";

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой метода ConsoleGame.Play. Ожидается вывод: " + expected + "Фактически вывод: " + actual);
            }
        }

        [TestMethod(), Timeout(2000)]
        public void ConsoleGamePlayLooseTest()
        {
            int rows = 5;
            int columns = 4;
            Grid grid = new Grid(rows, columns);
            grid[3, 3] = Grid.mine_value;
            ConsoleGame game = new ConsoleGame(grid);
            string input = "3 3\n";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            game.Play();
            string actual = stringWriter.ToString();
            string expected = "|????\n|????\n|????\n|????\n|????\n|Введите ход: <строка> <столбец>; пустая строка – выход.\r\n|Конец игры\r\n|????\n|????\n|????\n|???9\n|????\n";

            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                throw new AssertFailedException("Сбой метода ConsoleGame.Play. Ожидается вывод \"" + expected + "\".\nФактически вывод \"" + actual + "\".");
            }
        }
    }
}
