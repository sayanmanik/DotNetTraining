using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflection
{
    class Employee
    {
        public int age;
        public string name;

        public int Age { get; set; }

        public string Name { get; set; }

        public int GetAge()
        {
            return age;
        }

        public string GetName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Type type = typeof(Employee);

            MethodInfo[] methods = type.GetMethods();

            PropertyInfo[] properties = type.GetProperties();

            FieldInfo[] fields = type.GetFields();


            Console.WriteLine("Method infos----------->>>>>>>>>>>>>>>");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }


            Console.WriteLine("Property infos----------->>>>>>>>>>>>>>>");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
            

            Console.WriteLine("Fields infos------------->>>>>>>>>>>>");
            foreach(FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }

        }
    }
}
