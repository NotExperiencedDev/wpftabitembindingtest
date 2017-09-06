using System.Windows.Input;

namespace WpfApp1
{
    public class TabCtrlVM:BaseVM
    {
        private ICommand _cmd;
        private ICommand _modifyCmd;
        public TabCtrlVM()
        {
            _cmd = new CheckCmd();
            _modifyCmd = new ModifyFromBehindCmd();
        }

        public TabVM TabAVM { get; set; }
        public TabVM TabBVM { get; set; }
        public TabVM SelectedTab { get; set; }

        public ICommand CheckCmd
        {
            get { return _cmd; }
        }

        public ICommand ModifyCmd
        {
            get { return _modifyCmd; }
        }
    }
}