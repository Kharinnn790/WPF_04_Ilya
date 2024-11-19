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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значения из текстовых полей
            if (double.TryParse(Operand1TextBox.Text, out double operand1) &&
                double.TryParse(Operand2TextBox.Text, out double operand2))
            {
                string sign = SignTextBox.Text;

                double result;

                // Выбор арифметической операции с помощью switch
                switch (sign)
                {
                    case "+":
                        result = operand1 + operand2;
                        ResultTextBlock.Text = $"Результат: {result}";
                        break;
                    case "-":
                        result = operand1 - operand2;
                        ResultTextBlock.Text = $"Результат: {result}";
                        break;
                    case "*":
                        result = operand1 * operand2;
                        ResultTextBlock.Text = $"Результат: {result}";
                        break;
                    case "/":
                        if (operand2 != 0)
                        {
                            result = operand1 / operand2;
                            ResultTextBlock.Text = $"Результат: {result}";
                        }
                        else
                        {
                            ResultTextBlock.Text = "Ошибка: Деление на ноль!";
                        }
                        break;
                    default:
                        ResultTextBlock.Text = "Ошибка: Неверный знак операции!";
                        break;
                }
            }
            else
            {
                ResultTextBlock.Text = "Ошибка: Введите корректные числа!";
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
