using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoriesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            createDirectories();


            BackUp("C:\\Academy", "D:\\Academy");

        }


        static void createDirectories()
        {
            string first = "C:\\Academy\\Chennai\\";
            string second = "C:\\Academy\\Bangalore\\";
            string third = "C:\\Academy\\Mumbai\\";
            string fourth = "C:\\Academy\\Pune\\";

            if (!Directory.Exists(first))
            {
                Directory.CreateDirectory(first);
            }

            if (!Directory.Exists(second))
            {
                Directory.CreateDirectory(second);
            }

            if (!Directory.Exists(third))
            {
                Directory.CreateDirectory(third);
            }

            if (!Directory.Exists(fourth))
            {
                Directory.CreateDirectory(fourth);
            }
        }


        static void BackUp(string from ,string to)
        {
            //if (!Directory.Exists(to))
            //{
            //    Directory.CreateDirectory(to);
            //}

            //string[] folders = Directory.GetDirectories(from);

            //foreach(string str in folders)
            //{
            //    BackUp();
            //}


            //FileSystem.CopyDirectory(from, to);


        }
    }
}
