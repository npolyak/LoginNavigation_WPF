using System.Windows;
using System.Windows.Controls;

namespace WK23012_Main.Views.ModuleViews
{
    public partial class numericUpDown : UserControl
    {
        public numericUpDown()
        {
            InitializeComponent();
        }

        private void IncreaseValue(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NumericTextBox.Text, out int value))
            {
                value++;
                NumericTextBox.Text = value.ToString();
            }
        }

        private void DecreaseValue(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NumericTextBox.Text, out int value) && value > 0)
            {
                value--;
                NumericTextBox.Text = value.ToString();
            }
        }

    }
}
