using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using WK23012_Main.Views.Run_Screen;

namespace WK23012_Main.ViewModels.RunScreen
{
    class TabsControlVM : ObservableObject
    {
        public ObservableCollection<TabItem> TabItems { get; } = new ObservableCollection<TabItem>();

        public TabsControlVM()
        {
            AddTab("Home", new RunScreenHome());
            AddTab("Run Parameters", new RunParameters());
            AddTab("Error Message", new ErrorMessage());
            AddTab("GHSECSGEM", new GHSECSGEM());
            AddTab("Vacuum Profile", new VacuumProfile());
        }

        private void AddTab(string header, UserControl content)
        {
            TabItems.Add(new TabItem { Header = header, Content = content });
        }
    }
}
