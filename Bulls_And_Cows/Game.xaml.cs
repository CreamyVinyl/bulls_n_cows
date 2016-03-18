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
            TextBox_WordInput.Text = "";
        }

        //private void Button_А_Click(object sender, RoutedEventArgs e)
        //{
        //    while (Button_А.Background.ToString() == "#FFCDCDCD" || Button_А.Background.ToString() == "#FF008000" || Button_А.Background.ToString() == "#FFFF0000")
        //    {
        //        if (Button_А.Background.ToString() == "#FFCDCDCD")
        //        {
        //            Button_А.Background = Brushes.Red;
        //            break;
        //        }
        //        if (Button_А.Background.ToString() == "#FFFF0000")
        //        {
        //            Button_А.Background = Brushes.Green;
        //            break;
        //        }
        //        if (Button_А.Background.ToString() == "#FF008000")
        //        {
        //            Button_А.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFCDCDCD"));
        //            break;
        //        }
        //    }
        //}
    }
}
