using System.Windows;

namespace DBEX
{
    /// <summary>
    /// Interaction logic for PieDetailPage.xaml
    /// </summary>
    public partial class PieDetailPage : Window
    {
        public Pie Pie { get; set; }

        public PieDetailPage(Pie pie)
        {
            InitializeComponent();
            Pie = pie;

            this.DataContext = pie;
        }
    }
}