using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] currPersonArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string currPersonName = currPersonArgs[0];
                int currPersonAge = int.Parse(currPersonArgs[1]);
                Person person = new Person() { Name = currPersonName, Age = currPersonAge};
            }

            
            string conditions = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter =
                CreateFilter(conditions, ageThreshold);
            List<Person> matchingPeople = people.Where(filter).ToList();

            Action<Person> formatter = CreatePrinterFormat(format);
            PrintFilteredPeople(matchingPeople, formatter);

        }

        private static void PrintFilteredPeople(List<Person> people, Action<Person> formatter)
        {
            foreach (var person in people)
            {
                formatter(person);
            }
        }

        private static Action<Person> CreatePrinterFormat(string format)
        {
            if (format == "name age")
            {
                return p => Console.WriteLine($"{p.Name} - {p.Age}");
            }
            else if (format == "age")
            {
                return p => Console.WriteLine(p.Age);
            }
            else if (format == "name")
            {
                return p => Console.WriteLine(p.Name);
            }
            return null;
        }

        private static Func<Person, bool> CreateFilter(string conditions, int ageThreshold)
        {
            if (conditions == "older")
            {
                return p => p.Age >= ageThreshold;   
            }
            else if (conditions == "younger")
            {
                return p => p.Age <= ageThreshold;
            }
            return null;
        }

        class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }

    }
}
