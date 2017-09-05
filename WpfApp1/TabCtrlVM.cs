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
}