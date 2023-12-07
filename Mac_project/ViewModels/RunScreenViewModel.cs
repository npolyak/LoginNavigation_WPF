using System.Collections.Generic;
using System.Collections.ObjectModel;
using Mac_project.Models;

namespace Mac_project.ViewModels;

public class RunScreenViewModel : ViewModelBase
{
    private readonly ObservableCollection<VacuumOvenStatus> _vacuumOvenStatus;
    public IEnumerable<VacuumOvenStatus>  vacuumOvenStatus => _vacuumOvenStatus;

    public RunScreenViewModel() {
        _vacuumOvenStatus = new ObservableCollection<VacuumOvenStatus>() {
            new VacuumOvenStatus(){ Name = "Main Air", isOn = false },
            new VacuumOvenStatus(){ Name = "Main Air", isOn = false },
            new VacuumOvenStatus(){ Name = "Oven Power", isOn = true },
            new VacuumOvenStatus(){ Name = "Oven Temperature", isOn = true },
            new VacuumOvenStatus(){ Name = "Water Flow", isOn = false },
            new VacuumOvenStatus(){ Name = "Water Temperature", isOn = true },
            new VacuumOvenStatus(){ Name = "Filter Power", isOn = true },
            new VacuumOvenStatus(){ Name = "Filter Flow", isOn = false },
        };
    }
}

