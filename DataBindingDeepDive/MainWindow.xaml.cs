using System.Windows;

namespace DataBindingDeepDive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person myFriendInCodeBehind;

        public MainWindow()
        {
            InitializeComponent();
            myFriendInCodeBehind = new Person
            {
                Age = 24,
                Name = "Dave",
                Residence = "Jakkamakka"
            };

            // Set binding in code-behind
            myStackPanel.DataContext = myFriendInCodeBehind;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myFriendInCodeBehind.Name = "I have been changed";
            myFriendInCodeBehind.Age = 42;
            myFriendInCodeBehind.Residence = "London";
        }
    }
}