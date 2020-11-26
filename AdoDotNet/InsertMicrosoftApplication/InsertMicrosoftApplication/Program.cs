using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;

namespace InsertMicrosoftApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Employee id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Emplyee First Name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Employee Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Employee age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DOJ");
            string date = Console.ReadLine();

            SqlConnection conn = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            conn.Open();

            SqlHelper.ExecuteNonQuery(
                conn,
                "InsertEmployee",
                new SqlParameter("@empId",id),
                new SqlParameter("@lastName",lastName),
                new SqlParameter("@firstName",FirstName),
                new SqlParameter("@age",age),
                new SqlParameter("@joiningDate",date));

            conn.Close();


        }
    }
}
