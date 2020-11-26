using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {

        //static List<string> AsyncTask()
        //{
        //    //Console.WriteLine("Message from asynctask");

        //    List<string> names = new List<string>();

        //    names.Add("C#");
        //    names.Add("WPF");
        //    names.Add("ASP.NET");

        //    return names;
        
        //}


        static void Main(string[] args)
        {
            //Task<List<string>> task = new Task<List<string>>(AsyncTask);
            //Console.WriteLine(task.Status);
            //task.Start();
            //Console.WriteLine(task.Status);
            //foreach (string name in task.Result)
            //{
            //    Console.WriteLine(name);
            //}

            //Task myTask = new Task(() => Console.WriteLine("Message from task"));
            //myTask.Start();

            //System.Threading.Thread.Sleep(3000);
            //Console.WriteLine(task.Status);


            //Task task1 = new Task(Action1);
            //Task task2 = new Task(Action2, 25);

            //task1.Start();
            //task2.Start();

            //Task.WaitAll(task1, task2);


            simpleFor();

            Parallel.For(0,1000,parallelFor);


                
        }



        static void simpleFor()
        {
            for(int i = 1000; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
        }


        static void parallelFor(int i)
        {
            Console.WriteLine(i);
        }

        //static void Action2(object param)
        //{
        //    for(int i = 1; i <= (int)param; i++)
        //    {
        //        Console.WriteLine(i+ "   *");
        //    }
        //}

        //static void Action1()
        //{
        //    for(int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
