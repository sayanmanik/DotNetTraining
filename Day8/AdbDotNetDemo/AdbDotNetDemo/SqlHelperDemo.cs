using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;

namespace AdbDotNetDemo
{
    class SqlHelperDemo
    {
        static void Main(string[] args)
        {
            SqlDataReader reader = SqlHelper.ExecuteReader("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true",System.Data.CommandType.Text,"select * from employees");

            while (reader.Read())
            {
                Console.WriteLine(reader[0]+","+reader[1]+","+reader[2]+","+reader[3]);
            }
        }
    }
}
