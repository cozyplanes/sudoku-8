﻿using System;
using System.Collections.Generic;

namespace Sudoku
{
    public class Board
    {
        List<List<Cell>> cells = new List<List<Cell>>(9);
        public Board()
        {
            initializeBoard();
            setInitialCells();
        }

        public List<Cell> this[int index]
        {
            get { return cells[index]; }
        }


        private void initializeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                cells.Add(new List<Cell>(9));
                for (int j = 0; j < 9; j++)
                {
                    cells[i].Add(new MutableCell(i, j, 0));
                }
            }

        }

        private void setInitialCells()
        {
            Random rand = new Random();
            int i = 0;
            List<Cell> unallowedCells = new List<Cell>();
            int c = 0;
            while (i < 36)
            {
                c++;
                bool flag = false;
                int row = rand.Next(0, 9);
                int column = rand.Next(0, 9);
                int value = rand.Next(1, 10);
                Cell cell = new ImmutableCell(row, column, value);
                foreach (Cell unallowedCell in unallowedCells)
                {
                    if (cell.Equals(unallowedCell))
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag)
                {
                    continue;
                }
                try
                {
                    checkValue(row, column, value);
                    if (cells[row][column].Value == 0 && checkAmount(row, column))
                    {
                        cells[row][column] = cell;
                        i++;
                    }
                }
                catch (Exception e)
                {
                    unallowedCells.Add(cell);
                    continue;
                }
                
            }
            Console.WriteLine(c);
            Console.WriteLine(unallowedCells.Count);
        }

        public List<List<Cell>> Cells
        {
            get { return cells; }
        }

        public bool ifFilled()
        {
            foreach (List<Cell> row in cells)
            {
                foreach (Cell cell in row)
                {
                    if (cell.Value == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool checkAmount(int row, int column)
        {
            bool rowBool = checkRowAmount(row);
            bool columnBool = checkColumnAmount(column);
            bool squareBool = checkSquareAmount(row, column);
            return rowBool && columnBool && squareBool;
        }

        private bool checkRowAmount(int row)
        {
            int amount = 0;
            for (int i = 0; i < 9; i++)
            {
                if (cells[row][i].Value != 0)
                {
                    amount++;
                }
            }
            return amount < 6;

        }

        private bool checkColumnAmount(int column)
        {
            int amount = 0;
            for (int i = 0; i < 9; i++)
            {
                if (cells[i][column].Value != 0)
                {
                    amount++;
                }
            }
            return amount < 6;
        }

        private bool checkSquareAmount(int row, int column)
        {
            int i = 0;
            int squareRow = 3 * (row / 3);
            int squareColumn = 3 * (column / 3);
            for (int rowCounter = squareRow; rowCounter < squareRow + 3; rowCounter++)
            {
                for (int columnCounter = squareColumn; columnCounter < squareColumn + 3; columnCounter++)
                {
                    if (cells[rowCounter][columnCounter].Value != 0)
                    {
                        i++;
                    }
                }
            }
            return i < 6;
        } 
 
        public void setValue(int row, int column, int value)
        {
            checkInput(row);
            checkInput(column);
            checkValue(row, column, value);
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
