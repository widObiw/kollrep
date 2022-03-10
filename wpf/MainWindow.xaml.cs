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
using wpf.pages;

namespace wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();


            
        }

        private void dtbRadar_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Radar(frame));
        }

        private void dtbPie_Click(object sender, RoutedEventArgs e)
        {

            frame.Navigate(new Pie(frame));
        }

        private void dtbBar_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Bar(frame));



        }

        private void dtbClasses_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Klassi(frame));
        }
    }
}
