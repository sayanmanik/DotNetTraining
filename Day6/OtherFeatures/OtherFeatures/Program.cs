using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartialSample;

class MyClass
{
    public void MyMethod()
    {
        Console.WriteLine("Hello World");
    }
}

namespace OtherFeatures
{

    class MyDemo
    {
        public void MyMethod()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //#pragma warning disable
            //int x;

            // Enumerable ------->>>>>>>>>>>>

            //Persons persons = new Persons("Jack","Jill","Mathew");
            //foreach (string str in persons)
            //{
            //    Console.WriteLine(str);
            //

            // Partial class ------------->>>>>>>>>>>

            //PartialSample.Sample sample = new PartialSample.Sample();
            //sample.Method1();
            //sample.Method2();


            //MyDemo myDemo = new MyDemo();
            //myDemo.MyMethod();

            //global::MyClass classDemo = new MyClass();
            //classDemo.MyMethod();



            // string extension method--------------->>>>>>>>>>>>
            //string Ex = "100";
            //int num = Ex.ConvertToInt();
            //Console.WriteLine(num);


            // object initializer--------------->>>>>>>>>>>>>>>>
            //Employee emp = new Employee {
            //    EmployeeAge = 20,
            //    EmployeeId = 101,
            //    EmployeeName = "sayan"
            //};

            //Console.WriteLine(emp.EmployeeId+","+emp.EmployeeName +","+emp.EmployeeAge);


            var emp = new { Id = 101, Name="Sayan"};
            Console.WriteLine(emp.GetType());

            var emp1 = new { Id = 102, Name = "Manik" };
            Console.WriteLine(emp1.GetType());

            var emp2 = new { Id = 102 };
            Console.WriteLine(emp2.GetType());
        }
    }
}
