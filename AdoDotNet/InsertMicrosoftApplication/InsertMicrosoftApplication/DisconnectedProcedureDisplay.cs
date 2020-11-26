using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertMicrosoftApplication
{
    public class DisconnectedProcedureDisplay
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true"))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("GetEmployees",conn);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset,"Employees");
                    DataTable table = dataset.Tables[0];

                    foreach (DataRow row  in table.Rows)
                    {
                        Console.WriteLine(row[0]+","+row[1]+","+row[2]+","+row[3]+","+row[4]);
                    }
                   

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
