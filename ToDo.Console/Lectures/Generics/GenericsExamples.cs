using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Generics
{
    class GenericsExamples
    {
        //static void Main(string[] args)
        //{
        //    System.Console.WriteLine("************************************ Generic class ************************************");
        //    Test<string> test1 = new Test<string>();
        //    test1.value = "Test";

        //    System.Console.WriteLine(test1.value);

        //    Test<int> test2 = new Test<int>();
        //    test2.value = 23;

        //    System.Console.WriteLine(test2.value);

        //    System.Console.WriteLine("************************************ Generic methods ************************************");

        //    int num1 = 2;
        //    int num2 = 3;

        //    System.Console.WriteLine("Before: {0}, {1}", num1, num2);

        //    Test2.Swap<int>(ref num1, ref num2);

        //    System.Console.WriteLine("After: {0}, {1}", num1, num2);

        //    System.Console.WriteLine("************************************ Generic methods: Serialize ************************************");

        //    User user = new User(101, "Tushar");
        //    var str1 = Test2.Serialize<User>(user);

        //    Admin admin = new Admin(101, "Admin");
        //    var str2 = Test2.Serialize<Admin>(admin);

        //    var userObj = Test2.Deserialize<User>(str1);

        //    System.Console.WriteLine(userObj.Id);
        //    System.Console.WriteLine(userObj.Name);

        //    var adminObj = Test2.Deserialize<Admin>(str2);

        //    System.Console.WriteLine(adminObj.Id);
        //    System.Console.WriteLine(adminObj.Name);


        //    System.Console.WriteLine(str1);
        //    System.Console.WriteLine(str2);

        //    System.Console.ReadKey();
        //}
    }

    class Test<T>
    {
        private T data;

        public T value
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }
    }

    class Test2
    {
        public static string Serialize<T>(T data)
        {
            var str = JsonConvert.SerializeObject(data);
            return str;
        }

        public static T Deserialize<T>(string data)
        {
            var res = JsonConvert.DeserializeObject<T>(data);
            return res;
        }

        public static void Swap<T>(ref T num1, ref T num2)
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Admin(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }


    interface IMonth<T>
    {
        T GetDays();
        T GetWeeks();
    }

    class Jan : IMonth<int>
    {
        public int GetDays()
        {
            return 31;
        }

        public int GetWeeks()
        {
            return 5;
        }
    }

    class Feb : IMonth<string>
    {
        public string GetDays()
        {
            return "29";
        }

        public string GetWeeks()
        {
            return "4";
        }
    }
}
