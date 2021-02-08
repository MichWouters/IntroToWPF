namespace DataBindingDeepDive
{
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _residence;

        public string Residence
        {
            get { return _residence; }
            set { _residence = value; }
        }
    }
}