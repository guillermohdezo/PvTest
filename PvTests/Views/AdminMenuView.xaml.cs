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
using System.Windows.Shapes;

namespace PvTests.Views
{
    /// <summary>
    /// Lógica de interacción para AdminMenuView.xaml
    /// </summary>
    public partial class AdminMenuView : Window
    {
        public AdminMenuView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SellsView sellsView = new SellsView();
            sellsView.Show();
            this.Hide();
        }
    }
}
