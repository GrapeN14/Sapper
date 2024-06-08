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

namespace Sapper
{
    /// <summary>
    /// Логика взаимодействия для SapperGame.xaml
    /// </summary>
    public partial class SapperGame : Window
    {
        public SapperGame()
        {
            InitializeComponent();
            DataContext = new MinesweeperViewModel();
        }

        private void MouseRightButtonUpHandler(object sender, MouseButtonEventArgs e)
        {
            var viewModel = DataContext as MinesweeperViewModel;
            if (viewModel != null)
            {
                var button = e.Source as Button;
                if (button != null)
                {
                    var cell = button.Tag as Cell;
                    viewModel.CellRightClickCommand.Execute(cell);
                }
            }
        }
    }
}
