using System.Threading;

namespace ToDo.Console.Lectures.Multithreading
{
    class ThreadPoolExample
    {
        static void Execute()
        {
            System.Console.WriteLine("Main thread started");

            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Method1));
            }

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(Method2);
                thread.Start();
                thread.Join();
            }

            System.Console.WriteLine("Main thread ended");
            System.Console.ReadKey();
        }

        static void Method1(object obj)
        {
            Thread thread = Thread.CurrentThread;

            string message = $"IsBackgroundThread: {thread.IsBackground}, IsFromThreadPool: {thread.IsThreadPoolThread}, ThreadId: {thread.ManagedThreadId}";

            System.Console.WriteLine(message);
        }

        static void Method2(object obj)
        {
            Thread thread = Thread.CurrentThread;

            string message = $"IsBackgroundThread: {thread.IsBackground}, IsFromThreadPool: {thread.IsThreadPoolThread}, ThreadId: {thread.ManagedThreadId}";

            System.Console.WriteLine(message);
        }

    }
}
