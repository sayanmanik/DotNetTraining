using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AdbDotNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Connected Architecture(online mode)
            SqlConnection sqlConnection = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from Employees where EmpId=@empId", sqlConnection);
            command.Parameters.AddWithValue("@empId",123);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Console.WriteLine(reader.GetValue(0));
                Console.WriteLine(reader[0] + ","+ reader[1]);
            }
            sqlConnection.Close();
        
            //Disconnected Architecture -- connection will open & close only during read/write(offline mode)


              
        }
    }
}
