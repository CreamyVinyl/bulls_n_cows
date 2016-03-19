using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class ForListViewRecords
    {
        public int Место { get; set; }
        public string Имя { get; set; }
        public string Ходы { get; set; }
        public string Слово { get; set; }
        public string Дата { get; set; }
    }
    /// <summary>
    /// Interaction logic for Records.xaml
    /// </summary>
    public partial class Records : Window
    {
        int place;
        public Records()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void RecordsShow()
        {
            FileStream fs = new FileStream("../../records.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string[] recArray = new string[5];
            while (!sr.EndOfStream)
            {
                place += 1;
                string records = sr.ReadLine();
                recArray = records.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                ListView_Records.Items.Add(new ForListViewRecords { Место = place, Имя = recArray[0], Ходы = recArray[1], Слово = recArray[2], Дата = recArray[3] });
            }
        }
    }
}
