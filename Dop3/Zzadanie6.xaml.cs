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
    /// Логика взаимодействия для Zzadanie6.xaml
    /// </summary>
    public partial class Zzadanie6 : Window
    {
        public Zzadanie6()
        {
            InitializeComponent();
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            ((Expander)sender).Content = new Button() { Width = 80, Height = 30, Content = "Privet" };
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Spander svernut");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zzadanie7 zzadanie7 = new Zzadanie7();
            zzadanie7.Show();
        }
    }
}
