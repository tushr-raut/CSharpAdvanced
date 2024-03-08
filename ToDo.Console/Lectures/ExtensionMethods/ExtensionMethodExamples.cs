using Newtonsoft.Json;
using System;

namespace AdvanceCSharp.Console.Lectures.ExtensionMethods
{
    public class Program
    {
        public static void Execute()
        {
            int num = 10;

            var res2 = num.Increment();

            int num2 = 100;

            var res3 = num2.Increment();

            var res4 = num2.Add(100);

            System.Console.WriteLine(res4);
            System.Console.WriteLine(res2);

            var todayDate = DateTime.Now;

            var today = todayDate.ToDateOnly();

            var res5 = JsonConvert.SerializeObject(today);

            System.Console.WriteLine(res5);

            System.Console.ReadKey();
        }

    }

    //Extension methods
    //When you have a class but you don't have source code available to that class
    //You want add a method in a resp. class
    //Adv. avoids the recompilation on a resp. class
    //SOLID principles
    public static class ExtensionMethodExamples
    {
        public static int Increment(this int num)
        {
            return num + 1;
        }

        public static int Add(this int num1, int num2)
        {
            return num1 + num2;
        }

        public static DateOnly ToDateOnly(this DateTime date)
        {
            return new DateOnly(date.Day, date.Month, date.Year);
        }
    }

    public class DateOnly
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public DateOnly(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
}
