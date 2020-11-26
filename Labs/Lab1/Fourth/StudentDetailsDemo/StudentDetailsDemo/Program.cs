using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter roll number");
            int roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student name");
            string name = Console.ReadLine();

            
            Console.WriteLine("Enter Student Age");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter Student gender");
            char gender = Console.ReadLine().ToCharArray()[0];

            Console.WriteLine("Enter Student DOB");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Student address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Student percentage");
            float percentage = (float)Convert.ToDouble(Console.ReadLine());


            SchoolDemo school = new SchoolDemo();
            school.RollNumber = roll;
            school.StudentName = name;
            school.Percentage = percentage;
            school.Gender = gender;
            school.DOB = dob;
            school.Address = address;
            school.Age = age;

            school.display();

        }
    }
}
