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

namespace Övning14_4_Buss1
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
            Canvas.SetLeft(Buss, Canvas.GetLeft(Buss) + 150);

            if (Canvas.GetLeft(Buss) > 650)
            {
                Canvas.SetLeft(Buss, Canvas.GetLeft(Buss) - 750);
            }

            if (Canvas)
            {

            }
        }
    }
}
