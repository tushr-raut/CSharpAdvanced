using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ToDo.Console.Lectures.Linq
{
    class LinqExample01
    {
        public static void Execute()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            var res1 = numbers.Where(num => num % 2 == 0);

            Func<int, bool> pred = x => x % 2 == 0;

            var res2 = numbers.Where(pred);
            
            int res3 = numbers.Where(num => num % 2 == 0).First();
            int res4 = numbers.Where(num => num % 2 == 0).FirstOrDefault();
            int res5 = numbers.Where(num => num % 2 == 0).Last();
            int res6 = numbers.Where(num => num % 2 == 0).LastOrDefault();
            int res7 = numbers.Where(num => num % 2 == 0).Single();
            int res8 = numbers.Where(num => num % 2 == 0).SingleOrDefault();

            
            //XML to LINQ
            XDocument doc = XDocument.Load(@"C:\Users\rautttus\Desktop\data.xml");

            var query = from node
                        in doc.Descendants("node1")
                        select node.Attribute("name");

            var res9 = doc.Descendants("node1").Where(node => node.Attribute("name").Value == "A");

            //Partitioning operators
            var res10 = numbers.Take(2);
            var res11 = numbers.TakeWhile(num => num < 3);
            var res12 = numbers.Skip(2);
            var res13 = numbers.SkipWhile(num => num < 3);

            //Conversion operators
            var res14 = numbers.Where(num => num % 2 == 0).ToList();
            var res15 = numbers.Where(num => num % 2 == 0).ToArray();

            //Set operators
            int[] numbers1 = new int[] { 5, 8, 9, 11 };
            int[] numbers2 = new int[] { 5, 6, 9, 2 };
            var numbers3 = numbers1.Concat(numbers2);
            var numbers6 = numbers1.Union(numbers2);
            var numbers7 = numbers1.Distinct();


            var numbers4 = new List<int> { 5, 8, 9, 11 };
            var numbers5 = numbers4.Where(x => x < 9);
            var res = numbers4.Except(numbers5);
        }
    }
}
