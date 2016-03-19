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
        int place = 1;
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
            List<ForListViewRecords> RecordsList = new List<ForListViewRecords>();
            
            while (!sr.EndOfStream)
            {
                string records = sr.ReadLine();
                recArray = records.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                RecordsList.Add(new ForListViewRecords { Место = place, Имя = recArray[0], Ходы = recArray[1], Слово = recArray[2], Дата = recArray[3] });
            }
            
            for (int i = 0; i < RecordsList.Count - 1; i++)
            {
                for (int j = i + 1; j < RecordsList.Count; j++)
                {
                    if (int.Parse(RecordsList[i].Ходы) > int.Parse(RecordsList[j].Ходы))
                    {
                        var temp = RecordsList[i];
                        RecordsList[i] = RecordsList[j];
                        RecordsList[j] = temp;
                    }
                    RecordsList[j].Место = place + 1;
                }
                place += 1;
            }

            foreach (ForListViewRecords forListViewRecords in RecordsList)
            {
                ListView_Records.Items.Add(forListViewRecords);
            }

            sr.Close();
            fs.Close();
        }
    }
}
