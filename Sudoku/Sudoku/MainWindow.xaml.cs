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
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("GameBoard.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
