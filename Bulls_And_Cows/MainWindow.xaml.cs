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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bulls_And_Cows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            Rules rulepage = new Rules();
            rulepage.ShowDialog();
            this.Visibility = Visibility.Visible; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.Visibility = Visibility.Collapsed;
            Letters letterpage = new Letters();
            letterpage.ShowDialog();
            this.Visibility = Visibility.Visible; 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            Records recordspage = new Records();
            recordspage.RecordsShow();
            recordspage.ShowDialog();
            this.Visibility = Visibility.Visible; 
        }
    }
}
