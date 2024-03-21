using System.Threading;

namespace ToDo.Console.Lectures.Multithreading
{
    class ThreadSafetyExample
    {
        public static int sum = 0;
        static void Execute()
        {
            Thread obj1 = new Thread(Method1);
            Thread obj2 = new Thread(Method1);
            Thread obj3 = new Thread(Method1);

            obj1.Start();
            obj2.Start();
            obj3.Start();

            obj1.Join();
            obj2.Join();
            obj3.Join();

            System.Console.WriteLine("sum: " + sum);

            Thread obj4 = new Thread(Method2);
            Thread obj5 = new Thread(Method2);
            Thread obj6 = new Thread(Method2);

            obj4.Start();
            obj5.Start();
            obj6.Start();

            obj4.Join();
            obj5.Join();
            obj6.Join();
            
            System.Console.WriteLine("sum: " + sum);


            System.Console.ReadKey();
        }

        public static object obj1 = new object();
        //With help of Monitor class
        static void Method1()
        {
            for (int i = 0; i < 5000; i++)
            {
                Monitor.Enter(obj1);
                try
                {
                    sum++;
                }
                finally
                {
                    Monitor.Exit(obj1);
                }
            }
        }

        public static object obj2 = new object();
        //With help of lock
        static void Method2()
        {
            for (int i = 0; i < 5000; i++)
            {
                lock (obj2)
                {
                    sum++;
                }
            }
        }
    }
}
