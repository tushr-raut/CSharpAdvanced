using System;

namespace AdvanceCSharp.Console.Lectures.Generics
{
    public class FuncActionPredicateDelegates
    {
        //public delegate int AddDelegate(int num1, int num2);
        //public delegate void NameDelegate(string str);
        //public delegate bool IsCaseLowerDelegate(string str);
        public static void Execute()
        {
            //Func is generic delegate
            //It always requires the return type
            
            //AddDelegate obj1 = new AddDelegate(Add)
            Func<int, int, int> obj1 = new Func<int, int, int>(Add);
            var res1 = obj1(10, 10);
            System.Console.WriteLine(res1);

            //Action is generic delegate
            //It is void type returning methods

            //NameDelegate obj2 = new NameDelegate(Name)
            Action<string> obj2 = new Action<string>(Name);
            obj2("Test");

            //Predicate is generic delegate
            //It is bool type returning methods

            //IsCaseLowerDelegate obj3 = new IsCaseLowerDelegate(IsCaseLower)
            Predicate<string> obj3 = new Predicate<string>(IsCaseLower);
            var res2 = obj3("test");
            System.Console.WriteLine(res2);

            System.Console.ReadKey();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Name(string str)
        {
            System.Console.WriteLine(str);
        }

        public static bool IsCaseLower(string str)
        {
            if (str == str.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
