using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DBEX
{
    public partial class PieOverviewPage : Window
    {
        public ObservableCollection<Pie> Pies { get; set; }

        public PieOverviewPage()
        {
            InitializeComponent();
            Pies = GetPies();
            PiesListView.ItemsSource = Pies;
        }

        private ObservableCollection<Pie> GetPies()
        {
            return new ObservableCollection<Pie>
            {
                  new Pie(1, "Apple Pie"),
                  new Pie(2, "Strawberry Cheese"),
                  new Pie(3, "Strawberry Pie"),
                  new Pie(4, "Rhubarb Pie"),
                  new Pie(5, "Blueberry Pie"),
                  new Pie(6, "Cheese cake"),
            };
        }

        private void AddPieButton_Click(object sender, RoutedEventArgs e)
        {
            Pies.Add(new Pie(7, "Demo Pie"));
        }

        private void ListViewItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            var pie = item.Content as Pie;


            var selectedPie = Pies.FirstOrDefault(x => x.Id == pie.Id);

            if (item != null && item.IsSelected)
            {
                PieDetailPage detail = new PieDetailPage(selectedPie);
                detail.ShowDialog();
            }
        }
    }
}