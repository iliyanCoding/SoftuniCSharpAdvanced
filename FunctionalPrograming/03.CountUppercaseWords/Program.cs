using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Predicate<string> isUppercase = s => s[0] == s.ToUpper()[0];
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x => isUppercase(x)).ToArray();
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
