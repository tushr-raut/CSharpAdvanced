using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Multithreading
{
    class ThreadClassExample
    {
        static void Execute()
        {
            System.Console.WriteLine("Main thread starts");

            // Method1();

            //ThreadStart t1 = new ThreadStart(Method1);

            //ParameterizedThreadStart t2 = Method1;

            Thread obj = new Thread(Method1);

            obj.Start(2);


            System.Console.WriteLine("Main thread end");

            System.Console.ReadKey();
        }

        static void Method1(object startindex)
        {
            Thread.Sleep(5000);
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("M1: " + i);
            }
        }

        static void Method2(object startindex)
        {
            Thread.Sleep(3000);
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("M1: " + i);
            }
        }
    }
}
