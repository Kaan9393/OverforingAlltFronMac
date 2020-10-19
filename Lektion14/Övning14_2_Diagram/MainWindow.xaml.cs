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

namespace Övning14_2_Diagram
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


        private void text2_change(object sender, TextChangedEventArgs e)
        {
            d2.Height = int.Parse(text2.Text);
        }

        private void text3_change(object sender, TextChangedEventArgs e)
        {
            d3.Height = int.Parse(text3.Text);
        }

        private void rek_enter(object sender, TouchEventArgs e)
        {
            
        }

        private void tex1_changed(object sender, TextChangedEventArgs e)
        {
            d1.Height = int.Parse(text1.Text);
        }

        private void slider_value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            d1.Height = mySlider.Value;
        }
    }
}
