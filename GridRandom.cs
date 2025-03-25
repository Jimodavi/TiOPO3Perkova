namespace lr3_2
{
    public class GridRandom
    {
        public static Grid CreateRandomGrid(int rows, int columns, int mines)
        {
            // todo реализовать рандомное расположение мин
            Grid grid = new Grid(rows, columns);
            grid[0, 2] = Grid.mine_value;
            new GridCalculator().CalculateGrid(grid);
            return grid;
        }
    }
}
