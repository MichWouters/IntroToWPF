namespace DBEX
{
    public class Pie
    {
        private string _name;

        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public override string ToString()
        {
            return Name.ToString();
        }

        private bool _isInStock;

        public bool IsInStock
        {
            get { return _isInStock; }
            set { _isInStock = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }


        public Pie(int id, string name, string description = "A yummie pie")
        {
            Id = id;
            Name = name;
            Image = "http://placekitten.com/50/50";
            IsInStock = false;
            Description = description;
            Price = 12.95;
        }
    }
}