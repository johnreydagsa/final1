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

namespace final2
{
    /// <summary>
    /// Interaction logic for Categories.xaml
    /// </summary>
    public partial class Categories : Window
    {
        public Categories()
        {
            InitializeComponent();
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ingredients ingre = new Ingredients();
            ingre.ShowDialog();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.ShowDialog();
            this.Close();
        }
    }
}
