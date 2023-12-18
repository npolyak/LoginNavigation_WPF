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
            var loginWindow = new LoginView();
            var mainWindow = new MainWindow();

            // Handle the AuthenticationSuccess event
            loginWindow.AuthenticationSuccess += (sender, args) =>
            {
                // Set the DataContext of the MainWindow to a new instance of MainWindowViewModel
                mainWindow.DataContext = new MainWindowViewModel();

                // Show the mainWindow
                mainWindow.Show();

                // Set the mainWindow as the desktop's MainWindow
                desktop.MainWindow = mainWindow;

                // Close the login window
                loginWindow.Close();
            };

            // Show the login window
            desktop.MainWindow = loginWindow;
            loginWindow.Show();

            // Close the login window when the main window is closed
            mainWindow.Closed += (sender, args) => loginWindow.Close();
        }

        base.OnFrameworkInitializationCompleted();
    }


}
