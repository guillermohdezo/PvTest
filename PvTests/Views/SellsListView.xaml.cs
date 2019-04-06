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
    /// Lógica de interacción para SellsListView.xaml
    /// </summary>
    public partial class SellsListView : Window
    {
        public SellsListView(List<Window> Windows)
        {
            InitializeComponent();
            this.Windows = Windows;
        }

        public List<Window> Windows = new List<Window>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Windows.Remove(this);
            Windows.LastOrDefault().Show();
        }
    }
}
