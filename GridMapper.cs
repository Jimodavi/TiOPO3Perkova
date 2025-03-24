namespace lr3_2
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
                    return System.Convert.ToChar(number + 48);
            }
        }

        public static Grid StringArrayToGrid(string[] file)
        {
            Grid grid = new Grid(4, 3);
            grid[0, 0] = 3; grid[0, 1] = 0; grid[0, 2] = 0;
            grid[1, 0] = 0; grid[1, 1] = 0; grid[1, 2] = 0;
            grid[2, 0] = 0; grid[2, 1] = 9; grid[2, 2] = 0;
            grid[3, 0] = 5; grid[3, 1] = 3; grid[3, 2] = 8;
            return grid;
        }
    }
}
