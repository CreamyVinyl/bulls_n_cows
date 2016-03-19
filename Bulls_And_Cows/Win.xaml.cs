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
            FileStream fs = new FileStream("../../records.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("{0} {1} {2} {3}", TextBox_Name.Text, Game.moves, Letters.hiddenword, DateTime.Now);
            sw.Close();
            fs.Close();
            Records recordpage = new Records();
            recordpage.RecordsShow();
            recordpage.ShowDialog();
            this.Close();
        }

        private void TextBox_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBox_Name.Text.Length != 0)
            {
                Button_OK.IsEnabled = true;
            }
        }
    }
}
