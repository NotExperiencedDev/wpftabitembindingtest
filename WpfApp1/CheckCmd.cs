using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public class CheckCmd : ICommand
    {
        

        public CheckCmd()
        {
            
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var vm = parameter as TabVM;
            MessageBox.Show(vm?.FieldA + "  " + vm?.FieldB);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}