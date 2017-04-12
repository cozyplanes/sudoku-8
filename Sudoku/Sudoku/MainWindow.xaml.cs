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
            HideButtons();
        }

        private void HideButtons()
        {
            easy.Visibility = Visibility.Hidden;
            medium.Visibility = Visibility.Hidden;
            hard.Visibility = Visibility.Hidden;
            quit.Visibility = Visibility.Hidden;
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void play_Easy(object sender, RoutedEventArgs e)
        {
            GameBoard gameBoard = new GameBoard("easy");
            MainFrame.NavigationService.Navigate(gameBoard);
            HideButtons();
        }

        private void play_Medium(object sender, RoutedEventArgs e)
        {
            GameBoard gameBoard = new GameBoard("medium");
            MainFrame.NavigationService.Navigate(gameBoard);
            HideButtons();
        }

        private void play_Hard(object sender, RoutedEventArgs e)
        {
            GameBoard gameBoard = new GameBoard("hard");
            MainFrame.NavigationService.Navigate(gameBoard);
            HideButtons();
        }
    }
}
