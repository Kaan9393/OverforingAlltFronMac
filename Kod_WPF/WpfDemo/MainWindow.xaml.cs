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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DateSelect.SelectedDate = DateTime.Now;

            for(int i = 0; i< 10; i++)
            {
                TextBox tb = new TextBox();
                tb.Width = 100;
                tb.Text = "textBox" + i;
                Canvas.SetLeft(tb, 25);
                Canvas.SetTop(tb, i * 20);
                myCanvas.Children.Add(tb);

                
            }



        }



        private void Checkbox_Clicked(object sender, RoutedEventArgs e)
        {
            if(NightSwitch.IsChecked == true)
            {
                MyWindow.Background = new SolidColorBrush(Colors.Black);
                NightSwitch.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                MyWindow.Background = new SolidColorBrush(Colors.White);
                NightSwitch.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyRectangle.Width = MyRectangle.Width + 10;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyRectangle.Width = MyRectangle.Width - 10;
        }

        private void CalculateDateDiff(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = DateSelect.SelectedDate;
            DateTime? christmasDate = DateTime.Parse("2020-12-24");

            TimeSpan? dayDiff = (christmasDate - selectedDate);

            christmasInfo.Text = $"{dayDiff.Value.Days} days till christmas";


        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MyRectangle.Height = mySlider.Value;
        }
    }
}
