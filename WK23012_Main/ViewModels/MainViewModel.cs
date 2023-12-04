using FontAwesome.Sharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WK23012_Main.Views;

namespace WK23012_Main.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //Fields
        private ViewModelBase _currentChildView;
        private string _caption;
        private IconChar _icon;

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

        public IconChar Icon
        {
            get
            {
                return _icon;
            }

            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }

        //--> Commands
        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowSystemViewCommand { get; }
        public ICommand ShowRunScreenViewCommand { get; }
        public ICommand ShowModuleViewCommand { get; }
        public ICommand ShowDiagnosticViewCommand { get; }
        public ICommand ShowOvenMapViewCommand { get; }

        public MainViewModel()
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
            CurrentChildView = new HomeViewModel();
            Caption = "Home";
            Icon = IconChar.Home;
        }

        private void ExecuteShowSystemViewCommand(object obj)
        {
            CurrentChildView = new SystemViewModel();
            Caption = "System";
            Icon = IconChar.Display;
        }

        private void ExecuteShowRunScreenCommand(object obj)
        {
            CurrentChildView = new RunScreenViewModel();
            Caption = "Run Screen";
            Icon = IconChar.Brain;
        }

        private void ExecuteModuleViewCommand(object obj)
        {
            CurrentChildView = new ModuleViewModel();
            Caption = "Module";
            Icon = IconChar.Cubes;
        }

        private void ExecuteDiagnosticViewCommand(object obj)
        {
            CurrentChildView = new DiagnosticViewModel();
            Caption = "Diagnostic";
            Icon = IconChar.Stethoscope;
        }
    }
}