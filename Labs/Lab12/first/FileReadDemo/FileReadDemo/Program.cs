using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\TestUser\\Desktop\\demo.txt"))
                {
                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        Console.WriteLine(line);
                    }

                }
            }catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
