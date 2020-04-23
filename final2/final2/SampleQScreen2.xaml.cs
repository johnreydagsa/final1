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
    /// Interaction logic for SampleQScreen2.xaml
    /// </summary>
    public partial class SampleQScreen2 : Window
    {
        public SampleQScreen2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SampleQScreen1 sample1 = new SampleQScreen1();
            this.Close();
            sample1.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RecommendedRecipes recommended = new RecommendedRecipes();
            this.Close();
            recommended.ShowDialog();
        }
    }
}
