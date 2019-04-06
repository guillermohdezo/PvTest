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
    /// Lógica de interacción para UserMenuView.xaml
    /// </summary>
    public partial class UserMenuView : Window
    {
        public List<Window> Windows;
        public UserMenuView(List<Window> windows)
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

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Windows.Remove(this);
            Windows.LastOrDefault().Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SellsListView sellsView = new SellsListView(Windows);
            sellsView.Show();
            this.Hide();
        }
    }
}
