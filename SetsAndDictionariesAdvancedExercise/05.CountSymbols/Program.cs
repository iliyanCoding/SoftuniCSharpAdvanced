using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charInput = input.ToCharArray();
            SortedDictionary<char, int> occurrences = new SortedDictionary<char, int>();
            for (int i = 0; i < charInput.Length; i++)
            {
                char currChar = charInput[i];
                if (occurrences.ContainsKey(currChar))
                {
                    occurrences[currChar]++;
                }
                else
                {
                    occurrences.Add(currChar, 1);
                }
            }
            

            foreach (var symbol in occurrences)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
