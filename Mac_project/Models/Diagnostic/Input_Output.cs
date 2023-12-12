
namespace Mac_project.Models.Diagnostic
{
    public class Input_Output
    {
        public string ModuleName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }

        public Input_Output(string moduleName, string name, string address, bool status)
        {
            ModuleName = moduleName;
            Name = name;
            Address = address;
            Status = status;
        }
    }
}
