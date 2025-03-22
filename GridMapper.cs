﻿namespace lr3_2
{
    public class GridMapper
    {
        public const char mine = '9';
        public const char dot = '.';

        public static int ToInt(char symbol)
        {
            switch (symbol)
            {
                case mine:
                    return Grid.mine_value;

                case dot:
                    return 0;

                default:
                    int result = symbol - '0';
                    if (result > 9) return 0;
                    else return result;
            }
        }

        public static char ToChar(int number)
        {
            switch (number)
            {
                case Grid.mine_value:
                    return mine;
                case 0:
                    return dot;
                default:
                    return '2';
            }
        }
    }
}
