using System.Collections.Generic;
using System.Windows.Controls;

namespace WK23012_Main.Views.Run_Screen
{
    public partial class VacuumProfile : UserControl
    {
        public VacuumProfile()
        {
            InitializeComponent();

            // Initialize your ViewModel and set it as the DataContext
            DataContext = new VacuumProfileViewModel();
        }
    }

    public class VacuumProfileViewModel
    {
        public VacuumProfileViewModel()
        {
            // Initialize Line1 with your data
            Line1 = new List<Data>
            {
                new Data { Col = "N30U", Value = 18000 },
                // Add other data points as needed
            };
        }

        public List<Data> Line1 { get; set; }

        public class Data
        {
            public string Col { get; set; }
            public int Value { get; set; }
        }
    }
}
