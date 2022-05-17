using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            List<int> list = new List<int>();
            foreach (var num in queue)
            {
                if (num % 2 == 0)
                {
                    list.Add(num);
                }
            }
            Console.WriteLine(String.Join(", ", list));
        }
    }
}
