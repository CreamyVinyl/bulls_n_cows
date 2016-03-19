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
            TextBox_WordInput.Focus();
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
            TextBox_WordInput.Focus();
        }

        private void Analysis(string hiddenword, string wordattempt)
        {
            wordattempt = wordattempt.ToLower();

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

            if (bulls == wordattempt.Length)
            {
                Win winpage = new Win();
                winpage.ShowDialog();
                this.Close();
            }
        }

        private void ColorChange(Button A)
        {
            while (A.Background.ToString() == "#FFCDCDCD" || A.Background.ToString() == "#FF008000" || A.Background.ToString() == "#FFFF0000")
            {
                if (A.Background.ToString() == "#FFCDCDCD")
                {
                    A.Background = Brushes.Red;
                    break;
                }
                if (A.Background.ToString() == "#FFFF0000")
                {
                    A.Background = Brushes.Green;
                    break;
                }
                if (A.Background.ToString() == "#FF008000")
                {
                    A.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFCDCDCD"));
                    break;
                }
            }
        }

        private void Button_А_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_А);
        }

        private void Button_Б_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Б);
        }

        private void Button_В_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_В);
        }

        private void Button_Г_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Г);
        }

        private void Button_Д_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Д);
        }

        private void Button_Е_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Е);
        }

        private void Button_Ж_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Ж);
        }

        private void Button_З_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_З);
        }

        private void Button_И_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_И);
        }

        private void Button_Й_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Й);
        }

        private void Button_К_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_К);
        }

        private void Button_Л_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Л);
        }

        private void Button_М_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_М);
        }

        private void Button_Н_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Н);
        }

        private void Button_О_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_О);
        }

        private void Button_П_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_П);
        }

        private void Button_Р_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Р);
        }

        private void Button_С_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_С);
        }

        private void Button_Т_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Т);
        }

        private void Button_У_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_У);
        }

        private void Button_Ф_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Ф);
        }

        private void Button_Х_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Х);
        }

        private void Button_Ц_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Ц);
        }

        private void Button_Ч_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Ч);
        }

        private void Button_Ш_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Ш);
        }

        private void Button_Щ_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Щ);
        }

        private void Button_Ъ_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Ъ);
        }

        private void Button_Ы_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Ы);
        }

        private void Button_Ь_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Ь);
        }

        private void Button_Э_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Э);
        }

        private void Button_Ю_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Ю);
        }

        private void Button_Я_Click(object sender, RoutedEventArgs e)
        {
            ColorChange(Button_Я);
        }

        private void TextBox_Temporary_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox_Temporary.MaxLength = Letters.length;
        }
    }
}
