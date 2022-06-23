using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                string[] currClothingSplit = input[1].Split(',');
                for (int j = 0; j < currClothingSplit.Length; j++)
                {
                    
                    string currClothing = currClothingSplit[j];
                    if (wardrobe[color].ContainsKey(currClothing))
                    {
                        wardrobe[color][currClothing]++;
                    }
                    else
                    {
                        wardrobe[color].Add(currClothing, 1);
                    }
                    
                }
            }

            string[] neededWardrobe = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string neededColor = neededWardrobe[0];
            string neededCloth = neededWardrobe[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    if (color.Key == neededColor && cloth.Key == neededCloth)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }

        }
    }
}
