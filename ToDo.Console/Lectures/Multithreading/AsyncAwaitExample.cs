using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Multithreading
{
    class AsyncAwaitExample
    {
        static async Task Main(string[] args)
        {
            System.Console.WriteLine("We are going to make breakfast.");

            //********************Slower Async/Await********************
            var watch = Stopwatch.StartNew();
            await CookBreakfastSlow();
            watch.Stop();
            System.Console.WriteLine($"It took {watch.ElapsedMilliseconds} ms to cook.");

            System.Console.WriteLine("That took a long time.  Let's try it a little faster");

            //********************Faster Async/Await********************
            watch = Stopwatch.StartNew();
            await CookBreakfastFast();
            watch.Stop();
            System.Console.WriteLine($"It took {watch.ElapsedMilliseconds} ms to cook.");
        }


        public static async Task CookBreakfastSlow()
        {
            await FryEggAsync();
            await ToastBreadAsync();
            System.Console.WriteLine("Breakfast is ready.");
        }

        public static async Task CookBreakfastFast()
        {
            Task eggTask = FryEggAsync();
            Task toastTask = ToastBreadAsync();

            await eggTask;
            await toastTask;

            System.Console.WriteLine("Breakfast is ready");
        }

        public static async Task FryEggAsync()
        {
            System.Console.WriteLine("Starting egg frying");
            await Task.Run(() =>
            {
                for (var i = 0; i < 5; i++)
                {
                    System.Console.WriteLine("Frying");
                    Thread.Sleep(1000);
                }
            });
            System.Console.WriteLine("Egg is done");
        }

        public static async Task ToastBreadAsync()
        {
            System.Console.WriteLine("Starting on toast");
            await Task.Run(() =>
            {
                for (var i = 0; i < 5; i++)
                {
                    System.Console.WriteLine("Toasting");
                    Thread.Sleep(1000);
                }
            });
            System.Console.WriteLine("Toast done.");
        }
    }
}
