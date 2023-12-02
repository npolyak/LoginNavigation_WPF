using System.Windows;
using System.Windows.Controls;

namespace WK23012_Main.Views.ModuleViews
{
    public partial class numericUpDown : UserControl
    {
        public numericUpDown()
        {
            InitializeComponent();
            txtNum.Text = _numValue.ToString();
        }

        private int _numValue = 0;
        public int NumValue
        {
            get { return _numValue; }
            set
            {
                if (value >= 0)
                {
                    _numValue = value;
                    txtNum.Text = value.ToString();
                }
            }
        }

        private void CmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void CmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        private void TxtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue))
                txtNum.Text = _numValue.ToString();
        }

    }
}
