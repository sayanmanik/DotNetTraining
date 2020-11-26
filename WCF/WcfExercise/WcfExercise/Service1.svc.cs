using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfExercise
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Book> GetAllBooks()
        {

            List<Book> list = new List<Book>();
            SqlConnection conn = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from tblBookDetails",conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(reader[0]+","+reader[1]+","+reader[2]+","+reader[3]);
                Book book = new Book();
                book.BookID = (int)reader[0];
                book.BookName = (string)reader[1];
                book.AvailableCopies = (int)reader[2];
                book.description = (string)reader[3];

                list.Add(book);
            }
            conn.Close();
            return list;
        }

        public void GetBook(int value)
        {
            List<Book> list = new List<Book>();
            SqlConnection conn = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from tblBookDetails where bookID=@value", conn);
            command.Parameters.AddWithValue("@value",value);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Console.WriteLine(reader[0] + "," + reader[1] + "," + reader[2] + "," + reader[3]);
                Book book = new Book();
                book.BookID = (int)reader[0];
                book.BookName = (string)reader[1];
                book.AvailableCopies = (int)reader[2];
                book.description = (string)reader[3];

                list.Add(book);
            }
            conn.Close();
            
        }

        public void InsertBook(int id, string name, int copy, string desc)
        {
            SqlConnection conn = new SqlConnection("Data Source=KIIT_10699;Initial Catalog=DotNet;Integrated Security=true");
            conn.Open();
            SqlCommand command = new SqlCommand("Insert into tblBookDetails values(@id, @name, @copy, @desc)");
            command.Parameters.AddWithValue("@id",id);
            command.Parameters.AddWithValue("@name",name);
            command.Parameters.AddWithValue("@copy",copy);
            command.Parameters.AddWithValue("@desc",desc);



            conn.Close();
        }
    }
}
