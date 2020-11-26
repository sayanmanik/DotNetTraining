using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdbDotNetDemo
{
    class DisconnectedDemo
    {
        static void Main(string[] args)
        {
            SqlConnection connection=null;
            try
            {
                connection = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");

                SqlCommand command = new SqlCommand("select * from employees", connection);

                //SqlCommand command = new SqlCommand("select * from employees2", connection);

                // Adapter acts like a bridge and manages to open and close connection automatically
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                //Dataset is an offline stotage used for storing table fetched from the db
                DataSet set = new DataSet();

                Console.WriteLine(connection.State);
                //adapter fetches table from db and populate it in dataset
                adapter.Fill(set, "employees");

                Console.WriteLine(connection.State);

                //Console.WriteLine("Set tables: "+set.DataSetName);

                DataTable dt = set.Tables["employees"];


                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row[0] + "," + row[1] + "," + row[2] + "," + row[3]);
                }

            }catch(SqlException ex)
            {
                Console.WriteLine(ex.Message+","+ex.ErrorCode);
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }  
                
        }   
    }
}
