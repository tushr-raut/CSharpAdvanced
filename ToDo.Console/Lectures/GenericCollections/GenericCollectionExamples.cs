using System.Collections.Generic;

namespace AdvanceCSharp.Console.Lectures.GenericCollections
{
    class GenericCollectionExamples
    {
        public void GetGenericCollections()
        {
            //List
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            //Dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Test1");
            dict.Add(2, "Test2");
            dict.Add(2, "Test2");

            foreach (var item in dict.Values)
            {
                System.Console.WriteLine(item);
            }

            //Get values from Dictionary
            dict.TryGetValue(1, out string val); //If key not found returns null
            var res = dict[1];  //If key not found throws key not found exception

            //SortedList
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "Test1");
            sortedList.Add(3, "Test3");
            sortedList.Add(2, "Test2");
            sortedList.Add(5, "Test2");

            foreach (var item in sortedList.Values)
            {
                System.Console.WriteLine(item);
            }

            //Stack
            Stack<int> stack = new Stack<int>(); //LIFO
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            foreach (var item in stack)
            {
                System.Console.WriteLine(item);
            }

            //Queue
            Queue<int> queue = new Queue<int>(); //FIFO
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
