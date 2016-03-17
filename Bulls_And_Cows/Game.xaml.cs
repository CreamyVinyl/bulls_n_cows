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
    public partial class Game : Window
    {
        public string wordattempt;
        public Game()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            wordattempt = TextBox.TextProperty.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //while (wordattempt.Length == int.Parse(Letters.length))
            {
                // IS ENABLED !!! ввести событие text_ischanged
            }
            TextBox_WordInput.Text = "";
        }
    }
}
