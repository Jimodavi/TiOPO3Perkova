namespace lr3_2
{
    public class GridRandom
    {
        public static Grid CreateRandomGrid(int rows, int columns, int mines)
        {
            // todo реализовать рандомное расположение мин
            // todo реализовать обработку неправильного количества mines
            Grid grid = new Grid(rows, columns);
            grid[0, 2] = Grid.mine_value;
            if (mines > 1) grid[0,0] = Grid.mine_value;
            new GridCalculator().CalculateGrid(grid);
            return grid;
        }
    }
}
