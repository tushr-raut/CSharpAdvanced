using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.NonGenericCollections
{
    class NonGenericCollectionExamples
    {
        public void GetCollections()
        {
            //ArrayList
            //Hashtable
            //SortedList
            //Stack
            //Queue

            //Arrays
            int[] arr = new int[4];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }

            //ArrayList
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add("test");
            
            list.Remove(4);
            
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            //Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Test1");
            hashtable.Add(2, "Test2");
            hashtable.Add(2, "Test2");
            
            hashtable.Remove(2);

            foreach (var item in hashtable.Values)
            {
                System.Console.WriteLine(item);
            }

            //SortedList
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "Test1");
            sortedList.Add(3, "Test3");
            sortedList.Add(2, "Test2");
            sortedList.Add(5, "Test2");
            
            sortedList.Remove(1);

            foreach (var item in sortedList.Values)
            {
                System.Console.WriteLine(item);
            }

            //Stack
            Stack stack = new Stack(); //LIFO
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop();

            foreach (var item in stack)
            {
                System.Console.WriteLine(item);
            }

            Queue queue = new Queue(); //FIFO
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue();

            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }
            
        }
    }
}
