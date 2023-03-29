using System;
using System.Windows.Input;

namespace Experity_Assessment.Commands
{
    public abstract class CommandBase : ICommand
    {
        private Action<object> _execute;
        public event EventHandler CanExecuteChanged;

        public CommandBase(Action<object> execute)
        {
            _execute = execute;
        }

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);

    }
}
