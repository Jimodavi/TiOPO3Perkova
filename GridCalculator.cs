namespace lr3_2
{
    public class GridCalculator
    {
        public GridCalculator()
        {
        }

        public void CalculateGrid(Grid grid)
        {
            grid[0, 0] = 1; grid[0, 1] = Grid.mine_value; grid[0, 2] = 1;
            grid[1, 1] = 1; grid[1, 5] = 1;
            grid[2, 4] = 1; grid[2, 5] = Grid.mine_value; grid[2, 6] = 1;
            grid[3, 5] = 1;
        }
    }
}
