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
    /// Логика взаимодействия для Klassi.xaml
    /// </summary>
    public partial class Klassi : Page
    {
        Frame frame;
        public Klassi(Frame _frame)
        {
            InitializeComponent();
            frame = _frame;
            tName.Text = "Пипуткин";
            tGroup.Text = "112";
            string[] marks = new string[] { "3", "5", "2", "5", "5", "4", "2", "5", "5", "5" };
            tBal.Text = ClassLibrary1.Class1.MinAVG(marks).ToString();
        }

        private void btnGenerat_Click(object sender, RoutedEventArgs e)
        {
            tNn.Text = ClassLibrary1.Class1.GetStudNumber(int.Parse(tbYear.Text), int.Parse(tbGroup.Text), tbFIO.Text);
        }
    }
}
