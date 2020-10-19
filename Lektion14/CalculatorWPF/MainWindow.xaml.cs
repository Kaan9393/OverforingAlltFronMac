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

namespace CalculatorWPF
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

        private void Callc_Click(object sender, RoutedEventArgs e)
        {
            int fNumber, sNumber;
            try
            {
                fNumber = int.Parse(firstNumber.Text);
                sNumber = int.Parse(secondNumber.Text);

                results.Items.Add($"{fNumber} x {sNumber} = {fNumber * sNumber}");        //Listbox består av items
                errorMessage.Visibility = Visibility.Hidden;
            }
            catch
            {
                errorMessage.Visibility = Visibility.Visible;
            }
          
               
        }

        private void results_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void click_division(object sender, RoutedEventArgs e)
        {
            int fNumber, sNumber;

            fNumber = int.Parse(firstNumber.Text);
            sNumber = int.Parse(secondNumber.Text);
            results.Items.Add($"{fNumber} / {sNumber} = {fNumber / sNumber}");
        }
    }
}
