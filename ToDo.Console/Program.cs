using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Console.Services;

namespace ToDo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoService toDo = new ToDoService();
            var result = toDo.GetList();

            foreach (var item in result)
            {
                System.Console.WriteLine(item.Id);
                System.Console.WriteLine(item.Type);
                System.Console.WriteLine(item.Notes);
            }

            System.Console.ReadKey();
        }
    }
}
