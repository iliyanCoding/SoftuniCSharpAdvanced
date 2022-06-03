using System;

namespace _02.KnightsOfHonour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] knights = Console.ReadLine().Split(' ');
            Action<string> printKnights = knight => Console.WriteLine($"Sir {knight}");
            foreach (var knight in knights)
            {
                printKnights(knight);
            }
        }
    }
}
