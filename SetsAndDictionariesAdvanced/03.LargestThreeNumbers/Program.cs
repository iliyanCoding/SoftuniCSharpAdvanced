using System;
using System.Linq;

namespace _03.LargestThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).Take(3).ToArray();
            Console.WriteLine(String.Join(' ', nums));
        }
    }
}
