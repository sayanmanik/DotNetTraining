using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailsDemo
{
    class SchoolDemo
    {
        int rollNumber;
        string studentName;
        byte age;
        char gender;
        DateTime dob;
        string address;
        float percentage;


        public int RollNumber
        {
            get
            {
                return rollNumber;
            }
            set
            {
                rollNumber = value;
            }
        }

        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }


        public byte Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }


        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public float Percentage
        {
            get
            {
                return percentage;
            }
            set
            {
                percentage = value;
            }
        }

        public void display()
        {
            Console.WriteLine("Roll Number:" + rollNumber);
            Console.WriteLine("Student Name:"+studentName);
            Console.WriteLine("Age:"+age);
            Console.WriteLine("Gender:"+gender);
            Console.WriteLine("DOB:"+dob.ToString("dd/MM/yyyy"));
            Console.WriteLine("Address:"+address);
            Console.WriteLine("Percentage:"+percentage);
        } 



    }
}
