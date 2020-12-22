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
    /// Логика взаимодействия для Zzadanie8.xaml
    /// </summary>
    public partial class Zzadanie8 : Window
    {
        public Zzadanie8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineUp();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            scroll.LineDown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();

            Zzadanie9 zzadanie9 = new Zzadanie9();
            zzadanie9.Show();
        }
    }
}
