namespace lr3_2
{
    public class Grid
    {
        public readonly int rows;
        public readonly int columns;
        public readonly int[,] cells;
        public const int mine_value = 9;

        public Grid(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            cells = new int[rows, columns];
        }
        public int this[int row, int column]
        {
            get { return cells[row, column]; }
            set { cells[row, column] = value; }
        }
        public void IncCell(int row, int column)
        {
            // Метод увеличивающий значение клетки сетки на 1, если значение не максимальное
            // row - строка сетки
            // column - столбец сетки
            var current_value = this[row, column];
            if (current_value == mine_value) return;
            this[row, column] = current_value + 1;
        }
    }
}