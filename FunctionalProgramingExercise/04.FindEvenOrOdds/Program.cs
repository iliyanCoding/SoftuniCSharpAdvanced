using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvenOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            int startIndex = int.Parse(input.Split(' ')[0]);
            int endIndex = int.Parse(input.Split(' ')[1]);
            List<int> numbers = new List<int>();
            
            for (int i = startIndex; i <= endIndex; i++)
            {
                numbers.Add(i);
            }

            string type = Console.ReadLine();
            Predicate<int> predicate = null;
            if (type == "even")
            {
                predicate = num => num % 2 == 0;
            }
            else if (type == "odd")
            {
                predicate = num => num % 2 != 0;
            }

            Console.WriteLine(string.Join(' ', numbers.FindAll(predicate)));
        }
    }
}
