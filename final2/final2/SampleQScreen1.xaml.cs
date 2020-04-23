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
    /// Interaction logic for SampleQScreen1.xaml
    /// </summary>
    public partial class SampleQScreen1 : Window
    {
        public SampleQScreen1()
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
            guidequestioninstruction guide = new guidequestioninstruction();
            this.Close();
            guide.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SampleQScreen2 sample2 = new SampleQScreen2();
            this.Close();
            sample2.ShowDialog();
        }
    }
}
