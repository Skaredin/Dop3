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
    /// Логика взаимодействия для Zadanie1.xaml
    /// </summary>
    public partial class Zadanie1 : Window
    {
        public Zadanie1()
        {
            InitializeComponent();

            RadioButton radioButton = new RadioButton {IsChecked=true, GroupName= "LP", Content="JS"};
            Sp1.Children.Add(radioButton);
            radioButton.Checked += RadioButton_Checked;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            MessageBox.Show(rb.Content.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zzadanie3 zzadanie3 = new Zzadanie3();
            zzadanie3.Show();
        }
    }
}
