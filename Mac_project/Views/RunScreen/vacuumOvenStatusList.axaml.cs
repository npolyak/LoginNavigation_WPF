using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Mac_project.ViewModels;

namespace Mac_project.Views.RunScreen;

public partial class vacuumOvenStatusList : UserControl
{
    public vacuumOvenStatusList()
    {
        InitializeComponent();
        DataContext = new RunScreenViewModel();
    }
}
