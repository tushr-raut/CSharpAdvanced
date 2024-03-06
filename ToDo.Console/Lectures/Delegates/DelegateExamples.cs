using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Delegates
{
    class DelegateExamples
    {
        //Def
        public delegate void AddDelegate(int num1, int num2);

        public delegate int GetDelegate(string str);

        public delegate void CaseDelegate(string str);
        
        //static void Main(string[] args)
        //{
        //    Program obj = new Program();
        //    //obj.Add(10, 10);

        //    //Instatiate
        //    GetDelegate del2 = new GetDelegate(Get);

        //    //Call
        //    var res = del2("Test");
        //    var res2 = del2.Invoke("Test");
        //    System.Console.WriteLine(res2);

        //    Print print = new Print();
        //    print.PrintNumbers(GetNum);

        //    CaseDelegate del1 = Lower;

        //    del1 += Upper;

        //    //string as i/p lower case and uppercase of the same string

        //    del1("Test");

        //    //System.Console.WriteLine(res);

        //    System.Console.ReadKey();
        //}

        public static void GetNum(int num)
        {
            System.Console.WriteLine(num);
        }

        static void Lower(string str)
        {
            System.Console.WriteLine(str.ToLower());
        }

        static void Upper(string str)
        {
            System.Console.WriteLine(str.ToUpper());
        }

        static int Get(string str)
        {
            return str.Count();
        }
    }

    //Callback
    public class Print
    {
        public delegate void NumDelegate(int num);

        public void PrintNumbers(NumDelegate obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                //Logic
                obj(i);
            }
        }
    }
}
