namespace Sudoku
{
    public abstract class Cell
    {

        protected int row;
        protected int column;
        protected int value;

        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        public abstract int Value
        {
            get; set;
        }

        public Cell(int row, int column, int value)
        {
            this.row = row;
            this.column = column;
            this.value = value;
        }

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
            this.value = 0;
        }

    }
}
