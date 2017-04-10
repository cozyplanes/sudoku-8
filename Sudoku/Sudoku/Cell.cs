using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public abstract class Cell
    {
        protected int x;
        protected int y;
        protected int value;

        public int GetX()
        {
            return x;
        }
        
        public int GetY()
        {
            return y;
        }
        
        public int GetValue()
        {
            return value;
        }
        
    }
}
