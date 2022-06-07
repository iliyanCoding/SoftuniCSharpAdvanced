using System;
using System.Collections.Generic;

namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentsDictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!continentsDictionary.ContainsKey(continent))
                {
                    continentsDictionary.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentsDictionary[continent].ContainsKey(country))
                {
                    continentsDictionary[continent][country] = new List<string>();
                }

                continentsDictionary[continent][country].Add(city);

                
            }

            foreach (var continent in continentsDictionary)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"\t{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
