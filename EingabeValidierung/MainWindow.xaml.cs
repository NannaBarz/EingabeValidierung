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

namespace EingabeValidierung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Datenobjekt bereitstellen
            SomeData sd = new SomeData();
            this.DataContext = sd;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Zustand des Objektes kontrollierne

            MessageBox.Show((DataContext as SomeData).ToString());
        }
    }
}
