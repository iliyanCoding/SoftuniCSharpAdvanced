using System;
using System.Linq;

namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parser = x => int.Parse(x);
            int[] nums = input.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();
            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }
    }
}
