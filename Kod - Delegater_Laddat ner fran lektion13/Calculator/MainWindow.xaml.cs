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

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = 0;
            int secondNumber = 0;

            try
            {
                firstNumber = int.Parse(FirstNumber.Text);
                secondNumber = int.Parse(SecondNumber.Text);
                MyListBox.Items.Add($"{firstNumber} x {secondNumber} = {firstNumber * secondNumber}");
                ErrorMessage.Visibility = Visibility.Hidden;
            }
            catch
            {
                ErrorMessage.Visibility = Visibility.Visible;
            }

            

        }

        private void EmptyContent(object sender, RoutedEventArgs e)
        {
            FirstNumber.Text = "";
        }



        private void EmptyContent2(object sender, RoutedEventArgs e)
        {
            SecondNumber.Text = "";
        }
    }
}
