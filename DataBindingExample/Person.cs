using System.ComponentModel;

namespace DataBindingExample
{
    public class Person : INotifyPropertyChanged
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string Hobbies { get; set; }

        public override string ToString()
        {
            return name.ToString(); 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}