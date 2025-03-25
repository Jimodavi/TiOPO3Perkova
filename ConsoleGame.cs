﻿using static System.Console;
using System.Linq;
using System;

namespace lr3_2
{
    public class ConsoleGame
    {
        public readonly Grid grid;
        public readonly bool[,] show;

        public ConsoleGame(Grid grid)
        {
            this.grid = grid;
            show = new bool[grid.rows, grid.columns];
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
            Write(GridToString());
            WriteLine("|Введите ход: " +
                "<строка> <столбец>; " +
                "пустая строка – выход.");
            WriteLine("|Конец игры");
            Write(GridToString());
        }
    }
}
