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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ent
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            ItalianoMenu ita = new ItalianoMenu();
            this.Content = ita;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Visitor vis = new Visitor();
            this.Content = vis;
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Waither wai = new Waither();
            this.Content = wai;
        }
    }
}
