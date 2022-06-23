using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numsLength = numbers.Count();
            Action<List<int>> reverseList = list => list.Reverse();
            reverseList(numbers);
            
            int n = int.Parse(Console.ReadLine());
            Predicate<int> divisibleByN = num => num % n == 0;

            List<int> result = new List<int>();
            foreach (var num in numbers)
            {
                if (!divisibleByN(num))
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(String.Join(' ', result));
        }
    }
}
