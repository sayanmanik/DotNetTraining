using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdbDotNetDemo
{
    class InsertDemo
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            connection.Open();

            SqlCommand insertCommand = new SqlCommand("Insert into Employees(EmpId, FirstName, LastName, JoiningDate) values(@empId,@firstName,@lastName,@joining_date)",connection);
            insertCommand.Parameters.Add("@empId",System.Data.SqlDbType.Int);
            insertCommand.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar, 20);
            insertCommand.Parameters.Add("@lastName",System.Data.SqlDbType.VarChar,20);
            //insertCommand.Parameters.Add("@salary",System.Data.SqlDbType.Decimal);
            insertCommand.Parameters.Add("@joining_date",System.Data.SqlDbType.Date);
            
            insertCommand.Parameters["@empId"].Value = Convert.ToInt32(Console.ReadLine());
            insertCommand.Parameters["@firstName"].Value = Console.ReadLine();
            insertCommand.Parameters["@lastName"].Value = Console.ReadLine();
            //insertCommand.Parameters["@salary"].Value = Convert.ToDecimal(Console.ReadLine());
            insertCommand.Parameters["@joining_date"].Value = Console.ReadLine();

            int rows = insertCommand.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("Successful");
            }
            else
            {
                Console.WriteLine("Error!");
            }


        }
    }
}
