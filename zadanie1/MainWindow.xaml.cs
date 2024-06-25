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
        int des = 0;
        int ed = 0;
        int sum = 0;
        int prod = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(TextBox1.Text.ToString());
                if (a <= 99)
                {
                    des = a / 10;
                    ed = a - (des * 10);
                    sum = des + ed;
                    prod = des * ed;
                    label2.Content = "Количество десятков: " + des;
                    label3.Content = "Количество единиц: " + ed;
                    label4.Content = "Сумма цифр: " + sum;
                    label5.Content = "Произведение цифр: " + prod;
                }
                else
                {
                    MessageBox.Show("Ошибка: Проверьте правильность введенных данных.                       " +
                        "Error: Check that the entered data is correct.");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка: Проверьте правильность введенных данных.                       " +
                    "Error: Check that the entered data is correct.");
            }
        }
    }
}
