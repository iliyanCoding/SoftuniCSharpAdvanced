using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            Predicate<string> filterByLength = x => x.Length <= length;

            Console.ReadLine()
                .Split()
                .Where(s => filterByLength(s))
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
