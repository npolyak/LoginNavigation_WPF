using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace Mac_project.Views.RunScreen
{
    public partial class main : UserControl
    {
        public main()
        {
            InitializeComponent();
        }

        private void OnRunParametersClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.IsEnabled = false;

            var parametersWindow = new Window
            {
                Content = new Parameters(),
                SizeToContent = SizeToContent.WidthAndHeight,
                CanResize = false,
            };

            parametersWindow.Closed += (s, args) =>
            {
                this.IsEnabled = true;
            };

            parametersWindow.Show();
        }

        private void GHSECSGEMClick(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            var GHSECSGEMWindow = new Window
            {
                Content = new GHSECSGEM(),
                SizeToContent = SizeToContent.WidthAndHeight,
                CanResize = false,
            };

            GHSECSGEMWindow.Closed += (s, args) =>
            {
                this.IsEnabled = true;
            };

            GHSECSGEMWindow.Show();
        }
    }
}
