using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Demo
{
    class ThreadDemo
    {
        static List<string> numbers = new List<string>();
        static object locker1 = new object();
        static object locker2 = new object();
        

        static void Main(string[] args)
        {
            //ThreadStart threadStart = new ThreadStart(Child);
            //Thread childThread = new Thread(threadStart);
            //Console.WriteLine(childThread.ThreadState);
            //childThread.Start();
            //Console.WriteLine(childThread.ThreadState);
            //Thread.Sleep(1000);
            //Console.WriteLine(childThread.ThreadState);


            //ThreadStart threadStart = new ThreadStart(printNumbers);
            //Thread thread = new Thread(threadStart);

            //Console.WriteLine(thread.ThreadState);
            //thread.Start();
            //Console.WriteLine(thread.ThreadState);
            //Thread.Sleep(1000);
            //Console.WriteLine(thread.ThreadState);


            //ThreadStart start = new ThreadStart(Processtask);
            //Thread t1 = new Thread(start);
            //t1.Start();

            //Console.WriteLine(t1.IsAlive);
            //Console.WriteLine("Main Thread in action");

            //t1.Join();
            //Console.WriteLine(t1.IsAlive);
            //Console.WriteLine("Main Thread completed");

            // Thread Priority -------------------->>>>>>>>>>>>>>>

            //ThreadStart start = new ThreadStart(Processtask);
            //Thread firstThread = new Thread(start);
            //firstThread.Name = "first";

            //Thread secondThread = new Thread(start);
            //secondThread.Name = "second";

            //secondThread.Priority = ThreadPriority.Normal;
            //firstThread.Priority = ThreadPriority.BelowNormal;

            //firstThread.Start();
            //secondThread.Start();

            ThreadStart firstStart = new ThreadStart(FirstThread);
            Thread first = new Thread(firstStart);
            ThreadStart secondStart = new ThreadStart(SecondThread);
            Thread second = new Thread(secondStart);
            first.Name = "1st";
            second.Name = "2nd";
            first.Start();
            second.Start();

            Thread.Sleep(2000);

            foreach(string i in numbers)
            {
                Thread.Sleep(10);
                Console.WriteLine(i);
            }

        }


        static void FirstThread()
        {
            lock(locker1){
                for (int i = 1; i < 4; i++)
                {
                    //Thread.Sleep(10);
                    numbers.Add(Thread.CurrentThread.Name+","+i);
                }
            }

        }


        static void SecondThread()
        {
            lock (locker2)
            {
                for (int i = 4; i < 7; i++)
                {
                    //Thread.Sleep(10);
                    numbers.Add(Thread.CurrentThread.Name + "," + i);
                }

            }

        }

        //static void Child()
        //{
        //    Console.WriteLine("Child thread");
        //}

        //static void printNumbers()
        //{
        //    for(int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("{0}",i);
        //    }
        //}



        static void Processtask()
        {
            //    for(int i = 0; i < 5; i++)
            //    {
            //        if (i == 4)
            //        {
            //            Thread.CurrentThread.Abort();
            //        }
            //        Console.WriteLine("Thread t1 in action");

            Console.WriteLine("Current thread {0}",Thread.CurrentThread.Name);
            }
        }   
    }