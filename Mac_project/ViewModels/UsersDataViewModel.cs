using Mac_project.Models.System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mac_project.ViewModels
{
    public class UsersDataViewModel : ViewModelBase
    {
        public ObservableCollection<displayUsers> FileUserDisplay { get; }

        public UsersDataViewModel()
        {
            var userdisplay = new List<displayUsers>
            {
                new displayUsers("Neil", "Armstrong", "Technician"),
                new displayUsers("Buzz", "Lightyear", "Technician"),
                new displayUsers("James", "Kirk", "Admin"),
                new displayUsers("Carlos", "Jarquin", "Engineer"),
                new displayUsers("Kerling", "Washington", "Admin"),
                new displayUsers("Claire", "Darce", "Admin"),
                new displayUsers("Regina", "Support", "Engineer"),
                new displayUsers("Mayra", "Jarquin", "Technician"),
                new displayUsers("Lionel", "Messi", "Engineer"),
                new displayUsers("Carles", "Puyol", "Technician"),
                new displayUsers("Ronaldinho", "Gaucho", "Admin"),
                new displayUsers("Neymar", "Jr", "Engineer"),
            };
            FileUserDisplay = new ObservableCollection<displayUsers>(userdisplay);
        }
    }
}
