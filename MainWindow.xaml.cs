using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sapper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDarkTheme;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Theme_Click(object sender, RoutedEventArgs e)
        {
             if (isDarkTheme)
            {
                Start.Background = new SolidColorBrush(Colors.White);
                Rules.Background = new SolidColorBrush(Colors.White);
                Exit.Background = new SolidColorBrush(Colors.White);
                Border.Background = new SolidColorBrush(Colors.LightGray);
                ThemeImage.Source = new BitmapImage(new Uri("/sun.png",UriKind.Relative));
                isDarkTheme = false; 
            }
             else
            {
                Start.Background = new SolidColorBrush(Colors.Gray);
                Rules.Background = new SolidColorBrush(Colors.Gray);
                Exit.Background = new SolidColorBrush(Colors.Gray);
                Border.Background = new SolidColorBrush(Color.FromRgb(7,15,43));
                ThemeImage.Source = new BitmapImage(new Uri("/moon.png", UriKind.Relative));
                isDarkTheme |= true;
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            SapperGame sapperGame = new SapperGame();
            sapperGame.Show();
            Close();
        }

        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            Rules rules = new Rules();
            rules.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
