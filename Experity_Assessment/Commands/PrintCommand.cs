using Experity_Assessment.ViewModels;
using System;

namespace Experity_Assessment.Commands
{
    public class PrintCommand : CommandBase
    {
        private Action<object> _execute;
        private EventViewModel _eventViewModel;

        public PrintCommand(Action<object> execute, EventViewModel eventViewModel) : base(execute)
        {
            _execute = execute;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
