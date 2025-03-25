using static System.Console;
using System.Linq;
using System;

namespace lr3_2
{
    public class ConsoleGame
    {
        public readonly Grid grid;
        public readonly bool[,] show;
        public int counter;

        public ConsoleGame(Grid grid)
        {
            this.grid = grid;
            show = new bool[grid.rows, grid.columns];
            counter = grid.rows * grid.columns;
        }

        public string GridToString()
        {
            string result = "";
            for (int i = 0; i < grid.rows; i++)
            {
                result += "|";
                for (int j = 0; j < grid.columns; j++)
                {
                    result += show[i, j] ? GridMapper.ToChar(grid[i, j]) : '?';
                }
                result += "\n";
            }
            return result;
        }

        public void Play()
        {
            // todo реализовать обработку неправильного ввода
            while (counter>0)
            {
                Write(GridToString());
                WriteLine("|Введите ход: " +
                    "<строка> <столбец>; " +
                    "пустая строка – выход.");
                string input = ReadLine();
                if (input == "") break;

                string[] input_split = input.Split(',', ' ');
                int[] numbers = input_split.Select(element => Int32.Parse(element)).ToArray();
                show[numbers[0], numbers[1]] = true;
                if (grid[numbers[0], numbers[1]] == Grid.mine_value) counter = 0;
                else counter -= 1;
            }
            WriteLine("|Конец игры");
            Write(GridToString());
        }
    }
}
