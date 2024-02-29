using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Basics
{
    class InheritancePolymorphismExamples
    {
        //static void Main(string[] args)
        //{
        //    A a1 = new A();
        //    a1.Print();

        //    B b1 = new B();
        //    b1.Print();

        //    A a2 = new B();
        //    a2.Print();

        //    //B b2 = new A();
        //    //b2.Print();

        //    B b3 = (B)new A();
        //    b3.Print();


        //    System.Console.ReadLine();
        //}
    }

    class A
    {
        public virtual void Print()
        {
            System.Console.WriteLine("Print A");
        }
    }

    class B : A
    {
        public override void Print()
        {
            System.Console.WriteLine("Print B");
        }
    }
}
