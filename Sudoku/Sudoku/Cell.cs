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

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;
            Cell objCell = (Cell)obj;
            return objCell.Row == this.Row && objCell.Column == this.Column && objCell.Value == this.Value;
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
