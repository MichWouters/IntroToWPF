using DataBindingDeepDive.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DataBindingDeepDive
{
    public partial class PieOverview : Window
    {
        public ObservableCollection<Pie> pies;

        public PieOverview()
        {
            InitializeComponent();
            pies = GetPies();
            PieOverViewList.ItemsSource = pies;
        }

        private ObservableCollection<Pie> GetPies()
        {
            var result = new ObservableCollection<Pie>
            {
                new Pie(1,"Franchipane"),
                new Pie(2,"Aardbeien"),
                new Pie(3,"Crumble"),
                new Pie(4,"American Pie"),
                new Pie(5,"Cheesecake"),
                new Pie(6,"Apple Pie"),
                new Pie(7,"Smurfentaart"),
                new Pie(8,"Confituurtaart"),
            };

            return result;
        }

        private void AddPie_Click(object sender, RoutedEventArgs e)
        {
            pies.Add(new Pie(9, "Rabarber"));
        }

        private void ListViewItem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Extract selected Pie from ListView
            var listItem = sender as ListViewItem;
            Pie pie = listItem.Content as Pie;

            //Pie selectedPie = pies.FirstOrDefault(pie => pie.ID == 5);

            if (pie != null)
            {
                var detailView = new PieDetailView(pie);
                detailView.ShowDialog();
            }
        }
    }
}
