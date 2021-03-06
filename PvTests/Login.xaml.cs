﻿using PvTests.ViewModels;
using PvTests.Views;
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

namespace PvTests
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public List<Window> Windows = new List<Window>();
        public Login()
        {
            InitializeComponent();
            Windows.Add(this);
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            ((LoginViewModel)this.FindResource("loginViewModel")).View = this;
        }
    }
}
