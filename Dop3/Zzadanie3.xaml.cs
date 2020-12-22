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
    /// Логика взаимодействия для Zzadanie3.xaml
    /// </summary>
    public partial class Zzadanie3 : Window
    {
        public Zzadanie3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zzadanie4 zzadanie4 = new Zzadanie4();
            zzadanie4.Show();
        }
    }
}
