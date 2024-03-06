using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Reflections
{
    //Task
    //Test class => Id, Name, Age 
    //List of Test class
    //objList1 and  (101, 102, 103) and (104, 105, 101) 
    // Distict() in linq

    class ReflectionExamples
    {
        //static void Main(string[] args)
        //{
        //    //Assembly
        //    var assembly = Assembly.GetExecutingAssembly();
        //    var assemblyName = assembly.FullName;
        //    System.Console.WriteLine(assemblyName);
            
        //    //Types
        //    var types = assembly.GetTypes();

        //    foreach (var type in types)
        //    {
        //        if (type.Name == "TestReflection")
        //        {
        //            System.Console.WriteLine(type.Name);

        //            //Objects Or instances
        //            var obj = Activator.CreateInstance(type);

        //            var constructors = obj.GetType().GetConstructors();

        //            //Properties
        //            var props = obj.GetType().GetProperties();

        //            foreach (var prop in props)
        //            {
        //                var value = prop.GetValue(obj, null);
        //                System.Console.WriteLine(value);
        //            }

        //            //Methods
        //            var methods = obj.GetType().GetMethods();

        //            foreach (var method in methods)
        //            {
        //                if (method.Name == "Print")
        //                {
        //                    method.Invoke(obj, null);
        //                }
        //            }
        //        }
        //    }

        //    var nexon = GetVehicle<Tata>("Tata", "Nexon", "TTL");
        //    var thar = GetVehicle<Mahindra>("Mahindra", "Thar");

        //    System.Console.ReadKey();
        //}

        static IEnumerable<T> GetVehicle<T>(string manufacturer, string vehicleType, string sub = "")
        {
            var type = typeof(T);
            var instance = Activator.CreateInstance<T>();

            foreach (var prop in type.GetProperties())
            {
                if (prop.Name == "Manufacturer")
                {
                    prop.SetValue(instance, manufacturer);
                }
                else if (prop.Name == "Type")
                {
                    prop.SetValue(instance, vehicleType);
                }
                else if (prop.Name == "SubOrganization")
                {
                    prop.SetValue(instance, sub);
                }
            }
            return new List<T>() { instance };
        }
    }
    class Tata
    {
        public string SubOrganization { get; set; }
    }

    class Mahindra
    {
        public string Manufacturer { get; set; }
        public string Type { get; set; }
    }

    class TestReflection
    {
        public int Id { get; set; } = 101;

        public void Print()
        {
            System.Console.WriteLine("Print");
        }
    }
}
