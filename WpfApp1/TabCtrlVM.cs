using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public class TabCtrlVM:BaseVM
    {
        private ICommand _cmd;
        public TabCtrlVM()
        {
            _cmd = new CheckCmd();
        }

        public TabVM TabAVM { get; set; }
        public TabVM TabBVM { get; set; }
        public TabVM SelectedTab { get; set; }

        public ICommand CheckCmd
        {
            get { return _cmd; }
            set
            {
                if(_cmd != value)
                    _cmd = value;
            }
        }
    }

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