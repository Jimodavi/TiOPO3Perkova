namespace lr3_2
{
    public class GridMapper
    {
        public const char mine = '9';

        public static int ToInt(char symbol)
        {
            if (symbol == mine) return Grid.mine_value;
            else return 0;
        }
    }
}
