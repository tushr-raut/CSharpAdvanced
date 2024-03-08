using System;
using System.Collections.Generic;

namespace AdvanceCSharp.Console.Lectures.Delegates
{
    public class DelegatesPracticeExample
    {
        //Write a program to categorise the persons
        //in 1. Child ( < 18 ) 2. Adult ( >= 18 && < 60) 3. Senior ( >= 60 ) categories
        //var list = new List<Person>
        //{
        //  new Person("John", 60),
        //  new Person("Jenny", 30),
        //  new Person("Sean", 25),
        //  new Person("Hilde", 18),
        //  new Person("Arve", 62),
        //  new Person("Ida", 15)
        //}
        public static void Execute()
        {
            var persons = new List<Person>
            {
              new Person("John", 60),
              new Person("Jenny", 30),
              new Person("Sean", 25),
              new Person("Hilde", 18),
              new Person("Arve", 62),
              new Person("Ida", 15),
              new Person("OJ", 76),
            };

            CategorisePersons(persons, "Childrens", IsChild);
            CategorisePersons(persons, "Adults", IsAdult);
            CategorisePersons(persons, "Seniors", IsSenior);

            System.Console.ReadKey();
        }

        public static void CategorisePersons(List<Person> persons, string title, Predicate<Person> filterDelegate)
        {
            System.Console.WriteLine(title);
            foreach (var person in persons)
            {
                if (filterDelegate(person))
                {
                    System.Console.WriteLine("{0}, {1}", person.Name, person.Age);
                }
            }
        }

        public static bool IsChild(Person person)
        {
            return person.Age <= 18;
        }

        public static bool IsAdult(Person person)
        {
            return person.Age > 18 && person.Age < 60;
        }

        public static bool IsSenior(Person person)
        {
            return person.Age >= 60;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}