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

namespace final2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// harry
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Categories category = new Categories();
            this.Close();
            category.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Savedrecipe saved = new Savedrecipe();
            this.Close();
            saved.ShowDialog();
            //
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string name = recipename.Text;
            if (name.ToUpper().Equals("CHOCOLATE CHIP"))
            {
                RecipeInstruction  recipe = new RecipeInstruction();
                this.Close();
                recipe.ShowDialog();

            }
        }

        private void Button_Click_3(object sender,  RoutedEventArgs e)
        {

        }
    }
}
