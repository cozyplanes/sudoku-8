using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sudoku
{
    public partial class GameBoard : Page
    {
        private Board board = new Board();

        public GameBoard()
        {
            InitializeComponent();

            for(int i = 0; i < 9; i++)
            {
                List<Cell> row = board[i];
                for (int j = 0; j < 9; j++)
                {
                    Cell cell = row[j];
                    if (cell.Value != 0)
                    {
                        ComboBox comboBox = (ComboBox) LogicalTreeHelper.FindLogicalNode(GameGrid, String.Format("c{0}{1}", i, j));
                        comboBox.SelectedItem = comboBox.Items.GetItemAt(cell.Value - 1);
                    }
                }
            }
        }

        private void choice_PreviewMouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            string senderName = ((ComboBoxItem)sender).Name.Replace("choice", "");
            int row = Int32.Parse(senderName[0].ToString());
            int column = Int32.Parse(senderName[1].ToString());
            ComboBox comboBox = (ComboBox)LogicalTreeHelper.FindLogicalNode(GameGrid, String.Format("c{0}{1}", row, column));
            int value = Int32.Parse(senderName[2].ToString());
            try
            {
                board.setValue(row, column, value);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                comboBox.Text = "";
            }
        }
    }
}
