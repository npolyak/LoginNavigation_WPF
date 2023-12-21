using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace Mac_project.Views.RunScreen;

public partial class Parameters : UserControl
{
    public Parameters()
    {
        InitializeComponent();
    }

    private void btnClose(object sender, RoutedEventArgs e)
    {
        var window = this.Parent as Window;
        window.Close();
    }
}