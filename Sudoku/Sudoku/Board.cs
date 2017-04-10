using System;
using System.Collections.Generic;

namespace Sudoku
{
    public class Board
    {
        List<List<Cell>> cells;

        public void setValue(int row, int column, int value)
        {
            checkInput(row);
            checkInput(column);
            cells[row][column].Value = value;
        }

        private void checkInput(int input)
        {
            if (input < 0 || input > 8)
                throw new ArgumentOutOfRangeException("Input is out of range!");
        }

        private void checkValue(int row, int column, int value)
        {
            checkRow(row, column, value);
            checkColumn(row, column, value);
            checkSquare(row, column, value);
        }

        private void checkIdentity(int firtsValue, int secondValue, String unit)
        {
            if (firtsValue == secondValue)
                throw new Exception("Such value is already in this " + unit);
        }

        private void checkRow(int row, int column, int value)
        {
            List<Cell> cellRow = cells[row];
            foreach (Cell cell in cellRow)
            {
                checkIdentity(cell.Value, value, "row");
            }
        }

        private void checkColumn(int row, int column, int value)
        {
            List<Cell> cellColumn = new List<Cell>();
            foreach (List<Cell> listCell in cells)
            {
                cellColumn.Add(listCell[column]);
            }
            foreach (Cell cell in cellColumn)
            {
                checkIdentity(cell.Value, value, "column");
            }
        }

        private void checkSquare(int row, int column, int value)
        {
            int squareRow = 3 * (row / 3);
            int squareColumn = 3 * (column / 3);
            for (int rowCounter = squareRow; rowCounter < squareRow + 3; rowCounter++)
            {
                for (int columnCounter = squareColumn; columnCounter < squareColumn + 3; columnCounter++)
                {
                    checkIdentity(cells[rowCounter][columnCounter].Value, value, "square");
                }
            }
        }
    }
}
