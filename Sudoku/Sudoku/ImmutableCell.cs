using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class ImmutableCell : Cell
    {
        ImmutableCell(int x, int y, int value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }
    }
}
