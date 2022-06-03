using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ApliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Func<List<int>, List<int>> add = list => list.Select(number => number += 1).ToList();
            Func<List<int>, List<int>> multiply = list => list.Select(number => number  *= 2).ToList();
            Func<List<int>, List<int>> subtract = list => list.Select(number => number  -= 1).ToList();
            Action<List<int>> print = list => Console.WriteLine(String.Join(' ', list));

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "add")
                {
                    numbers = add(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }
                else if (command == "end")
                {
                    break;
                }
            }
        }
    }
}
