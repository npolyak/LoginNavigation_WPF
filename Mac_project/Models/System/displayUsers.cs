
using System;

namespace Mac_project.Models.System
{
    public class displayUsers
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string Action { get; set; }


        public displayUsers(string userName, string role, string action)
        {
            Username = userName;
            Role = role;
            Action = action;
        }
    }

}
