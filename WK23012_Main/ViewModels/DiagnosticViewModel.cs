using System.Collections.ObjectModel;

namespace WK23012_Main.ViewModels
{
    public class DiagnosticViewModel : ViewModelBase
    {
        public ObservableCollection<InputModel> InputData { get; set; }

        public DiagnosticViewModel()
        {
            InputData = new ObservableCollection<InputModel>();

            // Add dummy data
            for (int i = 1; i <= 10; i++)
            {
                InputData.Add(new InputModel
                {
                    //ID = i,
                    ModuleName = $"Module{i}",
                    Name = $"Name{i}",
                    Address = $"Address{i}",
                    Status = i % 2 == 0, // Just alternating true/false for demonstration
                    Vendor = $"Vendor{i}"
                });
            }
        }
    }

    public class InputModel
    {
        //public int ID { get; set; }
        public string? ModuleName { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public bool Status { get; set; }
        public string? Vendor { get; set; }

    }
}
