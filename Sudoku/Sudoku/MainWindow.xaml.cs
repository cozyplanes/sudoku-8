using System;
using System.Windows;

namespace Sudoku
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("GameBoard.xaml", UriKind.Relative);
            MainFrame.NavigationService.Navigate(uri);
            play.Visibility = Visibility.Hidden;
            quit.Visibility = Visibility.Hidden;

        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
