using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace Mac_project.Views;

public partial class LoginView : Window
{
    public event EventHandler AuthenticationSuccess;
    public LoginView()
    {
        InitializeComponent();
        Loaded += Login_Loaded;
    }
    private void Login_Loaded(object sender, RoutedEventArgs e)
    {
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
        string password = txtPassword.Text;

        // Check if fields are empty
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            txtError.Text = "Username and password are required.";
            return;
        }

        AuthenticationService authService = new AuthenticationService();

        if (authService.IsValidUser(username, password))
        {
            // Raise the AuthenticationSuccess event
            AuthenticationSuccess?.Invoke(this, EventArgs.Empty);

            // Close the login window
            Close();
        }
        else
        {
            txtError.Text = "Invalid username or password. Try again.";
        }
    }
    // Minimize and Close buttons
    private void btnMinimize_Click(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
    public class AuthenticationService
    {
        public bool IsValidUser(string username, string password)
        {
            return username == "3s" && password == "1234";
        }
    }
}