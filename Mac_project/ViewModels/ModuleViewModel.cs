using System.Collections.ObjectModel;
using System;

namespace Mac_project.ViewModels
{
    public class ModuleViewModel : ViewModelBase
    {
        private readonly ObservableCollection<string> _errorMessages;
        public string errorMessages => String.Join("\r\n", _errorMessages);


    }
}
