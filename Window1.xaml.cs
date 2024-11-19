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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        // Словарь для перевода слов о погоде
        private Dictionary<string, string> translations = new Dictionary<string, string>
        {
            { "солнце", "sun" },
            { "дождь", "rain" },
            { "снег", "snow" },
            { "ветер", "wind" },
            { "облако", "cloud" },
            { "гром", "thunder" },
            { "молния", "lightning" },
            { "туман", "fog" },
            { "тепло", "warm" },
            { "холод", "cold" }
        };
        public Window1()
        {
            InitializeComponent();
        }
        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            string russianWord = InputTextBox.Text.ToLower(); // Получаем слово и приводим к нижнему регистру

            if (translations.TryGetValue(russianWord, out string englishWord))
            {
                ResultTextBlock.Text = $"Перевод: {englishWord}";
            }
            else
            {
                ResultTextBlock.Text = "Такого слова нет.";
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
