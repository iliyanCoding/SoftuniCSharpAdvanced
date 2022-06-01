using System;
using System.Linq;

namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] pricesWithoutVAT = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            Func<double, double> addVAT = x => x * 1.20;
            foreach (var price in pricesWithoutVAT)
            {
                Console.WriteLine($"{addVAT(price):f2}");
            }
        }
    }
}
