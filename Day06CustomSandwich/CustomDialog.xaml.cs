using System.Collections.Generic;
using System.Windows;

namespace Day06CustomSandwich
{
    /// <summary>
    /// Interaction logic for CustomDialog.xaml
    /// </summary>
    public partial class CustomDialog : Window
    {
        private MainWindow mainWindow;

        public CustomDialog()
        {
            InitializeComponent();
        }

        public CustomDialog(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            if (-1 == cmbBreadType.SelectedIndex)
            {
                MessageBox.Show(this, "Bread must be selected", "Operation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string bread = cmbBreadType.Text;
            List<string> vegetablesList = new List<string>();
            if (true == cbLettuces.IsChecked)
            {
                vegetablesList.Add("Lettuces");
            }
            if (true == cbTomatoes.IsChecked)
            {
                vegetablesList.Add("Tomatoes");
            }
            if (true == cbCucumbers.IsChecked)
            {
                vegetablesList.Add("Cucumbers");
            }
            string vegetables = string.Join(";", vegetablesList);
            string meats;
            if (true == rbChicken.IsChecked)
            {
                meats = "Chicken";
            }
            else if (true == rbTurkey.IsChecked)
            {
                meats = "Turkey";
            }
            else if (true == rbTofu.IsChecked)
            {
                meats = "Tofu";
            }
            else
            {
                MessageBox.Show(this, "Meats must be selected", "Internal Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            mainWindow.setValues(bread, vegetables, meats);
            this.DialogResult = true;
        }
    }
}