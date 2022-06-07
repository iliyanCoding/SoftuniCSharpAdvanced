using System;

namespace _01.ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Action<string> printWords = word => Console.WriteLine(word);
            foreach (var word in input)
            {
                printWords(word);
            }
        }
    }
}
