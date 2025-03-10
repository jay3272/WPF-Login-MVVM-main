﻿using System;
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

namespace WPF_LoginForm.Views
{
    /// <summary>
    /// DashboardView.xaml 的互動邏輯
    /// </summary>
    public partial class DashboardView : Window
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // 創建 LoginView
            LoginView loginView = new LoginView();
            Application.Current.MainWindow = loginView;
            loginView.Show();

            // 關閉 Dashboard
            this.Close();
        }
    }
}
