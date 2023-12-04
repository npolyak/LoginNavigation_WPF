using System.Windows.Input;

namespace Mac_project.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    //Fields
    private ViewModelBase _currentChildView;
    private string _caption;

    public ViewModelBase CurrentChildView
    {
        get
        {
            return _currentChildView;
        }

        set
        {
            _currentChildView = value;
            OnPropertyChanged(nameof(CurrentChildView));
        }
    }

    public string Caption
    {
        get
        {
            return _caption;
        }

        set
        {
            _caption = value;
            OnPropertyChanged(nameof(Caption));
        }
    }

    //--> Commands
    public ICommand ShowHomeViewCommand { get; }
    public ICommand ShowSystemViewCommand { get; }
    public ICommand ShowRunScreenViewCommand { get; }
    public ICommand ShowModuleViewCommand { get; }
    public ICommand ShowDiagnosticViewCommand { get; }
    public ICommand ShowOvenMapViewCommand { get; }

    public MainWindowViewModel()
    {

        //Initialize commands
        ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
        ShowSystemViewCommand = new ViewModelCommand(ExecuteShowSystemViewCommand);
        ShowModuleViewCommand = new ViewModelCommand(ExecuteModuleViewCommand);
        ShowRunScreenViewCommand = new ViewModelCommand(ExecuteShowRunScreenCommand);
        ShowDiagnosticViewCommand = new ViewModelCommand(ExecuteDiagnosticViewCommand);

        //Default view
        ExecuteShowHomeViewCommand(null);
    }

    private void ExecuteShowHomeViewCommand(object obj)
    {
        CurrentChildView = new Dashboard();
        Caption = "Home";
    }

    private void ExecuteShowSystemViewCommand(object obj)
    {
        CurrentChildView = new SystemViewModel();
        Caption = "System";
    }

    private void ExecuteShowRunScreenCommand(object obj)
    {
        CurrentChildView = new RunScreenViewModel();
        Caption = "Run Screen";
    }

    private void ExecuteModuleViewCommand(object obj)
    {
        CurrentChildView = new ModuleViewModel();
        Caption = "Module";
    }

    private void ExecuteDiagnosticViewCommand(object obj)
    {
        CurrentChildView = new DiagnosticViewModel();
        Caption = "Diagnostic";
    }
}