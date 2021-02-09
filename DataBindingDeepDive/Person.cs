using System.ComponentModel;

namespace DataBindingDeepDive
{
    // INotifyPropertyChanged is needed to send a nudge that an object has been updated
    // so the view can update the data
    public class Person : INotifyPropertyChanged
    {
        private string _name;
        private int _age;
        private string _residence;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;

                // Send out an event that this property has changed and needs updating in the Front-End
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                _age = value;
             
            }
        }

        public string Residence
        {
            get => _residence;
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