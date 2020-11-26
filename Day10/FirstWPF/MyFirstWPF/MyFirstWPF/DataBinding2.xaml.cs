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

namespace MyFirstWPF
{
    /// <summary>
    /// Interaction logic for DataBinding2.xaml
    /// </summary>
    public partial class DataBinding2 : Page
    {
        public DataBinding2()
        {
            InitializeComponent();
        }

        Student student = new Student {StudentId=1,Name="Sayan",Grade="IT" };
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = student;

        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(student.Name);
        }
    }
}
