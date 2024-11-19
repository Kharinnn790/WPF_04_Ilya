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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private string SECRETPASSWORD = "228";
        private string SECRETMESSAGE = "Что такое 52? Пожалуй, вот главная загадка человечества...";
        public Window4()
        {
            InitializeComponent();
        }
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            string inputPassword = PasswordTextBox.Text;

            // Проверяем введенный пароль
            if (inputPassword == SECRETPASSWORD)
            {
                MessageTextBlock.Text = SECRETMESSAGE; // Выводим секретное сообщение
                MessageTextBlock.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.LightGreen);
            }
            else
            {
                MessageTextBlock.Text = "Неверный пароль. Попробуйте снова!"; // Сообщение об ошибке
                MessageTextBlock.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
                PasswordTextBox.Clear(); // Очищаем поле ввода
                PasswordTextBox.Focus(); // Устанавливаем фокус на поле ввода
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
