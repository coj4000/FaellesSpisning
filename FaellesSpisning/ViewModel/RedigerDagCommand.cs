using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaellesSpisning.ViewModel
{
    public class RedigerDagCommand
    {
        private readonly Action execute;

        public event EventHandler CanExecuteChanged;

        public RedigerDagCommand(Action execute)
        {
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute();
        }
    }
}
