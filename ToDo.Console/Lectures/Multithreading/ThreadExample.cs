using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Multithreading
{
    class ThreadExample
    {
        static void Execute()
        {
            System.Console.WriteLine("Main thread starts");

            Thread obj1 = new Thread(Method1);

            Thread obj2 = new Thread(Method2);

            Thread obj3 = new Thread(Method3);

            obj1.Start();
            obj2.Start();
            obj3.Start();

            if (obj1.Join(2000))
            {
                System.Console.WriteLine("Do more..");
            }

            if (obj1.IsAlive)
            {
                System.Console.WriteLine("Alive");
            }

            System.Console.WriteLine("Main thread end");

            System.Console.ReadKey();
        }
        
        static void Method1()
        {
            System.Console.WriteLine("Method1 start ");
            Thread.Sleep(5000);
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("M1: " + i);
            }
            System.Console.WriteLine("Method1 end ");
        }

        static void Method2()
        {
            System.Console.WriteLine("Method2 start ");
            Thread.Sleep(3000);
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("M2: " + i);
            }
            System.Console.WriteLine("Method2 end ");
        }

        static void Method3()
        {
            System.Console.WriteLine("Method3 start ");
            Thread.Sleep(2000);
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("M3: " + i);
            }
            System.Console.WriteLine("Method3 end ");
        }
    }
}
