using System.Windows;

namespace DataBindingExample
{
    /// <summary>
    /// Interaction logic for CodeBehindBinding.xaml
    /// </summary>
    public partial class CodeBehindBinding : Window
    {
        private Person person;

        public CodeBehindBinding()
        {
            InitializeComponent();
            person = new Person
            {
                Age = 33,
                Name = "Michiel",
                Hobbies = "Gaming",
            };

            MyStackPanel.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.Name = "Changed from code behind";
            person.Age = 12;
        }
    }
}