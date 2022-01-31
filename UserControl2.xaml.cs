using System.Windows;
using System.Windows.Controls;
using LiveCharts;

namespace Dash2
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            Values = new ChartValues<double> { 150, 375, 420, 500, 160, 140 };
        }
        public ChartValues<double> Values { get; set; }

        private void UpdateOnclick(object sender, RoutedEventArgs e)
        {
            Chart.Update(true);
        }
    }
}
