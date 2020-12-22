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
    /// Логика взаимодействия для Zzadanie7.xaml
    /// </summary>
    public partial class Zzadanie7 : Window
    {
        public Zzadanie7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zzadanie8 zzadanie8 = new Zzadanie8();
            zzadanie8.Show();
        }
    }
}
