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

namespace Panels_1___Verwachte_lengte
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            float length;
            // Controle juistheid van gegevens.
            bool testlengthFather = float.TryParse(lengthFatherTextBox.Text, out float lengthFather);
            bool testlengthMother = float.TryParse(lengthMotherTextBox.Text, out float lengthMother);
            if (!testlengthFather || !testlengthMother)
            {
                MessageBox.Show("Geef een correcte lengte voor vader en moeder op!",
                    "Foute invoer",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (girlRadioButton.IsChecked == true)
            {
                length = ((lengthFather + lengthMother - 13) / 2) + 4.5f;
                lengthGirlTextBox.Text = length.ToString();
            }
            else
            {
                length = ((lengthFather + lengthMother + 13) / 2) + 4.5f;
                lengthBoyTextBox.Text = length.ToString();
            }

            lengthMotherTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void girlRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            lengthGirlTextBox.IsEnabled = true;
            lengthBoyTextBox.IsEnabled = false;
            lengthBoyTextBox.Clear();
        }
        private void boyRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            lengthBoyTextBox.IsEnabled = true;
            lengthGirlTextBox.IsEnabled = false;
            lengthGirlTextBox.Clear();
        }
    }
}