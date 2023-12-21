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
                new Input_Output("MainFrame", "MF_RunStart", "00100", false),
                new Input_Output("MainFrame", "MF_RunStop", "00101", true),
                new Input_Output("MainFrame", "MF_MainAirSensor", "00933", true),
                new Input_Output("MainFrame", "MF_WaterFlowSensor", "0002", true),
                new Input_Output("MainFrame", "MF_OvenOnSensor", "00920", true),
                new Input_Output("MainFrame", "MF_OvenThermoAlarm", "00916", true),
                new Input_Output("MainFrame", "MF_HeaterCurrentAlarm", "00917", true),
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
