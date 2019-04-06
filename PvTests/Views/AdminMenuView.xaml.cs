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
        public AdminMenuView(List<Window> windows)
        {
            InitializeComponent();
            Windows = windows;
            Windows.Add(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SellsView sellsView = new SellsView(Windows);
            sellsView.Show();
            this.Hide();
        }

        public List<Window> Windows = new List<Window>();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Windows.Remove(this);
            Windows.LastOrDefault().Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SellsListView sellsList = new SellsListView(Windows);
            sellsList.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddProductView addProduct = new AddProductView(Windows);
            addProduct.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EditProductView editProduct = new EditProductView(Windows);
            editProduct.Show();
            this.Hide();
        }
    }
}
