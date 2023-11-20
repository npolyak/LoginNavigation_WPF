using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK23012_Main.Models.Diagnostic
{
    class InputModel
    {
        public string ModuleName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public bool Invert { get; set; }
        public string Vender { get; set; }

        //public string FullInput => $"{ModuleName}, {Name}, {Address}, {Status}, {Invert}, {Vender}";
        public string FullInput => $"{ModuleName} {Name}";
    }

}
