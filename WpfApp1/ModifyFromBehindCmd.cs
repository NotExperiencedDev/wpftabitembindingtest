using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public class ModifyFromBehindCmd : ICommand
    {
        static int _incr;
        public ModifyFromBehindCmd()
        {

        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            TabVM vm;
            if ((vm = parameter as TabVM) != null)
            {
                vm.FieldA += _incr++;
                vm.FieldB += _incr++;
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}