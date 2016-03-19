using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Letters.xaml
    /// </summary>
    public partial class Letters : Window
    {
        public static int length;
        public static string hiddenword;

        public Letters()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Game gamepage = new Game();
            WordGenerator(length);
            gamepage.ShowDialog();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox_Length != null)
            {
                Button_StartGame.IsEnabled = true;
            }

            length = ComboBox_Length.SelectedIndex + 3;

            if (length == 11)
            {
                Random rand = new Random();
                length = rand.Next(3, 11);
                int temp = length;
                temp.ToString();
                MessageBox.Show("Вам выпало слово длиной: " + temp);
            }
        }

            private void WordGenerator(int length)
        {
            List<string> neededwords = new List<string>();
            string pathtofile = @"../../words.txt";
            string[] allwords = File.ReadAllLines(pathtofile);

            for (int i = 0; i < allwords.Length; i++)
            {
                if (allwords[i].Length == length)
                {
                    neededwords.Add(allwords[i]);
                }
            }
            Random rand2 = new Random();
            int temp2 = rand2.Next(0, neededwords.Count + 1);
            hiddenword = neededwords.ElementAt(temp2);
        }

    }
}
