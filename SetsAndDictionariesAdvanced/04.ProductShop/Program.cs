using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopsDictionary = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Revision")
                {
                    break;
                }
                else
                {
                    string[] prices = input.Split(", ");
                    string shop = prices[0];
                    string product = prices[1];
                    double price = double.Parse(prices[2]);
                    if (!shopsDictionary.ContainsKey(shop))
                    {
                        shopsDictionary.Add(shop, new Dictionary<string, double>());
                    }
                    shopsDictionary[shop].Add(product, price);
                }
            }
            var orderedShops = shopsDictionary.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var shop in orderedShops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
                
            }
        }

   
    }
}
