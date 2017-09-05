namespace WpfApp1
{
    public class TabVM : BaseVM
    {
        private string _fieldA;
        private string _fieldB;

        public TabVM()
        {

        }

        public string FieldA
        {
            get
            {
                return _fieldA;
            }
            set
            {
                if (_fieldA != value)
                {
                    _fieldA = value;
                    OnPropertyChanged();
                }
            }
        }
        public string FieldB
        {
            get
            {
                return _fieldB;
            }
            set
            {
                if (_fieldB != value)
                {
                    _fieldB = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}