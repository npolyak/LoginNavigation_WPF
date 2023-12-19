using System.Collections.Generic;
using System.Collections.ObjectModel;
using Mac_project.Models.Diagnostic;

namespace Mac_project.ViewModels
{
    public class DiagnosticViewModel : ViewModelBase
    {
        //Input, Outputs and Motors List
        public ObservableCollection<Input_Output> IOMotors { get; }

        public DiagnosticViewModel()
        {
            var iomotors = new List<Input_Output>
            {
                new Input_Output("Neil", "Armstrong", "0001", false),
                new Input_Output("Buzz", "Lightyear", "6070", true),
                new Input_Output("James", "Kirk", "7040", true),
                new Input_Output("Carlos", "Jarquin", "0002", true),
                new Input_Output("Kerling", "Washington", "1212", true),
                new Input_Output("Claire", "Darce", "1010", true),
                new Input_Output("Regina", "Support", "1001", true),
                new Input_Output("Mayra", "Jarquin", "1110", true),
                new Input_Output("Lionel", "Messi", "1101", true),
                new Input_Output("Carles", "Puyol", "9001", true),
                new Input_Output("Ronaldinho", "Gaucho", "9999", true),
                new Input_Output("Neymar", "Jr", "9990", true),
            };
            IOMotors = new ObservableCollection<Input_Output>(iomotors);
        }
    }
}
