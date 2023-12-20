using Mac_project.Views.RunScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mac_project.ViewModels
{
    public interface RunParametersDialog
    {
        void ShowDialog(string name);
    }
    public class ModalScreenViewModel : RunParametersDialog
    {
        public void ShowDialog(string name) 
        {
            var dialog = new Parameters();

            var type = Type.GetType($"Dialog.{name}");

            dialog.Content = Activator.CreateInstance(type);

            dialog.ShowDialog();
        }
    }
}
