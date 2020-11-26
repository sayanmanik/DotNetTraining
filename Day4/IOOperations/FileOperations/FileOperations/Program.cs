using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            using(FileStream fs = new FileStream("C:\\Users\\TestUser\\Desktop\\demo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamWriter streamWriter = new StreamWriter(fs);
                streamWriter.WriteLine("Hello");
                streamWriter.WriteLine("How r u?");

                fs.Flush();
                fs.Seek(0,SeekOrigin.Begin);

                StreamReader reader = new StreamReader(fs);
                string str;
                while((str = reader.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }


            }


        }
    }
}
