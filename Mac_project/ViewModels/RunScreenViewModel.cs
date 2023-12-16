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
            new VacuumOvenStatus(){ Name = "Filter Power", isCheckAndReady = true, isDisable = false, isFailed = false },
            new VacuumOvenStatus(){ Name = "Heater Current", isCheckAndReady = true, isDisable = false, isFailed = false },
            new VacuumOvenStatus(){ Name = "Bonder Ready", isCheckAndReady = false, isDisable = true, isFailed = false },
            new VacuumOvenStatus(){ Name = "Oven Power", isCheckAndReady = true, isDisable = false, isFailed = false },
            new VacuumOvenStatus(){ Name = "Filter Flow", isCheckAndReady = false, isDisable = false, isFailed = true },
            new VacuumOvenStatus(){ Name = "O2 Content", isCheckAndReady = false, isDisable = false, isFailed = true },
            new VacuumOvenStatus(){ Name = "Oven Ready", isCheckAndReady = false, isDisable = false, isFailed = true },

            new VacuumOvenStatus(){ Name = "Oven Temperature", isCheckAndReady = false, isDisable = false, isFailed = true  },
            new VacuumOvenStatus(){ Name = "Nitrogen Pressure", isCheckAndReady = true, isDisable = false, isFailed = false },
            new VacuumOvenStatus(){ Name = "Door Sensor", isCheckAndReady = true, isDisable = false, isFailed = false },
            new VacuumOvenStatus(){ Name = "Request Unload", isCheckAndReady = false, isDisable = true, isFailed = false },
            new VacuumOvenStatus(){ Name = "Water Flow", isCheckAndReady = true, isDisable = false, isFailed = false },
            new VacuumOvenStatus(){ Name = "Nitrogen Low Flow", isCheckAndReady = false, isDisable = false, isFailed = true },
            new VacuumOvenStatus(){ Name = "Test", isCheckAndReady = false, isDisable = false, isFailed = true },
            new VacuumOvenStatus(){ Name = "Receive Ready", isCheckAndReady = false, isDisable = false, isFailed = true },
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
