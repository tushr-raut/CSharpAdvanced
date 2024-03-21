using System.Threading;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Multithreading
{
    class TaskExample
    {
        static void Execute()
        {
            System.Console.WriteLine("Main thread starts");

            Thread thread = new Thread(Method1);
            thread.Start();

            Task task = new Task(Method1);
            task.Start();

            //Factory method task invocation
            Task task1 = Task.Factory.StartNew(Method1);

            //void type
            Task task2 = Task.Run(() =>
            {
                Method1();
            });

            //Returning complex type
            Task<Student> task3 = Task.Run(() =>
            {
                return Method3();
            });

            //Returning int type
            Task<int> task4 = Task.Run(() =>
            {
                return Method2();
            });

            task3.Wait();

            System.Console.WriteLine(task3.Result.Id);
            System.Console.WriteLine(task3.Result.Name);

            System.Console.WriteLine("Main thread ends");
            System.Console.ReadKey();
        }

        static void Method1()
        {
            System.Console.WriteLine("Method1 starts");

            Thread.Sleep(5000);
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Method1: " + i);
            }

            System.Console.WriteLine("Method1 ends");
        }

        static int Method2()
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                count++;
            }
            return count;
        }

        static Student Method3()
        {

            return new Student
            {
                Id = 101,
                Name = "Test"
            };
        }
    }
    
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
