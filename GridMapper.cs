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
                    return symbol - '0';
            }
        }
    }
}
