namespace lr3_2
{
    public class GridCalculator
    {
        public GridCalculator()
        {
        }

        public void CalculateGrid(Grid grid)
        {
            for (int i = 0; i < grid.rows; i++)
            {
                for (int j = 0; j < grid.columns; j++)
                {
                    if (grid[i,j] == Grid.mine_value)
                    {
                        grid.UpAdjacentInc(i, j);
                        grid.RightUpAdjacentInc(i, j);
                        grid.RightAdjacentInc(i, j);
                        grid.RightDownAdjacentInc(i, j);
                        grid.DownAdjacentInc(i, j);
                        grid.LeftDownAdjacentInc(i, j);
                        grid.LeftAdjacentInc(i, j);
                        grid.LeftUpAdjacentInc(i, j);
                    }
                }
            }
        }
    }
}
