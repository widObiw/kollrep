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
    /// Логика взаимодействия для Radar.xaml
    /// </summary>
    public partial class Radar : Page
    {
        Frame frame;
        public Radar(Frame _frame)
        {
            InitializeComponent();
            frame = _frame;
            wpfp.Plot.Clear();
            wpfp.Visibility = Visibility.Visible;
            double[,] values =
                {
                    { 78,  83, 84, 76, 43 },
                    { 100, 50, 70, 60, 90 }
                };

            wpfp.Plot.AddRadar(values);

            // improve plot styling
            wpfp.Plot.Frameless();
            wpfp.Plot.Grid(enable: false);
            wpfp.Refresh();
        }
    }
}
