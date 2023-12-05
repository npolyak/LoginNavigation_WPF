using CommunityToolkit.Mvvm.ComponentModel;
using Mac_project.ViewModels;

namespace Mac_project.ViewModels;

public partial class ValueSelectionPageViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isValueSelectionEnabled = true;

    [ObservableProperty]
    private int _sliderValue;
}