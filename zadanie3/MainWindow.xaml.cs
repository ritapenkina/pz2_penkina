using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace pz1_penkina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a = 0;
        double b = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToInt32(TextBox1.Text.ToString());
            double b = Convert.ToInt32(TextBox2.Text.ToString());
            double c = Math.Sqrt(a * a + b * b);
            double square = a * b / 2.0;
            label3.Content = "Гипотенуза: " + c;
            label4.Content = "Площадь: " + square;
        }
    }
}
