using Avalonia.Controls;
using Mac_project.ViewModels;

namespace Mac_project.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = new MainWindowViewModel();
    }
}
