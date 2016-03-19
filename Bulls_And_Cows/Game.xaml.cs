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

namespace Bulls_And_Cows
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public class ForListView
    {
        public int Номер { get; set; }

        public string Слово { get; set; }

        public int Быки { get; set; }

        public int Коровы { get; set; }
    }
    
    public partial class Game : Window
    {
        public string wordattempt;
        public int moves;
        public int bulls;
        public int cows;

        public Game()
        {
            InitializeComponent();
        }

        private void TextBox_WordInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            wordattempt = TextBox_WordInput.Text;

            if (TextBox_WordInput.Text.Length == Letters.length)
            {
                Button_Check.IsEnabled = true;
            }
            else
            {
                Button_Check.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Analysis(Letters.hiddenword, wordattempt);
            ListView_BullsCows.Items.Add(new ForListView { Номер = moves, Слово = wordattempt, Быки = bulls, Коровы = cows });
            TextBox_WordInput.Text = "";
        }

        private void Analysis (string hiddenword, string wordattempt) // НУЖНО СДЕЛАТЬ ОКНО ДЛЯ ЗАВЕРШЕНИЯ ИГРЫ
        {
            wordattempt = wordattempt.ToLower();
            string tempword = hiddenword;

            moves += 1;
            bulls = 0;
            cows = 0;
            char[] letters_word = Letters.hiddenword.ToCharArray();
            char[] letters_attempt = wordattempt.ToCharArray();
            

            for (int i = 0; i < letters_word.Length; i++)
            {
                for (int j = 0; j < letters_attempt.Length; j++)
                {
                    if (i == j && letters_word[i] == letters_attempt[j])
                    {
                        bulls += 1;
                        letters_word[i] = '0';
                    } 
                }
            }

            for (int i = 0; i < letters_word.Length; i++)
            {
                for (int j = 0; j < letters_attempt.Length; j++)
                {
                    if (i != j && letters_word[i] == letters_attempt[j])
                    {
                        cows += 1;
                        letters_word[i] = '0';
                    }
                }
            }

            hiddenword = tempword;
        }

        private void Button_А_Click(object sender, RoutedEventArgs e)
        {
            while (Button_А.Background.ToString() == "#FFCDCDCD" || Button_А.Background.ToString() == "#FF008000" || Button_А.Background.ToString() == "#FFFF0000")
            {
                if (Button_А.Background.ToString() == "#FFCDCDCD")
                {
                    Button_А.Background = Brushes.Red;
                    break;
                }
                if (Button_А.Background.ToString() == "#FFFF0000")
                {
                    Button_А.Background = Brushes.Green;
                    break;
                }
                if (Button_А.Background.ToString() == "#FF008000")
                {
                    Button_А.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFCDCDCD"));
                    break;
                }
            }
        }
    }
}
