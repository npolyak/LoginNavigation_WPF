using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace WK23012_Main.Views
{
    public partial class SystemV : UserControl
    {
        public SystemV()
        {
            InitializeComponent();

            // Dummy data
            List<User> users = new List<User>
        {
            new User { Username = "Reg", Roles = new List<string> { "Admin"}, Actions = new List<string> { "Edit", "Delete" } },
            new User { Username = "Kerl", Roles = new List<string> { "Engineer"}, Actions = new List<string> { "Edit", "Delete" } },
            new User { Username = "Carlos", Roles = new List<string> { "Technician"}, Actions = new List<string> { "Edit", "Delete" } },
            new User { Username = "3s", Roles = new List<string> { "Operator"}, Actions = new List<string> { "Edit", "Delete" } },
        };

            userListView.ItemsSource = users;
        }

        private void GridViewColumnHeader_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }

    public class User
    {
        public string Username { get; set; }
        public List<string> Roles { get; set; }
        public List<string> Actions { get; set; }
    }
}