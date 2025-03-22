namespace lr3_2
{
    public class Grid
    {
        public readonly int rows;
        public readonly int columns;

        public Grid(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
        public int this[int row, int column]
        {
            get { return 9; }
            set { }
        }
    }
}