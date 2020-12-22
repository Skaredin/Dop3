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

namespace Dop3
{
    /// <summary>
    /// Логика взаимодействия для Zzadanie4.xaml
    /// </summary>
    public partial class Zzadanie4 : Window
    {
        public Zzadanie4()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            popup1.IsOpen = true;

        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            popup2.IsOpen = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadanie5 zadanie5 = new Zadanie5();
            zadanie5.Show();
        }
    }
}
