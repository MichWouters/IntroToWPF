using System.ComponentModel;

namespace DataBindingDeepDive
{
    // INotifyPropertyChanged is needed to send a nudge that an object has been updated
    // so the view can update the data
    public class Person : INotifyPropertyChanged
    {
        private string _name;

        public MyEnum myEnum { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;

                // Send out an event that this property has changed and needs updating in the Front-End
                OnPropertyChanged();
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        private string _residence;

        public string Residence
        {
            get { return _residence; }
            set
            {
                _residence = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public enum MyEnum
    {
        Some,
        Random,
        Value,
    }
}