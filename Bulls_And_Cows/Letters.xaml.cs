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
    public partial class Letters : Window // выровнять окно по центру
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
    }
}
