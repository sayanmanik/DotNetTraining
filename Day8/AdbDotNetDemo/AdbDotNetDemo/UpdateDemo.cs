using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdbDotNetDemo
{
    class UpdateDemo
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("usp_UpdateEmpAge", connection);
            //SqlCommand command = new SqlCommand("EXEC usp_UpdateEmpSalary 33, 45000", connection);


            command.CommandType = System.Data.CommandType.StoredProcedure;
            //command.CommandType = System.Data.CommandType.Text;


            command.Parameters.AddWithValue("@empId",300);
            command.Parameters.AddWithValue("@age", 23);

            int rows = command.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("Successful");
            }
            else
            {
                Console.WriteLine("Error");
            }

            connection.Close();
        }
    }
}
