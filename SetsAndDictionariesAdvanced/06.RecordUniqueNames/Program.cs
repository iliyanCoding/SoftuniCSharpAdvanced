using System;
using System.Collections.Generic;

namespace _06.RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> setOfNames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string currName = Console.ReadLine();
                setOfNames.Add(currName);
            }

            foreach (var name in setOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
