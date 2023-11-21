using System.Windows;
using System.Windows.Input;

namespace WK23012_Main.Views
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            Loaded += Login_Loaded; // Attach the event handler when the window is loaded
        }

        private void Login_Loaded(object sender, RoutedEventArgs e)
        {
            // Set the focus to the txtUser TextBox when the window is loaded
            txtUser.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AttemptLogin();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AttemptLogin();
        }

        private void AttemptLogin()
        {
            string username = txtUser.Text;
            string password = txtPass.Password;

            // Check if fields are empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                txtError.Text = "Username and password are required.";
                return;
            }

            AuthenticationService authService = new AuthenticationService();

            if (authService.IsValidUser(username, password))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                txtError.Text = "Invalid username or password. Try again.";
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

    public class AuthenticationService
    {
        public bool IsValidUser(string username, string password)
        {
            return username == "3s" && password == "1234";
        }
    }
}
