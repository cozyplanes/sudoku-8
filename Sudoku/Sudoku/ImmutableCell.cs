using System;

namespace Sudoku
{
    public class ImmutableCell : Cell
    {
        public ImmutableCell(int row, int column, int value) : base(row, column, value) { }

        public override int Value
        {
            get { return value; }
            set { throw new ArgumentException("This cell can't be modified"); }
        }
    }
}
