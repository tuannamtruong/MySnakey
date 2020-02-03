using System;
using System.Windows.Input;

namespace MySnakey.Common
{
    public class DelegateCommand : ICommand
    {
        #region Fields

        private Action<object> execute;
        private Func<object, bool> canExecute;

        #endregion

        #region Events

        public event EventHandler CanExecuteChanged;

        #endregion

        #region Constructors

        public DelegateCommand(Action<object> execute)
        {
            this.execute = execute;
            this.canExecute = (x) => { return true; };
        }
        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        #endregion Constructors

        #region Methods

        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        #endregion Methods

    }
}
