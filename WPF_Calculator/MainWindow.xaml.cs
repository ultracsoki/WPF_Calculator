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
            szamokEllenorzese(1);
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            szamokEllenorzese(2);
        }

        private void buttonSzorzas_Click(object sender, RoutedEventArgs e)
        {
            szamokEllenorzese(3);
        }

        private void buttonOsztas_Click(object sender, RoutedEventArgs e)
        {
            szamokEllenorzese(4);
        }

        private void buttonMaradekos_Click(object sender, RoutedEventArgs e)
        {
            szamokEllenorzese(5);
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
            //int.TryParse(szam)
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

        private void szamokEllenorzese(int number)
        {
            string number1String = textboxNumber1.Text;
            string number2String = textboxNumber2.Text;
            EllenorzesUres(number1String, number2String);
            if (Ellenorzes(number1String, number2String) == true)
            {
                switch (number)
                {
                    case 1:
                        labelEredmeny.Content = OsszeAdas(int.Parse(textboxNumber1.Text), int.Parse(textboxNumber2.Text));
                    break;
                    case 2:
                        labelEredmeny.Content = Kivonas(int.Parse(textboxNumber1.Text), int.Parse(textboxNumber2.Text));
                        break;
                    case 3:
                        labelEredmeny.Content = Szorzas(int.Parse(textboxNumber1.Text), int.Parse(textboxNumber2.Text));
                        break;
                    case 4:
                        labelEredmeny.Content = Osztas(double.Parse(textboxNumber1.Text), double.Parse(textboxNumber2.Text));
                        break;
                    case 5:
                        labelEredmeny.Content = Maradekos(int.Parse(textboxNumber1.Text), int.Parse(textboxNumber2.Text));
                        break;
                    default:
                        break;
                }
            }
        }

        private int OsszeAdas(int n1, int n2)
        {
            return n1 + n2;
        }

        private int Kivonas(int n1, int n2)
        {
            return n1 - n2;
        }

        private int Szorzas(int n1, int n2)
        {
            return n1 * n2;
        }

        private double Osztas(double n1, double n2)
        {
            return Math.Round((n1 / n2),2);
        }

        private int Maradekos(int n1, int n2)
        {
            return n1 % n2;
        }

    }
}
