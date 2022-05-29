using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalEl = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                for (int h = 0; h < input.Length; h++)
                {
                    chemicalEl.Add(input[h]);
                }
            }
            chemicalEl.OrderBy(x => x);
            Console.WriteLine(string.Join(' ', chemicalEl));
        }
    }
}
