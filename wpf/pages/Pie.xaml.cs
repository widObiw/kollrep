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
    /// Логика взаимодействия для Pie.xaml
    /// </summary>
    public partial class Pie : Page
    {
        Frame frame;
        public Pie(Frame _frame)
        {
            InitializeComponent();
            frame = _frame;
            wpfp.Plot.Clear();
            wpfp.Visibility = Visibility.Visible;
            double[] values = { 778, 43, 283, 76, 184 };
            var pie = wpfp.Plot.AddPie(values);
            pie.ShowPercentages = true;
            wpfp.Refresh();
        }
    }
}
