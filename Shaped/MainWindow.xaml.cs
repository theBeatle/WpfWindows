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

namespace Shaped
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

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BlackNWhiteButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a linear gradient brush with five stops   
            LinearGradientBrush blacknwhiteBrush = new LinearGradientBrush();
            blacknwhiteBrush.StartPoint = new Point(0, 0);
            blacknwhiteBrush.EndPoint = new Point(1, 1);
            // Create and add Gradient stops  
            GradientStop blackGS = new GradientStop();
            blackGS.Color = Colors.Black;
            blackGS.Offset = 0.0;
            blacknwhiteBrush.GradientStops.Add(blackGS);
            GradientStop whiteGS = new GradientStop();
            whiteGS.Color = Colors.White;
            whiteGS.Offset = 1.0;
            blacknwhiteBrush.GradientStops.Add(whiteGS);
            UIPath.Fill = blacknwhiteBrush;
        }
    }
}
