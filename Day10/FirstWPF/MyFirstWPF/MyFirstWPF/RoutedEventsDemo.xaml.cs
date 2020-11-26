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
using System.Windows.Shapes;

namespace MyFirstWPF
{
    /// <summary>
    /// Interaction logic for RoutedEventsDemo.xaml
    /// </summary>
    public partial class RoutedEventsDemo : Window
    {
        public RoutedEventsDemo()
        {
            InitializeComponent();
        }

        private void btnClick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lstItems.Items.Add("Button Mousedown");
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lstItems.Items.Add("Stackpanel Mousedown");
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lstItems.Items.Add("Grid Mousedown");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lstItems.Items.Add("Window Mousedown");
        }

        private void btnClick_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            lstItems.Items.Add("Button preview mouse down");
        }
    }
}
