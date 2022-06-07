using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
                firstSet.Add(int.Parse(Console.ReadLine()));
            for (int i = 0; i < m; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (firstSet.Contains(currNum))
                {
                    secondSet.Add(currNum);
                }
            }

            Console.WriteLine(String.Join(" ", secondSet));
                
        }
    }
}
