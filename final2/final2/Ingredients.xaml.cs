using System.Windows;

namespace final2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Ingredients : Window
    {
        public Ingredients()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Categories categories = new Categories();
            categories.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RecipeInstruction recipeInstruction = new RecipeInstruction();
            recipeInstruction.ShowDialog();
        }
    }
}
