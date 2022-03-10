using ScottPlot;
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

namespace wpf.pages
{
    /// <summary>
    /// Логика взаимодействия для Bar.xaml
    /// </summary>
    public partial class Bar : Page
    {
        Frame frame;
        public Bar(Frame _frame)
        {
            InitializeComponent();
            frame = _frame;
            wpfp.Plot.Clear();
            wpfp.Visibility = Visibility.Visible;
            double[] values = { 26, 20, 23, 7, 16 };
            double[] positions = { 10, 20, 30, 40, 50 };

            // add a bar graph to the plot
            var bar = wpfp.Plot.AddBar(values, positions);

            // customize the width of bars (80% of the inter-position distance looks good)
            bar.BarWidth = (positions[1] - positions[0]) * .8;

            // adjust axis limits so there is no padding below the bar graph
            wpfp.Plot.SetAxisLimits(yMin: 0);

            wpfp.Refresh();
        }
    }
}
