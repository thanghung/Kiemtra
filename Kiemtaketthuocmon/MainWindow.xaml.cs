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

namespace Kiemtaketthuocmon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Meo_Click(object sender, RoutedEventArgs e)
        {
            Meo cat = new Meo();
            cat.Keu();
            MessageBox.Show(cat.meo + tbmeo.Text);
        }

        private void Cho_Click(object sender, RoutedEventArgs e)
        {
            Cho dog = new Cho();
            dog.Keu();
            MessageBox.Show(dog.cho + tbcho.Text);
        }
    }
}
