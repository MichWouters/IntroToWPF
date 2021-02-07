using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBindingExample
{
    /// <summary>
    /// Interaction logic for CollectionExample.xaml
    /// </summary>
    public partial class CollectionExample : Window
    {
        IList<Person> myFriendsBack;
        public CollectionExample()
        {
            InitializeComponent();
            myFriendsBack = new ObservableCollection<Person>
            {
                new Person{Name = "Michiel", Age = 33, Hobbies = "Gaming"},
                new Person{Name = "Dirk", Age = 39, Hobbies = "Cooking"},
                new Person{Name = "Suzy", Age = 24, Hobbies = "Jogging"},
                new Person{Name = "Dave", Age = 26, Hobbies = "Wakeboarding"},
            };

            this.DataContext = myFriendsBack;


        }
    }
}
