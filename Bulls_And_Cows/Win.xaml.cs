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
    /// Логика взаимодействия для Win.xaml
    /// </summary>
    public partial class Win : Window
    {
        public Win()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] info = { TextBox_Name.Text, (Game.moves).ToString(), Letters.hiddenword, (DateTime.Now).ToString() };
            File.WriteAllLines("../../records.txt", info);
            Records recordpage = new Records();
            recordpage.ShowDialog();
            this.Close();
        }
    }
}
