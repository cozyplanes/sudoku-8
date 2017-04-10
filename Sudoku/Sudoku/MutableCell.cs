using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class MutableCell : Cell
    {
        public override int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public MutableCell(int row, int column, int value) : base(row, column, value) { }

    }
}
