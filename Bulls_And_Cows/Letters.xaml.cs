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
        public static string length;
        public Letters()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // IS ENABLED!! 
            
            this.Close();
            Game gamepage = new Game();
            gamepage.ShowDialog();
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            length = ComboBox.SelectedItemProperty.ToString();
            if (length == "Случайно")
            {
                Random rand = new Random();
                length = rand.Next(3, 11).ToString();
            }
        }

        
    }
}
