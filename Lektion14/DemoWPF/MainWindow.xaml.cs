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

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Vi skapar textboxar i Canvas.
            for (int i = 0; i < 10; i++)        //Loopas 0-9
            {
                TextBox tb = new TextBox();
                tb.Width = 100;
                string name = "textBox" + i;
                tb.Text = "TEXTBOXEN NR " + i;      //Vad det ska stå i textboxen
                RegisterName(name, tb);
                //Var de olika object som befinner sig i canvas ska vara.
                Canvas.SetLeft(tb, 25);         //25 pixlar ifrån vänstra kanten
                Canvas.SetTop(tb, i * 20);          //varje pixel kmr placeras med 20 pix mellanrum?
                myCanvas.Children.Add(tb);
            }



        }

        private void darkMode_Clicked(object sender, RoutedEventArgs e)
        {
            if (darkMode.IsChecked == true)
            {
                myWindow.Background = new SolidColorBrush(Colors.Black);
                darkMode.Foreground = new SolidColorBrush(Colors.White); 
            }
            else
            {
                myWindow.Background = new SolidColorBrush(Colors.White);
                darkMode.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void darkMode_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Slider_Valuechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myRectangle.Height = mySlider.Value;
        }

        private void CalculateDateDiff_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = dateSelect.SelectedDate;        //Betyder att vi kan ha nollvärde på detta. Men då behöver vi lägga till "?".
            DateTime? christmasDate = DateTime.Parse("2020-12-24");

            //Hur långt är det mellan dessa datum?:
            TimeSpan? dayDiff = (christmasDate - selectedDate);

            christmasInfo.Text = $"{dayDiff.Value.Days} dagar till julafton";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb3 = (TextBox)FindName("textBox3");
            if (tb3 != null)        //om tb3 inte är null
            {
                tb3.Text = "Detta är textbox 3";
            }
        }
    }
}
