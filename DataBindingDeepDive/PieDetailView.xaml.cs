using DataBindingDeepDive.Models;
using System.Windows;

namespace DataBindingDeepDive
{
    /// <summary>
    /// Interaction logic for PieDetailView.xaml
    /// </summary>
    public partial class PieDetailView : Window
    {
        public Pie Pie{ get; set; }

        public PieDetailView(Pie pie)
        {
            InitializeComponent();
            Pie = pie;

            this.DataContext = pie;
        }
    }
}
