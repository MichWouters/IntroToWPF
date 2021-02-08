using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingDeepDive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person myFriendInCodeBehind;

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
    }
}
