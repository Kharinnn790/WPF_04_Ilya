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
using System.Windows.Shapes;

namespace WPF_Ilya
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, является ли введенное значение числом
            if (double.TryParse(NumberTextBox.Text, out double number))
            {
                // Проверяем, попадает ли число в указанные диапазоны
                if (number >= 0 && number <= 14)
                {
                    ResultTextBlock.Text = "Число попадает в диапазон [0 - 14].";
                }
                else if (number >= 15 && number <= 35)
                {
                    ResultTextBlock.Text = "Число попадает в диапазон [15 - 35].";
                }
                else if (number >= 36 && number <= 50)
                {
                    ResultTextBlock.Text = "Число попадает в диапазон [36 - 50].";
                }
                else if (number > 50 && number <= 100)
                {
                    ResultTextBlock.Text = "Число попадает в диапазон [51 - 100].";
                }
                else
                {
                    ResultTextBlock.Text = "Число не попадает ни в один из указанных диапазонов.";
                }
            }
            else
            {
                ResultTextBlock.Text = "Ошибка: Введите корректное число!";
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}