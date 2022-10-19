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

namespace WPF_Samkova_PR3._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlusTri3_Click(object sender, RoutedEventArgs e)
        {
            double tre = double.Parse(Tri.Text);
            double plus = 3;
            double itog = tre + plus;
            Tri.Text = itog.ToString();
        }

        private void PlusDva3_Click(object sender, RoutedEventArgs e)
        {
            double tre = double.Parse(Tri.Text);
            double plus = 2;
            double itog = tre + plus;
            Tri.Text = itog.ToString();
        }

        private void PlusOdin3_Click(object sender, RoutedEventArgs e)
        {
            double tre = double.Parse(Tri.Text);
            double plus = 1;
            double itog = tre + plus;
            Tri.Text = itog.ToString();
        }

        private void MinusOdin3_Click(object sender, RoutedEventArgs e)
        {
            double tre = double.Parse(Tri.Text);
            double minus = 1;
            double itog = tre - minus;
            Tri.Text = itog.ToString();
        }

        private void MinusDva3_Click(object sender, RoutedEventArgs e)
        {
            double tre = double.Parse(Tri.Text);
            double minus = 2;
            double itog = tre - minus;
            Tri.Text = itog.ToString();
        }

        private void MinusTri3_Click(object sender, RoutedEventArgs e)
        {
            double tre = double.Parse(Tri.Text);
            double minus = 3;
            double itog = tre - minus;
            Tri.Text = itog.ToString();
        }

        private void PlusTri2_Click(object sender, RoutedEventArgs e)
        {
            double dva = double.Parse(Dva.Text);
            double plus = 3;
            double itog = dva + plus;
            Dva.Text = itog.ToString();
        }

        private void PlusDva2_Click(object sender, RoutedEventArgs e)
        {
            double dva = double.Parse(Dva.Text);
            double plus = 2;
            double itog = dva + plus;
            Dva.Text = itog.ToString();
        }

        private void PlusOdin2_Click(object sender, RoutedEventArgs e)
        {
            double dva = double.Parse(Dva.Text);
            double plus = 1;
            double itog = dva + plus;
            Dva.Text = itog.ToString();
        }

        private void MinusOdi2_Click(object sender, RoutedEventArgs e)
        {
            double dva = double.Parse(Dva.Text);
            double minus = 1;
            double itog = dva - minus;
            Dva.Text = itog.ToString();
        }

        private void MinusDv2_Click(object sender, RoutedEventArgs e)
        {
            double dva = double.Parse(Dva.Text);
            double minus = 2;
            double itog = dva - minus;
            Dva.Text = itog.ToString();
        }

        private void MinusTri2_Click(object sender, RoutedEventArgs e)
        {
            double dva = double.Parse(Dva.Text);
            double minus = 3;
            double itog = dva - minus;
            Dva.Text = itog.ToString();
        }

        private void PlusTri1_Click(object sender, RoutedEventArgs e)
        {
            double odin = double.Parse(Odin.Text);
            double plus = 3;
            double itog = odin + plus;
            Odin.Text = itog.ToString();
        }

        private void PlusDva1_Click(object sender, RoutedEventArgs e)
        {
            double odin = double.Parse(Odin.Text);
            double plus = 2;
            double itog = odin + plus;
            Odin.Text = itog.ToString();
        }

        private void PlusOdin1_Click(object sender, RoutedEventArgs e)
        {
            double odin = double.Parse(Odin.Text);
            double plus = 1;
            double itog = odin + plus;
            Odin.Text = itog.ToString();
        }

        private void MinusTri1_Click(object sender, RoutedEventArgs e)
        {
            double odin = double.Parse(Odin.Text);
            double minus = 3;
            double itog = odin - minus;
            Odin.Text = itog.ToString();
        }

        private void MinusDva1_Click(object sender, RoutedEventArgs e)
        {
            double odin = double.Parse(Odin.Text);
            double minus = 2;
            double itog = odin - minus;
            Odin.Text = itog.ToString();
        }

        private void MinusOdin1_Click(object sender, RoutedEventArgs e)
        {
            double odin = double.Parse(Odin.Text);
            double minus = 1;
            double itog = odin - minus;
            Odin.Text = itog.ToString();
        }

        private void Sbros_Click(object sender, RoutedEventArgs e)
        {
            double tri = 3;
            Tri.Text = tri.ToString();
            double dva = 2;
            Dva.Text = dva.ToString();
            double odin = 1;
            Odin.Text = odin.ToString();
        }
    }
}
