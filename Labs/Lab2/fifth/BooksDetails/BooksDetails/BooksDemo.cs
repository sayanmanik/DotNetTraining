using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDetails
{
    class BooksDemo
    {
        static void Main(string[] args)
        {
            string[] colsName = {"Book Title","Author","Publisher","Price" };
            string[,] bookDetails = new string[2,4];

            Console.WriteLine("Enter details of books");
            for (int i=0;i<2;i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    bookDetails[i,j] = Console.ReadLine();
                }
            }

            for (int i=0;i<colsName.Length;i++)
            {
                Console.Write(colsName[i]+"-");
            }

            Console.WriteLine();
            for (int i=0;i<2;i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(bookDetails[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
