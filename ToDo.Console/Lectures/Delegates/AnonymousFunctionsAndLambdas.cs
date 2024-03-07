using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Delegates
{
    class AnonymousFunctionsAndLambdas
    {
        //public delegate T GetDelegate<T>(T obj);

        public delegate void GetDelegate();

        //static void Main(string[] args)
        //{
        //    string str1 = "Hi..";

        //    //delegate
        //    GetDelegate obj1 = new GetDelegate(Get);

        //    //Anonymous method
        //    GetDelegate obj2 = delegate ()
        //    {
        //        System.Console.WriteLine(str1);
        //    };

        //    //Lambda expression
        //    GetDelegate obj3 = () =>
        //    {
        //        System.Console.WriteLine(str1);
        //    };

        //    //obj1.Invoke();
        //    obj2.Invoke();
        //    obj3.Invoke();

        //    System.Console.ReadKey();
        }

        //Method
        public static void Get()
        {
            //System.Console.WriteLine();
        }

        public static void GetLowerCase(string str)
        {
            System.Console.WriteLine(str.ToLower());
        }
    }
}
