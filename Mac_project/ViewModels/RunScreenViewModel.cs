using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Mac_project.Models;

namespace Mac_project.ViewModels;

public class RunScreenViewModel : ViewModelBase
{
    private readonly ObservableCollection<VacuumOvenStatus> _vacuumOvenStatus;
    private readonly ObservableCollection<string> _errorMessages;
    public IEnumerable<VacuumOvenStatus> vacuumOvenStatus => _vacuumOvenStatus;
    public string errorMessages => String.Join("\r\n", _errorMessages);

    public RunScreenViewModel()
    {
        _vacuumOvenStatus = new ObservableCollection<VacuumOvenStatus>() {
            new VacuumOvenStatus(){ Name = "Main Air", isCheckAndReady = false, isDisable = false, isFailed = true  },
            new VacuumOvenStatus(){ Name = "Main Air", isCheckAndReady = true, isDisable = false, isFailed = false },
            new VacuumOvenStatus(){ Name = "Oven Power", isCheckAndReady = true, isDisable = false, isFailed = false },
            new VacuumOvenStatus(){ Name = "Oven Temperature", isCheckAndReady = false, isDisable = true, isFailed = false },
            new VacuumOvenStatus(){ Name = "Water Flow", isCheckAndReady = true, isDisable = false, isFailed = false },
            new VacuumOvenStatus(){ Name = "Water Temperature", isCheckAndReady = false, isDisable = false, isFailed = true },
            new VacuumOvenStatus(){ Name = "Filter Power", isCheckAndReady = false, isDisable = false, isFailed = true },
            new VacuumOvenStatus(){ Name = "Filter Flow", isCheckAndReady = false, isDisable = false, isFailed = true },
        };

        _errorMessages = new ObservableCollection<string> {
            $"system error {string.Format("{0:yyyy/MM/dd hh:mm:ss}", DateTime.Now)}",
            $"system error {string.Format("{0:yyyy/MM/dd hh:mm:ss}", DateTime.Now)}",
            $"system error {string.Format("{0:yyyy/MM/dd hh:mm:ss}", DateTime.Now)}",
            $"system error {string.Format("{0:yyyy/MM/dd hh:mm:ss}", DateTime.Now)}",
            $"system error {string.Format("{0:yyyy/MM/dd hh:mm:ss}", DateTime.Now)}",
            $"system error {string.Format("{0:yyyy/MM/dd hh:mm:ss}", DateTime.Now)}",
            $"system error {string.Format("{0:yyyy/MM/dd hh:mm:ss}", DateTime.Now)}",
            $"system error {string.Format("{0:yyyy/MM/dd hh:mm:ss}", DateTime.Now)}"
        };
    }
}
