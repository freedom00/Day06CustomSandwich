using System.Windows;

namespace Day06CustomSandwich
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btMakeASandwich_Click(object sender, RoutedEventArgs e)
        {
            new CustomDialog(this).ShowDialog();
        }

        public void setValues(string bread, string vegetables, string meats)
        {
            lblBread.Content = bread;
            lblVegetables.Content = vegetables;
            lblMeats.Content = meats;
        }
    }
}