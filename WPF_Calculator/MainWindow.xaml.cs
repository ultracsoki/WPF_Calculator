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

namespace WPF_Calculator
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

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            string number1String = textboxNumber1.Text;
            string number2String = textboxNumber2.Text;
            EllenorzesUres(number1String, number2String);
            if (Ellenorzes(number1String, number2String) == true)
            {
                labelEredmeny.Content = int.Parse(textboxNumber1.Text) + int.Parse(textboxNumber2.Text);
            }
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            string number1String = textboxNumber1.Text;
            string number2String = textboxNumber2.Text;
            EllenorzesUres(number1String, number2String);
            if (Ellenorzes(number1String, number2String) == true)
            {
                labelEredmeny.Content = int.Parse(textboxNumber1.Text) - int.Parse(textboxNumber2.Text);
            }
        }

        private void buttonSzorzas_Click(object sender, RoutedEventArgs e)
        {
            string number1String = textboxNumber1.Text;
            string number2String = textboxNumber2.Text;
            EllenorzesUres(number1String, number2String);
            if (Ellenorzes(number1String, number2String) == true)
            {
                labelEredmeny.Content = int.Parse(textboxNumber1.Text) * int.Parse(textboxNumber2.Text);
            }
        }

        private void buttonOsztas_Click(object sender, RoutedEventArgs e)
        {
            string number1String = textboxNumber1.Text;
            string number2String = textboxNumber2.Text;
            EllenorzesUres(number1String, number2String);
            if (Ellenorzes(number1String, number2String) == true)
            {
                labelEredmeny.Content = Math.Round((double.Parse(textboxNumber1.Text) / double.Parse(textboxNumber2.Text)),2);
            }
        }

        private void buttonMaradekos_Click(object sender, RoutedEventArgs e)
        {
            string number1String = textboxNumber1.Text;
            string number2String = textboxNumber2.Text;
            EllenorzesUres(number1String, number2String);
            if (Ellenorzes(number1String, number2String) == true)
            {
                labelEredmeny.Content = (int.Parse(textboxNumber1.Text) % int.Parse(textboxNumber2.Text));
            }
        }

        private bool EllenorzesUres(string n1, string n2)
        {
            if (n1 == "" || n2 == "")
            {
                MessageBox.Show("Minden mező kitöltése kötelező!");
                return false;
            }
            return true;
        }

        private bool Ellenorzes(string n1, string n2)
        {
            if (!(SzamE(n1)) || !(SzamE(n2)))
            {
                MessageBox.Show("Számot kell megadnia!");
                return false;
            }
            return true;
        }

        private bool SzamE(string szam)
        {
            try
            {
                Convert.ToInt32(szam);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
