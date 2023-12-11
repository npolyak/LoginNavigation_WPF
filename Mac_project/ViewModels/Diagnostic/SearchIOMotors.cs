using ReactiveUI;

namespace Mac_project.ViewModels.Diagnostic
{
    public class SearchIOMotors : ViewModelBase
    {
        private string? _searchText;
        private bool _isBusy;

        public string? SearchText
        {
            get => _searchText;
            //set => this.RaiseAndSetIfChanged(ref _searchText, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            //set => this.RaiseAndSetIfChanged(ref _isBusy, value);
        }

    }
}
