using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDo.Console.Lectures.ListVsIEnumerable
{
    class ListVsIEnumerableExamples
    {
        //static void Main(string[] args)
        //{
        //    //Immediate vs deffered execution
        //    //List vs IEnumerable

        //    var list = new List<int> { 1, 2, 3, 4 };

        //    var filteredList = list.Where(x => x > 2).ToList(); //Immediate

        //    var filtered = list.Where(x => x > 2); //deferred

        //    list.Add(5);

        //    System.Console.WriteLine("======= filteredList =======");
        //    foreach (var item in filteredList)
        //    {
        //        System.Console.WriteLine(item);
        //    }

        //    System.Console.WriteLine("======= filtered =======");
        //    foreach (var item in filtered)
        //    {
        //        System.Console.WriteLine(item);
        //    }


        //    List<int> list1 = new List<int> { 1, 2, 3, 4 };

        //    IList<int> list2 = new List<int> { 1, 2, 3, 4 };

        //    IEnumerable<int> list3 = new List<int> { 1, 2, 3, 4 };

        //    Test test = new Test();
        //    var res1 = test.Filter(list1);

        //    var res2 = test.Filter(list2);

        //    //var res3 = test.Filter(list3);

        //    MyList mylist = new MyList();
        //    var res4 = test.Filter(mylist);


        //    System.Console.ReadKey();
        //}
    }

    public class Test
    {
        public IEnumerable<int> Filter(IList<int> nums)
        {
            return nums.Where(x => x > 2);
        }
    }

    public class MyList : IList<int>
    {
        public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
