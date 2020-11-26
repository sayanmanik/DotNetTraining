using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopyDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var file = "demo.txt";
            var from = "C:\\Users\\TestUser\\Desktop\\" + file;

            var to = "C:\\Users\\TestUser\\Desktop\\sayan\\";


            if (!Directory.Exists(to))
            {
                Directory.CreateDirectory(to);
            }

            File.Copy(from, to + file);
        }

    }
}
