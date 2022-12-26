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

namespace _26_12_2022_Tab_control
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> colors = new List<string>() { "Красный", "Зеленый", "Синий" };
        List<string> sity = new List<string>() { "Москва", "Новокузнецк", "Сочи" };
        List<string> Games = new List<string>() { "Ведьмак", "Дота", "Call of Duty" };
        public MainWindow()
        {
           

            InitializeComponent();
            appData();
        }
        private void appData() 
        {
            Listbox1.ItemsSource = colors;
            Listbox2.ItemsSource = sity;
            Listbox3.ItemsSource = Games;
        }
    }
}
