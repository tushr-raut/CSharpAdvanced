using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Console.Lectures.Linq
{
    class LinqExample02
    {
        public readonly List<Department> departments;
        public readonly List<Employee> employees;

        public LinqExample02()
        {
            departments = new List<Department>
            {
                new Department(1, "IT"),
                new Department(2, "Accounts"),
                new Department(3, "HR"),
                new Department(4, "Facility"),
                new Department(5, "Admin"),
            };
            employees = new List<Employee>
            {
                new Employee(102, "John2", 26, new DateOnly(1, 1, 2001), 9000, new List<int> {1}),
                new Employee(103, "John3", 44, new DateOnly(1, 1, 2001), 20000, new List<int> {1, 2}),
                new Employee(105, "John5", 33, new DateOnly(21, 10, 1991), 15000, new List<int> {4, 5}),
                new Employee(101, "John1", 32, new DateOnly(1, 1, 2001), 10000, new List<int> {1}),
                new Employee(104, "John4", 55, new DateOnly(3, 3, 1999), 12000, new List<int> {2, 3}),
            };
        }

        public void Execute()
        {
            //Aggregate operators
            var res1 = employees.Min(x => x.Salary == 9000);
            var res2 = employees.Sum(x => x.Salary);
            var res3 = employees.Count;
            var res4 = employees.Count(x => x.Salary > 9000);
            var res5 = employees.Average(x => x.Salary);

            //Ordering operators
            var res6 = employees.OrderBy(x => x.DateOfBirth)
                                  .Select(x => new { x.Id, x.DateOfBirth }).ToList();

            var res7 = employees.OrderBy(x => x.DateOfBirth)
                                  .ThenBy(x => x.Id)
                                  .Select(x => new { x.Id, x.DateOfBirth }).ToList();

            //Projection operators
            var res8 = employees.Select(x => x.Id);

            var res9 = employees.Select(x => new { x.Id, x.Name });

            var res10 = employees.Select(x => new Employee(x.Id, x.Name));

            var res11 = employees.Select(x => x.DeptIds).Count();
            var res12 = employees.SelectMany(x => x.DeptIds).Count();

            //Conversion operators
            var res13 = employees.Select(x => new { x.Id, x.Name }).ToDictionary(s => s.Id, s => s.Name);

            var res14 = employees.OrderBy(x => x.DateOfBirth)
                                  .Select(x => new { x.Id, x.DateOfBirth }).ToList();

            var res15 = employees.OrderBy(x => x.DateOfBirth)
                                  .ThenBy(x => x.Id)
                                  .Select(x => new { x.Id, x.DateOfBirth }).ToList();



            //Inner join
            var res16 = from emp
                       in employees
                       join dept
                       in departments
                       on emp.Id equals dept.Id
                       select new { emp.Id, emp.Name };
        }
    }

    public class Employee
    {
        public List<int> Ids { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Salary { get; set; }
        public IEnumerable<int> DeptIds { get; set; }

        public Employee(int id, string name, int age, DateOnly dob, int salary, IEnumerable<int> deptIds)
        {
            Id = id;
            Name = name;
            Age = age;
            DateOfBirth = dob.ToDateTime();
            Salary = salary;
            DeptIds = deptIds;
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public static class ExtendDateTime
    {
        public static DateOnly ToDateOnly(this DateTime dateTime)
        {
            return new DateOnly(dateTime.Day, dateTime.Month, dateTime.Year);
        }

        public static DateTime ToDateTime(this DateOnly date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }
    }

    public class DateOnly
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public DateOnly(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
}
