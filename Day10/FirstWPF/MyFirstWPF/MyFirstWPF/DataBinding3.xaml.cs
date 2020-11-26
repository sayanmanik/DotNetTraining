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
using System.Data.SqlClient;

namespace MyFirstWPF
{
    /// <summary>
    /// Interaction logic for DataBinding3.xaml
    /// </summary>
    public partial class DataBinding3 : Window
    {
        public DataBinding3()
        {
            InitializeComponent();
        }

        //private void GetData()
        //{

        //}

        private SqlDataReader GetData()
        {
            SqlConnection conn = new SqlConnection("Data Source = KIIT_10699; Initial Catalog = DotNet; Integrated Security = true");
            conn.Open();

            SqlCommand command = new SqlCommand("select * from Employees",conn);
            SqlDataReader reader = command.ExecuteReader();

            return reader;

                 
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            SqlDataReader reader = GetData();
            datagrid1.DataContext = reader;
        }
    }
}
