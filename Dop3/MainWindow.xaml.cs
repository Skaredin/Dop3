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

namespace Dop3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckBox checkBox = new CheckBox {Content="New flag (Нажмите на меня следующее зд)", MinHeight=20, IsChecked=false};
            checkBox.Checked += Ceke1_Checked;
            Sp1.Children.Add(checkBox);

        }

        private void Ceke1_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Ceke1.Content.ToString() + "V neopredelennosti sostoanii");
        }

        private void Ceke1_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            
            if(chBox.IsChecked == true)
            {
                MessageBox.Show(chBox.Content.ToString() + "Otmecen");
                this.Hide();
                Zadanie1 zadanie1 = new Zadanie1();
                zadanie1.Show();
            
            
            }

           
        }

        private void Ceke1_Unchecked(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(Ceke1.Content.ToString()+"Ne otmecen");
        }
    }
}
