using System;
using Microsoft.IO;
using System.Linq;

namespace lr3_2
{
    class Program
    {
        static void Main()
        {
            // todo реализовать обработку неправильного ввода
            Console.WriteLine("Консольный \"Сапёр\"");
            while (true)
            {
                Console.WriteLine("Введите операцию: " +
                    "1 - откыть файл; " +
                    "2 - случайное поле; " +
                    "пустая строка – выход.");
                string input = Console.ReadLine();
                if (input == "") break;
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Введите полный путь и имя файла:");
                        string path = Console.ReadLine();
                        try
                        {
                            string[] file = File.ReadAllLines(path);
                            Grid grid1 = GridMapper.StringArrayToGrid(file);
                            ConsoleGame game1 = new ConsoleGame(grid1);
                            game1.Play();
                            break;

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                    case "2":
                        Console.WriteLine("Введите число <рядов> <колонок> <мин>:");
                        input = Console.ReadLine();
                        string[] input_split = input.Split(',', ' ');
                        int[] numbers = input_split.Select(element => Int32.Parse(element)).ToArray();
                        Grid grid2 = GridRandom.CreateRandomGrid(numbers[0], numbers[1], numbers[2]);
                        ConsoleGame game2= new ConsoleGame(grid2);
                        game2.Play();
                        break;
                }
            }
        }
    }
}
