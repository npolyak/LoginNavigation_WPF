using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Mac_project.ViewModels;
using Mac_project.Views;

namespace Mac_project;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var mainWindow = new MainWindow();

            mainWindow.DataContext = new MainWindowViewModel();

            // Show the mainWindow
            mainWindow.Show();

            // Show the login window
            desktop.MainWindow = mainWindow;
        }

        base.OnFrameworkInitializationCompleted();
    }


}
