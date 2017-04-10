using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class MutableCell : Cell
    {
        MutableCell(int x, int y, int value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }

    }
}
