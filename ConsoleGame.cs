using static System.Console;
using System.Linq;
using System;

namespace lr3_2
{
    public class ConsoleGame
    {
        public readonly Grid grid;

        public ConsoleGame(Grid grid)
        {
            this.grid = grid;
        }

        public string GridToString()
        {
            string result = "";
            for (int i = 0; i < grid.rows; i++)
            {
                result += "|";
                for (int j = 0; j < grid.columns; j++)
                {
                    result += '?';
                }
                result += "\n";
            }
            return result;
        }
    }
}
